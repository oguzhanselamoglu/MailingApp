using System.Collections.Specialized;

namespace MailingApp.Api.Services.Contract;

public interface IMailSettings
{
    NameValueCollection Headers { get; set; }
    string From { get; set; }
    string Host { get; set; }
    int Port { get; set; }
    bool EnableSsl { get; set; }
    string UserName { get; set; }
    string Password { get; set; }
    string DisplayName { get; set; }
}