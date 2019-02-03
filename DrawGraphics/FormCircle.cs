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
    public partial class FormCircle : Form
    {
        private static DrawingObject circle = new Circle(350, 250, 100);
        private static int x0 = 350, y0 = 250;
        private static int radius = 100;
        private static int algorithmIndex = 0;

        public FormCircle()
        {
            InitializeComponent();
            comboBox_Algorithm.Items.Add("Mid point");
            comboBox_Algorithm.Items.Add("DDA");

            numericUpDown_a.Value = radius;
            numericUpDown_VertexX.Value = x0;
            numericUpDown_VertexY.Value = y0;

            comboBox_Algorithm.SelectedIndex = algorithmIndex;
        }

        public static DrawingObject getcircle()
        {
            return circle;
        }

        public static int getAlgorithm()
        {
            return algorithmIndex;
        }

        private void FormCircle_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_FormCircle_Click(object sender, EventArgs e)
        {
            radius = (int)numericUpDown_a.Value;
            x0 = (int)numericUpDown_VertexX.Value;
            y0 = (int)numericUpDown_VertexY.Value;

            algorithmIndex = comboBox_Algorithm.SelectedIndex;
            circle = new Circle(x0, y0,radius);
            this.Close();
        }
    }
}
