namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class QuoteInfo
    {
        public string City { get; set; }

        public DateTime Date { get; set; }

        public long Id { get; set; }

        public decimal MoneyOpportunity
        {
            get
            {
                return (this.Total * ((decimal) this.Opportunity));
            }
        }

        public double Opportunity { get; set; }

        public decimal Percentage
        {
            get
            {
                return (100M * ((decimal) this.Opportunity));
            }
        }

        public StateEnum State { get; set; }

        public decimal Total { get; set; }
    }
}

