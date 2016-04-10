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
            foreach (var rule in _rules.Rules)
            {
                if (ShouldFliter(message, rule))
                {
                    message.MailFolder = (int) MailFolder.ASP; //rule.Folder; TODO Use folder rule
                }
                else
                {
                    message.MailFolder = (int) MailFolder.Announcements; // TODO check which folder should be default
                }
            }
        }

        private bool ShouldFliter(Message message, EmailRule rule)
        {
            bool shouldFilter = true;
            bool shouldFilterChanged = false;
            foreach (var messageFilterRule in _filterRules)
            {
                var isMatch = messageFilterRule.IsMatch(message, rule);
                if (messageFilterRule.IsRuleDefined(rule))
                {
                    shouldFilter &= isMatch;
                    shouldFilterChanged = true;
                }
                //else
                //{
                //    if (!shouldFilterWasInitialized)
                //    {
                //        shouldFilter = isMatch;
                //        shouldFilterWasInitialized = true;
                //    }
                //    else
                //    {
                //        shouldFilter |= isMatch;
                //    }
                    
                //}
                
            }
            return shouldFilter && shouldFilterChanged;
        }
    }
}
