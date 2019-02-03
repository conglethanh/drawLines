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
    public partial class FormEllipse : Form
    {
        private static DrawingObject ellipse = new Ellipse(350, 250, 100,70);
        private static int x0 = 350, y0 = 250;
        private static int a = 100,b=70;
        private static int algorithmIndex = 0;
        public FormEllipse()
        {
            InitializeComponent();

            comboBox_Algorithm.Items.Add("Mid point");
            comboBox_Algorithm.Items.Add("DDA");

            numericUpDown_a.Value = a;
            numericUpDown_b.Value = b;
            numericUpDown_VertexX.Value = x0;
            numericUpDown_VertexY.Value = y0;

            comboBox_Algorithm.SelectedIndex = algorithmIndex;
        }

        public static DrawingObject getellipse()
        {
            return ellipse;
        }

        public static int getAlgorithm()
        {
            return algorithmIndex;
        }

        private void Formellipse_Load(object sender, EventArgs e)
        {

        }


        private void btn_OK_FormEllipse_Click(object sender, EventArgs e)
        {
            a = (int)numericUpDown_a.Value;
            b = (int)numericUpDown_b.Value;
            x0 = (int)numericUpDown_VertexX.Value;
            y0 = (int)numericUpDown_VertexY.Value;
            ellipse = new Ellipse(x0, y0, a, b);

            algorithmIndex = comboBox_Algorithm.SelectedIndex;
            this.Close();
        }

        private void FormEllipse_Load_1(object sender, EventArgs e)
        {

        }
    }
}
