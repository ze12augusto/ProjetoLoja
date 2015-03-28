namespace ProjetoLojaDesktop
{
    partial class FormCadFuncionarios
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
            this.tabFuncionarios = new System.Windows.Forms.TabControl();
            this.tabCadFuncionarios = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabExtras = new System.Windows.Forms.TabPage();
            this.grpTelefone = new System.Windows.Forms.GroupBox();
            this.btnNovoTelefone = new System.Windows.Forms.Button();
            this.btnExcluirTelefone = new System.Windows.Forms.Button();
            this.btnEditarTelefone = new System.Windows.Forms.Button();
            this.btnSalvarTelefone = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cbxTipoTelefone = new System.Windows.Forms.ComboBox();
            this.lblTipoTelefone = new System.Windows.Forms.Label();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.btnNovoEndereco = new System.Windows.Forms.Button();
            this.cbxTipoEndereco = new System.Windows.Forms.ComboBox();
            this.btnExcluirEndereco = new System.Windows.Forms.Button();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.lblTipoEndereco = new System.Windows.Forms.Label();
            this.btnSalvarEndereco = new System.Windows.Forms.Button();
            this.lblUF = new System.Windows.Forms.Label();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.tabFuncionarios.SuspendLayout();
            this.tabCadFuncionarios.SuspendLayout();
            this.grpCadastrar.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tabExtras.SuspendLayout();
            this.grpTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.grpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.tabCadFuncionarios);
            this.tabFuncionarios.Controls.Add(this.tabExtras);
            this.tabFuncionarios.Location = new System.Drawing.Point(12, 13);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.SelectedIndex = 0;
            this.tabFuncionarios.Size = new System.Drawing.Size(685, 447);
            this.tabFuncionarios.TabIndex = 0;
            // 
            // tabCadFuncionarios
            // 
            this.tabCadFuncionarios.Controls.Add(this.btnNovo);
            this.tabCadFuncionarios.Controls.Add(this.grpCadastrar);
            this.tabCadFuncionarios.Controls.Add(this.grpPesquisa);
            this.tabCadFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.tabCadFuncionarios.Controls.Add(this.btnEditar);
            this.tabCadFuncionarios.Controls.Add(this.btnExcluir);
            this.tabCadFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabCadFuncionarios.Name = "tabCadFuncionarios";
            this.tabCadFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadFuncionarios.Size = new System.Drawing.Size(677, 421);
            this.tabCadFuncionarios.TabIndex = 0;
            this.tabCadFuncionarios.Text = "Funcionários";
            this.tabCadFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(418, 189);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Controls.Add(this.txtSenha);
            this.grpCadastrar.Controls.Add(this.lblSenha);
            this.grpCadastrar.Controls.Add(this.cbxTipoUsuario);
            this.grpCadastrar.Controls.Add(this.lblTipoUsuario);
            this.grpCadastrar.Controls.Add(this.txtEmail);
            this.grpCadastrar.Controls.Add(this.lblNome);
            this.grpCadastrar.Controls.Add(this.txtNome);
            this.grpCadastrar.Controls.Add(this.btnSalvar);
            this.grpCadastrar.Controls.Add(this.lblEmail);
            this.grpCadastrar.Controls.Add(this.lblCPF);
            this.grpCadastrar.Controls.Add(this.mtxtCPF);
            this.grpCadastrar.Controls.Add(this.txtRG);
            this.grpCadastrar.Controls.Add(this.lblRG);
            this.grpCadastrar.Location = new System.Drawing.Point(11, 235);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(651, 167);
            this.grpCadastrar.TabIndex = 13;
            this.grpCadastrar.TabStop = false;
            this.grpCadastrar.Text = "Cadastro";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(370, 123);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(155, 20);
            this.txtSenha.TabIndex = 31;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(326, 127);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 30;
            this.lblSenha.Text = "Senha";
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Location = new System.Drawing.Point(93, 123);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoUsuario.TabIndex = 29;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(5, 127);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblTipoUsuario.TabIndex = 28;
            this.lblTipoUsuario.Text = "Tipo de Usuário";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(552, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(52, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(552, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(559, 117);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(52, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(60, 93);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(93, 90);
            this.mtxtCPF.Mask = "999,999,999-99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(167, 20);
            this.mtxtCPF.TabIndex = 5;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(370, 90);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(155, 20);
            this.txtRG.TabIndex = 7;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(341, 93);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 6;
            this.lblRG.Text = "RG";
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(11, 8);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(651, 46);
            this.grpPesquisa.TabIndex = 12;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(8, 18);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(636, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(11, 73);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(651, 110);
            this.dgvFuncionarios.TabIndex = 8;
            this.dgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellDoubleClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(499, 189);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(580, 189);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tabExtras
            // 
            this.tabExtras.Controls.Add(this.grpTelefone);
            this.tabExtras.Controls.Add(this.grpEndereco);
            this.tabExtras.Location = new System.Drawing.Point(4, 22);
            this.tabExtras.Name = "tabExtras";
            this.tabExtras.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtras.Size = new System.Drawing.Size(677, 421);
            this.tabExtras.TabIndex = 1;
            this.tabExtras.Text = "Extras";
            this.tabExtras.UseVisualStyleBackColor = true;
            // 
            // grpTelefone
            // 
            this.grpTelefone.Controls.Add(this.btnNovoTelefone);
            this.grpTelefone.Controls.Add(this.btnExcluirTelefone);
            this.grpTelefone.Controls.Add(this.btnEditarTelefone);
            this.grpTelefone.Controls.Add(this.btnSalvarTelefone);
            this.grpTelefone.Controls.Add(this.dgvTelefone);
            this.grpTelefone.Controls.Add(this.txtTelefone);
            this.grpTelefone.Controls.Add(this.lblTelefone);
            this.grpTelefone.Controls.Add(this.cbxTipoTelefone);
            this.grpTelefone.Controls.Add(this.lblTipoTelefone);
            this.grpTelefone.Location = new System.Drawing.Point(6, 311);
            this.grpTelefone.Name = "grpTelefone";
            this.grpTelefone.Size = new System.Drawing.Size(665, 100);
            this.grpTelefone.TabIndex = 32;
            this.grpTelefone.TabStop = false;
            this.grpTelefone.Text = "Telefone";
            // 
            // btnNovoTelefone
            // 
            this.btnNovoTelefone.Location = new System.Drawing.Point(500, 30);
            this.btnNovoTelefone.Name = "btnNovoTelefone";
            this.btnNovoTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnNovoTelefone.TabIndex = 23;
            this.btnNovoTelefone.Text = "Novo";
            this.btnNovoTelefone.UseVisualStyleBackColor = true;
            this.btnNovoTelefone.Click += new System.EventHandler(this.btnNovoTelefone_Click);
            // 
            // btnExcluirTelefone
            // 
            this.btnExcluirTelefone.Location = new System.Drawing.Point(584, 61);
            this.btnExcluirTelefone.Name = "btnExcluirTelefone";
            this.btnExcluirTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirTelefone.TabIndex = 22;
            this.btnExcluirTelefone.Text = "Excluir";
            this.btnExcluirTelefone.UseVisualStyleBackColor = true;
            this.btnExcluirTelefone.Click += new System.EventHandler(this.btnExcluirTelefone_Click);
            // 
            // btnEditarTelefone
            // 
            this.btnEditarTelefone.Location = new System.Drawing.Point(500, 61);
            this.btnEditarTelefone.Name = "btnEditarTelefone";
            this.btnEditarTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTelefone.TabIndex = 21;
            this.btnEditarTelefone.Text = "Editar";
            this.btnEditarTelefone.UseVisualStyleBackColor = true;
            this.btnEditarTelefone.Click += new System.EventHandler(this.btnEditarTelefone_Click);
            // 
            // btnSalvarTelefone
            // 
            this.btnSalvarTelefone.Location = new System.Drawing.Point(584, 30);
            this.btnSalvarTelefone.Name = "btnSalvarTelefone";
            this.btnSalvarTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTelefone.TabIndex = 20;
            this.btnSalvarTelefone.Text = "Salvar";
            this.btnSalvarTelefone.UseVisualStyleBackColor = true;
            this.btnSalvarTelefone.Click += new System.EventHandler(this.btnSalvarTelefone_Click);
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Location = new System.Drawing.Point(241, 15);
            this.dgvTelefone.MultiSelect = false;
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefone.Size = new System.Drawing.Size(254, 75);
            this.dgvTelefone.TabIndex = 17;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(108, 58);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(53, 61);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // cbxTipoTelefone
            // 
            this.cbxTipoTelefone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTelefone.FormattingEnabled = true;
            this.cbxTipoTelefone.Location = new System.Drawing.Point(108, 27);
            this.cbxTipoTelefone.Name = "cbxTipoTelefone";
            this.cbxTipoTelefone.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoTelefone.TabIndex = 5;
            // 
            // lblTipoTelefone
            // 
            this.lblTipoTelefone.AutoSize = true;
            this.lblTipoTelefone.Location = new System.Drawing.Point(14, 30);
            this.lblTipoTelefone.Name = "lblTipoTelefone";
            this.lblTipoTelefone.Size = new System.Drawing.Size(88, 13);
            this.lblTipoTelefone.TabIndex = 4;
            this.lblTipoTelefone.Text = "Tipo de Telefone";
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.btnNovoEndereco);
            this.grpEndereco.Controls.Add(this.cbxTipoEndereco);
            this.grpEndereco.Controls.Add(this.btnExcluirEndereco);
            this.grpEndereco.Controls.Add(this.cbxUF);
            this.grpEndereco.Controls.Add(this.btnEditarEndereco);
            this.grpEndereco.Controls.Add(this.lblTipoEndereco);
            this.grpEndereco.Controls.Add(this.btnSalvarEndereco);
            this.grpEndereco.Controls.Add(this.lblUF);
            this.grpEndereco.Controls.Add(this.dgvEndereco);
            this.grpEndereco.Controls.Add(this.lblLogradouro);
            this.grpEndereco.Controls.Add(this.cbxCidade);
            this.grpEndereco.Controls.Add(this.txtLogradouro);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.lblNumero);
            this.grpEndereco.Controls.Add(this.mtxtCEP);
            this.grpEndereco.Controls.Add(this.txtNumero);
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Controls.Add(this.lblComplemento);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.txtComplemento);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.lblReferencia);
            this.grpEndereco.Controls.Add(this.txtReferencia);
            this.grpEndereco.Location = new System.Drawing.Point(6, 6);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(665, 294);
            this.grpEndereco.TabIndex = 31;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // btnNovoEndereco
            // 
            this.btnNovoEndereco.Location = new System.Drawing.Point(339, 161);
            this.btnNovoEndereco.Name = "btnNovoEndereco";
            this.btnNovoEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEndereco.TabIndex = 31;
            this.btnNovoEndereco.Text = "Novo";
            this.btnNovoEndereco.UseVisualStyleBackColor = true;
            this.btnNovoEndereco.Click += new System.EventHandler(this.btnNovoEndereco_Click);
            // 
            // cbxTipoEndereco
            // 
            this.cbxTipoEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoEndereco.FormattingEnabled = true;
            this.cbxTipoEndereco.Location = new System.Drawing.Point(108, 19);
            this.cbxTipoEndereco.Name = "cbxTipoEndereco";
            this.cbxTipoEndereco.Size = new System.Drawing.Size(206, 21);
            this.cbxTipoEndereco.TabIndex = 3;
            // 
            // btnExcluirEndereco
            // 
            this.btnExcluirEndereco.Location = new System.Drawing.Point(584, 161);
            this.btnExcluirEndereco.Name = "btnExcluirEndereco";
            this.btnExcluirEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEndereco.TabIndex = 15;
            this.btnExcluirEndereco.Text = "Excluir";
            this.btnExcluirEndereco.UseVisualStyleBackColor = true;
            this.btnExcluirEndereco.Click += new System.EventHandler(this.btnExcluirEndereco_Click);
            // 
            // cbxUF
            // 
            this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(420, 129);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(85, 21);
            this.cbxUF.TabIndex = 30;
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.Location = new System.Drawing.Point(502, 161);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEndereco.TabIndex = 14;
            this.btnEditarEndereco.Text = "Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            this.btnEditarEndereco.Click += new System.EventHandler(this.btnEditarEndereco_Click);
            // 
            // lblTipoEndereco
            // 
            this.lblTipoEndereco.AutoSize = true;
            this.lblTipoEndereco.Location = new System.Drawing.Point(7, 22);
            this.lblTipoEndereco.Name = "lblTipoEndereco";
            this.lblTipoEndereco.Size = new System.Drawing.Size(92, 13);
            this.lblTipoEndereco.TabIndex = 2;
            this.lblTipoEndereco.Text = "Tipo de Endereço";
            // 
            // btnSalvarEndereco
            // 
            this.btnSalvarEndereco.Location = new System.Drawing.Point(420, 161);
            this.btnSalvarEndereco.Name = "btnSalvarEndereco";
            this.btnSalvarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEndereco.TabIndex = 13;
            this.btnSalvarEndereco.Text = "Salvar";
            this.btnSalvarEndereco.UseVisualStyleBackColor = true;
            this.btnSalvarEndereco.Click += new System.EventHandler(this.btnSalvarEndereco_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(384, 132);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 29;
            this.lblUF.Text = "UF";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(7, 190);
            this.dgvEndereco.MultiSelect = false;
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEndereco.Size = new System.Drawing.Size(652, 89);
            this.dgvEndereco.TabIndex = 12;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(38, 50);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 4;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(108, 132);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(206, 21);
            this.cbxCidade.TabIndex = 28;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(109, 46);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(466, 20);
            this.txtLogradouro.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(59, 135);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 27;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(581, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 17;
            this.lblNumero.Text = "Número";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(420, 101);
            this.mtxtCEP.Mask = "99,999-999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(85, 20);
            this.mtxtCEP.TabIndex = 26;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(627, 46);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(32, 20);
            this.txtNumero.TabIndex = 18;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(377, 104);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 25;
            this.lblCEP.Text = "CEP";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(28, 77);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 19;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(108, 101);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(206, 20);
            this.txtBairro.TabIndex = 24;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(109, 74);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(140, 20);
            this.txtComplemento.TabIndex = 20;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(65, 104);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(285, 77);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(59, 13);
            this.lblReferencia.TabIndex = 21;
            this.lblReferencia.Text = "Referência";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(350, 74);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(309, 20);
            this.txtReferencia.TabIndex = 22;
            // 
            // FormCadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 472);
            this.Controls.Add(this.tabFuncionarios);
            this.Name = "FormCadFuncionarios";
            this.Text = "Cadastro de Funcionários";
            this.tabFuncionarios.ResumeLayout(false);
            this.tabCadFuncionarios.ResumeLayout(false);
            this.grpCadastrar.ResumeLayout(false);
            this.grpCadastrar.PerformLayout();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tabExtras.ResumeLayout(false);
            this.grpTelefone.ResumeLayout(false);
            this.grpTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFuncionarios;
        private System.Windows.Forms.TabPage tabCadFuncionarios;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabExtras;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxTipoEndereco;
        private System.Windows.Forms.Label lblTipoEndereco;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Button btnExcluirEndereco;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.Button btnSalvarEndereco;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.GroupBox grpTelefone;
        private System.Windows.Forms.Button btnExcluirTelefone;
        private System.Windows.Forms.Button btnEditarTelefone;
        private System.Windows.Forms.Button btnSalvarTelefone;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cbxTipoTelefone;
        private System.Windows.Forms.Label lblTipoTelefone;
        private System.Windows.Forms.Button btnNovoTelefone;
        private System.Windows.Forms.Button btnNovoEndereco;
    }
}

