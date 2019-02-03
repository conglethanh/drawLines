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
    public partial class FormRandomOptions : Form
    {

        public const int Line = 0;
        public const int Circle = 1;
        public const int Ellipse = 2;
        public const int Parabol = 3;
        public const int Hyperbol = 4;
        public const int Acc_line = 5;

        private static int type = Line;
        private static int objectNumber = 0;

        public FormRandomOptions()
        {
            InitializeComponent();

            comboBox_RandomOptions_Shape.Items.Add("Time - Line");
            comboBox_RandomOptions_Shape.Items.Add("Time - Circle");
            comboBox_RandomOptions_Shape.Items.Add("Time - Ellipse");
            comboBox_RandomOptions_Shape.Items.Add("Time - Parabol");
            comboBox_RandomOptions_Shape.Items.Add("Time - Hyperbol");
            comboBox_RandomOptions_Shape.Items.Add("Accuracy - Line");

            comboBox_RandomOptions_Shape.SelectedIndex = type;
            numericUpDown_numObject.Value = objectNumber;
        }

        public static int getType()
        {
            return type;
        }

        public static int getObjectNumer()
        {
            return objectNumber;
        }
        private void showOnListBox(int type)
        {
            listBox_RandomOptions_Algorithm.Items.Clear();
            switch (type)
            {
                case Line:
                    listBox_RandomOptions_Algorithm.Items.Add("DDA");
                    listBox_RandomOptions_Algorithm.Items.Add("Bresenham");
                    listBox_RandomOptions_Algorithm.Items.Add("Mid point");
                    listBox_RandomOptions_Algorithm.Items.Add("Xiaolin Wu");
                    break;
                case Circle:
                    listBox_RandomOptions_Algorithm.Items.Add("Mid point");
                    listBox_RandomOptions_Algorithm.Items.Add("DDA");
                    break;
                case Ellipse:
                    listBox_RandomOptions_Algorithm.Items.Add("Mid point");
                    listBox_RandomOptions_Algorithm.Items.Add("DDA");
                    break;
                case Parabol:
                    listBox_RandomOptions_Algorithm.Items.Add("Mid point");
                    listBox_RandomOptions_Algorithm.Items.Add("DDA");
                    break;
                case Hyperbol:
                    listBox_RandomOptions_Algorithm.Items.Add("Mid point");
                    listBox_RandomOptions_Algorithm.Items.Add("DDA");
                    break;
                case Acc_line:
                    listBox_RandomOptions_Algorithm.Items.Add("DDA");
                    listBox_RandomOptions_Algorithm.Items.Add("Bresenham");
                    listBox_RandomOptions_Algorithm.Items.Add("Mid point");
                    listBox_RandomOptions_Algorithm.Items.Add("Xiaolin Wu");
                    break;
            }
        }

        private void FormRandomOptions_Load(object sender, EventArgs e)
        {

        }

        private void btn_RandomOptions_OK_Click(object sender, EventArgs e)
        {
            type = comboBox_RandomOptions_Shape.SelectedIndex;
            objectNumber = (int)numericUpDown_numObject.Value;
            this.Close();
        }

        private void comboBox_RandomOptions_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            showOnListBox(comboBox_RandomOptions_Shape.SelectedIndex);
        }

        private void listBox_RandomOptions_Algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
