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
    public partial class FormParabol : Form
    {
        private static DrawingObject parabol = new Parabol(350, 0, 0.01);
        private static int x0 = 350, y0 = 0;
        private static double a = 0.01;
        private static int algorithmIndex = 0;

        public FormParabol()
        {
            InitializeComponent();

            comboBox_Algorithm.Items.Add("Mid point");
            comboBox_Algorithm.Items.Add("DDA");

            numericUpDown_a.Value=new decimal(a);
            numericUpDown_VertexX.Value = x0;
            numericUpDown_VertexY.Value = y0;

            comboBox_Algorithm.SelectedIndex = algorithmIndex;
        }

        public static DrawingObject getParabol()
        {
            return parabol;
        }

        public static int getAlgorithm()
        {
            return algorithmIndex;
        }

        private void FormParabol_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_FormParabol_Click(object sender, EventArgs e)
        {
            a = (double)numericUpDown_a.Value;
            x0 = (int)numericUpDown_VertexX.Value;
            y0 = (int)numericUpDown_VertexY.Value;
            parabol = new Parabol(x0, y0, a);

            algorithmIndex = comboBox_Algorithm.SelectedIndex;

            this.Close();
        }

        private void numericUpDown_a_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
