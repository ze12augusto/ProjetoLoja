using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class PessoaData
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

        public List<Pessoa> todasPessoaFisicasPorTipo(int idTipoPessoa)
        {
            var Lista = from p in db.Pessoa
                        where p.TipoPessoa.idTipoPessoa == idTipoPessoa
                        select p;

            return Lista.ToList();
        }

        public List<Pessoa> buscarPessoasFisicasPorNome(string nome)
        {
            var Lista = from p in db.Pessoa
                        where p.nome.Contains(nome)
                        select p;

             return Lista.ToList();
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
    }
}
