using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class ProductCatalog : DatabaseObject {
        public virtual Product Product { get; set; }
        public long? ProductId { get; set; }
        public byte[] PDF { get; set; }
        Stream _pdfStream;
        public Stream PdfStream {
            get {
                if (_pdfStream == null)
                    _pdfStream = new MemoryStream(PDF);
                return _pdfStream;
            }
        }
    }
}