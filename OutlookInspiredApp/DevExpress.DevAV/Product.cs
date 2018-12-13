using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;

namespace DevExpress.DevAV {
    public enum ProductCategory {
        [Display(Name = "Automation")]
        Automation,
        [Display(Name = "Monitors")]
        Monitors,
        [Display(Name = "Projectors")]
        Projectors,
        [Display(Name = "Televisions")]
        Televisions,
        [Display(Name = "Video Players")]
        VideoPlayers,
    }
    public class Product : DatabaseObject {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ProductionStart { get; set; }
        public bool Available { get; set; }
        public byte[] Image { get; set; }
        public virtual Employee Support { get; set; }
        public long? SupportId { get; set; }
        public virtual Employee Engineer { get; set; }
        public long? EngineerId { get; set; }
        public int? CurrentInventory { get; set; }
        public int Backorder { get; set; }
        public int Manufacturing { get; set; }
        public byte[] Barcode { get; set; }
        public virtual Picture PrimaryImage { get; set; }
        public long? PrimaryImageId { get; set; }
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal RetailPrice { get; set; }
        public double Weight { get; set; }
        public double ConsumerRating { get; set; }
        public ProductCategory Category { get; set; }
        [InverseProperty("Product")]
        public virtual List<ProductCatalog> Catalog { get; set; }
        [InverseProperty("Product")]
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<ProductImage> Images { get; set; }
        public virtual ICollection<QuoteItem> QuoteItems { get; set; }
        public Stream Brochure {
            get {
                if(Catalog != null && Catalog.Count > 0)
                    return Catalog[0].PdfStream;
                return null;
            }
        }
        Image img;
        public Image ProductImage {
            get {
                if(img == null && PrimaryImage != null)
                    img = CreateImage(PrimaryImage.Data);
                return img;
            }
        }
        Image CreateImage(byte[] data) {
            if (data == null)
                return null;//  ResourceImageHelper.CreateImageFromResourcesEx("DevExpress.DevAV.Resources.Unknown-user.png", typeof(Employee).Assembly);
            else
                return DevAVByteImageConverter.FromByteArray(data);
        }
    }
}