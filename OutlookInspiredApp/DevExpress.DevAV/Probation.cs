using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class Probation : DatabaseObject {
        public string Reason { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
 