using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace zoomed
{
    class sendMail
    {
        public sendMail()
        {

        }

        public void send(string textTosend)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("cristobalcordovaw@gmail.com");
                message.To.Add(new MailAddress("cristobalcordovaw@gmail.com"));

                message.Subject = "test";
                message.IsBodyHtml = true;
                message.Body = textTosend;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("cristobalcordovaw@gmail.com", "lospcc.2");
                

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch(SmtpException e)
            {
                throw e;
            }
        }

    }
}
