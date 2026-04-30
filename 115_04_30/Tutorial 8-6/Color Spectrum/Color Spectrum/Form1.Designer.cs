namespace Color_Spectrum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// 初始化元件。此方法由設計工具產生，僅變更元件屬性（文字、字型、大小、位置、註解）
        /// - 已將所有元件的 Text 屬性改為繁體中文
        /// - 已將所有元件字型改為 18pt（使用微軟正黑體以支援繁體中文顯示）
        /// - 適度調整每個元件的大小與相對位置，確保 18pt 時仍能完整顯示
        /// 注意：未更動事件綁定或其他程式邏輯。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.indigoLabel = new System.Windows.Forms.Label();
            this.violetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            // 提示標籤：顯示指示文字，已改為繁體中文並置中顯示，字型 18pt
            this.promptLabel.AutoSize = false;
            this.promptLabel.Location = new System.Drawing.Point(12, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(532, 34);
            this.promptLabel.TabIndex = 7;
            this.promptLabel.Text = "請選擇光譜中的顏色";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // colorLabel
            // 
            // 顯示顏色的標籤：用於顯示被選取的顏色名稱，已設定初始文字為繁體中文並加大字型
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Location = new System.Drawing.Point(178, 106);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(200, 44);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "顯示顏色";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // redLabel
            // 
            // 紅色方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(12, 52);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(64, 44);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "紅色";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.redLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // orangeLabel
            // 
            // 橙色方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.orangeLabel.BackColor = System.Drawing.Color.Orange;
            this.orangeLabel.Location = new System.Drawing.Point(88, 52);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(64, 44);
            this.orangeLabel.TabIndex = 10;
            this.orangeLabel.Text = "橙色";
            this.orangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orangeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.orangeLabel.Click += new System.EventHandler(this.orangeLabel_Click);
            // 
            // yellowLabel
            // 
            // 黃色方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.Location = new System.Drawing.Point(164, 52);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(64, 44);
            this.yellowLabel.TabIndex = 11;
            this.yellowLabel.Text = "黃色";
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yellowLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yellowLabel.Click += new System.EventHandler(this.yellowLabel_Click);
            // 
            // greenLabel
            // 
            // 綠色方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.Location = new System.Drawing.Point(240, 52);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(64, 44);
            this.greenLabel.TabIndex = 12;
            this.greenLabel.Text = "綠色";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.greenLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // blueLabel
            // 
            // 藍色方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(316, 52);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(64, 44);
            this.blueLabel.TabIndex = 13;
            this.blueLabel.Text = "藍色";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blueLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // indigoLabel
            // 
            // 靛藍方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.indigoLabel.BackColor = System.Drawing.Color.Indigo;
            this.indigoLabel.Location = new System.Drawing.Point(392, 52);
            this.indigoLabel.Name = "indigoLabel";
            this.indigoLabel.Size = new System.Drawing.Size(64, 44);
            this.indigoLabel.TabIndex = 14;
            this.indigoLabel.Text = "靛藍";
            this.indigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.indigoLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.indigoLabel.Click += new System.EventHandler(this.indigoLabel_Click);
            // 
            // violetLabel
            // 
            // 紫色方塊（可點選）：已加入繁體中文文字，字型放大並調整大小與位置
            this.violetLabel.BackColor = System.Drawing.Color.Violet;
            this.violetLabel.Location = new System.Drawing.Point(468, 52);
            this.violetLabel.Name = "violetLabel";
            this.violetLabel.Size = new System.Drawing.Size(64, 44);
            this.violetLabel.TabIndex = 15;
            this.violetLabel.Text = "紫色";
            this.violetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.violetLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.violetLabel.Click += new System.EventHandler(this.violetLabel_Click);
            // 
            // Form1
            // 
            // 主視窗：標題改為繁體中文，並調整視窗大小以容納放大的元件
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 166);
            this.Controls.Add(this.violetLabel);
            this.Controls.Add(this.indigoLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "色彩光譜";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label orangeLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label indigoLabel;
        private System.Windows.Forms.Label violetLabel;
    }
}

