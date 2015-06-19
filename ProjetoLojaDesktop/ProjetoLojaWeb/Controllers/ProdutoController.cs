using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaWeb.Models;
using ProjetoLojaData.Entity;
using ProjetoLojaData.Data;

namespace ProjetoLojaWeb.Controllers
{
    //[Authorize]
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/ProdutoData
        private ProdutoData produtoModel = new ProdutoData();
        private ImagemProdutoData ipModel = new ImagemProdutoData();
        private ProdutoVigenciaData pvp = new ProdutoVigenciaData(new ProjetoLojaEntities());


        public ActionResult Index()
        {
            List<ProdutoImagem> imagensProduto = new List<ProdutoImagem>();
            foreach (var produto in produtoModel.todosProdutos())
            {
                ProdutoImagem imgProduto = new ProdutoImagem();
                imgProduto.imagem = ipModel.obterCaminhosImagem(produto.idProduto).FirstOrDefault();
                imgProduto.id = produto.idProduto;
                imagensProduto.Add(imgProduto);
            }
            ViewBag.ListaDeCaminhos = imagensProduto;
            ViewBag.ProdutoVigenciaPreco = pvp.todosProdutoVigencia();
            return View(produtoModel.todosProdutos());        
        }

        public ActionResult Details(int id)
        {
            Produto p;
            if (id == 0)
            {
                p = new Produto();
            }
            else
            {
                p = produtoModel.obterProduto(id);
            }
           
            ViewBag.Imagem = ipModel.obterCaminhosImagem(id);
            ViewBag.PrimeiraImagem = ipModel.obterCaminhosImagem(id).FirstOrDefault();
            ViewBag.ProdutoVigenciaPreco = pvp.obterProdutoVigenciaPorIdProduto(id);
            return View(p);
        }

    }
}
