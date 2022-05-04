using System.Net;
using System.Net.Mail;
using System.Text;

namespace portfolio.services
{
    public class SendMail
    {
        public SmtpClient client;
        public string SiteMail = "Ahmed.M.Younis20@gmail.com";
        public  MailMessage message;
        public SendMail(string toMail,string subject,string body,string name)
        {

            client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(SiteMail, "raghad25")
                
                
            };
            MailAddress to = new MailAddress(toMail, name);
            MailAddress from = new MailAddress(SiteMail, "Younis");
            message = new MailMessage()
            {
                Subject = subject,
                Body = body,
                From = from,
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            };
            message.To.Add(to);



        }
        public async void Send()
        {
            try
            {
                await client.SendMailAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
