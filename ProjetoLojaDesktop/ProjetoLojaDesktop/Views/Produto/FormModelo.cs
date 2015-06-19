using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaData.Entity;
using ProjetoLojaData.Data;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormModelo : Form
    {
        private ProjetoLojaEntities db;
        private ModeloData modeloData;
        private MarcaData marcaData;
        private Modelo modelo;

        public FormModelo()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            modeloData = new ModeloData();
            marcaData = new MarcaData();
            limparFormulario();
            atualizarTabela(modeloData.todasModelos());

            cbxMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void limparFormulario()
        {
            modelo = new Modelo();
            txtDescricao.Text = "";
            txtPesquisar.Text = "";
            cbxMarcas.DataSource = marcaData.todasMarcas();
            cbxMarcas.DisplayMember = "descricao";
            cbxMarcas.ValueMember = "idMarca";
        }

        public void atualizarTabela(List<Modelo> modelo)
        {

            var list = from m in modelo
                       join marca in marcaData.todasMarcas()
                       on m.idMarca equals marca.idMarca
                       select new {
                              modelo = m,
                              descricao = m.descricao,
                              marca = marca.descricao
                       };

            dgvModelos.DataSource = list.ToList();
            dgvModelos.Columns[0].Visible = false;

         }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterModelo();

                string erro = null;
                if (modelo.idModelo == 0)
                {
                    erro = modeloData.adicionarModelo(modelo);
                }
                else
                {
                    erro = modeloData.editarModelo(modelo);
                }

                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(modeloData.todasModelos());
            }
        }

        public bool validar()
        {
            if (txtDescricao.Text == null || txtDescricao.Text == "")
            {
                MessageBox.Show("Digite uma descrição válida!");
                return false;
            }

            return true;
        }

        public void obterModelo()
        {
            modelo.descricao = txtDescricao.Text;
            modelo.idMarca = (int) cbxMarcas.SelectedValue;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizarTabela(modeloData.buscaModelos(txtPesquisar.Text));
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (dgvModelos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Modelo!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                modeloData
                    .excluirModelo((Modelo)dgvModelos.CurrentRow.Cells[0].Value);
                atualizarTabela(modeloData.todasModelos());
            }
        }

        public void atribuirModelo(Modelo m)
        {
            modelo = m;
            txtDescricao.Text = m.descricao;
            cbxMarcas.SelectedValue = m.idMarca;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dgvModelos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Modelo!");
                return;
            }
            atribuirModelo((Modelo)dgvModelos.CurrentRow.Cells[0].Value);
        }

        private void cbxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
