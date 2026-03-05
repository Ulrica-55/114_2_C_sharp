using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Review_Q2
{
    public partial class Form1 : Form
    {
        // 費用常數
        private const decimal OIL_CHANGE = 780m;
        private const decimal LUBE_JOB = 540m;
        private const decimal RADIATOR_FLUSH = 900m;
        private const decimal TRANSMISSION_FLUSH = 2400m;
        private const decimal INSPECTION = 450m;
        private const decimal MUFFLER = 3000m;
        private const decimal TIRE_ROTATION = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();
            // 初始化顯示
            ClearFees();
        }

        #region 費用計算方法

        // 計算機油和潤滑服務費用
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (chkChangeOil.Checked) total += OIL_CHANGE;
            if (chkLubeJob.Checked) total += LUBE_JOB;
            return total;
        }

        // 計算清洗服務費用
        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (chkRadiatorFlush.Checked) total += RADIATOR_FLUSH;
            if (chkTransmissionFlush.Checked) total += TRANSMISSION_FLUSH;
            return total;
        }

        // 計算其他維修服務費用
        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (chkInspection.Checked) total += INSPECTION;
            if (chkReplaceMuffler.Checked) total += MUFFLER;
            if (chkTireRotation.Checked) total += TIRE_ROTATION;
            return total;
        }

        // 計算零件與工時費用（回傳 tuple: parts, laborCost）
        private (decimal parts, decimal laborCost) OtherCharges()
        {
            decimal parts = 0m;
            decimal laborCost = 0m;

            if (!string.IsNullOrWhiteSpace(txtParts.Text))
            {
                decimal.TryParse(txtParts.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out parts);
            }

            if (!string.IsNullOrWhiteSpace(txtLaborHours.Text))
            {
                if (decimal.TryParse(txtLaborHours.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out decimal hours))
                {
                    laborCost = hours * LABOR_RATE_PER_HOUR;
                }
            }

            return (parts, laborCost);
        }

        // 計算稅金（僅對零件）
        private decimal TaxCharges(decimal parts)
        {
            return Math.Round(parts * PARTS_TAX_RATE, 0); // 以整數元為單位
        }

        // 計算總費用，並更新顯示
        private void TotalCharges()
        {
            // 驗證輸入
            if (!ValidateInputs()) return;

            // 各類費用
            decimal oilLube = OilLubeCharges();
            decimal flushes = FlushCharges();
            decimal misc = MiscCharges();
            var (parts, laborCost) = OtherCharges();

            decimal serviceCharges = oilLube + flushes + misc + laborCost; // 服務與工資總額
            decimal tax = TaxCharges(parts);
            decimal total = serviceCharges + parts + tax;

            // 更新 UI（使用「NT$#,##0」格式）
            lblServiceLaborValue.Text = FormatCurrency(serviceCharges);
            lblPartsSummaryValue.Text = FormatCurrency(parts);
            lblPartsTaxValue.Text = FormatCurrency(tax);
            lblTotalValue.Text = FormatCurrency(total);
        }

        private string FormatCurrency(decimal value)
        {
            // 顯示為 NT$ 與千分位，無小數
            return string.Format(CultureInfo.InvariantCulture, "NT${0:N0}", value);
        }

        #endregion

        #region 事件處理

        // 計算按鈕
        private void calculateButton_Click(object sender, EventArgs e)
        {
            TotalCharges();
        }

        // 清除按鈕
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        // 離開按鈕（會提示是否儲存）
        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否要儲存目前維修明細到檔案？", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return; // 取消離開
            }
            if (result == DialogResult.Yes)
            {
                SaveServiceDetailsToFile();
            }

            Close();
        }

        #endregion

        #region 清除功能

        private void ClearOilLube()
        {
            chkChangeOil.Checked = false;
            chkLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtParts.Text = string.Empty;
            txtLaborHours.Text = string.Empty;
        }

        private void ClearFees()
        {
            lblServiceLaborValue.Text = string.Empty;
            lblPartsSummaryValue.Text = string.Empty;
            lblPartsTaxValue.Text = string.Empty;
            lblTotalValue.Text = string.Empty;
        }

        #endregion

        #region 驗證

        // 驗證數字輸入與非負
        private bool ValidateInputs()
        {
            // 驗證零件費用
            if (!string.IsNullOrWhiteSpace(txtParts.Text))
            {
                if (!decimal.TryParse(txtParts.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out decimal parts) || parts < 0m)
                {
                    MessageBox.Show("請輸入有效且非負的零件金額（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtParts.Focus();
                    return false;
                }
            }

            // 驗證工時數
            if (!string.IsNullOrWhiteSpace(txtLaborHours.Text))
            {
                if (!decimal.TryParse(txtLaborHours.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out decimal hours) || hours < 0m)
                {
                    MessageBox.Show("請輸入有效且非負的工時數（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLaborHours.Focus();
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region 檔案輸出

        // 儲存維修明細到文字檔案（含分類、明細、計算過程）
        private void SaveServiceDetailsToFile()
        {
            // 先確保當前計算結果為最新
            if (!ValidateInputs())
            {
                return;
            }
            TotalCharges();

            using var sfd = new SaveFileDialog
            {
                Title = "儲存維修明細",
                Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*",
                FileName = $"ServiceDetails_{DateTime.Now:yyyyMMdd_HHmmss}.txt"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            var sb = new StringBuilder();
            sb.AppendLine("汽車維修服務 - 維修明細");
            sb.AppendLine($"產生時間: {DateTime.Now:F}");
            sb.AppendLine(new string('-', 60));
            sb.AppendLine("選取的服務項目：");

            if (chkChangeOil.Checked) sb.AppendLine($"- 更換機油: {FormatCurrency(OIL_CHANGE)}");
            if (chkLubeJob.Checked) sb.AppendLine($"- 潤滑保養: {FormatCurrency(LUBE_JOB)}");
            if (chkRadiatorFlush.Checked) sb.AppendLine($"- 水箱清洗: {FormatCurrency(RADIATOR_FLUSH)}");
            if (chkTransmissionFlush.Checked) sb.AppendLine($"- 變速箱清洗: {FormatCurrency(TRANSMISSION_FLUSH)}");
            if (chkInspection.Checked) sb.AppendLine($"- 檢驗: {FormatCurrency(INSPECTION)}");
            if (chkReplaceMuffler.Checked) sb.AppendLine($"- 更換消音器: {FormatCurrency(MUFFLER)}");
            if (chkTireRotation.Checked) sb.AppendLine($"- 輪胎換位: {FormatCurrency(TIRE_ROTATION)}");

            var (parts, laborCost) = OtherCharges();
            decimal serviceFees = OilLubeCharges() + FlushCharges() + MiscCharges();
            sb.AppendLine();
            sb.AppendLine("費用明細：");
            sb.AppendLine($"服務費用 (不含工時): {FormatCurrency(serviceFees)}");
            sb.AppendLine($"工時費用 ({(string.IsNullOrWhiteSpace(txtLaborHours.Text) ? "0" : txtLaborHours.Text)} 小時 × {FormatCurrency(LABOR_RATE_PER_HOUR)}): {FormatCurrency(laborCost)}");
            sb.AppendLine($"零件費用: {FormatCurrency(parts)}");
            decimal tax = TaxCharges(parts);
            sb.AppendLine($"零件稅金 (6%): {FormatCurrency(tax)}");
            decimal total = (serviceFees + laborCost) + parts + tax;
            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"總費用: {FormatCurrency(total)}");

            try
            {
                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("維修明細已成功儲存。", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存檔案時發生錯誤：{ex.Message}", "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
