using System.Configuration;

namespace DevExpress.DevAV.Helpers
{
    public class AppSettingsReader : IAppSettingsReader
    {
        public AppSettings Read()
        {
            var settings = new AppSettings();
            bool showSplashScreen;
            if (bool.TryParse(ConfigurationManager.AppSettings["ShowSplashScreen"], out showSplashScreen))
            {
                settings.ShowSplashScreen = showSplashScreen;
            }
            return settings;
        }
    }
}