using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Data;
using ProjetoLojaDesktop.Entity;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormTransacaoSaida : Form
    {
        ProjetoLojaEntities db;
        private StatusTransacaoData statusTransacaoData;
        private PessoaData pessoaData;

        public FormTransacaoSaida()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            statusTransacaoData = new StatusTransacaoData(db);
            pessoaData = new PessoaData(db);

            cbxStatus.DataSource = statusTransacaoData.obterTodos();
            cbxStatus.DisplayMember = "descricao";
            cbxStatus.ValueMember = "idStatus";

            cbxFuncionario.DataSource = pessoaData.todasPessoaFisicasPorTipo(2);
            cbxFuncionario.DisplayMember = "nome";
            cbxFuncionario.ValueMember = "idPessoa";
        }

        private void btnSalvarTransacao_Click(object sender, EventArgs e)
        {

        }

    }
}
