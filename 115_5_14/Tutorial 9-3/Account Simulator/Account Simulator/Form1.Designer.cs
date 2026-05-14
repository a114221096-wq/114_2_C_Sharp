namespace Account_Simulator
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
        /// 設計器產生的初始化方法 - 請勿用程式碼編輯器修改其內容。
        /// 以下已將所有元件的 Text 屬性改為繁體中文、預設字型改為微軟正黑體並將字型大小設為 18，
        /// 並調整各元件大小與位置以避免重疊。詳細中文註解已內嵌於下方程式碼中。
        /// </summary>
        private void InitializeComponent()
        {
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 為整個表單設定預設字型與大小（微軟正黑體 18pt）
            // 所有未明確設定 Font 的子元件會繼承此字型，確保中文顯示與大小一致
            // 
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 調整自動縮放比例以配合字型大小
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            // 
            // depositGroupBox
            // 群組 - 存款：包含金額輸入與存款按鈕，已擴大尺寸避免與其他元件重疊
            // 
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositTextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(20, 70);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(240, 120);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存款";
            // 
            // depositButton
            // 存款按鈕：增大尺寸以配合 18pt 字型並置中於群組下半部
            // 
            this.depositButton.Location = new System.Drawing.Point(70, 68);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(100, 38);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 存款金額輸入欄：加大高度以符合字型，避免文字被裁切
            // 
            this.depositTextBox.Location = new System.Drawing.Point(100, 28);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(120, 39);
            this.depositTextBox.TabIndex = 1;
            // 
            // depositAmountDescriptionLabel
            // 存款金額說明標籤：繁體中文
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(16, 32);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(78, 30);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額：";
            // 
            // groupBox1
            // 群組 - 提款：包含金額輸入與提款按鈕，同樣擴大避免重疊
            // 
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Controls.Add(this.withdrawTextBox);
            this.groupBox1.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(280, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提款";
            // 
            // withdrawButton
            // 提款按鈕：加大尺寸與字型，位置置中
            // 
            this.withdrawButton.Location = new System.Drawing.Point(70, 68);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(100, 38);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 提款金額輸入欄：加高以避免 18pt 字型被截斷
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(100, 28);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(120, 39);
            this.withdrawTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 提款金額說明標籤：繁體中文
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(16, 32);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(78, 30);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額：";
            // 
            // balanceDescriptionLabel
            // 餘額說明標籤：移至表單上方並以繁體中文顯示
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(30, 20);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(78, 30);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "餘額：";
            // 
            // balanceLabel
            // 顯示餘額的標籤：加上邊框、置中顯示並放大寬度以容納較長文字
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(120, 12);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(400, 40);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 結束按鈕：放在表單下方中央，字型與尺寸皆放大以便點選
            // 
            this.exitButton.Location = new System.Drawing.Point(240, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 主表單：標題改為繁體中文，並擴充 ClientSize 以容納放大的元件
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.depositGroupBox);
            this.Name = "Form1";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

