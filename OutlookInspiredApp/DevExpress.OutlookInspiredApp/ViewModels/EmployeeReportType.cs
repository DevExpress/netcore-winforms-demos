using System.ComponentModel.DataAnnotations;

namespace DevExpress.DevAV.ViewModels {
    public enum EmployeeReportType {
        None,
        [Display(Name = "Profile Report")]
        Profile,
        [Display(Name = "Summary Report")]
        Summary,
        [Display(Name = "Employees Directory Report")]
        Directory,
        [Display(Name = "Task List Report")]
        TaskList
    }
}