using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class TipoPagamentoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<TipoPagamento> tiposPagamento;

        public TipoPagamentoData(ProjetoLojaEntities _db)
        {
            db = _db;
            tiposPagamento = db.CreateObjectSet<TipoPagamento>();
        }

        public List<TipoPagamento> todosTipoPagamento()
        {
            return tiposPagamento.ToList();
        }

        public string excluirTipoPagamento(TipoPagamento tipoPagamento)
        {
            string erro = null;
            try
            {
                tiposPagamento.DeleteObject(tipoPagamento);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public TipoPagamento obterTipoPagamento(int id)
        {
            var lista = from p in tiposPagamento where p.idTipoPagamento == id select p;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarTipoPagamento(TipoPagamento tipoPagamento)
        {
            string erro = null;
            try
            {
                tiposPagamento.AddObject(tipoPagamento);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarTipoPagamento(TipoPagamento tipoPagamento)
        {
            string erro = null;
            try
            {
                if (tipoPagamento.EntityState == System.Data.EntityState.Detached)
                {
                    tiposPagamento.Attach(tipoPagamento);
                }
                db.ObjectStateManager.ChangeObjectState(tipoPagamento, System.Data.EntityState.Modified);

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
