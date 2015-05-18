﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class NotaFiscalData
    {
        private ProjetoLojaEntities1 db;
        private ObjectSet<NotaFiscal> NotasFiscais;

        public NotaFiscalData(ProjetoLojaEntities1 _db)
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
