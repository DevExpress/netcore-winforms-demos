using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace DevExpress.DevAV {
    public class Picture : DatabaseObject {
        public byte[] Data { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<CustomerEmployee> CustomerEmployees { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
    static class PictureExtension {
        public const string DefaultPic = DefaultUserPic;
        public const string DefaultUserPic = "DevExpress.DevAV.Resources.Unknown-user.png";
        internal static Image CreateImage(this Picture picture, string defaultImage = null) {
            if(picture == null) {
                if(string.IsNullOrEmpty(defaultImage))
                    defaultImage = DefaultPic;
                return ResourceImageHelper.CreateImageFromResourcesEx(defaultImage, typeof(Picture).Assembly);
            }
            else return ByteImageConverter.FromByteArray(picture.Data);
        }
        internal static Picture FromImage(Image image) {
            return (image == null) ? null : new Picture()
            {
                Data = ByteImageConverter.ToByteArray(image, image.RawFormat)
            };
        }
    }
}