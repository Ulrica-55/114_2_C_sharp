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
        // 平均值方法：接受一個 int 陣列，回傳 double 型的平均值（若陣列為空回傳 0）。
        private double Average(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (int s in scores)
            {
                sum += s;
            }

            return sum / scores.Length;
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        // 最大值方法：接受一個 int 陣列，回傳陣列中的最大整數（若陣列為空回傳 0）。
        private int Highest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            int high = scores[0];
            foreach (int s in scores)
            {
                if (s > high)
                {
                    high = s;
                }
            }

            return high;
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        // 最小值方法：接受一個 int 陣列，回傳陣列中的最小整數（若陣列為空回傳 0）。
        private int Lowest(int[] scores)
        {
            if (scores == null || scores.Length == 0)
            {
                return 0;
            }

            int low = scores[0];
            foreach (int s in scores)
            {
                if (s < low)
                {
                    low = s;
                }
            }

            return low;
        }

        // 按下「計算成績」按鈕時的處理：嘗試從名為 TestScores.txt 的檔案讀取分數（每行一個分數）。
        // 若檔案不存在或格式錯誤會顯示錯誤訊息；成功讀取後把分數顯示在 ListBox，並顯示最高、最低與平均分數。
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 預設檔案名稱（放在執行檔同目錄）；如需不同檔案請修改此路徑或改用 OpenFileDialog。
            string fileName = "TestScores.txt";

            if (!File.Exists(fileName))
            {
                MessageBox.Show("找不到檔案：" + fileName, "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> scores = new List<int>();

            try
            {
                // 逐行讀取並解析為整數（忽略空白行）
                foreach (string line in File.ReadAllLines(fileName))
                {
                    string trimmed = line.Trim();
                    if (string.IsNullOrEmpty(trimmed))
                    {
                        continue;
                    }

                    // 嘗試解析整數；如果格式錯誤拋出例外以提示使用者
                    int value;
                    if (!int.TryParse(trimmed, out value))
                    {
                        throw new FormatException("無法解析成整數：" + trimmed);
                    }

                    scores.Add(value);
                }

                // 清除 ListBox 並加入剛讀取到的分數
                this.testScoresListBox.Items.Clear();
                foreach (int s in scores)
                {
                    this.testScoresListBox.Items.Add(s.ToString());
                }

                int[] scoresArray = scores.ToArray();

                // 計算並顯示最高、最低與平均分數（平均保留 2 位小數顯示）
                this.highScoreLabel.Text = Highest(scoresArray).ToString();
                this.lowScoreLabel.Text = Lowest(scoresArray).ToString();
                this.averageScoreLabel.Text = Average(scoresArray).ToString("F2");
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息（包含例外內容），方便除錯
                MessageBox.Show("讀取或解析檔案時發生錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
