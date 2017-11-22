using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Api.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
            public Task SendEmailAsync(string email, string subject, string message)
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("Duy Nam Tin", "vu.nh@live.com"));
                emailMessage.To.Add(new MailboxAddress("Hello Hoang Vu", email));
                emailMessage.Subject = subject;
                emailMessage.Body = new TextPart("html") { Text = message };
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("smtp.gmail.com", 587, false);

                    // the XOAUTH2 authentication mechanism.
                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("quanlytinhoc@gmail.com", "saigon209");

                    client.Send(emailMessage);
                    client.Disconnect(true);
                }


                return Task.CompletedTask;
            }
        
    }
}
