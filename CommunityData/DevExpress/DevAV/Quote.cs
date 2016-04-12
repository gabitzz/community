namespace DevExpress.DevAV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Quote : DatabaseObject
    {
        public virtual DevExpress.DevAV.Customer Customer { get; set; }

        public long? CustomerId { get; set; }

        public virtual DevExpress.DevAV.CustomerStore CustomerStore { get; set; }

        public long? CustomerStoreId { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual DevExpress.DevAV.Employee Employee { get; set; }

        public long? EmployeeId { get; set; }

        public string Number { get; set; }

        public double Opportunity { get; set; }

        public virtual List<QuoteItem> QuoteItems { get; set; }

        [DataType(DataType.Currency)]
        public decimal ShippingAmount { get; set; }

        [DataType(DataType.Currency)]
        public decimal SubTotal { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}

