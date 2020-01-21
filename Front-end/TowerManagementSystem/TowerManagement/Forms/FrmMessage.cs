using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace KansaiProject.MainForm
{
    public partial class FrmMessage : Form
    {

        #region Form Move Variables & Methods

        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern bool ReleaseCapture();
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion

        public FrmMessage(string Msg,int Index)
        {
            InitializeComponent();
            DisplayImage(Index);
            lblMessage.Text = Msg;
        }

        #region Functions

        void DisplayImage(int PixIndex)
        {
            switch (PixIndex)
            {
                case 0:
                    {
                        pixBox.Image = TowerManagement.Properties.Resources.Tick3;
                        break;
                    }
                case 1:
                    {
                        pixBox.Image = TowerManagement.Properties.Resources.Error2;
                        break;
                    }
                case 2:
                    {
                        pixBox.Image = TowerManagement.Properties.Resources.Information;
                        break;
                    }
            }

        }

        void MsgFormatting(string strMsg)
        {
            strMsg = lblMessage.Text;
            string[] code = strMsg.Split(':');
            string errorcode = code[0];
            if (errorcode == "Error Code")
            {
                
                //var result = Regex.Replace("The allergy type a1c should be written A1C.",@"a1c",@"<b>"+ errorcode + </b>",RegexOptions.IgnoreCase);
            }
        }

        #endregion

        #region Events

        private void FrmMessage_Load(object sender, EventArgs e)
        {
            btnok.BackColor = ColorTranslator.FromHtml("#53a2b3");
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#75B4C1");
            btnok.FlatAppearance.MouseOverBackColor = col;
            btnok.FlatAppearance.BorderSize = 0;
            MsgFormatting(lblMessage.Text);
        }

        private void FrmMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
