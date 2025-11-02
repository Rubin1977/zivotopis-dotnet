using RastislavRuzbackyMvcOsobnaStranka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace RastislavRuzbackyMvcOsobnaStranka.Util
{
    public class Mailer
    {
        public void OdoslanieEmalilu(OdoslanieSpravyModel model) 
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("ruzbacky@yahoo.com", "Rastislav Ruzbacky");
            mail.Headers["X-Mailer"] = "developerboss.sk";
            mail.Subject = "Vaša správa pre nás";
            mail.IsBodyHtml = false;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = string.Format("Ďakujeme, že ste nás kontaktovali. Váš email: {0}, Váš telefón: {1}, Vaša správa: {2}", model.Email, model.Telefon, model.Sprava);
            mail.To.Add(model.Email);
            mail.Bcc.Add("rubin7y@gmail.com");

            SmtpClient client = new SmtpClient("smtp.mail.yahoo.com");
            client.EnableSsl = true;           
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("ruzbacky@yahoo.com", "canzahesxtgogros");

            client.Send(mail);
        }
    }
}