using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class PagamentoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<Pagamento> pagamentos;

        public PagamentoData(ProjetoLojaEntities _db)
        {
            db = _db;
            pagamentos = db.CreateObjectSet<Pagamento>();
        }

        public List<Pagamento> todosPagamentos()
        {
            return pagamentos.ToList();
        }

        public string excluirPagamento(Pagamento pagamento)
        {
            string erro = null;
            try
            {
                pagamentos.DeleteObject(pagamento);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public Pagamento obterPagamento(int id)
        {
            var lista = from p in pagamentos where p.idTransacao == id select p;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarPagamento(Pagamento pagamento)
        {
            string erro = null;
            try
            {
                pagamentos.AddObject(pagamento);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarPagamento(Pagamento pagamento)
        {
            string erro = null;
            try
            {
                if (pagamento.EntityState == System.Data.EntityState.Detached)
                {
                    pagamentos.Attach(pagamento);
                }
                db.ObjectStateManager.ChangeObjectState(pagamento, System.Data.EntityState.Modified);

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
