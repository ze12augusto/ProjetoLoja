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

namespace ProjetoLojaDesktop.Views.Relatorios.StatusPedido
{
    public partial class FormStatusPedido : Form
    {
        ProjetoLojaEntities db;
        private StatusTransacaoData statusData;

        public FormStatusPedido()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            statusData = new StatusTransacaoData();
        }

        private void FormStatusPedido_Load(object sender, EventArgs e)
        {
            var lista = statusData.obterStatusTransacaoData(1); // apenas para efeito de teste
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString() + "\\Views\\Relatorios\\StatusPedido\\StatusPedido.rpt";
            rpt.SetDataSource(lista);
            rptStatusPedido.ReportSource = rpt;
        }
    }
}
