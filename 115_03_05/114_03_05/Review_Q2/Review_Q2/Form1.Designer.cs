namespace Review_Q2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Visual Controls

        private System.Windows.Forms.GroupBox groupBoxVehicleInfo;
        private System.Windows.Forms.Label lblVehicleOwner;
        private System.Windows.Forms.TextBox txtVehicleOwner;
        private System.Windows.Forms.Label lblVehiclePlate;
        private System.Windows.Forms.TextBox txtVehiclePlate;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.ComboBox cmbVehicleModel;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;

        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkBrakeRepair;
        private System.Windows.Forms.CheckBox chkTireService;
        private System.Windows.Forms.CheckBox chkEngineDiagnostic;
        private System.Windows.Forms.CheckBox chkBatteryReplacement;
        private System.Windows.Forms.CheckBox chkWheelAlignment;
        private System.Windows.Forms.Label lblOtherService;
        private System.Windows.Forms.TextBox txtOtherService;

        private System.Windows.Forms.GroupBox groupBoxCosts;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.TextBox txtLaborHours;
        private System.Windows.Forms.Label lblLaborRate;
        private System.Windows.Forms.TextBox txtLaborRate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.GroupBox groupBoxRecords;
        private System.Windows.Forms.DataGridView dgvServiceRecords;
        private System.Windows.Forms.Label lblRecordsFilter;
        private System.Windows.Forms.TextBox txtRecordsFilter;

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

            // Vehicle Info Group
            this.groupBoxVehicleInfo = new System.Windows.Forms.GroupBox();
            this.lblVehicleOwner = new System.Windows.Forms.Label();
            this.txtVehicleOwner = new System.Windows.Forms.TextBox();
            this.lblVehiclePlate = new System.Windows.Forms.Label();
            this.txtVehiclePlate = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.cmbVehicleModel = new System.Windows.Forms.ComboBox();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();

            // Services Group
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkBrakeRepair = new System.Windows.Forms.CheckBox();
            this.chkTireService = new System.Windows.Forms.CheckBox();
            this.chkEngineDiagnostic = new System.Windows.Forms.CheckBox();
            this.chkBatteryReplacement = new System.Windows.Forms.CheckBox();
            this.chkWheelAlignment = new System.Windows.Forms.CheckBox();
            this.lblOtherService = new System.Windows.Forms.Label();
            this.txtOtherService = new System.Windows.Forms.TextBox();

            // Costs Group
            this.groupBoxCosts = new System.Windows.Forms.GroupBox();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.lblLaborHours = new System.Windows.Forms.Label();
            this.txtLaborHours = new System.Windows.Forms.TextBox();
            this.lblLaborRate = new System.Windows.Forms.Label();
            this.txtLaborRate = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();

            // Actions Group
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // Records Group
            this.groupBoxRecords = new System.Windows.Forms.GroupBox();
            this.dgvServiceRecords = new System.Windows.Forms.DataGridView();
            this.lblRecordsFilter = new System.Windows.Forms.Label();
            this.txtRecordsFilter = new System.Windows.Forms.TextBox();

            // Form settings
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Text = "汽車維修服務費用管理系統";

            // groupBoxVehicleInfo
            this.groupBoxVehicleInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            this.groupBoxVehicleInfo.Size = new System.Drawing.Size(480, 140);
            this.groupBoxVehicleInfo.TabIndex = 0;
            this.groupBoxVehicleInfo.TabStop = false;
            this.groupBoxVehicleInfo.Text = "車輛與客戶資訊";
            this.groupBoxVehicleInfo.Controls.Add(this.lblVehicleOwner);
            this.groupBoxVehicleInfo.Controls.Add(this.txtVehicleOwner);
            this.groupBoxVehicleInfo.Controls.Add(this.lblVehiclePlate);
            this.groupBoxVehicleInfo.Controls.Add(this.txtVehiclePlate);
            this.groupBoxVehicleInfo.Controls.Add(this.lblVehicleModel);
            this.groupBoxVehicleInfo.Controls.Add(this.cmbVehicleModel);
            this.groupBoxVehicleInfo.Controls.Add(this.lblServiceDate);
            this.groupBoxVehicleInfo.Controls.Add(this.dtpServiceDate);

            // lblVehicleOwner
            this.lblVehicleOwner.Location = new System.Drawing.Point(12, 25);
            this.lblVehicleOwner.Name = "lblVehicleOwner";
            this.lblVehicleOwner.Size = new System.Drawing.Size(80, 23);
            this.lblVehicleOwner.Text = "車主姓名：";

            // txtVehicleOwner
            this.txtVehicleOwner.Location = new System.Drawing.Point(98, 22);
            this.txtVehicleOwner.Name = "txtVehicleOwner";
            this.txtVehicleOwner.Size = new System.Drawing.Size(360, 23);

            // lblVehiclePlate
            this.lblVehiclePlate.Location = new System.Drawing.Point(12, 55);
            this.lblVehiclePlate.Name = "lblVehiclePlate";
            this.lblVehiclePlate.Size = new System.Drawing.Size(80, 23);
            this.lblVehiclePlate.Text = "車牌：";

            // txtVehiclePlate
            this.txtVehiclePlate.Location = new System.Drawing.Point(98, 52);
            this.txtVehiclePlate.Name = "txtVehiclePlate";
            this.txtVehiclePlate.Size = new System.Drawing.Size(160, 23);

            // lblVehicleModel
            this.lblVehicleModel.Location = new System.Drawing.Point(270, 55);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(80, 23);
            this.lblVehicleModel.Text = "車款/型號：";

            // cmbVehicleModel
            this.cmbVehicleModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleModel.Location = new System.Drawing.Point(350, 52);
            this.cmbVehicleModel.Name = "cmbVehicleModel";
            this.cmbVehicleModel.Size = new System.Drawing.Size(108, 23);

            // lblServiceDate
            this.lblServiceDate.Location = new System.Drawing.Point(12, 85);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(80, 23);
            this.lblServiceDate.Text = "維修日期：";

            // dtpServiceDate
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(98, 82);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(160, 23);

            // groupBoxServices
            this.groupBoxServices.Location = new System.Drawing.Point(12, 160);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(480, 170);
            this.groupBoxServices.TabIndex = 1;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "維修服務項目";
            this.groupBoxServices.Controls.Add(this.chkOilChange);
            this.groupBoxServices.Controls.Add(this.chkBrakeRepair);
            this.groupBoxServices.Controls.Add(this.chkTireService);
            this.groupBoxServices.Controls.Add(this.chkEngineDiagnostic);
            this.groupBoxServices.Controls.Add(this.chkBatteryReplacement);
            this.groupBoxServices.Controls.Add(this.chkWheelAlignment);
            this.groupBoxServices.Controls.Add(this.lblOtherService);
            this.groupBoxServices.Controls.Add(this.txtOtherService);

            // chkOilChange
            this.chkOilChange.Location = new System.Drawing.Point(16, 28);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(140, 24);
            this.chkOilChange.Text = "更換機油 (Oil Change)";

            // chkBrakeRepair
            this.chkBrakeRepair.Location = new System.Drawing.Point(180, 28);
            this.chkBrakeRepair.Name = "chkBrakeRepair";
            this.chkBrakeRepair.Size = new System.Drawing.Size(140, 24);
            this.chkBrakeRepair.Text = "煞車維修 (Brake Repair)";

            // chkTireService
            this.chkTireService.Location = new System.Drawing.Point(16, 58);
            this.chkTireService.Name = "chkTireService";
            this.chkTireService.Size = new System.Drawing.Size(140, 24);
            this.chkTireService.Text = "輪胎服務 (Tire Service)";

            // chkEngineDiagnostic
            this.chkEngineDiagnostic.Location = new System.Drawing.Point(180, 58);
            this.chkEngineDiagnostic.Name = "chkEngineDiagnostic";
            this.chkEngineDiagnostic.Size = new System.Drawing.Size(180, 24);
            this.chkEngineDiagnostic.Text = "引擎診斷 (Engine Diagnostic)";

            // chkBatteryReplacement
            this.chkBatteryReplacement.Location = new System.Drawing.Point(16, 88);
            this.chkBatteryReplacement.Name = "chkBatteryReplacement";
            this.chkBatteryReplacement.Size = new System.Drawing.Size(200, 24);
            this.chkBatteryReplacement.Text = "電瓶更換 (Battery Replacement)";

            // chkWheelAlignment
            this.chkWheelAlignment.Location = new System.Drawing.Point(180, 88);
            this.chkWheelAlignment.Name = "chkWheelAlignment";
            this.chkWheelAlignment.Size = new System.Drawing.Size(180, 24);
            this.chkWheelAlignment.Text = "四輪定位 (Wheel Alignment)";

            // lblOtherService
            this.lblOtherService.Location = new System.Drawing.Point(16, 120);
            this.lblOtherService.Name = "lblOtherService";
            this.lblOtherService.Size = new System.Drawing.Size(80, 23);
            this.lblOtherService.Text = "其他：";

            // txtOtherService
            this.txtOtherService.Location = new System.Drawing.Point(98, 117);
            this.txtOtherService.Name = "txtOtherService";
            this.txtOtherService.Size = new System.Drawing.Size(360, 23);

            // groupBoxCosts
            this.groupBoxCosts.Location = new System.Drawing.Point(510, 12);
            this.groupBoxCosts.Name = "groupBoxCosts";
            this.groupBoxCosts.Size = new System.Drawing.Size(480, 210);
            this.groupBoxCosts.TabIndex = 2;
            this.groupBoxCosts.TabStop = false;
            this.groupBoxCosts.Text = "費用明細";
            this.groupBoxCosts.Controls.Add(this.lblPartsCost);
            this.groupBoxCosts.Controls.Add(this.txtPartsCost);
            this.groupBoxCosts.Controls.Add(this.lblLaborHours);
            this.groupBoxCosts.Controls.Add(this.txtLaborHours);
            this.groupBoxCosts.Controls.Add(this.lblLaborRate);
            this.groupBoxCosts.Controls.Add(this.txtLaborRate);
            this.groupBoxCosts.Controls.Add(this.lblSubtotal);
            this.groupBoxCosts.Controls.Add(this.txtSubtotal);
            this.groupBoxCosts.Controls.Add(this.lblTax);
            this.groupBoxCosts.Controls.Add(this.txtTax);
            this.groupBoxCosts.Controls.Add(this.lblTotal);
            this.groupBoxCosts.Controls.Add(this.txtTotal);

            // lblPartsCost
            this.lblPartsCost.Location = new System.Drawing.Point(16, 28);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(120, 23);
            this.lblPartsCost.Text = "零件費用 (Parts)：";

            // txtPartsCost
            this.txtPartsCost.Location = new System.Drawing.Point(142, 25);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.Size = new System.Drawing.Size(120, 23);
            this.txtPartsCost.Text = "0.00";

            // lblLaborHours
            this.lblLaborHours.Location = new System.Drawing.Point(16, 58);
            this.lblLaborHours.Name = "lblLaborHours";
            this.lblLaborHours.Size = new System.Drawing.Size(120, 23);
            this.lblLaborHours.Text = "工時 (Hours)：";

            // txtLaborHours
            this.txtLaborHours.Location = new System.Drawing.Point(142, 55);
            this.txtLaborHours.Name = "txtLaborHours";
            this.txtLaborHours.Size = new System.Drawing.Size(120, 23);
            this.txtLaborHours.Text = "0";

            // lblLaborRate
            this.lblLaborRate.Location = new System.Drawing.Point(16, 88);
            this.lblLaborRate.Name = "lblLaborRate";
            this.lblLaborRate.Size = new System.Drawing.Size(120, 23);
            this.lblLaborRate.Text = "工資單價 (Rate)：";

            // txtLaborRate
            this.txtLaborRate.Location = new System.Drawing.Point(142, 85);
            this.txtLaborRate.Name = "txtLaborRate";
            this.txtLaborRate.Size = new System.Drawing.Size(120, 23);
            this.txtLaborRate.Text = "0.00";

            // lblSubtotal
            this.lblSubtotal.Location = new System.Drawing.Point(16, 118);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(120, 23);
            this.lblSubtotal.Text = "小計 (Subtotal)：";

            // txtSubtotal
            this.txtSubtotal.Location = new System.Drawing.Point(142, 115);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(120, 23);
            this.txtSubtotal.Text = "0.00";

            // lblTax
            this.lblTax.Location = new System.Drawing.Point(16, 148);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(120, 23);
            this.lblTax.Text = "稅額 (Tax)：";

            // txtTax
            this.txtTax.Location = new System.Drawing.Point(142, 145);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(120, 23);
            this.txtTax.Text = "0.00";

            // lblTotal
            this.lblTotal.Location = new System.Drawing.Point(16, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 23);
            this.lblTotal.Text = "總計 (Total)：";

            // txtTotal
            this.txtTotal.Location = new System.Drawing.Point(142, 175);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 23);
            this.txtTotal.Text = "0.00";

            // groupBoxActions
            this.groupBoxActions.Location = new System.Drawing.Point(510, 230);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(480, 100);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "操作";

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(16, 28);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.Text = "計算";

            // btnAddRecord
            this.btnAddRecord.Location = new System.Drawing.Point(130, 28);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(100, 30);
            this.btnAddRecord.Text = "新增紀錄";

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(244, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "清除";

            // btnGenerateReport
            this.btnGenerateReport.Location = new System.Drawing.Point(358, 28);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(100, 30);
            this.btnGenerateReport.Text = "產生報表";

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(358, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "離開";

            this.groupBoxActions.Controls.Add(this.btnCalculate);
            this.groupBoxActions.Controls.Add(this.btnAddRecord);
            this.groupBoxActions.Controls.Add(this.btnClear);
            this.groupBoxActions.Controls.Add(this.btnGenerateReport);
            this.groupBoxActions.Controls.Add(this.btnExit);

            // groupBoxRecords
            this.groupBoxRecords.Location = new System.Drawing.Point(12, 340);
            this.groupBoxRecords.Name = "groupBoxRecords";
            this.groupBoxRecords.Size = new System.Drawing.Size(978, 348);
            this.groupBoxRecords.TabIndex = 4;
            this.groupBoxRecords.TabStop = false;
            this.groupBoxRecords.Text = "維修紀錄清單";
            this.groupBoxRecords.Controls.Add(this.dgvServiceRecords);
            this.groupBoxRecords.Controls.Add(this.lblRecordsFilter);
            this.groupBoxRecords.Controls.Add(this.txtRecordsFilter);

            // lblRecordsFilter
            this.lblRecordsFilter.Location = new System.Drawing.Point(16, 24);
            this.lblRecordsFilter.Name = "lblRecordsFilter";
            this.lblRecordsFilter.Size = new System.Drawing.Size(120, 23);
            this.lblRecordsFilter.Text = "搜尋/篩選：";

            // txtRecordsFilter
            this.txtRecordsFilter.Location = new System.Drawing.Point(142, 22);
            this.txtRecordsFilter.Name = "txtRecordsFilter";
            this.txtRecordsFilter.Size = new System.Drawing.Size(320, 23);

            // dgvServiceRecords
            this.dgvServiceRecords.Location = new System.Drawing.Point(16, 52);
            this.dgvServiceRecords.Name = "dgvServiceRecords";
            this.dgvServiceRecords.Size = new System.Drawing.Size(946, 280);
            this.dgvServiceRecords.ReadOnly = true;
            this.dgvServiceRecords.AllowUserToAddRows = false;
            this.dgvServiceRecords.AllowUserToDeleteRows = false;
            this.dgvServiceRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Add top-level controls to Form
            this.Controls.Add(this.groupBoxVehicleInfo);
            this.Controls.Add(this.groupBoxServices);
            this.Controls.Add(this.groupBoxCosts);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxRecords);

            // Finalize form
            this.ResumeLayout(false);
        }

        #endregion
    }
}

