using System;
using System.Net;
using System.Net.Mail;
using Common;

namespace Business
{
    public class EmailService
    {
        public string SendEmail(EmailMessage email)
        {
            try
            {
                var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("ace85772397f0b", "76248e07f7d761"),
                    EnableSsl = true
                };

                client.Send(email.From, email.To, email.Subject, email.Body);
                return " Email sent successfully!";
            }
            catch (Exception ex)
            {
                return $" Email failed: {ex.Message}";
            }
        }
    }
}