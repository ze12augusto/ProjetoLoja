using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Forms;
using ProjetoLojaDesktop.Views.Relatorios.Produto;

namespace ProjetoLojaDesktop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new FormCadastroCliente().Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            new FormFornecedor().Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FormCadFuncionarios().Show();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            new FormModelo().Show();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            new FormMarca().Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadastroCliente().Show();
        }

        private void fornecerdorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor().Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCadFuncionarios().Show();
        }

        private void cadastrarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMarca().Show();
        }

        private void cadastrarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormModelo().Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Programa?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Programa?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRelatorioProduto().Show();
        }

      
       
    }
}
