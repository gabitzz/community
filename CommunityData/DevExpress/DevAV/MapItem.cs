namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class MapItem
    {
        public DevExpress.DevAV.Address Address { get; set; }

        public string City
        {
            get
            {
                return this.Address.City;
            }
        }

        public DevExpress.DevAV.Customer Customer { get; set; }

        public string CustomerName
        {
            get
            {
                return this.Customer.Name;
            }
        }

        public double Latitude
        {
            get
            {
                return this.Address.Latitude;
            }
        }

        public double Longitude
        {
            get
            {
                return this.Address.Longitude;
            }
        }

        public DevExpress.DevAV.Product Product { get; set; }

        public DevExpress.DevAV.ProductCategory ProductCategory
        {
            get
            {
                return this.Product.Category;
            }
        }

        public string ProductName
        {
            get
            {
                return this.Product.Name;
            }
        }

        public decimal Total { get; set; }
    }
}

