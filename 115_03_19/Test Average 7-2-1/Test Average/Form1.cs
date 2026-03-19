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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        // 註解（繁體中文）：計算陣列中所有分數的平均值，若陣列為 null 或長度為 0 則回傳 0。
        private double Average(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0.0;
            }

            int sum = 0;
            foreach (int s in scores)
            {
                sum += s;
            }

            return (double)sum / scores.Length;
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        // 註解（繁體中文）：回傳陣列中的最高分，若陣列為 null 或空則回傳 0。
        private int Highest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            int max = scores[0];
            foreach (int s in scores)
            {
                if (s > max) max = s;
            }

            return max;
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        // 註解（繁體中文）：回傳陣列中的最低分，若陣列為 null 或空則回傳 0。
        private int Lowest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            int min = scores[0];
            foreach (int s in scores)
            {
                if (s < min) min = s;
            }

            return min;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 清除先前顯示
            testScoresListBox.Items.Clear();
            highScoreLabel.Text = string.Empty;
            lowScoreLabel.Text = string.Empty;
            averageScoreLabel.Text = string.Empty;

            // 以應用程式啟動目錄尋找 Scores.txt（請將 Scores.txt 放在執行檔同一資料夾）
            string path = Path.Combine(Application.StartupPath, "Scores.txt");
            if (!File.Exists(path))
            {
                MessageBox.Show("找不到 Scores.txt 檔案。請將 Scores.txt 放在應用程式目錄中。", "檔案遺失", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var scoresList = new List<int>();

            try
            {
                using (var reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Trim();
                        if (line.Length == 0) continue;

                        // 嘗試解析每一行為整數，若成功則加入列表並顯示於 ListBox
                        if (int.TryParse(line, out int value))
                        {
                            scoresList.Add(value);
                            testScoresListBox.Items.Add(value);
                        }
                        // 無法解析的行會被略過
                    }
                }

                if (scoresList.Count == 0)
                {
                    MessageBox.Show("Scores.txt 中未找到有效的分數。", "無資料", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int[] scoresArray = scoresList.ToArray();

                // 顯示最高、最低與平均（平均以小數點兩位顯示）
                highScoreLabel.Text = Highest(scoresArray).ToString();
                lowScoreLabel.Text = Lowest(scoresArray).ToString();
                averageScoreLabel.Text = Average(scoresArray).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取分數時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
