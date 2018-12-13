namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.DevAV.Properties;
    using DevExpress.Mvvm.POCO;

    public class EmployeesFilterTreeViewModel : FilterTreeViewModel<Employee, long, IDevAVDbUnitOfWork> {
        public static EmployeesFilterTreeViewModel Create(EmployeeCollectionViewModel collectionViewModel) {
            return ViewModelSource.Create(() => new EmployeesFilterTreeViewModel(collectionViewModel));
        }
        protected EmployeesFilterTreeViewModel(EmployeeCollectionViewModel collectionViewModel)
            : base(collectionViewModel, new FilterTreeModelPageSpecificSettings<Settings>(Settings.Default, StaticFiltersName, x => x.EmployeesStaticFilters, x => x.EmployeesCustomFilters, x => x.EmployeesGroupFilters)) {
        }
        protected new EmployeeCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as EmployeeCollectionViewModel; }
        }
    }
}