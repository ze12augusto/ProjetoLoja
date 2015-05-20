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
    public partial class FormMarca : Form
    {

        private ProjetoLojaEntities db;
        private MarcaData marcaData;
        private ModeloData modeloData;
        private Marca marca;

        public FormMarca()
        {
            InitializeComponent();
            db = new ProjetoLojaEntities();
            marcaData = new MarcaData();
            modeloData = new ModeloData();
            limparFormulario();
            atualizarTabela(marcaData.todasMarcas());
        }

        public void limparFormulario()
        {
            marca = new Marca();
            txtDescricao.Text = "";
            txtPesquisar.Text = "";
        }

        public void atualizarTabela(List<Marca> marca)
        {

            var list = from m in marca
                       let count = 
                       (
                          from mo in modeloData.todasModelos()
                          where m.idMarca == mo.idMarca
                          select mo
                        ).Count()    
                       select new
                       {
                           marca = m,
                           descricao = m.descricao,
                           quantidade = count

                       };

            dgvMarcas.DataSource = list.ToList();
            dgvMarcas.Columns[0].Visible = false;
     
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterMarca();

                string erro = null;
                if (marca.idMarca == 0)
                {
                    erro = marcaData.adicionarMarca(marca);
                }
                else
                {
                    erro = marcaData.editarMarca(marca);
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
                atualizarTabela(marcaData.todasMarcas());
            }
        }

        public void obterMarca()
        {
            marca.descricao = txtDescricao.Text;
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

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma Marca!");
                return;
            }
            atribuirMarca((Marca)dgvMarcas.CurrentRow.Cells[0].Value);
        }

        public void atribuirMarca(Marca m)
        {
            marca = m;
            txtDescricao.Text = m.descricao;
 
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma Marca!");
                return;
            }

            if ((int)dgvMarcas.CurrentRow.Cells[2].Value > 0)
            {
                    MessageBox.Show("Não é possivel excluir uma marca que possui modelos associados!");
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    marcaData.excluirMarca((Marca)dgvMarcas.CurrentRow.Cells[0].Value);
                    atualizarTabela(marcaData.todasMarcas());


                }

            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizarTabela(marcaData.buscaMarcas(txtPesquisar.Text));
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
