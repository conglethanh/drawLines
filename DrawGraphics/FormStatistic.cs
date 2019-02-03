using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    public partial class FormStatistic : Form
    {
        private long time_DDA = 0, time_Bresenham = 0, time_Midpoint = 0, time_XiaolinWu = 0;
        public FormStatistic()
        {
            InitializeComponent();




        }

        public void setTimeForStat(long dda, long bresenham, long midpoint, long xiaolinWu)
        {
            time_DDA = dda;
            time_Bresenham = bresenham;
            time_Midpoint = midpoint;
            time_XiaolinWu = xiaolinWu;
        }


        private void FormStatistic_Load(object sender, EventArgs e)
        {
            if (time_DDA > 0)
                label_time_dda.Text = time_DDA.ToString() + " (ms)";
            if (time_Bresenham > 0)
                label_time_bresenham.Text = time_Bresenham.ToString() + " (ms)";
            if (time_Midpoint > 0)
                label_time_midpoint.Text = time_Midpoint.ToString() + " (ms)";
            if (time_XiaolinWu > 0)
                label_time_xiaolin.Text = time_XiaolinWu.ToString() + " (ms)";

        }

        private void btn_OK_formStat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_time_midpoint_Click(object sender, EventArgs e)
        {

        }
    }
}
