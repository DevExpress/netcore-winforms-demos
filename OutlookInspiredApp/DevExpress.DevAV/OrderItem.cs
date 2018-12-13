using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class OrderItem : DatabaseObject {
        public virtual Order Order { get; set; }
        public long? OrderId { get; set; }
        public virtual Product Product { get; set; }
        public long? ProductId { get; set; }
        public int ProductUnits { get; set; }
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal Discount { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}
