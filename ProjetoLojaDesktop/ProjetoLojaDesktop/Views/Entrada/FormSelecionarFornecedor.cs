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
    public partial class FormSelecionarFornecedor : Form
    {
        private ProjetoLojaEntities db;
        private PessoaData pessoaData;
        private Pessoa pessoa;

        public String Valor
        {
            get { return txtFornecedor.Text; }
            set { txtFornecedor.Text = value; }
        }

        public String Valor2
        {
            get { return txtCodFornecedor.Text; }
            set { txtCodFornecedor.Text = value; }
        }

        public FormSelecionarFornecedor()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            pessoaData = new PessoaData(db);
            inicializar();
        }

        public void pesquisarFornecedor()
        {
            var lista = from f in pessoaData.todasPessoasJuridicas()
                        where f.idPessoa == (Convert.ToInt32(txtCodFornecedor.Text))
                        select f;
            dgvFornecedores.DataSource = lista.ToList();
        }

        private void inicializar()
        {
            inicializarDataGridViewListaFornecedores();
        }

        private void inicializarDataGridViewListaFornecedores()
        {
            dgvFornecedores.DataSource = pessoaData.todasPessoasJuridicas();
            /*dgvProduto.Columns[0].Visible = false;
            dgvProduto.Columns[1].Visible = false;
            dgvProduto.Columns[6].Visible = false;
            dgvProduto.Columns[7].Visible = false;
            dgvProduto.Columns[8].Visible = false;
            dgvProduto.Columns[9].Visible = false;
            dgvProduto.Columns[10].Visible = false;
            dgvProduto.Columns[11].Visible = false;
            dgvProduto.Columns[2].HeaderText = "Nome";
            dgvProduto.Columns[3].HeaderText = "Descrição";
            dgvProduto.Columns[4].HeaderText = "Quantidade Mínima";
            dgvProduto.Columns[5].HeaderText = "Quantidade Atual";*/
        }

        private Pessoa getPessoaSelecionada()
        {
            DataGridViewRow f = dgvFornecedores.CurrentRow;
            if (f != null)
                return (Pessoa)f.DataBoundItem;
            return null;
        }

        private void btnSelecionarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            pessoa = getPessoaSelecionada();
            //txtValorUnitario.Text = transacaoProduto.valorUnitario.ToString();
            txtFornecedor.Text = pessoa.nome;
            txtCodFornecedor.Text = pessoa.idPessoa.ToString();
        }

        private void dgvFornecedores_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void pesquisarTabela()
        {
            var lista = from f in pessoaData.todasPessoasJuridicas()
                        where f.nome.ToLower().Contains(txtFornecedor.Text.ToLower())
                        select f;
            dgvFornecedores.DataSource = lista.ToList();
        }



    }
}
