namespace DevExpress.DevAV
{
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class CustomerSaleDetailOrderItemInfo
    {
        private Image img;

        public string CustomerBillingAddressCity { get; set; }

        public string CustomerBillingAddressCityLine
        {
            get
            {
                return Address.GetCityLine(this.CustomerBillingAddressCity, this.CustomerBillingAddressState, this.CustomerBillingAddressZipCode);
            }
        }

        public string CustomerBillingAddressLine { get; set; }

        public StateEnum CustomerBillingAddressState { get; set; }

        public string CustomerBillingAddressZipCode { get; set; }

        public string CustomerFax { get; set; }

        public string CustomerHomeOfficeCity { get; set; }

        public string CustomerHomeOfficeCityLine
        {
            get
            {
                return Address.GetCityLine(this.CustomerHomeOfficeCity, this.CustomerHomeOfficeState, this.CustomerHomeOfficeZipCode);
            }
        }

        public string CustomerHomeOfficeLine { get; set; }

        public StateEnum CustomerHomeOfficeState { get; set; }

        public string CustomerHomeOfficeZipCode { get; set; }

        public Image CustomerImage
        {
            get
            {
                return (this.img ?? (this.img = Customer.CreateImage(this.CustomerLogo)));
            }
        }

        public byte[] CustomerLogo { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public decimal Discount { get; set; }

        public string EmployeeFullName { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public long OrderId { get; set; }

        public string PONumber { get; set; }

        public DevExpress.DevAV.ProductCategory ProductCategory { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductUnits { get; set; }

        public decimal ShippingAmount { get; set; }

        public string StoreCity { get; set; }

        public long StoreId { get; set; }

        public decimal Total { get; set; }

        public decimal TotalAmount { get; set; }
    }
}

