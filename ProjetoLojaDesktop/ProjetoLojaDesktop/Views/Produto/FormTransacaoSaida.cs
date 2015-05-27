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
using ProjetoLojaDesktop.Views;
using System.Text.RegularExpressions;
using ProjetoLojaDesktop.Views.Cliente;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormTransacaoSaida : Form
    {
        ProjetoLojaEntities db;
        private StatusTransacaoData statusTransacaoData;
        private TransacaoData transacaoData;
        private PessoaData pessoaData;
        private OrdemDeServicoData ordemServicoData;

        private Pessoa pessoa = new Pessoa();
        private Transacao transacao;

        public FormTransacaoSaida()
        {
            InitializeComponent();

            instanciarClassesData();
            instanciarEntidadesDeTransacao();
            inicializarDataSources();
            atualizarListaDeTransacoes();
            limparFormulario();
        }

        private void inicializarDataSources()
        {
            cbxStatus.DataSource = statusTransacaoData.todosStatusTransacao();
            cbxStatus.DisplayMember = "descricao";
            cbxStatus.ValueMember = "idStatus";

            cbxFuncionario.DataSource = pessoaData.todasPessoaFisicasPorTipo(2);
            cbxFuncionario.DisplayMember = "nome";
            cbxFuncionario.ValueMember = "idPessoa";
        }

        private void instanciarClassesData()
        {
            db = new ProjetoLojaEntities();
            statusTransacaoData = new StatusTransacaoData();
            transacaoData = new TransacaoData(db);
            pessoaData = new PessoaData(db);
            ordemServicoData = new OrdemDeServicoData(db);
        }

        private string validarCamposTransacao()
        {
            if (txtNomeCliente.Text == "")
                return "Selecione um Cliente!";
            if (cbxStatus.SelectedIndex == -1)
                return "Selecione um Status!";
            if (cbxFuncionario.SelectedIndex == -1)
                return "Selecione um Funcionário!";
            if (txtValor.Text == "")
                return "Valor não pode ser vazio!";

            return null;
        }

        private string validarCamposOrdemServico()
        {
            if (txtDescricaoOrdem.Text == "")
                return "Digite os dados da Ordem de Serviço!";
            if (DateTime.Now > dtpPrevisaoDeEntrega.Value)
                return "Selecione uma data válida!";

            return null;
        }

        private void inserirValoresTransacao()
        {
            if (transacao.idTransacao == 0)
            {
                transacao = new Transacao();
                transacao.OrdemServico = new OrdemServico();
            }

            transacao.idTipoTransacao = 2; //2 é o ID da Transação de Saída
            transacao.idCliente = pessoa.idPessoa;
            transacao.idFuncionario = (int)cbxFuncionario.SelectedValue;
            transacao.idStatus = (int)cbxStatus.SelectedValue;
            transacao.data = DateTime.Now;

            if (txtDesconto.Text != "")
                transacao.desconto = Convert.ToInt32(txtDesconto.Text);

            transacao.OrdemServico.dataEntrada = DateTime.Now;
            transacao.OrdemServico.dataPrevistaEntrega = Convert.ToDateTime(dtpPrevisaoDeEntrega.Value);
            transacao.OrdemServico.descricao = txtDescricaoOrdem.Text;
        }

        private void inserirValoresOrdemServico()
        {
            transacao.OrdemServico.dataEntrada = DateTime.Now;
            transacao.OrdemServico.dataPrevistaEntrega = Convert.ToDateTime(dtpPrevisaoDeEntrega.Value);
            transacao.OrdemServico.dataEntrega = null;
            transacao.OrdemServico.descricao = txtDescricaoOrdem.Text;
            if (txtValor.Text != "")
                transacao.OrdemServico.valor = Convert.ToInt32(txtValor.Text);
            else
                transacao.OrdemServico.valor = 0;
        }

        private void limparFormulario()
        {
            instanciarEntidadesDeTransacao();
            txtData.Text = Convert.ToString(DateTime.Now);
            
            cbxFuncionario.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            txtDesconto.Text = "";
            txtValor.Text = "";
            txtNomeCliente.Text = "";
            dtpPrevisaoDeEntrega.Text = Convert.ToString(DateTime.Now);
            txtDescricaoOrdem.Text = "";
        }

        private void btnNovaTransacao_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        public void instanciarEntidadesDeTransacao()
        {
            transacao = new Transacao();
            transacao.OrdemServico = new OrdemServico();
            transacao.Pessoa = new Pessoa(); //Este é o Funcionário
            transacao.Pessoa1 = new Pessoa(); //Este é o Cliente
        }

        private bool obterTransacaoDaLista()
        {
            if (dgvTransacoes.CurrentRow != null)
            {
                transacao = (Transacao)dgvTransacoes.CurrentRow.DataBoundItem;
                return true;
            }
            else
            {
                MessageBox.Show("Selecione uma transação antes!", "Erro");
                return false;
            }
        }

        private void btnEditarTransacao_Click(object sender, EventArgs e)
        {
            if (obterTransacaoDaLista())
            {
                txtNomeCliente.Text = transacao.Pessoa1.nome;
                cbxFuncionario.SelectedValue = transacao.idFuncionario;
                cbxStatus.SelectedValue = transacao.idStatus;
                txtData.Text = Convert.ToString(transacao.data);
                txtDesconto.Text = Convert.ToString(transacao.desconto);
            }
        }

        private string verificarDesconto()
        {
            if (Convert.ToInt32(txtDesconto.Text) > Convert.ToInt32(txtValor.Text))
                return "O desconto não pode ser maior que o valor da Transação!";

            return null;
        }

        private void atualizarListaDeTransacoes()
        {
            List<Transacao> transacoes = transacaoData.todasTransacoes();
            dgvTransacoes.DataSource = transacoes;
            dgvTransacoes.Columns[0].Visible = false;
            dgvTransacoes.Columns[3].Visible = false;
            dgvTransacoes.Columns[7].Visible = false;
            dgvTransacoes.Columns[8].Visible = false;
            dgvTransacoes.Columns[9].Visible = false;
            dgvTransacoes.Columns[10].Visible = false;
            dgvTransacoes.Columns[11].Visible = false;
            dgvTransacoes.Columns[12].Visible = false;
            dgvTransacoes.Columns[13].Visible = false;
            dgvTransacoes.Columns[14].Visible = false;

            dgvTransacoes.Columns[1].HeaderText = "Data";
            dgvTransacoes.Columns[2].HeaderText = "Desconto";
            dgvTransacoes.Columns[4].HeaderText = "Cliente";
            dgvTransacoes.Columns[4].Width = 150;
            dgvTransacoes.Columns[5].HeaderText = "Funcionário";
            dgvTransacoes.Columns[5].Width = 150;
            dgvTransacoes.Columns[6].HeaderText = "Status";
        }

        private void btnSalvarTransacao_Click(object sender, EventArgs e)
        {
            string erro = validarCamposTransacao();

            if (erro == null)
            {
                inserirValoresTransacao();
                string verDesconto = verificarDesconto();

                if (verDesconto == null)
                {
                    string retorno = transacaoData.salvarTransacao(transacao);

                    if (retorno == null)
                    {
                        MessageBox.Show("Salvo com sucesso!", "Sucesso");
                        atualizarListaDeTransacoes();
                        limparFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar a Transação!", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show(verDesconto, "Erro");
                }
            }
            else
            {
                MessageBox.Show(erro, "Erro");
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FormSelecionarCliente form = new FormSelecionarCliente();
            form.ShowDialog();

            pessoa = form.getPessoaSelecionada();
            txtNomeCliente.Text = pessoa.nome;
        }

        private void buscarOrdemServico()
        {
            transacao.OrdemServico = ordemServicoData.obterOrdemDeServico(transacao.idTransacao);
            dtpPrevisaoDeEntrega.Text = Convert.ToString(transacao.OrdemServico.dataPrevistaEntrega);
            txtDescricaoOrdem.Text = transacao.OrdemServico.descricao;
            txtValor.Text = Convert.ToString(transacao.OrdemServico.valor);
        }

        private void dgvTransacao_DoubleClick(object sender, EventArgs e)
        {
            transacao = ((Transacao)dgvTransacoes.CurrentRow.DataBoundItem);
            buscarOrdemServico();
            tbcTransacao.SelectedIndex = 1;
            tbpOrdemDeServico.Enabled = true;
        }

        private void btnSalvarOrdem_Click(object sender, EventArgs e)
        {
            string erro = validarCamposOrdemServico();

            if (erro == null)
            {
                inserirValoresOrdemServico();

                string retorno = ordemServicoData.adicionarOrdemDeServico(transacao.OrdemServico);

                if (retorno == null)
                {
                    MessageBox.Show("Salvo com sucesso!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar a Ordem de Serviço!", "Erro");
                }
            }
            else
            {
                MessageBox.Show(erro, "Erro");
            }
        } 
    }
}
