namespace ProjetoLojaDesktop.Views
{
    partial class FormPagamentoCartao
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
            this.rptPagamentoCartao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptPagamentoCartao
            // 
            this.rptPagamentoCartao.ActiveViewIndex = -1;
            this.rptPagamentoCartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptPagamentoCartao.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptPagamentoCartao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPagamentoCartao.Location = new System.Drawing.Point(0, 0);
            this.rptPagamentoCartao.Name = "rptPagamentoCartao";
            this.rptPagamentoCartao.Size = new System.Drawing.Size(657, 352);
            this.rptPagamentoCartao.TabIndex = 0;
            // 
            // FormPagamentoCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 352);
            this.Controls.Add(this.rptPagamentoCartao);
            this.Name = "FormPagamentoCartao";
            this.Text = "FormPagamentoCartao";
            this.Load += new System.EventHandler(this.FormPagamentoCartao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptPagamentoCartao;

    }
}