using kiosky_common;
namespace Common
{
    public class MailSettings
    {
        public string Host { get; set; } = "";
        public int Port { get; set; } = 25;
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public bool EnableSsl { get; set; } = true;
        public string FromName { get; set; } = "";
        public string FromEmail { get; set; } = "";
    }
}
