using System;
using System.Configuration;

namespace DevExpress.DevAV
{
    public class AppSettings
    {
        private const int DEFAULT_SEND_RECEIVE_TIME_INTERVAL = 5;
        public static AppSettings Instance { get; } = new AppSettings();

        /// <summary>
        /// Automatic send receive interval (in miliseconds)
        /// Default value is set to 5 seconds
        /// </summary>
        public int SendReceiveTimeInterval
        {
            get
            {
                try
                {
                    var setting = Convert.ToInt32(ConfigurationManager.AppSettings["SendReceiveTimeInterval"]);
                    var sendReceiveTimeIntervalInSeconds = setting == 0 ? DEFAULT_SEND_RECEIVE_TIME_INTERVAL : setting;
                    return sendReceiveTimeIntervalInSeconds*1000;
                }
                catch (FormatException)
                {
                    // TODO log exception
                    return DEFAULT_SEND_RECEIVE_TIME_INTERVAL;
                }
            }
        }
    }
}
