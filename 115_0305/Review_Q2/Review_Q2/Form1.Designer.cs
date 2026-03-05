namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbOilLubrication;
        private System.Windows.Forms.CheckBox chkChangeOil;
        private System.Windows.Forms.CheckBox chkLubeJob;

        private System.Windows.Forms.GroupBox gbCleaningServices;
        private System.Windows.Forms.CheckBox chkRadiatorFlush;
        private System.Windows.Forms.CheckBox chkTransmissionFlush;

        private System.Windows.Forms.GroupBox gbOtherServices;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkTireRotation;

        private System.Windows.Forms.GroupBox gbPartsAndLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.TextBox txtLaborHours;

        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblServiceLabor;
        private System.Windows.Forms.Label lblPartsSummary;
        private System.Windows.Forms.Label lblPartsTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblServiceLaborValue;
        private System.Windows.Forms.Label lblPartsSummaryValue;
        private System.Windows.Forms.Label lblPartsTaxValue;
        private System.Windows.Forms.Label lblTotalValue;

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
            gbOilLubrication = new System.Windows.Forms.GroupBox();
            chkChangeOil = new System.Windows.Forms.CheckBox();
            chkLubeJob = new System.Windows.Forms.CheckBox();
            gbCleaningServices = new System.Windows.Forms.GroupBox();
            chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            gbOtherServices = new System.Windows.Forms.GroupBox();
            chkInspection = new System.Windows.Forms.CheckBox();
            chkReplaceMuffler = new System.Windows.Forms.CheckBox();
            chkTireRotation = new System.Windows.Forms.CheckBox();
            gbPartsAndLabor = new System.Windows.Forms.GroupBox();
            lblParts = new System.Windows.Forms.Label();
            txtParts = new System.Windows.Forms.TextBox();
            lblLaborHours = new System.Windows.Forms.Label();
            txtLaborHours = new System.Windows.Forms.TextBox();
            gbSummary = new System.Windows.Forms.GroupBox();
            lblServiceLabor = new System.Windows.Forms.Label();
            lblServiceLaborValue = new System.Windows.Forms.Label();
            lblPartsSummary = new System.Windows.Forms.Label();
            lblPartsSummaryValue = new System.Windows.Forms.Label();
            lblPartsTax = new System.Windows.Forms.Label();
            lblPartsTaxValue = new System.Windows.Forms.Label();
            lblTotal = new System.Windows.Forms.Label();
            lblTotalValue = new System.Windows.Forms.Label();
            btnCalculate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            gbOilLubrication.SuspendLayout();
            gbCleaningServices.SuspendLayout();
            gbOtherServices.SuspendLayout();
            gbPartsAndLabor.SuspendLayout();
            gbSummary.SuspendLayout();
            SuspendLayout();
            // 
            // gbOilLubrication
            // 
            gbOilLubrication.Controls.Add(chkChangeOil);
            gbOilLubrication.Controls.Add(chkLubeJob);
            gbOilLubrication.Location = new System.Drawing.Point(12, 12);
            gbOilLubrication.Name = "gbOilLubrication";
            gbOilLubrication.Size = new System.Drawing.Size(240, 100);
            gbOilLubrication.TabIndex = 0;
            gbOilLubrication.TabStop = false;
            gbOilLubrication.Text = "機油和潤滑";
            // 
            // chkChangeOil
            // 
            chkChangeOil.AutoSize = true;
            chkChangeOil.Location = new System.Drawing.Point(12, 22);
            chkChangeOil.Name = "chkChangeOil";
            chkChangeOil.Size = new System.Drawing.Size(190, 27);
            chkChangeOil.TabIndex = 0;
            chkChangeOil.Text = "更換機油 (NT$780)";
            // 
            // chkLubeJob
            // 
            chkLubeJob.AutoSize = true;
            chkLubeJob.Location = new System.Drawing.Point(12, 52);
            chkLubeJob.Name = "chkLubeJob";
            chkLubeJob.Size = new System.Drawing.Size(190, 27);
            chkLubeJob.TabIndex = 1;
            chkLubeJob.Text = "潤滑保養 (NT$540)";
            // 
            // gbCleaningServices
            // 
            gbCleaningServices.Controls.Add(chkRadiatorFlush);
            gbCleaningServices.Controls.Add(chkTransmissionFlush);
            gbCleaningServices.Location = new System.Drawing.Point(268, 12);
            gbCleaningServices.Name = "gbCleaningServices";
            gbCleaningServices.Size = new System.Drawing.Size(240, 100);
            gbCleaningServices.TabIndex = 1;
            gbCleaningServices.TabStop = false;
            gbCleaningServices.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            chkRadiatorFlush.AutoSize = true;
            chkRadiatorFlush.Location = new System.Drawing.Point(12, 22);
            chkRadiatorFlush.Name = "chkRadiatorFlush";
            chkRadiatorFlush.Size = new System.Drawing.Size(190, 27);
            chkRadiatorFlush.TabIndex = 0;
            chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransmissionFlush
            // 
            chkTransmissionFlush.AutoSize = true;
            chkTransmissionFlush.Location = new System.Drawing.Point(12, 52);
            chkTransmissionFlush.Name = "chkTransmissionFlush";
            chkTransmissionFlush.Size = new System.Drawing.Size(222, 27);
            chkTransmissionFlush.TabIndex = 1;
            chkTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // gbOtherServices
            // 
            gbOtherServices.Controls.Add(chkInspection);
            gbOtherServices.Controls.Add(chkReplaceMuffler);
            gbOtherServices.Controls.Add(chkTireRotation);
            gbOtherServices.Location = new System.Drawing.Point(12, 118);
            gbOtherServices.Name = "gbOtherServices";
            gbOtherServices.Size = new System.Drawing.Size(240, 120);
            gbOtherServices.TabIndex = 2;
            gbOtherServices.TabStop = false;
            gbOtherServices.Text = "其他服務";
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new System.Drawing.Point(12, 22);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new System.Drawing.Size(154, 27);
            chkInspection.TabIndex = 0;
            chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkReplaceMuffler
            // 
            chkReplaceMuffler.AutoSize = true;
            chkReplaceMuffler.Location = new System.Drawing.Point(12, 52);
            chkReplaceMuffler.Name = "chkReplaceMuffler";
            chkReplaceMuffler.Size = new System.Drawing.Size(222, 27);
            chkReplaceMuffler.TabIndex = 1;
            chkReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // chkTireRotation
            // 
            chkTireRotation.AutoSize = true;
            chkTireRotation.Location = new System.Drawing.Point(12, 82);
            chkTireRotation.Name = "chkTireRotation";
            chkTireRotation.Size = new System.Drawing.Size(190, 27);
            chkTireRotation.TabIndex = 2;
            chkTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // gbPartsAndLabor
            // 
            gbPartsAndLabor.Controls.Add(lblParts);
            gbPartsAndLabor.Controls.Add(txtParts);
            gbPartsAndLabor.Controls.Add(lblLaborHours);
            gbPartsAndLabor.Controls.Add(txtLaborHours);
            gbPartsAndLabor.Location = new System.Drawing.Point(268, 118);
            gbPartsAndLabor.Name = "gbPartsAndLabor";
            gbPartsAndLabor.Size = new System.Drawing.Size(240, 120);
            gbPartsAndLabor.TabIndex = 3;
            gbPartsAndLabor.TabStop = false;
            gbPartsAndLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new System.Drawing.Point(12, 28);
            lblParts.Name = "lblParts";
            lblParts.Size = new System.Drawing.Size(98, 23);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new System.Drawing.Point(134, 25);
            txtParts.Name = "txtParts";
            txtParts.Size = new System.Drawing.Size(100, 30);
            txtParts.TabIndex = 1;
            // 
            // lblLaborHours
            // 
            lblLaborHours.AutoSize = true;
            lblLaborHours.Location = new System.Drawing.Point(12, 68);
            lblLaborHours.Name = "lblLaborHours";
            lblLaborHours.Size = new System.Drawing.Size(117, 23);
            lblLaborHours.TabIndex = 2;
            lblLaborHours.Text = "工時數 (小時)";
            // 
            // txtLaborHours
            // 
            txtLaborHours.Location = new System.Drawing.Point(134, 61);
            txtLaborHours.Name = "txtLaborHours";
            txtLaborHours.Size = new System.Drawing.Size(100, 30);
            txtLaborHours.TabIndex = 3;
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(lblServiceLabor);
            gbSummary.Controls.Add(lblServiceLaborValue);
            gbSummary.Controls.Add(lblPartsSummary);
            gbSummary.Controls.Add(lblPartsSummaryValue);
            gbSummary.Controls.Add(lblPartsTax);
            gbSummary.Controls.Add(lblPartsTaxValue);
            gbSummary.Controls.Add(lblTotal);
            gbSummary.Controls.Add(lblTotalValue);
            gbSummary.Location = new System.Drawing.Point(12, 254);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new System.Drawing.Size(496, 202);
            gbSummary.TabIndex = 4;
            gbSummary.TabStop = false;
            gbSummary.Text = "費用摘要";
            // 
            // lblServiceLabor
            // 
            lblServiceLabor.AutoSize = true;
            lblServiceLabor.Location = new System.Drawing.Point(6, 41);
            lblServiceLabor.Name = "lblServiceLabor";
            lblServiceLabor.Size = new System.Drawing.Size(100, 23);
            lblServiceLabor.TabIndex = 0;
            lblServiceLabor.Text = "服務與工資";
            // 
            // lblServiceLaborValue
            // 
            lblServiceLaborValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblServiceLaborValue.Location = new System.Drawing.Point(120, 41);
            lblServiceLaborValue.Name = "lblServiceLaborValue";
            lblServiceLaborValue.Size = new System.Drawing.Size(140, 23);
            lblServiceLaborValue.TabIndex = 1;
            lblServiceLaborValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartsSummary
            // 
            lblPartsSummary.AutoSize = true;
            lblPartsSummary.Location = new System.Drawing.Point(21, 80);
            lblPartsSummary.Name = "lblPartsSummary";
            lblPartsSummary.Size = new System.Drawing.Size(46, 23);
            lblPartsSummary.TabIndex = 2;
            lblPartsSummary.Text = "零件";
            // 
            // lblPartsSummaryValue
            // 
            lblPartsSummaryValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPartsSummaryValue.Location = new System.Drawing.Point(120, 80);
            lblPartsSummaryValue.Name = "lblPartsSummaryValue";
            lblPartsSummaryValue.Size = new System.Drawing.Size(140, 23);
            lblPartsSummaryValue.TabIndex = 3;
            lblPartsSummaryValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartsTax
            // 
            lblPartsTax.AutoSize = true;
            lblPartsTax.Location = new System.Drawing.Point(7, 119);
            lblPartsTax.Name = "lblPartsTax";
            lblPartsTax.Size = new System.Drawing.Size(99, 23);
            lblPartsTax.TabIndex = 4;
            lblPartsTax.Text = "稅金 (零件)";
            // 
            // lblPartsTaxValue
            // 
            lblPartsTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblPartsTaxValue.Location = new System.Drawing.Point(120, 119);
            lblPartsTaxValue.Name = "lblPartsTaxValue";
            lblPartsTaxValue.Size = new System.Drawing.Size(140, 23);
            lblPartsTaxValue.TabIndex = 5;
            lblPartsTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(21, 160);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(64, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "總費用";
            // 
            // lblTotalValue
            // 
            lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTotalValue.Location = new System.Drawing.Point(120, 160);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new System.Drawing.Size(140, 23);
            lblTotalValue.TabIndex = 7;
            lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(97, 498);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(100, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            btnCalculate.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(227, 498);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(100, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(358, 498);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(100, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(586, 540);
            Controls.Add(gbOilLubrication);
            Controls.Add(gbCleaningServices);
            Controls.Add(gbOtherServices);
            Controls.Add(gbPartsAndLabor);
            Controls.Add(gbSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Name = "Form1";
            Text = "汽車維修服務";
            gbOilLubrication.ResumeLayout(false);
            gbOilLubrication.PerformLayout();
            gbCleaningServices.ResumeLayout(false);
            gbCleaningServices.PerformLayout();
            gbOtherServices.ResumeLayout(false);
            gbOtherServices.PerformLayout();
            gbPartsAndLabor.ResumeLayout(false);
            gbPartsAndLabor.PerformLayout();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
