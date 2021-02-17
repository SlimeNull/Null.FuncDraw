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

            ViewModel = new TestFormViewModel(this);
            scaleBar.DataBindings.Add(new Binding("Value", ViewModel, "Scale"));
            xOffsetBar.DataBindings.Add(new Binding("Value", ViewModel, "XOffset"));
            yOffsetBar.DataBindings.Add(new Binding("Value", ViewModel, "YOffset"));
            stepBar.DataBindings.Add(new Binding("Value", ViewModel, "StepDiv"));

            xOffsetBar.Minimum = -10000; xOffsetBar.Maximum = paintPanel.Width + 10000;
            yOffsetBar.Maximum = -10000; yOffsetBar.Maximum = paintPanel.Height + 10000;

            xOffsetBar.Value = paintPanel.Width / 2;
            yOffsetBar.Value = paintPanel.Height / 2;

            //xOffsetBar.DataBindings.Add(new Binding("Maximum", paintPanel, "Width"));
            //yOffsetBar.DataBindings.Add(new Binding("Maximum", paintPanel, "Height"));

            scaleTip.DataBindings.Add(new Binding("Text", scaleBar, "Value"));
            xOffsetTip.DataBindings.Add(new Binding("Text", xOffsetBar, "Value"));
            yOffsetTip.DataBindings.Add(new Binding("Text", yOffsetBar, "Value"));

            //var typeTransBinding1 = new Binding("Text", ViewModel, "Step");
            //stepTip.DataBindings.Add(typeTransBinding1);

            g = Graphics.FromHwnd(paintPanel.Handle);
            brush = new SolidBrush(Color.LightPink);
            pen = new Pen(Color.LightPink);
            font = new Font(FontFamily.GenericSansSerif, 12);

            autoRefreshTimer = new Timer() { Interval = 1000 };
            autoRefreshTimer.Tick += (sender, e) =>
            {
                DrawAll();
            };

            paintPanel.MouseWheel += PaintPanel_MouseWheel;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);

            buffer = new GraphicsBuffer(paintPanel.CreateGraphics(), new Rectangle(Point.Empty, paintPanel.Size));

            comboBox1.SelectedIndex = 0;
            funcToCalc = funcs[0];

            autoRefreshBox.Checked = true;
        }

        double MyFunc1(double num)
        {
            return Math.Sin(num);
        }
        double MyFunc2(double num)
        {
            return 1 / (1 + Math.Pow(2, num));
        }

        Func<double, double> funcToCalc = (x) => Math.Tan(x);

        Graphics g;
        Brush brush;
        Pen pen;
        Font font;
        GraphicsBuffer buffer;
        void DrawFunc(Graphics g)
        {
            Core.FuncDraw.GetCoordinatesFromPoint((int)(-0.5 * paintPanel.Width), 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xStart, out _);
            Core.FuncDraw.GetCoordinatesFromPoint((int)(paintPanel.Width * 1.5), 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xEnd, out _);

            Core.FuncDraw.DrawFunc(funcToCalc, Lib.Range(xStart, xEnd, ViewModel.Step), g, pen, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale);
        }
        void DrawShaft(Graphics g)
        {
            Core.FuncDraw.GetCoordinatesFromPoint(0, 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xLeft, out double yTop);
            Core.FuncDraw.GetCoordinatesFromPoint(paintPanel.Width, paintPanel.Height, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xRight, out double yBottom);
            double step = Core.FuncDraw.GetNumberFromPixelLength(50, ViewModel.Scale);

            Core.FuncDraw.DrawShaft(
                Lib.Range(Math.Round(xLeft), xRight, Math.Round(step, 2)), 
                Lib.Range(Math.Round(yTop), yBottom, Math.Round(step, 2)), 
                g, brush, pen, font, 
                new Rectangle(0, 0, paintPanel.Width, paintPanel.Height), 
                ViewModel.XOffset, ViewModel.YOffset, 5, ViewModel.Scale, true);
        }
        void Clear()
        {
            g.Clear(paintPanel.BackColor);
        }
        void DrawAll()
        {
            try
            {
                buffer.Clear(paintPanel.BackColor);
                DrawFunc(buffer.BufferGraphics);
                DrawShaft(buffer.BufferGraphics);
                buffer.DrawBuffer();
            }
            catch
            {
                MessageBox.Show("啊↓哈↑没画呢~", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void drawButton_MouseDown(object sender, MouseEventArgs e)
        {
            DrawFunc(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"[{String.Join(", ", Lib.Range(-10).ToList())}]");
        }

        private void shaftButton_MouseDown(object sender, MouseEventArgs e)
        {
            DrawShaft(g);
        }

        Timer autoRefreshTimer;
        private void autoRefreshBox_CheckedChanged(object sender, EventArgs e)
        {
            autoRefreshTimer.Enabled = autoRefreshBox.Checked;
        }

        bool offsetMoving = false; Point lastPoint;
        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            offsetMoving = true;
            lastPoint = e.Location;
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (offsetMoving)
            {
                Point offset = new Point(e.Location.X - lastPoint.X, e.Location.Y - lastPoint.Y);
                if (offset.X != 0 && offset.Y != 0)
                {
                    lastPoint = e.Location;
                    xOffsetBar.Value = (int)Scope(xOffsetBar.Value + offset.X, xOffsetBar.Minimum, xOffsetBar.Maximum);
                    yOffsetBar.Value = (int)Scope(yOffsetBar.Value + offset.Y, yOffsetBar.Minimum, yOffsetBar.Maximum);
                }

                DrawAll();
            }
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            offsetMoving = false;
        }

        private void paintPanel_MouseLeave(object sender, EventArgs e)
        {
            offsetMoving = false;
        }
        double Scope(double src, double min, double max)
        {
            if (src < min)
                return min;
            if (src > max)
                return max;

            return src;
        }

        private void PaintPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            scaleBar.Value = (int)Scope(scaleBar.Value + e.Delta, scaleBar.Minimum, scaleBar.Maximum);

            if (e.Delta != 0)
                DrawAll();
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paintPanel_Click(object sender, EventArgs e)
        {
            DrawAll();
        }

        private void paintPanel_Resize(object sender, EventArgs e)
        {
            buffer.BufferArea = new Rectangle(0, 0, paintPanel.Width, paintPanel.Height);
            buffer.DestGraphics = paintPanel.CreateGraphics();

            DrawAll();
        }
        Func<double, double>[] funcs = new Func<double, double>[]
        {
            Math.Sin,
            Math.Cos,
            Math.Tan,
            Math.Asin,
            Math.Acos,
            Math.Atan,
            Math.Sinh,
            Math.Cosh,
            Math.Tanh,
            Math.Sqrt,    // 平方根
            Math.Log,
            Math.Log10,
            Math.Abs,
            Math.Exp,
        };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
                funcToCalc = funcs[comboBox1.SelectedIndex];
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
