namespace Telephone_Format
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
        /// 設計工具產生的方法 - 請勿使用程式碼編輯器修改此方法內容。
        /// 下列程式碼已經依需求調整：
        /// - 所有元件的 Text 屬性改為繁體中文
        /// - 預設字型改為「Microsoft JhengHei」、大小 18（方便顯示繁體中文）
        /// - 適度調整每個元件的尺寸與相對位置
        /// 其他程式碼維持原狀。
        /// </summary>
        private void InitializeComponent()
        {
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.formatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 注意：下列區塊以繁體中文註解說明每個元件的調整目的與屬性
            // 
            // numberTextBox
            // 
            // 說明：電話號碼輸入欄位 — 字型改為 18，寬度加大以容納 10 位數字的顯示
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberTextBox.Location = new System.Drawing.Point(30, 70);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(370, 38);
            this.numberTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            // 說明：提示文字（已翻譯為繁體中文），置中顯示，字型 18，並適度增加高度以容納換行
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instructionLabel.Location = new System.Drawing.Point(12, 10);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(410, 50);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "請輸入 10 位數字，我會將其格式化為電話號碼。";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatButton
            // 
            // 說明：格式化按鈕 — 文字改為「格式化」，字型 18，尺寸放大以符合整體介面
            this.formatButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.formatButton.Location = new System.Drawing.Point(60, 120);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(140, 45);
            this.formatButton.TabIndex = 2;
            this.formatButton.Text = "格式化";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // exitButton
            // 
            // 說明：離開按鈕 — 文字改為「離開」，字型 18，放在格式化按鈕右側
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(230, 120);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 說明：表單標題改為繁體中文，整體大小增加以符合字型與控制項尺寸
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 190);
            // 設定表單預設字型，讓子元件能繼承，確保繁體字型顯示與大小一致
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
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

