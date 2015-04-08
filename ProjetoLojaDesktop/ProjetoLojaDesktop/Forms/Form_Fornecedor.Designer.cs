namespace cad_fornecedor
{
    partial class FormFornecedor
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
            this.btnNovoPesq = new System.Windows.Forms.Button();
            this.btnEditarPesq = new System.Windows.Forms.Button();
            this.btnDesatiivarPesq = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.Fornecedores = new System.Windows.Forms.TabControl();
            this.tabFornecedor = new System.Windows.Forms.TabPage();
            this.tabDadosFornecedor = new System.Windows.Forms.TabPage();
            this.btnSalvarDadosForn = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.btnNovoEnd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.btnEditarEnd = new System.Windows.Forms.Button();
            this.btnDesativarEnd = new System.Windows.Forms.Button();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.btnSalvarEnd = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.tabTelefone = new System.Windows.Forms.TabPage();
            this.btnNovoTel = new System.Windows.Forms.Button();
            this.btnEditarTel = new System.Windows.Forms.Button();
            this.btnDesativarTel = new System.Windows.Forms.Button();
            this.btnSalvarTel = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.txtNumeroTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoTel = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.Fornecedores.SuspendLayout();
            this.tabFornecedor.SuspendLayout();
            this.tabDadosFornecedor.SuspendLayout();
            this.tabEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.tabTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoPesq
            // 
            this.btnNovoPesq.Location = new System.Drawing.Point(156, 286);
            this.btnNovoPesq.Name = "btnNovoPesq";
            this.btnNovoPesq.Size = new System.Drawing.Size(55, 23);
            this.btnNovoPesq.TabIndex = 0;
            this.btnNovoPesq.Text = "Novo";
            this.btnNovoPesq.UseVisualStyleBackColor = true;
            // 
            // btnEditarPesq
            // 
            this.btnEditarPesq.Location = new System.Drawing.Point(217, 286);
            this.btnEditarPesq.Name = "btnEditarPesq";
            this.btnEditarPesq.Size = new System.Drawing.Size(55, 23);
            this.btnEditarPesq.TabIndex = 1;
            this.btnEditarPesq.Text = "Editar";
            this.btnEditarPesq.UseVisualStyleBackColor = true;
            // 
            // btnDesatiivarPesq
            // 
            this.btnDesatiivarPesq.Location = new System.Drawing.Point(278, 286);
            this.btnDesatiivarPesq.Name = "btnDesatiivarPesq";
            this.btnDesatiivarPesq.Size = new System.Drawing.Size(68, 23);
            this.btnDesatiivarPesq.TabIndex = 2;
            this.btnDesatiivarPesq.Text = "Desativar";
            this.btnDesatiivarPesq.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(273, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(15, 14);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(252, 20);
            this.txtPesquisar.TabIndex = 4;
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(15, 42);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.Size = new System.Drawing.Size(332, 229);
            this.dgvPesquisar.TabIndex = 7;
            // 
            // Fornecedores
            // 
            this.Fornecedores.Controls.Add(this.tabFornecedor);
            this.Fornecedores.Controls.Add(this.tabDadosFornecedor);
            this.Fornecedores.Controls.Add(this.tabEndereco);
            this.Fornecedores.Controls.Add(this.tabTelefone);
            this.Fornecedores.Location = new System.Drawing.Point(10, 12);
            this.Fornecedores.Name = "Fornecedores";
            this.Fornecedores.SelectedIndex = 0;
            this.Fornecedores.Size = new System.Drawing.Size(369, 366);
            this.Fornecedores.TabIndex = 15;
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.txtPesquisar);
            this.tabFornecedor.Controls.Add(this.btnPesquisar);
            this.tabFornecedor.Controls.Add(this.dgvPesquisar);
            this.tabFornecedor.Controls.Add(this.btnNovoPesq);
            this.tabFornecedor.Controls.Add(this.btnEditarPesq);
            this.tabFornecedor.Controls.Add(this.btnDesatiivarPesq);
            this.tabFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFornecedor.Size = new System.Drawing.Size(361, 340);
            this.tabFornecedor.TabIndex = 0;
            this.tabFornecedor.Text = "Pesquisar Fornecedor";
            this.tabFornecedor.UseVisualStyleBackColor = true;
            // 
            // tabDadosFornecedor
            // 
            this.tabDadosFornecedor.Controls.Add(this.btnSalvarDadosForn);
            this.tabDadosFornecedor.Controls.Add(this.lblNome);
            this.tabDadosFornecedor.Controls.Add(this.label2);
            this.tabDadosFornecedor.Controls.Add(this.txtEmail);
            this.tabDadosFornecedor.Controls.Add(this.lblEmail);
            this.tabDadosFornecedor.Controls.Add(this.txtCnpj);
            this.tabDadosFornecedor.Controls.Add(this.txtNomeFantasia);
            this.tabDadosFornecedor.Controls.Add(this.txtRazaoSocial);
            this.tabDadosFornecedor.Controls.Add(this.lblRazaoSocial);
            this.tabDadosFornecedor.Controls.Add(this.lblNomeFantasia);
            this.tabDadosFornecedor.Controls.Add(this.lblCnpj);
            this.tabDadosFornecedor.Location = new System.Drawing.Point(4, 22);
            this.tabDadosFornecedor.Name = "tabDadosFornecedor";
            this.tabDadosFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosFornecedor.Size = new System.Drawing.Size(361, 340);
            this.tabDadosFornecedor.TabIndex = 3;
            this.tabDadosFornecedor.Text = "Dados do Fornecedor";
            this.tabDadosFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnSalvarDadosForn
            // 
            this.btnSalvarDadosForn.Location = new System.Drawing.Point(275, 187);
            this.btnSalvarDadosForn.Name = "btnSalvarDadosForn";
            this.btnSalvarDadosForn.Size = new System.Drawing.Size(68, 23);
            this.btnSalvarDadosForn.TabIndex = 48;
            this.btnSalvarDadosForn.Text = "Salvar";
            this.btnSalvarDadosForn.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(98, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(245, 20);
            this.lblNome.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 45;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(49, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(98, 131);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(245, 20);
            this.txtCnpj.TabIndex = 19;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(98, 60);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(245, 20);
            this.txtNomeFantasia.TabIndex = 15;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(98, 97);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(245, 20);
            this.txtRazaoSocial.TabIndex = 17;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(19, 100);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 16;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(11, 67);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.lblNomeFantasia.TabIndex = 14;
            this.lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(55, 131);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(37, 13);
            this.lblCnpj.TabIndex = 18;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // tabEndereco
            // 
            this.tabEndereco.Controls.Add(this.btnNovoEnd);
            this.tabEndereco.Controls.Add(this.textBox2);
            this.tabEndereco.Controls.Add(this.lblCidade);
            this.tabEndereco.Controls.Add(this.textBox1);
            this.tabEndereco.Controls.Add(this.lblComplemento);
            this.tabEndereco.Controls.Add(this.btnEditarEnd);
            this.tabEndereco.Controls.Add(this.btnDesativarEnd);
            this.tabEndereco.Controls.Add(this.dgvEndereco);
            this.tabEndereco.Controls.Add(this.btnSalvarEnd);
            this.tabEndereco.Controls.Add(this.cbxEstado);
            this.tabEndereco.Controls.Add(this.txtNumero);
            this.tabEndereco.Controls.Add(this.txtCEP);
            this.tabEndereco.Controls.Add(this.txtBairro);
            this.tabEndereco.Controls.Add(this.lblCEP);
            this.tabEndereco.Controls.Add(this.lblBairro);
            this.tabEndereco.Controls.Add(this.lblEstado);
            this.tabEndereco.Controls.Add(this.lblNumero);
            this.tabEndereco.Controls.Add(this.txtRua);
            this.tabEndereco.Controls.Add(this.lblRua);
            this.tabEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndereco.Size = new System.Drawing.Size(361, 340);
            this.tabEndereco.TabIndex = 1;
            this.tabEndereco.Text = "Endereço";
            this.tabEndereco.UseVisualStyleBackColor = true;
            // 
            // btnNovoEnd
            // 
            this.btnNovoEnd.Location = new System.Drawing.Point(24, 299);
            this.btnNovoEnd.Name = "btnNovoEnd";
            this.btnNovoEnd.Size = new System.Drawing.Size(68, 23);
            this.btnNovoEnd.TabIndex = 49;
            this.btnNovoEnd.Text = "Novo";
            this.btnNovoEnd.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 48;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(46, 118);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 47;
            this.lblCidade.Text = "Cidade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 46;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(9, 51);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 45;
            this.lblComplemento.Text = "Complemento:";
            // 
            // btnEditarEnd
            // 
            this.btnEditarEnd.Location = new System.Drawing.Point(98, 299);
            this.btnEditarEnd.Name = "btnEditarEnd";
            this.btnEditarEnd.Size = new System.Drawing.Size(68, 23);
            this.btnEditarEnd.TabIndex = 42;
            this.btnEditarEnd.Text = "Editar";
            this.btnEditarEnd.UseVisualStyleBackColor = true;
            // 
            // btnDesativarEnd
            // 
            this.btnDesativarEnd.Location = new System.Drawing.Point(172, 299);
            this.btnDesativarEnd.Name = "btnDesativarEnd";
            this.btnDesativarEnd.Size = new System.Drawing.Size(68, 23);
            this.btnDesativarEnd.TabIndex = 43;
            this.btnDesativarEnd.Text = "Desativar";
            this.btnDesativarEnd.UseVisualStyleBackColor = true;
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(12, 180);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.Size = new System.Drawing.Size(335, 99);
            this.dgvEndereco.TabIndex = 41;
            // 
            // btnSalvarEnd
            // 
            this.btnSalvarEnd.Location = new System.Drawing.Point(246, 299);
            this.btnSalvarEnd.Name = "btnSalvarEnd";
            this.btnSalvarEnd.Size = new System.Drawing.Size(68, 23);
            this.btnSalvarEnd.TabIndex = 40;
            this.btnSalvarEnd.Text = "Salvar";
            this.btnSalvarEnd.UseVisualStyleBackColor = true;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(89, 140);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(110, 21);
            this.cbxEstado.TabIndex = 35;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(315, 14);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(32, 20);
            this.txtNumero.TabIndex = 34;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(246, 140);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(101, 20);
            this.txtCEP.TabIndex = 33;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(89, 77);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(258, 20);
            this.txtBairro.TabIndex = 32;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(209, 142);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 30;
            this.lblCEP.Text = "CEP:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(46, 82);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(40, 148);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(292, 17);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(22, 13);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "N°:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(89, 14);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(192, 20);
            this.txtRua.TabIndex = 26;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(53, 21);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 25;
            this.lblRua.Text = "Rua:";
            // 
            // tabTelefone
            // 
            this.tabTelefone.Controls.Add(this.btnNovoTel);
            this.tabTelefone.Controls.Add(this.btnEditarTel);
            this.tabTelefone.Controls.Add(this.btnDesativarTel);
            this.tabTelefone.Controls.Add(this.btnSalvarTel);
            this.tabTelefone.Controls.Add(this.dgvTelefone);
            this.tabTelefone.Controls.Add(this.txtNumeroTel);
            this.tabTelefone.Controls.Add(this.label1);
            this.tabTelefone.Controls.Add(this.cbxTipoTel);
            this.tabTelefone.Controls.Add(this.lblTelefone);
            this.tabTelefone.Location = new System.Drawing.Point(4, 22);
            this.tabTelefone.Name = "tabTelefone";
            this.tabTelefone.Size = new System.Drawing.Size(361, 340);
            this.tabTelefone.TabIndex = 2;
            this.tabTelefone.Text = "Telefone";
            this.tabTelefone.UseVisualStyleBackColor = true;
            // 
            // btnNovoTel
            // 
            this.btnNovoTel.Location = new System.Drawing.Point(28, 290);
            this.btnNovoTel.Name = "btnNovoTel";
            this.btnNovoTel.Size = new System.Drawing.Size(68, 23);
            this.btnNovoTel.TabIndex = 53;
            this.btnNovoTel.Text = "Novo";
            this.btnNovoTel.UseVisualStyleBackColor = true;
            // 
            // btnEditarTel
            // 
            this.btnEditarTel.Location = new System.Drawing.Point(102, 290);
            this.btnEditarTel.Name = "btnEditarTel";
            this.btnEditarTel.Size = new System.Drawing.Size(68, 23);
            this.btnEditarTel.TabIndex = 51;
            this.btnEditarTel.Text = "Editar";
            this.btnEditarTel.UseVisualStyleBackColor = true;
            // 
            // btnDesativarTel
            // 
            this.btnDesativarTel.Location = new System.Drawing.Point(176, 290);
            this.btnDesativarTel.Name = "btnDesativarTel";
            this.btnDesativarTel.Size = new System.Drawing.Size(68, 23);
            this.btnDesativarTel.TabIndex = 52;
            this.btnDesativarTel.Text = "Desativar";
            this.btnDesativarTel.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTel
            // 
            this.btnSalvarTel.Location = new System.Drawing.Point(250, 290);
            this.btnSalvarTel.Name = "btnSalvarTel";
            this.btnSalvarTel.Size = new System.Drawing.Size(68, 23);
            this.btnSalvarTel.TabIndex = 50;
            this.btnSalvarTel.Text = "Salvar";
            this.btnSalvarTel.UseVisualStyleBackColor = true;
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Location = new System.Drawing.Point(28, 90);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.Size = new System.Drawing.Size(300, 180);
            this.dgvTelefone.TabIndex = 49;
            // 
            // txtNumeroTel
            // 
            this.txtNumeroTel.Location = new System.Drawing.Point(87, 23);
            this.txtNumeroTel.Name = "txtNumeroTel";
            this.txtNumeroTel.Size = new System.Drawing.Size(241, 20);
            this.txtNumeroTel.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Número:";
            // 
            // cbxTipoTel
            // 
            this.cbxTipoTel.FormattingEnabled = true;
            this.cbxTipoTel.Items.AddRange(new object[] {
            "Celular",
            "Fixo",
            "Fax"});
            this.cbxTipoTel.Location = new System.Drawing.Point(87, 49);
            this.cbxTipoTel.Name = "cbxTipoTel";
            this.cbxTipoTel.Size = new System.Drawing.Size(241, 21);
            this.cbxTipoTel.TabIndex = 46;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(45, 52);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(31, 13);
            this.lblTelefone.TabIndex = 40;
            this.lblTelefone.Text = "Tipo:";
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 388);
            this.Controls.Add(this.Fornecedores);
            this.Name = "FormFornecedor";
            this.Text = "Cadastro de Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.Fornecedores.ResumeLayout(false);
            this.tabFornecedor.ResumeLayout(false);
            this.tabFornecedor.PerformLayout();
            this.tabDadosFornecedor.ResumeLayout(false);
            this.tabDadosFornecedor.PerformLayout();
            this.tabEndereco.ResumeLayout(false);
            this.tabEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.tabTelefone.ResumeLayout(false);
            this.tabTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPesq;
        private System.Windows.Forms.Button btnEditarPesq;
        private System.Windows.Forms.Button btnDesatiivarPesq;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.TabControl Fornecedores;
        private System.Windows.Forms.TabPage tabFornecedor;
        private System.Windows.Forms.TabPage tabEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Button btnEditarEnd;
        private System.Windows.Forms.Button btnDesativarEnd;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.Button btnSalvarEnd;
        private System.Windows.Forms.TabPage tabTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cbxTipoTel;
        private System.Windows.Forms.Button btnEditarTel;
        private System.Windows.Forms.Button btnDesativarTel;
        private System.Windows.Forms.Button btnSalvarTel;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.TextBox txtNumeroTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TabPage tabDadosFornecedor;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnSalvarDadosForn;
        private System.Windows.Forms.TextBox lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnNovoEnd;
        private System.Windows.Forms.Button btnNovoTel;
    }
}

