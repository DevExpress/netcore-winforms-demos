using System.ComponentModel.DataAnnotations;

namespace DevExpress.DevAV.ViewModels {
    public enum SalesReportType {
        None,
        [Display(Name = "Sales Report")]
        SalesReport,
        [Display(Name = "Sales by store")]
        SalesByStore,
        [Display(Name = "Follow Up")]
        OrderFollowUp,
        [Display(Name = "Invoice")]
        Invoice,
    }
    public static class SalesReportTypeExtension {
        public static string ToFileName(this SalesReportType reportTemplate) {
            switch(reportTemplate) {
                case SalesReportType.SalesReport:
                    return ("Sales Order Summary Report");
                case SalesReportType.SalesByStore:
                    return ("Sales Analysys Report");
                case SalesReportType.OrderFollowUp:
                    return ("SalesOrderFollowUp");
                default:
                    return ("Sales Invoice");
            }
        }
    }
}