namespace Telephone_Format
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，則表示應釋放管理資源；否則只釋放非管理資源。</param>
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
        /// 設計工具所需的方法 — 請勿使用程式碼編輯器修改此方法內容。
        /// 已將所有元件的顯示文字改為繁體中文，字型改為 18pt，並適度調整元件大小與位置以符合更大字型。
        /// 以下註解皆為繁體中文說明，說明每個元件用途與調整說明。
        /// </summary>
        private void InitializeComponent()
        {
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.formatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberTextBox.Location = new System.Drawing.Point(87, 149);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(380, 55);
            this.numberTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(590, 125);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "輸入 10 碼數字，我會將其格式化為電話號碼。";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatButton
            // 
            this.formatButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formatButton.Location = new System.Drawing.Point(78, 225);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(159, 64);
            this.formatButton.TabIndex = 2;
            this.formatButton.Text = "格式化";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(292, 225);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 64);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 335);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "電話格式化";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Button exitButton;
    }
}

