using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaData.Entity;

namespace ProjetoLojaDesktop.Views.Venda
{
    public partial class FormPagamento : Form
    {
        private Transacao transacao;
        private int qtdParcela;

        public FormPagamento(Transacao transacao)
        {
            InitializeComponent();
            this.transacao = transacao;
            inicia();
        }

        public Transacao getTransacaoPaga()
        {
            return transacao;
        }

        public void inicia()
        {
            txtValor.Text = getTotalVenda().ToString();
            lbTotal.Text = getTotalVenda().ToString();
            txtCartaoCod.ReadOnly = true;
            txtCartao.ReadOnly = true;
            txtValor.ReadOnly = true;
            cbxParcelas.Enabled = false;
            cbxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxParcelas.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPagamento.SelectedIndex == 0)
            {
                txtCartaoCod.ReadOnly = true;
                txtCartao.ReadOnly = true;
                cbxParcelas.Enabled = false;

            }

            if (cbxPagamento.SelectedIndex == 1)
            {
                txtCartaoCod.ReadOnly = false;
                txtCartao.ReadOnly = false;
                cbxParcelas.Enabled = true;
            }
            
        }

        private void cbxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxParcelas.SelectedIndex == 0)
            {
                lbTotal.Text = "1 x "+getTotalVenda().ToString();
                qtdParcela = 1;
            }
            if (cbxParcelas.SelectedIndex == 1)
            {
                lbTotal.Text = "2 x " + (getTotalVenda() / 2).ToString();
                qtdParcela = 2;
            }
            if (cbxParcelas.SelectedIndex == 2)
            {
                lbTotal.Text = "3 x " + (getTotalVenda() / 3).ToString();
                qtdParcela = 3;
            }
            if (cbxParcelas.SelectedIndex == 3)
            {
                lbTotal.Text = "4 x " + (getTotalVenda() / 4).ToString();
                qtdParcela = 4;
            }
            if (cbxParcelas.SelectedIndex == 4)
            {
                lbTotal.Text = "5 x " + (getTotalVenda() / 5).ToString();
                qtdParcela = 5;
            }
            if (cbxParcelas.SelectedIndex == 5)
            {
                lbTotal.Text = "6 x " + (getTotalVenda() / 6).ToString();
                qtdParcela = 6;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Boolean validaCartao()
        {
            if(txtCartaoCod.Text == ""){
                MessageBox.Show("Preencha o codigo do cartão!");
                return false;
            }
            if (txtCartao.Text == "")
            {
                MessageBox.Show("Preencha o codigo do cartão!");
                return false;
            }

            return true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (validaCartao())
            {
                if (cbxPagamento.SelectedIndex == 0 || cbxPagamento.SelectedIndex == 1)
                {
                    if (cbxParcelas.SelectedIndex == 0 
                        || cbxParcelas.SelectedIndex == 1
                        || cbxParcelas.SelectedIndex == 2
                        || cbxParcelas.SelectedIndex == 3
                        || cbxParcelas.SelectedIndex == 4
                        || cbxParcelas.SelectedIndex == 5){

                        if (cbxPagamento.SelectedIndex == 0)
                        {
                            //transacao.Pagamento.PagamentoAVista.valorRecebido = getTotalVenda();
                        }
                        else
                        {
                            // transacao.Pagamento.PagamentoCartao.qtdParcelas = (Int16) qtdParcela;
                            // transacao.Pagamento.PagamentoCartao.valorParcela = (decimal) getTotalVenda() / (Int16)qtdParcela;
                        }

                        transacao.idStatus = 2; //Pag.

                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Selecione as parcelas!");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o tipo de pagamento!");
                }
            }
            

        }

        private void txtCartaoCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
