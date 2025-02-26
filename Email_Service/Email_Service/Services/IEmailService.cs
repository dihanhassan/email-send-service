using Email_Service.Model;

namespace Email_Service.Services
{
    public interface IEmailService
    {
        Task SendEmail(Email email);
    }
}
