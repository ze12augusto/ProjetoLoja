using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class ProdutoVigenciaData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<ProdutoVigenciaPreco> produtoVigencias;

        public ProdutoVigenciaData(ProjetoLojaEntities _db)
        {
            db = _db;
            produtoVigencias = db.CreateObjectSet<ProdutoVigenciaPreco>();
        }

        public List<ProdutoVigenciaPreco> todosProdutoVigencia()
        {
            return produtoVigencias.ToList();
        }

        public string excluirProdutoVigencia(ProdutoVigenciaPreco produtoVigencia)
        {
            string erro = null;
            try
            {
                produtoVigencias.DeleteObject(produtoVigencia);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public ProdutoVigenciaPreco obterProdutoVigencia(int id)
        {
            var lista = from c in produtoVigencias where c.idVigencia == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarProdutoVigencia(ProdutoVigenciaPreco produtoVigencia)
        {
            string erro = null;
            try
            {
                produtoVigencias.AddObject(produtoVigencia);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarProdutoVigencia(ProdutoVigenciaPreco produtoVigencia)
        {
            string erro = null;
            try
            {
                if (produtoVigencia.EntityState == System.Data.EntityState.Detached)
                {
                    produtoVigencias.Attach(produtoVigencia);
                }
                db.ObjectStateManager.ChangeObjectState(produtoVigencia, System.Data.EntityState.Modified);

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
