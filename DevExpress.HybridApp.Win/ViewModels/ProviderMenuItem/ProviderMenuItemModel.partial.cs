using System.Linq;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.ViewModels
{
    partial class ProviderMenuItemModel:IBaseViewModel
    {
        public new bool IsNew() { return base.IsNew(); }
        public IQueryable<Employee> GetEmployees()
        {
            return UnitOfWork.Employees.GetEntities();
        }
        public override void Delete()
        {
            MessageBoxService.ShowMessage("To ensure data integrity, the Portal module doesn't allow records to be deleted. Record deletion is supported by the Teams module.", "Delete Product", MessageButton.OK);
        }
    }
}
