using System.ComponentModel.DataAnnotations;

namespace DevExpress.DevAV
{
    public enum EmployeeStatus
    {
        [Display(Name = "SilentBusters")]
        SilentBusters = 0,
        [Display(Name="TeamX")]
        TeamX = 1,
        [Display(Name="TeamY")]
        TeamY = 2,
        [Display(Name = "TeamZ")]
        TeamZ = 3,
        [Display(Name="TeamW")]
        TeamW = 4,
    }
}

