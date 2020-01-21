using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using KansaiProject.MainForm;
using BusinessProcessObjects;
using BusinessEntities;
using BLL;
using Infragistics.Win.UltraWinGrid;
using DAL;

namespace TowerManagement.Forms
{
    public partial class FrmBuilding : Form
    {
        public DataTable dt = new DataTable();
        BLL_Building BLLObj = new BLL_Building();

        BLL_City BLLObj_City = new BLL_City();

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

        #region Modifiers

        string MBuildingID = "";
        long MBuilding = 0;
        bool GetRecord = false;
        bool UpdateRecord = false;

        #endregion

        public FrmBuilding()
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
            btnBuildingID.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnBuildingID.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnBuildingID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnBuildingID.Font = GlobalVaribles.btnFontStyle;
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

        public void GetMaxBuildingID()
        {
            MBuildingID = BLLObj.GetMaxBuildingID();
            dt = GlobalVaribles.DeserializeDataTable(MBuildingID);
            if (dt.Rows.Count > 0)
            {
                MBuilding = long.Parse(dt.Rows[0]["BuildingID"].ToString());
                txtBuildingID.Text = MBuilding.ToString();
            }
        }

        bool DuplicationCheck()
        {
            bool IsDuplicate = false;
            string str = BLLObj.DuplicationCheck(txtBuildingName.Text);
            DataTable dtduplicate = GlobalVaribles.DeserializeDataTable(str);
            if (dtduplicate != null)
            {
                if (dtduplicate.Rows.Count > 0)
                {
                    FrmMessage message = new FrmMessage("Error Code: SA-003 \n Error Message: Failed to update. \nSame record already exists in the system.", 1);
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
            BLL.NewWebServices.BE_Building NewBEObj = new BLL.NewWebServices.BE_Building();
            //NewBEObj.BuildingID = txtBuildingID.Text.ToString();
            NewBEObj.BuildingName = txtBuildingName.Text;
            NewBEObj.Address = txtAddress.Text;
            NewBEObj.CityID = int.Parse(cboCityName.Value.ToString());
            NewBEObj.Created_Id = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            //NewBEObj.Created_Id = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            NewBEObj.Created_At = GlobalVaribles.CurrentServerTime;
            IsSave = BLLObj.SaveRecord(NewBEObj);
            return IsSave;
        }

        public void LoadAllCities(UltraCombo cbo)
        {
            try
            {
                string str = BLLObj_City.LoadAllCity();
                dt = GlobalVaribles.DeserializeDataTable(str);
                //sqlDataAdapter.Fill(dataTable);
                cbo.DataSource = dt;
                cbo.ValueMember = "CityID";
                cbo.DisplayMember = "CityName";
                cbo.DisplayLayout.Bands[0].Columns["CityID"].Hidden = true;
                cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
                cbo.Value = 0;
            }
            catch (Exception)
            {
                
                //throw;
            }
            
           
        }

        private void ClearForm()
        {
            UpdateRecord = false;
            txtBuildingName.Text = "";
            txtBuildingID.Text = "";
            txtAddress.Text = "";
            btnOK.Enabled = true;
            btnEdit.Enabled = false;
            txtBuildingName.Focus();
            GetMaxBuildingID();
            cboCityName.DataSource = null;
            LoadAllCities(cboCityName);

        }

        bool UpdateRecordBuilding()
        {
            bool IsUpdate = false;
            BLL.NewWebServices.BE_Building NewBEObj = new BLL.NewWebServices.BE_Building();
            NewBEObj.BuildingID = Convert.ToInt32(txtBuildingID.Text);
            NewBEObj.BuildingName = txtBuildingName.Text;
            NewBEObj.Address = txtAddress.Text;
            NewBEObj.CityID = int.Parse(cboCityName.Value.ToString());
            NewBEObj.Modify_At = GlobalVaribles.CurrentServerTime;
            NewBEObj.Modify_ID = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            //NewBEObj.Modify_ID = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            IsUpdate = BLLObj.UpdateRecord(NewBEObj);
            return IsUpdate;
        }

        bool ValidateForm()
        {
            bool IsValidate = false;
            //bool ISCity = GlobalVaribles.IsString(txtCityName.Text);

            if (cboCityName.Value == null)
            {
                FrmMessage message = new FrmMessage("Error Code: SA-004 \nError Message: Please Select City\n                                Name.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
                message.ShowDialog();
               // MessageBox.Show("Please Select the City Name", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboCityName.Focus();
                return false;
            }

            else if (string.IsNullOrEmpty(txtBuildingName.Text))
            {
                FrmMessage message = new FrmMessage("Error Code: SA-005 \nError Message: You cannot leave Building\n                                Name blank.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
                message.ShowDialog();
                txtBuildingName.Focus();
                IsValidate = false;
            }
           
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                FrmMessage message = new FrmMessage("Error Code: SA-006 \nError Message: You cannot leave Address\n                                blank.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
                message.ShowDialog();
                txtAddress.Focus();
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

        public void LoadCityByBuildingID(UltraCombo cbo, int BuildingID)
        {

            string str = BLLObj_City.LoadAllCity();
            dt = GlobalVaribles.DeserializeDataTable(str);
            //sqlDataAdapter.Fill(dataTable);
            cbo.DataSource = dt;
            cbo.ValueMember = "CityID";
            cbo.DisplayMember = "CityName";
            cbo.DisplayLayout.Bands[0].Columns["CityID"].Hidden = true;
            cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;

            string strr = BLLObj.LoadCityByBuildingID(BuildingID);
            dt = GlobalVaribles.DeserializeDataTable(strr);
            cbo.Value = Convert.ToInt32(dt.Rows[0]["CityID"]);

            //cbo.DataSource = dt;
            //cbo.ValueMember = "CityID";
            //cbo.DisplayMember = "CityName";
            //cbo.DisplayLayout.Bands[0].Columns["CityID"].Hidden = true;
            //cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
            //cbo.Value = BuildingID;
            // cbo.ReadOnly = true;
        }

        #endregion

        #region Events

        private void FrmBuilding_Load(object sender, EventArgs e)
        {
            FormDesign();
            btnEdit.Enabled = false;
            LoadAllCities(cboCityName);
            GetMaxBuildingID();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBuilding_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(GlobalVaribles.BorderColor);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void FrmBuilding_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FrmConfirmationMessage message = new FrmConfirmationMessage(GlobalVaribles.ConfirmationMsg, 2, this);
                message.ShowDialog();
            }
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
                            MessageBox.Show("Record Inserted Successfully", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Duplicate Record", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            //FrmMessage message = new FrmMessage("City Saved", 0);
                            //message.lblSuccess.Text = "Success";
                            //message.ShowDialog();
                            ClearForm();

                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
           

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
              
                if (UpdateRecordBuilding())
                {
                    MessageBox.Show("Record Updated Successfully", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FrmMessage message = new FrmMessage("City Updated", 0);
                    //message.lblSuccess.Text = "Success";
                    //message.ShowDialog();
                    ClearForm();
                    btnEdit.Enabled = false;
                    btnOK.Enabled = true;
                    LoadAllCities(cboCityName);
                }

            }
        }

        private void btnBuildingID_Click(object sender, EventArgs e)
        {
            object rValue;
            try
            {
                string str = BLLObj.LoadAllBuilding();

                GlobalVaribles.dtGSearch = GlobalVaribles.DeserializeDataTable(str);

                rValue = FrmGSearch.Show("Select", false, "All Building");
                if (rValue == null)
                    return;
                MBuilding = long.Parse(rValue.ToString());
                DataTable dt = new DataTable();
                // GetCityIDByCityValue(Convert.ToInt32(MCity));
                string strs = BLLObj.GetBuildingByID(Convert.ToInt32(MBuilding));
                dt = GlobalVaribles.DeserializeDataTable(strs);

                if (dt != null && dt.Rows.Count > 0)
                {
                    UpdateRecord = true;
                    GetRecord = true;
                    LoadCityByBuildingID(cboCityName,Convert.ToInt32(MBuilding));

                    txtBuildingID.Text = dt.Rows[0]["BuildingID"].ToString();
                    txtBuildingName.Text = dt.Rows[0]["BuildingName"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
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

