using System;
namespace MailingApp.Api.Models
{
	public class EmailMessageDto
	{
        public string FromMail { get; set; }
        public string FromName { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string EmailAddress { get; set; }
        public string Body { get; set; }
        public string Html { get; set; }
    }
}

