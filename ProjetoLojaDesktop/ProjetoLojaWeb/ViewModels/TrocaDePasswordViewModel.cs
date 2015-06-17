using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLojaWeb.ViewModels
{
    public class TrocaDePasswordViewModel
    {
        public string SenhaAntiga { get; set; }
        public string SenhaNova { get; set; }
        public string ConfirmacaoSenha { get; set; }
    }
}