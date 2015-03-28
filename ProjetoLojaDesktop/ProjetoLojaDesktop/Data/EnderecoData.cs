using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class EnderecoData
    {
        
        private ProjetoLojaEntities db;
        private ObjectSet<Endereco> enderecos;

        public EnderecoData(ProjetoLojaEntities _db)
        {
            db = _db;
            enderecos = db.CreateObjectSet<Endereco>();
        }

        public List<Endereco> todosEnderecos( int idPessoa )
        {
            var lista = from e in enderecos
                        where e.idPessoa == idPessoa
                        select e;
            return lista.ToList();
        }

        public string salvarEndereco(Endereco endereco)
        {
            string erro = null;
            try
            {
                if (endereco.idEndereco == 0)
                {
                    enderecos.AddObject(endereco);
                }
                else
                {
                    if (endereco.EntityState == System.Data.EntityState.Detached)
                    {
                        enderecos.Attach(endereco);
                    }
                    db.ObjectStateManager.ChangeObjectState(endereco, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirEndereco(Endereco endereco)
        {
            string erro = null;
            try
            {
                db.Endereco.DeleteObject(endereco);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

	public Endereco obterEndereco (int id)
	{

        var lista = from c in enderecos where c.idEndereco == id select c;
        return lista.ToList().FirstOrDefault();
	}

    public string adicionarEndereco(Endereco endereco)
        {
            string erro = null;
            try
            {
                enderecos.AddObject(endereco);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

    public string editarEndereco(Endereco endereco)
        {
            string erro = null;
            try
            {
                if (endereco.EntityState == System.Data.EntityState.Detached)
                {
                    db.Endereco.Attach(endereco);
                }
                db.ObjectStateManager.ChangeObjectState(endereco, System.Data.EntityState.Modified);
                
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
