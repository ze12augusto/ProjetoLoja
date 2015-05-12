namespace ProjetoLojaDesktop.Views
{
    partial class FormVenda
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabListaVenda = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvListaVenda = new System.Windows.Forms.DataGridView();
            this.txtPesquisaVenda = new System.Windows.Forms.TextBox();
            this.lblPesquisaVenda = new System.Windows.Forms.Label();
            this.tabCadastrarVenda = new System.Windows.Forms.TabPage();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.txtClienteVenda = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabListaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenda)).BeginInit();
            this.tabCadastrarVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabListaVenda);
            this.tabControl1.Controls.Add(this.tabCadastrarVenda);
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 356);
            this.tabControl1.TabIndex = 2;
            // 
            // tabListaVenda
            // 
            this.tabListaVenda.Controls.Add(this.btnNovo);
            this.tabListaVenda.Controls.Add(this.btnEditar);
            this.tabListaVenda.Controls.Add(this.btnExcluir);
            this.tabListaVenda.Controls.Add(this.dgvListaVenda);
            this.tabListaVenda.Controls.Add(this.txtPesquisaVenda);
            this.tabListaVenda.Controls.Add(this.lblPesquisaVenda);
            this.tabListaVenda.Location = new System.Drawing.Point(4, 22);
            this.tabListaVenda.Name = "tabListaVenda";
            this.tabListaVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaVenda.Size = new System.Drawing.Size(459, 330);
            this.tabListaVenda.TabIndex = 0;
            this.tabListaVenda.Text = "Lista de Vendas";
            this.tabListaVenda.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(34, 296);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 25);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(115, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(196, 296);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvListaVenda
            // 
            this.dgvListaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVenda.Location = new System.Drawing.Point(34, 61);
            this.dgvListaVenda.Name = "dgvListaVenda";
            this.dgvListaVenda.Size = new System.Drawing.Size(371, 229);
            this.dgvListaVenda.TabIndex = 2;
            // 
            // txtPesquisaVenda
            // 
            this.txtPesquisaVenda.Location = new System.Drawing.Point(93, 23);
            this.txtPesquisaVenda.Name = "txtPesquisaVenda";
            this.txtPesquisaVenda.Size = new System.Drawing.Size(312, 20);
            this.txtPesquisaVenda.TabIndex = 1;
            // 
            // lblPesquisaVenda
            // 
            this.lblPesquisaVenda.AutoSize = true;
            this.lblPesquisaVenda.Location = new System.Drawing.Point(31, 23);
            this.lblPesquisaVenda.Name = "lblPesquisaVenda";
            this.lblPesquisaVenda.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisaVenda.TabIndex = 0;
            this.lblPesquisaVenda.Text = "Pesquisa: ";
            // 
            // tabCadastrarVenda
            // 
            this.tabCadastrarVenda.Controls.Add(this.txtTotalVenda);
            this.tabCadastrarVenda.Controls.Add(this.lblTotalVenda);
            this.tabCadastrarVenda.Controls.Add(this.btnFinalizar);
            this.tabCadastrarVenda.Controls.Add(this.btnCancelar);
            this.tabCadastrarVenda.Controls.Add(this.btnSalvar);
            this.tabCadastrarVenda.Controls.Add(this.dgvListaProduto);
            this.tabCadastrarVenda.Controls.Add(this.cbxFuncionario);
            this.tabCadastrarVenda.Controls.Add(this.txtClienteVenda);
            this.tabCadastrarVenda.Controls.Add(this.lblFuncionario);
            this.tabCadastrarVenda.Controls.Add(this.lblCliente);
            this.tabCadastrarVenda.Controls.Add(this.btnRemoverProduto);
            this.tabCadastrarVenda.Controls.Add(this.btnAddProduto);
            this.tabCadastrarVenda.Controls.Add(this.button1);
            this.tabCadastrarVenda.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrarVenda.Name = "tabCadastrarVenda";
            this.tabCadastrarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrarVenda.Size = new System.Drawing.Size(459, 330);
            this.tabCadastrarVenda.TabIndex = 1;
            this.tabCadastrarVenda.Text = "Cadastrar Venda";
            this.tabCadastrarVenda.UseVisualStyleBackColor = true;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Location = new System.Drawing.Point(276, 262);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.ReadOnly = true;
            this.txtTotalVenda.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVenda.TabIndex = 12;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(184, 265);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(86, 13);
            this.lblTotalVenda.TabIndex = 11;
            this.lblTotalVenda.Text = "Total da Venda: ";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(301, 292);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 25);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(224, 292);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Location = new System.Drawing.Point(32, 104);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.Size = new System.Drawing.Size(344, 150);
            this.dgvListaProduto.TabIndex = 5;
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(103, 56);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(242, 21);
            this.cbxFuncionario.TabIndex = 3;
            // 
            // txtClienteVenda
            // 
            this.txtClienteVenda.Location = new System.Drawing.Point(103, 18);
            this.txtClienteVenda.Name = "txtClienteVenda";
            this.txtClienteVenda.Size = new System.Drawing.Size(242, 20);
            this.txtClienteVenda.TabIndex = 2;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(29, 59);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(68, 13);
            this.lblFuncionario.TabIndex = 1;
            this.lblFuncionario.Text = "Funcionario: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(394, 150);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(25, 25);
            this.btnRemoverProduto.TabIndex = 7;
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Add_New;
            this.btnAddProduto.Location = new System.Drawing.Point(394, 104);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(25, 25);
            this.btnAddProduto.TabIndex = 6;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 374);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormVenda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabListaVenda.ResumeLayout(false);
            this.tabListaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenda)).EndInit();
            this.tabCadastrarVenda.ResumeLayout(false);
            this.tabCadastrarVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabListaVenda;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvListaVenda;
        private System.Windows.Forms.TextBox txtPesquisaVenda;
        private System.Windows.Forms.Label lblPesquisaVenda;
        private System.Windows.Forms.TabPage tabCadastrarVenda;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.TextBox txtClienteVenda;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button button1;
    }
}