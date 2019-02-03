using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeDrawings;

namespace DrawGraphics
{
    public partial class FormMain : Form
    {
        public Bitmap bmp;
        public Bitmap pixel;
        public Graphics graphics;

        //const default
        private const int DDA = 0;
        private const int Bresenham = 1;
        private const int MidPoint = 2;
        private const int XiaolinWu = 3;

        private const int max_X = 700;
        private const int max_Y = 500;

        private Int64 time_DDA = 0, time_Bresenham = 0, time_MidPoint = 0, time_XiaolinWu = 0;
        //private static double var = 0;

        DrawingObject line, circle, ellipse, parabol, hyperbol;

        delegate void SetPixelFunc(int x, int y, Color color);

        Thread t_runTest;

        public FormMain()
        {
            InitializeComponent();

            listBox1.Items.Add("All");
            listBox1.Items.Add("Line");
            listBox1.Items.Add("Circle");
            listBox1.Items.Add("Ellipse");
            listBox1.Items.Add("Parabol");
            listBox1.Items.Add("Hyperbol");
            listBox1.SelectedIndex = 0;


        }

        private void drawOnePixel(int x, int y)
        {
            SetPixelFunc func = new SetPixelFunc(SetPixel);
            try
            {
                if (x >= 0 && y >= 0 && x < picBox_main.Width && y < picBox_main.Height)
                    picBox_main.Invoke(func, x, y, Color.Red);


            }
            catch (InvalidOperationException)
            {
                return;
            }
        }

        private void drawOnePixelWithBrightness(int x, int y, double brightness)
        {
            int alpha = (int)(brightness * 255);
            if (alpha > 255) alpha = 255;
            if (alpha < 0) alpha = 0;
            Color color = Color.FromArgb(alpha, Color.Red);

            SetPixelFunc func = new SetPixelFunc(SetPixel);
            try
            {
                if (x >= 0 && y >= 0 && x < picBox_main.Width && y < picBox_main.Height)
                    picBox_main.Invoke(func, x, y, color);
            }
            catch (InvalidOperationException)
            {
                return;
            }
        }

        private void Init()
        {

            if (graphics != null) graphics.Dispose();
            picBox_main.Image = null;
            if (bmp != null) bmp.Dispose();
            bmp = new Bitmap(picBox_main.Width, picBox_main.Height);
            if (pixel != null) pixel.Dispose();
            pixel = new Bitmap(1, 1);
            picBox_main.Image = bmp;

            graphics = picBox_main.CreateGraphics();



        }

        private void SetPixel(int x, int y, Color color)
        {

            lock (graphics)
            {
                pixel.SetPixel(0, 0, color);
                graphics.DrawImageUnscaled(pixel, x, y);
                bmp.SetPixel(x, y, color);
            }
        }

