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
    public partial class FormAccuracy : Form
    {
        private double var_DDA = 0, var_Bresenham = 0, var_Midpoint = 0, var_Xiaolin = 0;
        public FormAccuracy()
        {
            InitializeComponent();




        }

        public void setVarForAcc(double dda, double bresenham, double midpoint, double xiaolinWu)
        {
            var_DDA = dda;
            var_Bresenham = bresenham;
            var_Midpoint = midpoint;
            var_Xiaolin = xiaolinWu;
        }


        private void FormAccuracy_Load(object sender, EventArgs e)
        {
            if (var_DDA > 0)
                label_var_dda.Text = var_DDA.ToString();
            if (var_Bresenham > 0)
                label_var_bresenham.Text= var_Bresenham.ToString();
            if (var_Midpoint > 0)
                label_var_midpoint.Text = var_Midpoint.ToString();
            if (var_Xiaolin > 0)
                label_var_xiaolin.Text = var_Xiaolin.ToString();

        }

        private void btn_OK_formStat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_time_midpoint_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_formStat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
