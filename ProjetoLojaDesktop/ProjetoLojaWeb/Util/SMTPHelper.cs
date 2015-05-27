using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace ProjetoLojaWeb.Util
{
    public class SMTPHelper
    {
        public static void EnviarEmail(MensagemEmail mensagem)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
<<<<<<< HEAD
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Timeout = 10000;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("feerpessoa26@gmail.com", "tulio123");
            MailMessage message = new MailMessage(mensagem.Remetente, mensagem.Destinatario);
            message.Subject = mensagem.Assunto;
            message.Body = mensagem.Mensagem;
            smtp.Send(message);            
=======
            smtp.Port = 465;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("feerpessoa26@gmail.com", "tulio123");
            MailMessage message = new MailMessage();
            message.Sender = new MailAddress(mensagem.Remetente, "ProjetoLoja");
            message.From = new MailAddress(mensagem.Remetente, "ProjetoLoja");
            message.To.Add( new  MailAddress(mensagem.Destinatario) );
            message.Subject = mensagem.Assunto;
            smtp.Send(message);
>>>>>>> 5d93537732a0d508920f724faaf44664b4662214
        }
    }
}
