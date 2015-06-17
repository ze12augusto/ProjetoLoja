using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaData.Data;
using ProjetoLojaData.Entity;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace ProjetoLojaDesktop.Views.Relatorios.Produto
{
    public partial class FormProduto : Form
    {
        ProjetoLojaEntities db;
        private ProdutoData produtoData;

        public FormProduto()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            produtoData = new ProdutoData(db);
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            var lista = produtoData.todosProdutos();
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString() + "Views\\Relatorios\\Produto\\ProdutoReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptProduto.ReportSource = rpt;
        }
    }
}
