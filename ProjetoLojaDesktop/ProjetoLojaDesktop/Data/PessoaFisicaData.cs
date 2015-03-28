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

        public PessoaFisicaData(ProjetoLojaEntities _db) {

            db = _db;
        }

        public PessoaFisica obterPessoaFisica(int id)
        {
            var Lista = from p in db.PessoaFisica
                        where p.idPessoa == id
                        select p;

            return Lista.ToList().FirstOrDefault();

        }

        public bool verificarCPF(int idPessoa, string cpf)
        {
            if (idPessoa == 0)
            {
                var lista = from p in db.PessoaFisica
                            where p.CPF == cpf
                            select p;

                if (lista.Count() == 0)
                    return true;
                else
                    return false;
            }
            else
            {
                var lista = from p in db.PessoaFisica
                            where p.idPessoa == idPessoa && p.CPF == cpf
                            select p;

                if (lista.Count() == 1)
                    return true;
                else
                    return false;
            }
        }

        public List<PessoaFisica> todasPessoaFisicasPorTipo( int idTipoPessoa ) {
            var Lista = from p in db.PessoaFisica
                        where p.Pessoa.TipoPessoa.idTipoPessoa == idTipoPessoa
                        select p;

            return Lista.ToList();
        }

        public List<PessoaFisica> buscarPessoasFisicasPorNome(string nome)
        {
            var Lista = from p in db.PessoaFisica
                        where p.Pessoa.nome == nome
                        select p;

            return Lista.ToList();
        }

        public string adicionarPessoaFisica(PessoaFisica m) {
            string erro = null;
            try
            {
                db.Pessoa.AddObject(m.Pessoa);
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
