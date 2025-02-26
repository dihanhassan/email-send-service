using Email_Service.Model;
using System.Net;
using System.Net.Mail;

namespace Email_Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmail(Email email)
        {
            try
            {
                var senderEmail = _configuration["Email_Config:SenderEmail"];
                var senderPassword = _configuration["Email_Config:SenderPassword"];
                var smtpHost = _configuration["Email_Config:SmtpHost"];
                var smtpPort = _configuration["Email_Config:SmtpPort"];

                var smtpClient = new SmtpClient(smtpHost, int.Parse(smtpPort))
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(senderEmail, senderPassword)
                };

                var mail = new MailMessage(senderEmail!, email.To, email.Subject, email.Body);

                await smtpClient.SendMailAsync(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
