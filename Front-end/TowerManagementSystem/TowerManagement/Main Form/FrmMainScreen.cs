﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using System.Reflection;
using TowerManagement.Forms;
using TowerManagement.Report_Forms;
using System.Runtime.InteropServices;

namespace TowerManagement.Main_Form
{
    public partial class FrmMainScreen : Form
    {
        int Second = 0;

        public FrmMainScreen()
        {
            InitializeComponent();
        }

        #region Functions

        //void MainSubMenu()
        //{
        //    MainMenu menu = new MainMenu();
        //    DataTable dt = new DataTable();
        //    dt = GlobalVaribles.dtMainMenu;
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        MenuItem mnuNewSystem = new MenuItem(@"System");

        //        if (Convert.ToInt32(dt.Rows[0]["UserID"]) == 1)
        //        {
        //            mnuNewSystem.Text = "&Admin";
        //            menu.MenuItems.Add(mnuNewSystem);
        //        }
        //        else
        //        {
        //            mnuNewSystem.Text = "S&ystem";
        //            menu.MenuItems.Add(mnuNewSystem);
        //        }
        //        MenuItem mnuChangePassword = new MenuItem("@ChangePassword");
        //        mnuChangePassword.Text = "C&hange Password";
        //        mnuChangePassword.Click += new EventHandler(mnuChangePassword_Click);
        //        mnuNewSystem.MenuItems.Add(mnuChangePassword);

        //        MenuItem mnuLogout = new MenuItem("@Logout");
        //        mnuLogout.Text = "&Logout";
        //        mnuLogout.Click += new EventHandler(mnuLogout_Click);
        //        mnuNewSystem.MenuItems.Add(mnuLogout);

        //        MenuItem mnuExit = new MenuItem("@Exit");
        //        mnuExit.Text = "&Exit";
        //        mnuExit.Click += new EventHandler(mnuExit_Click);
        //        mnuNewSystem.MenuItems.Add(mnuExit);


        //        string menuName = "Configuration";
        //        string menuName1 = "Defination";
        //        string MenuName2 = "Reports";


        //        MenuItem mnuConfiguration = new MenuItem("Configuration");
        //        mnuConfiguration.Text = "Con&figuration";
        //        mnuConfiguration.Index = 0;

        //        MenuItem mnuStock = new MenuItem("Defination");
        //        mnuStock.Text = "&Defination";
        //        mnuStock.Index = 1;


        //        //menu.MenuItems.Add(mnuConfiguration);
        //        // Load Menu Configuration
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            string childmenu = "User Management";
        //            int i = 0;
        //            string DBValue = dr["DisplayName"].ToString();

        //            if (DBValue == childmenu)
        //            {

        //                MenuItem mnuUserManagement = new MenuItem("&UserManagement");
        //                mnuUserManagement.Text = "&User Management";
        //                mnuUserManagement.Index = 0;
        //                mnuUserManagement.Click += new EventHandler(mnuUserManagement_Click);
        //                mnuConfiguration.MenuItems.Add(mnuUserManagement);
        //                if (i == 0)
        //                {
        //                    menu.MenuItems.Add(mnuConfiguration);
        //                    i++;
        //                }
        //            }
        //        }

        //        // Load Menu Stock
        //        foreach (DataRow drr in dt.Rows)
        //        {
        //            string childmenuname1 = "Version";
        //            string childmenuname2 = "Customer Information";
        //            string childmenuname3 = "Building Parameter";
        //            string childmenuname4 = "Customer Status";
        //            int i = 0;
        //            string DBValue = drr["DisplayName"].ToString();
        //            if (DBValue == childmenuname1)
        //            {
        //                MenuItem mnuVersion = new MenuItem("&Version");
        //                mnuVersion.Text = "&Version";
        //                mnuVersion.Index = 0;
        //                mnuVersion.Click += new EventHandler(mnuVersion_Click); mnuStock.MenuItems.Add(mnuVersion);
        //                if (i == 0)
        //                {
        //                    menu.MenuItems.Add(mnuStock);
        //                    i++;
        //                }
        //            }
        //            else if (DBValue == childmenuname2)
        //            {
        //                MenuItem mnuCustomerInfo = new MenuItem("&CustomerInformation");
        //                mnuCustomerInfo.Text = "&Customer Information";
        //                mnuCustomerInfo.Index = 1;
        //                mnuCustomerInfo.Click += new EventHandler(mnuCustomerInfo_Click);
        //                mnuStock.MenuItems.Add(mnuCustomerInfo);
        //                if (i == 0)
        //                {
        //                    menu.MenuItems.Add(mnuStock);
        //                    i++;
        //                }
        //            }
        //            else if (DBValue == childmenuname3)
        //            {
        //                MenuItem mnuBuildingPar = new MenuItem("&BuildingParameter");
        //                mnuBuildingPar.Text = "&Building Parameter";
        //                mnuBuildingPar.Index = 2;
        //                mnuBuildingPar.Click += new EventHandler(mnuBuildingPar_Click);
        //                mnuStock.MenuItems.Add(mnuBuildingPar);
        //                if (i == 0)
        //                {
        //                    menu.MenuItems.Add(mnuStock);
        //                    i++;
        //                }
        //            }
        //            else if (DBValue == childmenuname4)
        //            {
        //                MenuItem mnuCustomerStatus = new MenuItem("&CustomerStatus");
        //                mnuCustomerStatus.Text = "Customer &Status";
        //                mnuCustomerStatus.Index = 3;
        //                mnuCustomerStatus.Click += new EventHandler(mnuCustomerStatus_Click);
        //                mnuStock.MenuItems.Add(mnuCustomerStatus);
        //                if (i == 0)
        //                {
        //                    menu.MenuItems.Add(mnuStock);
        //                    i++;
        //                }
        //            }
        //        }

