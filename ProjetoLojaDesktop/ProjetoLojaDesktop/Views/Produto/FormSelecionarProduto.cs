using System;
using System.Linq;
using System.Windows.Forms;
using ProjetoLojaData.Data;
using ProjetoLojaData.Entity;
using ProjetoLojaDesktop.Enums;

namespace ProjetoLojaDesktop.Views
{
    public partial class FormSelecionarProduto : Form
    {
        private ProdutoData produtoData;
        private TipoTransacaoEnum tipoTransacao;
        private TransacaoProduto transacaoProduto;
        private ProdutoVigenciaData produtoVigenciaData;
        private Produto produtoSelecionado;
        private float valorAtualProduto;

        public FormSelecionarProduto( TipoTransacaoEnum tipoTransacao )
        {
            InitializeComponent();
            instanciarObjetos();
            preencherTabelaDeProdutos();

            this.tipoTransacao = tipoTransacao;
            if (tipoTransacao == TipoTransacaoEnum.ENTRADA)
            {
                lblGenerico.Text = "Valor Unitário";
            }
        }

        private void instanciarObjetos()
        {
            ProjetoLojaEntities db = new ProjetoLojaEntities();
            produtoData = new ProdutoData(db);
            transacaoProduto = new TransacaoProduto();
            produtoVigenciaData = new ProdutoVigenciaData(db);
            valorAtualProduto = 0;
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
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Você precisa selecionar um produto antes.");
            }

            transacaoProduto.idProduto = produtoSelecionado.idProduto;
            transacaoProduto.qtdProduto = Int32.Parse(txtQuantidade.Text);
            if (tipoTransacao == TipoTransacaoEnum.SAIDA)
                transacaoProduto.valorUnitario = (decimal)valorAtualProduto;
            else
                transacaoProduto.valorUnitario = decimal.Parse(txtGenerico.Text);

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

        public TransacaoProduto getTransacaoProduto()
        {
            return transacaoProduto;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (produtoSelecionado != null)
            {
                valorAtualProduto = produtoVigenciaData.obterPrecoVigenteAtual(produtoSelecionado.idProduto); ;

                if (tipoTransacao == TipoTransacaoEnum.SAIDA)
                {
                    if (txtQuantidade.Text != "")
                        txtGenerico.Text = (Int32.Parse(txtQuantidade.Text) * valorAtualProduto).ToString();
                    else
                        txtGenerico.Text = "";
                }
            }
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (getProdutoSelecionadoNaTabela() == null)
            {
                MessageBox.Show("Selecione um produto antes de colocar a quantidade.");
                dgvProdutos.Focus();
            }
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            produtoSelecionado = getProdutoSelecionadoNaTabela();

            if( produtoSelecionado != null ) { 

                if (tipoTransacao == TipoTransacaoEnum.ENTRADA)
                {
                    txtGenerico.Enabled = true;
                }
                else
                {
                    txtGenerico.Enabled = false;
                }

                txtQuantidade.Enabled = true;

                if (produtoSelecionado != null)
                    valorAtualProduto = produtoVigenciaData.obterPrecoVigenteAtual(produtoSelecionado.idProduto);
            }
        }
    }
}
