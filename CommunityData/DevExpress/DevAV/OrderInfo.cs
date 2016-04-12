namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class OrderInfo
    {
        public string Company { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public string Store { get; set; }

        public decimal TotalAmount { get; set; }
    }
}

