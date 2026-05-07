namespace Coin_Toss
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
        /// 初始化元件
        /// 繁體中文註解：此方法由設計工具產生。依要求將所有可見元件的文字改成繁體中文、字型大小設定為 18，並適度調整每個元件大小與相對位置。
        /// 注意：不要變更事件綁定或其他非 UI 外觀之行為。
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            // 繁體中文註解：顯示擲幣結果的清單，字型設定為「微軟正黑體」18pt，適度放大清單尺寸以容納較大字型。
            this.outputListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 30;
            this.outputListBox.Location = new System.Drawing.Point(20, 20);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(320, 212);
            this.outputListBox.TabIndex = 0;
            // 
            // tossButton
            // 
            // 繁體中文註解：執行「擲五次硬幣」的主要按鈕，字型 18pt，按鈕尺寸與位置已調整為適合觸控與閱讀。
            this.tossButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tossButton.Location = new System.Drawing.Point(20, 245);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(150, 60);
            this.tossButton.TabIndex = 1;
            this.tossButton.Text = "擲五次硬幣";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            // 繁體中文註解：關閉程式的按鈕，字型 18pt，與「擲幣」按鈕並排放置，保持良好間距。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(190, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 繁體中文註解：主視窗標題改為繁體中文，並擴大窗體以容納放大的字型與元件。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "擲硬幣模擬器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}

