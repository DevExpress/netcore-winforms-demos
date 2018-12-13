using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.DevAV.ViewModels {
    public enum EmployeeMailTemplate {
        [Display(Name = "Employee of The Month")]
        EmployeeOfTheMonth,
        [Display(Name = "Probation Notice")]
        ProbationNotice,
        [Display(Name = "Service Excellence")]
        ServiceExcellence,
        [Display(Name = "Thank you note")]
        ThankYouNote,
        [Display(Name = "Welcome to DevAV")]
        WelcomeToDevAV
    }
    public static class EmployeeMailTemplateExtension {
        public static string ToFileName(this EmployeeMailTemplate mailTemplate) {
            switch(mailTemplate) {
                case EmployeeMailTemplate.ProbationNotice:
                    return ("Employee Probation Notice");
                case EmployeeMailTemplate.ServiceExcellence:
                    return ("Employee Service Excellence");
                case EmployeeMailTemplate.ThankYouNote:
                    return ("Employee Thank You Note");
                case EmployeeMailTemplate.WelcomeToDevAV:
                    return ("Welcome to DevAV");
                default:
                    return ("Employee of the Month");
            }
        }
    }
}