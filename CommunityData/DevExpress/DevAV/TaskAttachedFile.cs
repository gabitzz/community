namespace DevExpress.DevAV
{
    using System;
    using System.Runtime.CompilerServices;

    public class TaskAttachedFile : DatabaseObject
    {
        public byte[] Content { get; set; }

        public virtual DevExpress.DevAV.EmployeeTask EmployeeTask { get; set; }

        public long? EmployeeTaskId { get; set; }

        public string Name { get; set; }
    }
}

