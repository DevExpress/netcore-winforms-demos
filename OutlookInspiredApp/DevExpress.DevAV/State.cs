using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DevExpress.DevAV {
    public class State {
        [Key]
        public StateEnum ShortName { get; set; }
        public string LongName { get; set; }
        public byte[] Flag48px { get; set; }
        public byte[] Flag24px { get; set; }
    }
}
 