namespace ProjetoLojaVirtual
{
    partial class Frm_cadCliente
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
            this.btn_incluir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_tipoPessoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_razaoSocial = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.aba_dadosPessoais = new System.Windows.Forms.TabPage();
            this.aba_endereco = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aba_telefone = new System.Windows.Forms.TabPage();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_telefones = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.aba_pesquisar = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbx_cidade = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbx_tipoTelefone = new System.Windows.Forms.ComboBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.aba_dadosPessoais.SuspendLayout();
            this.aba_endereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.aba_telefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_telefones)).BeginInit();
            this.aba_pesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_incluir
            // 
            this.btn_incluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_incluir.Location = new System.Drawing.Point(15, 372);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_incluir.TabIndex = 0;
            this.btn_incluir.Text = "Novo";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(177, 372);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(96, 372);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.Text = "Editar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "RG :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(490, 126);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(147, 20);
            this.txt_rg.TabIndex = 12;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(490, 91);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(147, 20);
            this.txt_cpf.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF/CNPJ *:";
            // 
            // cbx_tipoPessoa
            // 
            this.cbx_tipoPessoa.FormattingEnabled = true;
            this.cbx_tipoPessoa.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbx_tipoPessoa.Location = new System.Drawing.Point(134, 91);
            this.cbx_tipoPessoa.Name = "cbx_tipoPessoa";
            this.cbx_tipoPessoa.Size = new System.Drawing.Size(255, 21);
            this.cbx_tipoPessoa.TabIndex = 8;
            this.cbx_tipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbx_tipoPessoa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Pessoa *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Fantasia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-Mail *:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(134, 126);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(255, 20);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_nomeFantasia
            // 
            this.txt_nomeFantasia.Location = new System.Drawing.Point(134, 53);
            this.txt_nomeFantasia.Name = "txt_nomeFantasia";
            this.txt_nomeFantasia.Size = new System.Drawing.Size(503, 20);
            this.txt_nomeFantasia.TabIndex = 2;
            this.txt_nomeFantasia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome/ Razão Social *:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_razaoSocial
            // 
            this.txt_razaoSocial.Location = new System.Drawing.Point(134, 18);
            this.txt_razaoSocial.Name = "txt_razaoSocial";
            this.txt_razaoSocial.Size = new System.Drawing.Size(503, 20);
            this.txt_razaoSocial.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.aba_pesquisar);
            this.tabControl1.Controls.Add(this.aba_dadosPessoais);
            this.tabControl1.Controls.Add(this.aba_endereco);
            this.tabControl1.Controls.Add(this.aba_telefone);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 432);
            this.tabControl1.TabIndex = 5;
            // 
            // aba_dadosPessoais
            // 
            this.aba_dadosPessoais.Controls.Add(this.label6);
            this.aba_dadosPessoais.Controls.Add(this.txt_rg);
            this.aba_dadosPessoais.Controls.Add(this.txt_cpf);
            this.aba_dadosPessoais.Controls.Add(this.txt_razaoSocial);
            this.aba_dadosPessoais.Controls.Add(this.label5);
            this.aba_dadosPessoais.Controls.Add(this.label1);
            this.aba_dadosPessoais.Controls.Add(this.cbx_tipoPessoa);
            this.aba_dadosPessoais.Controls.Add(this.txt_nomeFantasia);
            this.aba_dadosPessoais.Controls.Add(this.label4);
            this.aba_dadosPessoais.Controls.Add(this.txt_email);
            this.aba_dadosPessoais.Controls.Add(this.label2);
            this.aba_dadosPessoais.Controls.Add(this.label3);
            this.aba_dadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.aba_dadosPessoais.Name = "aba_dadosPessoais";
            this.aba_dadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.aba_dadosPessoais.Size = new System.Drawing.Size(661, 406);
            this.aba_dadosPessoais.TabIndex = 0;
            this.aba_dadosPessoais.Text = "Dados Pessoais";
            this.aba_dadosPessoais.UseVisualStyleBackColor = true;
            // 
            // aba_endereco
            // 
            this.aba_endereco.Controls.Add(this.button1);
            this.aba_endereco.Controls.Add(this.button2);
            this.aba_endereco.Controls.Add(this.button3);
            this.aba_endereco.Controls.Add(this.panel3);
            this.aba_endereco.Controls.Add(this.dataGridView1);
            this.aba_endereco.Location = new System.Drawing.Point(4, 22);
            this.aba_endereco.Name = "aba_endereco";
            this.aba_endereco.Padding = new System.Windows.Forms.Padding(3);
            this.aba_endereco.Size = new System.Drawing.Size(661, 406);
            this.aba_endereco.TabIndex = 1;
            this.aba_endereco.Text = "Endereço";
            this.aba_endereco.UseVisualStyleBackColor = true;
            this.aba_endereco.Click += new System.EventHandler(this.aba_endereco_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // aba_telefone
            // 
            this.aba_telefone.Controls.Add(this.txt_telefone);
            this.aba_telefone.Controls.Add(this.btn_cancelar);
            this.aba_telefone.Controls.Add(this.label15);
            this.aba_telefone.Controls.Add(this.button6);
            this.aba_telefone.Controls.Add(this.label16);
            this.aba_telefone.Controls.Add(this.btn_adicionar);
            this.aba_telefone.Controls.Add(this.cbx_tipoTelefone);
            this.aba_telefone.Controls.Add(this.btn_salvar);
            this.aba_telefone.Controls.Add(this.btn_remover);
            this.aba_telefone.Controls.Add(this.tb_telefones);
            this.aba_telefone.Location = new System.Drawing.Point(4, 22);
            this.aba_telefone.Name = "aba_telefone";
            this.aba_telefone.Size = new System.Drawing.Size(661, 406);
            this.aba_telefone.TabIndex = 2;
            this.aba_telefone.Text = "Telefones";
            this.aba_telefone.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adicionar.Location = new System.Drawing.Point(9, 89);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(73, 23);
            this.btn_adicionar.TabIndex = 15;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(171, 89);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(77, 23);
            this.btn_remover.TabIndex = 14;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.button5_Click);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Tipo *:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tb_telefones
            // 
            this.tb_telefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_telefones.Location = new System.Drawing.Point(8, 118);
            this.tb_telefones.Name = "tb_telefones";
            this.tb_telefones.Size = new System.Drawing.Size(240, 143);
            this.tb_telefones.TabIndex = 12;
            // 
            // btn_salvar
            // 
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_salvar.Location = new System.Drawing.Point(563, 369);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(71, 23);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(482, 369);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // aba_pesquisar
            // 
            this.aba_pesquisar.Controls.Add(this.btn_excluir);
            this.aba_pesquisar.Controls.Add(this.btn_incluir);
            this.aba_pesquisar.Controls.Add(this.btn_alterar);
            this.aba_pesquisar.Controls.Add(this.textBox1);
            this.aba_pesquisar.Controls.Add(this.dataGridView2);
            this.aba_pesquisar.Controls.Add(this.label7);
            this.aba_pesquisar.Location = new System.Drawing.Point(4, 22);
            this.aba_pesquisar.Name = "aba_pesquisar";
            this.aba_pesquisar.Size = new System.Drawing.Size(661, 406);
            this.aba_pesquisar.TabIndex = 3;
            this.aba_pesquisar.Text = "Pesquisa de Clientes";
            this.aba_pesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(630, 334);
            this.dataGridView2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 20);
            this.textBox1.TabIndex = 9;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_referencia);
            this.panel3.Controls.Add(this.txt_cep);
            this.panel3.Controls.Add(this.txt_logradouro);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_numero);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_bairro);
            this.panel3.Controls.Add(this.txt_complemento);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbx_uf);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cbx_cidade);
            this.panel3.Location = new System.Drawing.Point(16, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 150);
            this.panel3.TabIndex = 40;
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(84, 112);
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(331, 20);
            this.txt_referencia.TabIndex = 36;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(507, 115);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(118, 20);
            this.txt_cep.TabIndex = 38;
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(84, 12);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(331, 20);
            this.txt_logradouro.TabIndex = 23;
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
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(507, 15);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(118, 20);
            this.txt_numero.TabIndex = 25;
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
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(84, 47);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(331, 20);
            this.txt_bairro.TabIndex = 27;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(507, 50);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(118, 20);
            this.txt_complemento.TabIndex = 33;
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
            // cbx_uf
            // 
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Location = new System.Drawing.Point(507, 83);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(118, 21);
            this.cbx_uf.TabIndex = 32;
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
            // cbx_cidade
            // 
            this.cbx_cidade.FormattingEnabled = true;
            this.cbx_cidade.Location = new System.Drawing.Point(84, 80);
            this.cbx_cidade.Name = "cbx_cidade";
            this.cbx_cidade.Size = new System.Drawing.Size(331, 21);
            this.cbx_cidade.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(77, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Editar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(181, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(19, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(100, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbx_tipoTelefone
            // 
            this.cbx_tipoTelefone.FormattingEnabled = true;
            this.cbx_tipoTelefone.Items.AddRange(new object[] {
            "Fixo",
            "Celular"});
            this.cbx_tipoTelefone.Location = new System.Drawing.Point(74, 50);
            this.cbx_tipoTelefone.Name = "cbx_tipoTelefone";
            this.cbx_tipoTelefone.Size = new System.Drawing.Size(174, 21);
            this.cbx_tipoTelefone.TabIndex = 10;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(74, 12);
            this.txt_telefone.Mask = "(99) 9999-9999";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(174, 20);
            this.txt_telefone.TabIndex = 12;
            this.txt_telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_telefone_MaskInputRejected);
            // 
            // Frm_cadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_cadCliente";
            this.Text = "Cadastro de Clientes";
            this.tabControl1.ResumeLayout(false);
            this.aba_dadosPessoais.ResumeLayout(false);
            this.aba_dadosPessoais.PerformLayout();
            this.aba_endereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.aba_telefone.ResumeLayout(false);
            this.aba_telefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_telefones)).EndInit();
            this.aba_pesquisar.ResumeLayout(false);
            this.aba_pesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_razaoSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nomeFantasia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_tipoPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aba_dadosPessoais;
        private System.Windows.Forms.TabPage aba_endereco;
        private System.Windows.Forms.TabPage aba_telefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.DataGridView tb_telefones;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage aba_pesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbx_cidade;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.ComboBox cbx_tipoTelefone;
    }
}

