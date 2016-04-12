namespace DevExpress.DevAV
{
    using DevExpress.Common;
    using DevExpress.DataAnnotations;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class Address : IDataErrorInfo
    {
        internal static string GetCityLine(string city, StateEnum state, string zipCode)
        {
            return string.Format("{0}, {1} {2}", city, state, zipCode);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Line, this.CityLine);
        }

        public string City { get; set; }

        public string CityLine
        {
            get
            {
                return GetCityLine(this.City, this.State, this.ZipCode);
            }
        }

        public double Latitude { get; set; }

        [Display(Name="Address")]
        public string Line { get; set; }

        public double Longitude { get; set; }

        public StateEnum State { get; set; }

        string IDataErrorInfo.Error
        {
            get
            {
                return null;
            }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                return IDataErrorInfoHelper.GetErrorText(this, columnName);
            }
        }

        [Display(Name="Zip code"), ZipCode]
        public string ZipCode { get; set; }
    }
}

