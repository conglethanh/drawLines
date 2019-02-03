using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeDrawings;

namespace DrawGraphics
{
    public partial class FormLine : Form
    {
        private static DrawingObject line = new Line(0, 0, 700, 500);
        private static int x0 = 0, y0 = 0, x1 = 700, y1 = 500;
        private static int algorithmIndex = 0;
        public FormLine()
        {
            InitializeComponent();

            comboBox_Algorithm.Items.Add("DDA");
            comboBox_Algorithm.Items.Add("Bresenham");
            comboBox_Algorithm.Items.Add("Mid point");
            comboBox_Algorithm.Items.Add("Xiaolin Wu");

            numericUpDown_Xstart.Value = x0;
            numericUpDown_Ystart.Value = y0;
            numericUpDown_Xend.Value = x1;
            numericUpDown_Yend.Value = y1;

            comboBox_Algorithm.SelectedIndex=algorithmIndex;
        }

        private void setData()
        {
            x0 = (int)numericUpDown_Xstart.Value;
            y0 = (int)numericUpDown_Ystart.Value;
            x1 = (int)numericUpDown_Xend.Value;
            y1 = (int)numericUpDown_Yend.Value;

            line = new Line(x0, y0, x1, y1);
            algorithmIndex = comboBox_Algorithm.SelectedIndex;
        }

        public static DrawingObject getLine()
        {
            return line;
        }

        public static int getAlgorithm()
        {
            return algorithmIndex;
        }

        private void FormLine_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_OK_Line_Click(object sender, EventArgs e)
        {
            setData();
            this.Close();
        }

        private void comboBox_Algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
