using MailingApp.Api.Models;
using MailingApp.Api.Services.Contract;

namespace MailingApp.Api.Services;

public class MailServiceFactory
{
    public static IEmailSender CreateSender(MailSenderType mailSenderType) => mailSenderType switch
    {
        MailSenderType.Mandrill => new MandrilMailSender(),
        MailSenderType.SendGrid => new SendGridMailSender(),
        _ => throw new ArgumentOutOfRangeException(nameof(mailSenderType), mailSenderType, null)
    };
}