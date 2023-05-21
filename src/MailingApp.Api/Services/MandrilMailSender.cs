using System;
using MailingApp.Api.Models;
using MailingApp.Api.Services.Contract;

namespace MailingApp.Api.Services
{
    public class MandrilMailSender : IEmailSender
    {
        public Task<EmailMessageResponseDto> SendMessageAsync(EmailMessageDto message)
        {
            throw new NotImplementedException();
        }
    }
}

