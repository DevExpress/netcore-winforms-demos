using System.ComponentModel.DataAnnotations;

namespace DevExpress.DevAV.ViewModels {
    public enum CustomerReportType {
        None,
        [Display(Name="Profile Report")]
        Profile,
        [Display(Name = "Contact Directory Report")]
        SelectedContactDirectory,
        [Display(Name = "Contact Directory Report")]
        ContactDirectory,
        [Display(Name = "Sales Summary Report")]
        SalesSummary,
        [Display(Name = "Sales Detail Report")]
        SalesDetail,
        [Display(Name = "Customer Stores Report")]
        LocationsDirectory,
    }
}