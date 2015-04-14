using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class CidadeData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<Cidade> cidades;

        public CidadeData(ProjetoLojaEntities _db)
        {
            db = _db;
            cidades = db.CreateObjectSet<Cidade>();
        }

        public List<Cidade> todasCidades()
        {
            return cidades.ToList();
        }

        public string excluirCidade(Cidade cidade)
        {
            string erro = null;
            try
            {
                cidades.DeleteObject(cidade);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public Cidade obterCidade(int id)
        {
            var lista = from c in cidades where c.idCidade == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarCidade(Cidade cidade)
        {
            string erro = null;
            try
            {
                cidades.AddObject(cidade);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarCidade(Cidade cidade)
        {
            string erro = null;
            try
            {
                if (cidade.EntityState == System.Data.EntityState.Detached)
                {
                    cidades.Attach(cidade);
                }
                db.ObjectStateManager.ChangeObjectState(cidade, System.Data.EntityState.Modified);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public Cidade obterCidade(string nomeCidade)
        {
            var lista = from c in cidades where c.nome.Equals(nomeCidade) select c;
            return lista.ToList().FirstOrDefault();
        }

    }
}
