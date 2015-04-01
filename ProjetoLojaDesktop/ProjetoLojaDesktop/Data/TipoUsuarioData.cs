using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class TipoUsuarioData
    {
        private ProjetoLojaEntities db;

        public TipoUsuarioData(ProjetoLojaEntities db)
        {

            this.db = db;
        }

        public TipoUsuario obterTipoUsuario(int id)
        {
            var Lista = from t in db.TipoUsuario
                        where t.idTipoUsuario == id
                        select t;

            return Lista.ToList().FirstOrDefault();

        }

        public List<TipoUsuario> todasTipoUsuarios() {
            var Lista = from t in db.TipoUsuario
                        select t;

            return Lista.ToList();
        }

        public string adicionarTipoUsuario(TipoUsuario t) {
            string erro = null;
            try
            {
                db.TipoUsuario.AddObject(t);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarTipoUsuario(TipoUsuario t)
        {
            string erro = null;
            try
            {

                if (t.EntityState == System.Data.EntityState.Detached)
                    db.TipoUsuario.Attach(t);
                db.ObjectStateManager.ChangeObjectState(t, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirTipoUsuario(TipoUsuario t)
        {
            string erro = null;
            try
            {
                db.TipoUsuario.DeleteObject(t);
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