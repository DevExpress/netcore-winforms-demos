using System.Drawing;
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
            if (picture == null)
            {
                return null;
                //if (string.IsNullOrEmpty(defaultImage))
                //    defaultImage = DefaultPic;
                //return ResourceImageHelper.CreateImageFromResourcesEx(defaultImage, typeof(Picture).Assembly);
            }
            else return DevAVByteImageConverter.FromByteArray(picture.Data);
        }
        internal static Picture FromImage(Image image) {
            return null;
            //return (image == null) ? null : new Picture()
            //{
            //    Data = DevAVByteImageConverter.ToByteArray(image, image.RawFormat)
            //};
        }
    }
}