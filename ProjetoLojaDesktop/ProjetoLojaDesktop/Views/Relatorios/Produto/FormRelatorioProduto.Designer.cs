namespace ProjetoLojaDesktop.Views.Relatorios.Produto
{
    partial class FormRelatorioProduto
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
            this.tbcRelatorioProdutos = new System.Windows.Forms.TabControl();
            this.tbpPesqProdutos = new System.Windows.Forms.TabPage();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDescProduto = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbpRelatorioProdutos = new System.Windows.Forms.TabPage();
            this.rptProduto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbcRelatorioProdutos.SuspendLayout();
            this.tbpPesqProdutos.SuspendLayout();
            this.tbpRelatorioProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRelatorioProdutos
            // 
            this.tbcRelatorioProdutos.Controls.Add(this.tbpPesqProdutos);
            this.tbcRelatorioProdutos.Controls.Add(this.tbpRelatorioProdutos);
            this.tbcRelatorioProdutos.ItemSize = new System.Drawing.Size(110, 18);
            this.tbcRelatorioProdutos.Location = new System.Drawing.Point(0, 1);
            this.tbcRelatorioProdutos.Name = "tbcRelatorioProdutos";
            this.tbcRelatorioProdutos.SelectedIndex = 0;
            this.tbcRelatorioProdutos.Size = new System.Drawing.Size(892, 489);
            this.tbcRelatorioProdutos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcRelatorioProdutos.TabIndex = 0;
            // 
            // tbpPesqProdutos
            // 
            this.tbpPesqProdutos.Controls.Add(this.txtDescProduto);
            this.tbpPesqProdutos.Controls.Add(this.cbxModelo);
            this.tbpPesqProdutos.Controls.Add(this.cbxMarca);
            this.tbpPesqProdutos.Controls.Add(this.btnPesquisar);
            this.tbpPesqProdutos.Controls.Add(this.lblDescProduto);
            this.tbpPesqProdutos.Controls.Add(this.lblModelo);
            this.tbpPesqProdutos.Controls.Add(this.lblMarca);
            this.tbpPesqProdutos.Location = new System.Drawing.Point(4, 22);
            this.tbpPesqProdutos.Name = "tbpPesqProdutos";
            this.tbpPesqProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPesqProdutos.Size = new System.Drawing.Size(884, 463);
            this.tbpPesqProdutos.TabIndex = 0;
            this.tbpPesqProdutos.Text = "Pesquisa de Produtos";
            this.tbpPesqProdutos.UseVisualStyleBackColor = true;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Location = new System.Drawing.Point(139, 92);
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(161, 20);
            this.txtDescProduto.TabIndex = 6;
            // 
            // cbxModelo
            // 
            this.cbxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(139, 57);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(161, 21);
            this.cbxModelo.TabIndex = 5;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(139, 21);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(161, 21);
            this.cbxMarca.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::ProjetoLojaDesktop.Properties.Resources.Search;
            this.btnPesquisar.Location = new System.Drawing.Point(306, 89);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblDescProduto
            // 
            this.lblDescProduto.AutoSize = true;
            this.lblDescProduto.Location = new System.Drawing.Point(20, 95);
            this.lblDescProduto.Name = "lblDescProduto";
            this.lblDescProduto.Size = new System.Drawing.Size(113, 13);
            this.lblDescProduto.TabIndex = 2;
            this.lblDescProduto.Text = "Descrição do Produto:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(88, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(93, 24);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // tbpRelatorioProdutos
            // 
            this.tbpRelatorioProdutos.Controls.Add(this.rptProduto);
            this.tbpRelatorioProdutos.Location = new System.Drawing.Point(4, 22);
            this.tbpRelatorioProdutos.Name = "tbpRelatorioProdutos";
            this.tbpRelatorioProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRelatorioProdutos.Size = new System.Drawing.Size(884, 463);
            this.tbpRelatorioProdutos.TabIndex = 1;
            this.tbpRelatorioProdutos.Text = "Relatório de Produtos";
            this.tbpRelatorioProdutos.UseVisualStyleBackColor = true;
            // 
            // rptProduto
            // 
            this.rptProduto.ActiveViewIndex = -1;
            this.rptProduto.AutoScroll = true;
            this.rptProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptProduto.Location = new System.Drawing.Point(3, 3);
            this.rptProduto.Name = "rptProduto";
            this.rptProduto.Size = new System.Drawing.Size(878, 457);
            this.rptProduto.TabIndex = 0;
            // 
            // FormRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 491);
            this.Controls.Add(this.tbcRelatorioProdutos);
            this.Name = "FormRelatorioProduto";
            this.Text = "FormRelatorioProduto";
            this.Load += new System.EventHandler(this.FormRelatorioProduto_Load);
            this.tbcRelatorioProdutos.ResumeLayout(false);
            this.tbpPesqProdutos.ResumeLayout(false);
            this.tbpPesqProdutos.PerformLayout();
            this.tbpRelatorioProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRelatorioProdutos;
        private System.Windows.Forms.TabPage tbpPesqProdutos;
        private System.Windows.Forms.TabPage tbpRelatorioProdutos;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptProduto;
        private System.Windows.Forms.Label lblDescProduto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btnPesquisar;

    }
}