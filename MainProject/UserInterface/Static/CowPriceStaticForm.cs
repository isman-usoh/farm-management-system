using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using MainProject.Database;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using MainProject.Database.FarmManageDataSetTableAdapters;
using System.Text;

namespace MainProject.UserInterface.Static
{
    public partial class CowPriceStaticForm : Form
    {
        private Random random = new Random();
        private CowTableAdapter CowTable = new CowTableAdapter();
        public CowPriceChartForm CharForm;

        private Dictionary<Int32, String> OrderInYear;
        private Dictionary<Int32, String> OrderOutYear;

        public Double?[] data1;
        public Double?[] data2;
        public Double?[] data3;
        public Double?[] data4;

        

        public CowPriceStaticForm()
        {
            InitializeComponent();
        }

        private void StaticCow_Load(object sender, EventArgs e)
        {
            DateTime OrderInMinDate = new OrderInTableAdapter().QueryMinDate() ?? DateTime.Now;
            DateTime OrderOutMinDate = new OrderOutTableAdapter().QueryMinDate() ?? DateTime.Now;

            OrderInYear = new Dictionary<Int32, String>();
            int Start = OrderInMinDate.Year;
            int End = DateTime.Now.Year;
            for (int i = Start; i <= End; i++)
            {
                OrderInYear.Add(i, new DateTime(i, 1, 1).ToString("yyyy"));
            }

            OrderOutYear = new Dictionary<Int32, String>();
            Start = OrderOutMinDate.Year;
            End = DateTime.Now.Year;
            for (int i = Start; i <= End; i++)
            {
                OrderOutYear.Add(i, new DateTime(i, 1, 1).ToString("yyyy"));
            }

            //////////////////////////////
            Dictionary<Int32, String> GeneList = new Dictionary<Int32, String>();
            GeneList.Add(-1, "ทั้งหมด");
            foreach (FarmManageDataSet.GeneRow row in this.geneTableAdapter.GetData())
            {
                GeneList.Add(row.GeneID, row.Name);
            }
            cbxGene1.DataSource = GeneList.ToList();
            cbxGene2.DataSource = GeneList.ToList();
            cbxGene3.DataSource = GeneList.ToList();
            cbxGene4.DataSource = GeneList.ToList();


            Dictionary<Int32, String> TypeList = new Dictionary<Int32, String>();
            TypeList.Add(0, "ราคาซื้อ");
            TypeList.Add(1, "ราคาขาย");
            cbxType1.DataSource = TypeList.ToList();
            cbxType2.DataSource = TypeList.ToList();
            cbxType3.DataSource = TypeList.ToList();
            cbxType4.DataSource = TypeList.ToList();

            ////////////////////////////////////////////

                //CowPriceChart.Series[0].Points[i].XValue = i + 1;
                //CowPriceChart.Series[0].Points[i].AxisLabel = time.AddMonths(i).ToString("MMMM");

                //CowPriceChart.Series[1].Points[i].XValue = i + 1;
                //CowPriceChart.Series[1].Points[i].AxisLabel = time.AddMonths(i).ToString("MMMM");

                //CowPriceChart.Series[2].Points[i].XValue = i + 1;
                //CowPriceChart.Series[2].Points[i].AxisLabel = time.AddMonths(i).ToString("MMMM");

                //CowPriceChart.Series[3].Points[i].XValue = i + 1;
                //CowPriceChart.Series[3].Points[i].AxisLabel = time.AddMonths(i).ToString("MMMM");


                //if (i == random.Next(0, 11))
                //{
                //    CowPriceChart.Series[0].Points[i].IsEmpty = true;
                //}
                //else
                //{
                //    Double Value1 = random.Next(10000, 15000);
                //    CowPriceChart.Series[0].Points[i].IsEmpty = false;
                //    CowPriceChart.Series[0].Points[i].LabelToolTip = String.Format("{0:C2}", Value1);
                //    CowPriceChart.Series[0].Points[i].Label = String.Format("{0:0}", Value1);
                //    CowPriceChart.Series[0].Points[i].YValues = new Double[] { Value1 };
                //}


                //if (i == random.Next(0, 11))
                //{
                //    CowPriceChart.Series[1].Points[i].IsEmpty = true;
                //}
                //else
                //{
                //    Double Value2 = random.Next(10000, 15000);
                //    CowPriceChart.Series[1].Points[i].IsEmpty = false;
                //    CowPriceChart.Series[1].Points[i].LabelToolTip = String.Format("{0:C}", Value2);
                //    CowPriceChart.Series[1].Points[i].Label = String.Format("{0:0}", Value2);
                //    CowPriceChart.Series[1].Points[i].YValues = new Double[] { Value2 };
                //}


                //if (i == random.Next(0, 11))
                //{
                //    CowPriceChart.Series[2].Points[i].IsEmpty = true;
                //}
                //else
                //{
                //    Double Value3 = random.Next(10000, 15000);
                //    CowPriceChart.Series[2].Points[i].IsEmpty = false;
                //    CowPriceChart.Series[2].Points[i].LabelToolTip = String.Format("{0:C}", Value3);
                //    CowPriceChart.Series[2].Points[i].Label = String.Format("{0:0}", Value3);
                //    CowPriceChart.Series[2].Points[i].YValues = new Double[] { Value3 };
                //}


                //if (i == random.Next(0, 11))
                //{
                //    CowPriceChart.Series[3].Points[i].IsEmpty = true;
                //}
                //else
                //{
                //    Double Value4 = random.Next(10000, 15000);
                //    CowPriceChart.Series[3].Points[i].IsEmpty = false;
                //    CowPriceChart.Series[3].Points[i].LabelToolTip = String.Format("{0:C}", Value4);
                //    CowPriceChart.Series[3].Points[i].Label = String.Format("{0:0}", Value4);
                //    CowPriceChart.Series[3].Points[i].YValues = new Double[] { Value4 };
                //}
            //}
        }

