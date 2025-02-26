using System.ComponentModel.DataAnnotations;

namespace Email_Service.Model
{
    public class Email
    {
        [Required]
        public string To { get; set; } 
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
