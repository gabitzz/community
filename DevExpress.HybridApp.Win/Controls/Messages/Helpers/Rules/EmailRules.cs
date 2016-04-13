using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.DevAV.Helpers;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class EmailRules
    {
        public BindingList<EmailRule> Rules { get; set; } = new BindingList<EmailRule>();
    }

    public class EmailRulesHelper
    {
        private readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(EmailRules));
        private const string DATA_EMAILRULES_XML = @"EmailRules.xml";

        public static EmailRulesHelper Instance { get; } = new EmailRulesHelper();
        private static EmailRules EmailRules { get; set; }

        private EmailRulesHelper()
        {
        }

        public EmailRules GetEmailRules()
        {
            if (File.Exists(GetEmailRulesFile()))
            {
                using (var fileStream = new FileStream(GetEmailRulesFile(), FileMode.Open))
                {
                    return _xmlSerializer.Deserialize(fileStream) as EmailRules;
                }
            }
            return new EmailRules();
        }

        public void AddRule(EmailRule rule)
        {
            EmailRules.Rules.Add(rule);
            var emailRulesFile = GetEmailRulesFile();

            using (var fileStream = new FileStream(emailRulesFile, FileMode.OpenOrCreate))
            {
                _xmlSerializer.Serialize(fileStream, EmailRules);
            }
        }

        private string GetEmailRulesFile()
        {
            return Path.Combine(Constants.BASE_DATA_PATH, DATA_EMAILRULES_XML);
        }

    }
}