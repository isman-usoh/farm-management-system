using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;
using MainProject.Database.FarmManageDataSetTableAdapters;

namespace MainProject.UserInterface.Supplies
{
    public partial class StockDetailForm : Form
    {
        public Int32 StockID { get; set; }

        private DateTime minAddDate;
        private DateTime nowAddDate = DateTime.Now;
        private DateTime minRemoveDate;
        private DateTime nowRemoveDate = DateTime.Now;

        private DateTime temp;


        private Dictionary<Int32, String> AddMonthList = new Dictionary<Int32, String>();
        private Dictionary<Int32, String> RemoveMonthList = new Dictionary<Int32, String>();


        public StockDetailForm()
        {
            InitializeComponent();
        }

        private void SuppliesDetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmManageDataSet.StockRemoveListView' table. You can move, or remove it, as needed.
            this.stockRemoveListViewTableAdapter.Fill(this.farmManageDataSet.StockRemoveListView);
            // TODO: This line of code loads data into the 'farmManageDataSet.StockAddListView' table. You can move, or remove it, as needed.
            this.stockAddListViewTableAdapter.Fill(this.farmManageDataSet.StockAddListView);
            // TODO: This line of code loads data into the 'farmManageDataSet.StockAddListView' table. You can move, or remove it, as needed.
            this.stockAddListViewTableAdapter.Fill(this.farmManageDataSet.StockAddListView);
            
            
            this.cbxStockType.ValueMember = "Key";
            this.cbxStockType.DisplayMember = "Value";
            this.cbxStockType.DataSource = TypeUtil.StockType().ToList();

            this.colRemoveFromType.ValueMember = "Key";
            this.colRemoveFromType.DisplayMember = "Value";
            this.colRemoveFromType.DataSource = TypeUtil.StockRevemoFormType().ToList();

            this.cbxAddMonth.ValueMember = "Key";
            this.cbxAddMonth.DisplayMember = "Value";

            this.cbxRemoveMonth.ValueMember = "Key";
            this.cbxRemoveMonth.DisplayMember = "Value";

            this.stockTableAdapter.FillByPK(farmManageDataSet.Stock, StockID);
            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);


            DateTime? minAddDateTemp = (DateTime?)this.stockAddListViewTableAdapter.QueryMinDateByStockID(StockID);
            this.minAddDate = minAddDateTemp ?? new DateTime(nowAddDate.Year, nowAddDate.Month, 1);
            
            DateTime? minRemoveDateTemp = this.stockRemoveListViewTableAdapter.QueryMinDateByStockID(StockID);
            this.minRemoveDate = minRemoveDateTemp ?? new DateTime(nowRemoveDate.Year, nowRemoveDate.Month, 1);




            Dictionary<Int32, String> AddYear = new Dictionary<Int32, String>();
            AddYear.Add(-1, "ทั้งหมด");
            int Start = this.minAddDate.Year;
            int End = DateTime.Now.Year;
            for (int i = Start; i <= End; i++)
            {
                AddYear.Add(i, new DateTime(i, 1, 1).ToString("yyyy"));
            }
            this.cbxAddYear.ValueMember = "Key";
            this.cbxAddYear.DisplayMember = "Value";
            this.cbxAddYear.DataSource = AddYear.ToList();
            this.cbxAddYear.SelectedIndex = 0;


            Dictionary<Int32, String> RemoveYear = new Dictionary<Int32, String>(); 
            RemoveYear.Add(-1, "ทั้งหมด");
            Start = this.minRemoveDate.Year;
            End = DateTime.Now.Year;
            for (int i = Start; i <= End; i++)
            {
                RemoveYear.Add(i, new DateTime(i, 1, 1).ToString("yyyy"));
            }
            this.cbxRemoveYear.ValueMember = "Key";
            this.cbxRemoveYear.DisplayMember = "Value";
            this.cbxRemoveYear.DataSource = RemoveYear.ToList();
            this.cbxRemoveYear.SelectedIndex = 0;


