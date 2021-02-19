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
            moveTip.DataBindings.Add(new Binding("Text", moveBar, "Value"));
            stepTip.DataBindings.Add(new Binding("Text", stepBar, "Value"));

            //var typeTransBinding1 = new Binding("Text", ViewModel, "Step");

            Color paintColor = Color.FromArgb(0, 120, 215);
            g = Graphics.FromHwnd(paintPanel.Handle);
            brush = new SolidBrush(paintColor);
            pen = new Pen(paintColor);
            font = new Font(FontFamily.GenericSansSerif, 8);

            autoRefreshTimer = new Timer() { Interval = 100 };
            autoRefreshTimer.Tick += (sender, e) =>
            {
                DrawAllForce();
                double number = FuncDraw.GetNumberFromPixel(5, ViewModel.Scale);
                int param = (int)Clamp(1d / number, stepBar.Minimum, stepBar.Maximum);
                this.Invoke((Action)(()=> stepBar.Value = param));
                
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

        Func<double, double> funcToCalc = (x) => Math.Tan(x);

        Graphics g;
        Brush brush;
        Pen pen;
        Font font;
        GraphicsBuffer buffer;
        void DrawFunc(Graphics g)
        {
            FuncDraw.GetCoordsFromPoint((int)(-0.25 * paintPanel.Width), 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xStart, out _);
            FuncDraw.GetCoordsFromPoint((int)(paintPanel.Width * 1.25), 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xEnd, out _);

            var range1 = Lib.Range(0, xStart, ViewModel.Step);
            var range2 = Lib.Range(0, xEnd, ViewModel.Step);
            var reverse = range1.Reverse();
            var concat = Lib.ConcatEnumerable(reverse, range2);

            FuncDraw.DrawFunc(funcToCalc, concat, g, pen, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale);

            reverse.GetEnumerator().Dispose();
            concat.GetEnumerator().Dispose();
        }
        void DrawShaft(Graphics g)
        {
            FuncDraw.GetCoordsFromPoint(0, 0, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xLeft, out double yTop);
            FuncDraw.GetCoordsFromPoint(paintPanel.Width, paintPanel.Height, ViewModel.XOffset, ViewModel.YOffset, ViewModel.Scale, out double xRight, out double yBottom);
            double step = FuncDraw.GetNumberFromPixel(50, ViewModel.Scale);

            var xRange = Lib.ConcatEnumerable(Lib.Range(0, xLeft, step), Lib.Range(step, xRight, step));
            var yRange = Lib.ConcatEnumerable(Lib.Range(-step, yBottom, step), Lib.Range(step, yTop, step));

            FuncDraw.DrawShaft(
                xRange, 
                yRange, 
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

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            offsetMoving = false;
        }

        private void paintPanel_MouseLeave(object sender, EventArgs e)
        {
            offsetMoving = false;
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
            scaleBar.Value = (int)Clamp(scaleBar.Value + e.Delta, scaleBar.Minimum, scaleBar.Maximum);

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
            double number = FuncDraw.GetNumberFromPixel(5, ViewModel.Scale);
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
