namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class CustomerCommunication : DatabaseObject
    {
        public virtual DevExpress.DevAV.CustomerEmployee CustomerEmployee { get; set; }

        public long? CustomerEmployeeId { get; set; }

        public DateTime Date { get; set; }

        public virtual DevExpress.DevAV.Employee Employee { get; set; }

        public long? EmployeeId { get; set; }

        public string Purpose { get; set; }

        public string Type { get; set; }
    }
}

