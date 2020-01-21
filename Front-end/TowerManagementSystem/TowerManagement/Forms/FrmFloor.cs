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
    public partial class FrmFloor : Form
    {
        public DataTable dt = new DataTable();
        BLL_Building BLLObj_Building = new BLL_Building();

        BLL_Floor BLLObj = new BLL_Floor();

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

        string MFloorID = "";
        long Mfloor = 0;
        bool GetRecord = false;
        bool UpdateRecord = false;

        #endregion

        public FrmFloor()
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
            btnFloorID.Appearance.BackColor = GlobalVaribles.btnBackColor;
            btnFloorID.Appearance.ForeColor = GlobalVaribles.btnForeColor;
            btnFloorID.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            btnFloorID.Font = GlobalVaribles.btnFontStyle;
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

        public void GetMaxFloorID()
        {
            MFloorID = BLLObj.GetMaxFloorID();
            dt = GlobalVaribles.DeserializeDataTable(MFloorID);
            if (dt.Rows.Count > 0)
            {
                Mfloor = long.Parse(dt.Rows[0]["FloorID"].ToString());
                txtFloorID.Text = Mfloor.ToString();
            }
        }

        bool DuplicationCheck()
        {
            bool IsDuplicate = false;
            string str = BLLObj.DuplicationCheck(txtFloorName.Text);
            DataTable dtduplicate = GlobalVaribles.DeserializeDataTable(str);
            if (dtduplicate != null)
            {
                if (dtduplicate.Rows.Count > 0)
                {
                    FrmMessage message = new FrmMessage("Error Code: SA-007 \n Error Message: Failed to update. \nSame record already exists in the system.", 1);
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
                FrmMessage message = new FrmMessage("Error Code: SA-008 \nError Message: Please Select the Building\n                                Name blank.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
                message.ShowDialog();

                //MessageBox.Show("Please Select the Building Name", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboBuildingName.Focus();
                IsValidate= false;
            }
            else if (string.IsNullOrEmpty(txtFloorName.Text))
            {
                FrmMessage message = new FrmMessage("Error Code: SA-009 \nError Message: You cannot leave Floor\n                                Name blank.", 1);
                //FrmMessage message = new FrmMessage("You cannot leave Area Name blank.", 1);
                message.ShowDialog();
                txtFloorName.Focus();
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

        private void ClearForm()
        {
            UpdateRecord = false;
            txtFloorName.Text = "";
            txtFloorID.Text = "";
            btnOK.Enabled = true;
            btnEdit.Enabled = false;
            txtFloorName.Focus();
            GetMaxFloorID();
            cboBuildingName.DataSource = null;
            LoadAllBuildingCombo(cboBuildingName);
            
        }

        bool SaveRecord()
        {
            bool IsSave = false;
            BLL.NewWebServices.BE_Floor NewBEObj = new BLL.NewWebServices.BE_Floor();
            //NewBEObj.BuildingID = txtBuildingID.Text.ToString();
            NewBEObj.FloorName = txtFloorName.Text;
            NewBEObj.BuildingID= int.Parse(cboBuildingName.Value.ToString());
            NewBEObj.Created_Id = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            //NewBEObj.Created_Id = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            NewBEObj.Created_At = GlobalVaribles.CurrentServerTime;
            IsSave = BLLObj.SaveRecord(NewBEObj);
            return IsSave;
        }

        bool UpdateRecordFloor()
        {
            bool IsUpdate = false;
            BLL.NewWebServices.BE_Floor NewBEObj = new BLL.NewWebServices.BE_Floor();
            NewBEObj.FloorID = Convert.ToInt32(txtFloorID.Text);
            NewBEObj.FloorName = txtFloorName.Text;
            NewBEObj.BuildingID = int.Parse(cboBuildingName.Value.ToString());
            NewBEObj.Modify_At = GlobalVaribles.CurrentServerTime;
            NewBEObj.Modify_ID = Convert.ToInt32(GlobalVaribles.dtSession.Rows[0]["UserID"]);
            //NewBEObj.Modify_ID = GlobalVaribles.UserID;
            NewBEObj.Status = chkIsActive.Checked;
            IsUpdate = BLLObj.UpdateRecord(NewBEObj);
            return IsUpdate;
        }

        public void LoadAllBuilding(UltraCombo cbo)
        {

            string str = BLLObj_Building.LoadAllBuilding();
            dt = GlobalVaribles.DeserializeDataTable(str);
            //sqlDataAdapter.Fill(dataTable);
            cbo.DataSource = dt;
            cbo.ValueMember = "BuildingID";
            cbo.DisplayMember = "BuildingName";
            cbo.DisplayLayout.Bands[0].Columns["BuildingID"].Hidden = true;
            cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
            cbo.Value = 0;

        }

        public void LoadAllBuildingCombo(UltraCombo cbo)
        {
            try
            {
                string str = BLLObj_Building.LoadAllBuildingCombo();
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

        public void LoadBuildingByFloorID(UltraCombo cbo, int floorID)
        {
            string str = BLLObj_Building.LoadAllBuildingCombo();
            dt = GlobalVaribles.DeserializeDataTable(str);
            //sqlDataAdapter.Fill(dataTable);
            cbo.DataSource = dt;
            cbo.ValueMember = "BuildingID";
            cbo.DisplayMember = "BuildingName";
            cbo.DisplayLayout.Bands[0].Columns["BuildingID"].Hidden = true;
            cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;

            string strr = BLLObj.LoadBuildingIDByFloorID(floorID);
            dt = new DataTable();
            dt = GlobalVaribles.DeserializeDataTable(strr);

            cbo.Value = Convert.ToInt32(dt.Rows[0]["BuildingID"]);
            
            
            //cbo.DataSource = dt;
            //cbo.ValueMember = "BuildingID";
            //cbo.DisplayMember = "BuildingName";
            //cbo.DisplayLayout.Bands[0].Columns["BuildingID"].Hidden = true;
            //cbo.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
            //cbo.Value = floorID;
            // cbo.ReadOnly = true;
        }

        #endregion

        #region Events

        private void FrmFloor_Load(object sender, EventArgs e)
        {
            FormDesign();
            btnEdit.Enabled = false;
            GetMaxFloorID();
            //LoadAllBuilding(cboBuildingName);
            LoadAllBuildingCombo(cboBuildingName);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFloor_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(GlobalVaribles.BorderColor);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void FrmFloor_KeyDown(object sender, KeyEventArgs e)
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

                if (UpdateRecordFloor())
                {
                    MessageBox.Show("Record Updated Successfully", GlobalVaribles.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FrmMessage message = new FrmMessage("City Updated", 0);
                    //message.lblSuccess.Text = "Success";
                    //message.ShowDialog();
                    ClearForm();
                    btnEdit.Enabled = false;
                    btnOK.Enabled = true;
                    LoadAllBuildingCombo(cboBuildingName);
                }

            }
        }

        private void btnFloorID_Click(object sender, EventArgs e)
        {
            object rValue;
            try
            {
                string str = BLLObj.LoadAllFloorCombo();

                GlobalVaribles.dtGSearch = GlobalVaribles.DeserializeDataTable(str);

                rValue = FrmGSearch.Show("Select", false, "All Floor");
                if (rValue == null)
                    return;
                Mfloor = long.Parse(rValue.ToString());
                DataTable dt = new DataTable();
                // GetCityIDByCityValue(Convert.ToInt32(MCity));
                string strs = BLLObj.GetFloorByID(Convert.ToInt32(Mfloor));
                dt = GlobalVaribles.DeserializeDataTable(strs);

                if (dt != null && dt.Rows.Count > 0)
                {
                    UpdateRecord = true;
                    GetRecord = true;
                    LoadBuildingByFloorID(cboBuildingName, Convert.ToInt32(Mfloor));

                    txtFloorID.Text = dt.Rows[0]["FloorID"].ToString();
                    txtFloorName.Text = dt.Rows[0]["FloorName"].ToString();
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
