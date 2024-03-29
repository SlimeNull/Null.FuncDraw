﻿using Null.FuncDraw.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;

namespace Null.FuncDraw.Model
{
    public class FuncDrawManager
    {
        BufferedGraphics buffer;
        CalcFunctionBase[] functions = Array.Empty<CalcFunctionBase>();

        Point offset;
        double scale = 1;
        private readonly Font defaultFont = new Font(FontFamily.GenericSansSerif, 8);

        public FuncDrawManager()
        {

        }

        public Point OffsetNow { get => offset; }
        public double ScaleNow { get => scale; }
        public Font DefaultFont => defaultFont;

        public Color BackColor { get; set; } = Color.FromArgb(240, 240, 240);
        public Color ForeColor { get; set; } = Color.FromArgb(0, 120, 215);
        public double DrawStep { get; set; } = 1;
        public Graphics TargetGraphics { get; set; }
        public Rectangle TargetArea { get; set; }
        public CalcFunctionBase[] Functions
        {
            get => functions;
            set
            {
                lock (Functions)
                {
                    functions = value;
                }
            }
        }

        public void SetOffsetTo(Point newOffset)
        {
            this.offset = newOffset;
        }

        public void SetOffsetBy(Point offset)
        {
            this.offset.Offset(offset);
        }

        public void SetScaleBy(double times)
        {
            scale *= times;
        }

        public void SetScaleTo(double newScale)
        {
            scale = newScale;
        }

        public void SetScaleAboutBy(double times, Point point)
        {
            double newScale = this.scale * times;

            Point relativeOffset = new Point(point.X - offset.X, point.Y - offset.Y);
            offset = new Point((int)(point.X - relativeOffset.X / scale * newScale), (int)(point.Y - relativeOffset.Y / scale * newScale));

            scale = newScale;
        }

        public void SetScaleAboutTo(double newScale, Point point)
        {
            Point relativeOffset = new Point(point.X - offset.X, point.Y - offset.Y);
            offset = new Point((int)(point.X - relativeOffset.X / scale * newScale), (int)(point.Y - relativeOffset.Y / scale * newScale));

            scale = newScale;
        }

        public void DrawFunction(bool render = false)
        {
            lock (functions)
            {
                Core.FuncDrawCore.GetCoordsFromPoint((int)(-0.0 * TargetArea.Width), 0, offset.X, offset.Y, scale, out double xStart, out _);
                Core.FuncDrawCore.GetCoordsFromPoint((int)(TargetArea.Width * 1.0), 0, offset.X, offset.Y, scale, out double xEnd, out _);

                foreach (CalcFunctionBase func in functions)
                {
                    Pen pen = new Pen(func.ForeCore);
                    Core.FuncDrawCore.DrawFunc(func.Calculate, NumUtil.Range(xStart, xEnd + DrawStep, DrawStep), buffer.Graphics, pen, TargetArea, offset.X, offset.Y, scale);
                    pen.Dispose();
                }

                if (render)
                    buffer.Render();
            }
        }

        public void DrawShaft(bool render = false)
        {
            lock (functions)
            {
                Core.FuncDrawCore.GetCoordsFromPoint(0, 0, offset.X, offset.Y, scale, out double xLeft, out double yTop);
                Core.FuncDrawCore.GetCoordsFromPoint(TargetArea.Width, TargetArea.Height, offset.X, offset.Y, scale, out double xRight, out double yBottom);
                double thisstep = Core.FuncDrawCore.GetNumberFromPixel(50, scale);

                xLeft = ((int)(xLeft / thisstep) - 1) * thisstep;       // 拓展区域, 使得刻度能够覆盖显示区域.
                xRight = ((int)(xRight / thisstep) + 1) * thisstep;     // 
                yTop = ((int)(yTop / thisstep) + 1) * thisstep;         // 
                yBottom = ((int)(yBottom / thisstep) - 1) * thisstep;   // 

                var xRange = NumUtil.Range(xLeft, xRight, thisstep).ToList();     // List 似乎更快. 不过我也不知道依据在哪里.
                var yRange = NumUtil.Range(yTop, yBottom, thisstep).ToList();

                xRange.Remove(0d);

                Color oppositeColor = Color.FromArgb(255 - BackColor.R, 255 - BackColor.G, 255 - BackColor.B);
                Brush oppositeBrush = new SolidBrush(oppositeColor);
                Pen oppositePen = new Pen(oppositeColor);

                Core.FuncDrawCore.DrawShaft(xRange, yRange, buffer.Graphics, oppositeBrush, oppositePen, defaultFont, TargetArea, offset.X, offset.Y, 5, scale, true); ;
                if (render)
                    buffer.Render();
            }
        }

        public void Clear(bool render = false)
        {
            lock (functions)
            {
                buffer.Graphics.Clear(BackColor);

                if (render)
                    buffer.Render();
            }
        }

        public void DrawAll(bool render = true)
        {
            DrawShaft(false);
            DrawFunction(false);

            if (render)
                buffer.Render();
        }

        public void RefreshAll(bool render = true)
        {
            Clear(false);
            DrawShaft(false);
            DrawFunction(false);

            if (render)
                buffer.Render();
        }

        public void UpdateBuffer()
        {
            if (TargetGraphics != null)
            {
                if (buffer != null)
                    lock (buffer)
                        buffer.Dispose();
                buffer = BufferedGraphicsManager.Current.Allocate(TargetGraphics, TargetArea);
            }
        }
    }
}
