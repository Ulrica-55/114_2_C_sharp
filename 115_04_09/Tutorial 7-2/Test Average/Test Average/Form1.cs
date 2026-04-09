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
        // 平均值計算：傳回 double，若陣列為 null 或長度為 0 則回傳 0
        private double Average(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0.0;
            }

            double sum = 0.0;
            foreach (int s in scores)
            {
                sum += s;
            }

            return sum / scores.Length;
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        // 最高分計算：若陣列為 null 或長度為 0 則回傳 0
        private int Highest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            int max = scores[0];
            foreach (int s in scores)
            {
                if (s > max)
                {
                    max = s;
                }
            }

            return max;
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        // 最低分計算：若陣列為 null 或長度為 0 則回傳 0
        private int Lowest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            int min = scores[0];
            foreach (int s in scores)
            {
                if (s < min)
                {
                    min = s;
                }
            }

            return min;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {   
            // 清除舊資料
            testScoresListBox.Items.Clear();
            highScoreLabel.Text = string.Empty;
            lowScoreLabel.Text = string.Empty;
            averageScoreLabel.Text = string.Empty;

            // 預期在執行檔目錄下有名為 TestScores.txt 的檔案，每行一個整數分數
            string path = Path.Combine(Application.StartupPath, "TestScores.txt");

            if (!File.Exists(path))
            {
                MessageBox.Show("找不到檔案：TestScores.txt。\n請將檔案放在應用程式執行目錄。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(path);
                var scoresList = new List<int>();

                foreach (string line in lines)
                {
                    string trimmed = line.Trim();
                    if (trimmed.Length == 0)
                    {
                        continue; // 跳過空行
                    }

                    if (int.TryParse(trimmed, out int value))
                    {
                        scoresList.Add(value);
                        testScoresListBox.Items.Add(value); // 將分數加入列表顯示
                    }
                    else
                    {
                        // 若遇到非整數行則略過（也可以顯示警告）
                        // 這裡選擇略過以耐受錯誤輸入
                    }
                }

                if (scoresList.Count == 0)
                {
                    MessageBox.Show("檔案中未找到可解析的分數。", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] scores = scoresList.ToArray();

                // 計算並顯示最高、最低、平均（平均顯示兩位小數）
                highScoreLabel.Text = Highest(scores).ToString();
                lowScoreLabel.Text = Lowest(scores).ToString();
                averageScoreLabel.Text = Average(scores).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取或處理檔案時發生錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
