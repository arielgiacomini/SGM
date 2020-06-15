namespace GUI
{
    partial class frmCadastroPeca
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPecaId = new System.Windows.Forms.Label();
            this.lblPeca = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPecaId = new System.Windows.Forms.TextBox();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.txtValorPeca = new System.Windows.Forms.MaskedTextBox();
            this.txtValorFrete = new System.Windows.Forms.MaskedTextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.txtFornecedor);
            this.pnCadastro.Controls.Add(this.txtValorFrete);
            this.pnCadastro.Controls.Add(this.txtValorPeca);
            this.pnCadastro.Controls.Add(this.txtPeca);
            this.pnCadastro.Controls.Add(this.txtPecaId);
            this.pnCadastro.Controls.Add(this.label5);
            this.pnCadastro.Controls.Add(this.label4);
            this.pnCadastro.Controls.Add(this.lblFornecedor);
            this.pnCadastro.Controls.Add(this.lblPeca);
            this.pnCadastro.Controls.Add(this.lblPecaId);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblPecaId
            // 
            this.lblPecaId.AutoSize = true;
            this.lblPecaId.Location = new System.Drawing.Point(52, 35);
            this.lblPecaId.Name = "lblPecaId";
            this.lblPecaId.Size = new System.Drawing.Size(46, 13);
            this.lblPecaId.TabIndex = 0;
            this.lblPecaId.Text = "Código: ";
            // 
            // lblPeca
            // 
            this.lblPeca.AutoSize = true;
            this.lblPeca.Location = new System.Drawing.Point(37, 70);
            this.lblPeca.Name = "lblPeca";
            this.lblPeca.Size = new System.Drawing.Size(61, 26);
            this.lblPeca.TabIndex = 1;
            this.lblPeca.Text = "Descrição: \r\n\r\n";
            this.lblPeca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(31, 114);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(67, 13);
            this.lblFornecedor.TabIndex = 2;
            this.lblFornecedor.Text = "Fornecedor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Frete/Adicional: ";
            // 
            // txtPecaId
            // 
            this.txtPecaId.Enabled = false;
            this.txtPecaId.Location = new System.Drawing.Point(100, 32);
            this.txtPecaId.Name = "txtPecaId";
            this.txtPecaId.Size = new System.Drawing.Size(135, 20);
            this.txtPecaId.TabIndex = 5;
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(100, 65);
            this.txtPeca.Multiline = true;
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(531, 31);
            this.txtPeca.TabIndex = 6;
            // 
            // txtValorPeca
            // 
            this.txtValorPeca.Location = new System.Drawing.Point(100, 145);
            this.txtValorPeca.Name = "txtValorPeca";
            this.txtValorPeca.Size = new System.Drawing.Size(80, 20);
            this.txtValorPeca.TabIndex = 8;
            this.txtValorPeca.Leave += new System.EventHandler(this.txtValorPeca_Leave);
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(100, 172);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Size = new System.Drawing.Size(80, 20);
            this.txtValorFrete.TabIndex = 9;
            this.txtValorFrete.Leave += new System.EventHandler(this.txtValorFrete_Leave);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(100, 114);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(502, 20);
            this.txtFornecedor.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(347, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastroPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroPeca";
            this.Text = "Sistema de Gerenciamento Mecânica - Cadastro de Peças/Produtos";
            this.Load += new System.EventHandler(this.frmCadastroPeca_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.MaskedTextBox txtValorFrete;
        private System.Windows.Forms.MaskedTextBox txtValorPeca;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.TextBox txtPecaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblPeca;
        private System.Windows.Forms.Label lblPecaId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
