using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Null.FuncDraw.Core
{
    public static class FuncDrawCore
    {
        /// <summary>
        /// 根据数字坐标获取像素位置
        /// </summary>
        /// <param name="xCoord">x坐标</param>
        /// <param name="yCoord">y坐标</param>
        /// <param name="xOffset">原点位置</param>
        /// <param name="yOffset">原点位置</param>
        /// <param name="scale">缩放</param>
        /// <returns>像素位置</returns>
        public static Point GetPointFromCoords(double xCoord, double yCoord, int xOffset, int yOffset, double scale)
        {
            return new Point((int)(xCoord * scale + xOffset), (int)(-yCoord * scale + yOffset));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coords">数字坐标</param>
        /// <param name="offset">原点位置</param>
        /// <param name="scale">缩放</param>
        /// <returns>像素位置</returns>
        public static Point GetPointFromCoords(PointF coords, Point offset, double scale)
        {
            return new Point((int)(coords.X * scale + offset.X), (int)(-coords.Y * scale + offset.Y));
        }
        /// <summary>
        /// 根据像素位置获取数字坐标
        /// </summary>
        /// <param name="x">水平位置</param>
        /// <param name="y">竖直位置</param>
        /// <param name="xOffset">原点位置</param>
        /// <param name="yOffset">原点位置</param>
        /// <param name="scale">缩放</param>
        /// <param name="xCoord">输出: 数字X坐标</param>
        /// <param name="yCoord">输出: 数字Y坐标</param>
        public static void GetCoordsFromPoint(int x, int y, int xOffset, int yOffset, double scale, out double xCoord, out double yCoord)
        {
            xCoord = (x - xOffset) / scale;
            yCoord = -((y - yOffset) / scale);
            return;
        }
        /// <summary>
        /// 根据像素长度返回数字
        /// </summary>
        /// <param name="length">像素长度</param>
        /// <param name="scale">缩放</param>
        /// <returns>数字</returns>
        public static double GetNumberFromPixel(int length, double scale)
        {
            return length / scale;
        }
        /// <summary>
        /// 根据数字来获取它距离原点的像素长度
        /// </summary>
        /// <param name="number">数字</param>
        /// <param name="scale">缩放</param>
        /// <returns>像素长度</returns>
        public static double GetPixelFromNumber(int number, double scale)
        {
            return number * scale;
        }
        /// <summary>
        /// 画函数图像
        /// </summary>
        /// <param name="func">要画的函数</param>
        /// <param name="inputs">X的取值</param>
        /// <param name="graphics">绘图Graphics</param>
        /// <param name="pen">画线所用的Pen</param>
        /// <param name="drawArea">画函数的区域</param>
        /// <param name="xOffset">原点的位置</param>
        /// <param name="yOffset">原点的位置</param>
        /// <param name="scale">缩放参数</param>
        public static void DrawFunc(Func<double, double> func, IEnumerable<double> inputs, Graphics graphics, Pen pen, Rectangle drawArea, int xOffset, int yOffset, double scale)
        {
            double[] nums = inputs.ToArray();
            Point[] coords = new Point[nums.Length];

            int drawAreaLeft = drawArea.X,
                drawAreaRight = drawAreaLeft + drawArea.Width,
                drawAreaTop = drawArea.Y,
                drawAreaBottom = drawAreaTop + drawArea.Height;

            double y;
            for (int i = 0, len = nums.Length; i < len; i++)          // 最近刚知道要少用属性, 毕竟属性的实质是函数, 函数调用需要分配栈空间, 而且似乎还涉及到装箱拆箱, 所以这样效率高一些
            {
                y = 0;
                try
                {
                    y = func.Invoke(nums[i]);
                }
                catch { }
                coords[i] = GetPointFromCoords(nums[i], y, xOffset, yOffset, scale);
            }

            bool point1xIn1 = false,
                point1xIn2 = false,
                point1yIn1 = false,
                point1yIn2 = false,
                point2xIn1 = false,
                point2xIn2 = false,
                point2yIn1 = false,
                point2yIn2 = false;

            Action<Point> point1Check = (point1) =>
            {
                point1xIn1 = point1.X >= drawAreaLeft;
                point1xIn2 = point1.X <= drawAreaRight;
                point1yIn1 = point1.Y >= drawAreaTop;
                point1yIn2 = point1.Y <= drawAreaBottom;
            };
            Action<Point> point2Check = (point2) =>
            {
                point2xIn1 = point2.X >= drawAreaLeft;
                point2xIn2 = point2.X <= drawAreaRight;
                point2yIn1 = point2.Y >= drawAreaTop;
                point2yIn2 = point2.Y <= drawAreaBottom;
            };

            for (int i = 1, len = nums.Length; i < len; i++)
            {
                Point point1 = coords[i - 1];
                Point point2 = coords[i];

                point1Check.Invoke(point1);
                point2Check.Invoke(point2);

                if (((!point1xIn1) && (!point2xIn1)) ||
                    ((!point1xIn2) && (!point2xIn2)) ||
                    ((!point1yIn1) && (!point2yIn1)) ||
                    ((!point1yIn2) && (!point2yIn2)))
                    continue;

                if (!point1xIn1)
                {
                    point1 = new Point(drawAreaLeft, (int)(point1.Y + (point2.Y - point1.Y) * ((double)drawAreaLeft - point1.X) / (point2.X - point1.X)));
                    point1Check.Invoke(point1);
                }
                else if (!point2xIn1)
                {
                    point2 = new Point(drawAreaLeft, (int)(point2.Y + (point1.Y - point2.Y) * ((double)drawAreaLeft - point2.X) / (point1.X - point2.X)));
                    point2Check.Invoke(point2);
                }
                if (!point1xIn2)
                {
                    point1 = new Point(drawAreaRight, (int)(point2.Y + (point1.Y - point2.Y) * ((double)drawAreaRight - point2.X) / (point1.X - point2.X)));
                    point1Check.Invoke(point1);
                }
                else if (!point2xIn2)
                {
                    point2 = new Point(drawAreaRight, (int)(point1.Y + (point2.Y - point1.Y) * ((double)drawAreaRight - point1.X) / (point2.X - point1.X)));
                    point2Check.Invoke(point2);
                }
                if (!point1yIn1)
                {
                    point1 = new Point((int)(point1.X + (point2.X - point1.X) * ((double)drawAreaTop - point1.Y) / (point2.Y - point1.Y)), drawAreaTop);
                    point1Check.Invoke(point1);
                }
                else if (!point2yIn1)
                {
                    point2 = new Point((int)(point2.X + (point1.X - point2.X) * ((double)drawAreaTop - point2.Y) / (point1.Y - point2.Y)), drawAreaTop);
                    point2Check.Invoke(point2);
                }
                if (!point1yIn2)
                {
                    point1 = new Point((int)(point2.X + (point1.X - point2.X) * ((double)drawAreaBottom - point2.Y) / (point1.Y - point2.Y)), drawAreaBottom);
                    point1Check.Invoke(point1);
                }
                else if (!point2yIn2)
                {
                    point2 = new Point((int)(point1.X + (point2.X - point1.X) * ((double)drawAreaBottom - point1.Y) / (point2.Y - point1.Y)), drawAreaBottom);
                    point2Check.Invoke(point2);
                }

                graphics.DrawLine(pen, point1, point2);
            }
        }
        /// <summary>
        /// 画一个坐标轴
        /// </summary>
        /// <param name="xNumbers">x轴要画的数</param>
        /// <param name="yNumbers">y轴要画的数</param>
        /// <param name="graphics">绘图Graphics</param>
        /// <param name="brush">填充坐标轴三角所使用的Brush</param>
        /// <param name="pen">画坐标轴所使用的Pen</param>
        /// <param name="font">画坐标数字所使用的Font</param>
        /// <param name="drawArea">画坐标轴的区域</param>
        /// <param name="xOffset">原点的位置</param>
        /// <param name="yOffset">远点的位置</param>
        /// <param name="barLength">坐标轴上小竖线的长度</param>
        /// <param name="scale">缩放参数</param>
        /// <param name="text">是否绘出数字</param>
        public static void DrawShaft(IEnumerable<double> xNumbers, IEnumerable<double> yNumbers, Graphics graphics, Brush brush, Pen pen, Font font, Rectangle drawArea, int xOffset, int yOffset, int barLength, double scale, bool text)
        {
            Action<Point, double> drawText;

            if (text)
                drawText = (point, num) => graphics.DrawString(num.ToString("F2"), font, brush, point);      // 使用委托, 那么接下来就不需要进行多余的对text的判断, 而直接Invoke就彳亍
            else
                drawText = (point, num) => { };

            Point
                yTop = new Point(xOffset, drawArea.Y),
                yBottom = new Point(xOffset, drawArea.Y + drawArea.Height),       // 确认轴的位置
                xLeft = new Point(drawArea.X, yOffset),
                xRight = new Point(drawArea.X + drawArea.Width, yOffset);

            graphics.DrawLine(pen, yTop, yBottom);            // 画轴
            graphics.DrawLine(pen, xLeft, xRight);

            int triangleHeight = (int)(Math.Tan(Math.PI / 3) * barLength);        // 坐标轴末端小三角的高度
            Point[]
                triangle1 = new Point[] { yTop, new Point(yTop.X - barLength, yTop.Y + triangleHeight), new Point(yTop.X + barLength, yTop.Y + triangleHeight) },
                triangle2 = new Point[] { xRight, new Point(xRight.X - triangleHeight, xRight.Y + barLength), new Point(xRight.X - triangleHeight, xRight.Y - barLength) };
            graphics.FillPolygon(brush, triangle1);           // 画三角
            graphics.FillPolygon(brush, triangle2);

            foreach (double x in xNumbers)
            {
                Point numBase = GetPointFromCoords(x, 0, xOffset, yOffset, scale);
                Point numEnd = new Point(numBase.X, numBase.Y - barLength);
                graphics.DrawLine(pen, numBase, numEnd);      // 画x轴数
                drawText(numBase, x);
            }

            foreach (double y in yNumbers)
            {
                Point numBase = GetPointFromCoords(0, y, xOffset, yOffset, scale);
                Point numEnd = new Point(numBase.X + barLength, numBase.Y);
                graphics.DrawLine(pen, numBase, numEnd);      // 画y轴数
                drawText(numBase, y);
            }
        }
    }
}
