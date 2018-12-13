namespace DevExpress.DevAV.ViewModels {
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.POCO;

    public class EmployeeMailMergeViewModel :
        MailMergeViewModelBase<EmployeeMailTemplate> {

        public static EmployeeMailMergeViewModel Create() {
            return ViewModelSource.Create(() => new EmployeeMailMergeViewModel());
        }
        protected EmployeeMailMergeViewModel() { }
    }
}