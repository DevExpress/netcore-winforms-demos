using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV {
    public class TaskAttachedFile : DatabaseObject {
        public virtual EmployeeTask EmployeeTask { get; set; }
        public long? EmployeeTaskId { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
    }
}