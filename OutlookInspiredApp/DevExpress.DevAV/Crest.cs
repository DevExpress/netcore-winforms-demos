using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.DevAV {
    public class Crest : DatabaseObject {
        public string CityName { get; set; }
        public byte[] SmallImage { get; set; }
        public byte[] LargeImage { get; set; }
        public virtual ICollection<CustomerStore> CustomerStores { get; set; }
        Image img;
        public Image LargeImageEx {
            get {
                if (img == null)
                    if (LargeImage == null)
                        return null; //ResourceImageHelper.CreateImageFromResourcesEx("DevExpress.DevAV.Resources.Unknown-user.png", typeof(Employee).Assembly);
                    else
                        img = DevAVByteImageConverter.FromByteArray(LargeImage);
                return img;
            }
        }
    }
}
