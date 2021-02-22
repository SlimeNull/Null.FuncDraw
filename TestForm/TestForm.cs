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
using Null.FuncDraw;
using Null.Library;
using Null.FuncDraw.Core;

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

            //xOffsetBar.Minimum = -100000; xOffsetBar.Maximum = paintPanel.Width + 100000;
            //yOffsetBar.Maximum = -100000; yOffsetBar.Maximum = paintPanel.Height + 100000;
            xOffsetBar.Minimum = int.MinValue; xOffsetBar.Maximum = int.MaxValue;
            yOffsetBar.Minimum = int.MinValue; yOffsetBar.Maximum = int.MaxValue;

            xOffsetBar.Value = paintPanel.Width / 2;
            yOffsetBar.Value = paintPanel.Height / 2;

            //xOffsetBar.DataBindings.Add(new Binding("Maximum", paintPanel, "Width"));
            //yOffsetBar.DataBindings.Add(new Binding("Maximum", paintPanel, "Height"));

            scaleTip.DataBindings.Add(new Binding("Text", scaleBar, "Value"));
            xOffsetTip.DataBindings.Add(new Binding("Text", xOffsetBar, "Value"));
            yOffsetTip.DataBindings.Add(new Binding("Text", yOffsetBar, "Value"));
            moveTip.DataBindings.Add(new Binding("Text", moveBar, "Value"));
            stepTip.DataBindings.Add(new Binding("Text", stepBar, "Value"));

            //var typeTransBinding1 = new Binding("Text", ViewModel, "Step");

            Color paintColor = Color.FromArgb(0, 120, 215);
            g = Graphics.FromHwnd(paintPanel.Handle);
            brush = new SolidBrush(paintColor);
            pen = new Pen(paintColor);
            font = new Font(FontFamily.GenericSansSerif, 8);

            golobalTimer = new Timer() { Interval = 100 };
            golobalTimer.Tick += (sender, e) =>
            {
                if (autoRefreshBox.Checked)
                {
                    DrawAllForce();
                }

                if (autoStepBox.Checked)
                {
                    double number = FuncDrawCore.GetNumberFromPixel(5, ViewModel.Scale);
                    int param = (int)Clamp(1d / number, stepBar.Minimum, stepBar.Maximum);
                    this.Invoke((Action)(() => stepBar.Value = param));
                }
            };
            golobalTimer.Start();

            paintPanel.MouseWheel += PaintPanel_MouseWheel;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);

            buffer = new GraphicsBuffer(paintPanel.CreateGraphics(), new Rectangle(Point.Empty, paintPanel.Size));

            comboBox1.SelectedIndex = 0;
            funcToCalc = funcs[0];

            this.KeyPreview = true;
            this.KeyDown += (sender, e) => ctrl = e.Control;
            this.KeyUp += (sender, e) => ctrl = e.Control;
        }

        bool ctrl = false;   // 指示是否按下了Ctrl键

        Func<double, double> funcToCalc = (x) => Math.Tan(x);

        Timer golobalTimer;
        Graphics g;
        Brush brush;
        Pen pen;
        Font font;
        GraphicsBuffer buffer;
        void DrawFunc(Graphics g)
        {
            int paintWidth = paintPanel.Width,
                paintHeight = paintPanel.Height,
                xOffset = ViewModel.XOffset,
                yOffset = ViewModel.YOffset,
                scale = ViewModel.Scale;

            double step = ViewModel.Step;

            FuncDrawCore.GetCoordsFromPoint((int)(-0.0 * paintWidth), 0, xOffset, yOffset, scale, out double xStart, out _);
            FuncDrawCore.GetCoordsFromPoint((int)(paintWidth * 1.0), 0, xOffset, yOffset, scale, out double xEnd, out _);

            var range1 = Lib.Range(0, xStart - step, step);
            var range2 = Lib.Range(0, xEnd + step, step);
            var reverse = range1.Reverse();
            var concat = Lib.ConcatEnumerable(reverse, range2);

            FuncDrawCore.DrawFunc(
                funcToCalc,
                concat,
                g, pen,
                new Rectangle(Point.Empty, paintPanel.Size),
                ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale);
        }
        void DrawShaft(Graphics g)
        {
            FuncDrawCore.GetCoordsFromPoint(0, 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xLeft, out double yTop);
            FuncDrawCore.GetCoordsFromPoint(paintPanel.Width, paintPanel.Height, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xRight, out double yBottom);
            double step = FuncDrawCore.GetNumberFromPixel(50, ViewModel.Scale);

            var xRange = Lib.ConcatEnumerable(Lib.Range(0, xLeft, step), Lib.Range(step, xRight, step));
            var yRange = Lib.ConcatEnumerable(Lib.Range(-step, yBottom, step), Lib.Range(step, yTop, step));

            FuncDrawCore.DrawShaft(
                xRange, 
                yRange, 
                g, brush, pen, font,
                new Rectangle(Point.Empty, paintPanel.Size),
                ViewModel.XOffset, ViewModel.YOffset, 5, ViewModel.Scale, true);
        }
        void Clear()
        {
            g.Clear(paintPanel.BackColor);
        }
        void DrawAll()
        {
            DrawAllForce();
        }
        void DrawAllForce()
        {
            try
            {
                buffer.BufferGraphics.Graphics.Clear(paintPanel.BackColor);
                //buffer.Clear(paintPanel.BackColor);
                DrawFunc(buffer.BufferGraphics.Graphics);
                DrawShaft(buffer.BufferGraphics.Graphics);
                //buffer.DrawBuffer();
                buffer.BufferGraphics.Render();
            }
            catch
            {
                if (this.Focused)
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

        private void shaftButton_MouseDown(object sender, MouseEventArgs e)
        {
            DrawShaft(g);
        }


        bool offsetMoving = false; Point lastPoint;
        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            offsetMoving = true;
            lastPoint = e.Location;
        }

        bool moveBarIncrease = true;
        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (offsetMoving)
            {
                Point movePos = paintPanel.PointToClient(MousePosition);
                Point offset = new Point(movePos.X - lastPoint.X, movePos.Y - lastPoint.Y);
                lastPoint = movePos;
                xOffsetBar.Value = (int)Clamp(xOffsetBar.Value + offset.X, xOffsetBar.Minimum, xOffsetBar.Maximum);
                yOffsetBar.Value = (int)Clamp(yOffsetBar.Value + offset.Y, yOffsetBar.Minimum, yOffsetBar.Maximum);

                DrawAll();
                moveBar.Value = (int)Clamp(moveBar.Value + (moveBarIncrease ? 1 : -1), moveBar.Minimum, moveBar.Maximum);

                if (moveBar.Value == moveBar.Maximum)
                    moveBarIncrease = false;
                else if (moveBar.Value == moveBar.Minimum)
                    moveBarIncrease = true;
            }
        }
        void ScaleOffset(int scaleOffset, bool stayPoint = true)
        {
            Point mousePosition = paintPanel.PointToClient(MousePosition);

            int xOffset = ViewModel.XOffset,
                yOffset = ViewModel.YOffset,
                scale = ViewModel.Scale;

            int newScale = (int)Clamp(scale + scaleOffset, scaleBar.Minimum, scaleBar.Maximum);

            if (stayPoint)
            {
                FuncDrawCore.GetCoordsFromPoint(mousePosition.X, mousePosition.Y, xOffset, yOffset, scale, out double xCoord, out double yCoord);
                Point pointOffsetNow = FuncDrawCore.GetPointFromCoords(xCoord, yCoord, xOffset, yOffset, scale);
                Point pointRelativeOffsetNow = FuncDrawCore.GetPointFromCoords(xCoord, yCoord, 0, 0, scale);
                Point offset = new Point((int)(pointOffsetNow.X - pointRelativeOffsetNow.X / (double)scale * newScale), (int)(pointOffsetNow.Y - pointRelativeOffsetNow.Y / (double)scale * newScale));
                xOffsetBar.Value = (int)Clamp(offset.X, xOffsetBar.Minimum, xOffsetBar.Maximum);
                yOffsetBar.Value = (int)Clamp(offset.Y, yOffsetBar.Minimum, yOffsetBar.Maximum);
            }

            scaleBar.Value = newScale;
        }
        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            offsetMoving = false;
        }

        private void paintPanel_MouseLeave(object sender, EventArgs e)
        {
            offsetMoving = false;
            ctrl = false;
        }
        double Clamp(double src, double min, double max)    // Math.Clamp在WinForm中似乎没有?
        {
            if (src < min)
                return min;
            if (src > max)
                return max;

            return src;
        }

        private void PaintPanel_MouseWheel(object sender, MouseEventArgs e)        // 当鼠标在面板内滚动时, 调整缩放
        {
            ScaleOffset(e.Delta, !ctrl);

            if (e.Delta != 0)
                DrawAll();
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawAll();        // 当控件重绘时, 也重绘图像
        }

        private void paintPanel_Click(object sender, EventArgs e)
        {
            DrawAll();        // 当点击面板时, 重绘图像
        }

        private void paintPanel_Resize(object sender, EventArgs e)
        {
            buffer.BufferArea = new Rectangle(0, 0, paintPanel.Width, paintPanel.Height);
            buffer.TargetGraphics.Dispose();
            buffer.TargetGraphics = paintPanel.CreateGraphics();

            DrawAll();        // 当面板尺寸变化时, 重新设置缓冲区的尺寸以及缓冲区的绘图Graphics
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
                funcToCalc = funcs[comboBox1.SelectedIndex];        // 当选择框变化时, 更新需要绘制的函数
        }

        private void paintPanel_MouseDoubleClick(object sender, MouseEventArgs e)    // 当双击时, 自动调整精度
        {
            double number = FuncDrawCore.GetNumberFromPixel(5, ViewModel.Scale);
            int param = (int)Clamp(1d / number, stepBar.Minimum, stepBar.Maximum);
            stepBar.Value = param;
        }

        private void button1_Click(object sender, EventArgs e)      // 当测试按钮按下时, 执行临时要执行的测试代码
        {
            IEnumerable<int> enumerable = Lib.ConcatEnumerable(Lib.Range(10), Lib.Range(-10), Lib.Range(-10, 0));
            MessageBox.Show($"[{String.Join(", ", enumerable.ToList())}]");
        }
    }
}
