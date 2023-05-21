using System;
using MailingApp.Api.Models;

namespace MailingApp.Api.Services.Contract
{
	public interface IEmailSender
	{
        Task<EmailMessageResponseDto> SendMessageAsync(EmailMessageDto message);
    }
}

