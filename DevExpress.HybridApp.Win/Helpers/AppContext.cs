using System.Collections.Generic;

namespace DevExpress.DevAV.Helpers
{
    public class AppContext
    {
        private AppSettings _settings;
        private List<EmailAccount> _accounts;

        private readonly IAppSettingsReader _appSettingsReader;
        private readonly IAccountReader _accountReader;

        private AppContext()
        {
            _appSettingsReader = new AppSettingsReader();
            _accountReader = new AccountReader();
        }

        public static AppContext Instance { get; } = new AppContext();

        public AppSettings Settings => _settings ?? (_settings = _appSettingsReader.Read());
        public List<EmailAccount> Accounts => _accounts ?? (_accounts = _accountReader.GetAccounts());
    }
}