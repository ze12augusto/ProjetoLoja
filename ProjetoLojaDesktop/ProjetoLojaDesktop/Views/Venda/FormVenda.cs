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
using ProjetoLojaDesktop.Views.Relatorios.StatusPedido;
using ProjetoLojaDesktop.Views.Relatorios.NotaFiscal;


namespace ProjetoLojaDesktop.Views
{
    public partial class FormVenda : Form
    {
        private ProjetoLojaEntities db;
        private Transacao transacao;
        private TransacaoData transacaoData;
        private Produto produto;
        private ProdutoData produtoData;
        private PessoaData pessoaData;
        private UsuarioData usuarioData;


        public FormVenda()
        {
            InitializeComponent();
            inicializarData();
            preenchercbxFuncionario();
            atualizarDgvListaVenda();
        }

        public void inicializarData()
        {
            db = new ProjetoLojaEntities();
            produtoData = new ProdutoData(db);
            pessoaData = new PessoaData(db);
            usuarioData = new UsuarioData(db);
            transacao = new Transacao();
            transacaoData = new TransacaoData(db);
        }

        private void preenchercbxFuncionario()
        {
            var lista = from u in usuarioData.todasUsuarios()
                        join p in pessoaData.todasPessoas()
                            on u.idPessoa equals p.idPessoa
                        select new
                        {
                            idPessoa = p.idPessoa,
                            nome = p.nome
                        };

            cbxFuncionario.DataSource = lista.ToList();
            cbxFuncionario.DisplayMember = "nome";
            cbxFuncionario.ValueMember = "idPessoa";
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FormSelecionarProduto form = new FormSelecionarProduto(TipoTransacaoEnum.SAIDA);
            form.ShowDialog();
            TransacaoProduto transacaoProduto = form.getTransacaoProduto();
            transacao.TransacaoProduto.Add(transacaoProduto);
            atualizarDgvListaProduto();
        }

        public void atualizarDgvListaVenda()
        {
            dgvListaVenda.DataSource = transacaoData.todasTransacoes();
        }

        public void atualizarDgvListaProduto()
        {
            var lista = from t in transacao.TransacaoProduto
                        join p in produtoData.todosProdutos()
                            on t.idProduto equals p.idProduto
                        select new
                        {
                            transacaoP = t,
                            descricao = p.descricao,
                            quantidade = t.qtdProduto,
                            valorUni = t.valorUnitario,
                            total = t.qtdProduto * t.valorUnitario
                        };

            dgvListaProduto.DataSource = lista.ToList();



            txtTotalVenda.Text = getTotalVenda().ToString();
        }

        public float getTotalVenda()
        {
            float total = 0;
            foreach (TransacaoProduto value in transacao.TransacaoProduto)
            {
                total += (float)value.valorUnitario * value.qtdProduto;
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelecionarCliente selecionarCliente = new FormSelecionarCliente();
            selecionarCliente.ShowDialog();
            Pessoa pessoa = selecionarCliente.getPessoaSelecionada();
            if (pessoa != null)
            {
                txtClienteVenda.Text = pessoa.nome;
                transacao.idCliente = pessoa.idPessoa;
            }

        }

        public bool validar()
        {
            if (transacao.idCliente == 0)
            {
                MessageBox.Show("Selecione um cliente.");
                return false;
            }
            if (cbxFuncionario.SelectedValue == null)
            {
                MessageBox.Show("Selecione um funcionario.");
                return false;
            }
            if (transacao.TransacaoProduto.Count() < 1)
            {
                MessageBox.Show("Selecione os produtos.");
                return false;
            }

            return true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                transacao.data = DateTime.Now.Date;
                transacao.idStatus = 1;
                transacao.idTipoTransacao = 2; //2-Saida
                transacao.idFuncionario = (Int32)cbxFuncionario.SelectedValue;

                String erro = transacaoData.adicionarTransacao(transacao);
                if (erro == null)
                {
                    MessageBox.Show("Transação salva.");
                    atualizarDgvListaVenda();
                    limpar();
                    
                }
                else
                {
                    MessageBox.Show("Não foi possivel salvar a transação agora");
                }
                
            }
            
        }

        public void limpar()
        {
            transacao = new Transacao();
            atualizarDgvListaProduto();
            txtClienteVenda.Text = "";
            txtTotalVenda.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisaVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void btnStatusPedido_Click(object sender, EventArgs e)
        {
            new FormStatusPedido().Show();
        }

        private void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            new FormNotaFiscal().Show();
        }      
=======
>>>>>>> master
    }
}
