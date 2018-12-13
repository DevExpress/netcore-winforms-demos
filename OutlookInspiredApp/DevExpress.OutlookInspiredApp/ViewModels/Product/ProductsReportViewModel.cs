namespace DevExpress.DevAV.ViewModels {
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.POCO;

    public class ProductsReportViewModel :
        ReportViewModelBase<ProductReportType, Product, long, IDevAVDbUnitOfWork> {
        IDevAVDbUnitOfWork unitOfWork;

        public static ProductsReportViewModel Create() {
            return ViewModelSource.Create(() => new ProductsReportViewModel());
        }
        protected ProductsReportViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IList<OrderItem> GetOrderItems(long productId) {
            return GetOrderItems(unitOfWork, productId).ToList();
        }
        static IQueryable<OrderItem> GetOrderItems(IDevAVDbUnitOfWork unitOfWork, long productId) {
            return from oi in unitOfWork.OrderItems
                   where oi.ProductId != null && oi.ProductId == productId
                   select oi;
        }
        public IList<State> GetStates() {
            return unitOfWork.States.ToList();
        }
    }
}