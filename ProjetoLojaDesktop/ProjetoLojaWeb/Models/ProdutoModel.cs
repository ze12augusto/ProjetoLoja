using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoLojaData.Entity;

namespace ProjetoLojaWeb.Models
{
    public class ProdutoModel
    {
        private ProjetoLojaEntities db = new ProjetoLojaEntities();

        public List<Produto> TodosOsProdutos()
        {
            var lista = from p in db.Produto
                        select p;
            return lista.ToList();
        }

        public Produto obterProduto(int idProduto)
        {
            var lista = from p in db.Produto
                        where p.idProduto == idProduto
                        select p;
            return lista.ToList().FirstOrDefault();
            
        }
    }
}