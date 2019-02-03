using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawings
{
    public delegate void DrawPixelFunc(int x, int y);
    public delegate void DrawPixelFuncWithBrightness(int x, int y, double brightness);
    public abstract class DrawingObject
    {
        protected int x0;
        protected int y0;

        public DrawingObject(int _x0, int _y0)
        {
            x0 = _x0;
            y0 = _y0;
        }
        protected static int width = 700;
        protected static int height = 500;
        public void setWidth(int wid)
        {
            width = wid;
        }

        public void setHeight(int high)
        {
            height = high;
        }

        public abstract void draw_MidPoint(DrawPixelFunc func);
        public abstract void draw_DDA(DrawPixelFunc func);
        public abstract void draw_Bresenham(DrawPixelFunc func);
        public abstract void draw_XiaolinWu(DrawPixelFuncWithBrightness func);
    }

    public class Line : DrawingObject
    {
        private int x1;
        private int y1;

        public Line(int _x0, int _y0, int _x1, int _y1)
            : base(_x0, _y0)
        {
            x1 = _x1;
            y1 = _y1;
        }
        public static int Round(double value)
        {
            return (int)(value + 0.5);
        }
        public override void draw_DDA(DrawPixelFunc setPixel)
        {
            int dx = x1 - x0, dy = y1 - y0, steps, k;

            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else steps = Math.Abs(dy);

            xIncrement = dx / (double)steps;
            yIncrement = dy / (double)steps;

            for (k = 0; k < steps; k++)
            {
                setPixel(Round(x), Round(y));
                x += xIncrement;
                y += yIncrement;
            }
        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public override void draw_Bresenham(DrawPixelFunc setPixel)
        {
            int xA = x0, yA = y0, xB = x1, yB = y1;
            int dx = Math.Abs(xA - xB);
            int dy = Math.Abs(yA - yB);
            int steep = (dy > dx) ? 1 : 0;
            if (steep == 1)
            {
                swap(ref dx, ref dy);
                swap(ref xA, ref yA);
                swap(ref xB, ref yB);
            }
            if (dx == 0 && dy == 0)
            {
                setPixel(xA, yA);
                return;
            }

            int p = 2 * dy - dx;
            int d1 = 2 * dy;
            int d2 = 2 * (dy - dx);

            int xInc = (xA < xB) ? 1 : -1;
            int yInc = (yA < yB) ? 1 : -1;

            while (xA != xB)
            {
                if (steep == 1)
                    setPixel(yA, xA);
                else
                    setPixel(xA, yA);
                if (p < 0)
                {
                    p += d1;
                }
                else
                {
                    p += d2;
                    yA += yInc;
                }
                xA += xInc;
            }
        }
        public override void draw_MidPoint(DrawPixelFunc setPixel)
        {
            int a, b, c, xA = x0, yA = y0, xB = x1, yB = y1, p;

            int steep = (Math.Abs(y1 - y0) > Math.Abs(x1 - x0)) ? 1 : 0;
            if (steep == 1)
            {
                swap(ref xA, ref yA);
                swap(ref xB, ref yB);
            }

            a = yB - yA;
            b = -(xB - xA);
            c = xB * yA - xA * yB;

            int xInc = (xA < xB) ? 1 : -1;
            int yInc = (yA < yB) ? 1 : -1;

            while (xA != xB)
            {
                if (steep == 1)
                    setPixel(yA, xA);
                else
                    setPixel(xA, yA);
                xA += xInc;
                if ((2 * a * xA + 2 * b * yA + 2 * c + 2 * a + b) >= 0)
                    yA += yInc;
            }
        }


        //Xiaolin wu
        int ipart(double x) { return (int)x; }

        int round(double x) { return ipart(x + 0.5); }

        double fpart(double x)
        {
            if (x < 0) return (1 - (x - Math.Floor(x)));
            return (x - Math.Floor(x));
        }

        double rfpart(double x)
        {
            return 1 - fpart(x);
        }

        public override void draw_XiaolinWu(DrawPixelFuncWithBrightness func)
        {
            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            int temp;
            if (steep)
            {
                temp = x0; x0 = y0; y0 = temp;
                temp = x1; x1 = y1; y1 = temp;
            }
            if (x0 > x1)
            {
                temp = x0; x0 = x1; x1 = temp;
                temp = y0; y0 = y1; y1 = temp;
            }

            double dx = x1 - x0;
            double dy = y1 - y0;
            double gradient = dy / dx;

            double xEnd = round(x0);
            double yEnd = y0 + gradient * (xEnd - x0);
            double xGap = rfpart(x0 + 0.5);
            double xPixel1 = xEnd;
            double yPixel1 = ipart(yEnd);

            if (steep)
            {
                func((int)yPixel1, (int)xPixel1, rfpart(yEnd) * xGap);
                func((int)yPixel1 + 1, (int)xPixel1, fpart(yEnd) * xGap);
            }
            else
            {
                func((int)xPixel1, (int)yPixel1, rfpart(yEnd) * xGap);
                func((int)xPixel1, (int)yPixel1 + 1, fpart(yEnd) * xGap);
            }
            double intery = yEnd + gradient;

            xEnd = round(x1);
            yEnd = y1 + gradient * (xEnd - x1);
            xGap = fpart(x1 + 0.5);
            double xPixel2 = xEnd;
            double yPixel2 = ipart(yEnd);
            if (steep)
            {
                func((int)yPixel2, (int)xPixel2, rfpart(yEnd) * xGap);
                func((int)yPixel2 + 1, (int)xPixel2, fpart(yEnd) * xGap);
            }
            else
            {
                func((int)xPixel2, (int)yPixel2, rfpart(yEnd) * xGap);
                func((int)xPixel2, (int)yPixel2 + 1, fpart(yEnd) * xGap);
            }

            if (steep)
            {
                for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                {
                    func((int)ipart(intery), x, rfpart(intery));
                    func((int)ipart(intery) + 1, x, fpart(intery));
                    intery += gradient;
                }
            }
            else
            {
                for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                {
                    func((int)x, ipart(intery), rfpart(intery));
                    func((int)x, ipart(intery) + 1, fpart(intery));
                    intery += gradient;
                }
            }
        }
        public static double var = 0;

        public void calculateAcc(int x, int y)
        {
            //y - y0 = m(x - x0)
            double xReal, yReal;
            int dy = Math.Abs(y1 - y0);
            int dx = Math.Abs(x1 - x0);
            double m = dy / dx;
            if (dy > dx)
            {
                yReal = y;
                xReal = (yReal - y0) / m + x0;
            }
            else
            {
                xReal = x;
                yReal = m * (x - x0) + y0;
            }

            var = var + Math.Abs(xReal - x) + Math.Abs(yReal - y);
        }

        public void calculateAcc_Xiaolin(int x, int y, double c)
        {
            calculateAcc(x, y);
        }
    }

    public class Circle : DrawingObject
    {
        private int radius;

        public Circle(int x, int y, int radius)
            : base(x, y)
        {
            this.radius = radius;
        }

        public override void draw_DDA(DrawPixelFunc setPixel)
        {
            int x, y;
            double xEnd = radius / Math.Sqrt(2);
            for (x = 0; x < xEnd; x++)
            {
                y = radius * radius - x * x;
                y = (int)(Math.Sqrt(y) + 0.5);

                set8pixel(setPixel, x, y);
            }
        }

        public override void draw_Bresenham(DrawPixelFunc func)
        {
            throw new NotImplementedException();
        }

        public void set8pixel(DrawPixelFunc setPixel, int x, int y)
        {
            setPixel(x0 + x, y0 + y);
            setPixel(x0 - x, y0 + y);
            setPixel(x0 + x, y0 - y);
            setPixel(x0 - x, y0 - y);
            setPixel(x0 + y, y0 + x);
            setPixel(x0 - y, y0 + x);
            setPixel(x0 + y, y0 - x);
            setPixel(x0 - y, y0 - x);
        }

        public override void draw_MidPoint(DrawPixelFunc setPixel)
        {

            int x, y;
            x = 0;
            y = radius;

            set8pixel(setPixel, x, y);
            double p = 1 - radius;
            while (x < y)
            {
                if (p < 0)
                    p += 2 * x + 3;
                else
                {
                    p += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                set8pixel(setPixel, x, y);
            }
        }

        public override void draw_XiaolinWu(DrawPixelFuncWithBrightness func)
        {
            throw new NotImplementedException();
        }
    }


    public class Ellipse : DrawingObject
    {
        private int halfBigAxis;
        private int halfSmallAxis;

        public Ellipse(int x, int y, int halfBigAxis, int halfSmallAxis)
            : base(x, y)
        {
            this.halfBigAxis = halfBigAxis;
            this.halfSmallAxis = halfSmallAxis;
        }

        public override void draw_DDA(DrawPixelFunc setPixel)
        {
            int a = halfBigAxis;
            int b = halfSmallAxis;
            int x, y;
            double tmp;
            //0 = b2x2 + a2y2 -a2b2

            double xEnd = a * a / Math.Sqrt(a * a + b * b);
            double yEnd = b * b / Math.Sqrt(a * a + b * b);

            for (x = 0; x <= xEnd; x++)
            {
                tmp = (a * a * b * b - b * b * x * x) / (a * a);
                y = Round(Math.Sqrt(tmp));
                set4pixel(setPixel, x, y);
            }

            for (y = 0; y <= yEnd; y++)
            {
                tmp = (a * a * b * b - a * a * y * y) / (b * b);
                x = Round(Math.Sqrt(tmp));
                set4pixel(setPixel, x, y);
            }

        }

        public override void draw_Bresenham(DrawPixelFunc func)
        {
            throw new NotImplementedException();
        }

        public int Round(double a)
        {
            return (int)(a + 0.5);
        }

        public void set4pixel(DrawPixelFunc setPixel, int x, int y)
        {
            setPixel(x0 + x, y0 + y);
            setPixel(x0 - x, y0 + y);
            setPixel(x0 + x, y0 - y);
            setPixel(x0 - x, y0 - y);
        }

        public override void draw_MidPoint(DrawPixelFunc setPixel)
        {
            int a = halfBigAxis;
            int b = halfSmallAxis;

            int x, y, fx, fy, a2, b2, p;
            x = 0;
            y = b;
            a2 = a * a;
            b2 = b * b;
            fx = 0;
            fy = 2 * a2 * y;

            set4pixel(setPixel, x, y);

            p = Round(b2 - (a2 * b) + (0.25 * a2));//p=b2 - a2*b +a2/4
            while (fx < fy)
            {
                x++;
                fx += 2 * b2;

                if (p < 0)
                {
                    p += b2 * (2 * x + 3);//p=p + b2*(2x +3)
                }
                else
                {
                    y--;
                    p += b2 * (2 * x + 3) + a2 * (2 - 2 * y);//p=p +b2(2x +3) +a2(2-2y)
                    fy -= 2 * a2;
                }
                set4pixel(setPixel, x, y);
            }
            p = Round(b2 * (x + 0.5) * (x + 0.5) + a2 * (y - 1) * (y - 1) - a2 * b2);
            //
            while (y > 0)
            {
                y--;
                fy -= 2 * a2;

                if (p >= 0)
                {
                    p += a2 * (3 - 2 * y); //p=p +a2(3-2y)
                }
                else
                {
                    x++;
                    fx += 2 * b2;
                    p += b2 * (2 * x + 2) + a2 * (3 - 2 * y);//p=p+ b2(2x +2) + a2(3-2y)
                }
                set4pixel(setPixel, x, y);
            }
        }



        public override void draw_XiaolinWu(DrawPixelFuncWithBrightness func)
        {
            throw new NotImplementedException();
        }
    }

    public class Parabol : DrawingObject
    {
        private double hs_a;

        public Parabol(int x, int y, double a)
            : base(x, y)
        {
            this.hs_a = a;
        }

        public override void draw_DDA(DrawPixelFunc setPixel)
        {
            double a = hs_a;
            if (hs_a < 0)
            {
                a = -a;
            }
            int x, y;
            double xEnd = 1 / (2 * a);
            double yStart = 1 / (4 * a);
            for (x = 0; x < xEnd; x++)
            {
                y = (int)(a * x * x + 0.5);

                if (hs_a < 0)
                    set2PixelWithANegative(setPixel, x, y);
                else
                    set2Pixel(setPixel, x, y);
            }

            for (y = (int)yStart; y <= height; y++)
            {
                x = (int)(Math.Sqrt(y / a) + 0.5);
                if (hs_a < 0)
                    set2PixelWithANegative(setPixel, x, y);
                else
                    set2Pixel(setPixel, x, y);
            }
        }

        public override void draw_Bresenham(DrawPixelFunc func)
        {
            throw new NotImplementedException();
        }

        public void set2Pixel(DrawPixelFunc setPixel, int x, int y)
        {
            setPixel(x0 + x, y0 + y);
            setPixel(x0 - x, y0 + y);
        }

        public int round(double a)
        {
            return (int)(a + 0.5);
        }

        public void set2PixelWithANegative(DrawPixelFunc setPixel, int x, int y)
        {
            setPixel(x0 + x, y0 - y);
            setPixel(x0 - x, y0 - y);
        }

        public override void draw_MidPoint(DrawPixelFunc setPixel)
        {
            double a = hs_a;
            int isNegative = 0;
            if (a == 0) return;
            if (a < 0)
            {
                isNegative = 1;
                a = -a;
            }
            int x = 0, y = 0;
            double f = 2 * a - 1;

            set2Pixel(setPixel, x, y);

            while (2 * a * x < 1)
            {
                if (f < 0)
                    f = f + a * (2 * x + 3);
                else
                {
                    f = f + a * (2 * x + 3) - 1;
                    y++;
                }
                x++;
                if (isNegative == 0)
                    set2Pixel(setPixel, x, y);
                else
                    set2PixelWithANegative(setPixel, x, y);
            }
            x = round(0.5 / a);
            y = round(0.25 / a);

            f = a - 2;
            set2Pixel(setPixel, x, y);
            while (y <= height)
            {
                if (f < 0)
                {
                    f = f + 2 * a * (x + 1) - 1;
                    x++;
                }
                else f--;
                y++;
                if (isNegative == 0)
                    set2Pixel(setPixel, x, y);
                else
                    set2PixelWithANegative(setPixel, x, y);
            }
        }

        public override void draw_XiaolinWu(DrawPixelFuncWithBrightness func)
        {
            throw new NotImplementedException();
        }
    }

    public class Hyperbol : DrawingObject
    {
        private int realAxis;
        private int virtualAxis;

        public Hyperbol(int x, int y, int realAxis, int virtualAxis)
            : base(x, y)
        {
            this.realAxis = realAxis;
            this.virtualAxis = virtualAxis;
        }

        public override void draw_DDA(DrawPixelFunc setPixel)
        {
            int a = realAxis;
            int b = virtualAxis;
            int x, y;
            double xStart = (a > b) ? a * a / Math.Sqrt(a * a - b * b) : a * a / Math.Sqrt(b * b - a * a);
            double yEnd = (a > b) ? b * b / Math.Sqrt(a * a - b * b) : b * b / Math.Sqrt(b * b - a * a);
            double tmp;

            for (y = 0; y <= yEnd; y++)
            {
                tmp = (a * a * y * y + a * a * b * b) / (b * b);
                x = (int)(Math.Sqrt(tmp) + 0.5);
                set4pixel(setPixel, x, y);
            }

            for (x = (int)xStart; x <= width; x++)
            {
                tmp = (b * b * x * x - a * a * b * b) / (a * a);
                y = (int)(Math.Sqrt(tmp) + 0.5);
                set4pixel(setPixel, x, y);
            }

        }

        public override void draw_Bresenham(DrawPixelFunc func)
        {
            throw new NotImplementedException();
        }

        public void set4pixel(DrawPixelFunc setPixel, int x, int y)
        {
            setPixel(x0 + x, y0 + y);
            setPixel(x0 - x, y0 + y);
            setPixel(x0 + x, y0 - y);
            setPixel(x0 - x, y0 - y);
        }
        public override void draw_MidPoint(DrawPixelFunc setPixel)
        {
            int a = realAxis;
            int b = virtualAxis;
            int p = 0;
            int x = a;
            int y = 0;
            int a2 = a * a;
            int b2 = b * b;

            p = (int)(1.0 * b2 / 4 + a * b2 - a2);

            int end = (int)((a <= b ? height : b * b / Math.Sqrt(a2 - b2)));

            while (y < end)
            {
                set4pixel(setPixel, x, y);

                if (p < 0)
                {
                    p += (2 * x + 2) * b2 - (2 * y + 3) * a2;
                    x++;
                }
                else
                {
                    p -= a2 * (2 * y + 3);
                }
                y++;
            }

            p = b2 - a2 / 4;
            while (x < width)
            {
                set4pixel(setPixel, x, y);

                if (p < 0)
                {
                    p += (x + 1) * 2 * b2;
                }
                else
                {
                    p += (x + 1) * 2 * b2 - (2 * y + 2) * a2;
                    y++;
                }
                x++;
            }

        }

        public override void draw_XiaolinWu(DrawPixelFuncWithBrightness func)
        {
            throw new NotImplementedException();
        }
    }
}