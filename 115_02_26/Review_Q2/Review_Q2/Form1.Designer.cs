namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.GroupBox groupBoxOil;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLubrication;

        private System.Windows.Forms.GroupBox groupBoxCleaning;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.CheckBox chkTransmission;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkAlignment;

        private System.Windows.Forms.GroupBox groupBoxPartsLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.TextBox txtLaborHours;

        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label lblServiceLabor;
        // Replace summary textboxes with labels
        private System.Windows.Forms.Label txtServiceLabor;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.Label txtPartsSummary;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label txtTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label txtTotal;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxOil = new GroupBox();
            chkOilChange = new CheckBox();
            chkLubrication = new CheckBox();
            groupBoxCleaning = new GroupBox();
            chkRadiator = new CheckBox();
            chkTransmission = new CheckBox();
            groupBoxOther = new GroupBox();
            chkInspection = new CheckBox();
            chkMuffler = new CheckBox();
            chkAlignment = new CheckBox();
            groupBoxPartsLabor = new GroupBox();
            lblParts = new Label();
            txtParts = new TextBox();
            lblLaborHours = new Label();
            txtLaborHours = new TextBox();
            groupBoxSummary = new GroupBox();
            lblServiceLabor = new Label();
            txtServiceLabor = new Label();
            lblPartsSummary = new Label();
            txtPartsSummary = new Label();
            lblTax = new Label();
            txtTax = new Label();
            lblTotal = new Label();
            txtTotal = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBoxOil.SuspendLayout();
            groupBoxCleaning.SuspendLayout();
            groupBoxOther.SuspendLayout();
            groupBoxPartsLabor.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOil
            // 
            groupBoxOil.Controls.Add(chkOilChange);
            groupBoxOil.Controls.Add(chkLubrication);
            groupBoxOil.Location = new Point(12, 12);
            groupBoxOil.Name = "groupBoxOil";
            groupBoxOil.Size = new Size(250, 80);
            groupBoxOil.TabIndex = 0;
            groupBoxOil.TabStop = false;
            groupBoxOil.Text = "機油和潤滑";
            // 
            // chkOilChange
            // 
            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(12, 22);
            chkOilChange.Name = "chkOilChange";
            chkOilChange.Size = new Size(190, 27);
            chkOilChange.TabIndex = 0;
            chkOilChange.Text = "更換機油 (NT$780)";
            chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubrication
            // 
            chkLubrication.AutoSize = true;
            chkLubrication.Location = new Point(12, 48);
            chkLubrication.Name = "chkLubrication";
            chkLubrication.Size = new Size(190, 27);
            chkLubrication.TabIndex = 1;
            chkLubrication.Text = "潤滑保養 (NT$540)";
            chkLubrication.UseVisualStyleBackColor = true;
            // 
            // groupBoxCleaning
            // 
            groupBoxCleaning.Controls.Add(chkRadiator);
            groupBoxCleaning.Controls.Add(chkTransmission);
            groupBoxCleaning.Location = new Point(278, 12);
            groupBoxCleaning.Name = "groupBoxCleaning";
            groupBoxCleaning.Size = new Size(250, 80);
            groupBoxCleaning.TabIndex = 1;
            groupBoxCleaning.TabStop = false;
            groupBoxCleaning.Text = "清洗服務";
            // 
            // chkRadiator
            // 
            chkRadiator.AutoSize = true;
            chkRadiator.Location = new Point(12, 22);
            chkRadiator.Name = "chkRadiator";
            chkRadiator.Size = new Size(190, 27);
            chkRadiator.TabIndex = 0;
            chkRadiator.Text = "水箱清洗 (NT$900)";
            chkRadiator.UseVisualStyleBackColor = true;
            // 
            // chkTransmission
            // 
            chkTransmission.AutoSize = true;
            chkTransmission.Location = new Point(12, 48);
            chkTransmission.Name = "chkTransmission";
            chkTransmission.Size = new Size(222, 27);
            chkTransmission.TabIndex = 1;
            chkTransmission.Text = "變速箱清洗 (NT$2,400)";
            chkTransmission.UseVisualStyleBackColor = true;
            // 
            // groupBoxOther
            // 
            groupBoxOther.Controls.Add(chkInspection);
            groupBoxOther.Controls.Add(chkMuffler);
            groupBoxOther.Controls.Add(chkAlignment);
            groupBoxOther.Location = new Point(12, 105);
            groupBoxOther.Name = "groupBoxOther";
            groupBoxOther.Size = new Size(250, 110);
            groupBoxOther.TabIndex = 2;
            groupBoxOther.TabStop = false;
            groupBoxOther.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(12, 22);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(154, 27);
            chkInspection.TabIndex = 0;
            chkInspection.Text = "機檢 (NT$450)";
            chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkMuffler
            // 
            chkMuffler.AutoSize = true;
            chkMuffler.Location = new Point(12, 48);
            chkMuffler.Name = "chkMuffler";
            chkMuffler.Size = new Size(222, 27);
            chkMuffler.TabIndex = 1;
            chkMuffler.Text = "更換消音器 (NT$3,000)";
            chkMuffler.UseVisualStyleBackColor = true;
            // 
            // chkAlignment
            // 
            chkAlignment.AutoSize = true;
            chkAlignment.Location = new Point(12, 74);
            chkAlignment.Name = "chkAlignment";
            chkAlignment.Size = new Size(190, 27);
            chkAlignment.TabIndex = 2;
            chkAlignment.Text = "輪胎定位 (NT$600)";
            chkAlignment.UseVisualStyleBackColor = true;
            // 
            // groupBoxPartsLabor
            // 
            groupBoxPartsLabor.Controls.Add(lblParts);
            groupBoxPartsLabor.Controls.Add(txtParts);
            groupBoxPartsLabor.Controls.Add(lblLaborHours);
            groupBoxPartsLabor.Controls.Add(txtLaborHours);
            groupBoxPartsLabor.Location = new Point(278, 105);
            groupBoxPartsLabor.Name = "groupBoxPartsLabor";
            groupBoxPartsLabor.Size = new Size(250, 110);
            groupBoxPartsLabor.TabIndex = 3;
            groupBoxPartsLabor.TabStop = false;
            groupBoxPartsLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(12, 28);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(98, 23);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(127, 24);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(103, 30);
            txtParts.TabIndex = 1;
            // 
            // lblLaborHours
            // 
            lblLaborHours.AutoSize = true;
            lblLaborHours.Location = new Point(12, 60);
            lblLaborHours.Name = "lblLaborHours";
            lblLaborHours.Size = new Size(117, 23);
            lblLaborHours.TabIndex = 2;
            lblLaborHours.Text = "工時數 (小時)";
            // 
            // txtLaborHours
            // 
            txtLaborHours.Location = new Point(127, 56);
            txtLaborHours.Name = "txtLaborHours";
            txtLaborHours.Size = new Size(103, 30);
            txtLaborHours.TabIndex = 3;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(lblServiceLabor);
            groupBoxSummary.Controls.Add(txtServiceLabor);
            groupBoxSummary.Controls.Add(lblPartsSummary);
            groupBoxSummary.Controls.Add(txtPartsSummary);
            groupBoxSummary.Controls.Add(lblTax);
            groupBoxSummary.Controls.Add(txtTax);
            groupBoxSummary.Controls.Add(lblTotal);
            groupBoxSummary.Controls.Add(txtTotal);
            groupBoxSummary.Location = new Point(12, 230);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Size = new Size(516, 100);
            groupBoxSummary.TabIndex = 4;
            groupBoxSummary.TabStop = false;
            groupBoxSummary.Text = "費用摘要";
            // 
            // lblServiceLabor
            // 
            lblServiceLabor.AutoSize = true;
            lblServiceLabor.Location = new Point(12, 24);
            lblServiceLabor.Name = "lblServiceLabor";
            lblServiceLabor.Size = new Size(100, 23);
            lblServiceLabor.TabIndex = 0;
            lblServiceLabor.Text = "服務與工資";
            // 
            // txtServiceLabor
            // 
            txtServiceLabor.BorderStyle = BorderStyle.Fixed3D;
            txtServiceLabor.Location = new Point(120, 20);
            txtServiceLabor.Name = "txtServiceLabor";
            txtServiceLabor.Size = new Size(120, 23);
            txtServiceLabor.TabIndex = 1;
            txtServiceLabor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPartsSummary
            // 
            lblPartsSummary.AutoSize = true;
            lblPartsSummary.Location = new Point(12, 50);
            lblPartsSummary.Name = "lblPartsSummary";
            lblPartsSummary.Size = new Size(46, 23);
            lblPartsSummary.TabIndex = 2;
            lblPartsSummary.Text = "零件";
            // 
            // txtPartsSummary
            // 
            txtPartsSummary.BorderStyle = BorderStyle.Fixed3D;
            txtPartsSummary.Location = new Point(120, 46);
            txtPartsSummary.Name = "txtPartsSummary";
            txtPartsSummary.Size = new Size(120, 23);
            txtPartsSummary.TabIndex = 3;
            txtPartsSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(270, 24);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(99, 23);
            lblTax.TabIndex = 4;
            lblTax.Text = "稅金 (零件)";
            // 
            // txtTax
            // 
            txtTax.BorderStyle = BorderStyle.Fixed3D;
            txtTax.Location = new Point(370, 20);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(120, 23);
            txtTax.TabIndex = 5;
            txtTax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(270, 50);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "總費用";
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.Fixed3D;
            txtTotal.Location = new Point(370, 46);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(120, 23);
            txtTotal.TabIndex = 7;
            txtTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(80, 340);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 28);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(220, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 28);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(360, 340);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 28);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 387);
            Controls.Add(groupBoxOil);
            Controls.Add(groupBoxCleaning);
            Controls.Add(groupBoxOther);
            Controls.Add(groupBoxPartsLabor);
            Controls.Add(groupBoxSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            groupBoxOil.ResumeLayout(false);
            groupBoxOil.PerformLayout();
            groupBoxCleaning.ResumeLayout(false);
            groupBoxCleaning.PerformLayout();
            groupBoxOther.ResumeLayout(false);
            groupBoxOther.PerformLayout();
            groupBoxPartsLabor.ResumeLayout(false);
            groupBoxPartsLabor.PerformLayout();
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
