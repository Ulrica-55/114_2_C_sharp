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
        // 存放讀入之「學號, 分數」對的欄位（供顯示用）
        // 讀取時會填入，DisplayScores 會使用此集合把每筆資料顯示在 ListBox 上（格式："學號 空格 分數"）
        private List<Tuple<string, int>> studentRecords = new List<Tuple<string, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        // 按下「讀取成績」按鈕的處理：維持原有流程（建立 scoresList、呼叫 ReadScores、DisplayScores、計算平均、顯示高於/低於平均人數）
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // To hold the average score
            int numAboveAverage;    // Number of above average scores
            int numBelowAverage;    // Number of below average scores

            // Create a List to hold the scores.
            List<int> scoresList = new List<int>();

            // Read the scores from the file into the List.
            ReadScores(scoresList);

            // Display the scores.
            DisplayScores(scoresList);

            // Display the average score.
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // 按下「離開」按鈕
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        /// <summary>
        /// 從檔案讀取學號與分數，並把數值分別填入 scoresList（只放分數以供計算）以及 studentRecords（放學號與分數以供顯示）。
        /// 檔案格式預期為： "學號" 空白 "分數" （例如：A114221055 54）
        /// - 若檔案不存在或解析某行失敗，會顯示友善訊息但繼續處理其餘行。
        /// </summary>
        /// <param name="scoresList">呼叫端用來接收純分數的 List（會在此方法中清除並填入）</param>
        private void ReadScores(List<int> scoresList)
        {
            // 清除傳入的 scoresList 與內部 studentRecords（避免重複加入）
            scoresList.Clear();
            studentRecords.Clear();

            // 檔名：放在應用程式啟動目錄的 TestScores.txt（若需要不同路徑可在此修改）
            string fileName = Path.Combine(Application.StartupPath, "TestScores.txt");

            if (!File.Exists(fileName))
            {
                MessageBox.Show("找不到檔案： " + fileName + Environment.NewLine + "請確認 TestScores.txt 已放在應用程式執行目錄。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parseErrors = new List<string>();

            try
            {
                // 逐行讀取檔案
                string[] lines = File.ReadAllLines(fileName, Encoding.Default);

                for (int i = 0; i < lines.Length; i++)
                {
                    string raw = lines[i].Trim();

                    // 忽略空行
                    if (string.IsNullOrEmpty(raw))
                        continue;

                    // 以空白分隔（允許多重空白）
                    string[] tokens = raw.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                    // 期待至少兩個 token：學號 與 分數
                    if (tokens.Length < 2)
                    {
                        parseErrors.Add($"第 {i + 1} 行格式錯誤：\"{raw}\"");
                        continue;
                    }

                    // 學號取第一個 token，分數取最後一個 token（容許學號中出現非預期空白時仍能取得分數）
                    string studentId = tokens[0];
                    string scoreToken = tokens[tokens.Length - 1];

                    int score;
                    if (!int.TryParse(scoreToken, out score))
                    {
                        parseErrors.Add($"第 {i + 1} 行分數無法解析：\"{raw}\"");
                        continue;
                    }

                    // 成功解析：加入純分數至 scoresList，並加入學號/分數對至 studentRecords
                    scoresList.Add(score);
                    studentRecords.Add(Tuple.Create(studentId, score));
                }

                // 若有解析錯誤，顯示簡短提示（不阻斷主流程）
                if (parseErrors.Count > 0)
                {
                    var msg = new StringBuilder();
                    msg.AppendLine("讀檔過程發現部分資料格式有誤，已略過該筆：");
                    foreach (var e in parseErrors.Take(10)) // 最多示 10 筆錯誤
                    {
                        msg.AppendLine(e);
                    }
                    if (parseErrors.Count > 10)
                        msg.AppendLine("... (省略其餘錯誤)");
                    MessageBox.Show(msg.ToString(), "讀檔警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // 讀檔或解析發生未預期的錯誤
                MessageBox.Show("讀取檔案時發生錯誤：" + Environment.NewLine + ex.Message, "讀檔錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 將 studentRecords 內容顯示在 ListBox 中，每一列以 "學號 空格 分數" 格式呈現。
        /// 若 studentRecords 為空，會顯示空的 ListBox（維持原有顯示邏輯）。
        /// </summary>
        /// <param name="scoresList">傳入以維持原呼叫介面（不直接使用此參數做顯示）</param>
        private void DisplayScores(List<int> scoresList)
        {
            // 清除 ListBox 內容（避免重複）
            testScoresListBox.Items.Clear();

            // 若有 studentRecords，逐筆加入 ListBox（格式："學號 分數"）
            foreach (var rec in studentRecords)
            {
                string line = $"{rec.Item1} {rec.Item2}";
                testScoresListBox.Items.Add(line);
            }
        }

        /// <summary>
        /// 計算分數平均（若無分數則回傳 0）
        /// </summary>
        /// <param name="scoresList">分數清單</param>
        /// <returns>平均（double）</returns>
        private double Average(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0.0;

            double sum = scoresList.Sum();
            return sum / scoresList.Count;
        }

        /// <summary>
        /// 計算高於平均的分數數量（strictly greater than average）
        /// </summary>
        /// <param name="scoresList">分數清單</param>
        /// <param name="averageScore">平均分數</param>
        /// <returns>高於平均的人數</returns>
        private int AboveAverage(List<int> scoresList, double averageScore)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            return scoresList.Count(s => s > averageScore);
        }

        /// <summary>
        /// 計算低於平均的分數數量（strictly less than average）
        /// 注意：此方法會自行計算平均（和程式原本呼叫方式相符：只傳 scoresList）
        /// </summary>
        /// <param name="scoresList">分數清單</param>
        /// <returns>低於平均的人數</returns>
        private int BelowAverage(List<int> scoresList)
        {
            if (scoresList == null || scoresList.Count == 0)
                return 0;

            double avg = Average(scoresList);
            return scoresList.Count(s => s < avg);
        }
    }
}
