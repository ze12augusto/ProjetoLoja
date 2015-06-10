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

namespace ProjetoLojaDesktop.Views.Relatorios.RelatorioOS
{
    public partial class FormRelatorioOS : Form
    {
        ProjetoLojaEntities db;
        private OrdemDeServicoData ordemDeServicoData;

        public FormRelatorioOS()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            ordemDeServicoData = new OrdemDeServicoData(db);
        }


        private void FormRelatorioOS_Load(object sender, EventArgs e)
        {
            var lista = ordemDeServicoData.todasOrdensDeServico();
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "C:\\Documents and Settings\\a12027158\\Desktop\\ProjetoLoja-master\\ProjetoLojaDesktop\\ProjetoLojaDesktop\\Views\\Relatorios\\RelatorioOS\\RelatorioOS.rpt";
            rpt.SetDataSource(lista.ToList());
            rptRelatorioOS.ReportSource = rpt;
        }
    }
}
