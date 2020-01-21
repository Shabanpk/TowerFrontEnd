namespace TowerManagement.Forms
{
    partial class FrmFloor
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
            this.txtFloorName = new System.Windows.Forms.TextBox();
            this.txtFloorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnEdit = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.chkIsActive = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnFloorID = new Infragistics.Win.Misc.UltraButton();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.cboBuildingName = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBuildingName)).BeginInit();
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
            this.PanelHeader.Size = new System.Drawing.Size(632, 69);
            this.PanelHeader.TabIndex = 12;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TowerManagement.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(593, 23);
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
            this.lblheader.Text = "Floor Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(169, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Building Name";
            // 
            // txtFloorName
            // 
            this.txtFloorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorName.Location = new System.Drawing.Point(280, 196);
            this.txtFloorName.MaxLength = 100;
            this.txtFloorName.Name = "txtFloorName";
            this.txtFloorName.Size = new System.Drawing.Size(195, 24);
            this.txtFloorName.TabIndex = 4;
            // 
            // txtFloorID
            // 
            this.txtFloorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorID.Location = new System.Drawing.Point(281, 111);
            this.txtFloorID.MaxLength = 10000;
            this.txtFloorID.Multiline = true;
            this.txtFloorID.Name = "txtFloorID";
            this.txtFloorID.ReadOnly = true;
            this.txtFloorID.Size = new System.Drawing.Size(85, 25);
            this.txtFloorID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(189, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 102;
            this.label1.Text = "Floor Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(218, 115);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 19);
            this.lblCity.TabIndex = 101;
            this.lblCity.Text = "FloorID";
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnEdit.Location = new System.Drawing.Point(347, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnClear.Location = new System.Drawing.Point(416, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnOK.Location = new System.Drawing.Point(280, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 30);
            this.btnOK.TabIndex = 6;
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
            this.chkIsActive.Location = new System.Drawing.Point(281, 238);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 5;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // btnFloorID
            // 
            this.btnFloorID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnFloorID.Location = new System.Drawing.Point(376, 112);
            this.btnFloorID.Name = "btnFloorID";
            this.btnFloorID.Size = new System.Drawing.Size(26, 20);
            this.btnFloorID.TabIndex = 2;
            this.btnFloorID.Text = "......";
            this.btnFloorID.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnFloorID.Click += new System.EventHandler(this.btnFloorID_Click);
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.LightGray;
            this.PanelFooter.Location = new System.Drawing.Point(1, 326);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(631, 32);
            this.PanelFooter.TabIndex = 104;
            // 
            // cboBuildingName
            // 
            this.cboBuildingName.AutoEdit = false;
            this.cboBuildingName.AutoSize = false;
            this.cboBuildingName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboBuildingName.DisplayLayout.Appearance = appearance25;
            this.cboBuildingName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cboBuildingName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.BorderColor = System.Drawing.SystemColors.Window;
            this.cboBuildingName.DisplayLayout.GroupByBox.Appearance = appearance26;
            appearance27.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboBuildingName.DisplayLayout.GroupByBox.BandLabelAppearance = appearance27;
            this.cboBuildingName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackColor2 = System.Drawing.SystemColors.Control;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance28.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboBuildingName.DisplayLayout.GroupByBox.PromptAppearance = appearance28;
            this.cboBuildingName.DisplayLayout.MaxColScrollRegions = 1;
            this.cboBuildingName.DisplayLayout.MaxRowScrollRegions = 1;
            appearance29.BackColor = System.Drawing.SystemColors.Window;
            appearance29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboBuildingName.DisplayLayout.Override.ActiveCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.Highlight;
            appearance30.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboBuildingName.DisplayLayout.Override.ActiveRowAppearance = appearance30;
            this.cboBuildingName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboBuildingName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance31.BackColor = System.Drawing.SystemColors.Window;
            this.cboBuildingName.DisplayLayout.Override.CardAreaAppearance = appearance31;
            appearance32.BorderColor = System.Drawing.Color.Silver;
            appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboBuildingName.DisplayLayout.Override.CellAppearance = appearance32;
            this.cboBuildingName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboBuildingName.DisplayLayout.Override.CellPadding = 0;
            appearance33.BackColor = System.Drawing.SystemColors.Control;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance33.BorderColor = System.Drawing.SystemColors.Window;
            this.cboBuildingName.DisplayLayout.Override.GroupByRowAppearance = appearance33;
            appearance34.TextHAlignAsString = "Left";
            this.cboBuildingName.DisplayLayout.Override.HeaderAppearance = appearance34;
            this.cboBuildingName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboBuildingName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.BorderColor = System.Drawing.Color.Silver;
            this.cboBuildingName.DisplayLayout.Override.RowAppearance = appearance35;
            this.cboBuildingName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance36.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboBuildingName.DisplayLayout.Override.TemplateAddRowAppearance = appearance36;
            this.cboBuildingName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboBuildingName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboBuildingName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboBuildingName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cboBuildingName.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            this.cboBuildingName.DropDownWidth = 200;
            this.cboBuildingName.Location = new System.Drawing.Point(280, 155);
            this.cboBuildingName.Name = "cboBuildingName";
            this.cboBuildingName.Size = new System.Drawing.Size(178, 22);
            this.cboBuildingName.TabIndex = 3;
            // 
            // FrmFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 356);
            this.Controls.Add(this.cboBuildingName);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFloorName);
            this.Controls.Add(this.txtFloorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnFloorID);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmFloor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloor";
            this.Load += new System.EventHandler(this.FrmFloor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmFloor_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFloor_KeyDown);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBuildingName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFloorName;
        private System.Windows.Forms.TextBox txtFloorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private Infragistics.Win.Misc.UltraButton btnEdit;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkIsActive;
        private Infragistics.Win.Misc.UltraButton btnFloorID;
        public System.Windows.Forms.Panel PanelFooter;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboBuildingName;
    }
}