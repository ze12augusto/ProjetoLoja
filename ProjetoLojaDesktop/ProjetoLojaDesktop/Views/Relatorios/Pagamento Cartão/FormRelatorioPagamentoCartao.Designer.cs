namespace ProjetoLojaDesktop.Views.Relatorios.Pagamento_Cartão
{
    partial class FormRelatorioPagamentoCartao
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
            this.produtoReport1 = new ProjetoLojaDesktop.Views.Relatorios.Produto.ProdutoReport();
            this.tabPagamentoCartao = new System.Windows.Forms.TabControl();
            this.tabPesquisaPagamentoCartao = new System.Windows.Forms.TabPage();
            this.gpbPesquisaPagamentoCartao = new System.Windows.Forms.GroupBox();
            this.chkDataFim = new System.Windows.Forms.CheckBox();
            this.chkDataInicio = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.tabRelatorioPagamentoCartao = new System.Windows.Forms.TabPage();
            this.rptProduto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPagamentoCartao.SuspendLayout();
            this.tabPesquisaPagamentoCartao.SuspendLayout();
            this.gpbPesquisaPagamentoCartao.SuspendLayout();
            this.tabRelatorioPagamentoCartao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPagamentoCartao
            // 
            this.tabPagamentoCartao.Controls.Add(this.tabPesquisaPagamentoCartao);
            this.tabPagamentoCartao.Controls.Add(this.tabRelatorioPagamentoCartao);
            this.tabPagamentoCartao.Location = new System.Drawing.Point(3, 5);
            this.tabPagamentoCartao.Name = "tabPagamentoCartao";
            this.tabPagamentoCartao.SelectedIndex = 0;
            this.tabPagamentoCartao.Size = new System.Drawing.Size(754, 410);
            this.tabPagamentoCartao.TabIndex = 0;
            // 
            // tabPesquisaPagamentoCartao
            // 
            this.tabPesquisaPagamentoCartao.Controls.Add(this.gpbPesquisaPagamentoCartao);
            this.tabPesquisaPagamentoCartao.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisaPagamentoCartao.Name = "tabPesquisaPagamentoCartao";
            this.tabPesquisaPagamentoCartao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisaPagamentoCartao.Size = new System.Drawing.Size(746, 384);
            this.tabPesquisaPagamentoCartao.TabIndex = 0;
            this.tabPesquisaPagamentoCartao.Text = "Pesquisa de Pagamento";
            this.tabPesquisaPagamentoCartao.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisaPagamentoCartao
            // 
            this.gpbPesquisaPagamentoCartao.Controls.Add(this.chkDataFim);
            this.gpbPesquisaPagamentoCartao.Controls.Add(this.chkDataInicio);
            this.gpbPesquisaPagamentoCartao.Controls.Add(this.btnPesquisar);
            this.gpbPesquisaPagamentoCartao.Controls.Add(this.dtpDataFim);
            this.gpbPesquisaPagamentoCartao.Controls.Add(this.dtpDataInicio);
            this.gpbPesquisaPagamentoCartao.Location = new System.Drawing.Point(23, 33);
            this.gpbPesquisaPagamentoCartao.Name = "gpbPesquisaPagamentoCartao";
            this.gpbPesquisaPagamentoCartao.Size = new System.Drawing.Size(363, 251);
            this.gpbPesquisaPagamentoCartao.TabIndex = 8;
            this.gpbPesquisaPagamentoCartao.TabStop = false;
            // 
            // chkDataFim
            // 
            this.chkDataFim.AutoSize = true;
            this.chkDataFim.Location = new System.Drawing.Point(25, 86);
            this.chkDataFim.Name = "chkDataFim";
            this.chkDataFim.Size = new System.Drawing.Size(71, 17);
            this.chkDataFim.TabIndex = 13;
            this.chkDataFim.Text = "Data Fim:";
            this.chkDataFim.UseVisualStyleBackColor = true;
            // 
            // chkDataInicio
            // 
            this.chkDataInicio.AutoSize = true;
            this.chkDataInicio.Location = new System.Drawing.Point(25, 43);
            this.chkDataInicio.Name = "chkDataInicio";
            this.chkDataInicio.Size = new System.Drawing.Size(80, 17);
            this.chkDataInicio.TabIndex = 12;
            this.chkDataInicio.Text = "Data Inicio:";
            this.chkDataInicio.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::ProjetoLojaDesktop.Properties.Resources.Search;
            this.btnPesquisar.Location = new System.Drawing.Point(301, 204);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(111, 86);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(215, 20);
            this.dtpDataFim.TabIndex = 10;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(111, 43);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(215, 20);
            this.dtpDataInicio.TabIndex = 8;
            // 
            // tabRelatorioPagamentoCartao
            // 
            this.tabRelatorioPagamentoCartao.Controls.Add(this.rptProduto);
            this.tabRelatorioPagamentoCartao.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorioPagamentoCartao.Name = "tabRelatorioPagamentoCartao";
            this.tabRelatorioPagamentoCartao.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorioPagamentoCartao.Size = new System.Drawing.Size(746, 384);
            this.tabRelatorioPagamentoCartao.TabIndex = 1;
            this.tabRelatorioPagamentoCartao.Text = "Relatório de Pagamento";
            this.tabRelatorioPagamentoCartao.UseVisualStyleBackColor = true;
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
            this.rptProduto.Size = new System.Drawing.Size(740, 378);
            this.rptProduto.TabIndex = 1;
            // 
            // FormRelatorioPagamentoCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 413);
            this.Controls.Add(this.tabPagamentoCartao);
            this.Name = "FormRelatorioPagamentoCartao";
            this.Text = " ";
            this.tabPagamentoCartao.ResumeLayout(false);
            this.tabPesquisaPagamentoCartao.ResumeLayout(false);
            this.gpbPesquisaPagamentoCartao.ResumeLayout(false);
            this.gpbPesquisaPagamentoCartao.PerformLayout();
            this.tabRelatorioPagamentoCartao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Produto.ProdutoReport produtoReport1;
        private System.Windows.Forms.TabControl tabPagamentoCartao;
        private System.Windows.Forms.TabPage tabPesquisaPagamentoCartao;
        private System.Windows.Forms.TabPage tabRelatorioPagamentoCartao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gpbPesquisaPagamentoCartao;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.CheckBox chkDataFim;
        private System.Windows.Forms.CheckBox chkDataInicio;


    }
}