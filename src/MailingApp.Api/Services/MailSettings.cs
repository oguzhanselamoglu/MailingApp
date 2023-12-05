using System.Collections.Specialized;
using MailingApp.Api.Services.Contract;

namespace MailingApp.Api.Models;

public class MailSettings: IMailSettings
{
    public NameValueCollection Headers { get; set; }
    public string From { get; set; }
    public string Host { get; set; }
    public int Port { get; set; }
    public bool EnableSsl { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string DisplayName { get; set; }

    public MailSettings()
    {
        From = "info@sedna360.com";
        Host = "smtp.mandrillapp.com";
        Port = 587;
        EnableSsl = true;
        UserName = "";
        Password = "";
    }
}