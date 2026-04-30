using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization; // 用於數字解析（Parse/TryParse）

namespace CSV_Reader
{
    struct Student
    {
        public string Class;
        public string Id;
        public string Name;
        public int[] scores;
    }
    public partial class Form1 : Form
    {
        // 使用 struct Student 與 List<Student> 存放整個班級成績資料
        private List<Student> gradeBook = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得分數按鈕處理程序
        /// 說明（繁體中文）：
        /// - 會開啟一個檔案選擇對話方塊，讓使用者選擇 CSV 檔案。
        /// - 假設 CSV 欄位依序為：班級, 學號, 姓名, score1, score2, score3, score4, score5
        /// - 會略過第一列標頭，逐列解析 score1..score5，將資料存入 gradeBook（List<Student>），
        ///   並以「班級 空白 學號 空白 姓名 空白 平均成績(小數點兩位)」格式加入 ListBox 顯示。
        /// - 解析時會嘗試使用不依賴文化的格式 (InvariantCulture)，若失敗則嘗試系統文化解析。
        /// - 發生錯誤會以訊息框顯示錯誤原因。
        /// </summary>
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 清空顯示清單與內部資料結構，準備放入新的輸出
            this.averagesListBox.Items.Clear();
            this.gradeBook.Clear();

            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇成績 CSV 檔案";
                ofd.Filter = "CSV 檔案 (*.csv)|*.csv|所有檔案 (*.*)|*.*";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog(this) != DialogResult.OK)
                {
                    // 使用者取消選擇
                    return;
                }

                string path = ofd.FileName;

                try
                {
                    var lines = File.ReadAllLines(path, Encoding.Default);
                    if (lines.Length == 0)
                    {
                        MessageBox.Show("CSV 檔案為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 將第一列視為標頭並略過
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var line = lines[i];
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue; // 跳過空白列
                        }

                        // 簡單的 CSV 分割（不處理欄位內含逗號的情況）
                        var tokens = line.Split(',');

                        // 期待至少 8 個欄位：班級, 學號, 姓名, score1..score5
                        if (tokens.Length < 8)
                        {
                            // 若欄位不足，略過該列並記錄在 ListBox 中以利偵錯
                            this.averagesListBox.Items.Add($"格式錯誤（第 {i + 1} 列）：{line}");
                            continue;
                        }

                        // 去除多餘的空白或雙引號
                        string className = tokens[0].Trim().Trim('"');
                        string studentId = tokens[1].Trim().Trim('"');
                        string studentName = tokens[2].Trim().Trim('"');

                        // 建立 Student 並解析五個分數欄位，存為 int[]（遇到小數會四捨五入）
                        Student st = new Student();
                        st.Class = className;
                        st.Id = studentId;
                        st.Name = studentName;
                        st.scores = new int[5];

                        for (int s = 0; s < 5; s++)
                        {
                            var raw = tokens[3 + s].Trim().Trim('"');

                            // 優先嘗試解析為 double，再轉為 int（四捨五入）
                            double v;
                            if (!double.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture, out v))
                            {
                                double.TryParse(raw, NumberStyles.Float, CultureInfo.CurrentCulture, out v);
                            }

                            // 將解析結果四捨五入後存為 int；若解析失敗則視為 0
                            int intScore = (int)Math.Round(v);
                            st.scores[s] = intScore;
                        }

                        // 將解析後的 Student 加入 gradeBook
                        this.gradeBook.Add(st);
                    }

                    // 使用 gradeBook 產生輸出至 ListBox（格式：班級 學號 姓名 平均成績）
                    foreach (var st in this.gradeBook)
                    {
                        double avg = 0.0;
                        if (st.scores != null && st.scores.Length > 0)
                        {
                            avg = st.scores.Average();
                        }

                        // 輸出保留兩位小數
                        string output = string.Format("{0} {1} {2} {3}", st.Class, st.Id, st.Name, avg.ToString("F2", CultureInfo.CurrentCulture));
                        this.averagesListBox.Items.Add(output);
                    }

                    // 若沒有有效輸出，通知使用者
                    if (this.averagesListBox.Items.Count == 0)
                    {
                        MessageBox.Show("未從 CSV 讀取到有效資料。請確認檔案格式是否正確。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // 讀檔或解析發生例外時，顯示錯誤訊息
                    MessageBox.Show("讀取或解析 CSV 檔案時發生錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
