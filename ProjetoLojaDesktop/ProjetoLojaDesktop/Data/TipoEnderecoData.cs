using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class TipoEnderecoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<TipoEndereco> tipoenderecos ;

        public TipoEnderecoData(ProjetoLojaEntities _db)
        {
            db = _db;
            tipoenderecos = db.CreateObjectSet<TipoEndereco>();
        }

        public List<TipoEndereco> todostipoenderecos()
        {
            return tipoenderecos.ToList();
        }

        public string excluirTipoEndereco(TipoEndereco tipoendereco)
        {
            string erro = null;
            try
            {
                tipoenderecos.DeleteObject(tipoendereco);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public TipoEndereco obeterTipoEndereco(int id)
        {

            var lista = from c in tipoenderecos where c.idTipoEndereco == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarTipoEndereco(TipoEndereco tipoendereco)
        {
            string erro = null;
            try
            {


                tipoenderecos.AddObject(tipoendereco);


                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarTipoEndereco(TipoEndereco tipoendereco)
        {
            string erro = null;
            try
            {


                if (tipoendereco.EntityState == System.Data.EntityState.Detached)
                {
                    tipoenderecos.Attach(tipoendereco);
                }
                db.ObjectStateManager.ChangeObjectState(tipoendereco, System.Data.EntityState.Modified);

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
