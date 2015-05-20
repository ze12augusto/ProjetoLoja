using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Enums;
using ProjetoLojaData.Entity;
using ProjetoLojaDesktop.Views.Cliente;
using ProjetoLojaData.Data;


namespace ProjetoLojaDesktop.Views
{
    public partial class FormVenda : Form
    {
        ProjetoLojaEntities db;
        private Transacao transacao;
        private Produto produto;
        private PessoaData pessoaData;
        private TransacaoData transacaoData;
        private TransacaoProdutoData transacaoProData;
        private ProdutoData produtoData;
        private ProdutoVigenciaData pvpData;


        public FormVenda()
        {
            InitializeComponent();
            inicializarData();
            atualizarTabelaProduto(transacaoProData.todostransacoesProduto());
        }

        public void inicializarData()
        {
            db = new ProjetoLojaEntities();
            pessoaData = new PessoaData(db);
            transacaoData = new TransacaoData(db);
            produtoData = new ProdutoData(db);
            transacaoProData = new TransacaoProdutoData(db);
            pvpData = new ProdutoVigenciaData(db);
        }

        public void atualizarTabelaProduto(List<TransacaoProduto> transacao)
        {
            var lista = from t in transacao
                        join tp in transacaoProData.todostransacoesProduto()
                            on t.idTransacao equals tp.idTransacao
                        join pd in produtoData.todosProdutos()
                            on tp.idProduto equals pd.idProduto

                        select new
                        {
                            NomeProduto = pd.nome,
                            Quantidade = tp.qtdProduto,
                            PrecoUnitario = tp.valorUnitario,
                            PrecoTotal = tp.qtdProduto * tp.valorUnitario
                        };
     
            dgvListaProduto.DataSource = transacao;
        }

        public void obterVenda()
        {
            transacao.Pessoa.nome = txtClienteVenda.Text;
            transacao.idFuncionario = (int)cbxFuncionario.SelectedValue;
        }

        private void limparFormulario()
        {
            txtClienteVenda.Text = "";
            cbxFuncionario.SelectedValue = -1;
        }

        public void removerProduto()
        {
            if (dgvListaProduto.CurrentRow != null)
            {
                TransacaoProduto tp = (TransacaoProduto)dgvListaProduto.CurrentRow.DataBoundItem;
                transacao.TransacaoProduto.Remove(tp);
            }
            atualizarTabelaProduto(transacaoProData.todostransacoesProduto());
        }

        private string validar()
        {
            if (txtClienteVenda.Text == null)
                return "Selecione um cliente!";
            if (transacao.TransacaoProduto.ToList().Count == 0)
                return "Selecione um produto!";
            if (cbxFuncionario.SelectedIndex == -1)
                return "Selecione um Funcionario";

            return null;
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

            FormSelecionarProduto form = new FormSelecionarProduto(TipoTransacaoEnum.SAIDA);
            form.ShowDialog();
            TransacaoProduto transacaoProduto = form.getTransacaoProduto();

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            removerProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelecionarCliente selecionarCliente = new FormSelecionarCliente();
            selecionarCliente.ShowDialog();
            Pessoa pessoa = selecionarCliente.getPessoaSelecionada();
            txtClienteVenda.Text = pessoa.nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string erro = validar();

            if (erro == null)
            {
                obterVenda();

                string erro2 = transacaoData.salvarTransacao(transacao);
                if (erro2 == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    limparFormulario();
                    atualizarTabelaProduto(transacaoProData.todostransacoesProduto());
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string erro = validar();

            if (erro == null)
            {
                obterVenda();

                string erro2 = transacaoData.salvarTransacao(transacao);
                if (erro2 == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                    //Pagamento
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
            }
        }

        
    }
}
