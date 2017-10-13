using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.UserInterface.Order;
using MainProject.Database;
using MainProject.UserInterface.Supplies;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Cow
{
    public partial class CowDetailForm : Form
    {
        public String CowNO { get; set;}

        public CowDetailForm()
        {
            InitializeComponent();

            this.cbxSex.DataSource = TypeUtil.CowSex().ToList();
            this.cbxOrderInType.DataSource = TypeUtil.InOrderType().ToList();
            this.cbxOutOrderType.DataSource = TypeUtil.OutOrderType().ToList();
            this.cbxInTransportType.DataSource = TypeUtil.InTransportType().ToList();
            this.cbxOutTransportType.DataSource = TypeUtil.OutTransportType().ToList();
        }

        private void CowDetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.farmManageDataSet.Stock);
            // TODO: This line of code loads data into the 'farmManageDataSet.UsersView' table. You can move, or remove it, as needed.
            this.usersViewTableAdapter.Fill(this.farmManageDataSet.UsersView);
            // TODO: This line of code loads data into the 'farmManageDataSet.Corral' table. You can move, or remove it, as needed.
            this.corralTableAdapter.Fill(this.farmManageDataSet.Corral);
            // TODO: This line of code loads data into the 'farmManageDataSet.Gene' table. You can move, or remove it, as needed.
            this.geneTableAdapter.Fill(this.farmManageDataSet.Gene);
            // TODO: This line of code loads data into the 'farmManageDataSet.DiseaseHistory' table. You can move, or remove it, as needed.
            this.diseaseHistoryTableAdapter.Fill(this.farmManageDataSet.DiseaseHistory);
            // TODO: This line of code loads data into the 'farmManageDataSet.Vaccine' table. You can move, or remove it, as needed.
            this.vaccineTableAdapter.Fill(this.farmManageDataSet.Vaccine);
            // TODO: This line of code loads data into the 'farmManageDataSet.OrderOut' table. You can move, or remove it, as needed.
            this.orderOutTableAdapter.Fill(this.farmManageDataSet.OrderOut);
            // TODO: This line of code loads data into the 'farmManageDataSet.OrderIn' table. You can move, or remove it, as needed.
            this.orderInTableAdapter.Fill(this.farmManageDataSet.OrderIn);
            // TODO: This line of code loads data into the 'farmManageDataSet.Cow' table. You can move, or remove it, as needed.
            this.cowTableAdapter.FillByPK(this.farmManageDataSet.Cow, CowNO);
            // TODO: This line of code loads data into the 'farmManageDataSet.DiseaseHistory' table. You can move, or remove it, as needed.
            this.diseaseHistoryTableAdapter.Fill(this.farmManageDataSet.DiseaseHistory);
            
            



            this.userLogUC.FillEvent(TypeUtil.Cow, CowNO);

            FarmManageDataSet.CowRow CowCurrent = ((this.cowBindingSource.Current as DataRowView).Row as FarmManageDataSet.CowRow);
            if (CowCurrent.OrderOutID == -1)
            {
                this.gbxOutOrder.Visible = false;
            }
            else
            {
                this.cbxSex.Enabled = false;
                this.cbxCorral.Enabled = false;
                this.cbxGene.Enabled = false;
                this.tbxCor.ReadOnly = true;
                this.btnAddMedicine.Enabled = false;
                this.btnAddVaccineHistory.Enabled = false;
                this.btnSave.Visible = false;
                this.btnCancel.Text = "ปิด";
                this.orderOutTableAdapter.FillByCowNO(farmManageDataSet.OrderOut, CowNO);
            }


            if (!MainForm.User.SuperUser)
                this.tcMain.TabPages.Remove(this.tabRecord);
        }

        private void btnInOrderDetail_Click(object sender, EventArgs e)
        {
            FarmManageDataSet.CowRow Cow = ((this.cowBindingSource.Current as DataRowView).Row as FarmManageDataSet.CowRow);

            if (Convert.ToByte(this.cbxOrderInType.SelectedValue) == 2)
            {
                var form = new AddBornForm();
                form.OrderInID = Cow.OrderInID;
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                    this.orderInTableAdapter.FillByCowNO(farmManageDataSet.OrderIn, CowNO);
            }
            else
            {
                var form = new InOrderForm();
                form.OrderInID = Cow.OrderInID;
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                    this.orderInTableAdapter.FillByCowNO(farmManageDataSet.OrderIn, CowNO);
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32 CorralID = ((cowBindingSource.Current as DataRowView).Row as FarmManageDataSet.CowRow).CorralID;

            this.Validate();
            this.cowBindingSource.EndEdit();
            if (1 == this.cowTableAdapter.Update(this.farmManageDataSet.Cow))
            {
                if (CorralID != Convert.ToInt32(cbxCorral.SelectedValue))
                {
                    corralTableAdapter.UpdateRemoveCurrent(1, CorralID);
                    corralTableAdapter.UpdateAddCurrent(1, Convert.ToInt32(cbxCorral.SelectedValue));
                }

                var log = new UserLogTableAdapter();
                log.Insert(TypeUtil.Cow, CowNO, MainForm.User.UserID, 1, DateTime.Now);

                DialogResult = DialogUtil.SaveSuccess();
            }
            else
            {
                DialogResult = DialogUtil.SaveError();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnOutOrderDetail_Click(object sender, EventArgs e)
        {
            FarmManageDataSet.CowRow Cow = ((this.cowBindingSource.Current as DataRowView).Row as FarmManageDataSet.CowRow);

            if (Convert.ToByte(this.cbxOutOrderType.SelectedValue) == 2)
            {
                var form = new AddDeadForm();
                form.OrderOutID = Cow.OrderOutID;
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                    this.orderOutTableAdapter.FillByCowNO(farmManageDataSet.OrderOut, CowNO);
            }
            else
            {
                var form = new OutOrderForm();
                form.OrderOutID = ((FarmManageDataSet.CowRow)((DataRowView)cowBindingSource.Current).Row).OrderOutID;
                var result = form.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.Yes)
                    this.orderOutTableAdapter.FillByCowNO(farmManageDataSet.OrderOut, CowNO);
            }
        }

        private void btnAddVaccineHistory_Click(object sender, EventArgs e)
        {
            var form = new AddVaccineForm();
            form.VaccineID = 0;
            form.CowNO = CowNO;
            if (DialogResult.Yes == form.ShowDialog())
            {
                vaccineTableAdapter.Fill(farmManageDataSet.Vaccine);
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            var form = new AddDiseaseHistoryForm();
            form.DiseaseHistoryID = 0;
            form.CowNO = CowNO;
            if (DialogResult.Yes == form.ShowDialog())
            {
                diseaseHistoryTableAdapter.Fill(farmManageDataSet.DiseaseHistory);
            }
        }

        private void dgvVaccine_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddVaccineForm();
            form.VaccineID = Convert.ToInt32(((DataRowView)fKVaccineCow1BindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                vaccineTableAdapter.Fill(farmManageDataSet.Vaccine);
            }
        }

        private void dgvMedicine_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddDiseaseHistoryForm();
            form.DiseaseHistoryID = Convert.ToInt32(((DataRowView)fKDiseaseHistoryCow1BindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                diseaseHistoryTableAdapter.Fill(farmManageDataSet.DiseaseHistory);
            }
        }

        private void cbxCorral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cowBindingSource.Current == null)
                return;

            Int32 CorralID = ((this.cowBindingSource.Current as DataRowView).Row as FarmManageDataSet.CowRow).CorralID;
            if (CorralID != Convert.ToInt32(this.cbxCorral.SelectedValue))
            {
                var value = new CorralTableAdapter().CheckFree(Convert.ToInt32(cbxCorral.SelectedValue));
                if (value == 0)
                {
                    DialogResult = MessageBox.Show("ไม่สามารถย้ายคอก เพราะคอกที่เลือกเต็มแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbxCorral.SelectedValue = CorralID;
                }
            }
        }
    }
}
