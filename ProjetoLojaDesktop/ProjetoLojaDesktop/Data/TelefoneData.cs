using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class TelefoneData
    {
        
        private ProjetoLojaEntities db;
        private ObjectSet<Telefone> telefones;

        public TelefoneData(ProjetoLojaEntities _db)
        {
            db = _db;
            telefones = db.CreateObjectSet<Telefone>();
        }

        public List<Telefone> todosTelefones()
        {
            return telefones.ToList();
        }

        public string salvarTelefone(Telefone telefone)
        {
            string erro = null;
            try
            {
                if (telefone.idTelefone == 0)
                {
                    telefones.AddObject(telefone);
                }
                else
                {
                    if (telefone.EntityState == System.Data.EntityState.Detached)
                    {
                        telefones.Attach(telefone);
                    }
                    db.ObjectStateManager.ChangeObjectState(telefone, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirTelefone(Telefone telefone)
        {
            string erro = null;
            try
            {
                telefones.DeleteObject(telefone);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        

	public Telefone obterTelefone (int id)
	{

        var lista = from c in telefones where c.idTelefone == id select c;
        return lista.ToList().FirstOrDefault();
		
	}

    public string adicionarCliente(Telefone telefone)
        {
            string erro = null;
            try
            {


                telefones.AddObject(telefone);
                
                
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

    public string editarTelefone(Telefone telefone)
        {
            string erro = null;
            try
            {


                if (telefone.EntityState == System.Data.EntityState.Detached)
                {
                    telefones.Attach(telefone);
                }
                db.ObjectStateManager.ChangeObjectState(telefone, System.Data.EntityState.Modified);
                
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

    public object obterObjTelefoneDaPessoa(int idPessoa)
    {
        var lista = from c in telefones
                    where c.idPessoa == idPessoa
                    select new { c.idPessoa, c.idTelefone, c.numero, c.TipoTelefone.descricao };
        return lista.ToList();
    }

    }
}
