namespace ProjetoLojaDesktop.Forms
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDetalhesProduto = new System.Windows.Forms.TabPage();
            this.nameImg = new System.Windows.Forms.Label();
            this.IdProduto = new System.Windows.Forms.Label();
            this.dgvCaracteristicasProduto = new System.Windows.Forms.DataGridView();
            this.txtDescricaoCaracteristicaProduto = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvImagem = new System.Windows.Forms.DataGridView();
            this.lblImagem = new System.Windows.Forms.Label();
            this.tabListaProduto = new System.Windows.Forms.TabPage();
            this.btnVigencia = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQtdMinima = new System.Windows.Forms.Label();
            this.lblQtdAtual = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtdA = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQtdM = new System.Windows.Forms.TextBox();
            this.tabVigencia = new System.Windows.Forms.TabPage();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarVigencia = new System.Windows.Forms.Button();
            this.btnNovoVigencia = new System.Windows.Forms.Button();
            this.mtxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblVigenciaPreco = new System.Windows.Forms.Label();
            this.btnEditarVigencia = new System.Windows.Forms.Button();
            this.dgvVigencia = new System.Windows.Forms.DataGridView();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnExcCarac = new System.Windows.Forms.Button();
            this.btnAdcCarac = new System.Windows.Forms.Button();
            this.btnExcluirImagem = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tabDetalhesProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicasProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).BeginInit();
            this.tabListaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.tabProdutos.SuspendLayout();
            this.tabProduto.SuspendLayout();
            this.tabVigencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVigencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetalhesProduto
            // 
            this.tabDetalhesProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetalhesProduto.Controls.Add(this.picImagem);
            this.tabDetalhesProduto.Controls.Add(this.nameImg);
            this.tabDetalhesProduto.Controls.Add(this.IdProduto);
            this.tabDetalhesProduto.Controls.Add(this.btnExcCarac);
            this.tabDetalhesProduto.Controls.Add(this.btnAdcCarac);
            this.tabDetalhesProduto.Controls.Add(this.dgvCaracteristicasProduto);
            this.tabDetalhesProduto.Controls.Add(this.txtDescricaoCaracteristicaProduto);
            this.tabDetalhesProduto.Controls.Add(this.txtTitulo);
            this.tabDetalhesProduto.Controls.Add(this.label1);
            this.tabDetalhesProduto.Controls.Add(this.btnExcluirImagem);
            this.tabDetalhesProduto.Controls.Add(this.dgvImagem);
            this.tabDetalhesProduto.Controls.Add(this.btnSelecionar);
            this.tabDetalhesProduto.Controls.Add(this.lblImagem);
            this.tabDetalhesProduto.Location = new System.Drawing.Point(4, 22);
            this.tabDetalhesProduto.Name = "tabDetalhesProduto";
            this.tabDetalhesProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalhesProduto.Size = new System.Drawing.Size(703, 365);
            this.tabDetalhesProduto.TabIndex = 2;
            this.tabDetalhesProduto.Text = "Detalhes";
            // 
            // nameImg
            // 
            this.nameImg.AutoSize = true;
            this.nameImg.Location = new System.Drawing.Point(487, 34);
            this.nameImg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameImg.Name = "nameImg";
            this.nameImg.Size = new System.Drawing.Size(35, 13);
            this.nameImg.TabIndex = 46;
            this.nameImg.Text = "label2";
            this.nameImg.Visible = false;
            // 
            // IdProduto
            // 
            this.IdProduto.AutoSize = true;
            this.IdProduto.Location = new System.Drawing.Point(487, 20);
            this.IdProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Size = new System.Drawing.Size(35, 13);
            this.IdProduto.TabIndex = 44;
            this.IdProduto.Text = "label2";
            this.IdProduto.Visible = false;
            // 
            // dgvCaracteristicasProduto
            // 
            this.dgvCaracteristicasProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicasProduto.Location = new System.Drawing.Point(88, 225);
            this.dgvCaracteristicasProduto.Name = "dgvCaracteristicasProduto";
            this.dgvCaracteristicasProduto.Size = new System.Drawing.Size(313, 87);
            this.dgvCaracteristicasProduto.TabIndex = 41;
            this.dgvCaracteristicasProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaracteristicasProduto_CellContentClick);
            // 
            // txtDescricaoCaracteristicaProduto
            // 
            this.txtDescricaoCaracteristicaProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDescricaoCaracteristicaProduto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDescricaoCaracteristicaProduto.Location = new System.Drawing.Point(88, 154);
            this.txtDescricaoCaracteristicaProduto.Multiline = true;
            this.txtDescricaoCaracteristicaProduto.Name = "txtDescricaoCaracteristicaProduto";
            this.txtDescricaoCaracteristicaProduto.Size = new System.Drawing.Size(313, 58);
            this.txtDescricaoCaracteristicaProduto.TabIndex = 40;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(87, 122);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(313, 20);
            this.txtTitulo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Caracteristicas";
            // 
            // dgvImagem
            // 
            this.dgvImagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagem.Location = new System.Drawing.Point(118, 20);
            this.dgvImagem.Name = "dgvImagem";
            this.dgvImagem.Size = new System.Drawing.Size(283, 85);
            this.dgvImagem.TabIndex = 36;
            this.dgvImagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImagem_CellContentClick);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(41, 25);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(44, 13);
            this.lblImagem.TabIndex = 34;
            this.lblImagem.Text = "Imagem";
            // 
            // tabListaProduto
            // 
            this.tabListaProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tabListaProduto.Controls.Add(this.btnVigencia);
            this.tabListaProduto.Controls.Add(this.btnExcluirProduto);
            this.tabListaProduto.Controls.Add(this.btnEditarProduto);
            this.tabListaProduto.Controls.Add(this.btnNovoProduto);
            this.tabListaProduto.Controls.Add(this.dgvProduto);
            this.tabListaProduto.Controls.Add(this.txtPesquisar);
            this.tabListaProduto.Controls.Add(this.lbPesquisar);
            this.tabListaProduto.Location = new System.Drawing.Point(4, 22);
            this.tabListaProduto.Name = "tabListaProduto";
            this.tabListaProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaProduto.Size = new System.Drawing.Size(703, 365);
            this.tabListaProduto.TabIndex = 0;
            this.tabListaProduto.Text = "Lista de Produtos";
            // 
            // btnVigencia
            // 
            this.btnVigencia.Location = new System.Drawing.Point(19, 267);
            this.btnVigencia.Name = "btnVigencia";
            this.btnVigencia.Size = new System.Drawing.Size(147, 25);
            this.btnVigencia.TabIndex = 6;
            this.btnVigencia.Text = "Visualizar Vigência";
            this.btnVigencia.UseVisualStyleBackColor = true;
            this.btnVigencia.Click += new System.EventHandler(this.btnVigencia_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(20, 55);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(417, 199);
            this.dgvProduto.TabIndex = 2;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(129, 22);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(308, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(21, 25);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(105, 13);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.Text = "Pesquisar por Nome:";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabListaProduto);
            this.tabProdutos.Controls.Add(this.tabProduto);
            this.tabProdutos.Controls.Add(this.tabDetalhesProduto);
            this.tabProdutos.Controls.Add(this.tabVigencia);
            this.tabProdutos.Location = new System.Drawing.Point(12, 12);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(711, 391);
            this.tabProdutos.TabIndex = 16;
            // 
            // tabProduto
            // 
            this.tabProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tabProduto.Controls.Add(this.btnCancelar);
            this.tabProduto.Controls.Add(this.lblNome);
            this.tabProduto.Controls.Add(this.lblDescricao);
            this.tabProduto.Controls.Add(this.lblQtdMinima);
            this.tabProduto.Controls.Add(this.lblQtdAtual);
            this.tabProduto.Controls.Add(this.lblModelo);
            this.tabProduto.Controls.Add(this.cbxMarca);
            this.tabProduto.Controls.Add(this.cbxModelo);
            this.tabProduto.Controls.Add(this.lblMarca);
            this.tabProduto.Controls.Add(this.txtNome);
            this.tabProduto.Controls.Add(this.txtQtdA);
            this.tabProduto.Controls.Add(this.txtDescricao);
            this.tabProduto.Controls.Add(this.txtQtdM);
            this.tabProduto.Controls.Add(this.btnSalvar);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(703, 365);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produtos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(61, 61);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblQtdMinima
            // 
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Location = new System.Drawing.Point(19, 93);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(98, 13);
            this.lblQtdMinima.TabIndex = 18;
            this.lblQtdMinima.Text = "Quantidade Minima";
            // 
            // lblQtdAtual
            // 
            this.lblQtdAtual.AutoSize = true;
            this.lblQtdAtual.Location = new System.Drawing.Point(237, 96);
            this.lblQtdAtual.Name = "lblQtdAtual";
            this.lblQtdAtual.Size = new System.Drawing.Size(89, 13);
            this.lblQtdAtual.TabIndex = 19;
            this.lblQtdAtual.Text = "Quantidade Atual";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(285, 128);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(119, 124);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(110, 21);
            this.cbxMarca.TabIndex = 27;
            // 
            // cbxModelo
            // 
            this.cbxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(329, 124);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(110, 21);
            this.cbxModelo.TabIndex = 21;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(79, 128);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 20);
            this.txtNome.TabIndex = 22;
            // 
            // txtQtdA
            // 
            this.txtQtdA.Location = new System.Drawing.Point(329, 92);
            this.txtQtdA.Name = "txtQtdA";
            this.txtQtdA.Size = new System.Drawing.Size(110, 20);
            this.txtQtdA.TabIndex = 25;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(119, 60);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(320, 20);
            this.txtDescricao.TabIndex = 23;
            // 
            // txtQtdM
            // 
            this.txtQtdM.Location = new System.Drawing.Point(119, 92);
            this.txtQtdM.Name = "txtQtdM";
            this.txtQtdM.Size = new System.Drawing.Size(110, 20);
            this.txtQtdM.TabIndex = 24;
            // 
            // tabVigencia
            // 
            this.tabVigencia.BackColor = System.Drawing.SystemColors.Control;
            this.tabVigencia.Controls.Add(this.dtpDataInicio);
            this.tabVigencia.Controls.Add(this.btnSalvarVigencia);
            this.tabVigencia.Controls.Add(this.btnNovoVigencia);
            this.tabVigencia.Controls.Add(this.mtxtPreco);
            this.tabVigencia.Controls.Add(this.lblDataInicio);
            this.tabVigencia.Controls.Add(this.lblVigenciaPreco);
            this.tabVigencia.Controls.Add(this.btnEditarVigencia);
            this.tabVigencia.Controls.Add(this.dgvVigencia);
            this.tabVigencia.Location = new System.Drawing.Point(4, 22);
            this.tabVigencia.Name = "tabVigencia";
            this.tabVigencia.Padding = new System.Windows.Forms.Padding(3);
            this.tabVigencia.Size = new System.Drawing.Size(703, 365);
            this.tabVigencia.TabIndex = 3;
            this.tabVigencia.Text = "Vigência";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(217, 266);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpDataInicio.TabIndex = 12;
            // 
            // btnSalvarVigencia
            // 
            this.btnSalvarVigencia.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvarVigencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarVigencia.Location = new System.Drawing.Point(497, 266);
            this.btnSalvarVigencia.Name = "btnSalvarVigencia";
            this.btnSalvarVigencia.Size = new System.Drawing.Size(70, 25);
            this.btnSalvarVigencia.TabIndex = 11;
            this.btnSalvarVigencia.Text = "Salvar";
            this.btnSalvarVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarVigencia.UseVisualStyleBackColor = true;
            this.btnSalvarVigencia.Click += new System.EventHandler(this.btnSalvarVigencia_Click);
            // 
            // btnNovoVigencia
            // 
            this.btnNovoVigencia.Image = global::ProjetoLojaDesktop.Properties.Resources.Document_02;
            this.btnNovoVigencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoVigencia.Location = new System.Drawing.Point(351, 266);
            this.btnNovoVigencia.Name = "btnNovoVigencia";
            this.btnNovoVigencia.Size = new System.Drawing.Size(70, 25);
            this.btnNovoVigencia.TabIndex = 10;
            this.btnNovoVigencia.Text = "Novo";
            this.btnNovoVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoVigencia.UseVisualStyleBackColor = true;
            this.btnNovoVigencia.Click += new System.EventHandler(this.btnNovoVigencia_Click);
            // 
            // mtxtPreco
            // 
            this.mtxtPreco.Location = new System.Drawing.Point(54, 266);
            this.mtxtPreco.Name = "mtxtPreco";
            this.mtxtPreco.Size = new System.Drawing.Size(92, 20);
            this.mtxtPreco.TabIndex = 7;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(156, 270);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(58, 13);
            this.lblDataInicio.TabIndex = 5;
            this.lblDataInicio.Text = "Data Inicio";
            // 
            // lblVigenciaPreco
            // 
            this.lblVigenciaPreco.AutoSize = true;
            this.lblVigenciaPreco.Location = new System.Drawing.Point(16, 269);
            this.lblVigenciaPreco.Name = "lblVigenciaPreco";
            this.lblVigenciaPreco.Size = new System.Drawing.Size(35, 13);
            this.lblVigenciaPreco.TabIndex = 4;
            this.lblVigenciaPreco.Text = "Preço";
            // 
            // btnEditarVigencia
            // 
            this.btnEditarVigencia.Image = global::ProjetoLojaDesktop.Properties.Resources.Data_Edit;
            this.btnEditarVigencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarVigencia.Location = new System.Drawing.Point(424, 266);
            this.btnEditarVigencia.Name = "btnEditarVigencia";
            this.btnEditarVigencia.Size = new System.Drawing.Size(70, 25);
            this.btnEditarVigencia.TabIndex = 2;
            this.btnEditarVigencia.Text = "Editar";
            this.btnEditarVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarVigencia.UseVisualStyleBackColor = true;
            this.btnEditarVigencia.Click += new System.EventHandler(this.btnEditarVigencia_Click);
            // 
            // dgvVigencia
            // 
            this.dgvVigencia.AllowUserToAddRows = false;
            this.dgvVigencia.AllowUserToDeleteRows = false;
            this.dgvVigencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVigencia.Location = new System.Drawing.Point(16, 18);
            this.dgvVigencia.MultiSelect = false;
            this.dgvVigencia.Name = "dgvVigencia";
            this.dgvVigencia.ReadOnly = true;
            this.dgvVigencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVigencia.Size = new System.Drawing.Size(551, 236);
            this.dgvVigencia.TabIndex = 0;
            this.dgvVigencia.SelectionChanged += new System.EventHandler(this.dgvVigencia_SelectionChanged);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.Location = new System.Drawing.Point(367, 267);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(70, 25);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Data_Edit;
            this.btnEditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProduto.Location = new System.Drawing.Point(293, 267);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(70, 25);
            this.btnEditarProduto.TabIndex = 4;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Document_02;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.Location = new System.Drawing.Point(219, 267);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(70, 25);
            this.btnNovoProduto.TabIndex = 3;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(370, 157);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 25);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(296, 157);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 25);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picImagem.Location = new System.Drawing.Point(407, 20);
            this.picImagem.Margin = new System.Windows.Forms.Padding(2);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(279, 292);
            this.picImagem.TabIndex = 45;
            this.picImagem.TabStop = false;
            // 
            // btnExcCarac
            // 
            this.btnExcCarac.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnExcCarac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcCarac.Location = new System.Drawing.Point(330, 325);
            this.btnExcCarac.Name = "btnExcCarac";
            this.btnExcCarac.Size = new System.Drawing.Size(70, 25);
            this.btnExcCarac.TabIndex = 43;
            this.btnExcCarac.Text = "Excluir";
            this.btnExcCarac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcCarac.UseVisualStyleBackColor = true;
            this.btnExcCarac.Click += new System.EventHandler(this.btnExcCarac_Click);
            // 
            // btnAdcCarac
            // 
            this.btnAdcCarac.Image = global::ProjetoLojaDesktop.Properties.Resources.Add_New;
            this.btnAdcCarac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdcCarac.Location = new System.Drawing.Point(251, 325);
            this.btnAdcCarac.Name = "btnAdcCarac";
            this.btnAdcCarac.Size = new System.Drawing.Size(75, 25);
            this.btnAdcCarac.TabIndex = 42;
            this.btnAdcCarac.Text = "Adcionar";
            this.btnAdcCarac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdcCarac.UseVisualStyleBackColor = true;
            this.btnAdcCarac.Click += new System.EventHandler(this.btnAdcCarac_Click);
            // 
            // btnExcluirImagem
            // 
            this.btnExcluirImagem.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnExcluirImagem.Location = new System.Drawing.Point(87, 49);
            this.btnExcluirImagem.Name = "btnExcluirImagem";
            this.btnExcluirImagem.Size = new System.Drawing.Size(25, 25);
            this.btnExcluirImagem.TabIndex = 37;
            this.btnExcluirImagem.UseVisualStyleBackColor = true;
            this.btnExcluirImagem.Click += new System.EventHandler(this.btnExcluirImagem_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::ProjetoLojaDesktop.Properties.Resources.Add_New;
            this.btnSelecionar.Location = new System.Drawing.Point(87, 20);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(25, 25);
            this.btnSelecionar.TabIndex = 35;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 418);
            this.Controls.Add(this.tabProdutos);
            this.Name = "FormProdutos";
            this.Text = "Produto";
            this.tabDetalhesProduto.ResumeLayout(false);
            this.tabDetalhesProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicasProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).EndInit();
            this.tabListaProduto.ResumeLayout(false);
            this.tabListaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.tabProdutos.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            this.tabVigencia.ResumeLayout(false);
            this.tabVigencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVigencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabDetalhesProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirImagem;
        private System.Windows.Forms.DataGridView dgvImagem;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.TabPage tabListaProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQtdMinima;
        private System.Windows.Forms.Label lblQtdAtual;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtdA;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtQtdM;
        private System.Windows.Forms.Button btnExcCarac;
        private System.Windows.Forms.Button btnAdcCarac;
        private System.Windows.Forms.DataGridView dgvCaracteristicasProduto;
        private System.Windows.Forms.TextBox txtDescricaoCaracteristicaProduto;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label IdProduto;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label nameImg;
        private System.Windows.Forms.Button btnVigencia;
        private System.Windows.Forms.TabPage tabVigencia;
        private System.Windows.Forms.Button btnEditarVigencia;
        private System.Windows.Forms.DataGridView dgvVigencia;
        private System.Windows.Forms.MaskedTextBox mtxtPreco;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblVigenciaPreco;
        private System.Windows.Forms.Button btnSalvarVigencia;
        private System.Windows.Forms.Button btnNovoVigencia;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;


    }
}