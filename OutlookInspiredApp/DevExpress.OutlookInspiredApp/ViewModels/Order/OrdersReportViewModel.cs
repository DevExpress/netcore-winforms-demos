namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.DevAV.DevAVDbDataModel;
    using System.Collections.Generic;
    using DevExpress.Mvvm.POCO;

    public class OrdersReportViewModel :
        ReportViewModelBase<SalesReportType, Order, long, IDevAVDbUnitOfWork> {
        IDevAVDbUnitOfWork unitOfWork;

        public static OrdersReportViewModel Create() {
            return ViewModelSource.Create(() => new OrdersReportViewModel());
        }
        protected OrdersReportViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IList<OrderItem> GetOrderItems() {
            return unitOfWork.OrderItems.ToList();
        }
    }
}