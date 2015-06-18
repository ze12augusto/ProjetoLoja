using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class TransacaoProductData
    {
    private ProjetoLojaEntities db;
        private ObjectSet<TransacaoProduto> transacaoProdutos;

        public TransacaoProductData(ProjetoLojaEntities _db)
        {
            db = _db;
            transacaoProdutos = db.CreateObjectSet<TransacaoProduto>();
        }

        public List<TransacaoProduto> todasTransacoes()
        {
            return transacaoProdutos.ToList();
        }

        public string salvarTransacaoProduto(TransacaoProduto transacaoProduto)
        {
            string erro = null;
            try
            {
                if (transacaoProduto.idTransacao == 0)
                {
                    transacaoProdutos.AddObject(transacaoProduto);
                }
                else
                {
                    if (transacaoProduto.EntityState == System.Data.EntityState.Detached)
                    {
                        transacaoProdutos.Attach(transacaoProduto);
                    }
                    db.ObjectStateManager.ChangeObjectState(transacaoProduto, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirTransacaoProduto(TransacaoProduto transacaoProduto)
        {
            string erro = null;
            try
            {
                transacaoProdutos.DeleteObject(transacaoProduto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        

	public TransacaoProduto obterTransacaoProduto (int id)
	{
        var lista = from t in transacaoProdutos where t.idTransacao == id select t;
        return lista.ToList().FirstOrDefault();
	}

    public TransacaoProduto obterTransacaoPorId(int id)
    {
        var lista = from t in transacaoProdutos where t.idTransacao == id select t;
        return lista.ToList().FirstOrDefault();
    }

    public string adicionarTransacaoProduto(TransacaoProduto transacaoProduto)
        {
            string erro = null;
            try
            {


                transacaoProdutos.AddObject(transacaoProduto);
                
                
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
                    transacaoProdutos.Attach(transacaoProduto);
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
    }
}