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
            this.btnExcCarac = new System.Windows.Forms.Button();
            this.btnAdcCarac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDescricaoCaracteristicaProduto = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirImagem = new System.Windows.Forms.Button();
            this.dgvImagem = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.tabListaProduto = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQtdMinima = new System.Windows.Forms.Label();
            this.lblQtdAtual = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabDetalhesProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).BeginInit();
            this.tabListaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.tabProdutos.SuspendLayout();
            this.tabProduto.SuspendLayout();
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
            this.tabDetalhesProduto.Size = new System.Drawing.Size(498, 356);
            this.tabDetalhesProduto.TabIndex = 2;
            this.tabDetalhesProduto.Text = "Detalhes";
            this.tabDetalhesProduto.UseVisualStyleBackColor = true;
            // 
            // btnExcCarac
            // 
            this.btnExcCarac.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnExcCarac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcCarac.Location = new System.Drawing.Point(415, 294);
            this.btnExcCarac.Name = "btnExcCarac";
            this.btnExcCarac.Size = new System.Drawing.Size(70, 25);
            this.btnExcCarac.TabIndex = 43;
            this.btnExcCarac.Text = "Excluir";
            this.btnExcCarac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcCarac.UseVisualStyleBackColor = true;
            // 
            // btnAdcCarac
            // 
            this.btnAdcCarac.Image = global::ProjetoLojaDesktop.Properties.Resources.Add_New;
            this.btnAdcCarac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdcCarac.Location = new System.Drawing.Point(332, 294);
            this.btnAdcCarac.Name = "btnAdcCarac";
            this.btnAdcCarac.Size = new System.Drawing.Size(80, 25);
            this.btnAdcCarac.TabIndex = 42;
            this.btnAdcCarac.Text = "Adcionar";
            this.btnAdcCarac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdcCarac.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 87);
            this.dataGridView1.TabIndex = 41;
            // 
            // txtDescricaoCaracteristicaProduto
            // 
            this.txtDescricaoCaracteristicaProduto.Location = new System.Drawing.Point(86, 123);
            this.txtDescricaoCaracteristicaProduto.Multiline = true;
            this.txtDescricaoCaracteristicaProduto.Name = "txtDescricaoCaracteristicaProduto";
            this.txtDescricaoCaracteristicaProduto.Size = new System.Drawing.Size(398, 58);
            this.txtDescricaoCaracteristicaProduto.TabIndex = 40;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(86, 90);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(398, 20);
            this.txtTitulo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Caracteristicas";
            // 
            // btnExcluirImagem
            // 
            this.btnExcluirImagem.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnExcluirImagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirImagem.Location = new System.Drawing.Point(86, 49);
            this.btnExcluirImagem.Name = "btnExcluirImagem";
            this.btnExcluirImagem.Size = new System.Drawing.Size(80, 25);
            this.btnExcluirImagem.TabIndex = 37;
            this.btnExcluirImagem.Text = "Excluir";
            this.btnExcluirImagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirImagem.UseVisualStyleBackColor = true;
            // 
            // dgvImagem
            // 
            this.dgvImagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagem.Location = new System.Drawing.Point(179, 20);
            this.dgvImagem.Name = "dgvImagem";
            this.dgvImagem.Size = new System.Drawing.Size(305, 54);
            this.dgvImagem.TabIndex = 36;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::ProjetoLojaDesktop.Properties.Resources.Add_New;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(86, 20);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(80, 25);
            this.btnSelecionar.TabIndex = 35;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(40, 25);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(44, 13);
            this.lblImagem.TabIndex = 34;
            this.lblImagem.Text = "Imagem";
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
            this.tabListaProduto.Size = new System.Drawing.Size(498, 356);
            this.tabListaProduto.TabIndex = 0;
            this.tabListaProduto.Text = "Lista de Produtos";
            this.tabListaProduto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::ProjetoLojaDesktop.Properties.Resources.Search;
            this.btnPesquisar.Location = new System.Drawing.Point(458, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.Location = new System.Drawing.Point(414, 318);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(70, 25);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Data_Edit;
            this.btnEditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProduto.Location = new System.Drawing.Point(341, 318);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(70, 25);
            this.btnEditarProduto.TabIndex = 4;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Image = global::ProjetoLojaDesktop.Properties.Resources.Document_02;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.Location = new System.Drawing.Point(267, 318);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(70, 25);
            this.btnNovoProduto.TabIndex = 3;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(16, 56);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(468, 250);
            this.dgvProduto.TabIndex = 2;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(72, 22);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(374, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(16, 25);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lbPesquisar.TabIndex = 0;
            this.lbPesquisar.Text = "Pesquisar";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabListaProduto);
            this.tabProdutos.Controls.Add(this.tabProduto);
            this.tabProdutos.Controls.Add(this.tabDetalhesProduto);
            this.tabProdutos.Location = new System.Drawing.Point(12, 12);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(506, 382);
            this.tabProdutos.TabIndex = 16;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.btnCancelar);
            this.tabProduto.Controls.Add(this.lblNome);
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
            this.tabProduto.Controls.Add(this.btnSalvar);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(498, 365);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produtos";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProjetoLojaDesktop.Properties.Resources.Garbage;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(406, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 25);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(75, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(55, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblQtdMinima
            // 
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Location = new System.Drawing.Point(12, 89);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(98, 13);
            this.lblQtdMinima.TabIndex = 18;
            this.lblQtdMinima.Text = "Quantidade Minima";
            // 
            // lblQtdAtual
            // 
            this.lblQtdAtual.AutoSize = true;
            this.lblQtdAtual.Location = new System.Drawing.Point(264, 88);
            this.lblQtdAtual.Name = "lblQtdAtual";
            this.lblQtdAtual.Size = new System.Drawing.Size(89, 13);
            this.lblQtdAtual.TabIndex = 19;
            this.lblQtdAtual.Text = "Quantidade Atual";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(312, 123);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo";
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(113, 118);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(128, 21);
            this.cbxMarca.TabIndex = 27;
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(357, 118);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(128, 21);
            this.cbxModelo.TabIndex = 21;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(73, 124);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 26;
            this.lblMarca.Text = "Marca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(356, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 24;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ProjetoLojaDesktop.Properties.Resources.Save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(332, 151);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 25);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 410);
            this.Controls.Add(this.tabProdutos);
            this.Name = "FormProdutos";
            this.Text = "Produto";
            this.tabDetalhesProduto.ResumeLayout(false);
            this.tabDetalhesProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagem)).EndInit();
            this.tabListaProduto.ResumeLayout(false);
            this.tabListaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.tabProdutos.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
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