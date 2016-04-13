using System;
using System.Collections.Generic;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;

namespace DevExpress.DevAV.Helpers
{
    public class MessageFilterEvaluator
    {
        private readonly EmailRules _rules;

        private List<IMessageFilterRule> _filterRules = new List<IMessageFilterRule>
        {
            new FromFilterRule(),
            new SubjectFilterRule()
        };

        public MessageFilterEvaluator(EmailRules rules)
        {
            _rules = rules;
        }

        public void ApplyRules(Message message)
        {
            var defaultFolder = MailFolder.Announcements;  // TODO check which folder should be default
            foreach (var rule in _rules.Rules)
            {
                if (ShouldFilter(message, rule))
                {
                    try
                    {
                        Enum.TryParse<MailFolder>(rule.Folder, true, out defaultFolder);}
                    catch { }
                }

                message.MailFolder = (int) defaultFolder;
            }
        }
        private bool ShouldFilter(Message message, EmailRule rule)
        {
            bool shouldFilter = true;
            bool shouldFilterValueIsChanged = false;
            foreach (var messageFilterRule in _filterRules)
            {
                var isMatch = messageFilterRule.IsMatch(message, rule);
                if (messageFilterRule.IsRuleDefined(rule))
                {
                    shouldFilter &= isMatch;
                    shouldFilterValueIsChanged = true;
                }
            }
            return shouldFilter && shouldFilterValueIsChanged;
        }
    }
}
