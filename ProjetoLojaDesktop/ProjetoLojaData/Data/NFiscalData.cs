using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class NFiscalData
    {
        private ProjetoLojaEntities db;

        public NFiscalData()
        {

            db = new ProjetoLojaEntities();
        }

        public NotaFiscal obterNotaFiscal(int id)
        {
            var Lista = from n in db.NotaFiscal
                        where n.idTransacao == id
                        select n;

            return Lista.ToList().FirstOrDefault();

        }

        public List<NotaFiscal> todasNotasFiscais()
        {
            var Lista = from n in db.NotaFiscal
                        select n;

            return Lista.ToList();
        }

        public List<NotaFiscal> buscaNotaFiscal(int numeroNotaFiscal)
        {
            var Lista = from n in db.NotaFiscal
                        where n.idTransacao == numeroNotaFiscal
                        select n;

            return Lista.ToList();
        }

        public string adicionarNotaFiscal(NotaFiscal n)
        {
            string erro = null;
            try
            {
                db.NotaFiscal.AddObject(n);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarNotaFiscal(NotaFiscal n)
        {
            string erro = null;
            try
            {

                if (n.EntityState == System.Data.EntityState.Detached)
                    db.NotaFiscal.Attach(n);
                db.ObjectStateManager.ChangeObjectState(n, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirNotaFiscal(NotaFiscal n)
        {
            string erro = null;
            try
            {
                db.NotaFiscal.DeleteObject(n);
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
