using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class UF_Data
    {
        private ProjetoLojaEntities db;
        private ObjectSet<UnidadeFederativa> unidadeFederativas;

        public UF_Data(ProjetoLojaEntities _db)
        {
            db = _db;
            unidadeFederativas = db.CreateObjectSet<UnidadeFederativa>();
        }

        public List<UnidadeFederativa> todasUnidadesFederativas()
        {
            return unidadeFederativas.ToList();
        }

        public string salvarUnidadeFederativa(UnidadeFederativa unidadeFederativa)
        {
            string erro = null;
            try
            {
                if (unidadeFederativa.UF == "")
                {
                    unidadeFederativas.AddObject(unidadeFederativa);
                }
                else
                {
                    if (unidadeFederativa.EntityState == System.Data.EntityState.Detached)
                    {
                        unidadeFederativas.Attach(unidadeFederativa);
                    }
                    db.ObjectStateManager.ChangeObjectState(unidadeFederativa, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirUnidadeFederativa(UnidadeFederativa unidadeFederativa)
        {
            string erro = null;
            try
            {
                unidadeFederativas.DeleteObject(unidadeFederativa);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        

	public UnidadeFederativa obterUnidadeFederativa (string id)
	{

        var lista = from c in unidadeFederativas where c.UF == id select c;
        return lista.ToList().FirstOrDefault();
	}

    public string adicionarUnidadeFederativa(UnidadeFederativa unidadeFederativa)
        {
            string erro = null;
            try
            {


                unidadeFederativas.AddObject(unidadeFederativa);
                
                
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

    public string editarUnidadeFederativa(UnidadeFederativa unidadeFederativa)
        {
            string erro = null;
            try
            {


                if (unidadeFederativa.EntityState == System.Data.EntityState.Detached)
                {
                    unidadeFederativas.Attach(unidadeFederativa);
                }
                db.ObjectStateManager.ChangeObjectState(unidadeFederativa, System.Data.EntityState.Modified);
                
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
