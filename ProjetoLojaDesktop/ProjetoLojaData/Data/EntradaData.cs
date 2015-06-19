using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaData.Entity;

namespace ProjetoLojaData.Data
{
    public class EntradaData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<Transacao> entradas;

        public EntradaData(ProjetoLojaEntities _db)
        {
            db = _db;
            entradas = db.CreateObjectSet<Transacao>();
        }

        public List<Transacao> todasEntradas()
        {
            return entradas.ToList();
        }

        public string excluirProduto(Transacao entrada)
        {
            string erro = null;
            try
            {
                entradas.DeleteObject(entrada);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirEntrada(Transacao t)
        {
            string erro = null;
            try
            {
                db.Transacao.DeleteObject(t);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public Transacao obterEntrada(int id)
        {
            var lista = from t in entradas where t.idTransacao == id && t.idTipoTransacao == 'E' select t;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarEntrada(Transacao entrada)
        {
            string erro = null;
            try
            {
                entradas.AddObject(entrada);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarEntrada(Transacao entrada)
        {
            string erro = null;
            try
            {
                if (entrada.EntityState == System.Data.EntityState.Detached)
                {
                    entradas.Attach(entrada);
                }
                db.ObjectStateManager.ChangeObjectState(entrada, System.Data.EntityState.Modified);

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
