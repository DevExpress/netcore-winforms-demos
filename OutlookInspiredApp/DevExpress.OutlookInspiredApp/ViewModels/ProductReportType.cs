using System.ComponentModel.DataAnnotations;

namespace DevExpress.DevAV.ViewModels {
    public enum ProductReportType {
        None,
        [Display(Name = "Order Detail")]
        OrderDetail,
        [Display(Name = "Sales Summary Report")]
        SalesSummary,
        [Display(Name = "Specification Summary Report")]
        SpecificationSummary,
        [Display(Name = "Top Salesperson Report")]
        TopSalesperson
    }
}
