namespace ProjetoLojaDesktop.Views.Relatorios.StatusPedido
{
    partial class FormStatusPedido
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
            this.rptStatusPedido = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptStatusPedido
            // 
            this.rptStatusPedido.ActiveViewIndex = -1;
            this.rptStatusPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptStatusPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptStatusPedido.Location = new System.Drawing.Point(-2, -4);
            this.rptStatusPedido.Name = "rptStatusPedido";
            this.rptStatusPedido.Size = new System.Drawing.Size(613, 366);
            this.rptStatusPedido.TabIndex = 1;
            // 
            // FormStatusPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 364);
            this.Controls.Add(this.rptStatusPedido);
            this.Name = "FormStatusPedido";
            this.Text = "FormStatusPedido";
            this.Load += new System.EventHandler(this.FormStatusPedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptStatusPedido;

    }
}