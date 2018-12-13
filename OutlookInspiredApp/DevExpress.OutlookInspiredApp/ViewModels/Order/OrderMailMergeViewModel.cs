namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    public class OrderMailMergeViewModel :
        MailMergeViewModelBase<SalesReportType> {
        IDevAVDbUnitOfWork unitOfWork;

        public static OrderMailMergeViewModel Create() {
            return ViewModelSource.Create(() => new OrderMailMergeViewModel());
        }
        protected OrderMailMergeViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public virtual OrderMailMergePeriod? Period { get; set; }
        [Command]
        public void SetThisMonthPeriod() {
            Period = OrderMailMergePeriod.ThisMonth;
        }
        public bool CanSetThisMonthPeriod() {
            return Period != OrderMailMergePeriod.ThisMonth;
        }
        [Command]
        public void SetLastMonthPeriod() {
            Period = OrderMailMergePeriod.LastMonth;
        }
        public bool CanSetLastMonthPeriod() {
            return Period != OrderMailMergePeriod.LastMonth;
        }
        protected virtual void OnPeriodChanged() {
            this.RaiseCanExecuteChanged(x => x.SetThisMonthPeriod());
            this.RaiseCanExecuteChanged(x => x.SetLastMonthPeriod());
            RaisePeriodChanged();
        }
        public IList<OrderItem> GetOrderItems() {
            return unitOfWork.OrderItems.ToList();
        }
        public event EventHandler PeriodChanged;
        void RaisePeriodChanged() {
            EventHandler handler = PeriodChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
    }
    public enum OrderMailMergePeriod {
        ThisMonth,
        LastMonth
    }
}