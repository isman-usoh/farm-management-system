using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MainProject.Util;

namespace MainProject.UserInterface.Supplies
{
    public partial class StockManageForm : Form
    {
        private DateTime minAddDate;
        private DateTime nowAddDate = DateTime.Now;
        private DateTime minRemoveDate;
        private DateTime nowRemoveDate = DateTime.Now;
        private DateTime temp;


        private Dictionary<Int32, String> AddMonthList = new Dictionary<Int32, String>();
        private Dictionary<Int32, String> RemoveMonthList = new Dictionary<Int32, String>();


        public StockManageForm()
        {
            InitializeComponent();
        }

        private void SuppliesManageForm_Load(object sender, EventArgs e)
        {
            var StockType = new SortedDictionary<Byte, String>();
            StockType.Add(0, "ทั้งหมด");
            StockType.Add(1, "อาหาร");
            StockType.Add(2, "วัคซีน");
            StockType.Add(3, "ยา");

            this.cbxType.ValueMember = "Key";
            this.cbxType.DisplayMember = "Value";
            this.cbxType.DataSource = StockType.ToList();

            this.colType.ValueMember = "Key";
            this.colType.DisplayMember = "Value";
            this.colType.DataSource = StockType.ToList();

            this.colRemoveFromType.ValueMember = "Key";
            this.colRemoveFromType.DisplayMember = "Value";
            this.colRemoveFromType.DataSource = TypeUtil.StockRevemoFormType().ToList();

            this.cbxAddMonth.ValueMember = "Key";
            this.cbxAddMonth.DisplayMember = "Value";

            this.cbxRemoveMonth.ValueMember = "Key";
            this.cbxRemoveMonth.DisplayMember = "Value";

            this.usersViewTableAdapter.Fill(farmManageDataSet.UsersView);
            this.stockTableAdapter.FillByType(farmManageDataSet.Stock, Convert.ToByte(cbxType.SelectedValue));



            DateTime? minAddDateTemp = this.stockAddTableAdapter.QueryMinDate();
            this.minAddDate = minAddDateTemp ?? new DateTime(nowAddDate.Year, nowAddDate.Month, 1);

            DateTime? minRemoveDateTemp = this.stockRemoveTableAdapter.QueryMinDate();
            this.minRemoveDate = minRemoveDateTemp ?? new DateTime(nowRemoveDate.Year, nowRemoveDate.Month, 1);


            Dictionary<Int32, String> AddYear = new Dictionary<Int32, String>();
            AddYear.Add(-1, "ทั้งหมด");
            int Start = this.minAddDate.Year;
            int End = this.nowAddDate.Year;
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
            End = this.nowRemoveDate.Year;
            for (int i = Start; i <= End; i++)
            {
                RemoveYear.Add(i, new DateTime(i,1,1).ToString("yyyy"));
            }
            this.cbxRemoveYear.ValueMember = "Key";
            this.cbxRemoveYear.DisplayMember = "Value";
            this.cbxRemoveYear.DataSource = RemoveYear.ToList();
            this.cbxRemoveYear.SelectedIndex = 0;
        }
            
        private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new StockDetailForm();
            form.StockID = Convert.ToInt32(((DataRowView)stockBindingSource[e.RowIndex]).Row[0]);
            var result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                stockTableAdapter.FillByType(farmManageDataSet.Stock, Convert.ToByte(cbxType.SelectedValue));
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockTableAdapter.FillByType(farmManageDataSet.Stock, Convert.ToByte(cbxType.SelectedValue));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            var form = new AddStockDetailForm();
            form.AddStockID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                stockTableAdapter.FillByType(farmManageDataSet.Stock, Convert.ToByte(cbxType.SelectedValue));
                stockAddTableAdapter.Fill(farmManageDataSet.StockAdd);
            }
        }

        private void removeStock_Click(object sender, EventArgs e)
        {
            var form = new RemoveStockDetailForm();
            form.RemoveStockID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                stockTableAdapter.FillByType(farmManageDataSet.Stock, Convert.ToByte(cbxType.SelectedValue));
                stockRemoveTableAdapter.Fill(farmManageDataSet.StockRemove);
            }
        }

        private void newStock_Click(object sender, EventArgs e)
        {
            var form = new NewStockForm();
            form.StockID = 0;
            var result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                stockTableAdapter.FillByType(farmManageDataSet.Stock, Convert.ToByte(cbxType.SelectedValue));
            }
        }

        private void dgvRemoveHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new RemoveStockDetailForm();
            form.RemoveStockID = Convert.ToInt32(((DataRowView)stockRemoveBindingSource[e.RowIndex]).Row[0]);
            form.ShowDialog();
        }

        private void dgvAddHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var form = new AddStockDetailForm();
            form.AddStockID = Convert.ToInt32(((DataRowView)stockAddBindingSource[e.RowIndex]).Row[0]);
            form.ShowDialog();
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

        private void cbxRemoveMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 Year = Convert.ToInt32(cbxRemoveYear.SelectedValue);
            Int32 Month = Convert.ToInt32(cbxRemoveMonth.SelectedValue);
            DateTime Start;
            DateTime End;


            if (Year == -1)
            {
                Start = new DateTime(1988, 1, 1);
                End = Start.AddYears(100);
                End = End.AddMonths(12);
                End = End.AddDays(-1);
            }
            else
            {
                if(Month == -1)
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

            this.stockRemoveTableAdapter.FillByDate(this.farmManageDataSet.StockRemove, Start, End);
        }

        private void cbxAddMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 Year = Convert.ToInt32(cbxAddYear.SelectedValue);
            Int32 Month = Convert.ToInt32(cbxAddMonth.SelectedValue);
            DateTime Start;
            DateTime End;


            if (Year == -1)
            {
                Start = new DateTime(1988, 1, 1);
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

            this.stockAddTableAdapter.FillByDate(this.farmManageDataSet.StockAdd, Start, End);
        }
    }
}
