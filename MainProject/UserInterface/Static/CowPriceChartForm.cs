using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainProject.UserInterface.Static
{
    public partial class CowPriceChartForm : Form
    {

        public Double?[] data1;

        public Double?[] data2;

        public Double?[] data3;

        public Double?[] data4;

        private List<String> Month = new List<String>();


        public CowPriceChartForm()
        {
            InitializeComponent();
        }

        private void CowPriceChartForm_Load(object sender, EventArgs e)
        {
            DateTime time = new DateTime(2000, 1, 1);
            for (int i = 0; i < 12; i++)
            {
                Month.Add(time.AddMonths(i).ToString("MMMM"));
            }

            this.initialData1();
            this.initialData2();
            this.initialData3();
            this.initialData4();
        }


        private void initialData1()
        {
            if (data1 != null)
            {
                this.CowPriceChart.Series[0].Enabled = true;

                for (Int32 i = 0; i < data1.Length; i++)
                {
                    CowPriceChart.Series[0].Points[i].AxisLabel = Month[i];
                    CowPriceChart.Series[0].Points[i].XValue = i + 1;
                    if (data1[i] == null)
                    {
                        CowPriceChart.Series[0].Points[i].IsEmpty = true;
                    }
                    else
                    {
                        CowPriceChart.Series[0].Points[i].IsEmpty = false;
                        CowPriceChart.Series[0].Points[i].YValues = new Double[] { data1[i].Value };
                    }
                }
            }
            else
            {
                this.CowPriceChart.Series[0].Enabled = false;
            }
        }

        private void initialData2()
        {
            if (data2 != null)
            {
                this.CowPriceChart.Series[1].Enabled = true;

                for (Int32 i = 0; i < data2.Length; i++)
                {
                    CowPriceChart.Series[1].Points[i].AxisLabel = Month[i];
                    CowPriceChart.Series[1].Points[i].XValue = i + 1;
                    if (data2[i] == null)
                    {
                        CowPriceChart.Series[1].Points[i].IsEmpty = true;
                    }
                    else
                    {
                        CowPriceChart.Series[1].Points[i].IsEmpty = false;
                        CowPriceChart.Series[1].Points[i].YValues = new Double[] { data2[i].Value };
                    }
                }
            }
            else
            {
                this.CowPriceChart.Series[1].Enabled = false;
            }
        }

        private void initialData3()
        {
            if (data3 != null)
            {
                this.CowPriceChart.Series[2].Enabled = true;

                for (Int32 i = 0; i < data3.Length; i++)
                {
                    CowPriceChart.Series[2].Points[i].AxisLabel = Month[i];
                    CowPriceChart.Series[2].Points[i].XValue = i + 1;
                    if (data3[i] == null)
                    {
                        CowPriceChart.Series[2].Points[i].IsEmpty = true;
                    }
                    else
                    {
                        CowPriceChart.Series[2].Points[i].IsEmpty = false;
                        CowPriceChart.Series[2].Points[i].YValues = new Double[] { data3[i].Value };
                    }
                }
            }
            else
            {
                this.CowPriceChart.Series[2].Enabled = false;
            }
        }

        private void initialData4()
        {
            if (data4 != null)
            {
                this.CowPriceChart.Series[3].Enabled = true;

                for (Int32 i = 0; i < data4.Length; i++)
                {
                    CowPriceChart.Series[3].Points[i].AxisLabel = Month[i];
                    CowPriceChart.Series[3].Points[i].XValue = i + 1;
                    if (data4[i] == null)
                    {
                        CowPriceChart.Series[3].Points[i].IsEmpty = true;
                    }
                    else
                    {
                        CowPriceChart.Series[3].Points[i].IsEmpty = false;
                        CowPriceChart.Series[3].Points[i].YValues = new Double[] { data4[i].Value };
                    }
                }
            }
            else
            {
                this.CowPriceChart.Series[3].Enabled = false;
            }
        }
    }
}
