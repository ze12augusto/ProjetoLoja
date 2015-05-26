using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class OrdemDeServicoData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<OrdemServico> ordensDeServico;

        public OrdemDeServicoData(ProjetoLojaEntities _db)
        {
            db = _db;
            ordensDeServico = db.CreateObjectSet<OrdemServico>();
        }

        public List<OrdemServico> todasOrdensDeServico()
        {
            return ordensDeServico.ToList();
        }

        public string excluirOrdemDeServico(OrdemServico ordemDeServico)
        {
            string erro = null;
            try
            {
                ordensDeServico.DeleteObject(ordemDeServico);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public OrdemServico obterOrdemDeServico(int id)
        {
            var lista = from o in ordensDeServico where o.idTransacao == id select o;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarOrdemDeServico(OrdemServico ordemDeServico)
        {
            string erro = null;
            try
            {
                ordensDeServico.AddObject(ordemDeServico);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarOrdemDeSevico(OrdemServico ordemDeServico)
        {
            string erro = null;
            try
            {
                if (ordemDeServico.EntityState == System.Data.EntityState.Detached)
                {
                    ordensDeServico.Attach(ordemDeServico);
                }
                db.ObjectStateManager.ChangeObjectState(ordemDeServico, System.Data.EntityState.Modified);

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
