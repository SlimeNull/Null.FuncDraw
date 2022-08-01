using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Null.FuncDraw.Model;
using Null.FuncDraw.UserControls;
using Null.FuncDraw.ViewModel;

namespace Null.FuncDraw.View
{
    public partial class MainWindow : Form
    {
        private System.Windows.Forms.Timer autoRefreshTimer;
        private FunctionManager functionManagerForm;
        private FuncDrawManager funcDrawManager;

        private bool ctrl = false;
        private bool signal_plus = true;

        public MainWindowViewModel ViewModel { get; set; }
        public FunctionManager FunctionManagerForm { get => functionManagerForm; }
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainWindowViewModel();

            scaleBar.DataBindings.Add("Value", ViewModel, "ScaleChange");
            xOffsetBar.DataBindings.Add("Value", ViewModel, "XOffsetChange");
            yOffsetBar.DataBindings.Add("Value", ViewModel, "YOffsetChange");


            functionManagerForm = new FunctionManager(this);
            funcDrawManager = new FuncDrawManager()
            {
                TargetArea = new Rectangle(Point.Empty, paintPanel.Size),
                TargetGraphics = paintPanel.CreateGraphics(),
                BackColor = paintPanel.BackColor
            };
            funcDrawManager.UpdateBuffer();

            autoRefreshTimer = new System.Windows.Forms.Timer() { Interval = 30 };
            autoRefreshTimer.Tick += (sender, e) =>
            {
                funcDrawManager.RefreshAll();
                funcDrawManager.SetOffsetBy(new Point((int)xOffsetBar.Value, (int)yOffsetBar.Value));
                funcDrawManager.SetScaleBy(Math.Pow(10, scaleBar.Value / 100));
                funcDrawManager.DrawStep = Core.FuncDrawCore.GetNumberFromPixel((int)(30 / drawStep.Value), funcDrawManager.ScaleNow);
            };
            autoRefreshTimer.Enabled = true;

            this.KeyPreview = true;
            this.KeyDown += (sender, e) => ctrl = e.Control;
            this.KeyUp += (sender, e) => ctrl = e.Control;


            scaleBar.ScrollEnd += NTrackBar_ValueRestore;
            xOffsetBar.ScrollEnd += NTrackBar_ValueRestore;
            yOffsetBar.ScrollEnd += NTrackBar_ValueRestore;
        }

        private void NTrackBar_ValueRestore(object sender, EventArgs e)
        {
            NTrackBar trackBar = (sender as NTrackBar)!;
            if (trackBar != null)
                trackBar.Value = 0;
        }

        public CalcFunctionBase[] Functions { get => funcDrawManager.Functions; set => funcDrawManager.Functions = value; }

        private void Manager_Click(object sender, EventArgs e)
        {
            FunctionManagerForm.ShowDialog();
            Functions = FunctionManagerForm.Functions;
        }

        private void funcButton_Click(object sender, EventArgs e)
        {
            funcDrawManager.DrawFunction(true);
        }

        private void shaftButton_Click(object sender, EventArgs e)
        {
            funcDrawManager.DrawShaft(true);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            funcDrawManager.Clear(true);
        }

        bool mouseOffseting = false;
        Point lastMousePosition;
        private void paintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffseting = true;
            lastMousePosition = MousePosition;
        }

        private void paintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseOffseting = false;
        }

        private void paintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseOffseting)
            {
                Point mousePositionNow = MousePosition;
                Point offset = new Point(mousePositionNow.X - lastMousePosition.X, mousePositionNow.Y - lastMousePosition.Y);
                lastMousePosition = mousePositionNow;

                funcDrawManager.SetOffsetBy(offset);
                funcDrawManager.RefreshAll();

                if (signal_plus)
                {
                    if (moveSignal.Value < moveSignal.Maximum)
                        moveSignal.Value++;
                    else
                        signal_plus = false;
                }
                else
                {
                    if (moveSignal.Value > moveSignal.Minimum)
                        moveSignal.Value--;
                    else
                        signal_plus = true;
                }
            }
        }

        private void paintPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            Point mousePoint = paintPanel.PointToClient(MousePosition);
            int delta = e.Delta;

            if (ctrl)
                funcDrawManager.SetScaleBy(Math.Pow(10, delta / 1000d));
            else
                funcDrawManager.SetScaleAboutBy(Math.Pow(10, delta / 1000d), mousePoint);
            funcDrawManager.RefreshAll();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            funcDrawManager.SetOffsetTo(new Point(paintPanel.Width / 2, paintPanel.Height / 2));
            funcDrawManager.SetScaleTo(30);
        }

        private void paintPanel_Resize(object sender, EventArgs e)
        {
            if (funcDrawManager == null)
                return;
            Graphics graphicsNow = funcDrawManager.TargetGraphics;
            if (graphicsNow != null)
                graphicsNow.Dispose();

            funcDrawManager.TargetArea = new Rectangle(Point.Empty, paintPanel.Size);
            funcDrawManager.TargetGraphics = paintPanel.CreateGraphics();
            funcDrawManager.UpdateBuffer();
        }
    }
}
