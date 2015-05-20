using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaData.Data;
using ProjetoLojaData.Entity;
using ProjetoLojaWeb.Util;

namespace ProjetoLojaWeb.Controllers
{
    public class UsuarioController : Controller
    {

        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult RecuperarSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarSenha(String email)
        {
            MensagemEmail mensagem = new MensagemEmail();
            mensagem.Mensagem = "enviando email para recuperação";
            mensagem.Assunto = "Recuperação da senha";
            mensagem.Remetente = "feerpessoa26@gmail.com";
            mensagem.Destinatario = "tuliohdvp@gmail.com";
            SMTPHelper.EnviarEmail(mensagem);

            return View();
        }
    }
}
