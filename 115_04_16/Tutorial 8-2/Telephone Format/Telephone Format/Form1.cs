using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 檢查輸入字串是否包含正好 10 個數字（允許輸入中含有空格或連字元，但只計算數字）
        // 回傳 true 表示有效，否則回傳 false。
        private bool IsValidNumber(string str)
        {
            // 若為 null 或空白，直接視為無效
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            // 只保留數字字元，計算數字長度
            string digitsOnly = new string(str.Where(char.IsDigit).ToArray());
            return digitsOnly.Length == 10;
        }

        // 將傳入的字串參考值格式化為電話號碼格式 (xxx) xxx-xxxx
        // 傳入的字串會先移除非數字字元，若不為 10 碼則不做變更。
        private void TelephoneFormat(ref string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return;
            }

            // 只保留數字字元
            string digitsOnly = new string(str.Where(char.IsDigit).ToArray());

            // 只在確定有 10 碼時才格式化
            if (digitsOnly.Length != 10)
            {
                return;
            }

            // 以 (XXX) XXX-XXXX 的格式組合字串
            string area = digitsOnly.Substring(0, 3);
            string prefix = digitsOnly.Substring(3, 3);
            string line = digitsOnly.Substring(6, 4);

            str = string.Format("({0}) {1}-{2}", area, prefix, line);
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入
            string number = numberTextBox.Text;

            // 驗證輸入是否為 10 碼數字（允許中間有空格或其他非數字，但會以數字數量判斷）
            if (!IsValidNumber(number))
            {
                // 若無效，顯示繁體中文錯誤訊息並將焦點回到輸入框
                MessageBox.Show("請輸入 10 碼數字（僅限數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberTextBox.Focus();
                return;
            }

            // 格式化電話字串，結果會存在 number 變數中
            TelephoneFormat(ref number);

            // 將格式化後的結果回寫到輸入框，並將游標移至結尾
            numberTextBox.Text = number;
            numberTextBox.SelectionStart = numberTextBox.Text.Length;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
