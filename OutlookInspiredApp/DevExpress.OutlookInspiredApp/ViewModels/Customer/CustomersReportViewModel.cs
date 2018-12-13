namespace DevExpress.DevAV.ViewModels {
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.POCO;

    public class CustomersReportViewModel :
        ReportViewModelBase<CustomerReportType, Customer, long, IDevAVDbUnitOfWork> {
        IDevAVDbUnitOfWork unitOfWork;

        public static CustomersReportViewModel Create() {
            return ViewModelSource.Create(() => new CustomersReportViewModel());
        }
        protected CustomersReportViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IList<CustomerEmployee> CustomerEmployees {
            get { return unitOfWork.CustomerEmployees.ToList(); }
        }
        public IList<CustomerStore> CustomerStores {
            get { return unitOfWork.CustomerStores.ToList(); }
        }
    }
}