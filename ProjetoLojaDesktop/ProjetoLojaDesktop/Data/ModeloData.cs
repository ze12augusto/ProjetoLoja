using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class ModeloData
    {
        private ProjetoLojaEntities db;

        public ModeloData() {

            db = new ProjetoLojaEntities();
        }

        public Modelo obterModelo(int idModelo, int idMarca)
        {
            var Lista = from o in db.Modelo
                        where o.idMarca == idMarca && o.idModelo == idModelo
                        select o;

            return Lista.ToList().FirstOrDefault();

        }

        public List<Modelo> todasModelos() {
            var Lista = from o in db.Modelo
                        select o;

            return Lista.ToList();
        }

        public List<Modelo> buscaModelos(string busca)
        {
            var Lista = from m in db.Modelo
                        where m.descricao == busca
                        select m;

            return Lista.ToList();
        }

        public string adicionarModelo(Modelo o) {
            string erro = null;
            try
            {
                db.Modelo.AddObject(o);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarModelo(Modelo o)
        {
            string erro = null;
            try
            {

                if (o.EntityState == System.Data.EntityState.Detached)
                    db.Modelo.Attach(o);
                db.ObjectStateManager.ChangeObjectState(o, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirModelo(Modelo o)
        {
            string erro = null;
            try
            {
                db.Modelo.DeleteObject(o);
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
