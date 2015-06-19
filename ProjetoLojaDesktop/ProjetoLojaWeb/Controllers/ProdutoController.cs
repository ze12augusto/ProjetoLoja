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
    [Authorize]
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/ProdutoData
        private ProdutoData produtoModel = new ProdutoData();
        private ImagemProdutoData ipModel = new ImagemProdutoData();

        public ActionResult Index(int id)
        {
            return View(produtoModel.todosProdutos());
            ViewBag.PrimeiraImagem = ipModel.obterCaminhosImagem(id).FirstOrDefault();
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
            return View(p);
        }

    }
}
