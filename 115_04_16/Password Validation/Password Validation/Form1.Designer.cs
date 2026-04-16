namespace Password_Validation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計器變數。
        /// 注意：此檔案為設計器產生檔，僅修改元件屬性（Text、Font、Size、Location）與註解，
        /// 其它自動產生的程式邏輯不應任意更動，以維持設計師與程式碼後端的一致性。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果為 true，表示要釋放受控資源；否則只是非受控資源。</param>
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
        /// 設計器所需的方法 - 請勿使用程式碼編輯器直接修改此方法內容。
        /// 以下已將所有元件的 Text 屬性改為繁體中文，字型大小統一為 18，並調整了元件大小與位置以配合放大字型。
        /// 同時在每個元件區塊加入詳細繁體中文註解，說明用途與修改內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            // 功能：顯示密碼規則與說明文字（多行）
            // 變更說明：
            // - Text 改為繁體中文，多行顯示密碼規則與操作提示
            // - 字型改為 18pt，以增強可讀性
            // - 調整 Size 與 Location 以容納較大字型與多行文字
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 12);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(416, 120);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "密碼規則：\r\n- 必須至少 8 個字元\r\n- 包含大寫字母、小寫字母與數字\r\n- 不可包含空白字元\r\n\r\n請輸入符合規則的密碼，然後按下「檢查密碼」。";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // promptLabel
            // 
            // 功能：提示使用者輸入密碼（單行）
            // 變更說明：
            // - Text 改為繁體中文提示
            // - 字型設定為 18pt 粗體以突顯提示
            // - 調整位置以配合 instructionsLabel 的放大
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 140);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(150, 29);
            this.promptLabel.TabIndex = 1;
            this.promptLabel.Text = "請輸入密碼：";
            // 
            // passwordTextBox
            // 
            // 功能：讓使用者輸入密碼
            // 變更說明：
            // - 字型改為 18pt
            // - 增加高度與寬度，讓文字與輸入框視覺一致
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(18, 175);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(320, 35);
            this.passwordTextBox.TabIndex = 2;
            // 
            // checkPasswordButton
            // 
            // 功能：檢查使用者所輸入的密碼是否符合規則
            // 變更說明：
            // - Text 改為繁體中文「檢查密碼」
            // - 字型改為 18pt
            // - 增大按鈕尺寸並移動位置使畫面配置更合理
            this.checkPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPasswordButton.Location = new System.Drawing.Point(18, 220);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(160, 48);
            this.checkPasswordButton.TabIndex = 3;
            this.checkPasswordButton.Text = "檢查密碼";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // exitButton
            // 
            // 功能：關閉視窗（離開程式或回到上一畫面）
            // 變更說明：
            // - Text 改為繁體中文「離開」
            // - 字型改為 18pt
            // - 與檢查按鈕並排，位置與大小調整以保持一致性
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(194, 220);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 48);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 功能：主視窗屬性
            // 變更說明：
            // - 標題改為繁體中文「密碼驗證」
            // - ClientSize 擴大以容納放大的字型與元件
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.instructionsLabel);
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

