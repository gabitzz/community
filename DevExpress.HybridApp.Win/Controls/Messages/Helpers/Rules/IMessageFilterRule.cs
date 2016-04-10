namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public interface IMessageFilterRule
    {
        bool IsRuleDefined(EmailRule rule);
        bool IsMatch(Message message, EmailRule rule);
    }
}