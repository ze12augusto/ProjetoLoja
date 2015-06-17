namespace ProjetoLojaDesktop.Views.Relatorios.NotaFiscal
{
    partial class FormNotaFiscal
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
            this.rptNotaFiscal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptNotaFiscal
            // 
            this.rptNotaFiscal.ActiveViewIndex = -1;
            this.rptNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptNotaFiscal.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptNotaFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNotaFiscal.Location = new System.Drawing.Point(0, 0);
            this.rptNotaFiscal.Name = "rptNotaFiscal";
            this.rptNotaFiscal.Size = new System.Drawing.Size(588, 356);
            this.rptNotaFiscal.TabIndex = 0;
            // 
            // FormNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 356);
            this.Controls.Add(this.rptNotaFiscal);
            this.Name = "FormNotaFiscal";
            this.Text = "FormNotaFiscal";
            this.Load += new System.EventHandler(this.FormNotaFiscal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptNotaFiscal;

    }
}