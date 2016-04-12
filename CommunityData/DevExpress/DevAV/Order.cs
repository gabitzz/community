namespace DevExpress.DevAV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Order : DatabaseObject
    {
        public Order()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public virtual DevExpress.DevAV.Customer Customer { get; set; }

        public long? CustomerId { get; set; }

        public virtual DevExpress.DevAV.Employee Employee { get; set; }

        public long? EmployeeId { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; }

        public string OrderTerms { get; set; }

        public string PONumber { get; set; }

        [DataType(DataType.Currency)]
        public decimal SaleAmount { get; set; }

        public DateTime ShipDate { get; set; }

        public OrderShipMethod ShipMethod { get; set; }

        [DataType(DataType.Currency)]
        public decimal ShippingAmount { get; set; }

        public virtual CustomerStore Store { get; set; }

        public long? StoreId { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount { get; set; }
    }
}

