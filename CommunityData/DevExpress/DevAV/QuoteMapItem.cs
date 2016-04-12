namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class QuoteMapItem
    {
        public DevExpress.DevAV.Address Address { get; set; }

        public string City
        {
            get
            {
                return this.Address.City;
            }
        }

        public DateTime Date { get; set; }

        public int Index
        {
            get
            {
                return (int) this.Stage;
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

        public string Name
        {
            get
            {
                return Enum.GetName(typeof(DevExpress.DevAV.Stage), this.Stage);
            }
        }

        public DevExpress.DevAV.Stage Stage { get; set; }

        public decimal Value { get; set; }
    }
}