        private void picBox_main_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (graphics != null && bmp != null && pixel != null)
            {
                graphics.Dispose();
                bmp.Dispose();
                pixel.Dispose();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_inputLine_Click(object sender, EventArgs e)
        {
            FormLine drawLineForm = new FormLine();
            drawLineForm.StartPosition = FormStartPosition.CenterScreen;
            drawLineForm.ShowDialog();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == 0)
            {
                Init();
                line = FormLine.getLine();
                int mode = FormLine.getAlgorithm();
                if (mode == DDA)
                    line.draw_DDA(drawOnePixel);
                else if (mode == Bresenham)
                    line.draw_Bresenham(drawOnePixel);
                else if (mode == MidPoint)
                    line.draw_MidPoint(drawOnePixel);
                else if (mode == XiaolinWu)
                    line.draw_XiaolinWu(drawOnePixelWithBrightness);

                circle = FormCircle.getcircle();
                if (FormCircle.getAlgorithm() == 0)
                    circle.draw_MidPoint(drawOnePixel);
                else if (FormCircle.getAlgorithm() == 1)
                    circle.draw_DDA(drawOnePixel);

                ellipse = FormEllipse.getellipse();
                if (FormEllipse.getAlgorithm() == 0)
                    ellipse.draw_MidPoint(drawOnePixel);
                else if (FormEllipse.getAlgorithm() == 1)
                    ellipse.draw_DDA(drawOnePixel);

                parabol = FormParabol.getParabol();
                if (FormParabol.getAlgorithm() == 0)
                    parabol.draw_MidPoint(drawOnePixel);
                else if (FormParabol.getAlgorithm() == 1)
                    parabol.draw_DDA(drawOnePixel);


                hyperbol = FormHyperbol.getHyperbol();
                if (FormHyperbol.getAlgorithm() == 0)
                    hyperbol.draw_MidPoint(drawOnePixel);
                else if (FormHyperbol.getAlgorithm() == 1)
                    hyperbol.draw_DDA(drawOnePixel);
            }
            else if (listBox1.SelectedIndex == 1)
            {
                Init();
                line = FormLine.getLine();
                int mode = FormLine.getAlgorithm();
                if (mode == DDA)
                    line.draw_DDA(drawOnePixel);
                else if (mode == Bresenham)
                    line.draw_Bresenham(drawOnePixel);
                else if (mode == MidPoint)
                    line.draw_MidPoint(drawOnePixel);
                else if (mode == XiaolinWu)
                    line.draw_XiaolinWu(drawOnePixelWithBrightness);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                Init();
                circle = FormCircle.getcircle();
                if (FormCircle.getAlgorithm() == 0)
                    circle.draw_MidPoint(drawOnePixel);
                else if (FormCircle.getAlgorithm() == 1)
                    circle.draw_DDA(drawOnePixel);
            }
            else if (listBox1.SelectedIndex == 3)
            {
                Init();
                ellipse = FormEllipse.getellipse();
                if (FormEllipse.getAlgorithm() == 0)
                    ellipse.draw_MidPoint(drawOnePixel);
                else if (FormEllipse.getAlgorithm() == 1)
                    ellipse.draw_DDA(drawOnePixel);
            }
            else if (listBox1.SelectedIndex == 4)
            {
                Init();
                parabol = FormParabol.getParabol();
                if (FormParabol.getAlgorithm() == 0)
                    parabol.draw_MidPoint(drawOnePixel);
                else if (FormParabol.getAlgorithm() == 1)
                    parabol.draw_DDA(drawOnePixel);
            }
            else if (listBox1.SelectedIndex == 5)
            {
                Init();
                hyperbol = FormHyperbol.getHyperbol();
                if (FormHyperbol.getAlgorithm() == 0)
                    hyperbol.draw_MidPoint(drawOnePixel);
                else if (FormHyperbol.getAlgorithm() == 1)
                    hyperbol.draw_DDA(drawOnePixel);
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Init();
        }

        System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
        private void btn_statistics_Click(object sender, EventArgs e)
        {
            time_DDA = 0;
            time_Bresenham = 0;
            time_MidPoint = 0;
            time_XiaolinWu = 0;
            t_runTest = new Thread(new ThreadStart(runTestTimerAlgorithm));
            t_runTest.Start();
        }

        private void runTestTimerAlgorithm()
        {
            btn_Clear.Enabled = false;
            btn_draw.Enabled = false;
            btn_inputLine.Enabled = false;
            btn_randomOptions.Enabled = false;
            btn_statistics.Enabled = false;

            btn_inputCircle.Enabled = false;
            btn_inputEllipse.Enabled = false;
            btn_inputParabol.Enabled = false;
            btn_intputHyperbol.Enabled = false;

            listBox1.Enabled = false;

            int shapeType = FormRandomOptions.getType();
            int numberObject = FormRandomOptions.getObjectNumer();
            Init();
            int[] x0, y0;

            switch (shapeType)
            {
                case FormRandomOptions.Line:
                    x0 = new int[numberObject];
                    y0 = new int[numberObject];
                    int[] x1 = new int[numberObject];
                    int[] y1 = new int[numberObject];
                    //Random range 0..numberObject-1
                    Random rd = new Random();
                    for (int i = 0; i < numberObject; i++)
                    {
                        x0[i] = rd.Next(0, max_X);
                        y0[i] = rd.Next(0, max_Y);
                        x1[i] = rd.Next(0, max_X);
                        y1[i] = rd.Next(0, max_Y);
                    }

                    //timer DDA
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Line(x0[i], y0[i], x1[i], y1[i]);
                        time.Reset();
                        time.Start();
                        myObject.draw_DDA(drawOnePixel);
                        time.Stop();
                        time_DDA += time.ElapsedMilliseconds;
                        numObj.Text = (i + 1).ToString();
                    }


                    //timer Bresenham

                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Line(x0[i], y0[i], x1[i], y1[i]);
                        time.Reset();
                        time.Start();
                        myObject.draw_Bresenham(drawOnePixel);
                        time.Stop();
                        time_Bresenham += time.ElapsedMilliseconds;
                        numObj.Text = (i + 1).ToString();
                    }


                    //timer midpoint

                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Line(x0[i], y0[i], x1[i], y1[i]);
                        time.Reset();
                        time.Start();
                        myObject.draw_MidPoint(drawOnePixel);
                        time.Stop();
                        time_MidPoint += time.ElapsedMilliseconds;
                        numObj.Text = (i + 1).ToString();
                    }


                    //timer xiaolin wu

                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Line(x0[i], y0[i], x1[i], y1[i]);
                        time.Reset();
                        time.Start();
                        myObject.draw_XiaolinWu(drawOnePixelWithBrightness);
                        time.Stop();
                        time_XiaolinWu += time.ElapsedMilliseconds;
                        numObj.Text = (i + 1).ToString();
                    }
                    break;

