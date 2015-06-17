namespace ProjetoLojaDesktop.Views.Relatorios.Produto
{
    partial class FormProduto
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
            this.rptProduto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptProduto
            // 
            this.rptProduto.ActiveViewIndex = -1;
            this.rptProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptProduto.Location = new System.Drawing.Point(0, 0);
            this.rptProduto.Name = "rptProduto";
            this.rptProduto.Size = new System.Drawing.Size(648, 400);
            this.rptProduto.TabIndex = 0;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 400);
            this.Controls.Add(this.rptProduto);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptProduto;

    }
}