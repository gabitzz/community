namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class ProductImage : DatabaseObject
    {
        public virtual DevExpress.DevAV.Picture Picture { get; set; }

        public long? PictureId { get; set; }

        public virtual DevExpress.DevAV.Product Product { get; set; }

        public long? ProductId { get; set; }
    }
}

