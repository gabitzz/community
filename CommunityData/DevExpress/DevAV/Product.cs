namespace DevExpress.DevAV
{
    using DevExpress.Utils;
    using DevExpress.XtraEditors.Controls;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;

    public class Product : DatabaseObject
    {
        private System.Drawing.Image img;

        private System.Drawing.Image CreateImage(byte[] data)
        {
            if (data == null)
            {
                return ResourceImageHelper.CreateImageFromResourcesEx("CommunityData.Resources.Unknown_user.png", typeof(Employee).Assembly);
            }
            return ByteImageConverter.FromByteArray(data);
        }

        public bool Available { get; set; }

        public int Backorder { get; set; }

        public byte[] Barcode { get; set; }

        public Stream Brochure
        {
            get
            {
                if ((this.Catalog != null) && (this.Catalog.Count > 0))
                {
                    return this.Catalog[0].PdfStream;
                }
                return null;
            }
        }

        [InverseProperty("Product")]
        public virtual List<ProductCatalog> Catalog { get; set; }

        public ProductCategory Category { get; set; }

        public double ConsumerRating { get; set; }

        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }

        public int? CurrentInventory { get; set; }

        public string Description { get; set; }

        public virtual Employee Engineer { get; set; }

        public long? EngineerId { get; set; }

        public byte[] Image { get; set; }

        public virtual List<DevExpress.DevAV.ProductImage> Images { get; set; }

        public int Manufacturing { get; set; }

        public string Name { get; set; }

        [InverseProperty("Product")]
        public virtual List<OrderItem> OrderItems { get; set; }

        public virtual Picture PrimaryImage { get; set; }

        public long? PrimaryImageId { get; set; }

        public System.Drawing.Image ProductImage
        {
            get
            {
                if ((this.img == null) && (this.PrimaryImage != null))
                {
                    this.img = this.CreateImage(this.PrimaryImage.Data);
                }
                return this.img;
            }
        }

        public DateTime ProductionStart { get; set; }

        [DataType(DataType.Currency)]
        public decimal RetailPrice { get; set; }

        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }

        public virtual Employee Support { get; set; }

        public long? SupportId { get; set; }
    }
}

