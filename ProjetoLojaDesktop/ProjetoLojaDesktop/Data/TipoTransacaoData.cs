using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class TipoTransacaoData
    {
        private ProjetoLojaEntities1 db;

        public TipoTransacaoData() {

            db = new ProjetoLojaEntities1();
        }

        public TipoTransacao ObterTipoTransacaoData(int id)
        {
            var Lista = from t in db.TipoTransacao
                        where t.idTipoTransacao == id
                        select t;

            return Lista.ToList().FirstOrDefault();

        }

        public List<TipoTransacao> todosTipoTransacao() {
            var Lista = from t in db.TipoTransacao
                        select t;

            return Lista.ToList();
        }

        public List<TipoTransacao> buscaTipoTransacao(String texto)
        {
            var Lista = from t in db.TipoTransacao
                        where t.descricao.Contains(texto)
                        select t;

            return Lista.ToList();
        }

        public string adicionarTipoTransacao(TipoTransacao t) {
            string erro = null;
            try
            {
                 db.TipoTransacao.AddObject(t);
                 db.SaveChanges();
   
            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarTipoTransacao(TipoTransacao t)
        {
            string erro = null;
            try
            {

                if (t.EntityState == System.Data.EntityState.Detached)
                    db.TipoTransacao.Attach(t);
                db.ObjectStateManager.ChangeObjectState(t, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirTipoTransacao(TipoTransacao t)
        {
            string erro = null;
            try
            {
                db.TipoTransacao.DeleteObject(t);
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
