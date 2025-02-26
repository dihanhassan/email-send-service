using Email_Service.Model;
using Email_Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Email_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        public EmailController(
            IConfiguration configuration,
            IEmailService emailService

            )
        {
            _configuration = configuration;
            _emailService = emailService;
        }

        [HttpPost("send-email")]
        public async Task<IActionResult> SendEmail(Email email)
        {
            try
            {
                await _emailService.SendEmail(email);
                return Ok(new
                {
                    StatusCode = StatusCodes.Status200OK,
                    Value = "Email sent successfully"
                });
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ProblemDetails
                {
                    Title = "An error occurred while sending the email.",
                    Detail = ex.Message,
                    Status = StatusCodes.Status500InternalServerError,
                    Instance = HttpContext.Request.Path
                });
            }
            
        }

    }
}
