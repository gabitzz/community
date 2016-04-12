namespace DevExpress.DevAV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public class EmployeeTask : DatabaseObject
    {
        public EmployeeTask()
        {
            this.AssignedEmployees = new List<Employee>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}, due {2}, {3},\r\nOwner: {4}", new object[] { this.Subject, this.Description, this.DueDate, this.Status, this.Owner });
        }

        public virtual Employee AssignedEmployee { get; set; }

        public long? AssignedEmployeeId { get; set; }

        public virtual List<Employee> AssignedEmployees { get; set; }

        public string AssignedEmployeesFullList
        {
            get
            {
                string str = string.Empty;
                if (this.AssignedEmployees != null)
                {
                    foreach (Employee employee in this.AssignedEmployees)
                    {
                        str = str + ((employee != this.AssignedEmployees[this.AssignedEmployees.Count - 1]) ? string.Format("{0}, ", employee.FullName) : employee.FullName);
                    }
                }
                return str;
            }
        }

        public bool AttachedCollectionsChanged { get; set; }

        public virtual List<TaskAttachedFile> AttachedFiles { get; set; }

        public int AttachedFilesCount
        {
            get
            {
                if (this.AttachedFiles != null)
                {
                    return this.AttachedFiles.Count;
                }
                return 0;
            }
        }

        public string Category { get; set; }

        public int Completion { get; set; }

        public virtual DevExpress.DevAV.CustomerEmployee CustomerEmployee { get; set; }

        public long? CustomerEmployeeId { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        public EmployeeTaskFollowUp FollowUp { get; set; }

        public bool Overdue
        {
            get
            {
                if ((this.Status == EmployeeTaskStatus.Completed) || !this.DueDate.HasValue)
                {
                    return false;
                }
                DateTime time = this.DueDate.Value.Date.AddDays(1.0);
                return (DateTime.Now >= time);
            }
        }

        public virtual Employee Owner { get; set; }

        public long? OwnerId { get; set; }

        public EmployeeTaskPriority Priority { get; set; }

        public bool Private { get; set; }

        public bool Reminder { get; set; }

        public DateTime? ReminderDateTime { get; set; }

        public string RtfTextDescription { get; set; }

        public DateTime? StartDate { get; set; }

        public EmployeeTaskStatus Status { get; set; }

        [Required]
        public string Subject { get; set; }
    }
}

