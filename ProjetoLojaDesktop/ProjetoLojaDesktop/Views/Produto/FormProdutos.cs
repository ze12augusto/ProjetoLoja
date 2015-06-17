using System.Drawing.Imaging;
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
using System.IO;

namespace ProjetoLojaDesktop.Forms
{
    public partial class FormProdutos : Form
    {
        private ProjetoLojaEntities db;

        private Produto produto;
        private ProdutoVigenciaPreco vigencia;
        private CaracteristicaProduto caracteristicaProduto;
        private ImagemProduto imagemProduto;

        private ProdutoData produtoData;
        private MarcaData marcaData;
        private ModeloData modeloData;
        private ProdutoVigenciaData vigenciaData;

        private ImagemProdutoData imagemProdutoData;
        private CaracteristicaProdutoData caracteristicaProdutoData;

        private int idProduto;

        public FormProdutos()
        {
            InitializeComponent();

            db = new ProjetoLojaEntities();

            produtoData = new ProdutoData(db);
            caracteristicaProdutoData = new CaracteristicaProdutoData();
            imagemProdutoData = new ImagemProdutoData();
            marcaData = new MarcaData();
            modeloData = new ModeloData();
            vigenciaData = new ProdutoVigenciaData(db);
            produto = new Produto();
            caracteristicaProduto = new CaracteristicaProduto();
            imagemProduto = new ImagemProduto();
            ((Control)this.tabProduto).Enabled = false;
            ((Control)this.tabDetalhesProduto).Enabled = false;
            ((Control)this.tabVigencia).Enabled = false;
            idProduto = 0;
            inicializar();
        }
        private void inicializar()
        {
            resetarCampos();
            inicializarDataGridView();
            inicializarDataGridViewImagens();
            inicializarDataGridViewCaracteristicas();
            inicializarDataGridViewVigencia();
            atualizarTabelaCaracteristicas();
            atualizarTabelaImagens();
            atualizarTabelaVigencia();
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
            //produto.Modelo.Marca.idMarca = (int)cbxMarca.SelectedValue;
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
                idProduto = produto.idProduto;
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
                cbxMarca.SelectedValue = produto.Modelo.Marca.idMarca;
                cbxModelo.SelectedValue = produto.idModelo;
                idProduto = produto.idProduto;
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
        private void inicializarDataGridViewVigencia()
        {
            dgvVigencia.DataSource = vigenciaData.todosProdutoVigencia();
            dgvVigencia.Columns[0].Visible = false;
            dgvVigencia.Columns[1].Visible = false;
            dgvVigencia.Columns[5].Visible = false;
            dgvVigencia.Columns[2].HeaderText = "Data Início";
            dgvVigencia.Columns[3].HeaderText = "Data Fim";
            dgvVigencia.Columns[4].HeaderText = "Preço";
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
            imagemProduto.idProduto = idProduto;
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
        private void resetarCamposVigencia()
        {
            mtxtPreco.Text = "";
            dtpDataInicio.Value = DateTime.Now.Date;
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
        public void atualizarTabelaVigencia()
        {
            var lista = from vg in vigenciaData.todosProdutoVigencia()
                        where vg.idProduto == produto.idProduto
                        select vg;
            dgvVigencia.DataSource = lista.ToList();
        }
        private void dgvImagem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private string geraNomeImagem()
        {
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
            int posicao = diretorio.IndexOf("\\ProjetoLojaDesktop\\bin\\Debug");
            diretorio = diretorio.Substring(0, posicao);
            diretorio = diretorio + "\\ProjetoLojaWeb\\Assets\\Img";
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

        private void btnVigencia_Click(object sender, EventArgs e)
        {
            tabProdutos.SelectedIndex = 3;
            ((Control)this.tabVigencia).Enabled = true;
            produto = getProdutoSelecionado();
            inicializarDataGridViewVigencia();
            atualizarTabelaVigencia();
            btnEditarVigencia.Enabled = false;
            mtxtPreco.Enabled = false;
            dtpDataInicio.Enabled = false;
        }
        private void btnNovoVigencia_Click(object sender, EventArgs e)
        {
            mtxtPreco.Enabled = true;
            dtpDataInicio.Enabled = true;
            resetarCamposVigencia();
        }
        private void btnSalvarVigencia_Click(object sender, EventArgs e)
        {

            produto = getProdutoSelecionado();
            if (validarVigencia())
            {
                string erro = null;

                ProdutoVigenciaPreco antigo = vigenciaData.obterUltimaVigencia(produto.idProduto);
                if (antigo != null)
                {
                    antigo.dataVigenciaFim = dtpDataInicio.Value.Date.AddDays(-1);
                    erro = vigenciaData.editarProdutoVigencia(antigo);
                }
                ProdutoVigenciaPreco novo = new ProdutoVigenciaPreco();
                novo.preco = (float)Convert.ToDouble(mtxtPreco.Text);
                novo.dataVigenciaInicio = dtpDataInicio.Value.Date;
                novo.dataVigenciaFim = null;
                novo.idProduto = produto.idProduto;
                erro = vigenciaData.adicionarProdutoVigencia(novo);
                resetarCamposVigencia();
                inicializarDataGridViewVigencia();
                atualizarTabelaVigencia();
            }
        }
        private ProdutoVigenciaPreco getVigenciaSelecionada()
        {
            DataGridViewRow p = dgvVigencia.CurrentRow;
            if (p != null)
                return (ProdutoVigenciaPreco)p.DataBoundItem;
            return null;
        }
        private void dgvVigencia_SelectionChanged(object sender, EventArgs e)
        {
            vigencia = getVigenciaSelecionada();

            if (vigencia != null && vigencia.dataVigenciaInicio > DateTime.Now.Date)
            {
                btnEditarVigencia.Enabled = true;
            }
            else
            {
                btnEditarVigencia.Enabled = false;
            }
        }
        public bool validarVigencia()
        {
            if (vigenciaData.verificarVigenciaExistente(dtpDataInicio.Value.Date,produto.idProduto) == false)
            {
                MessageBox.Show("VigÊncia Cadastrada");
                return false;
            }
            return true;
        }

        private void btnEditarVigencia_Click(object sender, EventArgs e)
        {
            resetarCamposVigencia();
            vigencia = getVigenciaSelecionada();
            if (vigencia != null)
            {
                mtxtPreco.Enabled = true;
                dtpDataInicio.Enabled = true;
                mtxtPreco.Text = vigencia.preco.ToString();
                dtpDataInicio.Value = vigencia.dataVigenciaInicio;
            }
            else
            {
                MessageBox.Show("Nenhuma vigência selecionada!");
            }

        }



    }
}