using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class StatusTransacaoData
    {
        private ProjetoLojaEntities db;

        public StatusTransacaoData() {

            db = new ProjetoLojaEntities();
        }

        public StatusTransacao obterStatusTransacaoData(int id)
        {
            var Lista = from s in db.StatusTransacao
                        where s.idStatus == id
                        select s;

            return Lista.ToList().FirstOrDefault();

        }

        public List<StatusTransacao> todosStatusTransacao() {
            var Lista = from s in db.StatusTransacao
                        select s;

            return Lista.ToList();
        }

        public List<StatusTransacao> buscaStatusTransacao(String texto)
        {
            var Lista = from s in db.StatusTransacao
                        where s.descricao.Contains(texto)
                        select s;

            return Lista.ToList();
        }

        public string adicionarStatusTransacao(StatusTransacao s) {
            string erro = null;
            try
            {
                 db.StatusTransacao.AddObject(s);
                 db.SaveChanges();
   
            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarStatusTransacao(StatusTransacao s)
        {
            string erro = null;
            try
            {

                if (s.EntityState == System.Data.EntityState.Detached)
                    db.StatusTransacao.Attach(s);
                db.ObjectStateManager.ChangeObjectState(s, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirStatusTransacao(StatusTransacao s)
        {
            string erro = null;
            try
            {
                db.StatusTransacao.DeleteObject(s);
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
