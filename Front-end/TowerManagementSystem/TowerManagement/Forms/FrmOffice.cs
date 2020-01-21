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
using BLL;
using Infragistics.Win.UltraWinGrid;
using DAL;

namespace TowerManagement.Forms
{
    public partial class FrmOffice : Form
    {
        public DataTable dt = new DataTable();
        BLL_Building BLLObj_Building = new BLL_Building();
        BLL_Offices BLLObj = new BLL_Offices();

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
        int BuildingID = 0;
        string MOfficeID = "";
        long Moffice = 0;
        bool GetRecord = false;
        bool UpdateRecord = false;

        #endregion

        public FrmOffice()
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
            btnOfficeID.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnOfficeID.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnOfficeID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnOfficeID.Font = GlobalVaribles.btnFontStyle;
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

        public void GetMaxOfficeID()
        {
            MOfficeID = BLLObj.GetMaxOfficeID();
            dt = GlobalVaribles.DeserializeDataTable(MOfficeID);
            if (dt.Rows.Count > 0)
            {
                Moffice = long.Parse(dt.Rows[0]["OfficeID"].ToString());
                txtOfficeID.Text = Moffice.ToString();
            }
        }

        bool DuplicationCheck()
        {
            bool IsDuplicate = false;
            string str = BLLObj.DuplicationCheck(txtofficeName.Text);
            DataTable dtduplicate = GlobalVaribles.DeserializeDataTable(str);
            if (dtduplicate != null)
            {
                if (dtduplicate.Rows.Count > 0)
                {
                    FrmMessage message = new FrmMessage("Error Code: SA-0010 \n Error Message: Failed to update. \nSame record already exists in the system.", 1);
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

        bool ValidateForm()
        {
            bool IsValidate = false;
            //bool ISCity = GlobalVaribles.IsString(txtCityName.Text);
            
            if (cboBuildingName.Value == null)
            {
                //MessageBox.Show("Please Select the Building Name", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //FrmMessage message = new FrmMessage("Error Code: SA-007 \n Error Message: Failed to update. \nSame record already exists in the system.", 1);
                FrmMessage message = new FrmMessage("Error Code: SA-0010 \nError Message: Please Select the Building\n                                Name blank.", 1);
                message.ShowDialog();
                cboBuildingName.Focus();
                return false;
            }
            else if (cboFloorName.Value == null)
            {
                FrmMessage message = new FrmMessage("Error Code: SA-0011 \nError Message: Please Select the Floor\n                                Name blank.", 1);
                message.ShowDialog();
               // MessageBox.Show("Please Select the Floor Name", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboBuildingName.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtofficeName.Text))
            {
                FrmMessage message = new FrmMessage("Error Code: SA-012 \nError Message: You cannot leave Office\n                                Name blank.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
                message.ShowDialog();
                txtofficeName.Focus();
                IsValidate = false;
            }

            else
                IsValidate = true;
            return IsValidate;
        }

        private void ClearForm()
        {
            UpdateRecord = false;
            txtofficeName.Text = "";
            txtOfficeID.Text = "";
            txttenantName.Text = "";
            txtRent.Text = "";
            txtOfficeArea.Text = "";
            txtElectricityPerUnit.Text = "";
            txtGeneratorPerUnit.Text = "";
            txtMaintence.Text = "";
            txtwater.Text = "";
            txtOther.Text = "";
            txtDescription.Text = "";
            btnOK.Enabled = true;
            btnEdit.Enabled = false;
            txtofficeName.Focus();
            GetMaxOfficeID();

            LoadAllBuildingforOffice(cboBuildingName);
            cboFloorName.DataSource = null;
            cboFloorName.Value = 0;

        }

        public void LoadAllBuildingforOffice(UltraCombo cbo)
        {
            try
            {
                string str = BLLObj.LoadAllBuildingforOffice();
                dt = GlobalVaribles.DeserializeDataTable(str);
                //sqlDataAdapter.Fill(dataTable);
                cbo.DataSource = dt;
                cbo.ValueMember = "BuildingID";
                cbo.DisplayMember = "BuildingName";
                cbo.DisplayLayout.Bands[0].Columns["BuildingID"].Hidden = true;
                cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
                cbo.Value = 0;
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        public void LoadfloorByBuildingID(UltraCombo cbo, int BuildingID)
        {
            string str = BLLObj.LoadfloorByBuildingID(BuildingID);
            dt = GlobalVaribles.DeserializeDataTable(str);
            if (dt != null && dt.Rows.Count > 0)
            {
                cbo.DataSource = dt;
                cbo.ValueMember = "FloorID";
                cbo.DisplayMember = "FloorName";
                cbo.DisplayLayout.Bands[0].Columns["FloorID"].Hidden = true;
                cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
                cbo.Value = BuildingID;
            }
            
            // cbo.ReadOnly = true;
        }

        bool SaveRecord()
        {
            bool IsSave = false;
            BLL.NewWebServices.BE_Office NewBEObj = new BLL.NewWebServices.BE_Office();
            NewBEObj.OfficeName = txtofficeName.Text;
            NewBEObj.tenantName = txttenantName.Text;
            NewBEObj.OfficeRent = txtRent.Text;
            NewBEObj.OfficeAreaSquare = txtOfficeArea.Text;
            NewBEObj.ElectricityPerUnit = txtElectricityPerUnit.Text;
            NewBEObj.GenetorPerUnit = txtGeneratorPerUnit.Text;
            NewBEObj.Maintence = txtMaintence.Text;
            NewBEObj.Water = txtwater.Text;
            NewBEObj.Other = txtOther.Text;
            NewBEObj.Description = txtDescription.Text;
            NewBEObj.BuildingID = int.Parse(cboBuildingName.Value.ToString());
            NewBEObj.FloorID = int.Parse(cboFloorName.Value.ToString());
            NewBEObj.Created_Id = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            //NewBEObj.Created_Id = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            NewBEObj.Created_At = GlobalVaribles.CurrentServerTime;
            IsSave = BLLObj.SaveRecord(NewBEObj);
            return IsSave;
        }

        bool UpdateRecordOffice()
        {
            bool IsUpdate = false;
            BLL.NewWebServices.BE_Office NewBEObj = new BLL.NewWebServices.BE_Office();
            NewBEObj.OfficeID = Convert.ToInt32(txtOfficeID.Text);
            NewBEObj.OfficeName = txtofficeName.Text;
            NewBEObj.tenantName = txttenantName.Text;
            NewBEObj.OfficeRent = txtRent.Text;
            NewBEObj.OfficeAreaSquare = txtOfficeArea.Text;
            NewBEObj.ElectricityPerUnit = txtElectricityPerUnit.Text;
            NewBEObj.GenetorPerUnit = txtGeneratorPerUnit.Text;
            NewBEObj.Maintence = txtMaintence.Text;
            NewBEObj.Water = txtwater.Text;
            NewBEObj.Other = txtOther.Text;
            NewBEObj.Description = txtDescription.Text;
            NewBEObj.BuildingID = int.Parse(cboBuildingName.Value.ToString());
            NewBEObj.FloorID = int.Parse(cboFloorName.Value.ToString());
            NewBEObj.Modify_At = GlobalVaribles.CurrentServerTime;
            NewBEObj.Modify_ID = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            //NewBEObj.Modify_ID = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            IsUpdate = BLLObj.UpdateRecord(NewBEObj);
            return IsUpdate;
        }

        #endregion

        #region Events


        private void FrmOffice_Load(object sender, EventArgs e)
        {
            FormDesign();
            btnEdit.Enabled = false;
            LoadAllBuildingforOffice(cboBuildingName);
            GetMaxOfficeID();
        }

        private void FrmOffice_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(GlobalVaribles.BorderColor);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void FrmOffice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FrmConfirmationMessage message = new FrmConfirmationMessage(GlobalVaribles.ConfirmationMsg, 2, this);
                message.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboBuildingName_ValueChanged(object sender, EventArgs e)
        {
            if (cboBuildingName.Value != null)
            {
                BuildingID = Convert.ToInt32(cboBuildingName.Value);
                LoadfloorByBuildingID(cboFloorName, BuildingID);
            }
            
        }

        public void LoadBuildingByOfficeID(UltraCombo cbo, int OfficeID)
        {
            //string str = BLLObj.LoadBuildingfromOfficesEdit(OfficeID);
            //dt = GlobalVaribles.DeserializeDataTable(str);
            //cbo.DataSource = dt;
            //cbo.ValueMember = "BuildingID";
            //cbo.DisplayMember = "BuildingName";
            //cbo.DisplayLayout.Bands[0].Columns["BuildingID"].Hidden = true;
            //cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
            //cbo.Value = OfficeID;
            // cbo.ReadOnly = true;


            string str = BLLObj.LoadAllBuildingforOffice();
            dt = GlobalVaribles.DeserializeDataTable(str);
            //sqlDataAdapter.Fill(dataTable);
            cbo.DataSource = dt;
            cbo.ValueMember = "BuildingID";
            cbo.DisplayMember = "BuildingName";
            cbo.DisplayLayout.Bands[0].Columns["BuildingID"].Hidden = true;
            cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;

            string strr = BLLObj.LoadBuildingfromOfficesEdit(OfficeID);
            dt = new DataTable();
            dt = GlobalVaribles.DeserializeDataTable(strr);
            cbo.Value = Convert.ToInt32(dt.Rows[0]["BuildingID"].ToString());
            //cbo.Value = 0;


        }

        public void LoadfloorByOfficeIDinEdit(UltraCombo cbo, int OfficeID)
        {
            BuildingID = Convert.ToInt32(cboBuildingName.Value);
            string str = BLLObj.LoadfloorByBuildingID(BuildingID);
            dt = GlobalVaribles.DeserializeDataTable(str);
            if (dt != null && dt.Rows.Count > 0)
            {
                cbo.DataSource = dt;
                cbo.ValueMember = "FloorID";
                cbo.DisplayMember = "FloorName";
                cbo.DisplayLayout.Bands[0].Columns["FloorID"].Hidden = true;
                cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
                //cbo.Value = BuildingID;
            }

            string strr = BLLObj.LoadfloorByOfficeIDinEdit(OfficeID);
            dt = GlobalVaribles.DeserializeDataTable(strr);
            cbo.Value = Convert.ToInt32(dt.Rows[0]["FloorID"].ToString());
            // cbo.ReadOnly = true;
        }

        private void btnOfficeID_Click(object sender, EventArgs e)
        {
            object rValue;
            try
            {
                string str = BLLObj.LoadAllOffices();
                GlobalVaribles.dtGSearch = GlobalVaribles.DeserializeDataTable(str);
                rValue = FrmGSearch.Show("Select", false, "All Office");
                if (rValue == null)
                    return;
                Moffice = long.Parse(rValue.ToString());
                DataTable dt = new DataTable();
                string strs = BLLObj.GetOfficeByID(Convert.ToInt32(Moffice));
                dt = GlobalVaribles.DeserializeDataTable(strs);

                if (dt != null && dt.Rows.Count > 0)
                {
                    UpdateRecord = true;
                    GetRecord = true;
                   // LoadBuildingByFloorID(cboBuildingName, Convert.ToInt32(Moffice));
                    LoadBuildingByOfficeID(cboBuildingName, Convert.ToInt32(Moffice));
                    LoadfloorByOfficeIDinEdit(cboFloorName, Convert.ToInt32(Moffice));
                    //string strr = BLLObj.LoadBuildingfromOfficesEdit(Convert.ToInt32(Moffice));
                    //dt = new DataTable();
                    //dt = GlobalVaribles.DeserializeDataTable(strr);
                    //LoadfloorByBuildingIDinEdit(cboFloorName,Convert.ToInt32(dt.Rows[0]["BuildingID"].ToString()));
                  //  cbo.Value = Convert.ToInt32(dt.Rows[0]["BuildingID"].ToString());

                    //LoadfloorByBuildingID(cboFloorName, BuildingID);

                  //  LoadfloorByBuildingID(cboFloorName, BuildingID);
                    txtOfficeID.Text = dt.Rows[0]["OfficeID"].ToString();
                    txtofficeName.Text = dt.Rows[0]["OfficeName"].ToString();
                    txttenantName.Text = dt.Rows[0]["TenantName"].ToString();
                    txtRent.Text = dt.Rows[0]["OfficeRent"].ToString();
                    txtOfficeArea.Text = dt.Rows[0]["OfficeAreaSquareFoot"].ToString();
                    txtElectricityPerUnit.Text = dt.Rows[0]["ElectricityPerUnit"].ToString();
                    txtGeneratorPerUnit.Text = dt.Rows[0]["GeneratorPerUnit"].ToString();
                    txtMaintence.Text = dt.Rows[0]["Maintenance"].ToString();
                    txtwater.Text = dt.Rows[0]["Water"].ToString();
                    txtOther.Text = dt.Rows[0]["Other"].ToString();
                    txtDescription.Text = dt.Rows[0]["Description"].ToString();

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

                if (UpdateRecordOffice())
                {
                    MessageBox.Show("Record Updated Successfully", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FrmMessage message = new FrmMessage("City Updated", 0);
                    //message.lblSuccess.Text = "Success";
                    //message.ShowDialog();
                    ClearForm();
                    btnEdit.Enabled = false;
                    btnOK.Enabled = true;
                    LoadAllBuildingforOffice(cboBuildingName);
                }

            }
        }

        #endregion

    }
}
