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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 用於儲存最後選擇的檔案路徑，方便搜尋功能復用
        private string lastSelectedFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 平均分數
            int numAboveAverage;    // 高於平均的人數
            int numBelowAverage;    // 低於平均的人數

            // 建立 List 以保存分數
            List<int> scoresList = new List<int>();

            // 使用檔案選擇對話框讓使用者選擇分數檔案
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇分數檔案";
                ofd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Multiselect = false;

                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    // 使用者取消選擇
                    return;
                }

                // 儲存選定的檔案路徑供後續使用
                lastSelectedFilePath = ofd.FileName;

                // 從選定的檔案讀取分數
                ReadScores(scoresList, ofd.FileName);
            }

            // 若無法讀取任何分數，提示使用者並返回
            if (scoresList.Count == 0)
            {
                MessageBox.Show("未能讀取任何有效的分數。", "無資料", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 顯示分數（帶編號）
            DisplayScores(scoresList);

            // 計算並顯示平均分數
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 計算並顯示高於平均的人數
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 計算並顯示低於平均的人數
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        /// <summary>
        /// 搜尋文字方塊的 KeyPress 事件處理器
        /// 使用者在搜尋文字方塊中輸入整數分數，按 Enter 鍵後：
        ///  - 若找到，輸出「找到於第 X 個位置」（採 1-based 位置），並自動選取 ListBox 中對應項目（若存在）。
        ///  - 若找不到，顯示「分數不存在」。
        ///  - 若輸入非有效整數，顯示提示「請輸入有效整數」。
        ///  - 若尚未選擇檔案，提示使用者先使用「取得成績」按鈕選擇檔案。
        /// </summary>
        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只有當使用者按下 Enter 鍵時才執行搜尋
            if (e.KeyChar != (char)Keys.Return)
            {
                return;
            }

            // 標記為已處理，避免系統發出聲音
            e.Handled = true;

            // 檢查是否曾選過檔案
            if (string.IsNullOrEmpty(lastSelectedFilePath))
            {
                searchResultLabel.Text = "請先按「取得成績」選擇檔案";
                return;
            }

            // 取得使用者輸入
            string input = searchTextBox.Text.Trim();

            // 驗證輸入是否為整數
            int targetScore;
            if (!int.TryParse(input, out targetScore))
            {
                // 非法輸入：顯示錯誤訊息於 searchResultLabel
                searchResultLabel.Text = "請輸入有效整數";
                return;
            }

            // 讀取分數到 List（使用已選擇的檔案路徑）
            List<int> scoresList = new List<int>();
            ReadScores(scoresList, lastSelectedFilePath);

            // 若無法讀取任何分數
            if (scoresList.Count == 0)
            {
                searchResultLabel.Text = "無法讀取分數資料";
                return;
            }

            // 搜尋分數：找第一個符合的索引（0-based）
            int foundIndex = scoresList.IndexOf(targetScore);

            if (foundIndex >= 0)
            {
                // 成功：顯示 1-based 位置
                int position = foundIndex + 1;
                searchResultLabel.Text = $"找到於第 {position} 個位置";

                // 如果 ListBox 已顯示分數，嘗試選取該項（避免例外，確認索引在範圍內）
                if (foundIndex < testScoresListBox.Items.Count)
                {
                    testScoresListBox.SelectedIndex = foundIndex;
                }
            }
            else
            {
                // 未找到
                searchResultLabel.Text = "分數不存在";
                testScoresListBox.ClearSelected();
            }
        }

        /// <summary>
        /// 從指定檔案路徑讀取分數並加入傳入的 List。
        /// 若檔案不存在或讀取發生錯誤，會顯示訊息框。
        /// 每一行以 int.TryParse 驗證，非整數行會被略過。
        /// </summary>
        /// <param name="scoresList">用來放入讀取到分數的 List</param>
        /// <param name="filePath">分數檔案路徑</param>
        private void ReadScores(List<int> scoresList, string filePath)
        {
            // 清空現有內容
            scoresList.Clear();

            try
            {
                if (!File.Exists(filePath))
                {
                    // 若檔案不存在，顯示提示
                    MessageBox.Show($"找不到檔案：{filePath}", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        if (line.Length == 0)
                        {
                            continue; // 忽略空行
                        }

                        int value;
                        if (int.TryParse(line, out value))
                        {
                            scoresList.Add(value);
                        }
                        else
                        {
                            // 若非整數，略過該行
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 若發生例外，顯示訊息
                MessageBox.Show($"讀取分數檔案時發生錯誤：{ex.Message}", "讀取錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 將分數及其編號（1-based）顯示在畫面的 ListBox 上。
        /// 格式為「編號. 分數」（例如「1. 85」、「2. 92」等）
        /// 會先清除 ListBox 內容，再逐筆加入。
        /// </summary>
        /// <param name="scoresList">欲顯示的分數清單</param>
        private void DisplayScores(List<int> scoresList)
        {
            testScoresListBox.Items.Clear();

                // 使用索引遍歷，以便加入編號（1-based）
            for (int i = 0; i < scoresList.Count; i++)
            {
                int itemNumber = i + 1;  // 編號（1-based）
                int score = scoresList[i];
                testScoresListBox.Items.Add($"{itemNumber}. {score}");
            }
        }

        /// <summary>
        /// 計算分數清單的平均值（若清單為空，回傳 0）。
        /// </summary>
        /// <param name="scoresList">分數清單</param>
        /// <returns>平均分數（double）</returns>
        private double Average(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0.0;
            }

            // 使用 LINQ Average 取得平均值
            return scoresList.Average();
        }

        /// <summary>
        /// 計算高於指定平均值的成績數量。
        /// </summary>
        /// <param name="scoresList">分數清單</param>
        /// <param name="average">比較用的平均值</param>
        /// <returns>大於 average 的分數數量</returns>
        private int AboveAverage(List<int> scoresList, double average)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0;
            }

            // 計算大於平均值的項目數
            return scoresList.Count(s => s > average);
        }

        /// <summary>
        /// 計算低於平均值的成績數量。
        /// 注意：此方法會自行呼叫 Average 以取得平均值（符合原呼叫簽章）。
        /// </summary>
        /// <param name="scoresList">分數清單</param>
        /// <returns>小於平均值的分數數量</returns>
        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
            {
                return 0;
            }

            // 呼叫 Average 方法來計算平均值
            double avg = Average(scoresList);

            // 計算小於平均值的項目數
            return scoresList.Count(s => s < avg);
        }
    }
}
