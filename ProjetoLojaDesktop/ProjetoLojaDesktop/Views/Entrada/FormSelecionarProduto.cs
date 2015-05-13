using System.Drawing.Imaging;
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
using System.IO;


namespace ProjetoLojaDesktop.Forms
{
    public partial class FormSelecionarProduto : Form
    {

        private ProjetoLojaEntities db;
        private ProdutoData produtoData;
        private Produto produto;

        public String CodProduto
        {
            get { return txtCodProduto.Text; }
            set { txtCodProduto.Text = value; }
        }

        public String NomeProduto
        {
            get { return txtProduto.Text; }
            set { txtProduto.Text = value; }
        }

        public FormSelecionarProduto()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            produtoData = new ProdutoData(db);

            inicializar();
        }

        private void inicializar()
        {
            inicializarDataGridViewListaProdutos();
        }

        private void inicializarDataGridViewListaProdutos()
        {
            dgvProdutos.DataSource = produtoData.todosProdutos();
        }

 
        private Produto getProdutoSelecionado()
        {
            DataGridViewRow p = dgvProdutos.CurrentRow;
            if (p != null)
                return (Produto)p.DataBoundItem;
            return null;
        }


        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.ShowDialog();
            inicializarDataGridViewListaProdutos();
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            produto = getProdutoSelecionado();
            txtCodProduto.Text = produto.idProduto.ToString();
            txtProduto.Text = produto.nome;
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
