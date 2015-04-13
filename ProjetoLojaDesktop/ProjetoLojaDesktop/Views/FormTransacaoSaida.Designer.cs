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
            this.mtxtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.btnEditarTransacao = new System.Windows.Forms.Button();
            this.btnSalvarTransacao = new System.Windows.Forms.Button();
            this.btnNovaTransacao = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTransacao = new System.Windows.Forms.DataGridView();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpOrdemDeServico = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dtpPrevisaoDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnEditarOrdem = new System.Windows.Forms.Button();
            this.btnSalvarOrdem = new System.Windows.Forms.Button();
            this.btnNovaOrdem = new System.Windows.Forms.Button();
            this.tbcTransacao.SuspendLayout();
            this.tbpTransacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacao)).BeginInit();
            this.tbpOrdemDeServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTransacao
            // 
            this.tbcTransacao.Controls.Add(this.tbpTransacao);
            this.tbcTransacao.Controls.Add(this.tbpOrdemDeServico);
            this.tbcTransacao.Location = new System.Drawing.Point(12, 12);
            this.tbcTransacao.Name = "tbcTransacao";
            this.tbcTransacao.SelectedIndex = 0;
            this.tbcTransacao.Size = new System.Drawing.Size(553, 410);
            this.tbcTransacao.TabIndex = 0;
            // 
            // tbpTransacao
            // 
            this.tbpTransacao.Controls.Add(this.mtxtDesconto);
            this.tbpTransacao.Controls.Add(this.label8);
            this.tbpTransacao.Controls.Add(this.label3);
            this.tbpTransacao.Controls.Add(this.mtxtValor);
            this.tbpTransacao.Controls.Add(this.btnEditarTransacao);
            this.tbpTransacao.Controls.Add(this.btnSalvarTransacao);
            this.tbpTransacao.Controls.Add(this.btnNovaTransacao);
            this.tbpTransacao.Controls.Add(this.cbxStatus);
            this.tbpTransacao.Controls.Add(this.label7);
            this.tbpTransacao.Controls.Add(this.dgvTransacao);
            this.tbpTransacao.Controls.Add(this.btnPesquisarCliente);
            this.tbpTransacao.Controls.Add(this.cbxFuncionario);
            this.tbpTransacao.Controls.Add(this.label6);
            this.tbpTransacao.Controls.Add(this.txtNomeCliente);
            this.tbpTransacao.Controls.Add(this.label5);
            this.tbpTransacao.Controls.Add(this.label4);
            this.tbpTransacao.Location = new System.Drawing.Point(4, 22);
            this.tbpTransacao.Name = "tbpTransacao";
            this.tbpTransacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTransacao.Size = new System.Drawing.Size(545, 384);
            this.tbpTransacao.TabIndex = 0;
            this.tbpTransacao.Text = "Transação";
            this.tbpTransacao.UseVisualStyleBackColor = true;
            // 
            // mtxtDesconto
            // 
            this.mtxtDesconto.Location = new System.Drawing.Point(422, 53);
            this.mtxtDesconto.Mask = "$ 000,000.00";
            this.mtxtDesconto.Name = "mtxtDesconto";
            this.mtxtDesconto.Size = new System.Drawing.Size(85, 20);
            this.mtxtDesconto.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Desconto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor:";
            // 
            // mtxtValor
            // 
            this.mtxtValor.Location = new System.Drawing.Point(422, 24);
            this.mtxtValor.Mask = "$ 000,000.00";
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(85, 20);
            this.mtxtValor.TabIndex = 12;
            // 
            // btnEditarTransacao
            // 
            this.btnEditarTransacao.Image = global::ProjetoLojaDesktop.Properties.Resources.Data_Edit;
            this.btnEditarTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTransacao.Location = new System.Drawing.Point(382, 344);
            this.btnEditarTransacao.Name = "btnEditarTransacao";
            this.btnEditarTransacao.Size = new System.Drawing.Size(70, 25);
            this.btnEditarTransacao.TabIndex = 11;
            this.btnEditarTransacao.Text = "Editar";
            this.btnEditarTransacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarTransacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTransacao
            // 
            this.btnSalvarTransacao.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvarTransacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarTransacao.Location = new System.Drawing.Point(458, 344);
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
            this.btnNovaTransacao.Location = new System.Drawing.Point(306, 344);
            this.btnNovaTransacao.Name = "btnNovaTransacao";
            this.btnNovaTransacao.Size = new System.Drawing.Size(70, 25);
            this.btnNovaTransacao.TabIndex = 9;
            this.btnNovaTransacao.Text = "Novo";
            this.btnNovaTransacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaTransacao.UseVisualStyleBackColor = true;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(86, 86);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // dgvTransacao
            // 
            this.dgvTransacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacao.Location = new System.Drawing.Point(18, 125);
            this.dgvTransacao.Name = "dgvTransacao";
            this.dgvTransacao.Size = new System.Drawing.Size(508, 201);
            this.dgvTransacao.TabIndex = 6;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Image = global::ProjetoLojaDesktop.Properties.Resources.Search;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(288, 18);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisarCliente.TabIndex = 5;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(85, 53);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(227, 21);
            this.cbxFuncionario.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Funcionário:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(86, 21);
            this.txtNomeCliente.Name = "txtNomeCliente";
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
            this.label4.Location = new System.Drawing.Point(41, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente:";
            // 
            // tbpOrdemDeServico
            // 
            this.tbpOrdemDeServico.Controls.Add(this.label2);
            this.tbpOrdemDeServico.Controls.Add(this.label1);
            this.tbpOrdemDeServico.Controls.Add(this.richTextBox1);
            this.tbpOrdemDeServico.Controls.Add(this.dtpPrevisaoDeEntrega);
            this.tbpOrdemDeServico.Controls.Add(this.btnEditarOrdem);
            this.tbpOrdemDeServico.Controls.Add(this.btnSalvarOrdem);
            this.tbpOrdemDeServico.Controls.Add(this.btnNovaOrdem);
            this.tbpOrdemDeServico.Location = new System.Drawing.Point(4, 22);
            this.tbpOrdemDeServico.Name = "tbpOrdemDeServico";
            this.tbpOrdemDeServico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrdemDeServico.Size = new System.Drawing.Size(545, 384);
            this.tbpOrdemDeServico.TabIndex = 1;
            this.tbpOrdemDeServico.Text = "Ordem de Serviço";
            this.tbpOrdemDeServico.UseVisualStyleBackColor = true;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(504, 241);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // dtpPrevisaoDeEntrega
            // 
            this.dtpPrevisaoDeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrevisaoDeEntrega.Location = new System.Drawing.Point(135, 19);
            this.dtpPrevisaoDeEntrega.Name = "dtpPrevisaoDeEntrega";
            this.dtpPrevisaoDeEntrega.Size = new System.Drawing.Size(87, 20);
            this.dtpPrevisaoDeEntrega.TabIndex = 1;
            // 
            // btnEditarOrdem
            // 
            this.btnEditarOrdem.Image = global::ProjetoLojaDesktop.Properties.Resources.Data_Edit;
            this.btnEditarOrdem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarOrdem.Location = new System.Drawing.Point(375, 331);
            this.btnEditarOrdem.Name = "btnEditarOrdem";
            this.btnEditarOrdem.Size = new System.Drawing.Size(70, 25);
            this.btnEditarOrdem.TabIndex = 6;
            this.btnEditarOrdem.Text = "Editar";
            this.btnEditarOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarOrdem.UseVisualStyleBackColor = true;
            // 
            // btnSalvarOrdem
            // 
            this.btnSalvarOrdem.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvarOrdem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarOrdem.Location = new System.Drawing.Point(451, 331);
            this.btnSalvarOrdem.Name = "btnSalvarOrdem";
            this.btnSalvarOrdem.Size = new System.Drawing.Size(70, 25);
            this.btnSalvarOrdem.TabIndex = 5;
            this.btnSalvarOrdem.Text = "Salvar";
            this.btnSalvarOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarOrdem.UseVisualStyleBackColor = true;
            // 
            // btnNovaOrdem
            // 
            this.btnNovaOrdem.Image = global::ProjetoLojaDesktop.Properties.Resources.Document_02;
            this.btnNovaOrdem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaOrdem.Location = new System.Drawing.Point(299, 331);
            this.btnNovaOrdem.Name = "btnNovaOrdem";
            this.btnNovaOrdem.Size = new System.Drawing.Size(70, 25);
            this.btnNovaOrdem.TabIndex = 4;
            this.btnNovaOrdem.Text = "Novo";
            this.btnNovaOrdem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovaOrdem.UseVisualStyleBackColor = true;
            // 
            // FormTransacaoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 434);
            this.Controls.Add(this.tbcTransacao);
            this.Name = "FormTransacaoSaida";
            this.Text = "Transação";
            this.tbcTransacao.ResumeLayout(false);
            this.tbpTransacao.ResumeLayout(false);
            this.tbpTransacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacao)).EndInit();
            this.tbpOrdemDeServico.ResumeLayout(false);
            this.tbpOrdemDeServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTransacao;
        private System.Windows.Forms.TabPage tbpTransacao;
        private System.Windows.Forms.TabPage tbpOrdemDeServico;
        private System.Windows.Forms.Button btnEditarOrdem;
        private System.Windows.Forms.Button btnSalvarOrdem;
        private System.Windows.Forms.Button btnNovaOrdem;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
        private System.Windows.Forms.DataGridView dgvTransacao;
        private System.Windows.Forms.Button btnEditarTransacao;
        private System.Windows.Forms.Button btnSalvarTransacao;
        private System.Windows.Forms.Button btnNovaTransacao;
        private System.Windows.Forms.MaskedTextBox mtxtDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtValor;
    }
}