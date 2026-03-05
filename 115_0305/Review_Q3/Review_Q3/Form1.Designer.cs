using System;
using System.Windows.Forms;
using System.Drawing;

namespace Review_Q3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private Label lblTitle;
        private Panel pnlNumberDisplay;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblNum4;
        private Label lblNum5;
        private TableLayoutPanel tlpButtons;
        private Button btnGenerate;
        private Button btnLoadDraw;
        private Button btnExit;
        private GroupBox grpDrawnList;
        private ListBox lstDrawnNumbers;
        private GroupBox grpResult;
        private Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlNumberDisplay = new Panel();
            tlpButtons = new TableLayoutPanel();
            btnGenerate = new Button();
            btnLoadDraw = new Button();
            btnExit = new Button();
            grpDrawnList = new GroupBox();
            lstDrawnNumbers = new ListBox();
            grpResult = new GroupBox();
            lblResult = new Label();
            tlpButtons.SuspendLayout();
            grpDrawnList.SuspendLayout();
            grpResult.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "樂透號碼產生器";
            // 
            // pnlNumberDisplay
            // 
            pnlNumberDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlNumberDisplay.BorderStyle = BorderStyle.FixedSingle;
            pnlNumberDisplay.Location = new Point(20, 56);
            pnlNumberDisplay.Name = "pnlNumberDisplay";
            pnlNumberDisplay.Size = new Size(860, 120);
            pnlNumberDisplay.TabIndex = 1;
            // Create and add five number labels into the panel
            {
                int labelSize = 120;
                int spacing = 20;
                int startX = 20;
                int yPos = (pnlNumberDisplay.Height - labelSize) / 2;

                lblNum1 = CreateNumberLabel("lblNum1", new Point(startX + (labelSize + spacing) * 0, yPos), labelSize);
                lblNum2 = CreateNumberLabel("lblNum2", new Point(startX + (labelSize + spacing) * 1, yPos), labelSize);
                lblNum3 = CreateNumberLabel("lblNum3", new Point(startX + (labelSize + spacing) * 2, yPos), labelSize);
                lblNum4 = CreateNumberLabel("lblNum4", new Point(startX + (labelSize + spacing) * 3, yPos), labelSize);
                lblNum5 = CreateNumberLabel("lblNum5", new Point(startX + (labelSize + spacing) * 4, yPos), labelSize);

                pnlNumberDisplay.Controls.Add(lblNum1);
                pnlNumberDisplay.Controls.Add(lblNum2);
                pnlNumberDisplay.Controls.Add(lblNum3);
                pnlNumberDisplay.Controls.Add(lblNum4);
                pnlNumberDisplay.Controls.Add(lblNum5);
            }
            // 
            // tlpButtons
            // 
            tlpButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpButtons.Controls.Add(btnGenerate, 0, 0);
            tlpButtons.Controls.Add(btnLoadDraw, 1, 0);
            tlpButtons.Controls.Add(btnExit, 2, 0);
            tlpButtons.Location = new Point(20, 190);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.Padding = new Padding(10);
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(860, 80);
            tlpButtons.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Dock = DockStyle.Fill;
            btnGenerate.Font = new Font("Segoe UI", 18F);
            btnGenerate.Location = new Point(13, 13);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(274, 54);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "產生號碼";
            // 
            // btnLoadDraw
            // 
            btnLoadDraw.Dock = DockStyle.Fill;
            btnLoadDraw.Font = new Font("Segoe UI", 18F);
            btnLoadDraw.Location = new Point(293, 13);
            btnLoadDraw.Name = "btnLoadDraw";
            btnLoadDraw.Size = new Size(274, 54);
            btnLoadDraw.TabIndex = 1;
            btnLoadDraw.Text = "開獎號碼";
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.Font = new Font("Segoe UI", 18F);
            btnExit.Location = new Point(573, 13);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(274, 54);
            btnExit.TabIndex = 2;
            btnExit.Text = "離開";
            // 
            // grpDrawnList
            // 
            grpDrawnList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpDrawnList.Controls.Add(lstDrawnNumbers);
            grpDrawnList.Font = new Font("Segoe UI", 14F);
            grpDrawnList.Location = new Point(20, 290);
            grpDrawnList.Name = "grpDrawnList";
            grpDrawnList.Size = new Size(430, 230);
            grpDrawnList.TabIndex = 3;
            grpDrawnList.TabStop = false;
            grpDrawnList.Text = "開獎號碼清單";
            // 
            // lstDrawnNumbers
            // 
            lstDrawnNumbers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstDrawnNumbers.Font = new Font("Segoe UI", 18F);
            lstDrawnNumbers.ItemHeight = 48;
            lstDrawnNumbers.Location = new Point(12, 36);
            lstDrawnNumbers.Name = "lstDrawnNumbers";
            lstDrawnNumbers.Size = new Size(406, 148);
            lstDrawnNumbers.TabIndex = 0;
            // 
            // grpResult
            // 
            grpResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpResult.Controls.Add(lblResult);
            grpResult.Font = new Font("Segoe UI", 14F);
            grpResult.Location = new Point(460, 290);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(420, 230);
            grpResult.TabIndex = 4;
            grpResult.TabStop = false;
            grpResult.Text = "中獎比對結果";
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.AutoEllipsis = true;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 18F);
            lblResult.Location = new Point(12, 36);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(8);
            lblResult.Size = new Size(392, 174);
            lblResult.TabIndex = 0;
            lblResult.Text = "等待比對結果...";
            lblResult.Click += lblResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 540);
            Controls.Add(lblTitle);
            Controls.Add(pnlNumberDisplay);
            Controls.Add(tlpButtons);
            Controls.Add(grpDrawnList);
            Controls.Add(grpResult);
            Font = new Font("Segoe UI", 18F);
            Name = "Form1";
            Text = "樂透號碼產生器";
            tlpButtons.ResumeLayout(false);
            grpDrawnList.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // Helper to create styled number labels
        private Label CreateNumberLabel(string name, Point location, int size)
        {
            var lbl = new Label();
            lbl.Name = name;
            lbl.Text = "";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Size = new Size(size, size);
            lbl.Location = location;
            lbl.BackColor = Color.White;
            lbl.Anchor = AnchorStyles.Top;
            return lbl;
        }

        #endregion
    }
}
