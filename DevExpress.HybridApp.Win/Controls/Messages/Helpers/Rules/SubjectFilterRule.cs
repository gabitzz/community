namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class SubjectFilterRule : IMessageFilterRule
    {
        public bool IsRuleDefined(EmailRule rule)
        {
            return !string.IsNullOrEmpty(rule.Subject);
        }

        public bool IsMatch(Message message, EmailRule rule)
        {
            return IsRuleDefined(rule) && message.Subject.ToLower().Contains(rule.Subject.ToLower());
        }
    }
}