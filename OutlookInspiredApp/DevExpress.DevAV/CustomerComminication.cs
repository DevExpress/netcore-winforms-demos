using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class CustomerCommunication : DatabaseObject {
        public virtual Employee Employee { get; set; }
        public long? EmployeeId { get; set; }
        public virtual CustomerEmployee CustomerEmployee { get; set; }
        public long? CustomerEmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Purpose { get; set; }
    }
}
