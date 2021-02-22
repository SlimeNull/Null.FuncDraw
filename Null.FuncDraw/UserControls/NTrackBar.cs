using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Null.FuncDraw.UserControls
{
    public partial class NTrackBar : UserControl
    {
        public NTrackBar()
        {
            InitializeComponent();

            mainTrackBar.MouseDown += (sender, e) => OnScrollStart();
            mainTrackBar.MouseUp += (sender, e) => OnScrollEnd();
            mainTrackBar.MouseCaptureChanged += (sender, e) => OnScrollEnd();

            mainTrackBar.ValueChanged += (sender, e) => OnValueChanged(e);

            valueLabel.DataBindings.Add(new Binding("Text", mainTrackBar, "Value"));
            valueLabel.TextAlign = ContentAlignment.MiddleRight;
        }
        public int Minimum { get => mainTrackBar.Minimum; set => mainTrackBar.Minimum = value; }
        public int Maximum { get => mainTrackBar.Maximum; set => mainTrackBar.Maximum = value; }
        public double Value
        {
            get
            {
                return mainTrackBar.Value;
            }

            set => mainTrackBar.Value = (int)value;
        }
        public double FilterValue
        {
            get
            {
                double result = mainTrackBar.Value;
                OnFilter(ref result);

                return result;
            }
        }
        public string Title { get => textLabel.Text; set => textLabel.Text = value; }

        private void OnFilter(ref double value)
        {
            object valueObj = value;
            if (Filter != null)
                Filter.Invoke(this, new ConvertEventArgs(valueObj, typeof(double)));

            value = (double)valueObj;
        }
        private void OnScrollStart()
        {
            if (ScrollStart != null) ScrollStart.Invoke(this, new EventArgs());
        }
        private void OnScrollEnd()
        {
            if (ScrollEnd != null) ScrollEnd.Invoke(this, new EventArgs());
        }
        private void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null) ValueChanged.Invoke(this, e);
        }
        public event EventHandler<ConvertEventArgs> Filter;
        public event EventHandler<EventArgs> ScrollStart;
        public event EventHandler<EventArgs> ScrollEnd;
        public event EventHandler<EventArgs> ValueChanged;
    }
}
