using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class TipoPessoaData
    {
        private ProjetoLojaEntities db;

        public TipoPessoaData(ProjetoLojaEntities _db) {
            db = _db;
        }

        public TipoPessoa obterTipoPessoa( string tipo )
        {
            var Lista = from t in db.TipoPessoa
                        where t.descricao == tipo
                        select t;

            return Lista.ToList().FirstOrDefault();

        }
    }
}