        //        // Load Menu Reports
        //        MenuItem mnuReports = new MenuItem(@"Reports");
        //        mnuReports.Text = "&Reports";
        //        mnuReports.Click += new EventHandler(mnuReports_Click);
        //        menu.MenuItems.Add(mnuReports);
        //    }
        //    this.Menu = menu;
        //}

        void MainSubMenuLoad()
        {
            MainMenu menu = new MainMenu();
            DataTable dt = new DataTable();
            dt = GlobalVaribles.dtMainMenu;
            if (dt != null && dt.Rows.Count > 0)
            {
                MenuItem mnuNewSystem = new MenuItem(@"System");

                if (Convert.ToInt32(dt.Rows[0]["UserID"]) == 1)
                {
                    mnuNewSystem.Text = "&Admin";
                    menu.MenuItems.Add(mnuNewSystem);
                }
                else
                {
                    mnuNewSystem.Text = "S&ystem";
                    menu.MenuItems.Add(mnuNewSystem);
                }
                MenuItem mnuChangePassword = new MenuItem("@ChangePassword");
                mnuChangePassword.Text = "C&hange Password";
                mnuChangePassword.Click+=new EventHandler(mnuChangePassword_Click);
                mnuNewSystem.MenuItems.Add(mnuChangePassword);

                MenuItem mnuLogout = new MenuItem("@Logout");
                mnuLogout.Text = "&Logout";
                mnuLogout.Click += new EventHandler(mnuLogout_Click);
                mnuNewSystem.MenuItems.Add(mnuLogout);

                MenuItem mnuExit = new MenuItem("@Exit");
                mnuExit.Text = "&Exit";
                mnuExit.Click += new EventHandler(mnuExit_Click);
                mnuNewSystem.MenuItems.Add(mnuExit);


                string menuName = "Configuration";
                string menuName1 = "Defination";
                string menuName2 = "Billing";
                string menuName3 = "Accounts";
                string MenuName4 = "Reports";



                MenuItem mnuConfiguration = new MenuItem("Configuration");
                mnuConfiguration.Text = "Con&figuration";
                mnuConfiguration.Index = 0;

                MenuItem mnuStock = new MenuItem("Defination");
                mnuStock.Text = "&Defination";
                mnuStock.Index = 1;

                MenuItem mnuMonthyBilling = new MenuItem("Monthly Billing");
                mnuMonthyBilling.Text = "Monthly &Billing";
                mnuMonthyBilling.Index = 2;

                MenuItem mnuAccounts = new MenuItem("Accounts");
                mnuAccounts.Text = "&Accounts";
                mnuAccounts.Index = 3;

                //menu.MenuItems.Add(mnuConfiguration);
                // Load Menu Configuration
                foreach (DataRow dr in dt.Rows)
                {
                    string childmenu = "User Management";
                    int i = 0;
                    string DBValue = dr["DisplayName"].ToString();

                    if (DBValue == childmenu)
                    {

                        MenuItem mnuUserManagement = new MenuItem("&UserManagement");
                        mnuUserManagement.Text = "&User Management";
                        mnuUserManagement.Index = 0;
                        mnuUserManagement.Click += new EventHandler(mnuUserManagement_Click);
                        mnuConfiguration.MenuItems.Add(mnuUserManagement);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuConfiguration);
                            i++;
                        }
                    }
                }

