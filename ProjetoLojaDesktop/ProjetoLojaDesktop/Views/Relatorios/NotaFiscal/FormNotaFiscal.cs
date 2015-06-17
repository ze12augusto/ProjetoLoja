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

namespace ProjetoLojaDesktop.Views.Relatorios.NotaFiscal
{
    public partial class FormNotaFiscal : Form
    {
        ProjetoLojaEntities db;
        private NotaFiscalData notaFiscalData;

        public FormNotaFiscal()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            notaFiscalData = new NotaFiscalData(db);
        }

        private void FormNotaFiscal_Load(object sender, EventArgs e)
        {
            var lista = notaFiscalData.obterNotaFiscal(1); // apenas para efeito de teste
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString() + "\\Views\\Relatorios\\NotaFiscal\\NotaFiscalReport.rpt";
            rpt.SetDataSource(lista);
            rptNotaFiscal.ReportSource = rpt;
        }
    }
}
