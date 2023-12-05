namespace MailingApp.Api.Models;

public enum MailSendStatusType
{
    Send = 0,
    Delivery = 1,
    hard_bounce = 2,
    soft_bounce = 3,
    Open = 4,
    Click = 5,
    Spam = 6,
    Unsub = 7,
    Reject = 8,
    Queued=9,
    Invalid=10,
    Scheduled=11,
}