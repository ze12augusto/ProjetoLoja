using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class ProdutoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<Produto> produtos;

        public ProdutoData(ProjetoLojaEntities _db)
        {
            db = _db;
            produtos = db.CreateObjectSet<Produto>();
        }

        public List<Produto> todosProdutos()
        {
            return produtos.ToList();
        }

        public string excluirProduto(Produto produto)
        {
            string erro = null;
            try
            {
                produtos.DeleteObject(produto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public Produto obterProduto(int id)
        {
            var lista = from c in produtos where c.idProduto == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarProduto(Produto produto)
        {
            string erro = null;
            try
            {
                produtos.AddObject(produto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarProduto(Produto produto)
        {
            string erro = null;
            try
            {
                if (produto.EntityState == System.Data.EntityState.Detached)
                {
                    produtos.Attach(produto);
                }
                db.ObjectStateManager.ChangeObjectState(produto, System.Data.EntityState.Modified);

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
