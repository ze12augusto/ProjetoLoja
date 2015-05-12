using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Enums;
using ProjetoLojaDesktop.Entity;
using ProjetoLojaDesktop.Views.Cliente;

namespace ProjetoLojaDesktop.Views
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

            //FormSelecionarProduto form = new FormSelecionarProduto(TipoTransacaoEnum.SAIDA);
            //form.ShowDialog();
            //TransacaoProduto transacaoProduto = form.getTransacaoProduto();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelecionarCliente selecionarCliente = new FormSelecionarCliente();
            selecionarCliente.ShowDialog();
            Pessoa pessoa = selecionarCliente.getPessoaSelecionada();
            txtClienteVenda.Text = pessoa.nome;
        }
    }
}
