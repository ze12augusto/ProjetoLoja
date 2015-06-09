using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class UsuarioData
    {
        private ProjetoLojaEntities db;

        public UsuarioData(ProjetoLojaEntities db)
        {

            this.db = db;
        }

        public Usuario obterUsuario(int idPessoa, int idTipoUsuario)
        {
            var Lista = from u in db.Usuario
                        where u.idPessoa == idPessoa && u.idTipoUsuario == idTipoUsuario
                        select u;

            return Lista.ToList().FirstOrDefault();

        }

        public List<Usuario> todasUsuarios() {
            var Lista = from u in db.Usuario
                        select u;

            return Lista.ToList();
        }

        public string adicionarUsuario(Usuario u) {
            string erro = null;
            try
            {
                db.Usuario.AddObject(u);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string salvarUsuario(Pessoa pessoa)
        {
            string erro = null;

            try
            {
                if (pessoa.idPessoa == 0)
                {
                    db.Pessoa.AddObject(pessoa);
                    db.Usuario.AddObject(pessoa.Usuario);
                    db.PessoaFisica.AddObject(pessoa.PessoaFisica);
                }
                else
                {
                    if (pessoa.EntityState == System.Data.EntityState.Detached)
                    {
                        db.Pessoa.Attach(pessoa);
                    }

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa, System.Data.EntityState.Modified);

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa.PessoaFisica, System.Data.EntityState.Modified);

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa.Usuario, System.Data.EntityState.Modified);
                }

                db.SaveChanges();
            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarUsuario(Usuario u)
        {
            string erro = null;
            try
            {

                if (u.EntityState == System.Data.EntityState.Detached)
                    db.Usuario.Attach(u);
                db.ObjectStateManager.ChangeObjectState(u, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirUsuario(Usuario u)
        {
            string erro = null;
            try
            {
                db.Usuario.DeleteObject(u);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public Usuario obterUsuarioPorlogin(string cpf)
        {
            var lista = from u in db.Usuario
                        join p in db.Pessoa on u.idPessoa equals p.idPessoa
                        join pf in db.PessoaFisica on p.idPessoa equals pf.idPessoa
                        where pf.CPF == cpf
                        select u;
            return lista.ToList().FirstOrDefault();
        }
    }

}
