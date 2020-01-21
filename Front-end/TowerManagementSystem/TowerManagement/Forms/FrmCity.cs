using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KansaiProject.MainForm;
using System.Runtime.InteropServices;
using BLL;
using DAL;

namespace TowerManagement.Forms
{
    public partial class FrmCity : Form
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

        public DataTable dt = new DataTable();
        BLL_City BLLObj = new BLL_City();

        #region Modifiers

        string MCityID = "";
        long MCity= 0;
        bool GetRecord = false;
        bool UpdateRecord = false;

        #endregion

        public FrmCity()
        {
            InitializeComponent();
        }

        #region Functions

        public void FormDesign()
        {
            PanelHeader.BackColor = GlobalVaribles.PanelHeader;
            lblheader.BackColor = GlobalVaribles.PanelHeader;
            lblheader.ForeColor = GlobalVaribles.lblheaderforeColor;
            btnClose.BackColor = GlobalVaribles.btnCloseBackColor;
            btnClose.FlatAppearance.BorderSize = GlobalVaribles.btnCloseBorder;
            this.BackColor = GlobalVaribles.FormColor;
            btnCityID.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnCityID.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnCityID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnCityID.Font = GlobalVaribles.btnFontStyle;
            btnOK.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnOK.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnOK.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnOK.Font = GlobalVaribles.btnFontStyle;
            btnClear.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnClear.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnClear.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnClear.Font = GlobalVaribles.btnFontStyle;
            btnEdit.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnEdit.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnEdit.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnEdit.Font = GlobalVaribles.btnFontStyle;
            PanelFooter.BackColor = GlobalVaribles.PanelFooter;
        }

        public void LoadAllCities()
        {
            string str = BLLObj.LoadAllCity();
            dt = GlobalVaribles.DeserializeDataTable(str);

        }

        bool ValidateForm()
        {
            bool IsValidate = false;
           // bool ISCity = GlobalVaribles.IsString(txtCityName.Text);
            if (string.IsNullOrEmpty(txtCityName.Text))
            {
                FrmMessage message = new FrmMessage("Error Code: SA-001 \nError Message: You cannot leave City\n                                Name blank.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
              //  MessageBox.Show("Please enter City Name", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                message.ShowDialog();
                txtCityName.Focus();
                IsValidate = false;
            }
            //else if (!ISCity)
            //{
            //    FrmMessage frmmsg = new FrmMessage(GlobalVaribles.InvalidCredential, 1);
            //    frmmsg.ShowDialog();
            //    IsValidate = false;
            //    txtCityName.Focus();
            //}
           
            else
                IsValidate = true;
            return IsValidate;
        }

        bool DuplicationCheck()
        {
            bool IsDuplicate = false;
            string str = BLLObj.DuplicationCheck(txtCityName.Text);
            DataTable dtduplicate = GlobalVaribles.DeserializeDataTable(str);
            if (dtduplicate != null)
            {
                if (dtduplicate.Rows.Count > 0)
                {
                    FrmMessage message = new FrmMessage("Error Code: SA-002 \n Error Message: Failed to update. \nSame record already exists in the system.", 1);
                    message.ShowDialog();
                    IsDuplicate = true;
                }
                else
                {
                    IsDuplicate = false;
                }
            }
            return IsDuplicate;
        }

        bool SaveRecord()
        {
            bool IsSave = false;
            bool IsString = false;
            IsString = GlobalVaribles.IsString(txtCityName.Text);
            BLL.NewWebServices.BE_City NewBEObj = new BLL.NewWebServices.BE_City();
            NewBEObj.CityName = txtCityName.Text;
            //NewBEObj.Created_Id = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            NewBEObj.Created_Id = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            NewBEObj.Created_At = GlobalVaribles.CurrentServerTime;
            NewBEObj.Modify_At = GlobalVaribles.CurrentServerTime;
            IsSave = BLLObj.SaveRecord(NewBEObj);
            return IsSave;
        }

        private void ClearForm()
        {
            UpdateRecord = false;
            txtCityName.Text = "";
            txtCityID.Text = "";
            btnOK.Enabled = true;
            btnEdit.Enabled = false;
            txtCityName.Focus();
        }

        public void GetMaxCityID()
        {
            MCityID = BLLObj.GetMaxCityID();
            dt = GlobalVaribles.DeserializeDataTable(MCityID);
            if (dt.Rows.Count > 0)
            {
                MCity = long.Parse(dt.Rows[0]["CityID"].ToString());
                txtCityID.Text = MCity.ToString();
            }
        }

        bool UpdateRecordCity()
        {
            bool IsUpdate = false;
            BLL.NewWebServices.BE_City NewBEObj = new BLL.NewWebServices.BE_City();
            //string[] ID = lblId.Text.Split(':');
            NewBEObj.CityID = Convert.ToInt32(txtCityID.Text);
            NewBEObj.CityName = txtCityName.Text;
            NewBEObj.Modify_At = GlobalVaribles.CurrentServerTime;
            //NewBEObj.Modify_ID = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            NewBEObj.Modify_ID = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            IsUpdate = BLLObj.UpdateRecord(NewBEObj);
            return IsUpdate;
        }

        #endregion

        #region  Events

        private void FrmCity_Load(object sender, EventArgs e)
        {
            FormDesign();
            GetMaxCityID();
            btnEdit.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!UpdateRecord)
            {
                if (ValidateForm())
                {
                    if (!DuplicationCheck())
                    {
                        if (SaveRecord())
                        {
                            //MessageBox.Show("Record Inserted Successfully", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Duplicate Record", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            FrmMessage message = new FrmMessage("City Saved", 0);
                            message.lblSuccess.Text = "Success";
                            message.ShowDialog();
                            ClearForm();
                            GetMaxCityID();
                            
                        }
                    }
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (UpdateRecordCity())
                {
                     MessageBox.Show("Record Updated Successfully", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FrmMessage message = new FrmMessage("City Updated", 0);
                    //message.lblSuccess.Text = "Success";
                    //message.ShowDialog();
                    ClearForm();
                    GetMaxCityID();
                    btnEdit.Enabled = false;
                    btnOK.Enabled = true;
                }
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            GetMaxCityID();
        }

        private void FrmCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FrmConfirmationMessage message = new FrmConfirmationMessage(GlobalVaribles.ConfirmationMsg, 2, this);
                message.ShowDialog();
            }
        }

        private void FrmCity_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(GlobalVaribles.BorderColor);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnCityID_Click(object sender, EventArgs e)
        {
             object rValue;
             try
             {
                 string str = BLLObj.LoadAllCity();
                 
                GlobalVaribles.dtGSearch = GlobalVaribles.DeserializeDataTable(str);

                 rValue = FrmGSearch.Show("Select", false, "All Cities");
                 if (rValue == null)
                     return;
                 MCity = long.Parse(rValue.ToString());
                 DataTable dt = new DataTable();
                 // GetCityIDByCityValue(Convert.ToInt32(MCity));
                 string strs = BLLObj.GetCityIDByCityValue(Convert.ToInt32(MCity));
                 dt = GlobalVaribles.DeserializeDataTable(strs);

                 if (dt != null && dt.Rows.Count > 0)
                 {
                     UpdateRecord = true;
                     GetRecord = true;
                     txtCityID.Text = dt.Rows[0]["CityID"].ToString();
                     txtCityName.Text = dt.Rows[0]["CityName"].ToString();
                     chkIsActive.CheckedValue = bool.Parse(dt.Rows[0]["Status"].ToString());
                     btnEdit.Enabled = true;
                     btnOK.Enabled = false;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }

        }

        #endregion

    }
}
