namespace ProjetoLojaDesktop
{
    partial class FormCadastroCliente
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
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.tabCadastroCliente = new System.Windows.Forms.TabControl();
            this.tabPesquisaCliente = new System.Windows.Forms.TabPage();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.dgvPesquisaCliente = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabDadosPessoais = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvarDadosPessoais = new System.Windows.Forms.Button();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.btnCancelarEndereco = new System.Windows.Forms.Button();
            this.btnSalvarEndereco = new System.Windows.Forms.Button();
            this.btnExcluirEndereco = new System.Windows.Forms.Button();
            this.btnNovoEndereco = new System.Windows.Forms.Button();
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxTipoEndereco = new System.Windows.Forms.ComboBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.tabTelefone = new System.Windows.Forms.TabPage();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarTelefone = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEditarTenefone = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.cbxTipoTelefone = new System.Windows.Forms.ComboBox();
            this.btnSalvarTelefone = new System.Windows.Forms.Button();
            this.btnRemoverTelefone = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.tabCadastroCliente.SuspendLayout();
            this.tabPesquisaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaCliente)).BeginInit();
            this.tabDadosPessoais.SuspendLayout();
            this.tabEndereco.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.tabTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCliente.Location = new System.Drawing.Point(15, 372);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCliente.TabIndex = 0;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCliente.Location = new System.Drawing.Point(177, 372);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCliente.TabIndex = 1;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCliente.Location = new System.Drawing.Point(96, 372);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 2;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "RG :";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(490, 139);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(147, 20);
            this.txtRg.TabIndex = 12;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(490, 101);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(147, 20);
            this.txtCpf.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF/CNPJ *:";
            // 
            // cbxTipoPessoa
            // 
            this.cbxTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPessoa.FormattingEnabled = true;
            this.cbxTipoPessoa.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbxTipoPessoa.Location = new System.Drawing.Point(134, 10);
            this.cbxTipoPessoa.Name = "cbxTipoPessoa";
            this.cbxTipoPessoa.Size = new System.Drawing.Size(255, 21);
            this.cbxTipoPessoa.TabIndex = 8;
            this.cbxTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbx_tipoPessoa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Pessoa *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Fantasia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-Mail *:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(134, 75);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(503, 20);
            this.txtNomeFantasia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome/ Razão Social *:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(134, 43);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(503, 20);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // tabCadastroCliente
            // 
            this.tabCadastroCliente.Controls.Add(this.tabPesquisaCliente);
            this.tabCadastroCliente.Controls.Add(this.tabDadosPessoais);
            this.tabCadastroCliente.Controls.Add(this.tabEndereco);
            this.tabCadastroCliente.Controls.Add(this.tabTelefone);
            this.tabCadastroCliente.Location = new System.Drawing.Point(8, 12);
            this.tabCadastroCliente.Name = "tabCadastroCliente";
            this.tabCadastroCliente.SelectedIndex = 0;
            this.tabCadastroCliente.Size = new System.Drawing.Size(669, 432);
            this.tabCadastroCliente.TabIndex = 5;
            this.tabCadastroCliente.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPesquisaCliente
            // 
            this.tabPesquisaCliente.Controls.Add(this.btnExcluirCliente);
            this.tabPesquisaCliente.Controls.Add(this.btnNovoCliente);
            this.tabPesquisaCliente.Controls.Add(this.btnEditarCliente);
            this.tabPesquisaCliente.Controls.Add(this.txtConsultaCliente);
            this.tabPesquisaCliente.Controls.Add(this.dgvPesquisaCliente);
            this.tabPesquisaCliente.Controls.Add(this.label7);
            this.tabPesquisaCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisaCliente.Name = "tabPesquisaCliente";
            this.tabPesquisaCliente.Size = new System.Drawing.Size(661, 406);
            this.tabPesquisaCliente.TabIndex = 3;
            this.tabPesquisaCliente.Text = "Pesquisa de Clientes";
            this.tabPesquisaCliente.UseVisualStyleBackColor = true;
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(63, 6);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(436, 20);
            this.txtConsultaCliente.TabIndex = 9;
            this.txtConsultaCliente.TextChanged += new System.EventHandler(this.txtConsultaCliente_TextChanged);
            // 
            // dgvPesquisaCliente
            // 
            this.dgvPesquisaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaCliente.Location = new System.Drawing.Point(15, 32);
            this.dgvPesquisaCliente.Name = "dgvPesquisaCliente";
            this.dgvPesquisaCliente.ReadOnly = true;
            this.dgvPesquisaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisaCliente.Size = new System.Drawing.Size(630, 334);
            this.dgvPesquisaCliente.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome *:";
            // 
            // tabDadosPessoais
            // 
            this.tabDadosPessoais.Controls.Add(this.btnCancelar);
            this.tabDadosPessoais.Controls.Add(this.btnSalvarDadosPessoais);
            this.tabDadosPessoais.Controls.Add(this.label6);
            this.tabDadosPessoais.Controls.Add(this.txtRg);
            this.tabDadosPessoais.Controls.Add(this.txtCpf);
            this.tabDadosPessoais.Controls.Add(this.txtRazaoSocial);
            this.tabDadosPessoais.Controls.Add(this.label5);
            this.tabDadosPessoais.Controls.Add(this.label1);
            this.tabDadosPessoais.Controls.Add(this.cbxTipoPessoa);
            this.tabDadosPessoais.Controls.Add(this.txtNomeFantasia);
            this.tabDadosPessoais.Controls.Add(this.label4);
            this.tabDadosPessoais.Controls.Add(this.txtEmail);
            this.tabDadosPessoais.Controls.Add(this.label2);
            this.tabDadosPessoais.Controls.Add(this.label3);
            this.tabDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabDadosPessoais.Name = "tabDadosPessoais";
            this.tabDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosPessoais.Size = new System.Drawing.Size(661, 406);
            this.tabDadosPessoais.TabIndex = 0;
            this.tabDadosPessoais.Text = "Dados Pessoais";
            this.tabDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(471, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvarDadosPessoais
            // 
            this.btnSalvarDadosPessoais.Location = new System.Drawing.Point(562, 365);
            this.btnSalvarDadosPessoais.Name = "btnSalvarDadosPessoais";
            this.btnSalvarDadosPessoais.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDadosPessoais.TabIndex = 14;
            this.btnSalvarDadosPessoais.Text = "Salvar";
            this.btnSalvarDadosPessoais.UseVisualStyleBackColor = true;
            this.btnSalvarDadosPessoais.Click += new System.EventHandler(this.btnSalvarDadosPessoais_Click);
            // 
            // tabEndereco
            // 
            this.tabEndereco.Controls.Add(this.btnCancelarEndereco);
            this.tabEndereco.Controls.Add(this.btnSalvarEndereco);
            this.tabEndereco.Controls.Add(this.btnExcluirEndereco);
            this.tabEndereco.Controls.Add(this.btnNovoEndereco);
            this.tabEndereco.Controls.Add(this.btnEditarEndereco);
            this.tabEndereco.Controls.Add(this.panel3);
            this.tabEndereco.Controls.Add(this.dgvEndereco);
            this.tabEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndereco.Size = new System.Drawing.Size(661, 406);
            this.tabEndereco.TabIndex = 1;
            this.tabEndereco.Text = "Endereço";
            this.tabEndereco.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEndereco
            // 
            this.btnCancelarEndereco.Location = new System.Drawing.Point(498, 375);
            this.btnCancelarEndereco.Name = "btnCancelarEndereco";
            this.btnCancelarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEndereco.TabIndex = 45;
            this.btnCancelarEndereco.Text = "Cancelar";
            this.btnCancelarEndereco.UseVisualStyleBackColor = true;
            this.btnCancelarEndereco.Click += new System.EventHandler(this.btnCancelarEndereco_Click);
            // 
            // btnSalvarEndereco
            // 
            this.btnSalvarEndereco.Location = new System.Drawing.Point(579, 376);
            this.btnSalvarEndereco.Name = "btnSalvarEndereco";
            this.btnSalvarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEndereco.TabIndex = 44;
            this.btnSalvarEndereco.Text = "Salvar";
            this.btnSalvarEndereco.UseVisualStyleBackColor = true;
            this.btnSalvarEndereco.Click += new System.EventHandler(this.btnSalvarEndereco_Click);
            // 
            // btnExcluirEndereco
            // 
            this.btnExcluirEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirEndereco.Location = new System.Drawing.Point(181, 377);
            this.btnExcluirEndereco.Name = "btnExcluirEndereco";
            this.btnExcluirEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEndereco.TabIndex = 42;
            this.btnExcluirEndereco.Text = "Excluir";
            this.btnExcluirEndereco.UseVisualStyleBackColor = true;
            this.btnExcluirEndereco.Click += new System.EventHandler(this.btnExcluirEndereco_Click);
            // 
            // btnNovoEndereco
            // 
            this.btnNovoEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoEndereco.Location = new System.Drawing.Point(19, 377);
            this.btnNovoEndereco.Name = "btnNovoEndereco";
            this.btnNovoEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEndereco.TabIndex = 41;
            this.btnNovoEndereco.Text = "Novo";
            this.btnNovoEndereco.UseVisualStyleBackColor = true;
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEndereco.Location = new System.Drawing.Point(100, 377);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEndereco.TabIndex = 43;
            this.btnEditarEndereco.Text = "Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            this.btnEditarEndereco.Click += new System.EventHandler(this.btnEditarEndereco_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbxTipoEndereco);
            this.panel3.Controls.Add(this.txtReferencia);
            this.panel3.Controls.Add(this.txtCep);
            this.panel3.Controls.Add(this.txtLogradouro);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtNumero);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtBairro);
            this.panel3.Controls.Add(this.txtComplemento);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbxUf);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cbxCidade);
            this.panel3.Location = new System.Drawing.Point(16, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 182);
            this.panel3.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Tipo *:";
            // 
            // cbxTipoEndereco
            // 
            this.cbxTipoEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoEndereco.FormattingEnabled = true;
            this.cbxTipoEndereco.Location = new System.Drawing.Point(84, 141);
            this.cbxTipoEndereco.Name = "cbxTipoEndereco";
            this.cbxTipoEndereco.Size = new System.Drawing.Size(196, 21);
            this.cbxTipoEndereco.TabIndex = 39;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(84, 112);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(331, 20);
            this.txtReferencia.TabIndex = 36;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(507, 115);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(118, 20);
            this.txtCep.TabIndex = 38;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(84, 12);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(331, 20);
            this.txtLogradouro.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(460, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "CEP *:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Logradouro *:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(507, 15);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(118, 20);
            this.txtNumero.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Referência :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Número *:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Complemento :";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(84, 47);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(331, 20);
            this.txtBairro.TabIndex = 27;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(507, 50);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(118, 20);
            this.txtComplemento.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Bairro *:";
            // 
            // cbxUf
            // 
            this.cbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Location = new System.Drawing.Point(507, 83);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(118, 21);
            this.cbxUf.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cidade *:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(467, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "UF *:";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(84, 80);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(331, 21);
            this.cbxCidade.TabIndex = 30;
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(16, 211);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.Size = new System.Drawing.Size(639, 160);
            this.dgvEndereco.TabIndex = 0;
            // 
            // tabTelefone
            // 
            this.tabTelefone.Controls.Add(this.txtTelefone);
            this.tabTelefone.Controls.Add(this.btnCancelarTelefone);
            this.tabTelefone.Controls.Add(this.label15);
            this.tabTelefone.Controls.Add(this.btnEditarTenefone);
            this.tabTelefone.Controls.Add(this.label16);
            this.tabTelefone.Controls.Add(this.btnAdicionarTelefone);
            this.tabTelefone.Controls.Add(this.cbxTipoTelefone);
            this.tabTelefone.Controls.Add(this.btnSalvarTelefone);
            this.tabTelefone.Controls.Add(this.btnRemoverTelefone);
            this.tabTelefone.Controls.Add(this.dgvTelefone);
            this.tabTelefone.Location = new System.Drawing.Point(4, 22);
            this.tabTelefone.Name = "tabTelefone";
            this.tabTelefone.Size = new System.Drawing.Size(661, 406);
            this.tabTelefone.TabIndex = 2;
            this.tabTelefone.Text = "Telefones";
            this.tabTelefone.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(74, 12);
            this.txtTelefone.Mask = "(99) 9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(174, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // btnCancelarTelefone
            // 
            this.btnCancelarTelefone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelarTelefone.Location = new System.Drawing.Point(482, 369);
            this.btnCancelarTelefone.Name = "btnCancelarTelefone";
            this.btnCancelarTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTelefone.TabIndex = 7;
            this.btnCancelarTelefone.Text = "Cancelar";
            this.btnCancelarTelefone.UseVisualStyleBackColor = true;
            this.btnCancelarTelefone.Click += new System.EventHandler(this.btnCancelarTelefone_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Telefone *:";
            // 
            // btnEditarTenefone
            // 
            this.btnEditarTenefone.Location = new System.Drawing.Point(88, 89);
            this.btnEditarTenefone.Name = "btnEditarTenefone";
            this.btnEditarTenefone.Size = new System.Drawing.Size(77, 23);
            this.btnEditarTenefone.TabIndex = 16;
            this.btnEditarTenefone.Text = "Editar";
            this.btnEditarTenefone.UseVisualStyleBackColor = true;
            this.btnEditarTenefone.Click += new System.EventHandler(this.btnEditarTenefone_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Tipo *:";
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(9, 89);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(73, 23);
            this.btnAdicionarTelefone.TabIndex = 15;
            this.btnAdicionarTelefone.Text = "Novo";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = true;
            // 
            // cbxTipoTelefone
            // 
            this.cbxTipoTelefone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTelefone.FormattingEnabled = true;
            this.cbxTipoTelefone.Location = new System.Drawing.Point(74, 50);
            this.cbxTipoTelefone.Name = "cbxTipoTelefone";
            this.cbxTipoTelefone.Size = new System.Drawing.Size(174, 21);
            this.cbxTipoTelefone.TabIndex = 10;
            // 
            // btnSalvarTelefone
            // 
            this.btnSalvarTelefone.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvarTelefone.Location = new System.Drawing.Point(563, 369);
            this.btnSalvarTelefone.Name = "btnSalvarTelefone";
            this.btnSalvarTelefone.Size = new System.Drawing.Size(71, 23);
            this.btnSalvarTelefone.TabIndex = 6;
            this.btnSalvarTelefone.Text = "Salvar";
            this.btnSalvarTelefone.UseVisualStyleBackColor = true;
            this.btnSalvarTelefone.Click += new System.EventHandler(this.btnSalvarTelefone_Click);
            // 
            // btnRemoverTelefone
            // 
            this.btnRemoverTelefone.Location = new System.Drawing.Point(171, 89);
            this.btnRemoverTelefone.Name = "btnRemoverTelefone";
            this.btnRemoverTelefone.Size = new System.Drawing.Size(77, 23);
            this.btnRemoverTelefone.TabIndex = 14;
            this.btnRemoverTelefone.Text = "Remover";
            this.btnRemoverTelefone.UseVisualStyleBackColor = true;
            this.btnRemoverTelefone.Click += new System.EventHandler(this.btnRemoverTelefone_Click);
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Location = new System.Drawing.Point(8, 118);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.Size = new System.Drawing.Size(240, 143);
            this.dgvTelefone.TabIndex = 12;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 485);
            this.Controls.Add(this.tabCadastroCliente);
            this.Name = "FormCadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.tabCadastroCliente.ResumeLayout(false);
            this.tabPesquisaCliente.ResumeLayout(false);
            this.tabPesquisaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaCliente)).EndInit();
            this.tabDadosPessoais.ResumeLayout(false);
            this.tabDadosPessoais.PerformLayout();
            this.tabEndereco.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.tabTelefone.ResumeLayout(false);
            this.tabTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabCadastroCliente;
        private System.Windows.Forms.TabPage tabDadosPessoais;
        private System.Windows.Forms.TabPage tabEndereco;
        private System.Windows.Forms.TabPage tabTelefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemoverTelefone;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.Button btnSalvarTelefone;
        private System.Windows.Forms.Button btnCancelarTelefone;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.TabPage tabPesquisaCliente;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.DataGridView dgvPesquisaCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Button btnEditarTenefone;
        private System.Windows.Forms.Button btnExcluirEndereco;
        private System.Windows.Forms.Button btnNovoEndereco;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox cbxTipoTelefone;
        private System.Windows.Forms.Button btnSalvarEndereco;
        private System.Windows.Forms.Button btnCancelarEndereco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvarDadosPessoais;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxTipoEndereco;
    }
}

