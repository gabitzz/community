namespace DevExpress.DevAV.Helpers
{
    public class EmailAccount
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Incoming { get; set; }
        public string Outgoing { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }

        public EmailAccount()
        {
            Type = "POP3";
        }
    }
}