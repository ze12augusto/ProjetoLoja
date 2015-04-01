namespace ProjetoLojaDesktop.Forms
{
    partial class FormModelo
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvModelos = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(278, 88);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(73, 90);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(199, 20);
            this.txtPesquisar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pesquisar";
            // 
            // dgvModelos
            // 
            this.dgvModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelos.Location = new System.Drawing.Point(15, 123);
            this.dgvModelos.Name = "dgvModelos";
            this.dgvModelos.Size = new System.Drawing.Size(288, 176);
            this.dgvModelos.TabIndex = 13;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 22);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(230, 20);
            this.txtDescricao.TabIndex = 12;
            // 
            // Excluir
            // 
            this.Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Excluir.Location = new System.Drawing.Point(161, 312);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(70, 25);
            this.Excluir.TabIndex = 9;
            this.Excluir.Text = "Excluir";
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editar.Location = new System.Drawing.Point(87, 312);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(70, 25);
            this.Editar.TabIndex = 10;
            this.Editar.Text = "Editar";
            this.Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // Salvar
            // 
            this.Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salvar.Location = new System.Drawing.Point(14, 312);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(70, 25);
            this.Salvar.TabIndex = 11;
            this.Salvar.Text = "Salvar";
            this.Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descricão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Marca";
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(73, 55);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(230, 21);
            this.cbxMarcas.TabIndex = 19;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::ProjetoLojaDesktop.Properties.Resources.Clean;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(234, 312);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 25);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 352);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvModelos);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.label1);
            this.Name = "FormModelo";
            this.Text = "Cadastro de Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvModelos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMarcas;
    }
}