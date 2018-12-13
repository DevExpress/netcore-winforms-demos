using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class Quote : DatabaseObject {
        public string Number { get; set; }
        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }
        public virtual CustomerStore CustomerStore { get; set; }
        public long? CustomerStoreId { get; set; }
        public virtual Employee Employee { get; set; }
        public long? EmployeeId { get; set; }
        public virtual DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public decimal SubTotal { get; set; }
        [DataType(DataType.Currency)]
        public decimal ShippingAmount { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
        public double Opportunity { get; set; }
        public virtual List<QuoteItem> QuoteItems { get; set; }
    }
}
