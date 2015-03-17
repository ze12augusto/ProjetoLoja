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
            this.tabListaProduto = new System.Windows.Forms.TabPage();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblQtdAtual = new System.Windows.Forms.Label();
            this.lblQtdMinima = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirImagem = new System.Windows.Forms.Button();
            this.dgvImagem = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescricaoCaracteristicaProduto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdcCarac = new System.Windows.Forms.Button();
            this.btnExcCarac = new System.Windows.Forms.Button();
            this.tabDetalhesProduto.SuspendLayout();
            this.tabListaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.tabProdutos.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetalhesProduto
            // 
            this.tabDetalhesProduto.Controls.Add(this.btnExcCarac);
            this.tabDetalhesProduto.Controls.Add(this.btnAdcCarac);
            this.tabDetalhesProduto.Controls.Add(this.dataGridView1);
            this.tabDetalhesProduto.Controls.Add(this.txtDescricaoCaracteristicaProduto);
            this.tabDetalhesProduto.Controls.Add(this.txtTitulo);
            this.tabDetalhesProduto.Controls.Add(this.label1);
            this.tabDetalhesProduto.Controls.Add(this.btnExcluirImagem);
            this.tabDetalhesProduto.Controls.Add(this.dgvImagem);
            this.tabDetalhesProduto.Controls.Add(this.btnSelecionar);
            this.tabDetalhesProduto.Controls.Add(this.lblImagem);
            this.tabDetalhesProduto.Location = new System.Drawing.Point(4, 22);
            this.tabDetalhesProduto.Name = "tabDetalhesProduto";
            this.tabDetalhesProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalhesProduto.Size = new System.Drawing.Size(540, 365);
            this.tabDetalhesProduto.TabIndex = 2;
            this.tabDetalhesProduto.Text = "Detalhes";
            this.tabDetalhesProduto.UseVisualStyleBackColor = true;
            // 
            // tabListaProduto
            // 
            this.tabListaProduto.Controls.Add(this.btnPesquisar);
            this.tabListaProduto.Controls.Add(this.btnExcluirProduto);
            this.tabListaProduto.Controls.Add(this.btnEditarProduto);
            this.tabListaProduto.Controls.Add(this.btnNovoProduto);
            this.tabListaProduto.Controls.Add(this.dgvProduto);
            this.tabListaProduto.Controls.Add(this.txtPesquisar);
            this.tabListaProduto.Controls.Add(this.lbPesquisar);
            this.tabListaProduto.Location = new System.Drawing.Point(4, 22);
            this.tabListaProduto.Name = "tabListaProduto";
            this.tabListaProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaProduto.Size = new System.Drawing.Size(540, 365);
            this.tabListaProduto.TabIndex = 0;
            this.tabListaProduto.Text = "Lista de Produtos";
            this.tabListaProduto.UseVisualStyleBackColor = true;
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(21, 25);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(83, 22);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(374, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(20, 64);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(498, 250);
            this.dgvProduto.TabIndex = 2;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Location = new System.Drawing.Point(281, 326);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProduto.TabIndex = 3;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(362, 326);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 4;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(443, 326);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(473, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "p";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabListaProduto);
            this.tabProdutos.Controls.Add(this.tabProduto);
            this.tabProdutos.Controls.Add(this.tabDetalhesProduto);
            this.tabProdutos.Location = new System.Drawing.Point(12, 12);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(548, 391);
            this.tabProdutos.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(394, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(385, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 20);
            this.textBox1.TabIndex = 22;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(72, 134);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(385, 134);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(128, 21);
            this.cbxModelo.TabIndex = 21;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(119, 134);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(144, 21);
            this.cbxMarca.TabIndex = 27;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(337, 140);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo";
            // 
            // lblQtdAtual
            // 
            this.lblQtdAtual.AutoSize = true;
            this.lblQtdAtual.Location = new System.Drawing.Point(290, 101);
            this.lblQtdAtual.Name = "lblQtdAtual";
            this.lblQtdAtual.Size = new System.Drawing.Size(89, 13);
            this.lblQtdAtual.TabIndex = 19;
            this.lblQtdAtual.Text = "Quantidade Atual";
            // 
            // lblQtdMinima
            // 
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Location = new System.Drawing.Point(11, 99);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(98, 13);
            this.lblQtdMinima.TabIndex = 18;
            this.lblQtdMinima.Text = "Quantidade Minima";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(54, 70);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descricao";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(357, 178);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(67, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
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
            this.tabProduto.Controls.Add(this.textBox1);
            this.tabProduto.Controls.Add(this.textBox4);
            this.tabProduto.Controls.Add(this.textBox2);
            this.tabProduto.Controls.Add(this.textBox3);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(540, 365);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produtos";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(438, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirImagem
            // 
            this.btnExcluirImagem.Location = new System.Drawing.Point(88, 49);
            this.btnExcluirImagem.Name = "btnExcluirImagem";
            this.btnExcluirImagem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirImagem.TabIndex = 37;
            this.btnExcluirImagem.Text = "Excluir";
            this.btnExcluirImagem.UseVisualStyleBackColor = true;
            // 
            // dgvImagem
            // 
            this.dgvImagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagem.Location = new System.Drawing.Point(169, 20);
            this.dgvImagem.Name = "dgvImagem";
            this.dgvImagem.Size = new System.Drawing.Size(313, 85);
            this.dgvImagem.TabIndex = 36;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(88, 20);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 35;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(38, 25);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(44, 13);
            this.lblImagem.TabIndex = 34;
            this.lblImagem.Text = "Imagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Caracteristicas";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(88, 135);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(394, 20);
            this.txtTitulo.TabIndex = 39;
            // 
            // txtDescricaoCaracteristicaProduto
            // 
            this.txtDescricaoCaracteristicaProduto.Location = new System.Drawing.Point(88, 161);
            this.txtDescricaoCaracteristicaProduto.Multiline = true;
            this.txtDescricaoCaracteristicaProduto.Name = "txtDescricaoCaracteristicaProduto";
            this.txtDescricaoCaracteristicaProduto.Size = new System.Drawing.Size(394, 58);
            this.txtDescricaoCaracteristicaProduto.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 87);
            this.dataGridView1.TabIndex = 41;
            // 
            // btnAdcCarac
            // 
            this.btnAdcCarac.Location = new System.Drawing.Point(326, 318);
            this.btnAdcCarac.Name = "btnAdcCarac";
            this.btnAdcCarac.Size = new System.Drawing.Size(75, 23);
            this.btnAdcCarac.TabIndex = 42;
            this.btnAdcCarac.Text = "Adcionar";
            this.btnAdcCarac.UseVisualStyleBackColor = true;

            // 
            // btnExcCarac
            // 
            this.btnExcCarac.Location = new System.Drawing.Point(407, 318);
            this.btnExcCarac.Name = "btnExcCarac";
            this.btnExcCarac.Size = new System.Drawing.Size(75, 23);
            this.btnExcCarac.TabIndex = 43;
            this.btnExcCarac.Text = "Excluir";
            this.btnExcCarac.UseVisualStyleBackColor = true;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 418);
            this.Controls.Add(this.tabProdutos);
            this.Name = "Produto";
            this.Text = "Produto";
            this.tabDetalhesProduto.ResumeLayout(false);
            this.tabDetalhesProduto.PerformLayout();
            this.tabListaProduto.ResumeLayout(false);
            this.tabListaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.tabProdutos.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnPesquisar;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnExcCarac;
        private System.Windows.Forms.Button btnAdcCarac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDescricaoCaracteristicaProduto;
        private System.Windows.Forms.TextBox txtTitulo;


    }
}