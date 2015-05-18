using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaDesktop.Entity;
using System.Data.Objects;

namespace ProjetoLojaDesktop.Data
{
    class CaracteristicaProdutoData
    {
        private ProjetoLojaEntities1 db;

        public CaracteristicaProdutoData() {

            db = new ProjetoLojaEntities1();
        }

        public CaracteristicaProduto obterCaracteristica(int idCaracteristica, int idProduto)
        {
            var Lista = from c in db.CaracteristicaProduto
                        where c.idCaracteristica == idCaracteristica && c.idProduto == idProduto
                        select c;

            return Lista.ToList().FirstOrDefault();

        }

        public List<CaracteristicaProduto> todasCaracteristicas() {
            var Lista = from c in db.CaracteristicaProduto
                        select c;

            return Lista.ToList();
        }

        public string adicionarCaracteristica(CaracteristicaProduto c) {
            string erro = null;
            try
            {
                db.CaracteristicaProduto.AddObject(c);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarCaracteristica(CaracteristicaProduto c)
        {
            string erro = null;
            try
            {

                if (c.EntityState == System.Data.EntityState.Detached)
                    db.CaracteristicaProduto.Attach(c);
                db.ObjectStateManager.ChangeObjectState(c, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirCaracteristica(CaracteristicaProduto c)
        {
            string erro = null;
            try
            {
                db.CaracteristicaProduto.DeleteObject(c);
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
