﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class PessoaFisicaData
    {
         private ProjetoLojaEntities1 db;

         public PessoaFisicaData(ProjetoLojaEntities1 db)
         {

            this.db = db;
        }

        public PessoaFisica obterPessoaFisica(int id)
        {
            var Lista = from p in db.PessoaFisica
                        where p.idPessoa == id
                        select p;

            return Lista.ToList().FirstOrDefault();

        }

        public List<PessoaFisica> todasPessoaFisicas() {
            var Lista = from p in db.PessoaFisica
                        select p;

            return Lista.ToList();
        }

        public string adicionarPessoaFisica(PessoaFisica m) {
            string erro = null;
            try
            {
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
    }
}
