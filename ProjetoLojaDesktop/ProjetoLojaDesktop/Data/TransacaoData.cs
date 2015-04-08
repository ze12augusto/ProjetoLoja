using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class TransacaoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<Transacao> transacoes;

        public TransacaoData(ProjetoLojaEntities _db)
        {
            db = _db;
            transacoes = db.CreateObjectSet<Transacao>();
        }

        public List<Transacao> todasTransacoes( int idTransacao )
        {
            var lista = from t in transacoes
                        where t.idTransacao == idTransacao
                        select t;
            return lista.ToList();
        }

        public string salvarTransacao(Transacao transacao)
        {
            string erro = null;
            try
            {
                if (transacao.idTransacao == 0)
                {
                    transacoes.AddObject(transacao);
                }
                else
                {
                    if (transacao.EntityState == System.Data.EntityState.Detached)
                    {
                        transacoes.Attach(transacao);
                    }
                    db.ObjectStateManager.ChangeObjectState(transacao, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirTransacao(Transacao transacao)
        {
            string erro = null;
            try
            {
                transacoes.DeleteObject(transacao);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

	    public Transacao obterTransacao (int id)
	    {
            var lista = from t in transacoes where t.idTransacao == id select t;
            return lista.ToList().FirstOrDefault();
		
	    }

        public string adicionarTransacao(Transacao transacao)
        {
            string erro = null;
            try
            {
                transacoes.AddObject(transacao);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarTransacao(Transacao transacao)
        {
            string erro = null;
            try
            {
                if (transacao.EntityState == System.Data.EntityState.Detached)
                {
                    db.Transacao.Attach(transacao);
                }
                db.ObjectStateManager.ChangeObjectState(transacao, System.Data.EntityState.Modified);
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
