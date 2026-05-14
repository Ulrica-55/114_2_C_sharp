namespace Cell_Phone_Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理資源 (含設計器建立的元件)。
        /// </summary>
        /// <param name="disposing">若為 true，代表釋放受控資源。</param>
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
        /// 初始化元件。以下內容為設計器自動建立，但已針對：
        /// 1) 所有元件的 Text 屬性改為繁體中文
        /// 2) 將各元件字型設為微軟正黑體、字型大小 18
        /// 3) 適度調整各元件大小與位置以配合較大字型
        /// 
        /// 註：此檔案僅改動顯示文字、字型與版面位置/大小，未變更欄位名稱或事件綁定，確保程式邏輯不受影響。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.outputPriceLabel = new System.Windows.Forms.Label();
            this.outputModelLabel = new System.Windows.Forms.Label();
            this.outputBrandLabel = new System.Windows.Forms.Label();
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.objectPropertiesGroupBox.SuspendLayout();
            this.enterDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(276, 500);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 48);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createObjectButton
            // 
            this.createObjectButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.createObjectButton.Location = new System.Drawing.Point(58, 500);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(172, 48);
            this.createObjectButton.TabIndex = 6;
            this.createObjectButton.Text = "建立物件";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectPropertiesGroupBox
            // 
            this.objectPropertiesGroupBox.Controls.Add(this.priceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.modelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.brandLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputPriceLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputModelLabel);
            this.objectPropertiesGroupBox.Controls.Add(this.outputBrandLabel);
            this.objectPropertiesGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.objectPropertiesGroupBox.Location = new System.Drawing.Point(44, 291);
            this.objectPropertiesGroupBox.Name = "objectPropertiesGroupBox";
            this.objectPropertiesGroupBox.Size = new System.Drawing.Size(408, 184);
            this.objectPropertiesGroupBox.TabIndex = 5;
            this.objectPropertiesGroupBox.TabStop = false;
            this.objectPropertiesGroupBox.Text = "物件屬性";
            this.objectPropertiesGroupBox.Enter += new System.EventHandler(this.objectPropertiesGroupBox_Enter);
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceLabel.Location = new System.Drawing.Point(120, 144);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(260, 34);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelLabel
            // 
            this.modelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modelLabel.Location = new System.Drawing.Point(120, 99);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(260, 34);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brandLabel
            // 
            this.brandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.brandLabel.Location = new System.Drawing.Point(120, 60);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(260, 34);
            this.brandLabel.TabIndex = 4;
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputPriceLabel
            // 
            this.outputPriceLabel.AutoSize = true;
            this.outputPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputPriceLabel.Location = new System.Drawing.Point(6, 139);
            this.outputPriceLabel.Name = "outputPriceLabel";
            this.outputPriceLabel.Size = new System.Drawing.Size(128, 45);
            this.outputPriceLabel.TabIndex = 5;
            this.outputPriceLabel.Text = "價格：";
            // 
            // outputModelLabel
            // 
            this.outputModelLabel.AutoSize = true;
            this.outputModelLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputModelLabel.Location = new System.Drawing.Point(6, 94);
            this.outputModelLabel.Name = "outputModelLabel";
            this.outputModelLabel.Size = new System.Drawing.Size(128, 45);
            this.outputModelLabel.TabIndex = 4;
            this.outputModelLabel.Text = "型號：";
            // 
            // outputBrandLabel
            // 
            this.outputBrandLabel.AutoSize = true;
            this.outputBrandLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputBrandLabel.Location = new System.Drawing.Point(6, 54);
            this.outputBrandLabel.Name = "outputBrandLabel";
            this.outputBrandLabel.Size = new System.Drawing.Size(128, 45);
            this.outputBrandLabel.TabIndex = 3;
            this.outputBrandLabel.Text = "品牌：";
            // 
            // enterDataGroupBox
            // 
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            this.enterDataGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enterDataGroupBox.Location = new System.Drawing.Point(31, 12);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(421, 241);
            this.enterDataGroupBox.TabIndex = 4;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "輸入手機資料";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(120, 186);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(260, 55);
            this.priceTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modelTextBox.Location = new System.Drawing.Point(120, 125);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(260, 55);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.brandTextBox.Location = new System.Drawing.Point(120, 64);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(260, 55);
            this.brandTextBox.TabIndex = 3;
            // 
            // promptPriceLabel
            // 
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.promptPriceLabel.Location = new System.Drawing.Point(5, 193);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(128, 45);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "價格：";
            // 
            // promptModelLabel
            // 
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.promptModelLabel.Location = new System.Drawing.Point(5, 128);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(128, 45);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "型號：";
            // 
            // promptBrandLabel
            // 
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.promptBrandLabel.Location = new System.Drawing.Point(5, 74);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(128, 45);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "品牌：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 556);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectPropertiesGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "手機測試";
            this.objectPropertiesGroupBox.ResumeLayout(false);
            this.objectPropertiesGroupBox.PerformLayout();
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectPropertiesGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label outputPriceLabel;
        private System.Windows.Forms.Label outputModelLabel;
        private System.Windows.Forms.Label outputBrandLabel;
        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
    }
}

