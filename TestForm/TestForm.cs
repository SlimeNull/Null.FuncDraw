using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestForm.Library;
using TestForm.ViewModel;

namespace TestForm
{
    public partial class TestForm : Form
    {
        TestFormViewModel ViewModel;
        public TestForm()
        {
            InitializeComponent();

            ViewModel = new TestFormViewModel();
            scaleBar.DataBindings.Add(new Binding("Value", ViewModel, "Scale"));
            xOffsetBar.DataBindings.Add(new Binding("Value", ViewModel, "XOffset"));
            yOffsetBar.DataBindings.Add(new Binding("Value", ViewModel, "YOffset"));

            xOffsetBar.DataBindings.Add(new Binding("Maximum", paintPanel, "Width"));
            yOffsetBar.DataBindings.Add(new Binding("Maximum", paintPanel, "Height"));

            scaleTip.DataBindings.Add(new Binding("Text", scaleBar, "Value"));
            xOffsetTip.DataBindings.Add(new Binding("Text", xOffsetBar, "Value"));
            yOffsetTip.DataBindings.Add(new Binding("Text", yOffsetBar, "Value"));

            g = Graphics.FromHwnd(paintPanel.Handle);
            brush = new SolidBrush(Color.LightPink);
            pen = new Pen(Color.LightPink);
            font = new Font(FontFamily.GenericSansSerif, 12);
        }

        double MyFunc(double num)
        {
            return Math.Sin(num);
        }

        Graphics g;
        Brush brush;
        Pen pen;
        Font font;
        void DrawFunc()
        {
            IEnumerable<double> qwq = Enumerable.Range(-100, 201).Select((v) => (double)v);
            Core.FuncDraw.DrawFunc(Math.Sin, qwq, g, pen, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale);
        }
        void DrawShaft()
        {
            Core.FuncDraw.GetCoordinatesFromPoint(0, 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xLeft, out double yTop);
            Core.FuncDraw.GetCoordinatesFromPoint(paintPanel.Width, paintPanel.Height, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xRight, out double yBottom);
            int step = Core.FuncDraw.GetNumberFromPixelLength(50, ViewModel.Scale);

            Core.FuncDraw.DrawShaft(
                Lib.Range((int)xLeft, xRight, (int)step), 
                Lib.Range((int)yTop, yBottom, (int)step), 
                g, brush, pen, font, 
                new Rectangle(0, 0, paintPanel.Width, paintPanel.Height), 
                ViewModel.XOffset, ViewModel.YOffset, 5, ViewModel.Scale, true);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(paintPanel.BackColor);
        }

        private void drawButton_MouseDown(object sender, MouseEventArgs e)
        {
            DrawFunc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"[{String.Join(", ", Lib.Range(-10).ToList())}]");
        }

        private void shaftButton_MouseDown(object sender, MouseEventArgs e)
        {
            DrawShaft();
        }
    }
}
