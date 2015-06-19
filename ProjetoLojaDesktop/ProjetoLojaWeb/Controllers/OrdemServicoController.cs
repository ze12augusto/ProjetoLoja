using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLojaData.Data;
using ProjetoLojaData.Entity;

namespace ProjetoLojaWeb.Controllers
{
    [Authorize]
    public class OrdemServicoController : Controller
    {
        private OrdemDeServicoData osData;
        private TransacaoData transacaoData;
        private ProdutoData produtoData;
        private UsuarioData usuarioData;

        public OrdemServicoController()
        {
            ProjetoLojaEntities db = new ProjetoLojaEntities();
            usuarioData = new UsuarioData(db);
            osData = new OrdemDeServicoData();
            transacaoData = new TransacaoData(db);
            produtoData = new ProdutoData();
        }

        public ActionResult Index()
        {
            Usuario u = usuarioData.obterUsuarioPorEmail(User.Identity.Name);
            int id = u.idPessoa;
            var lista = osData.listarOrdensDeServicoPorUsuarioLogado(id);
            return View(lista);
        }

        public JsonResult DetalhaOrdemServicoPorId(int id)
        {
            var detalhes = osData.obterOrdemDeServico(id);

            var produtos = from t in transacaoData.obterTransacao(id).TransacaoProduto
                       join p in produtoData.todosProdutos()
                           on t.idProduto equals p.idProduto
                       select new
                       {
                           descricao = p.descricao,
                           quantidade = t.qtdProduto,
                           valorUni = t.valorUnitario,
                           total = t.qtdProduto * t.valorUnitario
                       };

            var obj = new
            {
                id = detalhes.idTransacao,
                dataEntrada = detalhes.dataEntrada.ToShortDateString(),
                dataPrevistaEntrega = detalhes.dataPrevistaEntrega.ToShortDateString(),
                dataEntrega = (detalhes.dataEntrega == null) ? " " : detalhes.dataEntrega.Value.ToShortDateString(),
                descricao = detalhes.descricao,
                valor = detalhes.valor,
                produtos = produtos
            };

            return Json(obj);
        }

    }
}
