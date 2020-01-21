using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessEntities;
using BusinessProcessObjects;
using TowerManagement.Main_Form;
using TowerManagement.Forms;
using System.Runtime.InteropServices;
using TowerManagement.Report_Forms;
using BLL;

namespace TowerManagement
{
    public partial class FrmLogin : Form
    {
        Form fc = null;
        DAL.DAL_LoginUser NewDLLObj = new DAL.DAL_LoginUser();

        BLL_UserManagement BLL_Obj = new BLL_UserManagement();
        BLL_LoginAuth BLL_Login = new BLL_LoginAuth();
        int i = 0;
        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            
        }

        #region Modifiers

        bool PasswordCheck = false;

        #endregion

        #region Main Panel Variables

        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern bool ReleaseCapture();
        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        #endregion
        
        bool ValidateUser()
        {
            // This function Validate User Name from DB Exist Or Not
            bool IsValid = false;
            i = BLL_Obj.ValidateUser(txtUserName.Text);
            if (i == 0)
                IsValid = true;
            return IsValid;
        }

        bool LoginAuth()
        {
            // This Function Validate password According To The User Name ..
            bool IsValid = false;
            string ss = BLL_Login.LoginAuthorization(txtUserName.Text, txtPassword.Text);
            //string DecryptPass = Decrypt(EncryptPassword);
            //string ss = BLLObj.LoginAuthorization(txtUser.Text, txtPass.Text);
            if (!ss.Trim().Equals("false") && !string.IsNullOrEmpty(ss))
            {
                IsValid = true;
                GlobalVaribles.dtSession = new DataTable();
                GlobalVaribles.dtSession = GlobalVaribles.DeserializeDataTable(ss);
                //string Str = BLL_Login.LoadUserRight(Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"].ToString()));
                string Str = BLL_Login.LoadUserRight(txtUserName.Text);
                DataTable dt = new DataTable();
                dt = GlobalVaribles.DeserializeDataTable(Str);
                if (dt.Rows.Count > 0)
                {
                    GlobalVaribles.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    GlobalVaribles.UserStatus = dt.Rows[0]["UserStatus"].ToString();
                    GlobalVaribles.UserName = dt.Rows[0]["UserName"].ToString();
                    //txtUserID.Text = GlobalVaribles.UserID.ToString();
                    GlobalVaribles.dtSetUser = dt.Copy();
                    SetMenu(GlobalVaribles.UserID);
                }

            }
            else
            {
                IsValid = false;
            }
            return IsValid;
        }


        #region Functions

        private bool CheckUserPassword()
        {
            BE_LoginUser PasswordCheckObj = new BE_LoginUser();
            BP_LoginUser PasswordObj = new BP_LoginUser();
            PasswordCheckObj.UserName = txtUserName.Text;
            PasswordCheckObj.Password = txtPassword.Text;
            PasswordCheck = PasswordObj.CheckUserPassword(PasswordCheckObj);
            return PasswordCheck;
        }

        private void SetUsers()
        {
            BE_LoginUser NewLoginObj = new BE_LoginUser();
            //GlobalVaribles gblVar = new GlobalVaribles();
            BP_LoginUser GlobalBPObj = new BP_LoginUser();
            NewLoginObj.UserName = txtUserName.Text;
            //gblVar.Style = cboStyles.Text;
            DataTable dt = new DataTable();
            dt=GlobalBPObj.GetUserDetail(NewLoginObj);
            if (dt.Rows.Count > 0)
            {
                GlobalVaribles.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                GlobalVaribles.UserStatus = dt.Rows[0]["UserStatus"].ToString();
                GlobalVaribles.UserName = dt.Rows[0]["UserName"].ToString();
                //txtUserID.Text = GlobalVaribles.UserID.ToString();
                GlobalVaribles.dtSetUser = dt.Copy();
                SetMenu(GlobalVaribles.UserID);
            }
        }

