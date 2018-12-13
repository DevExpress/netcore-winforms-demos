namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using DevExpress.DevAV.DevAVDbDataModel;

    public class CustomerAnalysisViewModel : DocumentContentViewModelBase {
        IDevAVDbUnitOfWork unitOfWork;

        public static CustomerAnalysisViewModel Create() {
            return ViewModelSource.Create(() => new CustomerAnalysisViewModel());
        }
        protected CustomerAnalysisViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IEnumerable<CustomersAnalysis.Item> GetSalesReport() {
            return CustomersAnalysis.GetSalesReport(unitOfWork);
        }
        public IEnumerable<CustomersAnalysis.Item> GetSalesData() {
            return CustomersAnalysis.GetSalesData(unitOfWork);
        }
        public IEnumerable<string> GetStates(IEnumerable<StateEnum> states) {
            return QueriesHelper.GetStateNames(unitOfWork.States, states);
        }
    }
}