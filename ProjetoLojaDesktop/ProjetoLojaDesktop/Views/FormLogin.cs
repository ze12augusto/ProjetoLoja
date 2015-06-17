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

namespace ProjetoLojaDesktop.Views
{
    public partial class FormLogin : Form
    {
        public UsuarioData usuarioData;
        private ProjetoLojaEntities db;
        private Usuario usuario;

        public FormLogin()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            usuarioData = new UsuarioData(db);
            usuario = new Usuario();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string cpf = txtUsuario.Text;
            cpf = cpf.Replace(".","").Replace(",","").Replace("-","");
            string senhaDigitada = mtxSenha.Text;
            usuario = usuarioData.obterUsuarioPorlogin(cpf);
            if (usuario == null) {
                MessageBox.Show("Usuario Inexistente!");
                return;
            }
            if (usuario.senha != senhaDigitada)
            {
                MessageBox.Show("Senha Incorreta!");
                return;
            }
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnEntrar_Click(sender, null);
            }
            
        }


    }
}
