using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class PessoaJuridicaData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<PessoaJuridica> pessoasjuridicas;

        public PessoaJuridicaData(ProjetoLojaEntities _db)
        {
            db = _db;
            pessoasjuridicas = db.CreateObjectSet<PessoaJuridica>();
        }

        public List<PessoaJuridica> todasPessoasJuridicas()
        {
            return pessoasjuridicas.ToList();
        }

        public string excluirPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            string erro = null;
            try
            {
                pessoasjuridicas.DeleteObject(pessoajuridica);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public PessoaJuridica obterPessoaJuridica(int id)
        {

            var lista = from c in pessoasjuridicas where c.idPessoa == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            string erro = null;
            try
            {


                pessoasjuridicas.AddObject(pessoajuridica);


                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            string erro = null;
            try
            {


                if (pessoajuridica.EntityState == System.Data.EntityState.Detached)
                {
                    pessoasjuridicas.Attach(pessoajuridica);
                }
                db.ObjectStateManager.ChangeObjectState(pessoajuridica, System.Data.EntityState.Modified);

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
