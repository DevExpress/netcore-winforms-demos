using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public enum EvaluationRating {
        Unset,
        Good,
        Average,
        Poor
    }
    public partial class Evaluation : DatabaseObject {
        public virtual Employee CreatedBy { get; set; }
        public long? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual Employee Employee { get; set; }
        public long? EmployeeId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public virtual EvaluationRating Rating { get; set; }
    }
}
