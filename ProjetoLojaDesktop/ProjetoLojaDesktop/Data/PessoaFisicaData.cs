using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class PessoaFisicaData
    {
         private ProjetoLojaEntities db;

        public PessoaFisicaData() {

            db = new ProjetoLojaEntities();
        }

        public PessoaFisica obterPessoaFisica(int id)
        {
            var Lista = from p in db.PessoaFisica
                        where p.idPessoa == id
                        select p;

            return Lista.ToList().FirstOrDefault();

        }

        public List<PessoaFisica> todasPessoaFisicas() {
            var Lista = from p in db.PessoaFisica
                        select p;

            return Lista.ToList();
        }

        public string adicionarPessoaFisica(PessoaFisica m) {
            string erro = null;
            try
            {
                db.PessoaFisica.AddObject(m);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarPessoaFisica(PessoaFisica p)
        {
            string erro = null;
            try
            {

                if (p.EntityState == System.Data.EntityState.Detached)
                    db.PessoaFisica.Attach(p);
                db.ObjectStateManager.ChangeObjectState(p, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirPessoaFisica(PessoaFisica p)
        {
            string erro = null;
            try
            {
                db.PessoaFisica.DeleteObject(p);
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
