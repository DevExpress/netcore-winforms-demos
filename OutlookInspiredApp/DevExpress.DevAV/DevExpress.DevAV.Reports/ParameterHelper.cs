using DevExpress.XtraReports.Parameters;
using System;

namespace DevExpress.DevAV.Reports {
    static class ParameterHelper {
        public static void InitializeDateTimeParameters(Parameter fromDate, Parameter toDate) {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            fromDate.Value = new DateTime(currentYear - 2, currentMonth, 1);
            toDate.Value = new DateTime(currentYear, currentMonth, 1);
        }
        public static void InitializeMultiValueDateParameter(Parameter param) {
            int currentYear = DateTime.Now.Year;

            param.Value = string.Join(",", currentYear - 2, currentYear - 1, currentYear);
        }
    }
}
