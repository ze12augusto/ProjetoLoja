using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class MarcaData
    {
        private ProjetoLojaEntities db;

        public MarcaData() {

            db = new ProjetoLojaEntities();
        }

        public Marca obterMarca(int id)
        {
            var Lista = from m in db.Marca
                        where m.idMarca == id
                        select m;

            return Lista.ToList().FirstOrDefault();

        }

        public List<Marca> todasMarcas() {
            var Lista = from m in db.Marca
                        select m;

            return Lista.ToList();
        }

        public List<Marca> buscaMarcas( string busca )
        {
            var Lista = from m in db.Marca
                        where m.descricao == busca
                        select m;

            return Lista.ToList();
        }

        public string adicionarMarca(Marca m) {
            string erro = null;
            try
            {
                db.Marca.AddObject(m);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarMarca(Marca m)
        {
            string erro = null;
            try
            {

                if (m.EntityState == System.Data.EntityState.Detached)
                    db.Marca.Attach(m);
                db.ObjectStateManager.ChangeObjectState(m, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirMarca(Marca m)
        {
            string erro = null;
            try
            {
                db.Marca.DeleteObject(m);
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
