namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Drawing;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    public class ProductMapViewModel : ProductViewModel, ISalesMapViewModel {
        public virtual Period Period { get; set; }
        [Command]
        public void SetLifetimePeriod() {
            Period = Period.Lifetime;
        }
        public bool CanSetLifetimePeriod() {
            return Period != Period.Lifetime;
        }
        [Command]
        public void SetThisYearPeriod() {
            Period = Period.ThisYear;
        }
        public bool CanSetThisYearPeriod() {
            return Period != Period.ThisYear;
        }
        [Command]
        public void SetThisMonthPeriod() {
            Period = Period.ThisMonth;
        }
        public bool CanSetThisMonthPeriod() {
            return Period != Period.ThisMonth;
        }
        protected virtual void OnPeriodChanged() {
            this.RaiseCanExecuteChanged(x => x.SetLifetimePeriod());
            this.RaiseCanExecuteChanged(x => x.SetThisYearPeriod());
            this.RaiseCanExecuteChanged(x => x.SetThisMonthPeriod());
            RaisePeriodChanged();
        }
        public event EventHandler PeriodChanged;
        void RaisePeriodChanged() {
            EventHandler handler = PeriodChanged;
            if(handler != null) 
                handler(this, EventArgs.Empty);
        }
        #region Properties
        public string Name {
            get { return (Entity != null) ? Entity.Name : null; }
        }
        public string Description {
            get { return (Entity != null) ? Entity.Description : null; }
        }
        public Image Image {
            get { return (Entity != null) ? Entity.ProductImage : null; }
        }
        #endregion
    }
}