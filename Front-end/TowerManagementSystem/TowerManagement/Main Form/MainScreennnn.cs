using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TowerManagement.Forms;

namespace TowerManagement.Main_Form
{
    public partial class MainScreennnn : Form
    {
        public MainScreennnn()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmLogin f1 = new FrmLogin();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmPasswordChange f1 = new FrmPasswordChange();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buildingDefineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmBuilding f1 = new FrmBuilding();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmCity f1 = new FrmCity();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

        private void floorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmFloor f1 = new FrmFloor();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

        private void officeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmOffice f1 = new FrmOffice();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

    }
}
