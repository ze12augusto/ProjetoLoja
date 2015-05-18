using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class TipoTelefoneData
    {
        private ProjetoLojaEntities1 db;
        private ObjectSet<TipoTelefone> tipoTelefones;

        public TipoTelefoneData(ProjetoLojaEntities1 _db)
        {
            db = _db;
            tipoTelefones = db.CreateObjectSet<TipoTelefone>();
        }

        public List<TipoTelefone> todosTiposTelefones()
        {
            return tipoTelefones.ToList();
        }

        public string excluirTipoTelefone(TipoTelefone tipoTelefone)
        {
            string erro = null;
            try
            {
                tipoTelefones.DeleteObject(tipoTelefone);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public TipoTelefone obterTipoTelefone(int id)
        {
            var lista = from c in tipoTelefones where c.idTipoTelefone == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarTipoTelefone(TipoTelefone tipoTelefone)
        {
            string erro = null;
            try
            {
                tipoTelefones.AddObject(tipoTelefone);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarTipoTelefone(TipoTelefone tipoTelefone)
        {
            string erro = null;
            try
            {
                if (tipoTelefone.EntityState == System.Data.EntityState.Detached)
                {
                    tipoTelefones.Attach(tipoTelefone);
                }
                db.ObjectStateManager.ChangeObjectState(tipoTelefone, System.Data.EntityState.Modified);

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