        private void chbEnable_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Equals(this.chbEnable1))
            {
                cbxGene1.Enabled = cb.Checked;
                cbxYear1.Enabled = cb.Checked;
                cbxType1.Enabled = cb.Checked;
                btnPreview1.Enabled = cb.Checked;
            }
            else if (cb.Equals(this.chbEnable2))
            {
                cbxGene2.Enabled = cb.Checked;
                cbxYear2.Enabled = cb.Checked;
                cbxType2.Enabled = cb.Checked;
                btnPreview2.Enabled = cb.Checked;
            }
            else if (cb.Equals(this.chbEnable3))
            {
                cbxGene3.Enabled = cb.Checked;
                cbxYear3.Enabled = cb.Checked;
                cbxType3.Enabled = cb.Checked;
                btnPreview3.Enabled = cb.Checked;
            }
            else if (cb.Equals(this.chbEnable4))
            {
                cbxGene4.Enabled = cb.Checked;
                cbxYear4.Enabled = cb.Checked;
                cbxType4.Enabled = cb.Checked;
                btnPreview4.Enabled = cb.Checked;
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Equals(cbxType1))
            {
                if (Convert.ToByte(cb.SelectedValue) == 0)
                {
                    this.cbxYear1.DataSource = OrderInYear.ToList();
                }
                else
                {
                    this.cbxYear1.DataSource = OrderOutYear.ToList();
                }
            }
            else if (cb.Equals(cbxType2))
            {
                if (Convert.ToByte(cb.SelectedValue) == 0)
                {
                    this.cbxYear2.DataSource = OrderInYear.ToList();
                }
                else
                {
                    this.cbxYear2.DataSource = OrderOutYear.ToList();
                }
            }
            else if (cb.Equals(cbxType3))
            {
                if (Convert.ToByte(cb.SelectedValue) == 0)
                {
                    this.cbxYear3.DataSource = OrderInYear.ToList();
                }
                else
                {
                    this.cbxYear3.DataSource = OrderOutYear.ToList();
                }
            }
            else if (cb.Equals(cbxType4))
            {
                if (Convert.ToByte(cb.SelectedValue) == 0)
                {
                    this.cbxYear4.DataSource = OrderInYear.ToList();
                }
                else
                {
                    this.cbxYear4.DataSource = OrderOutYear.ToList();
                }
            }
        }

        private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Equals(cbxYear1))
            {
                cbxGene1.SelectedValue = -1;
            }
            else if (cb.Equals(cbxYear2))
            {
                cbxGene2.SelectedValue = -1;
            }
            else if (cb.Equals(cbxYear3))
            {
                cbxGene3.SelectedValue = -1;
            }
            else if (cb.Equals(cbxYear4))
            {
                cbxGene4.SelectedValue = -1;
            }
        }




        


       
       
        private void btnPreview_Click(object sender, EventArgs e)
        {
            initData();

            if (CharForm != null)
                CharForm.Close();

            
            CharForm = new CowPriceChartForm();
            CharForm.data1 = data1;
            CharForm.data2 = data2;
            CharForm.data3 = data3;
            CharForm.data4 = data4;
            CharForm.Show();
        }

        private void initData()
        {
            if (chbEnable1.Checked)
            {
                Int32 Year = Convert.ToInt32(this.cbxYear1.SelectedValue);
                Int32 Gene = Convert.ToInt32(this.cbxGene1.SelectedValue);

                data1 = new double?[12];

                switch (Convert.ToInt32(this.cbxType1.SelectedValue))
                {
                    case 0:
                        for (int i = 0; i < data1.Length; i++)
                        {
                            DateTime date1 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderInAmount(Gene, date1, date1.AddMonths(1).AddDays(-1));
                            if(result != null){
                                data1[i] = (double)result;
                            }
                        }
                        break;
                    case 1:
                        for (int i = 0; i < data1.Length; i++)
                        {
                            DateTime date2 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderOutAmount(Gene, date2, date2.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data1[i] = (double)result;
                            }
                        }
                        break;
                }
            }
            else
            {
                data1 = null;
            }




            if (chbEnable2.Checked)
            {
                Int32 Year = Convert.ToInt32(this.cbxYear2.SelectedValue);
                Int32 Gene = Convert.ToInt32(this.cbxGene2.SelectedValue);

                data2 = new double?[12];

                switch (Convert.ToInt32(this.cbxType2.SelectedValue))
                {
                    case 0:
                        for (int i = 0; i < data2.Length; i++)
                        {
                            DateTime date1 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderInAmount(Gene, date1, date1.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data2[i] = (double)result;
                            }
                        }
                        break;
                    case 1:
                        for (int i = 0; i < data2.Length; i++)
                        {
                            DateTime date2 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderOutAmount(Gene, date2, date2.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data2[i] = (double)result;
                            }
                        }
                        break;
                }
            }
            else
            {
                data2 = null;
            }


            if (chbEnable3.Checked)
            {
                Int32 Year = Convert.ToInt32(this.cbxYear3.SelectedValue);
                Int32 Gene = Convert.ToInt32(this.cbxGene3.SelectedValue);

                data3 = new double?[12];

                switch (Convert.ToInt32(this.cbxType3.SelectedValue))
                {
                    case 0:
                        for (int i = 0; i < data3.Length; i++)
                        {
                            DateTime date1 = new DateTime(Year, i + 1, 1);
                            var result =this.CowTable.QueryOrderInAmount(Gene, date1, date1.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data3[i] = (double)result;
                            }
                        }
                        break;
                    case 1:
                        for (int i = 0; i < data3.Length; i++)
                        {
                            DateTime date2 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderOutAmount(Gene, date2, date2.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data3[i] = (double)result;
                            }
                        }
                        break;
                }
            }
            else
            {
                data3 = null;
            }


            if (chbEnable4.Checked)
            {
                Int32 Year = Convert.ToInt32(this.cbxYear4.SelectedValue);
                Int32 Gene = Convert.ToInt32(this.cbxGene4.SelectedValue);

                data4 = new double?[12];

                switch (Convert.ToInt32(this.cbxType4.SelectedValue))
                {
                    case 0:
                        for (int i = 0; i < data4.Length; i++)
                        {
                            DateTime date1 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderInAmount(Gene, date1, date1.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data4[i] = (double)result;
                            }
                        }
                        break;
                    case 1:
                        for (int i = 0; i < data4.Length; i++)
                        {
                            DateTime date2 = new DateTime(Year, i + 1, 1);
                            var result = this.CowTable.QueryOrderOutAmount(Gene, date2, date2.AddMonths(1).AddDays(-1));
                            if (result != null)
                            {
                                data4[i] = (double)result;
                            }
                        }
                        break;
                }
            }
            else
            {
                data4 = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data1 = new Double?[12];
            data2 = new Double?[12];
            data3 = new Double?[12];
            data4 = new Double?[12];

            for (int i = 0; i < 12; i++)
            {
                if (random.Next(1000, 12000) % 12 != i)
                {
                    data1[i] = random.Next(10000, 20000);
                }

                if (random.Next(1000, 12000) % 12 != i)
                {
                    data2[i] = random.Next(10000, 20000);
                }

                if (random.Next(1000, 12000) % 12 != i)
                {
                    data3[i] = random.Next(10000, 20000);
                }

                if (random.Next(1000, 12000)%12 != i)
                {
                    data4[i] = random.Next(10000, 20000);
                }
            }


            if (CharForm != null)
                CharForm.Close();


            CharForm = new CowPriceChartForm();
            CharForm.data1 = data1;
            CharForm.data2 = data2;
            CharForm.data3 = data3;
            CharForm.data4 = data4;
            CharForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
