namespace ProjetoLojaDesktop
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecerdorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordensDeServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoCartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.entradasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecerdorToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecerdorToolStripMenuItem
            // 
            this.fornecerdorToolStripMenuItem.Name = "fornecerdorToolStripMenuItem";
            this.fornecerdorToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.fornecerdorToolStripMenuItem.Text = "Fornecerdor";
            this.fornecerdorToolStripMenuItem.Click += new System.EventHandler(this.fornecerdorToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMarcaToolStripMenuItem,
            this.cadastrarModeloToolStripMenuItem,
            this.cadastrarProdutoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarMarcaToolStripMenuItem
            // 
            this.cadastrarMarcaToolStripMenuItem.Name = "cadastrarMarcaToolStripMenuItem";
            this.cadastrarMarcaToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.cadastrarMarcaToolStripMenuItem.Text = "Cadastrar Marca";
            this.cadastrarMarcaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMarcaToolStripMenuItem_Click);
            // 
            // cadastrarModeloToolStripMenuItem
            // 
            this.cadastrarModeloToolStripMenuItem.Name = "cadastrarModeloToolStripMenuItem";
            this.cadastrarModeloToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.cadastrarModeloToolStripMenuItem.Text = "Cadastrar Modelo";
            this.cadastrarModeloToolStripMenuItem.Click += new System.EventHandler(this.cadastrarModeloToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordensDeServiçosToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.pagamentoCartãoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // ordensDeServiçosToolStripMenuItem
            // 
            this.ordensDeServiçosToolStripMenuItem.Name = "ordensDeServiçosToolStripMenuItem";
            this.ordensDeServiçosToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.ordensDeServiçosToolStripMenuItem.Text = "Ordens de Serviços";
            this.ordensDeServiçosToolStripMenuItem.Click += new System.EventHandler(this.ordensDeServiçosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(204, 24);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // pagamentoCartãoToolStripMenuItem
            // 
            this.pagamentoCartãoToolStripMenuItem.Name = "pagamentoCartãoToolStripMenuItem";
            this.pagamentoCartãoToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.pagamentoCartãoToolStripMenuItem.Text = "Pagamento Cartão";
            this.pagamentoCartãoToolStripMenuItem.Click += new System.EventHandler(this.pagamentoCartãoToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.Sales_Order;
            this.btnVenda.Location = new System.Drawing.Point(547, 53);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(67, 62);
            this.btnVenda.TabIndex = 9;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.Door_Closed;
            this.btnSair.Location = new System.Drawing.Point(621, 53);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 62);
            this.btnSair.TabIndex = 8;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.Verify;
            this.btnRelatorio.Location = new System.Drawing.Point(472, 53);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(67, 62);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.Money_Coin_01;
            this.btnFinanceiro.Location = new System.Drawing.Point(396, 53);
            this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(67, 62);
            this.btnFinanceiro.TabIndex = 6;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            // 
            // btnMarca
            // 
            this.btnMarca.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.marca2;
            this.btnMarca.Location = new System.Drawing.Point(321, 53);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(67, 62);
            this.btnMarca.TabIndex = 5;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.Folder_Picture;
            this.btnModelo.Location = new System.Drawing.Point(244, 53);
            this.btnModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(67, 62);
            this.btnModelo.TabIndex = 4;
            this.btnModelo.UseVisualStyleBackColor = true;
            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.User_Profile;
            this.btnUsuario.Location = new System.Drawing.Point(168, 53);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(67, 62);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Image = global::ProjetoLojaDesktop.Properties.Resources.User_Group1;
            this.btnFornecedor.Location = new System.Drawing.Point(92, 53);
            this.btnFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(67, 62);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::ProjetoLojaDesktop.Properties.Resources.Business_Man;
            this.btnCliente.Location = new System.Drawing.Point(16, 53);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(67, 62);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 137);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnModelo);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "ProjetoLoja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecerdorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnModelo;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordensDeServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagamentoCartãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
    }
}

