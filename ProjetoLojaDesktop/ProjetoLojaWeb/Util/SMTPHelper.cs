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
            smtp.Port = 465;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("feerpessoa26@gmail.com", "tulio123");
            MailMessage message = new MailMessage();
            message.Sender = new MailAddress(mensagem.Remetente, "ProjetoLoja");
            message.From = new MailAddress(mensagem.Remetente, "ProjetoLoja");
            message.To.Add( new  MailAddress(mensagem.Destinatario) );
            message.Subject = mensagem.Assunto;
            smtp.Send(message);
        }
    }
}
