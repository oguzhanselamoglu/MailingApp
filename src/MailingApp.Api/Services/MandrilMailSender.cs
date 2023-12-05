using System;
using MailingApp.Api.Models;
using MailingApp.Api.Services.Contract;
using Mandrill;
using Mandrill.Models;
using Mandrill.Requests.Messages;

namespace MailingApp.Api.Services
{
    public class MandrilMailSender : IEmailSender
    {
        private MandrillApi _mandrill;
        private IMailSettings _settings;

        public MandrilMailSender()
        {
            _settings = new MailSettings();
            _mandrill = new(_settings.Password);
        }
        public async Task<EmailMessageResponseDto> SendMessageAsync(EmailMessageDto message)
        {
            var response = new EmailMessageResponseDto();
            Mandrill.Models.EmailMessage emailMessage = new Mandrill.Models.EmailMessage()
            {
                Html = message.Body,
                To = new List<Mandrill.Models.EmailAddress>() { new Mandrill.Models.EmailAddress { Email = message.To } },
                Subject = message.Subject,
                SigningDomain = _settings.Host,
                FromEmail = _settings.From,
                FromName = _settings.DisplayName
                    
            };
            
            SendMessageRequest sendMessageRequest = new SendMessageRequest(emailMessage);
            var result= await  _mandrill.SendMessage(sendMessageRequest);
            var emailResult = result.FirstOrDefault();
            response.Status = (MailSendStatusType)emailResult.Status;

            return response;
        }
    }
}

