using SendGrid.Helpers.Mail;
namespace DitsPortal.Common.Requests
{

    public class EmailOptions
    {
        public EmailAddress From { get; set; }
        public EmailAddress To { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}
