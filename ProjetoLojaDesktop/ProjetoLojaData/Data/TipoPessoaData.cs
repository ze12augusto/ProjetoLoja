using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class TipoPessoaData
    {
         private ProjetoLojaEntities db;

        public TipoPessoaData() {

            db = new ProjetoLojaEntities();
        }

        public TipoPessoa obterTipoPessoa(int id)
        {
            var Lista = from t in db.TipoPessoa
                        where t.idTipoPessoa == id
                        select t;

            return Lista.ToList().FirstOrDefault();

        }

        public List<TipoPessoa> todasTipoPessoas() {
            var Lista = from t in db.TipoPessoa
                        select t;

            return Lista.ToList();
        }

        public string adicionarTipoPessoa(TipoPessoa t) {
            string erro = null;
            try
            {
                db.TipoPessoa.AddObject(t);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarTipoPessoa(TipoPessoa t)
        {
            string erro = null;
            try
            {

                if (t.EntityState == System.Data.EntityState.Detached)
                    db.TipoPessoa.Attach(t);
                db.ObjectStateManager.ChangeObjectState(t, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirTipoPessoa(TipoPessoa t)
        {
            string erro = null;
            try
            {
                db.TipoPessoa.DeleteObject(t);
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
