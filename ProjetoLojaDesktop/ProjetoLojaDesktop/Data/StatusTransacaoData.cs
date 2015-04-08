using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class StatusTransacaoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<StatusTransacao> status;

        public StatusTransacaoData(ProjetoLojaEntities _db)
        {
            db = _db;
            status = db.CreateObjectSet<StatusTransacao>();
	}

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

        public List<StatusTransacao> obterTodos() {
            var lista = from s in db.StatusTransacao
                        select s;

            return lista.ToList();
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
