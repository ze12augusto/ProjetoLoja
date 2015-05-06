using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class TransacaoProdutoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<TransacaoProduto> transacoesProduto;

        public TransacaoProdutoData(ProjetoLojaEntities _db)
        {
            db = _db;
            transacoesProduto = db.CreateObjectSet<TransacaoProduto>();
        }

        public List<TransacaoProduto> todostransacoesProduto()
        {
            return transacoesProduto.ToList();
        }

        public string excluirTransacaoProduto(TransacaoProduto transacoeProduto)
        {
            string erro = null;
            try
            {
                transacoesProduto.DeleteObject(transacoeProduto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public TransacaoProduto obterTransacaoProduto(int id)
        {
            var lista = from t in transacoesProduto where t.idTransacao == id select t;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarTransacaoProduto(TransacaoProduto transacaoProduto)
        {
            string erro = null;
            try
            {
                transacoesProduto.AddObject(transacaoProduto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarTransacaoProduto(TransacaoProduto transacaoProduto)
        {
            string erro = null;
            try
            {
                if (transacaoProduto.EntityState == System.Data.EntityState.Detached)
                {
                    transacoesProduto.Attach(transacaoProduto);
                }
                db.ObjectStateManager.ChangeObjectState(transacaoProduto, System.Data.EntityState.Modified);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public float estoqueProduto(int idProduto)
        {
            ObjectSet<TransacaoProduto> transacoesProdutos = db.CreateObjectSet<TransacaoProduto>();
            var transacoes = from t in transacoesProdutos
                             where t.idProduto == idProduto
                             select t.qtdProduto;
            return transacoes.ToList().Sum();
        }

        public TransacaoProduto obterTransacaoPorId(int id)
        {
            var lista = from t in transacoesProduto where t.idTransacao == id select t;
            return lista.ToList().FirstOrDefault();
        }
    }
}
