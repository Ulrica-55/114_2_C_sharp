namespace Password_Validation
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(13, 33);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(824, 312);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "請輸入一組密碼，程式會檢查是否符合以下條件：\r\n\r\n1. 包含至少一個大寫英文字母（A–Z）\r\n2. 包含至少一個小寫英文字母（a–z）\r\n3. 包含至少一個數字" +
    "（0–9）\r\n4. 長度至少 8 個字元";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(34, 389);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(239, 40);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "請輸入密碼：";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(41, 457);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(478, 48);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // checkPasswordButton
            // 
            this.checkPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPasswordButton.Location = new System.Drawing.Point(20, 543);
            this.checkPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(255, 62);
            this.checkPasswordButton.TabIndex = 3;
            this.checkPasswordButton.Text = "檢查密碼";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(309, 543);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(210, 62);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 636);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "密碼驗證";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button checkPasswordButton;
        private System.Windows.Forms.Button exitButton;
    }
}

