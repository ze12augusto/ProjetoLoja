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
            this.IdProduto = new System.Windows.Forms.Label();
            this.btnExcCarac = new System.Windows.Forms.Button();
            this.btnAdcCarac = new System.Windows.Forms.Button();
            this.dgvCaracteristicasProduto = new System.Windows.Forms.DataGridView();
            this.txtDescricaoCaracteristicaProduto = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirImagem = new System.Windows.Forms.Button();
            this.dgvImagem = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.tabListaProduto = new System.Windows.Forms.TabPage();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
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
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.nameImg = new System.Windows.Forms.Label();
            this.tabDetalhesProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicasProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).BeginInit();
            this.tabListaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.tabProdutos.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetalhesProduto
            // 
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
            this.tabDetalhesProduto.Location = new System.Drawing.Point(4, 25);
            this.tabDetalhesProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tabDetalhesProduto.Name = "tabDetalhesProduto";
            this.tabDetalhesProduto.Padding = new System.Windows.Forms.Padding(4);
            this.tabDetalhesProduto.Size = new System.Drawing.Size(1226, 452);
            this.tabDetalhesProduto.TabIndex = 2;
            this.tabDetalhesProduto.Text = "Detalhes";
            this.tabDetalhesProduto.UseVisualStyleBackColor = true;
            // 
            // IdProduto
            // 
            this.IdProduto.AutoSize = true;
            this.IdProduto.Location = new System.Drawing.Point(649, 25);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Size = new System.Drawing.Size(46, 17);
            this.IdProduto.TabIndex = 44;
            this.IdProduto.Text = "label2";
            this.IdProduto.Visible = false;
            // 
            // btnExcCarac
            // 
            this.btnExcCarac.Location = new System.Drawing.Point(543, 391);
            this.btnExcCarac.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcCarac.Name = "btnExcCarac";
            this.btnExcCarac.Size = new System.Drawing.Size(100, 28);
            this.btnExcCarac.TabIndex = 43;
            this.btnExcCarac.Text = "Excluir";
            this.btnExcCarac.UseVisualStyleBackColor = true;
            this.btnExcCarac.Click += new System.EventHandler(this.btnExcCarac_Click);
            // 
            // btnAdcCarac
            // 
            this.btnAdcCarac.Location = new System.Drawing.Point(435, 391);
            this.btnAdcCarac.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdcCarac.Name = "btnAdcCarac";
            this.btnAdcCarac.Size = new System.Drawing.Size(100, 28);
            this.btnAdcCarac.TabIndex = 42;
            this.btnAdcCarac.Text = "Adcionar";
            this.btnAdcCarac.UseVisualStyleBackColor = true;
            this.btnAdcCarac.Click += new System.EventHandler(this.btnAdcCarac_Click);
            // 
            // dgvCaracteristicasProduto
            // 
            this.dgvCaracteristicasProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicasProduto.Location = new System.Drawing.Point(117, 277);
            this.dgvCaracteristicasProduto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaracteristicasProduto.Name = "dgvCaracteristicasProduto";
            this.dgvCaracteristicasProduto.Size = new System.Drawing.Size(525, 107);
            this.dgvCaracteristicasProduto.TabIndex = 41;
            this.dgvCaracteristicasProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaracteristicasProduto_CellContentClick);
            // 
            // txtDescricaoCaracteristicaProduto
            // 
            this.txtDescricaoCaracteristicaProduto.Location = new System.Drawing.Point(117, 198);
            this.txtDescricaoCaracteristicaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoCaracteristicaProduto.Multiline = true;
            this.txtDescricaoCaracteristicaProduto.Name = "txtDescricaoCaracteristicaProduto";
            this.txtDescricaoCaracteristicaProduto.Size = new System.Drawing.Size(524, 70);
            this.txtDescricaoCaracteristicaProduto.TabIndex = 40;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(117, 166);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(524, 22);
            this.txtTitulo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Caracteristicas";
            // 
            // btnExcluirImagem
            // 
            this.btnExcluirImagem.Location = new System.Drawing.Point(118, 102);
            this.btnExcluirImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirImagem.Name = "btnExcluirImagem";
            this.btnExcluirImagem.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirImagem.TabIndex = 37;
            this.btnExcluirImagem.Text = "Excluir";
            this.btnExcluirImagem.UseVisualStyleBackColor = true;
            this.btnExcluirImagem.Click += new System.EventHandler(this.btnExcluirImagem_Click);
            // 
            // dgvImagem
            // 
            this.dgvImagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagem.Location = new System.Drawing.Point(225, 25);
            this.dgvImagem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvImagem.Name = "dgvImagem";
            this.dgvImagem.Size = new System.Drawing.Size(417, 105);
            this.dgvImagem.TabIndex = 36;
            this.dgvImagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImagem_CellContentClick);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(117, 25);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(100, 28);
            this.btnSelecionar.TabIndex = 35;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(51, 31);
            this.lblImagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(57, 17);
            this.lblImagem.TabIndex = 34;
            this.lblImagem.Text = "Imagem";
            // 
            // tabListaProduto
            // 
            this.tabListaProduto.Controls.Add(this.btnExcluirProduto);
            this.tabListaProduto.Controls.Add(this.btnEditarProduto);
            this.tabListaProduto.Controls.Add(this.btnNovoProduto);
            this.tabListaProduto.Controls.Add(this.dgvProduto);
            this.tabListaProduto.Controls.Add(this.txtPesquisar);
            this.tabListaProduto.Controls.Add(this.lbPesquisar);
            this.tabListaProduto.Location = new System.Drawing.Point(4, 25);
            this.tabListaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tabListaProduto.Name = "tabListaProduto";
            this.tabListaProduto.Padding = new System.Windows.Forms.Padding(4);
            this.tabListaProduto.Size = new System.Drawing.Size(723, 452);
            this.tabListaProduto.TabIndex = 0;
            this.tabListaProduto.Text = "Lista de Produtos";
            this.tabListaProduto.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(591, 401);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(483, 401);
            this.btnEditarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(100, 28);
            this.btnEditarProduto.TabIndex = 4;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(375, 401);
            this.btnNovoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(100, 28);
            this.btnNovoProduto.TabIndex = 3;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(27, 79);
            this.dgvProduto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(664, 308);
            this.dgvProduto.TabIndex = 2;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(192, 27);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(497, 22);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(28, 31);
            this.lbPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(141, 17);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.Text = "Pesquisar por Nome:";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabListaProduto);
            this.tabProdutos.Controls.Add(this.tabProduto);
            this.tabProdutos.Controls.Add(this.tabDetalhesProduto);
            this.tabProdutos.Location = new System.Drawing.Point(16, 15);
            this.tabProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(1234, 481);
            this.tabProdutos.TabIndex = 16;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.btnCancelar);
            this.tabProduto.Controls.Add(this.lblNome);
            this.tabProduto.Controls.Add(this.btnSalvar);
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
            this.tabProduto.Location = new System.Drawing.Point(4, 25);
            this.tabProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(4);
            this.tabProduto.Size = new System.Drawing.Size(723, 452);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produtos";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(584, 219);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(89, 54);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(476, 219);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(72, 86);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblQtdMinima
            // 
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Location = new System.Drawing.Point(15, 122);
            this.lblQtdMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(130, 17);
            this.lblQtdMinima.TabIndex = 18;
            this.lblQtdMinima.Text = "Quantidade Minima";
            // 
            // lblQtdAtual
            // 
            this.lblQtdAtual.AutoSize = true;
            this.lblQtdAtual.Location = new System.Drawing.Point(387, 124);
            this.lblQtdAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdAtual.Name = "lblQtdAtual";
            this.lblQtdAtual.Size = new System.Drawing.Size(118, 17);
            this.lblQtdAtual.TabIndex = 19;
            this.lblQtdAtual.Text = "Quantidade Atual";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(449, 172);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(159, 165);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(191, 24);
            this.cbxMarca.TabIndex = 27;
            // 
            // cbxModelo
            // 
            this.cbxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(513, 165);
            this.cbxModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(169, 24);
            this.cbxModelo.TabIndex = 21;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(96, 165);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(524, 22);
            this.txtNome.TabIndex = 22;
            // 
            // txtQtdA
            // 
            this.txtQtdA.Location = new System.Drawing.Point(513, 119);
            this.txtQtdA.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdA.Name = "txtQtdA";
            this.txtQtdA.Size = new System.Drawing.Size(169, 22);
            this.txtQtdA.TabIndex = 25;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(159, 82);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(524, 22);
            this.txtDescricao.TabIndex = 23;
            // 
            // txtQtdM
            // 
            this.txtQtdM.Location = new System.Drawing.Point(159, 119);
            this.txtQtdM.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdM.Name = "txtQtdM";
            this.txtQtdM.Size = new System.Drawing.Size(191, 22);
            this.txtQtdM.TabIndex = 24;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(652, 25);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(548, 359);
            this.picImagem.TabIndex = 45;
            this.picImagem.TabStop = false;
            // 
            // nameImg
            // 
            this.nameImg.AutoSize = true;
            this.nameImg.Location = new System.Drawing.Point(649, 42);
            this.nameImg.Name = "nameImg";
            this.nameImg.Size = new System.Drawing.Size(46, 17);
            this.nameImg.TabIndex = 46;
            this.nameImg.Text = "label2";
            this.nameImg.Visible = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 514);
            this.Controls.Add(this.tabProdutos);
            this.Margin = new System.Windows.Forms.Padding(4);
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


    }
}