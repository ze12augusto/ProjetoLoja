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
using ProjetoLojaDesktop.Views.Venda;
using ProjetoLojaDesktop.Views.Relatorios.StatusPedido;
using ProjetoLojaDesktop.Views.Relatorios.NotaFiscal;


namespace ProjetoLojaDesktop.Views
{
    public partial class FormVenda : Form
    {
        private ProjetoLojaEntities db;
        private Transacao transacao;
        private TransacaoData transacaoData;
        private ProdutoData produtoData;
        private PessoaData pessoaData;
        private UsuarioData usuarioData;
        private StatusTransacaoData statusData;


        public FormVenda()
        {
            InitializeComponent();
            inicializarData();
            preenchercbxFuncionario();
            atualizarDgvListaVenda();
            limpar();
            
        }

        public void inicializarData()
        {
            db = new ProjetoLojaEntities();
            produtoData = new ProdutoData(db);
            pessoaData = new PessoaData(db);
            usuarioData = new UsuarioData(db);
            transacao = new Transacao();
            transacaoData = new TransacaoData(db);
            statusData = new StatusTransacaoData();
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
            var lista = from t in transacaoData.todasTransacoes()
                        join p in pessoaData.todasPessoas()
                            on t.idFuncionario equals p.idPessoa
                        join c in pessoaData.todasPessoas()
                            on t.idCliente equals c.idPessoa
                        join st in statusData.todosStatusTransacao()
                            on t.idStatus equals st.idStatus
                        select new
                        {
                            transacao = t,
                            id = t.idTransacao,
                            data = t.data,
                            funcionario = p.nome,
                            cliente = c.nome,
                            status = st.descricao,

                        };

            dgvListaVenda.DataSource = lista.ToList();
            dgvListaVenda.Columns[0].Visible = false;
        }

        public void atualizarDgvListaProduto()
        {
            var lista = from t in transacao.TransacaoProduto
                        join p in produtoData.todosProdutos()
                            on t.idProduto equals p.idProduto
                        select new
                        {
                            transacaoProduto = t,
                            descricao = p.descricao,
                            quantidade = t.qtdProduto,
                            valorUni = t.valorUnitario,
                            total = t.qtdProduto * t.valorUnitario
                        };

            dgvListaProduto.DataSource = lista.ToList();
            dgvListaProduto.Columns[0].Visible = false;


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
            if (validar())
            {
                FormPagamento pagamento = new FormPagamento(transacao);
                pagamento.ShowDialog();
                Transacao transacaoPaga = pagamento.getTransacaoPaga();
                if (transacaoPaga != null)
                {
   
                    transacao.idFuncionario = (Int32)cbxFuncionario.SelectedValue;

                    salvaTransacao();

                }

            }

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                transacao.idStatus = 1; //Aguard Pag.
                transacao.idFuncionario = (Int32)cbxFuncionario.SelectedValue;

                salvaTransacao();
                                
            }
            
        }

        public void salvaTransacao()
        {
            transacao.data = DateTime.Now.Date;
            transacao.idTipoTransacao = 2; //2-Saida

            if (transacao.idTransacao == 0)
            {
                String erro = transacaoData.adicionarTransacao(transacao);
                if (erro == null)
                {
                    MessageBox.Show("Venda salva.");
                    atualizarDgvListaVenda();
                    limpar();

                }
                else
                {
                    MessageBox.Show("Não foi possivel salvar a venda agora");
                }
            }
            else
            {

                String erro = transacaoData.editarTransacao(transacao);
                if (erro == null)
                {
                    MessageBox.Show("Venda atualizada.");
                    atualizarDgvListaVenda();
                    limpar();

                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar a venda agora");
                }

            }
        }

        public void limpar()
        {
            transacao = new Transacao();
            atualizarDgvListaProduto();
            txtClienteVenda.Text = "";
            txtTotalVenda.Text = "";
            tabCadastrar.SelectedIndex = 0;
            tabCadastrarVenda.Enabled = false;
            txtClienteVenda.ReadOnly = true;
            cbxFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow p = dgvListaProduto.CurrentRow;
            if (p == null)
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }
            else
            {
                Object produto = p.DataBoundItem;
                TransacaoProduto transacaoP = (TransacaoProduto)produto.GetType().GetProperty("transacaoProduto").GetValue(produto, null);
                transacao.TransacaoProduto.Remove(transacaoP);
                atualizarDgvListaProduto();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabCadastrar.SelectedIndex = 1;
            tabCadastrarVenda.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow p = dgvListaVenda.CurrentRow;
            if (p == null)
            {
                MessageBox.Show("Selecione uma venda para excluir!");
            }
            else
            {
                Object t = p.DataBoundItem;
                transacao = (Transacao)t.GetType().GetProperty("transacao").GetValue(t, null);
                if (transacao.StatusTransacao.idStatus != 2)
                {
                    atualizarDgvListaProduto();
                    tabCadastrar.SelectedIndex = 1;
                    tabCadastrarVenda.Enabled = true;
                    Pessoa pess = pessoaData.obterPessoa(transacao.idCliente);
                    txtClienteVenda.Text = pess.nome;
                    transacao.idCliente = pess.idPessoa;
                }
                else
                {
                    MessageBox.Show("Esta venda já esta finalizada!");
                }
                
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow p = dgvListaVenda.CurrentRow;
            if (p == null)
            {
                MessageBox.Show("Selecione uma venda para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Object t = p.DataBoundItem;
                transacao = (Transacao)t.GetType().GetProperty("transacao").GetValue(t, null);

                string erro = transacaoData.excluirTransacao(transacao);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                atualizarDgvListaVenda();
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            new FormStatusPedido().Show();
        }

        private void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            new FormNotaFiscal().Show();
        }
    }
}