                // Load Menu Definations
                foreach (DataRow drr in dt.Rows)
                {
                    string childmenuname1 = "City";
                    string childmenuname2 = "Building";
                    string childmenuname3 = "Floor";
                    string childmenuname4 = "Office";
                    int i = 0;
                    string DBValue = drr["DisplayName"].ToString();
                    if (DBValue == childmenuname1)
                    {
                        MenuItem mnuCity = new MenuItem("&City");
                        mnuCity.Text = "&City";
                        mnuCity.Index = 0;
                        mnuCity.Click += new EventHandler(mnuCity_Click); 
                        mnuStock.MenuItems.Add(mnuCity);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuStock);
                            i++;
                        }
                    }
                    else if (DBValue == childmenuname2)
                    {
                        MenuItem mnuBuilding = new MenuItem("&Building");
                        mnuBuilding.Text = "&Building";
                        mnuBuilding.Index = 1;
                        mnuBuilding.Click += new EventHandler(mnuBuilding_Click);
                        mnuStock.MenuItems.Add(mnuBuilding);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuStock);
                            i++;
                        }
                    }
                    else if (DBValue == childmenuname3)
                    {
                        MenuItem mnuFloor = new MenuItem("&Floor");
                        mnuFloor.Text = "&Floor";
                        mnuFloor.Index = 2;
                        mnuFloor.Click += new EventHandler(mnuFloor_Click);
                        mnuStock.MenuItems.Add(mnuFloor);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuStock);
                            i++;
                        }
                    }
                    else if (DBValue == childmenuname4)
                    {
                        MenuItem mnuOffice = new MenuItem("&Office");
                        mnuOffice.Text = "Office";
                        mnuOffice.Index = 3;
                        mnuOffice.Click += new EventHandler(mnuOffice_Click);
                        mnuStock.MenuItems.Add(mnuOffice);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuStock);
                            i++;
                        }
                    }
                }


                // Load Menu Monthly Billing
                foreach (DataRow dr in dt.Rows)
                {
                    string childmenu = "Monthly Billing";
                    int i = 0;
                    string DBValue = dr["DisplayName"].ToString();

                    if (DBValue == childmenu)
                    {

                        MenuItem mnuMonthlyBilling = new MenuItem("Monthly &Billing");
                        mnuMonthlyBilling.Text = "&Billing and Reading";
                        mnuMonthlyBilling.Index = 0;
                        mnuMonthlyBilling.Click += new EventHandler(mnuMonthlyBilling_Click);
                        mnuMonthyBilling.MenuItems.Add(mnuMonthlyBilling);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuMonthyBilling);
                            i++;
                        }
                    }
                }

                // Load Menu Accounts 
                foreach (DataRow dr in dt.Rows)
                {
                    string childmenu = "Accounts";
                    int i = 0;
                    string DBValue = dr["DisplayName"].ToString();

                    if (DBValue == childmenu)
                    {

                        MenuItem mnuAcco = new MenuItem("Accounts");
                        mnuAcco.Text = "&Account and Finance";
                        mnuAcco.Index = 0;
                        mnuAcco.Click += new EventHandler(mnuAccounts_Click);
                        mnuAccounts.MenuItems.Add(mnuAcco);
                        if (i == 0)
                        {
                            menu.MenuItems.Add(mnuAccounts);
                            i++;
                        }
                    }
                }

                // Load Menu Reports
                MenuItem mnuReports = new MenuItem(@"Reports");
                mnuReports.Text = "&Reports";
                mnuReports.Click +=new EventHandler(mnuReports_Click);
                menu.MenuItems.Add(mnuReports);
            }
            this.Menu = menu;
        }
        
        #endregion

        #region Events

        private void FrmMainScreen_Load(object sender, EventArgs e)
        {
            //pictureBox2.Location = new Point(450,10);
            //pictureBox3.Location = new Point(550,10);
            //pictureBox4.Location = new Point(650, 10);
            //pictureBox5.Location = new Point(750, 10);
            //pictureBox6.Location = new Point(850, 10);
            //pictureBox7.Location = new Point(950, 10);
            //pictureBox9.Location = new Point(1050, 10);
            //pictureBox8.Location = new Point(1150, 10);
            //pictureBox1.Location = new Point(1430, 1);

            //PnlUserMang.Location = new Point(14, 25);
            //PnlWelfare.Location = new Point(14, 80);
            //PnlGuest.Location = new Point(14, 130);
            //pnlUnit.Location = new Point(14,180);
            //PnlGroup.Location = new Point(14, 230);
            //PnlItem.Location = new Point(14, 280);
            //PnlPassword.Location = new Point(14, 330);
            //PnlExit.Location = new Point(14, 380);
            //PnlLogout.Location = new Point(14, 430);
            

            timer1.Interval = 1000;
            timer1.Start();
            string UserName = GlobalVaribles.UserName;
            StatusBar.Items["lblStatusBarLogin"].Text = "Welcome " + UserName;
            StatusBar.Items["lblStatusBarReady"].Text = "Ready     " + GlobalVaribles.SoftwareVersion;
            //GlobalVaribles.HideProgressBar();
            //MainSubMenu();
            MainSubMenuLoad();

            //panel1.BackColor = ColorTranslator.FromHtml("#002D40");
            //panel4.BackColor = ColorTranslator.FromHtml("#002D40");
            //pictureBox1.BackColor = ColorTranslator.FromHtml("#002D40");
            
            //label1.BackColor = ColorTranslator.FromHtml("#002D40");
            //label1.ForeColor = Color.White;
            //label2.BackColor = ColorTranslator.FromHtml("#002D40");
            //label2.ForeColor = Color.White;
            //label3.BackColor = ColorTranslator.FromHtml("#002D40");
            //label3.ForeColor = Color.White;
            //label4.BackColor = ColorTranslator.FromHtml("#002D40");
            //label4.ForeColor = Color.White;
            panel2.BackColor = ColorTranslator.FromHtml("#7E502F");
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;

            //panel3.BackColor = ColorTranslator.FromHtml("#002D40");
            //label9.ForeColor = Color.White;
            //label10.ForeColor = Color.White;
            //label11.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StatusBar.Items["lblStatusBarDatetime"].Text = DateTime.Now.ToString("dd MMMM yyyy hh:mm:ss tt");
            Second = Second + 1;
            string UserName = GlobalVaribles.UserName;
            StatusBar.Items["lblStatusBarLogin"].Text = "Welcome " + UserName;
        }

        #region Events Form Click

        void mnuUserManagement_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmUserManagement"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmUserManagement f1 = new FrmUserManagement();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }

        }
        void mnuOffice_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmOffice"];
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

        void mnuFloor_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmFloor"];
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

        void mnuBuilding_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmBuilding"];
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

        void mnuCity_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmCity"];
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
        void mnuChangePassword_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["FrmPasswordChange"];
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

        void mnuLogout_Click(object sender, EventArgs e)
        {
            GlobalVaribles.UserID = 0;
            FrmLogin frmLogin = new FrmLogin();
            //this.WindowState = FormWindowState.Minimized;
            frmLogin.ShowDialog();
        }

        void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void mnuReports_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmReportForm"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmReportForm f1 = new FrmReportForm();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }

        void mnuAccounts_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmAccounts"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmAccounts f1 = new FrmAccounts();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }


        void mnuMonthlyBilling_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FrmReadingAndBilling"];
            Form fcParentMenu = Application.OpenForms["FrmMainScreen"];
            if (fc != null)
            {
                fc.Focus();
            }
            else
            {
                FrmReadingAndBilling f1 = new FrmReadingAndBilling();
                f1.MdiParent = fcParentMenu;
                f1.Show();
            }
        }


        #endregion

        #region PanelColoring

        private void PnlWelfare_MouseHover(object sender, EventArgs e)
        {
            //PnlWelfare.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblWelf.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlWelfare_MouseLeave(object sender, EventArgs e)
        {
            //PnlWelfare.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblWelf.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlUserMang_MouseHover(object sender, EventArgs e)
        {
            //PnlUserMang.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblUser.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlUserMang_MouseLeave(object sender, EventArgs e)
        {
            //PnlUserMang.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblUser.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlGuest_MouseHover(object sender, EventArgs e)
        {
            //PnlGuest.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblGuest.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlGuest_MouseLeave(object sender, EventArgs e)
        {
            //PnlGuest.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblGuest.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void pnlUnit_MouseHover(object sender, EventArgs e)
        {
            //pnlUnit.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblUnit.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void pnlUnit_MouseLeave(object sender, EventArgs e)
        {
            //pnlUnit.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblUnit.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlGroup_MouseHover(object sender, EventArgs e)
        {
            //PnlGroup.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblGroup.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlGroup_MouseLeave(object sender, EventArgs e)
        {
            //PnlGroup.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblGroup.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlItem_MouseHover(object sender, EventArgs e)
        {
            //PnlItem.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblItem.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlItem_MouseLeave(object sender, EventArgs e)
        {
        //    PnlItem.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        //    lblItem.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlPassword_MouseHover(object sender, EventArgs e)
        {
            //PnlPassword.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblChangePass.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlPassword_MouseLeave(object sender, EventArgs e)
        {
            //PnlPassword.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblChangePass.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlExit_MouseHover(object sender, EventArgs e)
        {
            //PnlExit.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblExit.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlExit_MouseLeave(object sender, EventArgs e)
        {
            //PnlExit.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblExit.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        private void PnlLogout_MouseHover(object sender, EventArgs e)
        {
            //PnlLogout.BackColor = GlobalVaribles.MainPnlBackHoverColor;
            //lblLogout.BackColor = GlobalVaribles.MainPnlBackHoverColor;
        }

        private void PnlLogout_MouseLeave(object sender, EventArgs e)
        {
            //PnlLogout.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
            //lblLogout.BackColor = GlobalVaribles.MainPnlBackLeaveColor;
        }

        #endregion

        #endregion

    }
}
