using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace DevExpress.DevAV.Common.ViewModel {
    public class SingleObjectChildViewModel<TEntity> : ISupportParameter where TEntity : class {
        public static SingleObjectChildViewModel<TEntity> Create() {
            return ViewModelSource.Create(() => new SingleObjectChildViewModel<TEntity>());
        }

        protected SingleObjectChildViewModel() { }

        public virtual TEntity Entity { get; set; }
        public virtual bool IsEnabled { get; protected set; }

        protected virtual void OnEntityChanged() {
            IsEnabled = Entity != null;
        }
        #region ISupportParameter
        object ISupportParameter.Parameter {
            get { return Entity; }
            set { Entity = (TEntity)value; }
        }
        #endregion
    }
}