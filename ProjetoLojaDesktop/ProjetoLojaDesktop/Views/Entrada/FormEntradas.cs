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
    public partial class FormEntradas : Form
    {
        private ProjetoLojaEntities1 db;

        private Transacao entrada;
        private EntradaData entradaData;
        private PessoaJuridicaData pessoaJuridicaData;
        private TransacaoProduto transacaoProduto;
        private Produto produto;
        private ProdutoData produtoData;
        private NotaFiscal notaFiscal;
        private NotaFiscalData notaFiscalData;
        private MarcaData marcaData;
        private ModeloData modeloData;
        private PessoaData pessoaData;
        private TransacaoProdutoData transacaoProdutoData;
        private Boolean novoProduto;
        private Boolean novaEntrada;
        private Decimal totalNota;


        public FormEntradas()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities1();
            entradaData = new EntradaData(db);
            produtoData = new ProdutoData(db);
            pessoaJuridicaData = new PessoaJuridicaData(db);
            transacaoProdutoData = new TransacaoProdutoData(db);
            pessoaData = new PessoaData(db);
            marcaData = new MarcaData();
            modeloData = new ModeloData();
            notaFiscalData = new NotaFiscalData(db);
            produto = new Produto();
            novoProduto = false;
            novaEntrada = false;
            inicializar();
        }

        private void inicializar()
        {
            inicializarDataGridViewListaEntradas();
        }

        private void inicializarDataGridViewListaEntradas()
        {
            dgvEntradas.DataSource = entradaData.todasEntradas();
            dgvEntradas.Columns[0].HeaderText = "Entrada";
            dgvEntradas.Columns[1].HeaderText = "Data de Entrada";
            dgvEntradas.Columns[4].HeaderText = "Fornecedor";
            dgvEntradas.Columns[7].HeaderText = "N.º Nota Fiscal";
            dgvEntradas.Columns[2].Visible = false;
            dgvEntradas.Columns[3].Visible = false;
            dgvEntradas.Columns[5].Visible = false;
            dgvEntradas.Columns[6].Visible = false;
            dgvEntradas.Columns[8].Visible = false;
            dgvEntradas.Columns[9].Visible = false;
            dgvEntradas.Columns[10].Visible = false;
            dgvEntradas.Columns[11].Visible = false;
            dgvEntradas.Columns[12].Visible = false;
            dgvEntradas.Columns[13].Visible = false;
            dgvEntradas.Columns[14].Visible = false;
        }

        private void inicializarDataGridViewTransacaoProdutos(int id)
        {
            dgvProdutosEntrada.DataSource = transacaoProdutoData.obterTransacaoPorId(entrada.idTransacao);
            dgvProdutosEntrada.Columns[0].Visible = false;
            dgvProdutosEntrada.Columns[5].Visible = false;
            dgvProdutosEntrada.Columns[1].HeaderText = "Código do Produto";
            dgvProdutosEntrada.Columns[2].HeaderText = "Quantidade";
            dgvProdutosEntrada.Columns[3].HeaderText = "Valor Unitário";
            dgvProdutosEntrada.Columns[4].HeaderText = "Produto";
        }

        private Transacao getEntradaSelecionada()
        {
            DataGridViewRow e = dgvEntradas.CurrentRow;
            if (e != null)
                return (Transacao)e.DataBoundItem;
            return null;
        }

        private NotaFiscal getNotaFiscalSelecionada()
        {
            DataGridViewRow n = dgvEntradas.CurrentRow;
            if (n != null)
                return (NotaFiscal)n.DataBoundItem;
            return null;
        }

        public void atualizarTabelaProdutosTransacao()
        {
            var lista = from tp in transacaoProdutoData.todostransacoesProduto()
                        where tp.idTransacao == entrada.idTransacao
                        select tp;
            dgvProdutosEntrada.DataSource = lista.ToList();
        }


        private void calcularTotalNota()
        {
            foreach (DataGridViewRow col in dgvProdutosEntrada.Rows)
            {
                totalNota = totalNota + (Convert.ToDecimal(col.Cells[2].Value) * Convert.ToDecimal(col.Cells[3].Value));
            }
            lblTotalNota.Text = Convert.ToString(string.Format("{0:0.00}", totalNota));
        }

        private void btnVisualizarEntrada_Click(object sender, EventArgs e)
        {
            resetarCampos();
            exibirCampos();
            tabListaEntradas.SelectedIndex = 1;
            entrada =  getEntradaSelecionada();
            totalNota = 0;
            if (entrada != null)
            {
                txtNumEntrada.Text = entrada.idTransacao.ToString();
                DateTime dataEntrada =  Convert.ToDateTime(entrada.data);
                txtDataEntrada.Text = dataEntrada.ToString("d");
                txtCodFornecedor.Text = entrada.idCliente.ToString();
                txtFornecedor.Text = pessoaData.obterPessoa(entrada.idCliente).nome;
                txtNotaFiscal.Text = notaFiscalData.obterNotaFiscal(entrada.idTransacao).numero;
                DateTime dataNotaFiscal = Convert.ToDateTime(notaFiscalData.obterNotaFiscal(entrada.idTransacao).dataHora);
                txtDataNotaFiscal.Text = dataNotaFiscal.ToString("d");
                atualizarTabelaProdutosTransacao();
                calcularTotalNota();
            }
            else
            {
                MessageBox.Show("Nenhuma entrada selecionada!");
            }
        }

        private TransacaoProduto getTransacaoSelecionada()
        {
            DataGridViewRow tp = dgvProdutosEntrada.CurrentRow;
            if (tp != null)
                return (TransacaoProduto)tp.DataBoundItem;
            return null;
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {

            string erro = transacaoProdutoData.excluirTransacaoProduto(getTransacaoSelecionada());

            if (erro == null)
            {
                MessageBox.Show("Produto excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir produto!");
            }
            
            atualizarTabelaProdutosTransacao();
            return;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!validarCamposProdutos())
            {
                return;
            }
            if (!validarCamposNovaEntrada())
            {
                return;
            }
            obterDadosTransacao();
            string erro = null;
            if (novoProduto == true)
            {
                erro = transacaoProdutoData.adicionarTransacaoProduto(transacaoProduto);
            }
            else
            {
                erro = transacaoProdutoData.editarTransacaoProduto(transacaoProduto);
            }
            if (erro == null)
            {
                MessageBox.Show("Produto adicionado com sucesso!");
                novoProduto = false;
                btnSelProduto.Enabled = false;
                atualizarTabelaProdutosTransacao();
                totalNota = 0;
                calcularTotalNota();
            }
            else
            {
                MessageBox.Show("Erro ao editar transação." + erro);
            }
        }

        private void obterDadosTransacao()
        {
            if (novoProduto)
            {
                transacaoProduto = new TransacaoProduto();
            }
            transacaoProduto.idTransacao = Convert.ToInt32(txtNumEntrada.Text);
            transacaoProduto.idProduto = Convert.ToInt32(txtCodProduto.Text);
            transacaoProduto.qtdProduto = Convert.ToInt32(txtQuantidade.Text);
            transacaoProduto.valorUnitario = Convert.ToDecimal(txtValorUnitario.Text);
        }

        private bool validarCamposProdutos()
        {
            if (txtProduto.Text == "" || txtProduto.Text == null)
            {
                MessageBox.Show("Selecione um produto");
                return false;
            }
            if (txtQuantidade.Text == "" || txtQuantidade.Text == null || txtQuantidade.Text == "0")
            {
                MessageBox.Show("Informe a quantidade");
                return false;
            }
            if (txtValorUnitario.Text == "" || txtValorUnitario.Text == null || txtValorUnitario.Text == "0")
            {
                MessageBox.Show("Informe o valor unitário");
                return false;
            }
            
            return true;
        }

        private bool validarCamposNovaEntrada()
        {
            if (txtDataEntrada.Text == "  /  /" || txtDataEntrada.Text == null)
            {
                MessageBox.Show("Informe Data de Entrada da Nota Fiscal");
                return false;
            }
            if (txtDataNotaFiscal.Text == "  /  /" || txtDataNotaFiscal.Text == null)
            {
                MessageBox.Show("Informe Data da Nota Fiscal");
                return false;
            }
            if (txtNotaFiscal.Text == "" || txtNotaFiscal.Text == null)
            {
                MessageBox.Show("Informe o Número da Nota Fiscal");
                return false;
            }
            if (txtFornecedor.Text == "" || txtFornecedor.Text == null)
            {
                MessageBox.Show("Selecione o Fornecedor");
                return false;
            }
            return true;
        }



        private void resetarCampos()
        {
            transacaoProduto = new TransacaoProduto();
            btnSelProduto.Enabled = false;
            novoProduto = false;
            txtNotaFiscal.Text = "";
            txtDataNotaFiscal.Text = "";
            txtNumEntrada.Text = "";
            txtFornecedor.Text = "";
            txtCodFornecedor.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtValorUnitario.Text = "";
            lblTotalProduto.Text = "0";
            dgvProdutosEntrada.DataSource = null;
            txtDataEntrada.Text = "";
        }

        private void resetarCamposProduto()
        {
            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtValorUnitario.Text = "";
        }

        private void criaNovaEntrada()
        {
            entrada = new Transacao();
            entrada.data = Convert.ToDateTime(txtDataEntrada.Text);
            entrada.desconto = 0;
            entrada.idTipoTransacao = 1;
            entrada.idCliente = Convert.ToInt32(txtCodFornecedor.Text);
            entrada.idFuncionario = 1;
            entrada.idStatus = 1;
        }

        private void obterNotaFiscal()
        {
            notaFiscal = new NotaFiscal();
            notaFiscal.idTransacao = Convert.ToInt32(txtNumEntrada.Text);
            notaFiscal.dataHora = Convert.ToDateTime(txtDataNotaFiscal.Text);
            notaFiscal.numero = txtNotaFiscal.Text;
        }

        private void esconderCampos()
        {
            btnRegistrarEntrada.Visible = true;
            lblWarn.Visible = true;
            btnAddProduto.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluirProduto.Enabled = false;
            lblCodProduto.Visible = false;
            txtCodProduto.Visible = false;
            lblNomeProduto.Visible = false;
            txtProduto.Visible = false;
            btnSelProduto.Visible = false;
            lblQuantidade.Visible = false;
            txtQuantidade.Visible = false;
            lblValorUnitario.Visible = false;
            txtValorUnitario.Visible = false;
            lblValorTotalProduto.Visible = false;
            lblTotalProduto.Visible = false;
            lblValorTotalNota.Visible = false;
            lblTotalNota.Visible = false;
        }

        private void exibirCampos()
        {
            btnRegistrarEntrada.Visible = false;
            lblWarn.Visible = false;
            btnAddProduto.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluirProduto.Enabled = true;
            lblCodProduto.Visible = true;
            txtCodProduto.Visible = true;
            lblNomeProduto.Visible = true;
            txtProduto.Visible = true;
            btnSelProduto.Visible = true;
            lblQuantidade.Visible = true;
            txtQuantidade.Visible = true;
            lblValorUnitario.Visible = true;
            txtValorUnitario.Visible = true;
            lblValorTotalProduto.Visible = true;
            lblTotalProduto.Visible = true;
            lblValorTotalNota.Visible = true;
            lblTotalNota.Visible = true;
        }

        private void btnNovaEntrada_Click(object sender, EventArgs e)
        {
            resetarCampos();
            resetarCamposProduto();
            esconderCampos();
            novaEntrada = true;
            int ultimoId = db.Transacao.Max(u => u.idTransacao);
            int proximoId = ultimoId + 1;
            tabListaEntradas.SelectedIndex = 1;
            txtNumEntrada.Text = proximoId.ToString();
            txtDataEntrada.Enabled = true;
            DateTime dataAtual = DateTime.Today;
            string dataFormatada = dataAtual.ToShortDateString();
            txtDataEntrada.Text = dataFormatada;
            btnPesquisarFornecedor.Enabled = true;
            btnSelProduto.Enabled = true;
        }

        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            FormSelecionarFornecedor formSelecionarFornecedor = new FormSelecionarFornecedor();
            formSelecionarFornecedor.ShowDialog();
            txtFornecedor.Text = formSelecionarFornecedor.Valor;
            txtCodFornecedor.Text = formSelecionarFornecedor.Valor2;
        }

        private void btnSelProduto_Click(object sender, EventArgs e)
        {
            FormSelecionarProduto formSelecionarProduto = new FormSelecionarProduto();
            formSelecionarProduto.ShowDialog();
            txtCodProduto.Text = formSelecionarProduto.CodProduto;
            txtProduto.Text = formSelecionarProduto.NomeProduto;
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            novoProduto = true;
            lblTotalProduto.Text = "0";
            lblTotalNota.Text = "0";
            btnSelProduto.Enabled = true;
            btnSalvar.Enabled = true;
            txtCodProduto.Enabled = true;
            resetarCamposProduto();
        }

        private void dgvProdutosEntrada_SelectionChanged(object sender, EventArgs e)
        {
            transacaoProduto = getTransacaoSelecionada();
            
            if (transacaoProduto != null)
            {
                txtCodProduto.Text = transacaoProduto.idProduto.ToString();
                Produto p = produtoData.obterProduto(transacaoProduto.idProduto);
                txtProduto.Text = p.nome.ToString();
                txtQuantidade.Text = transacaoProduto.qtdProduto.ToString();
                txtValorUnitario.Text = Convert.ToString(string.Format("{0:0.00}", (transacaoProduto.valorUnitario)));
                lblTotalProduto.Text = Convert.ToString(string.Format("{0:0.00}", (transacaoProduto.qtdProduto * transacaoProduto.valorUnitario)));
            }
        }

        private void dgvEntradas_DoubleClick(object sender, EventArgs e)
        {
            resetarCampos();
            exibirCampos();
            tabListaEntradas.SelectedIndex = 1;
            entrada = getEntradaSelecionada();
            totalNota = 0;
            if (entrada != null)
            {
                txtNumEntrada.Text = entrada.idTransacao.ToString();
                DateTime dataEntrada = Convert.ToDateTime(entrada.data);
                txtDataEntrada.Text = dataEntrada.ToString("d");
                txtCodFornecedor.Text = entrada.idCliente.ToString();
                txtFornecedor.Text = pessoaData.obterPessoa(entrada.idCliente).nome;
                txtNotaFiscal.Text = notaFiscalData.obterNotaFiscal(entrada.idTransacao).numero;
                DateTime dataNotaFiscal = Convert.ToDateTime(notaFiscalData.obterNotaFiscal(entrada.idTransacao).dataHora);
                txtDataNotaFiscal.Text = dataNotaFiscal.ToString("d");
                atualizarTabelaProdutosTransacao();
                calcularTotalNota();
            }
            else
            {
                MessageBox.Show("Nenhuma entrada selecionada!");
            }
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {

            if (!validarCamposNovaEntrada())
            {
                return;
            }
            criaNovaEntrada();
            string erro = null;
            if (entrada.idTransacao == 0)
            {
                erro = entradaData.adicionarEntrada(entrada);
            }
            else
            {
                erro = entradaData.editarEntrada(entrada);
            }
            if (erro == null)
            {
                MessageBox.Show("Entrada adicionada com sucesso!");
                obterNotaFiscal();
                notaFiscalData.adicionarNotaFiscal(notaFiscal);
                novoProduto = false;
                btnSelProduto.Enabled = false;
                inicializarDataGridViewListaEntradas();
                exibirCampos();
                btnSelProduto.Enabled = true;
                novoProduto = true;
                atualizarTabelaProdutosTransacao();
                totalNota = 0;
                calcularTotalNota();
            }
            else
            {
                MessageBox.Show("Erro ao editar transação." + erro);
            }
            tabListaEntradas.SelectedIndex = 1;
        }

        private void btnExcluirEntrada_Click(object sender, EventArgs e)
        {
            string erro = entradaData.excluirEntrada(getEntradaSelecionada());
            if (erro == null)
            {
                MessageBox.Show("Entrada excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir entrada!");
            }
            inicializarDataGridViewListaEntradas();
            tabListaEntradas.SelectedIndex = 0;
            return;
        }
   }
}
