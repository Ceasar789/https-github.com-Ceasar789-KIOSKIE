using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using kiosky_common;

namespace Common
{
    public class EmailService : IEmailService
    {
       
        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = true)
        {
            using var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("ace85772397f0b", "76248e07f7d761"),
                EnableSsl = true
            };

            using var message = new MailMessage("from@example.com", toEmail, subject, body)
            {
                IsBodyHtml = isHtml
            };

            await client.SendMailAsync(message);
        }

        
        public string SendEmail(EmailMessage email)
        {
            try
            {
                var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("ace85772397f0b", "76248e07f7d761"),
                    EnableSsl = true
                };

                var message = new MailMessage(email.From, email.To, email.Subject, email.Body)
                {
                    IsBodyHtml = true
                };

                client.Send(message);
                return "Email sent successfully!";
            }
            catch (Exception ex)
            {
                return "Failed to send email: " + ex.Message;
            }
        }
    }
}
