using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaData.Entity;
using System.Data.Objects;

namespace ProjetoLojaData.Data
{
    public class PessoaData
    {
        private ProjetoLojaEntities db;
        private ObjectSet<Pessoa> pessoas;

        public PessoaData(ProjetoLojaEntities _db)
        {
            db = _db;
            pessoas = db.CreateObjectSet<Pessoa>();
        }

        public List<Pessoa> todasPessoas()
        {
            return pessoas.ToList();
        }

        public List<Pessoa> todasPessoaFisicasPorTipo(int tipo)
        {
            var lista = from p in db.Pessoa
                        where p.idTipoPessoa == tipo
                        select p;

            return lista.ToList();
        }

        public List<Pessoa> buscarPessoasFisicasPorNome( string nome )
        {
            var lista = from p in db.Pessoa
				        where p.nome.ToLower().Contains(nome.ToLower())
                        select p;

            return lista.ToList();
        }

        public string excluirPessoa(Pessoa pessoa)
        {
            string erro = null;
            try
            {
                pessoas.DeleteObject(pessoa);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public Pessoa obterPessoa(int id)
        {

            var lista = from c in pessoas where c.idPessoa == id select c;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarPessoa(Pessoa pessoa)
        {
            string erro = null;
            try
            {


                pessoas.AddObject(pessoa);


                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarPessoa(Pessoa pessoa)
        {
            string erro = null;
            try
            {


                if (pessoa.EntityState == System.Data.EntityState.Detached)
                {
                    pessoas.Attach(pessoa);
                }
                db.ObjectStateManager.ChangeObjectState(pessoa, System.Data.EntityState.Modified);

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirPessoaFisica(Pessoa pessoa)
        {
            string erro = null;
            try
            {
                foreach (Endereco endereco in pessoa.Endereco.ToList())
                {
                    db.Endereco.DeleteObject(endereco);
                }
                foreach (Telefone telefone in pessoa.Telefone.ToList())
                    db.Telefone.DeleteObject(telefone);
                db.PessoaFisica.DeleteObject(pessoa.PessoaFisica);
                db.Usuario.DeleteObject(pessoa.Usuario);
                db.Pessoa.DeleteObject(pessoa);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string adicionarPessoaFisica(Pessoa pessoa)
        {
            string erro = null;

            try
            {
                if (pessoa.idPessoa == 0)
                {
                    db.Pessoa.AddObject(pessoa);
                    db.PessoaFisica.AddObject(pessoa.PessoaFisica);
                }
                else
                {
                    if (pessoa.EntityState == System.Data.EntityState.Detached)
                    {
                        db.Pessoa.Attach(pessoa);
                    }

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa, System.Data.EntityState.Modified);

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa.PessoaFisica, System.Data.EntityState.Modified);
                }

                db.SaveChanges();
            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string adicionarPessoaJuridica(Pessoa pessoa)
        {
            string erro = null;

            try
            {
                if (pessoa.idPessoa == 0)
                {
                    db.Pessoa.AddObject(pessoa);
                    db.PessoaJuridica.AddObject(pessoa.PessoaJuridica);
                }
                else
                {
                    if (pessoa.EntityState == System.Data.EntityState.Detached)
                    {
                        db.Pessoa.Attach(pessoa);
                    }

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa, System.Data.EntityState.Modified);

                    db.ObjectStateManager.ChangeObjectState(
                        pessoa.PessoaJuridica, System.Data.EntityState.Modified);
                }

                db.SaveChanges();
            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public List<Pessoa> pesquisarPessoaPorNome(string nome)
        {
            var lista = from p in todasPessoas()
                        where p.nome.ToLower().Contains(nome.ToLower())
                        select p;
            return lista.ToList();
        }
    }
}
