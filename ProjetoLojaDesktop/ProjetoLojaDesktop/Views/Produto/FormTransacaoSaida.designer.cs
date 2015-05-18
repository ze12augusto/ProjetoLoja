namespace ProjetoLojaDesktop.Forms
{
    partial class FormTransacaoSaida
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
            this.tbcTransacao = new System.Windows.Forms.TabControl();
            this.tbpTransacao = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarTransacao = new System.Windows.Forms.Button();
            this.btnSalvarTransacao = new System.Windows.Forms.Button();
            this.btnNovaTransacao = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTransacoes = new System.Windows.Forms.DataGridView();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpOrdemDeServico = new System.Windows.Forms.TabPage();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoOrdem = new System.Windows.Forms.RichTextBox();
            this.dtpPrevisaoDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarOrdem = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.tbcTransacao.SuspendLayout();
            this.tbpTransacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            this.tbpOrdemDeServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTransacao
            // 
            this.tbcTransacao.Controls.Add(this.tbpTransacao);
            this.tbcTransacao.Controls.Add(this.tbpOrdemDeServico);
            this.tbcTransacao.Location = new System.Drawing.Point(12, 12);
            this.tbcTransacao.Name = "tbcTransacao";
            this.tbcTransacao.SelectedIndex = 0;
            this.tbcTransacao.Size = new System.Drawing.Size(713, 455);
            this.tbcTransacao.TabIndex = 0;
            // 
            // tbpTransacao
            // 
            this.tbpTransacao.Controls.Add(this.txtDesconto);
            this.tbpTransacao.Controls.Add(this.txtValor);
            this.tbpTransacao.Controls.Add(this.label3);
            this.tbpTransacao.Controls.Add(this.txtData);
            this.tbpTransacao.Controls.Add(this.label9);
            this.tbpTransacao.Controls.Add(this.label8);
            this.tbpTransacao.Controls.Add(this.btnEditarTransacao);
            this.tbpTransacao.Controls.Add(this.btnSalvarTransacao);
            this.tbpTransacao.Controls.Add(this.btnNovaTransacao);
            this.tbpTransacao.Controls.Add(this.cbxStatus);
            this.tbpTransacao.Controls.Add(this.label7);
            this.tbpTransacao.Controls.Add(this.dgvTransacoes);
            this.tbpTransacao.Controls.Add(this.btnPesquisarCliente);
            this.tbpTransacao.Controls.Add(this.cbxFuncionario);
            this.tbpTransacao.Controls.Add(this.label6);
            this.tbpTransacao.Controls.Add(this.txtNomeCliente);
            this.tbpTransacao.Controls.Add(this.label5);
            this.tbpTransacao.Controls.Add(this.label4);
            this.tbpTransacao.Location = new System.Drawing.Point(4, 22);
            this.tbpTransacao.Name = "tbpTransacao";
            this.tbpTransacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTransacao.Size = new System.Drawing.Size(705, 429);
            this.tbpTransacao.TabIndex = 0;
            this.tbpTransacao.Text = "Transação";
            this.tbpTransacao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(494, 21);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(152, 20);
            this.txtData.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desconto:";
            // 
            // btnEditarTransacao
            // 
            this.btnEditarTransacao.Image = global::ProjetoLojaDesktop.Properties.Resources.Data_Edit;
            this.btnEditarTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTransacao.Location = new System.Drawing.Point(540, 389);
            this.btnEditarTransacao.Name = "btnEditarTransacao";
            this.btnEditarTransacao.Size = new System.Drawing.Size(70, 25);
            this.btnEditarTransacao.TabIndex = 11;
            this.btnEditarTransacao.Text = "Editar";
            this.btnEditarTransacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarTransacao.UseVisualStyleBackColor = true;
            this.btnEditarTransacao.Click += new System.EventHandler(this.btnEditarTransacao_Click);
            // 
            // btnSalvarTransacao
            // 
            this.btnSalvarTransacao.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvarTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarTransacao.Location = new System.Drawing.Point(616, 389);
            this.btnSalvarTransacao.Name = "btnSalvarTransacao";
            this.btnSalvarTransacao.Size = new System.Drawing.Size(70, 25);
            this.btnSalvarTransacao.TabIndex = 10;
            this.btnSalvarTransacao.Text = "Salvar";
            this.btnSalvarTransacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarTransacao.UseVisualStyleBackColor = true;
            this.btnSalvarTransacao.Click += new System.EventHandler(this.btnSalvarTransacao_Click);
            // 
            // btnNovaTransacao
            // 
            this.btnNovaTransacao.Image = global::ProjetoLojaDesktop.Properties.Resources.Document_02;
            this.btnNovaTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaTransacao.Location = new System.Drawing.Point(464, 389);
            this.btnNovaTransacao.Name = "btnNovaTransacao";
            this.btnNovaTransacao.Size = new System.Drawing.Size(70, 25);
            this.btnNovaTransacao.TabIndex = 9;
            this.btnNovaTransacao.Text = "Novo";
            this.btnNovaTransacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaTransacao.UseVisualStyleBackColor = true;
            this.btnNovaTransacao.Click += new System.EventHandler(this.btnNovaTransacao_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(86, 86);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // dgvTransacoes
            // 
            this.dgvTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacoes.Location = new System.Drawing.Point(18, 125);
            this.dgvTransacoes.MultiSelect = false;
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.ReadOnly = true;
            this.dgvTransacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransacoes.Size = new System.Drawing.Size(645, 258);
            this.dgvTransacoes.TabIndex = 6;
            this.dgvTransacoes.DoubleClick += new System.EventHandler(this.dgvTransacao_DoubleClick);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Image = global::ProjetoLojaDesktop.Properties.Resources.Search;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(288, 18);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisarCliente.TabIndex = 5;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(85, 53);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(227, 21);
            this.cbxFuncionario.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Funcionário:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(86, 21);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(196, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente:";
            // 
            // tbpOrdemDeServico
            // 
            this.tbpOrdemDeServico.Controls.Add(this.btnAdicionarProduto);
            this.tbpOrdemDeServico.Controls.Add(this.dgvProdutos);
            this.tbpOrdemDeServico.Controls.Add(this.label2);
            this.tbpOrdemDeServico.Controls.Add(this.label1);
            this.tbpOrdemDeServico.Controls.Add(this.txtDescricaoOrdem);
            this.tbpOrdemDeServico.Controls.Add(this.dtpPrevisaoDeEntrega);
            this.tbpOrdemDeServico.Controls.Add(this.btnSalvarOrdem);
            this.tbpOrdemDeServico.Location = new System.Drawing.Point(4, 22);
            this.tbpOrdemDeServico.Name = "tbpOrdemDeServico";
            this.tbpOrdemDeServico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrdemDeServico.Size = new System.Drawing.Size(705, 429);
            this.tbpOrdemDeServico.TabIndex = 1;
            this.tbpOrdemDeServico.Text = "Ordem de Serviço";
            this.tbpOrdemDeServico.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(568, 388);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(117, 23);
            this.btnAdicionarProduto.TabIndex = 10;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(17, 231);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(668, 151);
            this.dgvProdutos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Previsão de Entrega:";
            // 
            // txtDescricaoOrdem
            // 
            this.txtDescricaoOrdem.Location = new System.Drawing.Point(17, 71);
            this.txtDescricaoOrdem.Name = "txtDescricaoOrdem";
            this.txtDescricaoOrdem.Size = new System.Drawing.Size(668, 108);
            this.txtDescricaoOrdem.TabIndex = 3;
            this.txtDescricaoOrdem.Text = "";
            // 
            // dtpPrevisaoDeEntrega
            // 
            this.dtpPrevisaoDeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrevisaoDeEntrega.Location = new System.Drawing.Point(135, 19);
            this.dtpPrevisaoDeEntrega.Name = "dtpPrevisaoDeEntrega";
            this.dtpPrevisaoDeEntrega.Size = new System.Drawing.Size(87, 20);
            this.dtpPrevisaoDeEntrega.TabIndex = 1;
            // 
            // btnSalvarOrdem
            // 
            this.btnSalvarOrdem.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvarOrdem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarOrdem.Location = new System.Drawing.Point(614, 185);
            this.btnSalvarOrdem.Name = "btnSalvarOrdem";
            this.btnSalvarOrdem.Size = new System.Drawing.Size(70, 25);
            this.btnSalvarOrdem.TabIndex = 5;
            this.btnSalvarOrdem.Text = "Salvar";
            this.btnSalvarOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarOrdem.UseVisualStyleBackColor = true;
            this.btnSalvarOrdem.Click += new System.EventHandler(this.btnSalvarOrdem_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(493, 56);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 23;
            this.txtValor.Text = "R$";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(493, 87);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 24;
            this.txtDesconto.Text = "R$";
            // 
            // FormTransacaoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 479);
            this.Controls.Add(this.tbcTransacao);
            this.Name = "FormTransacaoSaida";
            this.Text = "Transação";
            this.tbcTransacao.ResumeLayout(false);
            this.tbpTransacao.ResumeLayout(false);
            this.tbpTransacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            this.tbpOrdemDeServico.ResumeLayout(false);
            this.tbpOrdemDeServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTransacao;
        private System.Windows.Forms.TabPage tbpTransacao;
        private System.Windows.Forms.TabPage tbpOrdemDeServico;
        private System.Windows.Forms.Button btnSalvarOrdem;
        private System.Windows.Forms.RichTextBox txtDescricaoOrdem;
        private System.Windows.Forms.DateTimePicker dtpPrevisaoDeEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTransacoes;
        private System.Windows.Forms.Button btnEditarTransacao;
        private System.Windows.Forms.Button btnSalvarTransacao;
        private System.Windows.Forms.Button btnNovaTransacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDesconto;
        private System.Windows.Forms.MaskedTextBox txtValor;
    }
}