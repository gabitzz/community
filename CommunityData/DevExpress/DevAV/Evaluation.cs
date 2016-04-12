namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class Evaluation : DatabaseObject
    {
        public virtual DevExpress.DevAV.Employee CreatedBy { get; set; }

        public long? CreatedById { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Details { get; set; }

        public virtual DevExpress.DevAV.Employee Employee { get; set; }

        public long? EmployeeId { get; set; }

        public virtual EvaluationRating Rating { get; set; }

        public string Subject { get; set; }
    }
}

