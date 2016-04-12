namespace DevExpress.DevAV
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class ProductInfoWithSales
    {
        public int Backorder { get; set; }

        public decimal Cost { get; set; }

        public int? CurrentInventory { get; set; }

        public long Id { get; set; }

        public IEnumerable<double> MonthlySales { get; set; }

        public string Name { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal? TotalSales { get; set; }
    }
}

