using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class NotaFiscalData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<NotaFiscal> NotasFiscais;

        public NotaFiscalData(ProjetoLojaEntities _db)
        {
            db = _db;
            NotasFiscais = db.CreateObjectSet<NotaFiscal>();
        }

        public List<NotaFiscal> todasNotFiscal()
        {
            return NotasFiscais.ToList();
        }

        public string excluirNotaFiscal(NotaFiscal notaFiscal)
        {
            string erro = null;
            try
            {
                NotasFiscais.DeleteObject(notaFiscal);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public NotaFiscal obterNotaFiscal(int id)
        {
            var lista = from n in NotasFiscais where n.idTransacao == id select n;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarNotaFiscal(NotaFiscal notaFiscal)
        {
            string erro = null;
            try
            {
                NotasFiscais.AddObject(notaFiscal);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarNotaFiscal(NotaFiscal notaFiscal)
        {
            string erro = null;
            try
            {
                if (notaFiscal.EntityState == System.Data.EntityState.Detached)
                {
                    NotasFiscais.Attach(notaFiscal);
                }
                db.ObjectStateManager.ChangeObjectState(notaFiscal, System.Data.EntityState.Modified);

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
