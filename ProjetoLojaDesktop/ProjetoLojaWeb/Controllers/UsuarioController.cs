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
<<<<<<< HEAD
        private UsuarioData usuarioData;

        public UsuarioController()
        {
            usuarioData = new UsuarioData(new ProjetoLojaEntities());
        }
=======

>>>>>>> 5d93537732a0d508920f724faaf44664b4662214
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
<<<<<<< HEAD
            if (email == "")
            {
                ViewBag.Erro = "Digite seu e-mail";
                return View();
            }

            Usuario usuario = obterUsuarioPorEmail(email);

            MensagemEmail mensagem = new MensagemEmail();
            mensagem.Mensagem = String.Format("Olá!\n Você solicitou a recuperação de senha. Sua senha é: {0}", usuario.senha);
            mensagem.Assunto = "Recuperação da Senha do Projeto Loja";
            mensagem.Remetente = "feerpessoa26@gmail.com";
            mensagem.Destinatario = email;

            try
            {
                SMTPHelper.EnviarEmail(mensagem);
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
            }

            return View();
        }

        private Usuario obterUsuarioPorEmail(String email)
        {
            return usuarioData.obterUsuarioPorEmail(email);
        }
=======
            MensagemEmail mensagem = new MensagemEmail();
            mensagem.Mensagem = "enviando email para recuperação";
            mensagem.Assunto = "Recuperação da senha";
            mensagem.Remetente = "feerpessoa26@gmail.com";
            mensagem.Destinatario = "tuliohdvp@gmail.com";
            SMTPHelper.EnviarEmail(mensagem);

            return View();
        }
>>>>>>> 5d93537732a0d508920f724faaf44664b4662214
    }
}
