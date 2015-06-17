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
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace ProjetoLojaDesktop.Views
{
    public partial class FormPagamentoCartao : Form
    {
        ProjetoLojaEntities db;
        private PagamentoCataoData pagamentoCartaoData;

        public FormPagamentoCartao()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            pagamentoCartaoData = new PagamentoCataoData(db);
        }

        private void FormPagamentoCartao_Load(object sender, EventArgs e)
        {
            var lista = pagamentoCartaoData.todosPagamentosCartao();
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString() + "\\Views\\Relatorios\\PagtoCartao\\PagamentoCartaoReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptPagamentoCartao.ReportSource = rpt;
        }
    }
}
