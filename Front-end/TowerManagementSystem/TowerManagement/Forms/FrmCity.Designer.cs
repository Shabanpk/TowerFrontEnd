namespace TowerManagement.Forms
{
    partial class FrmCity
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCityID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnEdit = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.btnOK = new Infragistics.Win.Misc.UltraButton();
            this.chkIsActive = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnCityID = new Infragistics.Win.Misc.UltraButton();
            this.PanelHeader.SuspendLayout();
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
            this.PanelHeader.TabIndex = 10;
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
            this.lblheader.Size = new System.Drawing.Size(64, 37);
            this.lblheader.TabIndex = 89;
            this.lblheader.Text = "City";
            // 
            // PanelFooter
            // 
            this.PanelFooter.BackColor = System.Drawing.Color.LightGray;
            this.PanelFooter.Location = new System.Drawing.Point(1, 279);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(631, 32);
            this.PanelFooter.TabIndex = 72;
            // 
            // txtCityName
            // 
            this.txtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityName.Location = new System.Drawing.Point(273, 143);
            this.txtCityName.MaxLength = 100;
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(195, 24);
            this.txtCityName.TabIndex = 3;
            // 
            // txtCityID
            // 
            this.txtCityID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityID.Location = new System.Drawing.Point(274, 102);
            this.txtCityID.MaxLength = 10000;
            this.txtCityID.Multiline = true;
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.ReadOnly = true;
            this.txtCityID.Size = new System.Drawing.Size(85, 25);
            this.txtCityID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(186, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "City Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCity.Location = new System.Drawing.Point(214, 106);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(48, 19);
            this.lblCity.TabIndex = 81;
            this.lblCity.Text = "CityID";
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnEdit.Location = new System.Drawing.Point(342, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 30);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnClear.Location = new System.Drawing.Point(411, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnOK.Location = new System.Drawing.Point(275, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(59, 30);
            this.btnOK.TabIndex = 5;
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
            this.chkIsActive.Location = new System.Drawing.Point(276, 182);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 4;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // btnCityID
            // 
            this.btnCityID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton;
            this.btnCityID.Location = new System.Drawing.Point(369, 103);
            this.btnCityID.Name = "btnCityID";
            this.btnCityID.Size = new System.Drawing.Size(26, 20);
            this.btnCityID.TabIndex = 2;
            this.btnCityID.Text = "......";
            this.btnCityID.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.btnCityID.Click += new System.EventHandler(this.btnCityID_Click);
            // 
            // FrmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 309);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.txtCityID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnCityID);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCity";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCity_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCity_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCity_KeyDown);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblheader;
        public System.Windows.Forms.Panel PanelFooter;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private Infragistics.Win.Misc.UltraButton btnEdit;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraButton btnOK;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkIsActive;
        private Infragistics.Win.Misc.UltraButton btnCityID;
    }
}