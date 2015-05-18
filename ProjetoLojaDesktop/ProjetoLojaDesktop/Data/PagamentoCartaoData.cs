using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class PagamentoCataoData
    {
        private ProjetoLojaEntities1 db;
        private ObjectSet<PagamentoCartao> pagamentosCartao;

        public PagamentoCataoData(ProjetoLojaEntities1 _db)
        {
            db = _db;
            pagamentosCartao = db.CreateObjectSet<PagamentoCartao>();
        }

        public List<PagamentoCartao> todosPagamentosCartao()
        {
            return pagamentosCartao.ToList();
        }

        public string excluirpagamentosCartao(PagamentoCartao pagamentoCartao)
        {
            string erro = null;
            try
            {
                pagamentosCartao.DeleteObject(pagamentoCartao);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public PagamentoCartao obterpagamentoCartao(int id)
        {
            var lista = from p in pagamentosCartao where p.idTransacao == id select p;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarPagamentosCartao(PagamentoCartao pagamentoCartao)
        {
            string erro = null;
            try
            {
                pagamentosCartao.AddObject(pagamentoCartao);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarPagamentosCartao(PagamentoCartao pagamentoCartao)
        {
            string erro = null;
            try
            {
                if (pagamentoCartao.EntityState == System.Data.EntityState.Detached)
                {
                    pagamentosCartao.Attach(pagamentoCartao);
                }
                db.ObjectStateManager.ChangeObjectState(pagamentoCartao, System.Data.EntityState.Modified);

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
