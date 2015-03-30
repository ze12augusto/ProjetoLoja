using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class UsuarioData
    {
        private ProjetoLojaEntities db;

        public UsuarioData(ProjetoLojaEntities _db) {

            db = _db;
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
    }

}
