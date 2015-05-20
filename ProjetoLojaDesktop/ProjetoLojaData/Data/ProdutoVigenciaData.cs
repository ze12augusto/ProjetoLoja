using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

using System.Windows.Forms;

namespace ProjetoLojaData.Data
{
    public class ProdutoVigenciaData
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

        public ProdutoVigenciaPreco obterUltimaVigencia(int idProduto)
        {

            var lista = from vg in db.ProdutoVigenciaPreco

                        where vg.idProduto == idProduto && vg.dataVigenciaFim == null

                        select vg;

            return lista.ToList().FirstOrDefault();

        }



        public bool verificarVigenciaExistente(DateTime dataVigenciaInicio, int idProduto)
        {

            var lista = from vg in db.ProdutoVigenciaPreco

                        where vg.dataVigenciaInicio >= dataVigenciaInicio.Date && vg.idProduto == idProduto

                        select vg;

            if (lista.ToList().Count > 0)
            {

                return false;

            }

            return true;

        }

        public ProdutoVigenciaPreco obterVigenciaAtual(int idProduto)
        {

            DateTime agora = DateTime.Now.Date;

            var lista = from vg in db.ProdutoVigenciaPreco

                        where vg.idProduto == idProduto && vg.dataVigenciaInicio <= agora &&

                        (vg.dataVigenciaFim == null || vg.dataVigenciaFim >= agora)

                        select vg;

            if (lista.ToList().Count == 0)
                return null;

            return lista.ToList().FirstOrDefault();

        }

        public float obterPrecoVigenteAtual(int idProduto)
        {

            ProdutoVigenciaPreco atual = obterVigenciaAtual(idProduto);

            if (atual == null)
            {

                return 0;

            }

            return atual.preco;

        }
    }
}