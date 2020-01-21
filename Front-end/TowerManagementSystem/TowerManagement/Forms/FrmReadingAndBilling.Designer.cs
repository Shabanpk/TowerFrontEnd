namespace TowerManagement.Forms
{
    partial class FrmReadingAndBilling
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.cboOfficeName = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.TxtCurrElecUnit = new System.Windows.Forms.TextBox();
            this.txtPrevElectUnit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGeneratorPerUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenantName = new System.Windows.Forms.TextBox();
            this.txtElectricityPerUnit = new System.Windows.Forms.TextBox();
            this.txtwater = new System.Windows.Forms.TextBox();
            this.txtMaintence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnEdit = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.chkIsActive = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnBillID = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrevGenetorUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurrGeneratorUnit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtthisMonthElectricUnit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtThisMonthGenetorUnit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtElectricityBill = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGenetorBill = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtWithOutTaxBill = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTotalBillWithTax = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtReceivedAmount = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtArears = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.txtBillingID = new System.Windows.Forms.TextBox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOfficeName)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.btnClose);
            this.PanelHeader.Controls.Add(this.lblheader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(809, 69);
            this.PanelHeader.TabIndex = 14;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TowerManagement.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(767, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 25);
            this.btnClose.TabIndex = 134;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblheader
            // 
            this.lblheader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblheader.Location = new System.Drawing.Point(10, 17);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(95, 37);
            this.lblheader.TabIndex = 89;
            this.lblheader.Text = "Billing";
            // 
            // cboOfficeName
            // 
            this.cboOfficeName.AutoEdit = false;
            this.cboOfficeName.AutoSize = false;
            this.cboOfficeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboOfficeName.DisplayLayout.Appearance = appearance1;
            this.cboOfficeName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cboOfficeName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.cboOfficeName.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboOfficeName.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.cboOfficeName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboOfficeName.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.cboOfficeName.DisplayLayout.MaxColScrollRegions = 1;
            this.cboOfficeName.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboOfficeName.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboOfficeName.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.cboOfficeName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboOfficeName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.cboOfficeName.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboOfficeName.DisplayLayout.Override.CellAppearance = appearance8;
            this.cboOfficeName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboOfficeName.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.cboOfficeName.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.cboOfficeName.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.cboOfficeName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboOfficeName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.cboOfficeName.DisplayLayout.Override.RowAppearance = appearance11;
            this.cboOfficeName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboOfficeName.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.cboOfficeName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboOfficeName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboOfficeName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboOfficeName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cboOfficeName.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            this.cboOfficeName.DropDownWidth = 200;
            this.cboOfficeName.Location = new System.Drawing.Point(177, 159);
            this.cboOfficeName.Name = "cboOfficeName";
            this.cboOfficeName.Size = new System.Drawing.Size(195, 22);
            this.cboOfficeName.TabIndex = 4;
            this.cboOfficeName.ValueChanged += new System.EventHandler(this.cboOfficeName_ValueChanged);
            // 
            // TxtCurrElecUnit
            // 
            this.TxtCurrElecUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrElecUnit.Location = new System.Drawing.Point(176, 446);
            this.TxtCurrElecUnit.MaxLength = 100;
            this.TxtCurrElecUnit.Name = "TxtCurrElecUnit";
            this.TxtCurrElecUnit.Size = new System.Drawing.Size(195, 24);
            this.TxtCurrElecUnit.TabIndex = 12;
            // 
            // txtPrevElectUnit
            // 
            this.txtPrevElectUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevElectUnit.Location = new System.Drawing.Point(176, 410);
            this.txtPrevElectUnit.MaxLength = 100;
            this.txtPrevElectUnit.Name = "txtPrevElectUnit";
            this.txtPrevElectUnit.Size = new System.Drawing.Size(195, 24);
            this.txtPrevElectUnit.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(33, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 19);
            this.label12.TabIndex = 164;
            this.label12.Text = "Generator Per Unit";
            // 
            // txtGeneratorPerUnit
            // 
            this.txtGeneratorPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratorPerUnit.Location = new System.Drawing.Point(177, 301);
            this.txtGeneratorPerUnit.MaxLength = 100;
            this.txtGeneratorPerUnit.Name = "txtGeneratorPerUnit";
            this.txtGeneratorPerUnit.ReadOnly = true;
            this.txtGeneratorPerUnit.Size = new System.Drawing.Size(195, 24);
            this.txtGeneratorPerUnit.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(81, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 162;
            this.label10.Text = "Office Rent";
            // 
            // txtRent
            // 
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRent.Location = new System.Drawing.Point(177, 230);
            this.txtRent.MaxLength = 100;
            this.txtRent.Name = "txtRent";
            this.txtRent.ReadOnly = true;
            this.txtRent.Size = new System.Drawing.Size(195, 24);
            this.txtRent.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(68, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 160;
            this.label8.Text = "Tenant Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(34, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 159;
            this.label7.Text = "Electricity Per Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(31, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 158;
            this.label6.Text = "Prev ElectricityUnit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(3, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 157;
            this.label5.Text = "Current. Electricity Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(69, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 156;
            this.label4.Text = "Maintenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(115, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 155;
            this.label3.Text = "Water";
            // 
            // txttenantName
            // 
            this.txttenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenantName.Location = new System.Drawing.Point(177, 195);
            this.txttenantName.MaxLength = 100;
            this.txttenantName.Name = "txttenantName";
            this.txttenantName.ReadOnly = true;
            this.txttenantName.Size = new System.Drawing.Size(195, 24);
            this.txttenantName.TabIndex = 5;
            // 
            // txtElectricityPerUnit
            // 
            this.txtElectricityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricityPerUnit.Location = new System.Drawing.Point(177, 267);
            this.txtElectricityPerUnit.MaxLength = 100;
            this.txtElectricityPerUnit.Name = "txtElectricityPerUnit";
            this.txtElectricityPerUnit.ReadOnly = true;
            this.txtElectricityPerUnit.Size = new System.Drawing.Size(195, 24);
            this.txtElectricityPerUnit.TabIndex = 7;
            // 
            // txtwater
            // 
            this.txtwater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwater.Location = new System.Drawing.Point(177, 374);
            this.txtwater.MaxLength = 100;
            this.txtwater.Name = "txtwater";
            this.txtwater.ReadOnly = true;
            this.txtwater.Size = new System.Drawing.Size(195, 24);
            this.txtwater.TabIndex = 10;
            // 
            // txtMaintence
            // 
            this.txtMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintence.Location = new System.Drawing.Point(177, 339);
            this.txtMaintence.MaxLength = 100;
            this.txtMaintence.Name = "txtMaintence";
            this.txtMaintence.ReadOnly = true;
            this.txtMaintence.Size = new System.Drawing.Size(195, 24);
            this.txtMaintence.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(72, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 154;
            this.label2.Text = "Office Name";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(177, 85);
            this.txtBillNo.MaxLength = 10000;
            this.txtBillNo.Multiline = true;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(163, 25);
            this.txtBillNo.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(78, 88);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(85, 19);
            this.lblCity.TabIndex = 152;
            this.lblCity.Text = "Bill Number";
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnEdit.Location = new System.Drawing.Point(413, 535);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 30);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnClear.Location = new System.Drawing.Point(482, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 30);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnOK.Location = new System.Drawing.Point(346, 535);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 30);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "&OK";
            this.btnOK.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chkIsActive.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkIsActive.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(414, 503);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 25;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // btnBillID
            // 
            this.btnBillID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnBillID.Location = new System.Drawing.Point(355, 87);
            this.btnBillID.Name = "btnBillID";
            this.btnBillID.Size = new System.Drawing.Size(26, 20);
            this.btnBillID.TabIndex = 2;
            this.btnBillID.Text = "......";
            this.btnBillID.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnBillID.Click += new System.EventHandler(this.btnBillID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(96, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 153;
            this.label1.Text = "Bill Date";
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(177, 125);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(195, 20);
            this.dtpBillDate.TabIndex = 3;
            // 
            // txtPrevGenetorUnit
            // 
            this.txtPrevGenetorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevGenetorUnit.Location = new System.Drawing.Point(583, 98);
            this.txtPrevGenetorUnit.MaxLength = 100;
            this.txtPrevGenetorUnit.Name = "txtPrevGenetorUnit";
            this.txtPrevGenetorUnit.Size = new System.Drawing.Size(195, 24);
            this.txtPrevGenetorUnit.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(429, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 19);
            this.label11.TabIndex = 167;
            this.label11.Text = "Prev. Generator Unit";
            // 
            // txtCurrGeneratorUnit
            // 
            this.txtCurrGeneratorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrGeneratorUnit.Location = new System.Drawing.Point(585, 134);
            this.txtCurrGeneratorUnit.MaxLength = 100;
            this.txtCurrGeneratorUnit.Name = "txtCurrGeneratorUnit";
            this.txtCurrGeneratorUnit.Size = new System.Drawing.Size(195, 24);
            this.txtCurrGeneratorUnit.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(409, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 19);
            this.label13.TabIndex = 169;
            this.label13.Text = "Current. Generator Unit";
            // 
            // txtthisMonthElectricUnit
            // 
            this.txtthisMonthElectricUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthisMonthElectricUnit.Location = new System.Drawing.Point(177, 487);
            this.txtthisMonthElectricUnit.MaxLength = 100;
            this.txtthisMonthElectricUnit.Name = "txtthisMonthElectricUnit";
            this.txtthisMonthElectricUnit.Size = new System.Drawing.Size(195, 24);
            this.txtthisMonthElectricUnit.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(10, 489);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 19);
            this.label14.TabIndex = 171;
            this.label14.Text = "This Month Elect. Unit";
            // 
            // txtThisMonthGenetorUnit
            // 
            this.txtThisMonthGenetorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThisMonthGenetorUnit.Location = new System.Drawing.Point(586, 172);
            this.txtThisMonthGenetorUnit.MaxLength = 100;
            this.txtThisMonthGenetorUnit.Name = "txtThisMonthGenetorUnit";
            this.txtThisMonthGenetorUnit.Size = new System.Drawing.Size(195, 24);
            this.txtThisMonthGenetorUnit.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(389, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 19);
            this.label15.TabIndex = 173;
            this.label15.Text = "This Month Generator Unit";
            // 
            // txtElectricityBill
            // 
            this.txtElectricityBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricityBill.Location = new System.Drawing.Point(587, 209);
            this.txtElectricityBill.MaxLength = 100;
            this.txtElectricityBill.Name = "txtElectricityBill";
            this.txtElectricityBill.Size = new System.Drawing.Size(195, 24);
            this.txtElectricityBill.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(475, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 175;
            this.label16.Text = "Electricity Bill";
            // 
            // txtGenetorBill
            // 
            this.txtGenetorBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenetorBill.Location = new System.Drawing.Point(588, 248);
            this.txtGenetorBill.MaxLength = 100;
            this.txtGenetorBill.Name = "txtGenetorBill";
            this.txtGenetorBill.Size = new System.Drawing.Size(195, 24);
            this.txtGenetorBill.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(475, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 19);
            this.label17.TabIndex = 177;
            this.label17.Text = "Generator Bill";
            // 
            // txtWithOutTaxBill
            // 
            this.txtWithOutTaxBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithOutTaxBill.Location = new System.Drawing.Point(589, 286);
            this.txtWithOutTaxBill.MaxLength = 100;
            this.txtWithOutTaxBill.Name = "txtWithOutTaxBill";
            this.txtWithOutTaxBill.Size = new System.Drawing.Size(195, 24);
            this.txtWithOutTaxBill.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(422, 289);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 19);
            this.label18.TabIndex = 179;
            this.label18.Text = "Total Bill With out Tax";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(589, 324);
            this.txtTax.MaxLength = 100;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(195, 24);
            this.txtTax.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(542, 326);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 19);
            this.label19.TabIndex = 181;
            this.label19.Text = "Tax";
            // 
            // txtTotalBillWithTax
            // 
            this.txtTotalBillWithTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBillWithTax.Location = new System.Drawing.Point(588, 363);
            this.txtTotalBillWithTax.MaxLength = 100;
            this.txtTotalBillWithTax.Name = "txtTotalBillWithTax";
            this.txtTotalBillWithTax.Size = new System.Drawing.Size(195, 24);
            this.txtTotalBillWithTax.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(446, 366);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 19);
            this.label20.TabIndex = 183;
            this.label20.Text = "Total Bill With Tax";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(588, 402);
            this.txtDiscount.MaxLength = 100;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(195, 24);
            this.txtDiscount.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(507, 405);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 19);
            this.label21.TabIndex = 185;
            this.label21.Text = "Discount";
            // 
            // txtReceivedAmount
            // 
            this.txtReceivedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedAmount.Location = new System.Drawing.Point(589, 439);
            this.txtReceivedAmount.MaxLength = 100;
            this.txtReceivedAmount.Name = "txtReceivedAmount";
            this.txtReceivedAmount.Size = new System.Drawing.Size(195, 24);
            this.txtReceivedAmount.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(453, 442);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 19);
            this.label22.TabIndex = 187;
            this.label22.Text = "Received Amount";
            // 
            // txtArears
            // 
            this.txtArears.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArears.Location = new System.Drawing.Point(590, 479);
            this.txtArears.MaxLength = 100;
            this.txtArears.Name = "txtArears";
            this.txtArears.Size = new System.Drawing.Size(195, 24);
            this.txtArears.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(525, 482);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 19);
            this.label23.TabIndex = 189;
            this.label23.Text = "Arears";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.LightGray;
            this.PanelFooter.Location = new System.Drawing.Point(0, 587);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(809, 32);
            this.PanelFooter.TabIndex = 190;
            // 
            // txtBillingID
            // 
            this.txtBillingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillingID.Location = new System.Drawing.Point(396, 75);
            this.txtBillingID.MaxLength = 10000;
            this.txtBillingID.Multiline = true;
            this.txtBillingID.Name = "txtBillingID";
            this.txtBillingID.ReadOnly = true;
            this.txtBillingID.Size = new System.Drawing.Size(85, 25);
            this.txtBillingID.TabIndex = 191;
            this.txtBillingID.Visible = false;
            // 
            // FrmReadingAndBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 619);
            this.Controls.Add(this.txtBillingID);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArears);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtReceivedAmount);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtTotalBillWithTax);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtWithOutTaxBill);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtGenetorBill);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtElectricityBill);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtThisMonthGenetorUnit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtthisMonthElectricUnit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCurrGeneratorUnit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrevGenetorUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboOfficeName);
            this.Controls.Add(this.TxtCurrElecUnit);
            this.Controls.Add(this.txtPrevElectUnit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGeneratorPerUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenantName);
            this.Controls.Add(this.txtElectricityPerUnit);
            this.Controls.Add(this.txtwater);
            this.Controls.Add(this.txtMaintence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnBillID);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmReadingAndBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReadingAndBilling";
            this.Load += new System.EventHandler(this.FrmReadingAndBilling_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmReadingAndBilling_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReadingAndBilling_KeyDown);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboOfficeName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblheader;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboOfficeName;
        private System.Windows.Forms.TextBox TxtCurrElecUnit;
        private System.Windows.Forms.TextBox txtPrevElectUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGeneratorPerUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenantName;
        private System.Windows.Forms.TextBox txtElectricityPerUnit;
        private System.Windows.Forms.TextBox txtwater;
        private System.Windows.Forms.TextBox txtMaintence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblCity;
        private Infragistics.Win.Misc.UltraButton btnEdit;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkIsActive;
        private Infragistics.Win.Misc.UltraButton btnBillID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtPrevGenetorUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurrGeneratorUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtthisMonthElectricUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtThisMonthGenetorUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtElectricityBill;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGenetorBill;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtWithOutTaxBill;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTotalBillWithTax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtReceivedAmount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtArears;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.TextBox txtBillingID;
    }
}