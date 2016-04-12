namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum EmployeeTaskStatus
    {
        [Display(Name="Completed")]
        Completed = 1,
        [Display(Name="Deferred")]
        Deferred = 4,
        [Display(Name="In Progress")]
        InProgress = 2,
        [Display(Name="Need Assistance")]
        NeedAssistance = 3,
        [Display(Name="Not Started")]
        NotStarted = 0
    }
}

