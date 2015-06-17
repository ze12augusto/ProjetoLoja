namespace ProjetoLojaDesktop.Views.Relatorios.RelatorioOS
{
    partial class FormRelatorioOS
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
            this.rptRelatorioOS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptRelatorioOS
            // 
            this.rptRelatorioOS.ActiveViewIndex = -1;
            this.rptRelatorioOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptRelatorioOS.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptRelatorioOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptRelatorioOS.Location = new System.Drawing.Point(0, 0);
            this.rptRelatorioOS.Name = "rptRelatorioOS";
            this.rptRelatorioOS.Size = new System.Drawing.Size(553, 376);
            this.rptRelatorioOS.TabIndex = 0;
            // 
            // FormRelatorioOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 376);
            this.Controls.Add(this.rptRelatorioOS);
            this.Name = "FormRelatorioOS";
            this.Text = "FormRelatorioOS";
            this.Load += new System.EventHandler(this.FormRelatorioOS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptRelatorioOS;

    }
}