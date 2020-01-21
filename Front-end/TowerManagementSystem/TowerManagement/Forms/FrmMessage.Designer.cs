namespace KansaiProject.MainForm
{
    partial class FrmMessage
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
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pixBox = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.lblSuccess);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(403, 32);
            this.PanelHeader.TabIndex = 7;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // lblSuccess
            // 
            this.lblSuccess.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSuccess.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblSuccess.Location = new System.Drawing.Point(9, 4);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(90, 21);
            this.lblSuccess.TabIndex = 91;
            this.lblSuccess.Text = "Error";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(129, 101);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(70, 32);
            this.btnok.TabIndex = 72;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMessage.Location = new System.Drawing.Point(126, 43);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(163, 18);
            this.lblMessage.TabIndex = 73;
            this.lblMessage.Text = "Record Saved Sucessfully";
            // 
            // pixBox
            // 
            this.pixBox.Location = new System.Drawing.Point(22, 52);
            this.pixBox.Name = "pixBox";
            this.pixBox.Size = new System.Drawing.Size(90, 81);
            this.pixBox.TabIndex = 74;
            this.pixBox.TabStop = false;
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(403, 149);
            this.Controls.Add(this.pixBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessage";
            this.Load += new System.EventHandler(this.FrmMessage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMessage_KeyDown);
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pixBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pixBox;
        public System.Windows.Forms.Label lblSuccess;
    }
}