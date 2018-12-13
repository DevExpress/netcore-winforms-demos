namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public class ProductAnalysisViewModel : DocumentContentViewModelBase {
        IDevAVDbUnitOfWork unitOfWork;

        public static ProductAnalysisViewModel Create() {
            return ViewModelSource.Create(() => new ProductAnalysisViewModel());
        }
        protected ProductAnalysisViewModel() {           
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IEnumerable<ProductsAnalysis.Item> GetFinancialReport() {
            return ProductsAnalysis.GetFinancialReport(unitOfWork);
        }
        public IEnumerable<ProductsAnalysis.Item> GetFinancialData() {
            return ProductsAnalysis.GetFinancialData(unitOfWork);
        }
    }
}