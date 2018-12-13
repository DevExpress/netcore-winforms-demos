namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.POCO;

    public class EmployeesReportViewModel :
        ReportViewModelBase<EmployeeReportType, Employee, long, IDevAVDbUnitOfWork> {
        IDevAVDbUnitOfWork unitOfWork;

        public static EmployeesReportViewModel Create() {
            return ViewModelSource.Create(() => new EmployeesReportViewModel());
        }
        protected EmployeesReportViewModel() {
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork();
        }
        public IList<EmployeeTask> Tasks {
            get { return unitOfWork.Tasks.ToList(); }
        }
    }
}