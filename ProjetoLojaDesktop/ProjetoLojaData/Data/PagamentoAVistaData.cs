using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class PagamentoAVistaData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<PagamentoAVista> pagamentosAVista;

        public PagamentoAVistaData(ProjetoLojaEntities _db)
        {
            db = _db;
            pagamentosAVista = db.CreateObjectSet<PagamentoAVista>();
        }

        public List<PagamentoAVista> todosPagamentosAVista()
        {
            return pagamentosAVista.ToList();
        }

        public string excluirPagamentoAVista(PagamentoAVista pagamentoAVista)
        {
            string erro = null;
            try
            {
                pagamentosAVista.DeleteObject(pagamentoAVista);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public PagamentoAVista obterPagamentoAVista(int id)
        {
            var lista = from p in pagamentosAVista where p.idTransacao == id select p;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarPagamentoAVista(PagamentoAVista pagamentoAVista)
        {
            string erro = null;
            try
            {
                pagamentosAVista.AddObject(pagamentoAVista);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarPagamentoAVista(PagamentoAVista pagamentoAVista)
        {
            string erro = null;
            try
            {
                if (pagamentoAVista.EntityState == System.Data.EntityState.Detached)
                {
                    pagamentosAVista.Attach(pagamentoAVista);
                }
                db.ObjectStateManager.ChangeObjectState(pagamentoAVista, System.Data.EntityState.Modified);

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
