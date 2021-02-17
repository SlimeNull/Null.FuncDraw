using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TestForm.ViewModel
{
    class TestFormViewModel : INotifyPropertyChanged
    {
        private double step = 1;

        TestForm form;
        private int scale = 1;
        private int xOffset;
        private int yOffset;

        public TestFormViewModel(TestForm form)
        {
            this.form = form;
        }

        public int Scale
        {
            get => form.scaleBar.Value;
            set => scale = value;
        }
        public int XOffset
        {
            get => form.xOffsetBar.Value;
            set => xOffset = value;
        }
        public int YOffset
        {
            get => form.yOffsetBar.Value;
            set => yOffset = value;
        }
        public int StepDiv
        {
            set => Step = 1d / value;
            get => (int)(1 / step);
        }
        public double Step
        {
            get => 1d / form.stepBar.Value;
            set
            {
                step = value;
                OnPropertyChanged("Step");
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
