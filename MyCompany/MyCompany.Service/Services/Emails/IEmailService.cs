using System.Collections.Generic;

namespace MyCompany.Service.Services.Emails
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
        List<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}
