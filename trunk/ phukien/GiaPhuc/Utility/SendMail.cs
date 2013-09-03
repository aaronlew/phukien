using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for SendMailClient
/// </summary>
public class SendMail
{
    #region Constant

    private const int Port = 25;
    private const string Host = "mail.gmail.com";
    private const string EmailAddress = "phukienipadx@gmail.com";
    private const string Password = "#me2010";

    #endregion

    #region define

    private readonly SmtpClient _smtpClient;

    #endregion

    #region Constructors & Destructors

    public SendMail()
        : this(false)
    {
    }

    public SendMail(bool enableSsl)
        : this(Host, Port, EmailAddress, Password, enableSsl)
    {
    }

    public SendMail(string displayName, bool enableSsl = false)
        : this(Host, Port, EmailAddress, Password, enableSsl)
    {
    }

    public SendMail(string host, int port, string emailAddress, string password)
        : this(host, port, emailAddress, password, false)
    {
    }

    public SendMail(string host, int port, string emailAddress, string password, bool enableSSL)
    {
        _smtpClient = new SmtpClient(host, port) { Credentials = new NetworkCredential(emailAddress, password), EnableSsl = enableSSL };
    }

    #endregion

    #region Methods

    /// <summary>
    /// Send Email
    /// </summary>
    /// <param name="displayName"> </param>
    /// <param name="emailTo"></param>
    /// <param name="subject"></param>
    /// <param name="body"></param>
    /// <param name="isHtmlFormat"></param>
    /// <param name="emailCc"> </param>
    /// <param name="emailBcc"> </param>
    /// <returns></returns>
    public int Send(string displayName, string emailTo, string subject, string body, bool isHtmlFormat = true, string[] emailCc = null,
                    string[] emailBcc = null)
    {
        try
        {
            // Validate Email
            var reg = new Regex(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");

            if (reg.IsMatch(emailTo))
            {
                var mailFrom = new MailAddress(EmailAddress, displayName, Encoding.UTF8);
                var mailTo = new MailAddress(emailTo);

                using (var mailMessage = new MailMessage(mailFrom, mailTo))
                {
                    mailMessage.ReplyToList.Add(mailMessage.From);

                    // CC mails
                    if (emailCc != null && emailCc.Length > 0)
                    {
                        foreach (string item in emailCc)
                            mailMessage.CC.Add(new MailAddress(item));
                    }

                    // Bcc mails
                    if (emailBcc != null && emailBcc.Length > 0)
                    {
                        foreach (string item in emailBcc)
                            mailMessage.Bcc.Add(new MailAddress(item));
                    }

                    mailMessage.Subject = subject;
                    mailMessage.BodyEncoding = Encoding.UTF8;
                    mailMessage.IsBodyHtml = isHtmlFormat;

                    // specify the priority of the mail message
                    //mailMessage.Priority = MailPriority.High;
                    // This method has been deprecated.
                    // mail.Headers.Add("Return-Receipt-To", "prashantmx@xyz.com"); 
                    // Use this if you need an delivery notification of an email.             
                    // DeliveryNotificationOption is an enumeration
                    // and can be used to set the delivery notification on the following options:
                    // 1. Delay
                    // 2. Never
                    // 3. None
                    // 4. OnFailure
                    // 5. OnSuccess
                    // You can use also use OnFailure enum with OnSuccess enum. If in case the e-mail
                    // fails to delivered you'll get notification for both the cases
                    //mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                    // Add "Disposition-Notification-To" for Read receipt
                    //mailMessage.Headers.Add("Disposition-Notification-To", "");

                    //string filename = "Image/logo.jpg";
                    //string filePath = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath.Replace("/", "\\")) + "\\" + filename;

                    ////Creating LinkedSource for embedded picture
                    //LinkedResource myPhoto = new LinkedResource(filePath);
                    //myPhoto.ContentId = "logo";

                    AlternateView htmlView =
                        AlternateView.CreateAlternateViewFromString(
                            mailMessage.IsBodyHtml
                                ? String.Format("<html><head><title>{0}</title></head><body>{1}</body></html>", subject,
                                                body)
                                : body, null, "text/html");

                    //Adding LinkedSource to AlternateView
                    //htmlView.LinkedResources.Add(myPhoto);

                    mailMessage.AlternateViews.Add(htmlView);

                    //mailMessage.Body = mailMessage.IsBodyHtml ? String.Format("<html><head><title>{0}</title></head><body>{1}</body></html>", subject, body) : body;

                    _smtpClient.Send(mailMessage);
                }

                return 1;
            }
            else
            {
                return 0;
            }
        }
        catch
        {
            return -1;
        }
    }

    #endregion
}