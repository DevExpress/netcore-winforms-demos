using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.Reports.Spreadsheet {
    public enum CustomEditorIds {
        FOBSpinEdit,
        TermsSpinEdit,
        QuantitySpinEdit,
        DiscountSpinEdit,
        ShippingSpinEdit
    }


    public enum CellsKind {
        Date,
        InvoiceNumber,
        CustomerName,
        CustomerHomeOfficeName,
        CustomerStreetLine,
        CustomerCityLine,
        ShippingCustomerName,
        CustomerStoreName,
        CustomerStoreStreetLine,
        CustomerStoreCityLine,

        EmployeeName,
        PONumber,
        ShipDate,
        ShipVia,
        FOB,
        Terms,
        SubTotal,
        Shipping,
        TotalDue,
        Comments,

        Quantity,
        ProductDescription,
        UnitPrice,
        Discount,
        Total,
        AmountPaid
    }
}
