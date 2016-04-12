namespace DevExpress.DevAV
{
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class CustomerSaleDetailOrderInfo
    {
        public string CustomerBillingAddressCityLine { get; set; }

        public string CustomerBillingAddressLine { get; set; }

        public string CustomerFax { get; set; }

        public string CustomerHomeOfficeCityLine { get; set; }

        public string CustomerHomeOfficeLine { get; set; }

        public Image CustomerImage { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public string EmployeeFullName { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public long OrderId { get; set; }

        public CustomerSaleDetailOrderItemInfo[] OrderItems { get; set; }

        public string PONumber { get; set; }

        public DevExpress.DevAV.ProductCategory ProductCategory { get; set; }

        public decimal ShippingAmount { get; set; }

        public string StoreCity { get; set; }

        public long StoreId { get; set; }

        public decimal TotalAmount { get; set; }
    }
}

