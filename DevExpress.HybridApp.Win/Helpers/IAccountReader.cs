using System.Collections.Generic;

namespace DevExpress.DevAV.Helpers
{
    public interface IAccountReader
    {
        List<EmailAccount> GetAccounts();
    }
}