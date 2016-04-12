namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class SaleSummaryInfo
    {
        public decimal Discount { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public DevExpress.DevAV.ProductCategory ProductCategory { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductUnits { get; set; }

        public string StoreCity { get; set; }

        public string StoreCustomerName { get; set; }

        public long StoreId { get; set; }

        public decimal Total { get; set; }
    }
}

