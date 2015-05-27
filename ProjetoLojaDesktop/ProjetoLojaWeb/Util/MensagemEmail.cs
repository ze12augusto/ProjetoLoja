using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoLojaWeb.Util
{
    public class MensagemEmail
    {
        public String Remetente { get; set; }
        public String Destinatario { get; set; }
        public String Mensagem { get; set; }
        public String Assunto { get; set; }
    }
}
