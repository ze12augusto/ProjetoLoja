using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
            ((Control)this.tabProduto).Enabled = false;
            ((Control)this.tabDetalhesProduto).Enabled = false;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            tabProdutos.SelectedIndex = 1;
            ((Control)this.tabProduto).Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tabProdutos.SelectedIndex = 2;
            ((Control)this.tabDetalhesProduto).Enabled = true;
        }
    }
}
