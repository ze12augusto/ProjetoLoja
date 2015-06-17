using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaData.Data;
using ProjetoLojaData.Entity;
using ProjetoLojaWeb.Util;
using System.Web.Security;
using ProjetoLojaWeb.ViewModels;

namespace ProjetoLojaWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioData usuarioData;
        private TipoUsuarioData tipoUsuarioData;

        public UsuarioController()
        {
            ProjetoLojaEntities projetoLojaEntities = new ProjetoLojaEntities();
            usuarioData = new UsuarioData(projetoLojaEntities);
            tipoUsuarioData = new TipoUsuarioData(projetoLojaEntities);
        }
        
        public ActionResult NovoUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovoUsuario(Usuario usuario)
        {
            string retornoValidacao = validarUsuario(usuario);

            if (retornoValidacao != null)
            {
                ViewBag.Erro = retornoValidacao;
                return View(usuario);
            }
            else
            {
                usuario.idTipoUsuario = 1;
                usuario.Pessoa.idTipoPessoa = 1;

                string retornoSalvar = usuarioData.salvarUsuario(usuario.Pessoa);

                if (retornoSalvar != null)
                {
                    ViewBag.Erro = String.Format("Erro ao cadastrar o usuário: [{0}]", retornoSalvar);
                }
            }

            return Login(usuario);
        }

        private string validarUsuario(Usuario usuario) {
            if (usuario.senha == "")
                return "Digite sua senha";
            else if (usuario.Pessoa.email == "")
                return "Digite seu e-mail";
            else if (existeUsuarioComEsteEmail(usuario.Pessoa.email))
                return "Esse e-mail já está cadastrado. Use a recuperação de senha";
            return null;
        }

        public ActionResult RecuperarSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RecuperarSenha(string email)
        {
            if (email == "")
            {
                ViewBag.Erro = "Digite seu e-mail";
                return View();
            }

            Usuario usuario = obterUsuarioPorEmail(email);

            if (usuario == null)
            {
                ViewBag.Erro = "O e-mail digitado não é válido";
                return View();
            }

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

            return RedirectToAction("Login");
        }

        public ActionResult TrocarSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TrocarSenha(TrocaDePasswordViewModel trocaDeSenha)
        {
            string retornoValidacao = validarTrocaDeSenha(trocaDeSenha);

            if (retornoValidacao != null)
            {
                ViewBag.Erro = retornoValidacao;
                return View(trocaDeSenha);
            }

            Usuario usuario = obterUsuarioPorEmail(User.Identity.Name);
            usuario.senha = trocaDeSenha.SenhaNova;
            string retornoEditar = usuarioData.editarUsuario(usuario);

            if (retornoEditar != null)
            {
                ViewBag.Erro = retornoValidacao;
                return View(trocaDeSenha);
            }

            return Redirect("/");
        }

        private string validarTrocaDeSenha(TrocaDePasswordViewModel trocaDeSenha)
        {
            if (trocaDeSenha.SenhaAntiga == "")
                return "A senha antiga não pode ser vazia";
            if (trocaDeSenha.SenhaNova == "")
                return "A senha nova não pode ser vazia";
            if (trocaDeSenha.SenhaNova != trocaDeSenha.ConfirmacaoSenha)
                return "As senhas digitadas não conferem";

            Usuario usuario = obterUsuarioPorEmail(User.Identity.Name);
            if (usuario.senha != trocaDeSenha.SenhaAntiga)
                return "A senha antiga não confere";

            return null;
        }

        private Usuario obterUsuarioPorEmail(string email)
        {
            return usuarioData.obterUsuarioPorEmail(email);
        }

        private bool existeUsuarioComEsteEmail(string email)
        {
            return usuarioData.obterUsuarioPorEmail(email) != null;
        }

        public ActionResult Login()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            Usuario usuarioBanco = obterUsuarioPorEmail(usuario.Pessoa.email);

            if (usuarioBanco == null)
            {
                ViewBag.Erro = "Usuário inexistente!";
                return View(usuario);
            }
            if (usuario.senha != usuarioBanco.senha)
            {
                ViewBag.Erro = "Senha Incorreta!";
                return View(usuario);
            }

            foreach (TipoUsuario tu in tipoUsuarioData.todosTipoUsuarios())
            {
                if (!Roles.RoleExists(tu.descricao)) // Testa se a role não existe
                {
                    Roles.CreateRole(tu.descricao); // adiciona a role
                }
            }
            
            // Testa se o usuario não está na role associada ao banco
            if (!Roles.IsUserInRole(usuarioBanco.Pessoa.email, usuarioBanco.TipoUsuario.descricao)) 
            {
                Roles.AddUserToRole(usuarioBanco.Pessoa.email, usuarioBanco.TipoUsuario.descricao); // adiciona o usuario
            }

            FormsAuthentication.SetAuthCookie(usuarioBanco.Pessoa.email, true);
            return Redirect("/");
        }

        public ActionResult Logoff()
        {
            Usuario u = usuarioData.obterUsuarioPorEmail(User.Identity.Name);
           
            string emailUsuario = u.Pessoa.email;
            string tipoUsuario = u.TipoUsuario.descricao;

            if (Roles.IsUserInRole(emailUsuario, tipoUsuario))
            {
                Roles.RemoveUserFromRole(emailUsuario, tipoUsuario);
            }

            FormsAuthentication.SignOut();

            return Redirect("/");
        }

    }
}
