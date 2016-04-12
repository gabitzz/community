namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class OrderItem : DatabaseObject
    {
        [DataType(DataType.Currency)]
        public decimal Discount { get; set; }

        public virtual DevExpress.DevAV.Order Order { get; set; }

        public long? OrderId { get; set; }

        public virtual DevExpress.DevAV.Product Product { get; set; }

        public long? ProductId { get; set; }

        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }

        public int ProductUnits { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}

