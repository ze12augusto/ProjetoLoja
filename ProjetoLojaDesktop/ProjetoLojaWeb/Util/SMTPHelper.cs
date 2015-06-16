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
        }
    }
}
