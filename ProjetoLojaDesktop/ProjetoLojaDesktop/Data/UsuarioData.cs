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

        public UsuarioData() {

            db = new ProjetoLojaEntities();
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
    }

}
