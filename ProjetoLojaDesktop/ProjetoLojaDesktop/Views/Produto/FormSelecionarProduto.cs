using System;
using System.Linq;
using System.Windows.Forms;
using ProjetoLojaDesktop.Data;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Views
{
    public partial class FormSelecionarProduto : Form
    {
        private ProdutoData produtoData;
        private Produto produtoSelecionado;

        public FormSelecionarProduto()
        {
            InitializeComponent();
            instanciarObjetos();
            preencherTabelaDeProdutos();
        }

        private void instanciarObjetos()
        {
            produtoData = new ProdutoData(new ProjetoLojaEntities());
        }

        private void preencherTabelaDeProdutos()
        {
            dgvProdutos.DataSource = produtoData.todosProdutos();
            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[5].Visible = false;
            dgvProdutos.Columns[6].Visible = false;
            dgvProdutos.Columns[7].Visible = false;
            dgvProdutos.Columns[8].Visible = false;
            dgvProdutos.Columns[9].Visible = false;
            dgvProdutos.Columns[10].Visible = false;
            dgvProdutos.Columns[1].HeaderText = "Nome";
            dgvProdutos.Columns[2].HeaderText = "Descrição";
            dgvProdutos.Columns[3].HeaderText = "Quantidade Mínima";
            dgvProdutos.Columns[4].HeaderText = "Quantidade Atual";
        }

        private Produto getProdutoSelecionadoNaTabela()
        {
            DataGridViewRow p = dgvProdutos.CurrentRow;
            if ( p != null )
                return (Produto) p.DataBoundItem;

            return null;
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = getProdutoSelecionadoNaTabela();

            if (produto == null)
            {
                MessageBox.Show("Você precisa selecionar um produto antes.");
            }

            produtoSelecionado = produto;
            Dispose();
        }

        private void atualizarTabela()
        {
            var lista = from p in produtoData.todosProdutos()
                        where p.nome.ToLower().Contains(txtPesquisa.Text.ToLower())
                        select p;

            dgvProdutos.DataSource = lista.ToList();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            atualizarTabela();
        }

        public Produto getProdutoSelecionado()
        {
            return produtoSelecionado;
        }
    }
}
