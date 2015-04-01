using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoLojaDesktop.Entity;
using ProjetoLojaDesktop.Data;
using System.IO;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormProdutos : Form
    {
        private ProjetoLojaEntities db;
        
        private Produto produto;
        private CaracteristicaProduto caracteristicaProduto;
        private ImagemProduto imagemProduto;

        private ProdutoData produtoData;
        private MarcaData marcaData;
        private ModeloData modeloData;

        private ImagemProdutoData imagemProdutoData;
        private CaracteristicaProdutoData caracteristicaProdutoData;
        
        public FormProdutos()
        {
            InitializeComponent();

            db = new ProjetoLojaEntities();
            
            produtoData = new ProdutoData(db);
            caracteristicaProdutoData = new CaracteristicaProdutoData();
            imagemProdutoData = new ImagemProdutoData();
            marcaData = new MarcaData();
            modeloData = new ModeloData();
            produto = new Produto();
            caracteristicaProduto = new CaracteristicaProduto();
            imagemProduto = new ImagemProduto();
            ((Control)this.tabProduto).Enabled = false;
            ((Control)this.tabDetalhesProduto).Enabled = false;
            inicializar();
        }
        private void inicializar()
        {
            resetarCampos();
            inicializarDataGridView();
            inicializarDataGridViewImagens();
            inicializarDataGridViewCaracteristicas();
            atualizarTabelaCaracteristicas();
            atualizarTabelaImagens();
            inicializarCbx();
        }
        private void inicializarCbx()
        {
            cbxMarca.DataSource = marcaData.todasMarcas();
            cbxMarca.DisplayMember = "descricao";
            cbxMarca.ValueMember = "idMarca";
            cbxModelo.DataSource = modeloData.todasModelos();
            cbxModelo.DisplayMember = "descricao";
            cbxModelo.ValueMember = "idModelo";
        }
        private void inicializarDataGridView()
        {
            dgvProduto.DataSource = produtoData.todosProdutos();
            dgvProduto.Columns[0].Visible = false;
            dgvProduto.Columns[1].Visible = false;
            dgvProduto.Columns[6].Visible = false;
            dgvProduto.Columns[7].Visible = false;
            dgvProduto.Columns[8].Visible = false;
            dgvProduto.Columns[9].Visible = false;
            dgvProduto.Columns[10].Visible = false;
            dgvProduto.Columns[11].Visible = false;
            dgvProduto.Columns[2].HeaderText = "Nome";
            dgvProduto.Columns[3].HeaderText = "Descrição";
            dgvProduto.Columns[4].HeaderText = "Quantidade Mínima";
            dgvProduto.Columns[5].HeaderText = "Quantidade Atual";
        }
        private bool validarCampos()
        {
            if (txtNome.Text == "" || txtNome.Text == null)
            {
                MessageBox.Show("Nome Invalido!");
                return false;
            }
            if (txtDescricao.Text == "" || txtDescricao.Text == null)
            {
                MessageBox.Show("Descricao Invalido!");
                return false;
            }
            if (txtQtdA.Text == "" || txtQtdA.Text == null)
            {
                MessageBox.Show("Quantidade Atual Invalida!");
                return false;

            }
            if (txtQtdM.Text == "" || txtQtdM.Text == null)
            {
                MessageBox.Show("Quantidade Minima Invalida!");
                return false;
            }
            return true;
        }
        private void obterProduto()
        {
            produto.nome = txtNome.Text;
            produto.descricao = txtDescricao.Text;
            produto.qtdMinima = Convert.ToInt32(txtQtdM.Text);
            produto.qtdAtual = Convert.ToInt32(txtQtdA.Text);
            produto.idMarcaProduto = (int)cbxMarca.SelectedValue;
            produto.idModelo = (int)cbxModelo.SelectedValue;
        }
        private void resetarCampos()
        {
            produto = new Produto();
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtQtdM.Text = "";
            txtQtdA.Text = "";
        }
        private Produto getProdutoSelecionado()
        {
            DataGridViewRow p = dgvProduto.CurrentRow;
            if (p != null)
                return (Produto)p.DataBoundItem;
            return null;
        }
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            tabProdutos.SelectedIndex = 1;
            ((Control)this.tabProduto).Enabled = true;
            resetarCampos();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            obterProduto();
            string erro = null;
            if (produto.idProduto == 0)
            {

                erro = produtoData.adicionarProduto(produto);
            }
            else
            {
                erro = produtoData.editarProduto(produto);
            }
            if (erro == null)
            {
                MessageBox.Show("Produto salvo com sucesso!");
                tabProdutos.SelectedIndex = 2;
                ((Control)this.tabDetalhesProduto).Enabled = true;
                atualizarTabela();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o produto." + erro);
                tabProdutos.SelectedIndex = 1;
                ((Control)this.tabDetalhesProduto).Enabled = false;
            }
        }
        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            tabProdutos.SelectedIndex = 2;
            ((Control)this.tabProduto).Enabled = true;
            ((Control)this.tabDetalhesProduto).Enabled = true;
            resetarCamposImagem();
            produto = getProdutoSelecionado();
            atualizarTabelaCaracteristicas();
            atualizarTabelaImagens();
            if (produto != null)
            {
                txtNome.Text = produto.nome;
                txtDescricao.Text = produto.descricao;
                txtQtdM.Text = produto.qtdMinima.ToString();
                txtQtdA.Text = produto.qtdAtual.ToString();
                cbxMarca.SelectedValue = produto.idMarcaProduto;
                cbxModelo.SelectedValue = produto.idModelo;
                IdProduto.Text = produto.idProduto.ToString();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!");
            }
        }
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            string erro = produtoData.excluirProduto(getProdutoSelecionado());

            if (erro == null)
            {
                MessageBox.Show("Produto excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o produto.");
            }
            inicializar();
        }

        private void inicializarDataGridViewImagens()
        {
            dgvImagem.DataSource = imagemProdutoData.todasImagemProdutos();
            dgvImagem.Columns[2].Visible = false;
            dgvImagem.Columns[3].Visible = false;
            dgvImagem.Columns[0].HeaderText = "Código da Imagem";
            dgvImagem.Columns[1].HeaderText = "Nome da Imagem";
        }
        private void inicializarDataGridViewCaracteristicas()
        {
            dgvCaracteristicasProduto.DataSource = caracteristicaProdutoData.todasCaracteristicas();
            dgvCaracteristicasProduto.Columns[1].Visible = false;
            dgvCaracteristicasProduto.Columns[4].Visible = false;
            dgvCaracteristicasProduto.Columns[0].HeaderText = "Código Característica";
            dgvCaracteristicasProduto.Columns[2].HeaderText = "Título";
            dgvCaracteristicasProduto.Columns[3].HeaderText = "Descrição";
        }
        
        private bool validarCamposCaracteristicas()
        {
            if (txtTitulo.Text == "" || txtTitulo.Text == null)
            {
                MessageBox.Show("Titulo Invalido!");
                return false;
            }
            if (txtDescricaoCaracteristicaProduto.Text == "" || txtDescricaoCaracteristicaProduto.Text == null)
            {
                MessageBox.Show("Descricao Invalida!");
                return false;
            }
            return true;
        }

        
        private void obterImagemProduto()
        {
            imagemProduto.idProduto = Convert.ToInt32(IdProduto.Text);
            imagemProduto.caminho = nameImg.Text;
        }
        private void obterCaracteristicaProd()
        {
            caracteristicaProduto.idProduto = Convert.ToInt32(IdProduto.Text);
            caracteristicaProduto.titulo = txtTitulo.Text;
            caracteristicaProduto.descricao = txtDescricaoCaracteristicaProduto.Text;
        }

        
        private void resetarCamposImagem()
        {
            imagemProduto = new ImagemProduto();
            picImagem.ImageLocation = "";
            nameImg.Text = "";
            btnSelecionar.Visible = true;
        }
        private void resetarCamposCaracteristicas()
        {
            caracteristicaProduto = new CaracteristicaProduto();
            txtTitulo.Text = "";
            txtDescricaoCaracteristicaProduto.Text = "";
        }

        
        private ImagemProduto getImagemSelecionada()
        {
            DataGridViewRow p = dgvImagem.CurrentRow;
            if (p != null)
                return (ImagemProduto)p.DataBoundItem;
            return null;
        }
        private CaracteristicaProduto getCaracteristicaSelecionada()
        {
            DataGridViewRow p = dgvCaracteristicasProduto.CurrentRow;
            if (p != null)
                return (CaracteristicaProduto)p.DataBoundItem;
            return null;
        }
        
       
        

        private void btnAdcCarac_Click(object sender, EventArgs e)
        {
            if (!validarCamposCaracteristicas())
            {
                return;
            }
            obterCaracteristicaProd();
            string erro = null;
            if (caracteristicaProduto.idCaracteristica == 0)
            {
                erro = caracteristicaProdutoData.adicionarCaracteristica(caracteristicaProduto);
            }
            else
            {
                erro = caracteristicaProdutoData.editarCaracteristica(caracteristicaProduto);
            }
            if (erro == null)
            {
                MessageBox.Show("Caracteristica salva com sucesso!");
                tabProdutos.SelectedIndex = 2;
                ((Control)this.tabDetalhesProduto).Enabled = true;
                resetarCamposCaracteristicas();
                atualizarTabelaCaracteristicas();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o produto." + erro);
                tabProdutos.SelectedIndex = 1;
                ((Control)this.tabDetalhesProduto).Enabled = false;
            }
        }
        private void btnExcCarac_Click(object sender, EventArgs e)
        {
            string erro = caracteristicaProdutoData.excluirCaracteristica(getCaracteristicaSelecionada());

            if (erro == null)
            {
                MessageBox.Show("Caracteristica excluida com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir caracteristica.");
            }
            atualizarTabelaCaracteristicas();
        }

        private void btnExcluirImagem_Click(object sender, EventArgs e)
        {
            string erro = imagemProdutoData.excluirImagemProduto(getImagemSelecionada());

            if (erro == null)
            {
                MessageBox.Show("Imagem excluida com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir imagem.");
            }
            atualizarTabelaImagens();
            resetarCamposImagem();
        }

        

        
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            atualizarTabela();
        }
        public void atualizarTabela()
        {
            var lista = from p in produtoData.todosProdutos()
                        where p.nome.ToLower().Contains(txtPesquisar.Text.ToLower())
                        select p;
            dgvProduto.DataSource = lista.ToList();
        }
        public void atualizarTabelaCaracteristicas()
        {
            var lista = from cp in caracteristicaProdutoData.todasCaracteristicas()
                        where cp.idProduto == produto.idProduto
                        select cp;
            dgvCaracteristicasProduto.DataSource = lista.ToList();
        }
        public void atualizarTabelaImagens()
        {
            var lista = from ip in imagemProdutoData.todasImagemProdutos()
                        where ip.idProduto == produto.idProduto
                        select ip;
            dgvImagem.DataSource = lista.ToList();
        }


      
        private void dgvImagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("OK");
        }

  

        private string geraNomeImagem() {
            string caracteresValidos = "abcdefghijklmnopqrstuvwxyz1234567890";
            int valormaximo = caracteresValidos.Length;
            Random random = new Random(DateTime.Now.Millisecond);
            StringBuilder nomeImg = new StringBuilder(10);
            for (int indice = 0; indice < 10; indice++)
            {
                nomeImg.Append(caracteresValidos[random.Next(valormaximo - 1)]);
            }
            return nomeImg.ToString();
        }

        private void salvarCaminhoImagem()
        {
            string erro = null;
            if (imagemProduto.idAlbumFoto == 0)
            {
                erro = imagemProdutoData.adicionarImagemProduto(imagemProduto);
            }
            else
            {
                erro = imagemProdutoData.editarImagemProduto(imagemProduto);
            }
            if (erro == null)
            {
                MessageBox.Show("Imagem salva com sucesso!");
                tabProdutos.SelectedIndex = 2;
                ((Control)this.tabDetalhesProduto).Enabled = true;
                resetarCamposImagem();
                atualizarTabelaImagens();
           }
            else
            {
                MessageBox.Show("Erro ao salvar a imagem." + erro);
                tabProdutos.SelectedIndex = 1;
                ((Control)this.tabDetalhesProduto).Enabled = false;
            }   
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgAbrir = new OpenFileDialog();
            dlgAbrir.Filter = "Arquivos de Imagem | *.png";
            dlgAbrir.ShowDialog();
            string nomeArquivo = dlgAbrir.FileName;
            picImagem.ImageLocation = nomeArquivo;
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            string diretorio = Directory.GetCurrentDirectory();
            int posicao = diretorio.IndexOf("\\bin\\Debug");
            diretorio = diretorio.Substring(0, posicao);
            diretorio = diretorio + "\\Assets\\Img";
            string nomeImagem = geraNomeImagem();
            MessageBox.Show("Nome da Imagem no Diretorio: " + nomeImagem);
            nameImg.Text = nomeImagem;
            picImagem.Image.Save(diretorio + "\\" + nomeImagem + ".png", ImageFormat.Png);

            obterImagemProduto();
            salvarCaminhoImagem();
        }

  
        private void dgvImagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            imagemProduto = getImagemSelecionada();

            string diretorio = Directory.GetCurrentDirectory();
            int posicao = diretorio.IndexOf("\\bin\\Debug");
            diretorio = diretorio.Substring(0, posicao);
            diretorio = diretorio + "\\Assets\\Img";
            diretorio = diretorio + "\\" + imagemProduto.caminho + ".png";

            nameImg.Text = diretorio;
            picImagem.ImageLocation = nameImg.Text;
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dgvCaracteristicasProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            caracteristicaProduto = getCaracteristicaSelecionada();
            txtTitulo.Text = caracteristicaProduto.titulo;
            txtDescricaoCaracteristicaProduto.Text = caracteristicaProduto.descricao;
        }
        

        
    }
}