            if (tbxUnit.Text.Trim().Length == 0)
                tbxUnit.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                stockBindingSource.EndEdit();
                int result = stockTableAdapter.Update(farmManageDataSet.Stock);
                if (result == 1)
                {
                    var log = new UserLogTableAdapter();
                    log.Insert(TypeUtil.Stock, StockID.ToString(), MainForm.User.UserID, TypeUtil.EVENT_MODIFY, DateTime.Now);
                }
                DialogResult = DialogUtil.SaveSuccess();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void dgvAddHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var form = new AddStockDetailForm();
            form.AddStockID = Convert.ToInt32(((DataRowView)this.stockAddListViewBindingSource[e.RowIndex]).Row["StockAddID"]);
            form.ShowDialog();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            var form = new AddStockDetailForm();
            form.AddStockID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.FillAdd();
                stockTableAdapter.FillByPK(farmManageDataSet.Stock, StockID);
            }
        }

        private void tbxUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressUtil.Double(tbxUnit, e);
        }

        private void tbxUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbxUnit.Text.Trim().Length == 0)
            {
                tbxUnit.Text = "0";
            }
        }

        private void dgvRemoveHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new RemoveStockDetailForm();
            form.RemoveStockID = Convert.ToInt32(((DataRowView)stockRemoveListViewBindingSource[e.RowIndex]).Row["StockRemoveID"]);
            form.ShowDialog();
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            var form = new RemoveStockDetailForm();
            form.RemoveStockID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.FillRemove();
                this.stockTableAdapter.FillByPK(farmManageDataSet.Stock, StockID);
            }
        }

        private void cbxAddMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillAdd();
        }

        private void FillAdd()
        {
            Int32 Year = Convert.ToInt32(cbxAddYear.SelectedValue);
            Int32 Month = Convert.ToInt32(cbxAddMonth.SelectedValue);
            DateTime Start;
            DateTime End;


            if (Year == -1)
            {
                Start = new DateTime(1990, 1, 1);
                End = Start.AddYears(100);
                End = End.AddMonths(12);
                End = End.AddDays(-1);
            }
            else
            {
                if (Month == -1)
                {
                    Start = new DateTime(Year, 1, 1);
                    End = Start.AddMonths(12);
                    End = End.AddDays(-1);
                }
                else
                {
                    Start = new DateTime(Year, Month, 1);
                    End = Start.AddMonths(1);
                    End = End.AddDays(-1);
                }
            }

            this.stockAddListViewTableAdapter.FillByStockID(this.farmManageDataSet.StockAddListView, StockID, Start, End);
        }

        private void cbxRemoveMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillRemove();
        }

        private void FillRemove()
        {
            Int32 Year = Convert.ToInt32(cbxRemoveYear.SelectedValue);
            Int32 Month = Convert.ToInt32(cbxRemoveMonth.SelectedValue);
            DateTime Start;
            DateTime End;


            if (Year == -1)
            {
                Start = new DateTime(1990, 1, 1);
                End = Start.AddYears(100);
                End = End.AddMonths(12);
                End = End.AddDays(-1);
            }
            else
            {
                if (Month == -1)
                {
                    Start = new DateTime(Year, 1, 1);
                    End = Start.AddMonths(12);
                    End = End.AddDays(-1);
                }
                else
                {
                    Start = new DateTime(Year, Month, 1);
                    End = Start.AddMonths(1);
                    End = End.AddDays(-1);
                }
            }

            this.stockRemoveListViewTableAdapter.FillByStockID(this.farmManageDataSet.StockRemoveListView, StockID, Start, End);
        }

        private void cbxAddYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AddMonthList.Clear();
            this.AddMonthList.Add(-1, "ทั้งหมด");

            int selectYear = Convert.ToInt32(this.cbxAddYear.SelectedValue);
            int minYear = minAddDate.Year;
            int nowYear = nowAddDate.Year;

            if (selectYear == -1)
            {
                cbxAddMonth.Enabled = false;
            }
            else
            {
                cbxAddMonth.Enabled = true;
            }


            if (minAddDate.Year == nowAddDate.Year)
            {
                temp = minAddDate;
                for (int i = minAddDate.Month; i <= nowAddDate.Month; i++)
                {
                    this.AddMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
            }
            else if (minYear == selectYear)
            {
                temp = new DateTime(2000, minAddDate.Month, 1);
                for (int i = minAddDate.Month; i <= 12; i++)
                {
                    this.AddMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
            }
            else if (nowYear == selectYear)
            {
                temp = new DateTime(2000, 1, 1);
                for (int i = 1; i <= minAddDate.Month; i++)
                {
                    this.AddMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
                this.AddMonthList.Add(temp.Month, temp.ToString("MMMM"));
            }
            else
            {
                temp = new DateTime(2000, 1, 1);
                for (int i = temp.Month; i <= 12; i++)
                {
                    this.AddMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
            }


            this.cbxAddMonth.DataSource = AddMonthList.ToList();
            this.cbxAddMonth.SelectedIndex = 0;
        }

        private void cbxRemoveYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RemoveMonthList.Clear();
            this.RemoveMonthList.Add(-1, "ทั้งหมด");

            int selectYear = Convert.ToInt32(this.cbxRemoveYear.SelectedValue);
            int minYear = minRemoveDate.Year;
            int nowYear = nowRemoveDate.Year;


            if (selectYear == -1)
            {
                cbxRemoveMonth.Enabled = false;
            }
            else
            {
                cbxRemoveMonth.Enabled = true;
            }


            if (minRemoveDate.Year == nowRemoveDate.Year)
            {
                temp = minRemoveDate;
                for (int i = minRemoveDate.Month; i <= nowRemoveDate.Month; i++)
                {
                    this.RemoveMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
            }
            else if (minYear == selectYear)
            {
                temp = new DateTime(2000, minRemoveDate.Month, 1);
                for (int i = temp.Month; i <= 12; i++)
                {
                    this.RemoveMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
            }
            else if (nowYear == selectYear)
            {
                temp = new DateTime(2000, 1, 1);
                for (int i = 1; i <= minAddDate.Month; i++)
                {
                    this.RemoveMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
                this.RemoveMonthList.Add(temp.Month, temp.ToString("MMMM"));
            }
            else
            {
                temp = new DateTime(2000, 1, 1);
                for (int i = temp.Month; i <= 12; i++)
                {
                    this.RemoveMonthList.Add(i, temp.ToString("MMMM"));
                    temp = temp.AddMonths(1);
                }
            }

            this.cbxRemoveMonth.DataSource = RemoveMonthList.ToList();
            this.cbxRemoveMonth.SelectedIndex = 0;
        }
    }
}
