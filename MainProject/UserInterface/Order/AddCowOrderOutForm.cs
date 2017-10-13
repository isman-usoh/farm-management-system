using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using MainProject.Database;
using MainProject.Util;

namespace MainProject.UserInterface.Order
{
    public partial class AddCowOrderOutForm : Form
    {
        public class CowPoJo
        {
            public Int32 CowID { get; set; }
            public String NO { get; set; }
            public Int32 CorralID { get; set; }
            public Int32 GeneID { get; set; }
            public Byte SexID { get; set; }
            public Double OrderInAmount { get; set; }
            public Double OrderOutAmount { get; set; }
        }



        public OrderOutWizardForm OrderOutWizard { get; set; }
        public AddDeadForm AddDead { get; set; }
        public Boolean IsDead { get; set; }

        public ArrayList Cows = new ArrayList();

        public AddCowOrderOutForm()
        {
            InitializeComponent();
        }

        private void initialDataGrid()
        {
            this.dgvList.Rows.Clear();


            var cowTable = cowTableAdapter1.GetDataBySearchCurrent(
                Convert.ToInt32(cbxCorral.SelectedValue),
                Convert.ToInt32(cbxGene.SelectedValue),
                Convert.ToInt32(cbxCowSex.SelectedValue), 
                tbxSearch.Text.Trim());

            String[] CowSelect = null;

            if (IsDead)
            {
                CowSelect = AddDead.SelectCow();
            }
            else
            {
                CowSelect = OrderOutWizard.SelectCow();
            }
            foreach (FarmManageDataSet.CowRow row in cowTable.Rows)
            {
                if (Array.IndexOf<String>(CowSelect, row.CowNO) == -1)
                {
                    dgvList.Rows.Add();
                    dgvList.Rows[dgvList.Rows.Count - 1].Cells["colCowNO"].Value = row.CowNO;
                    dgvList.Rows[dgvList.Rows.Count - 1].Cells["colCowCorral"].Value = row.CorralID;
                    dgvList.Rows[dgvList.Rows.Count - 1].Cells["colCowGene"].Value = row.GeneID;
                    dgvList.Rows[dgvList.Rows.Count - 1].Cells["colCowSex"].Value = row.Sex;
                    dgvList.Rows[dgvList.Rows.Count - 1].Cells["colCowOrderInAmount"].Value = row.OnderInAmount;

                    if (IsDead)
                    {
                        dgvList.Rows[dgvList.Rows.Count - 1].Cells["colCowOrderOutAmount"].Value = 0D;
                    }
                }
            }
        }

        private void AddCowOrderInForm_Load(object sender, EventArgs e)
        {
            var CowSex = new SortedDictionary<Int32, String>();
            CowSex.Add(-1, "ทั้งหมด");
            foreach (KeyValuePair<Byte, String> Pair in TypeUtil.CowSex())
            {
                CowSex.Add(Pair.Key, Pair.Value);
            }
            this.cbxCowSex.DataSource = CowSex.ToList();

            var CowCorral = new SortedDictionary<Int32, String>();
            CowCorral.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.CorralRow row in corralTableAdapter.GetData())
            {
                CowCorral.Add(row.CorralID, row.Name);
            }
            this.cbxCorral.DataSource = CowCorral.ToList();


            var CowGene = new SortedDictionary<Int32, String>();
            CowGene.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.GeneRow row in geneTableAdapter.GetData())
            {
                CowGene.Add(row.GeneID, row.Name);
            }
            this.cbxGene.DataSource = CowGene.ToList();

            this.colCowSex.ValueMember = "Key";
            this.colCowSex.DisplayMember = "Value";
            this.colCowSex.DataSource = TypeUtil.CowSex().ToList();


            if (IsDead)
            {
                this.colCowOrderOutAmount.Visible = false;
            }



            this.geneTableAdapter.Fill(farmManageDataSet.Gene);
            this.corralTableAdapter.Fill(farmManageDataSet.Corral);


            this.initialDataGrid();
            this.cbxGene.SelectedIndexChanged += new EventHandler(cbx_SelectedIndexChanged);
            this.cbxCorral.SelectedIndexChanged += new EventHandler(cbx_SelectedIndexChanged);
            this.cbxCowSex.SelectedIndexChanged += new EventHandler(cbx_SelectedIndexChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.SelectedRows)
            {
                var cow = new CowPoJo();
                cow.CowID = Convert.ToInt32(row.Cells["colCowID"].Value);
                cow.NO = row.Cells["colCowNO"].Value.ToString();
                ;
                cow.CorralID = Convert.ToInt32(row.Cells["colCowCorral"].Value);
                cow.GeneID = Convert.ToInt32(row.Cells["colCowGene"].Value);
                cow.SexID = Convert.ToByte(row.Cells["colCowSex"].Value);
                cow.OrderInAmount = Convert.ToInt32(row.Cells["colCowOrderInAmount"].Value);
                cow.OrderOutAmount = Convert.ToInt32(row.Cells["colCowOrderOutAmount"].Value);
                Cows.Add(cow);
            }
            DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            initialDataGrid();
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                initialDataGrid();
            }
        }



        public Double CellBeginValue = 0D;

        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                try
                {
                    var value = Convert.ToDouble(dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
                }
                catch
                {
                    MessageBox.Show("รับตัวเลขเท่านั้น");
                    dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = CellBeginValue;
                }
            }
        }

        private void dgvList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                CellBeginValue = Convert.ToDouble(dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + string.Empty;
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = dgvList.SelectedRows.Count > 0 ? true : false;
        }
    }
}