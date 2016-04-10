namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class FromFilterRule : IMessageFilterRule
    {
        public bool IsRuleDefined(EmailRule rule)
        {
            return !string.IsNullOrEmpty(rule.From);
        }

        public bool IsMatch(Message message, EmailRule rule)
        {
            return IsRuleDefined(rule) && message.From.ToLower().Contains(rule.From.ToLower());
        }
    }
}