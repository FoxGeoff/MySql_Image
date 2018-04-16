using System;
using System.Net;
using System.Net.Mail;

namespace MySql_Image.Services
{
    public class RealMailService : IMailService
    {
        public void SendMessage(string to, string subject, string body)
        {
            using (SmtpClient SmtpServer = new SmtpClient("smtp.live.com"))
            {
                try
                {
                    SmtpServer.Port = 587; // outlook

                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("DevTestOnly@outlook.com", "AudioImpact18##");

                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.EnableSsl = true;

                    var mail = new MailMessage();
                    mail.From = new MailAddress("DevTestOnly@outlook.com");
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;

                    SmtpServer.Send(mail);
                    mail = null;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Could not send e-mail. Exception caught: " + e);
                }
            }
        }
    }
}