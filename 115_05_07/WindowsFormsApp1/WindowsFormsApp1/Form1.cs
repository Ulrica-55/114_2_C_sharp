using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 7. 程式狀態變數
        private Random rand = new Random();
        private int n1 = 0, n2 = 0, n3 = 0; // 三個轉輪索引（0~9）
        private int prize = 0; // 本次旋轉獎金（初始 0）
        private int balance = 0; // 目前餘額（初始 0）
        private int totalDeposited = 0; // 累計存入（初始 0）
        private int totalSpins = 0; // 累計旋轉次數（初始 0）
        private int winCount = 0; // 累計中獎次數（初始 0）

        // 旋轉動畫變數（A.4）
        private System.Windows.Forms.Timer spinTimer;
        private int spinTick = 0;
        private int lastBet = 0; // 本次下注金額（動畫結束後 checkWinner 使用）
        private bool pb1Stopped = false, pb2Stopped = false, pb3Stopped = false;

        // 停止門檻常數（A.4）
        private const int TICKS_STOP_PB1 = 10; // 第一輪停止門檻
        private const int TICKS_STOP_PB2 = 17; // 第二輪停止門檻
        private const int TICKS_STOP_PB3 = 24; // 第三輪停止門檻

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        // 8. 方法職責 - Form1_Load：程式啟動
        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化下注選項；固定選項並預設 $1
            comboBox_bet.Items.Clear();
            comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$50" });
            comboBox_bet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_bet.SelectedIndex = 0;
            comboBox_bet.SelectedIndexChanged += ComboBox_bet_SelectedIndexChanged;

            // 確保 imageList1 有合理尺寸
            if (imageList1.ImageSize.Width == 0 || imageList1.ImageSize.Height == 0)
            {
                imageList1.ImageSize = new Size(120, 120);
            }

            // 優先嘗試從執行目錄的 Images 資料夾載入使用者上傳的圖片（若有）
            TryLoadImagesFromOutputFolder();

            // 若沒有任何圖片，建立示範圖片到 imageList1（但不顯示於 PictureBox）
            if (imageList1.Images.Count == 0)
            {
                GenerateDemoFruitImages();
            }

            // 一開始不要顯示圖片（使用者要求）：確保三個 PictureBox 為 null
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;

            // 初始化動畫 Timer（80ms）
            spinTimer = new System.Windows.Forms.Timer();
            spinTimer.Interval = 80;
            spinTimer.Tick += SpinTimer_Tick;

            UpdateUI();
            UpdateStats();
        }

        // ComboBox 選項變更 -> 更新 UI（會判斷旋轉按鈕狀態）
        // 若動畫進行中則忽略變更（A.5）
        private void ComboBox_bet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spinTimer != null && spinTimer.Enabled) return;
            UpdateUI();
        }

        // 嘗試從 bin/.../Images 載入圖片（使用者已上傳時）
        private bool TryLoadImagesFromOutputFolder()
        {
            try
            {
                string exeFolder = Application.StartupPath;
                string imagesFolder = Path.Combine(exeFolder, "Images");
                if (!Directory.Exists(imagesFolder)) return false;

                var supportedExt = new[] { ".png", ".jpg", ".jpeg", ".bmp", ".gif" };
                var files = Directory
                    .EnumerateFiles(imagesFolder)
                    .Where(f => supportedExt.Contains(Path.GetExtension(f).ToLowerInvariant()))
                    .OrderBy(f => f)
                    .ToArray();

                if (files.Length == 0) return false;

                imageList1.Images.Clear();
                foreach (var f in files)
                {
                    try
                    {
                        using (var img = Image.FromFile(f))
                        {
                            Bitmap bmp = new Bitmap(img);
                            if (bmp.Width != imageList1.ImageSize.Width || bmp.Height != imageList1.ImageSize.Height)
                            {
                                Bitmap scaled = new Bitmap(imageList1.ImageSize.Width, imageList1.ImageSize.Height);
                                using (Graphics g = Graphics.FromImage(scaled))
                                {
                                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                    g.DrawImage(bmp, 0, 0, imageList1.ImageSize.Width, imageList1.ImageSize.Height);
                                }
                                bmp.Dispose();
                                bmp = scaled;
                            }
                            imageList1.Images.Add(bmp);
                        }
                    }
                    catch
                    {
                        // 單一檔案載入失敗就跳過
                    }
                }

                return imageList1.Images.Count > 0;
            }
            catch
            {
                return false;
            }
        }

        // 若沒有上傳圖片則產生示範圖（120x120）
        private void GenerateDemoFruitImages()
        {
            imageList1.Images.Clear();
            Color[] colors = new Color[] {
                Color.Orange, Color.Yellow, Color.Purple, Color.Red, Color.Green,
                Color.Brown, Color.LightPink, Color.Gold, Color.Cyan, Color.Magenta
            };

            for (int i = 0; i < 10; i++)
            {
                Bitmap bmp = new Bitmap(imageList1.ImageSize.Width, imageList1.ImageSize.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    using (Brush b = new SolidBrush(colors[i % colors.Length]))
                    using (Pen p = new Pen(Color.SaddleBrown, 4))
                    {
                        g.FillEllipse(b, 12, 12, bmp.Width - 24, bmp.Height - 24);
                        g.DrawEllipse(p, 12, 12, bmp.Width - 24, bmp.Height - 24);
                    }
                    using (Font f = new Font("Arial", 18, FontStyle.Bold))
                    using (Brush tb = new SolidBrush(Color.Black))
                    {
                        StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        g.DrawString((i + 1).ToString(), f, tb, new RectangleF(0, 0, bmp.Width, bmp.Height), sf);
                    }
                }
                imageList1.Images.Add(bmp);
            }
        }

        // 8. 方法職責 - GetBetAmount(): 解析 ComboBox 為整數下注額
        private int GetBetAmount()
        {
            if (comboBox_bet.SelectedItem == null) return 0;
            string s = comboBox_bet.SelectedItem.ToString().Replace("$", "").Trim();
            if (int.TryParse(s, out int bet) && bet > 0) return bet;
            return 0;
        }

        // 8. 方法職責 - getImage(): 保留原本邏輯供必要時使用（A.6）
        private void getImage()
        {
            if (imageList1.Images.Count == 0) return;
            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);

            pictureBox1.Image = imageList1.Images[n1];
            pictureBox2.Image = imageList1.Images[n2];
            pictureBox3.Image = imageList1.Images[n3];
        }

        // 8. 方法職責 - checkWinner(bet): 判斷等級、計算獎金、加回餘額
        private int checkWinner(int bet)
        {
            // 計算 prize（4.4 規則）
            if (n1 == n2 && n2 == n3)
            {
                prize = bet * 10; // 頭獎
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                prize = bet * 2; // 普獎
            }
            else
            {
                prize = 0; // 未中
            }

            if (prize > 0)
            {
                balance += prize;
                winCount++;
            }

            return prize;
        }

        // 5.1 UpdateUI: 更新餘額/本次獲得/按鈕狀態
        // 若 spinTimer.Enabled = true（動畫中）則不要重新啟用「旋轉」按鈕（A.5）
        private void UpdateUI()
        {
            label_balance.Text = "餘額：" + balance.ToString("c", CultureInfo.CurrentCulture);
            label_lastWin.Text = "本次獲得：" + prize.ToString("c", CultureInfo.CurrentCulture);

            int bet = GetBetAmount();

            // 若正在動畫中，暫時禁用按鈕與輸入元件
            if (spinTimer != null && spinTimer.Enabled)
            {
                button1.Enabled = false;
                comboBox_bet.Enabled = false;
                button_deposit.Enabled = false;
                textBox_deposit.Enabled = false;
                return;
            }

            // 4.5 / 5.1 旋轉按鈕狀態規則
            if (balance == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = (bet > 0 && balance >= bet);
            }

            // 恢復其他輸入元件
            comboBox_bet.Enabled = true;
            button_deposit.Enabled = true;
            textBox_deposit.Enabled = true;
        }

        // 5.2 UpdateStats: 旋轉完成後更新統計
        private void UpdateStats()
        {
            label_totalSpins.Text = $"旋轉：{totalSpins} 次";
            label_winCount.Text = $"中獎：{winCount} 次";
            double winRate = totalSpins == 0 ? 0.0 : (double)winCount / totalSpins * 100.0;
            label_winRate.Text = $"勝率：{winRate:0.0}%";
        }

        // 8. 方法職責 - button_deposit_Click: 驗證、更新餘額、累計存入
        private void button_deposit_Click(object sender, EventArgs e)
        {
            string txt = textBox_deposit.Text.Trim();
            if (int.TryParse(txt, out int amount) && amount > 0)
            {
                balance += amount;
                totalDeposited += amount;
                textBox_deposit.Clear();
                prize = 0;
                UpdateUI();
            }
            else
            {
                MessageBox.Show("請輸入有效的存入金額（必須為正整數）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_deposit.Focus();
            }
        }

        // 8. 方法職責 - button1_Click (旋轉): 扣款、決定結果、啟動動畫
        // 防止在動畫進行中重複觸發（A.5）
        private void button1_Click(object sender, EventArgs e)
        {
            if (spinTimer != null && spinTimer.Enabled) return; // 已在動畫中，忽略重複點擊

            int bet = GetBetAmount();
            if (bet <= 0)
            {
                MessageBox.Show("請選擇有效的下注金額。", "下注錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (balance < bet)
            {
                MessageBox.Show("餘額不足，請先存入或降低下注金額。", "餘額不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateUI();
                return;
            }

            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show("目前沒有可用的圖片，無法旋轉。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 從 balance 扣除本次下注金額（動畫期間暫時先扣）
            balance -= bet;
            lastBet = bet;

            // 在動畫開始前決定最終結果（n1, n2, n3） — 與基礎版分離（A.6）
            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);

            // 初始化動畫狀態
            spinTick = 0;
            pb1Stopped = pb2Stopped = pb3Stopped = false;

            // 立即更新 UI（按鈕狀態 / 餘額顯示）
            prize = 0;
            UpdateUI();
            UpdateStats();

            // 開始 Timer 驅動動畫
            spinTimer.Start();
        }

        // Timer Tick: 每 80ms 更新尚未停止的轉輪為隨機圖，並在指定 tick 停止各轉輪（A.3/A.4）
        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            // 每次 tick 顯示隨機圖片（尚未停止的）
            spinTick++;

            int count = imageList1.Images.Count;
            if (!pb1Stopped)
            {
                pictureBox1.Image = imageList1.Images[rand.Next(count)];
            }
            if (!pb2Stopped)
            {
                pictureBox2.Image = imageList1.Images[rand.Next(count)];
            }
            if (!pb3Stopped)
            {
                pictureBox3.Image = imageList1.Images[rand.Next(count)];
            }

            // Tick 第 10 次（約 800ms）停止第一個轉輪
            if (spinTick == TICKS_STOP_PB1 && !pb1Stopped)
            {
                pb1Stopped = true;
                pictureBox1.Image = imageList1.Images[n1];
            }

            // Tick 第 17 次（約 1360ms）停止第二個轉輪
            if (spinTick == TICKS_STOP_PB2 && !pb2Stopped)
            {
                pb2Stopped = true;
                pictureBox2.Image = imageList1.Images[n2];
            }

            // Tick 第 24 次（約 1920ms）停止第三個轉輪，結束動畫並判斷結果
            if (spinTick == TICKS_STOP_PB3 && !pb3Stopped)
            {
                pb3Stopped = true;
                pictureBox3.Image = imageList1.Images[n3];

                // 停止動畫
                spinTimer.Stop();

                // 判斷勝負並加回獎金（使用 lastBet）
                int awarded = checkWinner(lastBet);

                // 增加旋轉次數與更新介面/統計
                totalSpins++;
                UpdateStats();
                UpdateUI();

                // 清除 lastBet（非必需，但讓狀態清晰）
                lastBet = 0;
            }
        }

        // 8. 方法職責 - button2_Click: 顯示結算摘要、關閉視窗
        private void button2_Click(object sender, EventArgs e)
        {
            int netGain = balance - totalDeposited;
            string profitLabel;
            string profitAmount;
            if (netGain < 0)
            {
                profitLabel = "虧損：";
                profitAmount = Math.Abs(netGain).ToString("c", CultureInfo.CurrentCulture);
            }
            else
            {
                profitLabel = "盈餘：";
                profitAmount = netGain.ToString("c", CultureInfo.CurrentCulture);
            }

            string msg =
                $"累計存入：{totalDeposited.ToString("c", CultureInfo.CurrentCulture)}\r\n" +
                $"目前餘額：{balance.ToString("c", CultureInfo.CurrentCulture)}\r\n" +
                $"{profitLabel}{profitAmount}\r\n\r\n" +
                $"旋轉次數：{totalSpins} 次　中獎次數：{winCount} 次";

            MessageBox.Show(msg, "結算", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
