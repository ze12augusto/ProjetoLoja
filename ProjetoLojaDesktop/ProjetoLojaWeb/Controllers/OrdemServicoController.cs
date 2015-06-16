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
        private OrdemDeServicoData osData = new OrdemDeServicoData();
        private UsuarioData usuarioData;

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
            var obj = new
            {
                id = detalhes.idTransacao,
                dataEntrada = detalhes.dataEntrada.ToShortDateString(),
                dataPrevistaEntrega = detalhes.dataPrevistaEntrega.ToShortDateString(),
                dataEntrega = (detalhes.dataEntrega == null) ? " " : detalhes.dataEntrega.Value.ToShortDateString(),
                descricao = detalhes.descricao,
                valor = detalhes.valor
            };

            return Json(obj);
        }

    }
}
