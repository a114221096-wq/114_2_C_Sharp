namespace Review_Q3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region 控制項宣告
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.GroupBox grpHeader;

        private System.Windows.Forms.FlowLayoutPanel numbersPanel;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Label lblNumber5;

        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoadDraw;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.GroupBox grpBottom;
        private System.Windows.Forms.SplitContainer bottomSplit;
        private System.Windows.Forms.ListBox listBoxLottery;
        private System.Windows.Forms.GroupBox grpCompareResult;
        private System.Windows.Forms.TextBox txtCompareResult;
        #endregion

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

            // Form 基本設定
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Text = "樂透號碼產生器";
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // 主 Layout
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F)); // 號碼區
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F)); // 按鈕區
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // 結果區
            this.Controls.Add(this.mainLayout);

            // 群組：標題與號碼顯示
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.grpHeader.Text = "樂透號碼產生器";
            this.grpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHeader.Padding = new System.Windows.Forms.Padding(12);
            this.mainLayout.Controls.Add(this.grpHeader, 0, 0);

            // 號碼面板 (5 個方塊水平排列)
            this.numbersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numbersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numbersPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.numbersPanel.WrapContents = false;
            this.numbersPanel.AutoScroll = true;
            this.numbersPanel.Padding = new System.Windows.Forms.Padding(6);
            this.grpHeader.Controls.Add(this.numbersPanel);

            this.lblNumber1 = CreateNumberLabel("lblNumber1");
            this.lblNumber2 = CreateNumberLabel("lblNumber2");
            this.lblNumber3 = CreateNumberLabel("lblNumber3");
            this.lblNumber4 = CreateNumberLabel("lblNumber4");
            this.lblNumber5 = CreateNumberLabel("lblNumber5");

            this.numbersPanel.Controls.Add(this.lblNumber1);
            this.numbersPanel.Controls.Add(this.lblNumber2);
            this.numbersPanel.Controls.Add(this.lblNumber3);
            this.numbersPanel.Controls.Add(this.lblNumber4);
            this.numbersPanel.Controls.Add(this.lblNumber5);

            // 按鈕區 (水平置中三個按鈕)
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.buttonsPanel.WrapContents = false;
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(6);
            this.buttonsPanel.AutoSize = false;
            this.mainLayout.Controls.Add(this.buttonsPanel, 0, 1);

            this.btnGenerate = CreateActionButton("btnGenerate", "產生號碼");
            this.btnLoadDraw = CreateActionButton("btnLoadDraw", "開獎號碼");
            this.btnExit = CreateActionButton("btnExit", "離開");

            // 調整按鈕間距，使其置中
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(40, 12, 20, 12);
            this.btnLoadDraw.Margin = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(20, 12, 40, 12);

            this.buttonsPanel.Controls.Add(this.btnGenerate);
            this.buttonsPanel.Controls.Add(this.btnLoadDraw);
            this.buttonsPanel.Controls.Add(this.btnExit);

            // 結果區 (左側 ListBox, 右側 比對群組)
            this.grpBottom = new System.Windows.Forms.GroupBox();
            this.grpBottom.Text = "";
            this.grpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBottom.Padding = new System.Windows.Forms.Padding(8);
            this.mainLayout.Controls.Add(this.grpBottom, 0, 2);

            this.bottomSplit = new System.Windows.Forms.SplitContainer();
            this.bottomSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomSplit.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bottomSplit.SplitterDistance = (int)(this.ClientSize.Width * 0.45);
            this.bottomSplit.Panel1.Padding = new System.Windows.Forms.Padding(6);
            this.bottomSplit.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.grpBottom.Controls.Add(this.bottomSplit);

            // 左側：listBoxLottery
            this.listBoxLottery = new System.Windows.Forms.ListBox();
            this.listBoxLottery.Name = "listBoxLottery";
            this.listBoxLottery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLottery.Font = new System.Drawing.Font(this.Font.FontFamily, 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottomSplit.Panel1.Controls.Add(this.listBoxLottery);

            // 右側：中獎比對結果標題與區塊
            this.grpCompareResult = new System.Windows.Forms.GroupBox();
            this.grpCompareResult.Text = "中獎比對結果";
            this.grpCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompareResult.Padding = new System.Windows.Forms.Padding(8);
            this.bottomSplit.Panel2.Controls.Add(this.grpCompareResult);

            this.txtCompareResult = new System.Windows.Forms.TextBox();
            this.txtCompareResult.Multiline = true;
            this.txtCompareResult.ReadOnly = true;
            this.txtCompareResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCompareResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompareResult.Font = new System.Drawing.Font(this.Font.FontFamily, 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCompareResult.Controls.Add(this.txtCompareResult);
        }

        #endregion

        #region Helper Methods
        private System.Windows.Forms.Label CreateNumberLabel(string name)
        {
            var lbl = new System.Windows.Forms.Label();
            lbl.Name = name;
            lbl.Text = "";
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.BackColor = System.Drawing.Color.White;
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbl.Size = new System.Drawing.Size(140, 100);
            lbl.Margin = new System.Windows.Forms.Padding(18, 16, 18, 16);
            lbl.Font = new System.Drawing.Font(this.Font.FontFamily, 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            return lbl;
        }

        private System.Windows.Forms.Button CreateActionButton(string name, string text)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Name = name;
            btn.Text = text;
            btn.AutoSize = false;
            btn.Size = new System.Drawing.Size(220, 64);
            btn.Font = new System.Drawing.Font(this.Font.FontFamily, 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            return btn;
        }
        #endregion
    }
}

