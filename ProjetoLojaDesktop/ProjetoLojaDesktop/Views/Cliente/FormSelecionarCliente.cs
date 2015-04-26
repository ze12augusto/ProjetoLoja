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

namespace ProjetoLojaDesktop.Views.Cliente
{
    public partial class FormSelecionarCliente : Form
    {
        private Pessoa pessoa;
        private PessoaData pessoaData;

        public FormSelecionarCliente()
        {
            InitializeComponent();
            ProjetoLojaEntities db = new ProjetoLojaEntities();
            pessoaData = new PessoaData(db);

            atualizarListaClientes(pessoaData.todasPessoas());
        }

        public void atualizarListaClientes(List<Pessoa> pessoas)
        {
            dgvClientes.DataSource = pessoas;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[1].HeaderText = "Nome";
            dgvClientes.Columns[4].Visible = false;
            dgvClientes.Columns[5].Visible = false;
            dgvClientes.Columns[6].Visible = false;
            dgvClientes.Columns[7].Visible = false;
            dgvClientes.Columns[8].Visible = false;
            dgvClientes.Columns[9].Visible = false;
            dgvClientes.Columns[10].Visible = false;
            dgvClientes.Columns[11].Visible = false;
        }

        private Pessoa getClienteSelecionadoNaTabela()
        {
            DataGridViewRow p = dgvClientes.CurrentRow;
            if (p != null)
                return (Pessoa)p.DataBoundItem;

            return null;
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            atualizarListaClientes(pessoaData.pesquisarPessoaPorNome(txtPesquisa.Text));
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            Pessoa p = getClienteSelecionadoNaTabela();
            if (p != null)
            {
                MessageBox.Show(p.nome);
                Dispose();
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente.");
            }
        }

    }
}
