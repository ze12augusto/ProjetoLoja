using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SevenInfo
{
    public partial class frmCadFuncionarios : Form
    {
        public frmCadFuncionarios()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            ((Control)this.tabExtras).Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tabFuncionarios.SelectedIndex = 1;
            ((Control)this.tabExtras).Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            ((Control)this.tabExtras).Enabled = true;
        }
    }
}
