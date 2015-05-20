using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using ProjetoLojaDesktop.Views;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormNotaFiscal : Form
    {
        public int idParemtroTransacao { get; set; }

        public FormNotaFiscal(int idTransacao)
        {
            InitializeComponent();
            idParemtroTransacao = idTransacao;
        }

        private void FormNotaFiscal_Load(object sender, EventArgs e)
        {
            string rel_path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            rel_path += "\\Relatorios\\NotaFiscalReport.rpt";
            ReportDocument rd = new ReportDocument();
            rd.Load(rel_path);

            ParameterField parametro = rd.ParameterFields["idParametroTransacao"];
            parametro.CurrentValues.AddValue(this.idParemtroTransacao);
        }
    }
}
