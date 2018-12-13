namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.IO;
    using DevExpress.Utils;

    public enum AnalysisTemplate { 
        CustomerSales,
        ProductSales
    }
    public static class AnalysisTemplatesHelper {
        public static Stream GetAnalysisTemplate(AnalysisTemplate template) {
            switch(template) {
                case AnalysisTemplate.CustomerSales:
                    return GetTemplateStream("CustomerAnalysis.xlsx");
                case AnalysisTemplate.ProductSales:
                    return GetTemplateStream("ProductAnalysis.xlsx");
                default:
                    throw new NotSupportedException(template.ToString());
            }
        }
        static Stream GetTemplateStream(string templateName) {
            return AssemblyHelper.GetEmbeddedResourceStream(typeof(AnalysisTemplatesHelper).Assembly, templateName, false);
        }
    }
}