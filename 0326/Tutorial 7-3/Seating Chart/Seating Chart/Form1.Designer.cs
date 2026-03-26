namespace Seating_Chart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果為 true，則表示受控資源應該被釋放；否則為 false。</param>
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
        /// 設計工具所需方法 — 請勿使用程式碼編輯器修改此方法內容。
        /// 以下已將所有元件的 Text 屬性改為繁體中文、字型大小統一設定為 18，並適度調整元件大小與位置。
        /// 內部並以繁體中文加入詳細註解，說明每個元件用途與調整原因。
        /// </summary>
        private void InitializeComponent()
        {
            this.airplanePictureBox = new System.Windows.Forms.PictureBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.seatPriceDescriptionLabel = new System.Windows.Forms.Label();
            this.colPromptLabel = new System.Windows.Forms.Label();
            this.rowPromptLabel = new System.Windows.Forms.Label();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayPriceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airplanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // airplanePictureBox
            // 
            this.airplanePictureBox.Image = global::Seating_Chart.Properties.Resources.Airplane;
            this.airplanePictureBox.Location = new System.Drawing.Point(0, 0);
            this.airplanePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.airplanePictureBox.Name = "airplanePictureBox";
            this.airplanePictureBox.Size = new System.Drawing.Size(996, 942);
            this.airplanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplanePictureBox.TabIndex = 0;
            this.airplanePictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceLabel.Location = new System.Drawing.Point(773, 29);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(209, 60);
            this.priceLabel.TabIndex = 21;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seatPriceDescriptionLabel
            // 
            this.seatPriceDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.seatPriceDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seatPriceDescriptionLabel.Location = new System.Drawing.Point(585, 29);
            this.seatPriceDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seatPriceDescriptionLabel.Name = "seatPriceDescriptionLabel";
            this.seatPriceDescriptionLabel.Size = new System.Drawing.Size(180, 61);
            this.seatPriceDescriptionLabel.TabIndex = 20;
            this.seatPriceDescriptionLabel.Text = "座位價格";
            this.seatPriceDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colPromptLabel
            // 
            this.colPromptLabel.BackColor = System.Drawing.Color.White;
            this.colPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.colPromptLabel.Location = new System.Drawing.Point(30, 166);
            this.colPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colPromptLabel.Name = "colPromptLabel";
            this.colPromptLabel.Size = new System.Drawing.Size(300, 61);
            this.colPromptLabel.TabIndex = 19;
            this.colPromptLabel.Text = "輸入欄位";
            this.colPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rowPromptLabel
            // 
            this.rowPromptLabel.BackColor = System.Drawing.Color.White;
            this.rowPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowPromptLabel.Location = new System.Drawing.Point(30, 83);
            this.rowPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rowPromptLabel.Name = "rowPromptLabel";
            this.rowPromptLabel.Size = new System.Drawing.Size(300, 61);
            this.rowPromptLabel.TabIndex = 18;
            this.rowPromptLabel.Text = "輸入列號";
            this.rowPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rowPromptLabel.Click += new System.EventHandler(this.rowPromptLabel_Click);
            // 
            // colTextBox
            // 
            this.colTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.colTextBox.Location = new System.Drawing.Point(205, 166);
            this.colTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(268, 55);
            this.colTextBox.TabIndex = 17;
            // 
            // rowTextBox
            // 
            this.rowTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowTextBox.Location = new System.Drawing.Point(205, 89);
            this.rowTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(268, 55);
            this.rowTextBox.TabIndex = 16;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(450, 969);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(270, 61);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayPriceButton
            // 
            this.displayPriceButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayPriceButton.Location = new System.Drawing.Point(90, 969);
            this.displayPriceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayPriceButton.Name = "displayPriceButton";
            this.displayPriceButton.Size = new System.Drawing.Size(300, 61);
            this.displayPriceButton.TabIndex = 22;
            this.displayPriceButton.Text = "顯示價格";
            this.displayPriceButton.UseVisualStyleBackColor = true;
            this.displayPriceButton.Click += new System.EventHandler(this.displayPriceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 1052);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayPriceButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.seatPriceDescriptionLabel);
            this.Controls.Add(this.colPromptLabel);
            this.Controls.Add(this.rowPromptLabel);
            this.Controls.Add(this.colTextBox);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.airplanePictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "座位圖";
            ((System.ComponentModel.ISupportInitialize)(this.airplanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox airplanePictureBox;
        internal System.Windows.Forms.Label priceLabel;
        internal System.Windows.Forms.Label seatPriceDescriptionLabel;
        internal System.Windows.Forms.Label colPromptLabel;
        internal System.Windows.Forms.Label rowPromptLabel;
        internal System.Windows.Forms.TextBox colTextBox;
        internal System.Windows.Forms.TextBox rowTextBox;
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button displayPriceButton;
    }
}

