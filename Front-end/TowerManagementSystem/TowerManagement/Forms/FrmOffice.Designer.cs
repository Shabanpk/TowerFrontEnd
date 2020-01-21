namespace TowerManagement.Forms
{
    partial class FrmOffice
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
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance34 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOfficeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnEdit = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.chkIsActive = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnOfficeID = new Infragistics.Win.Misc.UltraButton();
            this.txtofficeName = new System.Windows.Forms.TextBox();
            this.txtMaintence = new System.Windows.Forms.TextBox();
            this.txtwater = new System.Windows.Forms.TextBox();
            this.txtElectricityPerUnit = new System.Windows.Forms.TextBox();
            this.txttenantName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOfficeArea = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGeneratorPerUnit = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.cboBuildingName = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.cboFloorName = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBuildingName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFloorName)).BeginInit();
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
            this.PanelHeader.Size = new System.Drawing.Size(736, 69);
            this.PanelHeader.TabIndex = 13;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TowerManagement.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(697, 23);
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
            this.lblheader.Size = new System.Drawing.Size(205, 37);
            this.lblheader.TabIndex = 89;
            this.lblheader.Text = "Office Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(36, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 114;
            this.label2.Text = "Building Name";
            // 
            // txtOfficeID
            // 
            this.txtOfficeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeID.Location = new System.Drawing.Point(147, 96);
            this.txtOfficeID.MaxLength = 10000;
            this.txtOfficeID.Multiline = true;
            this.txtOfficeID.Name = "txtOfficeID";
            this.txtOfficeID.ReadOnly = true;
            this.txtOfficeID.Size = new System.Drawing.Size(85, 25);
            this.txtOfficeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(57, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Floor Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(78, 99);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(62, 19);
            this.lblCity.TabIndex = 112;
            this.lblCity.Text = "OfficeID";
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnEdit.Location = new System.Drawing.Point(362, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 30);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnClear.Location = new System.Drawing.Point(431, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 30);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnOK.Location = new System.Drawing.Point(295, 428);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 30);
            this.btnOK.TabIndex = 16;
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
            this.chkIsActive.Location = new System.Drawing.Point(363, 396);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // btnOfficeID
            // 
            this.btnOfficeID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnOfficeID.Location = new System.Drawing.Point(242, 97);
            this.btnOfficeID.Name = "btnOfficeID";
            this.btnOfficeID.Size = new System.Drawing.Size(26, 20);
            this.btnOfficeID.TabIndex = 2;
            this.btnOfficeID.Text = "......";
            this.btnOfficeID.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnOfficeID.Click += new System.EventHandler(this.btnOfficeID_Click);
            // 
            // txtofficeName
            // 
            this.txtofficeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtofficeName.Location = new System.Drawing.Point(147, 225);
            this.txtofficeName.MaxLength = 100;
            this.txtofficeName.Name = "txtofficeName";
            this.txtofficeName.Size = new System.Drawing.Size(195, 24);
            this.txtofficeName.TabIndex = 5;
            // 
            // txtMaintence
            // 
            this.txtMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintence.Location = new System.Drawing.Point(510, 211);
            this.txtMaintence.MaxLength = 100;
            this.txtMaintence.Name = "txtMaintence";
            this.txtMaintence.Size = new System.Drawing.Size(195, 24);
            this.txtMaintence.TabIndex = 11;
            // 
            // txtwater
            // 
            this.txtwater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwater.Location = new System.Drawing.Point(510, 256);
            this.txtwater.MaxLength = 100;
            this.txtwater.Name = "txtwater";
            this.txtwater.Size = new System.Drawing.Size(195, 24);
            this.txtwater.TabIndex = 12;
            // 
            // txtElectricityPerUnit
            // 
            this.txtElectricityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectricityPerUnit.Location = new System.Drawing.Point(510, 133);
            this.txtElectricityPerUnit.MaxLength = 100;
            this.txtElectricityPerUnit.Name = "txtElectricityPerUnit";
            this.txtElectricityPerUnit.Size = new System.Drawing.Size(195, 24);
            this.txtElectricityPerUnit.TabIndex = 9;
            // 
            // txttenantName
            // 
            this.txttenantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenantName.Location = new System.Drawing.Point(147, 266);
            this.txttenantName.MaxLength = 100;
            this.txttenantName.Name = "txttenantName";
            this.txttenantName.Size = new System.Drawing.Size(195, 24);
            this.txttenantName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(453, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 121;
            this.label3.Text = "Water";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(407, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 122;
            this.label4.Text = "Maintenance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(418, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 123;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(455, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 124;
            this.label6.Text = "Other";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(372, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 125;
            this.label7.Text = "Electricity Per Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(45, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 126;
            this.label8.Text = "Tenant Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(50, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 127;
            this.label9.Text = "Office Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(58, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 129;
            this.label10.Text = "Office Rent";
            // 
            // txtRent
            // 
            this.txtRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRent.Location = new System.Drawing.Point(147, 305);
            this.txtRent.MaxLength = 100;
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(195, 24);
            this.txtRent.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(6, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 131;
            this.label11.Text = "Office Area Square ";
            // 
            // txtOfficeArea
            // 
            this.txtOfficeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeArea.Location = new System.Drawing.Point(147, 347);
            this.txtOfficeArea.MaxLength = 100;
            this.txtOfficeArea.Name = "txtOfficeArea";
            this.txtOfficeArea.Size = new System.Drawing.Size(195, 24);
            this.txtOfficeArea.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(371, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 19);
            this.label12.TabIndex = 133;
            this.label12.Text = "Generator Per Unit";
            // 
            // txtGeneratorPerUnit
            // 
            this.txtGeneratorPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratorPerUnit.Location = new System.Drawing.Point(510, 170);
            this.txtGeneratorPerUnit.MaxLength = 100;
            this.txtGeneratorPerUnit.Name = "txtGeneratorPerUnit";
            this.txtGeneratorPerUnit.Size = new System.Drawing.Size(195, 24);
            this.txtGeneratorPerUnit.TabIndex = 10;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(510, 300);
            this.txtOther.MaxLength = 100;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(195, 24);
            this.txtOther.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(510, 336);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(195, 24);
            this.txtDescription.TabIndex = 14;
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.LightGray;
            this.PanelFooter.Location = new System.Drawing.Point(0, 491);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(736, 32);
            this.PanelFooter.TabIndex = 136;
            // 
            // cboBuildingName
            // 
            this.cboBuildingName.AutoEdit = false;
            this.cboBuildingName.AutoSize = false;
            this.cboBuildingName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboBuildingName.DisplayLayout.Appearance = appearance1;
            this.cboBuildingName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cboBuildingName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.cboBuildingName.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboBuildingName.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.cboBuildingName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboBuildingName.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.cboBuildingName.DisplayLayout.MaxColScrollRegions = 1;
            this.cboBuildingName.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboBuildingName.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboBuildingName.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.cboBuildingName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboBuildingName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.cboBuildingName.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboBuildingName.DisplayLayout.Override.CellAppearance = appearance8;
            this.cboBuildingName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboBuildingName.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.cboBuildingName.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.cboBuildingName.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.cboBuildingName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboBuildingName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.cboBuildingName.DisplayLayout.Override.RowAppearance = appearance11;
            this.cboBuildingName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboBuildingName.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.cboBuildingName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboBuildingName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboBuildingName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboBuildingName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cboBuildingName.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            this.cboBuildingName.DropDownWidth = 200;
            this.cboBuildingName.Location = new System.Drawing.Point(147, 140);
            this.cboBuildingName.Name = "cboBuildingName";
            this.cboBuildingName.Size = new System.Drawing.Size(178, 22);
            this.cboBuildingName.TabIndex = 3;
            this.cboBuildingName.ValueChanged += new System.EventHandler(this.cboBuildingName_ValueChanged);
            // 
            // cboFloorName
            // 
            this.cboFloorName.AutoEdit = false;
            this.cboFloorName.AutoSize = false;
            this.cboFloorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboFloorName.DisplayLayout.Appearance = appearance25;
            this.cboFloorName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cboFloorName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.BorderColor = System.Drawing.SystemColors.Window;
            this.cboFloorName.DisplayLayout.GroupByBox.Appearance = appearance26;
            appearance27.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboFloorName.DisplayLayout.GroupByBox.BandLabelAppearance = appearance27;
            this.cboFloorName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackColor2 = System.Drawing.SystemColors.Control;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance28.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboFloorName.DisplayLayout.GroupByBox.PromptAppearance = appearance28;
            this.cboFloorName.DisplayLayout.MaxColScrollRegions = 1;
            this.cboFloorName.DisplayLayout.MaxRowScrollRegions = 1;
            appearance29.BackColor = System.Drawing.SystemColors.Window;
            appearance29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboFloorName.DisplayLayout.Override.ActiveCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.Highlight;
            appearance30.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboFloorName.DisplayLayout.Override.ActiveRowAppearance = appearance30;
            this.cboFloorName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboFloorName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance31.BackColor = System.Drawing.SystemColors.Window;
            this.cboFloorName.DisplayLayout.Override.CardAreaAppearance = appearance31;
            appearance32.BorderColor = System.Drawing.Color.Silver;
            appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboFloorName.DisplayLayout.Override.CellAppearance = appearance32;
            this.cboFloorName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboFloorName.DisplayLayout.Override.CellPadding = 0;
            appearance33.BackColor = System.Drawing.SystemColors.Control;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance33.BorderColor = System.Drawing.SystemColors.Window;
            this.cboFloorName.DisplayLayout.Override.GroupByRowAppearance = appearance33;
            appearance34.TextHAlignAsString = "Left";
            this.cboFloorName.DisplayLayout.Override.HeaderAppearance = appearance34;
            this.cboFloorName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboFloorName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.BorderColor = System.Drawing.Color.Silver;
            this.cboFloorName.DisplayLayout.Override.RowAppearance = appearance35;
            this.cboFloorName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance36.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboFloorName.DisplayLayout.Override.TemplateAddRowAppearance = appearance36;
            this.cboFloorName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboFloorName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboFloorName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboFloorName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cboFloorName.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            this.cboFloorName.DropDownWidth = 200;
            this.cboFloorName.Location = new System.Drawing.Point(147, 183);
            this.cboFloorName.Name = "cboFloorName";
            this.cboFloorName.Size = new System.Drawing.Size(178, 22);
            this.cboFloorName.TabIndex = 4;
            // 
            // FrmOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 522);
            this.Controls.Add(this.cboFloorName);
            this.Controls.Add(this.cboBuildingName);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGeneratorPerUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOfficeArea);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.txtofficeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOfficeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnOfficeID);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmOffice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOffice";
            this.Load += new System.EventHandler(this.FrmOffice_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmOffice_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOffice_KeyDown);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBuildingName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFloorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOfficeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private Infragistics.Win.Misc.UltraButton btnEdit;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkIsActive;
        private Infragistics.Win.Misc.UltraButton btnOfficeID;
        private System.Windows.Forms.TextBox txtofficeName;
        private System.Windows.Forms.TextBox txtMaintence;
        private System.Windows.Forms.TextBox txtwater;
        private System.Windows.Forms.TextBox txtElectricityPerUnit;
        private System.Windows.Forms.TextBox txttenantName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOfficeArea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGeneratorPerUnit;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.Panel PanelFooter;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboBuildingName;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboFloorName;
    }
}