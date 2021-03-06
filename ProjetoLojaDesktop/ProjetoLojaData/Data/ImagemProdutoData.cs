﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjetoLojaData.Entity;
using System.IO;

namespace ProjetoLojaData.Data
{
    public class ImagemProdutoData
    {
        private ProjetoLojaEntities db;

        public ImagemProdutoData()
        {
            db = new ProjetoLojaEntities();
        }

        public List<ImagemProduto> obterImagemProduto(int id)
        {
            var Lista = from i in db.ImagemProduto
                        where i.idAlbumFoto == id
                        select i;

            return Lista.ToList();
        }

        public List<ImagemProduto> todasImagemProdutos()
        {
            var Lista = from i in db.ImagemProduto
                        select i;

            return Lista.ToList();
        }

        public string adicionarImagemProduto(ImagemProduto i)
        {
            string erro = null;
            try
            {
                db.ImagemProduto.AddObject(i);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string editarImagemProduto(ImagemProduto i)
        {
            string erro = null;
            try
            {

                if (i.EntityState == System.Data.EntityState.Detached)
                    db.ImagemProduto.Attach(i);
                db.ObjectStateManager.ChangeObjectState(i, System.Data.EntityState.Modified);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }

        public string excluirImagemProduto(ImagemProduto i)
        {
            string erro = null;
            try
            {
                db.ImagemProduto.DeleteObject(i);
                db.SaveChanges();

            }

            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return erro;
        }


        public List<string> obterCaminhosImagem(int idProduto)
        {
            var lista = from i in db.ImagemProduto
                        where i.idProduto == idProduto
                        select "../../Assets/Img/" + i.caminho + ".png";
            return lista.ToList();
        }
    }
}