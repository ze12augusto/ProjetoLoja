using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Data
{
    class TipoUsuarioData
    {
        private ProjetoLojaEntities db;

        public TipoUsuarioData(ProjetoLojaEntities _db)
        {
            db = _db;
        }

        public List<TipoUsuario> obterTodos()
        {
            var Lista = from t in db.TipoUsuario
                        select t;

            return Lista.ToList();
        }

        public TipoUsuario obterTipoUsuario( string tipo )
        {
            var Lista = from t in db.TipoUsuario
                        where t.descricao == tipo
                        select t;

            return Lista.ToList().FirstOrDefault();
        }
    }
}