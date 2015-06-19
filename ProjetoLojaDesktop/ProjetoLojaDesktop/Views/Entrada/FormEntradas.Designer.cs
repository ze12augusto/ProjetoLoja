namespace ProjetoLojaDesktop.Forms
{
    partial class FormEntradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabListaEntradas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExcluirEntrada = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.btnNovaEntrada = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.TabPage();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNotaFiscal = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNotaFiscal = new System.Windows.Forms.Label();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.lblTotalNota = new System.Windows.Forms.Label();
            this.lblValorTotalNota = new System.Windows.Forms.Label();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.txtNumEntrada = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.btnSelProduto = new System.Windows.Forms.Button();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblCodFornecedor = new System.Windows.Forms.Label();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.lblValorTotalProduto = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.dgvProdutosEntrada = new System.Windows.Forms.DataGridView();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblNEntrada = new System.Windows.Forms.Label();
            this.lblWarn = new System.Windows.Forms.Label();
            this.tabListaEntradas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.lblAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // tabListaEntradas
            // 
            this.tabListaEntradas.Controls.Add(this.tabPage1);
            this.tabListaEntradas.Controls.Add(this.lblAviso);
            this.tabListaEntradas.Location = new System.Drawing.Point(1, 30);
            this.tabListaEntradas.Name = "tabListaEntradas";
            this.tabListaEntradas.SelectedIndex = 0;
            this.tabListaEntradas.Size = new System.Drawing.Size(1203, 597);
            this.tabListaEntradas.TabIndex = 16;
            this.tabListaEntradas.Click += new System.EventHandler(this.tabListaEntradas_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExcluirEntrada);
            this.tabPage1.Controls.Add(this.dgvEntradas);
            this.tabPage1.Controls.Add(this.btnNovaEntrada);
            this.tabPage1.Controls.Add(this.btnIncluirProduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1195, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem de Entradas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluirEntrada
            // 
            this.btnExcluirEntrada.Location = new System.Drawing.Point(383, 519);
            this.btnExcluirEntrada.Name = "btnExcluirEntrada";
            this.btnExcluirEntrada.Size = new System.Drawing.Size(176, 42);
            this.btnExcluirEntrada.TabIndex = 19;
            this.btnExcluirEntrada.Text = "Excluir Entrada";
            this.btnExcluirEntrada.UseVisualStyleBackColor = true;
            this.btnExcluirEntrada.Click += new System.EventHandler(this.btnExcluirEntrada_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntradas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntradas.Location = new System.Drawing.Point(8, 22);
            this.dgvEntradas.MultiSelect = false;
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntradas.RowTemplate.Height = 24;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(1184, 491);
            this.dgvEntradas.TabIndex = 0;
            this.dgvEntradas.DoubleClick += new System.EventHandler(this.dgvEntradas_DoubleClick);
            // 
            // btnNovaEntrada
            // 
            this.btnNovaEntrada.Location = new System.Drawing.Point(8, 519);
            this.btnNovaEntrada.Name = "btnNovaEntrada";
            this.btnNovaEntrada.Size = new System.Drawing.Size(180, 42);
            this.btnNovaEntrada.TabIndex = 18;
            this.btnNovaEntrada.Text = "Nova Entrada";
            this.btnNovaEntrada.UseVisualStyleBackColor = true;
            this.btnNovaEntrada.Click += new System.EventHandler(this.btnNovaEntrada_Click);
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Location = new System.Drawing.Point(194, 519);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(183, 42);
            this.btnIncluirProduto.TabIndex = 17;
            this.btnIncluirProduto.Text = "Visualizar Entrada";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnVisualizarEntrada_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.Controls.Add(this.txtDataEntrada);
            this.lblAviso.Controls.Add(this.txtDataNotaFiscal);
            this.lblAviso.Controls.Add(this.lblDataNotaFiscal);
            this.lblAviso.Controls.Add(this.btnRegistrarEntrada);
            this.lblAviso.Controls.Add(this.lblTotalNota);
            this.lblAviso.Controls.Add(this.lblValorTotalNota);
            this.lblAviso.Controls.Add(this.btnAddProduto);
            this.lblAviso.Controls.Add(this.txtNumEntrada);
            this.lblAviso.Controls.Add(this.txtCodProduto);
            this.lblAviso.Controls.Add(this.lblCodProduto);
            this.lblAviso.Controls.Add(this.btnSelProduto);
            this.lblAviso.Controls.Add(this.txtCodFornecedor);
            this.lblAviso.Controls.Add(this.lblCodFornecedor);
            this.lblAviso.Controls.Add(this.btnPesquisarFornecedor);
            this.lblAviso.Controls.Add(this.txtNotaFiscal);
            this.lblAviso.Controls.Add(this.lblNotaFiscal);
            this.lblAviso.Controls.Add(this.lblTotalProduto);
            this.lblAviso.Controls.Add(this.lblValorTotalProduto);
            this.lblAviso.Controls.Add(this.btnExcluirProduto);
            this.lblAviso.Controls.Add(this.btnSalvar);
            this.lblAviso.Controls.Add(this.txtValorUnitario);
            this.lblAviso.Controls.Add(this.lblValorUnitario);
            this.lblAviso.Controls.Add(this.txtQuantidade);
            this.lblAviso.Controls.Add(this.lblQuantidade);
            this.lblAviso.Controls.Add(this.txtProduto);
            this.lblAviso.Controls.Add(this.lblNomeProduto);
            this.lblAviso.Controls.Add(this.dgvProdutosEntrada);
            this.lblAviso.Controls.Add(this.txtFornecedor);
            this.lblAviso.Controls.Add(this.lblNomeFornecedor);
            this.lblAviso.Controls.Add(this.lblDataEntrada);
            this.lblAviso.Controls.Add(this.lblNEntrada);
            this.lblAviso.Controls.Add(this.lblWarn);
            this.lblAviso.Location = new System.Drawing.Point(4, 25);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Padding = new System.Windows.Forms.Padding(3);
            this.lblAviso.Size = new System.Drawing.Size(1195, 568);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "Entrada de Produtos";
            this.lblAviso.UseVisualStyleBackColor = true;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Enabled = false;
            this.txtDataEntrada.Location = new System.Drawing.Point(505, 19);
            this.txtDataEntrada.Mask = "00/00/0000";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 22);
            this.txtDataEntrada.TabIndex = 2;
            this.txtDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataNotaFiscal
            // 
            this.txtDataNotaFiscal.Enabled = false;
            this.txtDataNotaFiscal.Location = new System.Drawing.Point(1103, 13);
            this.txtDataNotaFiscal.Mask = "00/00/0000";
            this.txtDataNotaFiscal.Name = "txtDataNotaFiscal";
            this.txtDataNotaFiscal.Size = new System.Drawing.Size(81, 22);
            this.txtDataNotaFiscal.TabIndex = 4;
            this.txtDataNotaFiscal.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNotaFiscal
            // 
            this.lblDataNotaFiscal.AutoSize = true;
            this.lblDataNotaFiscal.Location = new System.Drawing.Point(1001, 16);
            this.lblDataNotaFiscal.Name = "lblDataNotaFiscal";
            this.lblDataNotaFiscal.Size = new System.Drawing.Size(96, 17);
            this.lblDataNotaFiscal.TabIndex = 33;
            this.lblDataNotaFiscal.Text = "Data da Nota:";
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(1004, 520);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(180, 41);
            this.btnRegistrarEntrada.TabIndex = 31;
            this.btnRegistrarEntrada.Text = "Registrar Entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Visible = false;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // lblTotalNota
            // 
            this.lblTotalNota.AutoSize = true;
            this.lblTotalNota.Location = new System.Drawing.Point(950, 191);
            this.lblTotalNota.Name = "lblTotalNota";
            this.lblTotalNota.Size = new System.Drawing.Size(16, 17);
            this.lblTotalNota.TabIndex = 30;
            this.lblTotalNota.Text = "0";
            this.lblTotalNota.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblValorTotalNota
            // 
            this.lblValorTotalNota.AutoSize = true;
            this.lblValorTotalNota.Location = new System.Drawing.Point(789, 191);
            this.lblValorTotalNota.Name = "lblValorTotalNota";
            this.lblValorTotalNota.Size = new System.Drawing.Size(157, 17);
            this.lblValorTotalNota.TabIndex = 29;
            this.lblValorTotalNota.Text = "Valor Total da Nota: R$";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Location = new System.Drawing.Point(7, 520);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(180, 41);
            this.btnAddProduto.TabIndex = 28;
            this.btnAddProduto.Text = "Novo";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // txtNumEntrada
            // 
            this.txtNumEntrada.Enabled = false;
            this.txtNumEntrada.Location = new System.Drawing.Point(156, 16);
            this.txtNumEntrada.Name = "txtNumEntrada";
            this.txtNumEntrada.Size = new System.Drawing.Size(100, 22);
            this.txtNumEntrada.TabIndex = 1;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(156, 121);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 22);
            this.txtCodProduto.TabIndex = 8;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(20, 124);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(130, 17);
            this.lblCodProduto.TabIndex = 24;
            this.lblCodProduto.Text = "Código do Produto:";
            // 
            // btnSelProduto
            // 
            this.btnSelProduto.Enabled = false;
            this.btnSelProduto.Location = new System.Drawing.Point(1004, 120);
            this.btnSelProduto.Name = "btnSelProduto";
            this.btnSelProduto.Size = new System.Drawing.Size(180, 25);
            this.btnSelProduto.TabIndex = 10;
            this.btnSelProduto.Text = "Selecionar Produto";
            this.btnSelProduto.UseVisualStyleBackColor = true;
            this.btnSelProduto.Click += new System.EventHandler(this.btnSelProduto_Click);
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Enabled = false;
            this.txtCodFornecedor.Location = new System.Drawing.Point(156, 69);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(100, 22);
            this.txtCodFornecedor.TabIndex = 5;
            // 
            // lblCodFornecedor
            // 
            this.lblCodFornecedor.AutoSize = true;
            this.lblCodFornecedor.Location = new System.Drawing.Point(17, 72);
            this.lblCodFornecedor.Name = "lblCodFornecedor";
            this.lblCodFornecedor.Size = new System.Drawing.Size(133, 17);
            this.lblCodFornecedor.TabIndex = 21;
            this.lblCodFornecedor.Text = "Código Fornecedor:";
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Enabled = false;
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(1004, 66);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(180, 25);
            this.btnPesquisarFornecedor.TabIndex = 20;
            this.btnPesquisarFornecedor.Text = "Pesquisar Fornecedor";
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Enabled = false;
            this.txtNotaFiscal.Location = new System.Drawing.Point(864, 18);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(100, 22);
            this.txtNotaFiscal.TabIndex = 3;
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(717, 19);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(105, 17);
            this.lblNotaFiscal.TabIndex = 18;
            this.lblNotaFiscal.Text = "N.º Nota Fiscal:";
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Location = new System.Drawing.Point(950, 169);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(16, 17);
            this.lblTotalProduto.TabIndex = 17;
            this.lblTotalProduto.Text = "0";
            this.lblTotalProduto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblValorTotalProduto
            // 
            this.lblValorTotalProduto.AutoSize = true;
            this.lblValorTotalProduto.Location = new System.Drawing.Point(769, 169);
            this.lblValorTotalProduto.Name = "lblValorTotalProduto";
            this.lblValorTotalProduto.Size = new System.Drawing.Size(177, 17);
            this.lblValorTotalProduto.TabIndex = 16;
            this.lblValorTotalProduto.Text = "Valor Total do Produto: R$";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(379, 520);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(180, 41);
            this.btnExcluirProduto.TabIndex = 15;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(193, 520);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(180, 41);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Location = new System.Drawing.Point(505, 179);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(129, 22);
            this.txtValorUnitario.TabIndex = 12;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(393, 182);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(98, 17);
            this.lblValorUnitario.TabIndex = 12;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(156, 179);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 11;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(64, 182);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(505, 121);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(459, 22);
            this.txtProduto.TabIndex = 9;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(429, 124);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(62, 17);
            this.lblNomeProduto.TabIndex = 8;
            this.lblNomeProduto.Text = "Produto:";
            // 
            // dgvProdutosEntrada
            // 
            this.dgvProdutosEntrada.AllowUserToAddRows = false;
            this.dgvProdutosEntrada.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutosEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutosEntrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProdutosEntrada.Location = new System.Drawing.Point(6, 230);
            this.dgvProdutosEntrada.Name = "dgvProdutosEntrada";
            this.dgvProdutosEntrada.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutosEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProdutosEntrada.RowTemplate.Height = 24;
            this.dgvProdutosEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosEntrada.Size = new System.Drawing.Size(1178, 284);
            this.dgvProdutosEntrada.TabIndex = 6;
            this.dgvProdutosEntrada.SelectionChanged += new System.EventHandler(this.dgvProdutosEntrada_SelectionChanged);
            this.dgvProdutosEntrada.DoubleClick += new System.EventHandler(this.dgvProdutosEntrada_DoubleClick);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(505, 66);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(459, 22);
            this.txtFornecedor.TabIndex = 6;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(406, 69);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(85, 17);
            this.lblNomeFornecedor.TabIndex = 4;
            this.lblNomeFornecedor.Text = "Fornecedor:";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(375, 21);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(116, 17);
            this.lblDataEntrada.TabIndex = 2;
            this.lblDataEntrada.Text = "Data da Entrada:";
            // 
            // lblNEntrada
            // 
            this.lblNEntrada.AutoSize = true;
            this.lblNEntrada.Location = new System.Drawing.Point(65, 18);
            this.lblNEntrada.Name = "lblNEntrada";
            this.lblNEntrada.Size = new System.Drawing.Size(85, 17);
            this.lblNEntrada.TabIndex = 0;
            this.lblNEntrada.Text = "N.º Entrada:";
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarn.Location = new System.Drawing.Point(209, 150);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(768, 32);
            this.lblWarn.TabIndex = 32;
            this.lblWarn.Text = "REGISTRE A ENTRADA PARA ASSOCIAR PRODUTOS";
            this.lblWarn.Visible = false;
            // 
            // FormEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 622);
            this.Controls.Add(this.tabListaEntradas);
            this.Name = "FormEntradas";
            this.Text = "Registrar Entrada de Produtos";
            this.tabListaEntradas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.lblAviso.ResumeLayout(false);
            this.lblAviso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabListaEntradas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage lblAviso;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Label lblNEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.DataGridView dgvProdutosEntrada;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.Label lblValorTotalProduto;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Button btnNovaEntrada;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblCodFornecedor;
        private System.Windows.Forms.Button btnSelProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txtNumEntrada;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Label lblTotalNota;
        private System.Windows.Forms.Label lblValorTotalNota;
        private System.Windows.Forms.Button btnRegistrarEntrada;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Label lblDataNotaFiscal;
        private System.Windows.Forms.MaskedTextBox txtDataNotaFiscal;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.Button btnExcluirEntrada;

    }
}