using System;

namespace DevExpress.DevAV.Common.ViewModel {
    public class SelectedItemSynchronizationMessage<TEntity> where TEntity : class {
        public SelectedItemSynchronizationMessage(TEntity entity) {
            Entity = entity;
        }
        public TEntity Entity { get; private set; }
    }
}
