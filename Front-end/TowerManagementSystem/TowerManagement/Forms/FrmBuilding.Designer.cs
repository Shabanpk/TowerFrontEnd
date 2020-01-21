namespace TowerManagement.Forms
{
    partial class FrmBuilding
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
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.txtBuildingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnEdit = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.chkIsActive = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnBuildingID = new Infragistics.Win.Misc.UltraButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCityName = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCityName)).BeginInit();
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
            this.PanelHeader.TabIndex = 11;
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
            this.lblheader.Size = new System.Drawing.Size(120, 37);
            this.lblheader.TabIndex = 89;
            this.lblheader.Text = "Building";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.LightGray;
            this.PanelFooter.Location = new System.Drawing.Point(1, 379);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(631, 32);
            this.PanelFooter.TabIndex = 73;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingName.Location = new System.Drawing.Point(262, 192);
            this.txtBuildingName.MaxLength = 100;
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(195, 24);
            this.txtBuildingName.TabIndex = 4;
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingID.Location = new System.Drawing.Point(263, 97);
            this.txtBuildingID.MaxLength = 10000;
            this.txtBuildingID.Multiline = true;
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.ReadOnly = true;
            this.txtBuildingID.Size = new System.Drawing.Size(85, 25);
            this.txtBuildingID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(147, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "Building Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(175, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(76, 19);
            this.lblCity.TabIndex = 90;
            this.lblCity.Text = "BuildingID";
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnEdit.Location = new System.Drawing.Point(329, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnClear.Location = new System.Drawing.Point(398, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnOK.Location = new System.Drawing.Point(262, 315);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 30);
            this.btnOK.TabIndex = 7;
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
            this.chkIsActive.Location = new System.Drawing.Point(263, 285);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 6;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // btnBuildingID
            // 
            this.btnBuildingID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnBuildingID.Location = new System.Drawing.Point(358, 98);
            this.btnBuildingID.Name = "btnBuildingID";
            this.btnBuildingID.Size = new System.Drawing.Size(26, 20);
            this.btnBuildingID.TabIndex = 2;
            this.btnBuildingID.Text = "......";
            this.btnBuildingID.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnBuildingID.Click += new System.EventHandler(this.btnBuildingID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(175, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "City Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(262, 240);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 24);
            this.txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(190, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Address";
            // 
            // cboCityName
            // 
            this.cboCityName.AutoEdit = false;
            this.cboCityName.AutoSize = false;
            this.cboCityName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            appearance25.BackColor = System.Drawing.SystemColors.Window;
            appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCityName.DisplayLayout.Appearance = appearance25;
            this.cboCityName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.cboCityName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance26.BorderColor = System.Drawing.SystemColors.Window;
            this.cboCityName.DisplayLayout.GroupByBox.Appearance = appearance26;
            appearance27.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboCityName.DisplayLayout.GroupByBox.BandLabelAppearance = appearance27;
            this.cboCityName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance28.BackColor2 = System.Drawing.SystemColors.Control;
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance28.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cboCityName.DisplayLayout.GroupByBox.PromptAppearance = appearance28;
            this.cboCityName.DisplayLayout.MaxColScrollRegions = 1;
            this.cboCityName.DisplayLayout.MaxRowScrollRegions = 1;
            appearance29.BackColor = System.Drawing.SystemColors.Window;
            appearance29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboCityName.DisplayLayout.Override.ActiveCellAppearance = appearance29;
            appearance30.BackColor = System.Drawing.SystemColors.Highlight;
            appearance30.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cboCityName.DisplayLayout.Override.ActiveRowAppearance = appearance30;
            this.cboCityName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.cboCityName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance31.BackColor = System.Drawing.SystemColors.Window;
            this.cboCityName.DisplayLayout.Override.CardAreaAppearance = appearance31;
            appearance32.BorderColor = System.Drawing.Color.Silver;
            appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.cboCityName.DisplayLayout.Override.CellAppearance = appearance32;
            this.cboCityName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.cboCityName.DisplayLayout.Override.CellPadding = 0;
            appearance33.BackColor = System.Drawing.SystemColors.Control;
            appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance33.BorderColor = System.Drawing.SystemColors.Window;
            this.cboCityName.DisplayLayout.Override.GroupByRowAppearance = appearance33;
            appearance34.TextHAlignAsString = "Left";
            this.cboCityName.DisplayLayout.Override.HeaderAppearance = appearance34;
            this.cboCityName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.cboCityName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance35.BackColor = System.Drawing.SystemColors.Window;
            appearance35.BorderColor = System.Drawing.Color.Silver;
            this.cboCityName.DisplayLayout.Override.RowAppearance = appearance35;
            this.cboCityName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance36.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboCityName.DisplayLayout.Override.TemplateAddRowAppearance = appearance36;
            this.cboCityName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.cboCityName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.cboCityName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.cboCityName.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007;
            this.cboCityName.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            this.cboCityName.DropDownWidth = 200;
            this.cboCityName.Location = new System.Drawing.Point(263, 148);
            this.cboCityName.Name = "cboCityName";
            this.cboCityName.Size = new System.Drawing.Size(178, 22);
            this.cboCityName.TabIndex = 3;
            // 
            // FrmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 412);
            this.Controls.Add(this.cboCityName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.txtBuildingID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnBuildingID);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuilding";
            this.Load += new System.EventHandler(this.FrmBuilding_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmBuilding_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuilding_KeyDown);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCityName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblheader;
        public System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.TextBox txtBuildingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private Infragistics.Win.Misc.UltraButton btnEdit;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkIsActive;
        private Infragistics.Win.Misc.UltraButton btnBuildingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinGrid.UltraCombo cboCityName;
    }
}