                case FormRandomOptions.Circle:
                    time_Bresenham = 0;
                    time_DDA = 0;
                    time_XiaolinWu = 0;

                    x0 = new int[numberObject];
                    y0 = new int[numberObject];
                    int[] radius = new int[numberObject];

                    //Random range 0..numberObject-1
                    rd = new Random();
                    for (int i = 0; i < numberObject; i++)
                    {
                        radius[i] = rd.Next(0, max_Y / 4);
                        x0[i] = rd.Next(max_X / 3, 2 * max_X / 3);
                        y0[i] = rd.Next(max_Y / 3, 2 * max_Y / 3);
                    }

                    //timer midpoint
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Circle(x0[i], y0[i], radius[i]);
                        myObject.draw_MidPoint(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_MidPoint = time.ElapsedMilliseconds;

                    //timer dda
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Circle(x0[i], y0[i], radius[i]);
                        myObject.draw_DDA(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_DDA = time.ElapsedMilliseconds;
                    break;

                case FormRandomOptions.Ellipse:
                    time_Bresenham = 0;
                    time_DDA = 0;
                    time_XiaolinWu = 0;

                    x0 = new int[numberObject];
                    y0 = new int[numberObject];
                    int[] halBigAxis = new int[numberObject];
                    int[] halfSmallAxis = new int[numberObject];

                    //Random range 0..numberObject-1
                    rd = new Random();
                    for (int i = 0; i < numberObject; i++)
                    {
                        halBigAxis[i] = rd.Next(0, max_Y / 4);
                        halfSmallAxis[i] = rd.Next(0, max_Y / 4);
                        x0[i] = rd.Next(max_X / 3, 2 * max_X / 3);
                        y0[i] = rd.Next(max_Y / 3, 2 * max_Y / 3);
                    }

                    //timer midpoint
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Ellipse(x0[i], y0[i], halBigAxis[i], halfSmallAxis[i]);
                        myObject.draw_MidPoint(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_MidPoint = time.ElapsedMilliseconds;

                    //timer dda
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Ellipse(x0[i], y0[i], halBigAxis[i], halfSmallAxis[i]);
                        myObject.draw_DDA(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_DDA = time.ElapsedMilliseconds;
                    break;

                case FormRandomOptions.Parabol:
                    time_Bresenham = 0;
                    time_DDA = 0;
                    time_XiaolinWu = 0;

                    x0 = new int[numberObject];
                    y0 = new int[numberObject];
                    double[] a = new double[numberObject];

                    //Random range 0..numberObject-1
                    rd = new Random();
                    for (int i = 0; i < numberObject; i++)
                    {
                        a[i] = rd.NextDouble();
                        x0[i] = rd.Next(300, 400);
                        y0[i] = rd.Next(100, 200);
                    }

                    //timer midpoint
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Parabol(x0[i], y0[i], a[i]);
                        myObject.draw_MidPoint(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_MidPoint = time.ElapsedMilliseconds;

                    //timer dda
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Parabol(x0[i], y0[i], a[i]);
                        myObject.draw_DDA(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_DDA = time.ElapsedMilliseconds;
                    break;

                case FormRandomOptions.Hyperbol:
                    time_Bresenham = 0;
                    time_DDA = 0;
                    time_XiaolinWu = 0;

                    x0 = new int[numberObject];
                    y0 = new int[numberObject];
                    int[] realAxis = new int[numberObject];
                    int[] virtualAxis = new int[numberObject];

                    //Random range 0..numberObject-1
                    rd = new Random();
                    for (int i = 0; i < numberObject; i++)
                    {
                        realAxis[i] = rd.Next(0, max_Y / 4);
                        virtualAxis[i] = rd.Next(0, max_Y / 4);
                        x0[i] = rd.Next(max_X / 3, 2 * max_X / 3);
                        y0[i] = rd.Next(max_Y / 3, 2 * max_Y / 3);
                    }

                    //timer midpoint
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Hyperbol(x0[i], y0[i], realAxis[i], virtualAxis[i]);
                        myObject.draw_MidPoint(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_MidPoint = time.ElapsedMilliseconds;

                    //timer dda
                    time.Reset();
                    time.Start();
                    for (int i = 0; i < numberObject; i++)
                    {
                        Init();
                        DrawingObject myObject = new Hyperbol(x0[i], y0[i], realAxis[i], virtualAxis[i]);
                        myObject.draw_DDA(drawOnePixel);
                        numObj.Text = (i + 1).ToString();
                    }
                    time.Stop();
                    time_DDA = time.ElapsedMilliseconds;
                    break;
            }



            if (shapeType != FormRandomOptions.Acc_line)
            {
                //display result
                FormStatistic formStat = new FormStatistic();
                formStat.StartPosition = FormStartPosition.CenterScreen;
                formStat.setTimeForStat(time_DDA, time_Bresenham, time_MidPoint, time_XiaolinWu);
                formStat.ShowDialog();
            }
            else
            {
                double var_DDA = 0, var_Bresenham = 0, var_Midpoint = 0, var_xiaolin = 0;

                x0 = new int[numberObject];
                y0 = new int[numberObject];
                int[] x1 = new int[numberObject];
                int[] y1 = new int[numberObject];
                //Random range 0..numberObject-1
                Random rd = new Random();
                for (int i = 0; i < numberObject; i++)
                {
                    x0[i] = rd.Next(0, max_X);
                    y0[i] = rd.Next(0, max_Y);
                    x1[i] = rd.Next(0, max_X);
                    y1[i] = rd.Next(0, max_Y);
                }
                Line.var = 0;
                var_DDA = 0;
                //accuracy DDA with sum of sub all pixel with real point on the line
                for (int i = 0; i < numberObject; i++)
                {
                    Init();
                    Line myObject = new Line(x0[i], y0[i], x1[i], y1[i]);

                    myObject.draw_DDA(myObject.calculateAcc);

                    var_DDA += Line.var;
                    numObj.Text = (i + 1).ToString();
                }

                Line.var = 0;
                var_Bresenham = 0;
                //accuracy Bresenham with sum of sub all pixel with real point on the line
                for (int i = 0; i < numberObject; i++)
                {
                    Init();
                    Line myObject = new Line(x0[i], y0[i], x1[i], y1[i]);

                    myObject.draw_Bresenham(myObject.calculateAcc);

                    var_Bresenham += Line.var;
                    numObj.Text = (i + 1).ToString();
                }

                Line.var = 0;
                var_Midpoint = 0;
                //accuracy Midpoint with sum of sub all pixel with real point on the line
                for (int i = 0; i < numberObject; i++)
                {
                    Init();
                    Line myObject = new Line(x0[i], y0[i], x1[i], y1[i]);

                    myObject.draw_MidPoint(myObject.calculateAcc);

                    var_Midpoint += Line.var;
                    numObj.Text = (i + 1).ToString();
                }

                Line.var = 0;
                var_xiaolin = 0;
                //accuracy Xiaolin with sum of sub all pixel with real point on the line
                for (int i = 0; i < numberObject; i++)
                {
                    Init();
                    Line myObject = new Line(x0[i], y0[i], x1[i], y1[i]);

                    myObject.draw_XiaolinWu(myObject.calculateAcc_Xiaolin);

                    var_xiaolin += Line.var;
                    numObj.Text = (i + 1).ToString();
                }

                //display result
                FormAccuracy formAcc = new FormAccuracy();
                formAcc.StartPosition = FormStartPosition.CenterScreen;
                formAcc.setVarForAcc(var_DDA, var_Bresenham, var_Midpoint, var_xiaolin);
                formAcc.ShowDialog();
            }





            btn_Clear.Enabled = true;
            btn_draw.Enabled = true;
            btn_inputLine.Enabled = true;
            btn_randomOptions.Enabled = true;
            btn_statistics.Enabled = true;

            btn_inputCircle.Enabled = true;
            btn_inputEllipse.Enabled = true;
            btn_inputParabol.Enabled = true;
            btn_intputHyperbol.Enabled = true;
            listBox1.Enabled = true;

            numObj.Text = "";
        }

        private void btn_randomOptions_Click(object sender, EventArgs e)
        {
            FormRandomOptions randomOptions = new FormRandomOptions();
            randomOptions.StartPosition = FormStartPosition.CenterScreen;
            randomOptions.ShowDialog();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_inputEllipse_Click(object sender, EventArgs e)
        {
            FormEllipse para = new FormEllipse();
            para.StartPosition = FormStartPosition.CenterScreen;
            para.ShowDialog();
        }

        private void btn_inputCircle_Click(object sender, EventArgs e)
        {
            FormCircle para = new FormCircle();
            para.StartPosition = FormStartPosition.CenterScreen;
            para.ShowDialog();
        }

        private void btn_intputHyperbol_Click(object sender, EventArgs e)
        {
            FormHyperbol para = new FormHyperbol();
            para.StartPosition = FormStartPosition.CenterScreen;
            para.ShowDialog();
        }

        private void btn_inputParabol_Click(object sender, EventArgs e)
        {
            FormParabol para = new FormParabol();
            para.StartPosition = FormStartPosition.CenterScreen;
            para.ShowDialog();
        }

        private void buttonHDSD_Click(object sender, EventArgs e)
        {
            HDSD formHD = new HDSD();
            formHD.StartPosition = FormStartPosition.CenterScreen;
            formHD.ShowDialog();
        }
    }
}
