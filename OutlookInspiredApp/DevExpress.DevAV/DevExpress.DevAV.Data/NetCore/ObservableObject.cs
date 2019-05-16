using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DevExpress.DevAV {
    public class ObservableObject : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChangedEvent(string propertyName) {
            var handler = PropertyChanged;
            if(handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetPropertyValue<T>(ref T valueHolder, T newValue, [CallerMemberName]string propertyName = null) {
            if(object.Equals(valueHolder, newValue))
                return;
            valueHolder = newValue;
            RaisePropertyChangedEvent(propertyName);
        }
    }
}
