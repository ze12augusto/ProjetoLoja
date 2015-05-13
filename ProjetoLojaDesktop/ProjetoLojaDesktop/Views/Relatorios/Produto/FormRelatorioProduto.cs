using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Entity;
using ProjetoLojaDesktop.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjetoLojaDesktop.Views.Relatorios.Produto
{
    public partial class FormRelatorioProduto : Form
    {
        private TransacaoProdutoData transacaoProdutoData;
        private ProdutoData produtoData;
        private MarcaData marcaData;
        private ModeloData modeloData;

        public FormRelatorioProduto()
        {
            InitializeComponent();
            transacaoProdutoData = new TransacaoProdutoData(new ProjetoLojaEntities());
            produtoData = new ProdutoData(new ProjetoLojaEntities());
            marcaData = new MarcaData();
            modeloData = new ModeloData();
            Marca marcaVazia = new Marca { idMarca = 0, descricao = "Todas as Marcas" };
            List<Marca> todasMarcas = marcaData.todasMarcas();
            todasMarcas.Add(marcaVazia);
            cbxMarca.DataSource = todasMarcas;
            cbxMarca.DisplayMember = "descricao";
            cbxMarca.ValueMember = "idMarca";
            cbxMarca.SelectedValue = 0;
            Modelo modeloVazio = new Modelo { idModelo = 0, descricao = "Todos os Modelos" };
            List<Modelo> todosModelos = modeloData.todasModelos();
            todosModelos.Add(modeloVazio);
            cbxModelo.DataSource = todosModelos;
            cbxModelo.DisplayMember = "descricao";
            cbxModelo.ValueMember = "idModelo";
            cbxModelo.SelectedValue = 0;
        }


        private void FormRelatorioProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var lista = from p in produtoData.todosProdutos()
                        join mo in modeloData.todasModelos() on p.idModelo equals mo.idModelo
                        join ma in marcaData.todasMarcas() on mo.idMarca equals ma.idMarca
                        where transacaoProdutoData.estoqueProduto(p.idProduto) <= 0 &&
                        p.nome.Contains(txtDescProduto.Text) &&
                        ((int)cbxMarca.SelectedValue == 0 || ma.idMarca == (int)cbxMarca.SelectedValue) &&
                        ((int)cbxModelo.SelectedValue == 0 || mo.idModelo == (int)cbxModelo.SelectedValue)
                        select new

                        {
                            IdProduto = p.idProduto,
                            Nome = p.nome,
                            Marca = ma.descricao,
                            Modelo = mo.descricao,
                            QuantidadeMinima = p.qtdMinima,
                            QuantidadeAtual = p.qtdAtual
                        };

            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "C:\\Documents and Settings\\a11025687\\Desktop\\ProjetoLoja-master\\ProjetoLojaDesktop\\ProjetoLojaDesktop\\Views\\Relatorios\\Produto\\ProdutoReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptProduto.ReportSource = rpt;
            tbcRelatorioProdutos.SelectedIndex = 1;
        }

    }
}
