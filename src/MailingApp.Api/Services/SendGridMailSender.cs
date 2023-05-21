using System;
using MailingApp.Api.Models;
using MailingApp.Api.Services.Contract;

namespace MailingApp.Api.Services
{
    public class SendGridMailSender : IEmailSender
    {
        public Task<EmailMessageResponseDto> SendMessageAsync(EmailMessageDto message)
        {
            throw new NotImplementedException();
        }
    }
}

