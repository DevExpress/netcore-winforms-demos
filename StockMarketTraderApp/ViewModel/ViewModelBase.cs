using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DevExpress.StockMarketTrader.ViewModel {
    public class LockableCollection<T> : ObservableCollection<T> {
        bool isChanged;
        int updateLockCount;

        public bool IsUpdateLocked { get { return updateLockCount > 0; } }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {
            if (IsUpdateLocked)
                isChanged = true;
            else
                base.OnCollectionChanged(e);
        }
        protected override void SetItem(int index, T item) {
            if (!this[index].Equals(item))
                base.SetItem(index, item);
        }
        public void Assign(IList<T> source) {
            if(Equals(source))
                return;
            BeginUpdate();
            try {
                Clear();
                foreach(T item in source)
                    Add(item);
            } finally {
                EndUpdate();
            }
        }
        public void BeginUpdate() {
            if(!IsUpdateLocked)
                isChanged = false;
            updateLockCount++;
        }
        public void EndUpdate() {
            if(!IsUpdateLocked)
                return;
            updateLockCount--;
            if(!IsUpdateLocked && isChanged)
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
        public void ForEach(Action<T> action) {
            for (int i = 0; i < Count; i++)
                action(this[i]);
        }
        public T Find(Predicate<T> match) {
            if (match == null)
                return default(T);
            int count = Count;
            for (int i = 0; i < count; i++) {
                T item = this[i];
                if (match(item))
                    return item;
            }
            return default(T);
        }
        public override bool Equals(object obj) {
            if(obj is IList<T>) {
                var list = (IList<T>)obj;
                if(Count != list.Count)
                    return false;
                else {
                    for(int i = 0; i < Count; i++)
                        if(!this[i].Equals(list[i]))
                            return false;
                    return true;
                }
            } else
                return base.Equals(obj);
        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }

    public abstract class ViewModelBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