        bool ValidateForm()
        {
            bool IsValid = false;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("User Name Empty", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password Empty", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                IsValid = true;
            return IsValid;
        }

        void SetMenu(int UserID)
        {
            GlobalVaribles.dtMainMenu = new DataTable();
            DataTable dt = new DataTable();
            string Str = BLL_Login.GetUserMenuByUserID(UserID);
            dt = GlobalVaribles.DeserializeDataTable(Str);
            if (dt.Rows.Count > 0)
            {
                GlobalVaribles.dtMainMenu = dt.Copy();
            }
        }

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
                mnuChangePassword.Click += new EventHandler(mnuChangePassword_Click);
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
                mnuReports.Click += new EventHandler(mnuReports_Click);
                menu.MenuItems.Add(mnuReports);
            }
            this.Menu = menu;
        }

        #endregion

        #region Events

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //PanelHeader.BackColor = ColorTranslator.FromHtml("#002D40");
           // label1.BackColor = ColorTranslator.FromHtml("#002D40");
            lblLogin.BackColor = ColorTranslator.FromHtml("#002D40");
            lblLogin.BackColor = ColorTranslator.FromHtml("#ECEEF7");
            //label1.BackColor = ColorTranslator.FromHtml("#ECEEF7");
            this.BackColor = ColorTranslator.FromHtml("#ECEEF7");
            label2.BackColor = ColorTranslator.FromHtml("#002D40");
            //PanelFooter.BackColor = ColorTranslator.FromHtml("#DEE1EE");
            panel1.BackColor = ColorTranslator.FromHtml("#DEE1EE");
            panel2.BackColor = ColorTranslator.FromHtml("#DEE1EE");
            lblPass.BackColor = ColorTranslator.FromHtml("#DEE1EE");
            lblUserName.BackColor = ColorTranslator.FromHtml("#DEE1EE");
               
            btnClose.BackColor = ColorTranslator.FromHtml("#002D40");
            btnClose.ForeColor = ColorTranslator.FromHtml("#002D40");

            btnLogin.Appearance.BackColor = ColorTranslator.FromHtml("#002D40");
            btnLogin.Appearance.ForeColor = Color.White;
            btnLogin.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnLogin.Font = new System.Drawing.Font("Open Sans", 9, FontStyle.Bold);

            btnClose.Appearance.BackColor = ColorTranslator.FromHtml("#002D40");
            btnClose.Appearance.ForeColor = Color.White;
            btnClose.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnClose.Font = new System.Drawing.Font("Open Sans", 9, FontStyle.Bold);

            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MMMM dd, yyyy";

            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (LoginAuth())
                {
                   // SetUsers();
                    fc = Application.OpenForms["FrmMainScreen"];
                    if (fc != null)
                    {
                        fc.Close();
                        fc.Dispose();
                        MainSubMenuLoad();
                        //this.Close();
                      //  MainSubMenu();
                        FrmMainScreen frmMain = new FrmMainScreen();
                        frmMain.IsMdiContainer = true;
                        frmMain.ShowDialog();
                        //fc.IsMdiContainer = true;
                        //fc.Menu = menu;
                        //fc.WindowState = FormWindowState.Maximized;
                        //fc.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid UserName/Password", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            //if (ValidateForm())
            //{
            //    if (CheckUserPassword())
            //    {
            //        SetUsers();
            //        fc = Application.OpenForms["FrmMainScreen"];
            //        if (fc != null)
            //        {
            //            fc.Close();
            //            fc.Dispose();
            //            MainSubMenu();
            //            FrmMainScreen frmMain = new FrmMainScreen();
            //            frmMain.IsMdiContainer = true;
            //            frmMain.ShowDialog();

            //        }
            //        else
            //        {
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid UserName/Password", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    }
            //}
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           // Application.Exit();
            this.Close();
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(ColorTranslator.FromHtml("#002D40"));
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
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

        #endregion
    }
}
