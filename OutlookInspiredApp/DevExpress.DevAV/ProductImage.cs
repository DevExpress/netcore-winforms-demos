using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class ProductImage : DatabaseObject {
        public virtual Picture Picture { get; set; }
        public long? PictureId { get; set; }
        public virtual Product Product { get; set; }
        public long? ProductId { get; set; }
    }
}
