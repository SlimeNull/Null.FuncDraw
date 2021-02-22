using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Null.FuncDraw.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public double ScaleChange { get; set; }
        public double XOffsetChange { get; set; }
        public double YOffsetChange { get; set; }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
