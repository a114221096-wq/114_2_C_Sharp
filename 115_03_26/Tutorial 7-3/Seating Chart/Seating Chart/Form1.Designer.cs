namespace Seating_Chart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所有使用中的資源。
        /// 以下檔案由設計工具產生，已依使用者要求：
        /// - 將所有可見元件的 Text 屬性改為繁體中文
        /// - 將所有元件字型大小設定為 18（使用常見中文字型 Microsoft JhengHei）
        /// - 適度調整每個元件的 Size 與 Location 以配合字型大小並保持相對位置關係
        /// - 在 InitializeComponent 中加入繁體中文詳細註解（不更動其他程式邏輯或事件綁定）
        /// 請注意：不要在其他檔案做任何修改。
        /// </summary>
        /// <param name="disposing">如果為 true，表示應釋放受控資源；否則為 false。</param>
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
        /// 此方法為設計工具所需的方法內容。請勿以程式碼編輯器直接修改
        /// 內部程式碼，除非您非常清楚要變更的項目。以下已依使用者要求做出
        /// 視覺屬性與註解上的調整（繁體中文、字型大小 18、元件尺寸與位置微調）。
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
            // 圖片元件：顯示飛機背景，保留原始資源檔設定，大小調整以容納較大的文字及控制項。
            this.airplanePictureBox.Image = global::Seating_Chart.Properties.Resources.Airplane;
            this.airplanePictureBox.Location = new System.Drawing.Point(0, 0);
            this.airplanePictureBox.Name = "airplanePictureBox";
            this.airplanePictureBox.Size = new System.Drawing.Size(480, 560);
            this.airplanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airplanePictureBox.TabIndex = 0;
            this.airplanePictureBox.TabStop = false;
            // 
            // priceLabel
            // 
            // 價格顯示標籤：設定邊框、置中對齊，文字改為繁體中文，字型放大至 18，並擴大控制項大小以避免被裁切。
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceLabel.Location = new System.Drawing.Point(320, 60);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(140, 40);
            this.priceLabel.TabIndex = 21;
            this.priceLabel.Text = "價格";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seatPriceDescriptionLabel
            // 
            // 座位價格描述標籤：顯示說明文字「座位價格」，使用白色背景以便於在圖片上閱讀，字型 18。
            this.seatPriceDescriptionLabel.AutoSize = true;
            this.seatPriceDescriptionLabel.BackColor = System.Drawing.Color.White;
            this.seatPriceDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seatPriceDescriptionLabel.Location = new System.Drawing.Point(320, 26);
            this.seatPriceDescriptionLabel.Name = "seatPriceDescriptionLabel";
            this.seatPriceDescriptionLabel.Size = new System.Drawing.Size(86, 30);
            this.seatPriceDescriptionLabel.TabIndex = 20;
            this.seatPriceDescriptionLabel.Text = "座位價格";
            // 
            // colPromptLabel
            // 
            // 欄 (Column) 提示標籤：提示使用者輸入列號，文字改為繁體中文「輸入欄號」，字型 18，背景白色便於閱讀。
            this.colPromptLabel.AutoSize = true;
            this.colPromptLabel.BackColor = System.Drawing.Color.White;
            this.colPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.colPromptLabel.Location = new System.Drawing.Point(20, 70);
            this.colPromptLabel.Name = "colPromptLabel";
            this.colPromptLabel.Size = new System.Drawing.Size(106, 30);
            this.colPromptLabel.TabIndex = 19;
            this.colPromptLabel.Text = "輸入欄號";
            // 
            // rowPromptLabel
            // 
            // 行 (Row) 提示標籤：提示使用者輸入行號，文字改為繁體中文「輸入行號」，字型 18，背景白色。
            this.rowPromptLabel.AutoSize = true;
            this.rowPromptLabel.BackColor = System.Drawing.Color.White;
            this.rowPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowPromptLabel.Location = new System.Drawing.Point(20, 26);
            this.rowPromptLabel.Name = "rowPromptLabel";
            this.rowPromptLabel.Size = new System.Drawing.Size(106, 30);
            this.rowPromptLabel.TabIndex = 18;
            this.rowPromptLabel.Text = "輸入行號";
            // 
            // colTextBox
            // 
            // 欄輸入框：放大字型為 18，控制項尺寸也加大，便於輸入與閱讀。
            this.colTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.colTextBox.Location = new System.Drawing.Point(140, 68);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(140, 39);
            this.colTextBox.TabIndex = 17;
            // 
            // rowTextBox
            // 
            // 行輸入框：放大字型為 18，控制項尺寸也加大，便於輸入與閱讀。
            this.rowTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowTextBox.Location = new System.Drawing.Point(140, 24);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(140, 39);
            this.rowTextBox.TabIndex = 16;
            // 
            // exitButton
            // 
            // 離開按鈕：文字改為繁體中文「離開」，字型 18，尺寸與位置向下移動以置於表單下方中央區域。
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(260, 584);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 48);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayPriceButton
            // 
            // 顯示價格按鈕：文字改為繁體中文「顯示價格」，字型 18，尺寸與位置與離開按鈕對稱。
            this.displayPriceButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayPriceButton.Location = new System.Drawing.Point(100, 584);
            this.displayPriceButton.Name = "displayPriceButton";
            this.displayPriceButton.Size = new System.Drawing.Size(140, 48);
            this.displayPriceButton.TabIndex = 22;
            this.displayPriceButton.Text = "顯示價格";
            this.displayPriceButton.UseVisualStyleBackColor = true;
            this.displayPriceButton.Click += new System.EventHandler(this.displayPriceButton_Click);
            // 
            // Form1
            // 
            // 表單總體設定：將 Title 改為繁體中文「座位表」，調整表單大小以容納放大的元件。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 660);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayPriceButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.seatPriceDescriptionLabel);
            this.Controls.Add(this.colPromptLabel);
            this.Controls.Add(this.rowPromptLabel);
            this.Controls.Add(this.colTextBox);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.airplanePictureBox);
            this.Name = "Form1";
            this.Text = "座位表";
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

