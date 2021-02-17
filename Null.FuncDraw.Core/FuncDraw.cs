using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace TestForm.Core
{
    public static class FuncDraw
    {
        public static Point GetPointFromCoordinates(double xCoord, double yCoord, int xOffset, int yOffset, double scale)
        {
            return new Point((int)(xCoord * scale + xOffset), (int)(-yCoord * scale + yOffset));
        }
        public static Point GetPointFromCoordinates(PointF coords, Point offset, double scale)
        {
            return new Point((int)(coords.X * scale + offset.X), (int)(-coords.Y * scale + offset.Y));
        }
        public static void GetCoordinatesFromPoint(int x, int y, int xOffset, int yOffset, double scale, out double xCoord, out double yCoord)
        {
            xCoord = (x - xOffset) / scale;
            yCoord = -((y - yOffset) / scale);
            return;
        }
        public static double GetNumberFromPixelLength(int length, double scale)
        {
            return length / scale;
        }
        public static void DrawFunc(Func<double, double> func, IEnumerable<double> inputs, Graphics graphics, Pen pen, int xOffset, int yOffset, double scale)
        {
            double[] nums = inputs.ToArray();
            Point[] coords = new Point[nums.Length];

            double y;
            for (int i = 0; i < nums.Length; i++)
            {
                y = func.Invoke(nums[i]);
                coords[i] = GetPointFromCoordinates(nums[i], y, xOffset, yOffset, scale);
            }

            for (int i = 1; i < nums.Length; i++)
                graphics.DrawLine(pen, coords[i - 1], coords[i]);
        }
        public static void DrawShaft(IEnumerable<double> xNumbers, IEnumerable<double> yNumbers, Graphics graphics, Brush brush, Pen pen, Font font, Rectangle drawArea, int xOffset, int yOffset, int barLength, double scale, bool text)
        {
            Action<Point, double> drawText;

            if (text)
                drawText = (point, num) => graphics.DrawString(num.ToString("F2"), font, brush, point);
            else
                drawText = (point, num) => { };

            Point 
                yTop = new Point(xOffset, drawArea.Y),
                yBottom = new Point(xOffset, drawArea.Y + drawArea.Height),
                xLeft = new Point(drawArea.X, yOffset),
                xRight = new Point(drawArea.X + drawArea.Width, yOffset);

            graphics.DrawLine(pen, yTop, yBottom);            // 画轴
            graphics.DrawLine(pen, xLeft, xRight);

            int triangleHeight = (int)(Math.Tan(Math.PI / 3) * barLength);
            Point[]
                triangle1 = new Point[] { yTop, new Point(yTop.X - barLength, yTop.Y + triangleHeight), new Point(yTop.X + barLength, yTop.Y + triangleHeight) },
                triangle2 = new Point[] { xRight, new Point(xRight.X - triangleHeight, xRight.Y + barLength), new Point(xRight.X - triangleHeight, xRight.Y - barLength) };
            graphics.FillPolygon(brush, triangle1);           // 画三角
            graphics.FillPolygon(brush, triangle2);

            foreach (double x in xNumbers)
            {
                Point numBase = GetPointFromCoordinates(x, 0, xOffset, yOffset, scale);
                Point numEnd = new Point(numBase.X, numBase.Y - barLength);
                graphics.DrawLine(pen, numBase, numEnd);      // 画x轴数
                drawText(numBase, x);
            }

            foreach (double y in yNumbers)
            {
                Point numBase = GetPointFromCoordinates(0, y, xOffset, yOffset, scale);
                Point numEnd = new Point(numBase.X + barLength, numBase.Y);
                graphics.DrawLine(pen, numBase, numEnd);      // 画y轴数
                drawText(numBase, y);
            }
        }
    }

    public interface IOffset
    {
        Point GetOffsetFromPixel();
    }
    public struct Offset : IOffset
    {
        Point basePoint;
        public Offset(Point offset)
        {
            basePoint = offset;
        }
        public Offset(int xOffset, int yOffset)
        {
            basePoint = new Point(xOffset, yOffset);
        }
        public Offset(PointF numberOffset, double scale)
        {
            basePoint = new Point((int)(numberOffset.X * scale), (int)(numberOffset.Y * scale));
        }
        public Offset(double xNumberOffset, double yNumberOffset, double scale)
        {
            basePoint = new Point((int)(xNumberOffset * scale), (int)(yNumberOffset * scale));
        }
        public static Offset Empty { get => new Offset(Point.Empty); }
        public Point GetOffsetFromPixel()
        {
            return basePoint;
        }
    }
}
