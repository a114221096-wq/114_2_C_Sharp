namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblTitle;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Text = "樂透號碼產生器";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtNum1.Location = new System.Drawing.Point(24, 18);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.ReadOnly = true;
            this.txtNum1.Size = new System.Drawing.Size(68, 29);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtNum2.Location = new System.Drawing.Point(110, 18);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.ReadOnly = true;
            this.txtNum2.Size = new System.Drawing.Size(68, 29);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtNum3.Location = new System.Drawing.Point(196, 18);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.ReadOnly = true;
            this.txtNum3.Size = new System.Drawing.Size(68, 29);
            this.txtNum3.TabIndex = 2;
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            this.txtNum4.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtNum4.Location = new System.Drawing.Point(282, 18);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.ReadOnly = true;
            this.txtNum4.Size = new System.Drawing.Size(68, 29);
            this.txtNum4.TabIndex = 3;
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            this.txtNum5.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtNum5.Location = new System.Drawing.Point(368, 18);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.ReadOnly = true;
            this.txtNum5.Size = new System.Drawing.Size(68, 29);
            this.txtNum5.TabIndex = 4;
            this.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnGenerate.Location = new System.Drawing.Point(24, 64);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 48);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "產生號碼";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDraw.Location = new System.Drawing.Point(206, 64);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(160, 48);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "開獎號碼";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnExit.Location = new System.Drawing.Point(388, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(24, 130);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(520, 164);
            this.lstResults.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblTitle.Location = new System.Drawing.Point(24, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 20);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "本期開獎號碼：";
            // 
            // Form1 (finalize)
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

