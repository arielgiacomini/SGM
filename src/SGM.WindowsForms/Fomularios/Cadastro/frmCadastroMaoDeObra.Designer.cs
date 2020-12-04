namespace SGM.WindowsForms
{
    partial class FrmCadastroMaoDeObra
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
            this.lblMaoDeObraId = new System.Windows.Forms.Label();
            this.lblMaoDeObra = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblVigenciaInicial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaoDeObraId = new System.Windows.Forms.TextBox();
            this.txtMaoDeObra = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtVigenciaInicial = new System.Windows.Forms.MaskedTextBox();
            this.txtVigenciaFinal = new System.Windows.Forms.MaskedTextBox();
            this.cboAtivo = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.lblAtivo);
            this.pnCadastro.Controls.Add(this.cboAtivo);
            this.pnCadastro.Controls.Add(this.txtVigenciaFinal);
            this.pnCadastro.Controls.Add(this.txtVigenciaInicial);
            this.pnCadastro.Controls.Add(this.txtValor);
            this.pnCadastro.Controls.Add(this.cboTipo);
            this.pnCadastro.Controls.Add(this.txtMaoDeObra);
            this.pnCadastro.Controls.Add(this.txtMaoDeObraId);
            this.pnCadastro.Controls.Add(this.label6);
            this.pnCadastro.Controls.Add(this.lblVigenciaInicial);
            this.pnCadastro.Controls.Add(this.lblValor);
            this.pnCadastro.Controls.Add(this.lblTipo);
            this.pnCadastro.Controls.Add(this.lblMaoDeObra);
            this.pnCadastro.Controls.Add(this.lblMaoDeObraId);
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.TabIndex = 13;
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // lblMaoDeObraId
            // 
            this.lblMaoDeObraId.AutoSize = true;
            this.lblMaoDeObraId.Location = new System.Drawing.Point(22, 36);
            this.lblMaoDeObraId.Name = "lblMaoDeObraId";
            this.lblMaoDeObraId.Size = new System.Drawing.Size(46, 13);
            this.lblMaoDeObraId.TabIndex = 0;
            this.lblMaoDeObraId.Text = "Código: ";
            this.lblMaoDeObraId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaoDeObra
            // 
            this.lblMaoDeObra.AutoSize = true;
            this.lblMaoDeObra.Location = new System.Drawing.Point(15, 87);
            this.lblMaoDeObra.Name = "lblMaoDeObra";
            this.lblMaoDeObra.Size = new System.Drawing.Size(61, 13);
            this.lblMaoDeObra.TabIndex = 1;
            this.lblMaoDeObra.Text = "Descrição: ";
            this.lblMaoDeObra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 135);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo: ";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(28, 172);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor: ";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVigenciaInicial
            // 
            this.lblVigenciaInicial.AutoSize = true;
            this.lblVigenciaInicial.Location = new System.Drawing.Point(21, 203);
            this.lblVigenciaInicial.Name = "lblVigenciaInicial";
            this.lblVigenciaInicial.Size = new System.Drawing.Size(48, 26);
            this.lblVigenciaInicial.TabIndex = 4;
            this.lblVigenciaInicial.Text = "Vigência\r\nInicial:";
            this.lblVigenciaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vigência\r\nFinal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaoDeObraId
            // 
            this.txtMaoDeObraId.Enabled = false;
            this.txtMaoDeObraId.Location = new System.Drawing.Point(78, 33);
            this.txtMaoDeObraId.Name = "txtMaoDeObraId";
            this.txtMaoDeObraId.Size = new System.Drawing.Size(125, 20);
            this.txtMaoDeObraId.TabIndex = 6;
            // 
            // txtMaoDeObra
            // 
            this.txtMaoDeObra.Location = new System.Drawing.Point(78, 74);
            this.txtMaoDeObra.Multiline = true;
            this.txtMaoDeObra.Name = "txtMaoDeObra";
            this.txtMaoDeObra.Size = new System.Drawing.Size(661, 36);
            this.txtMaoDeObra.TabIndex = 7;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Pequeno Esforço",
            "Médio Esforço",
            "Grande Esforço",
            "Mega Esforço"});
            this.cboTipo.Location = new System.Drawing.Point(78, 127);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(78, 169);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 9;
            this.txtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // txtVigenciaInicial
            // 
            this.txtVigenciaInicial.Location = new System.Drawing.Point(78, 209);
            this.txtVigenciaInicial.Mask = "00/00/0000";
            this.txtVigenciaInicial.Name = "txtVigenciaInicial";
            this.txtVigenciaInicial.Size = new System.Drawing.Size(74, 20);
            this.txtVigenciaInicial.TabIndex = 10;
            this.txtVigenciaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVigenciaFinal
            // 
            this.txtVigenciaFinal.Location = new System.Drawing.Point(78, 249);
            this.txtVigenciaFinal.Mask = "00/00/0000";
            this.txtVigenciaFinal.Name = "txtVigenciaFinal";
            this.txtVigenciaFinal.Size = new System.Drawing.Size(74, 20);
            this.txtVigenciaFinal.TabIndex = 11;
            this.txtVigenciaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboAtivo
            // 
            this.cboAtivo.FormattingEnabled = true;
            this.cboAtivo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboAtivo.Location = new System.Drawing.Point(78, 286);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.Size = new System.Drawing.Size(100, 21);
            this.cboAtivo.TabIndex = 12;
            this.cboAtivo.Text = "Selecione";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(28, 289);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(37, 13);
            this.lblAtivo.TabIndex = 13;
            this.lblAtivo.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho1;
            this.pictureBox1.Location = new System.Drawing.Point(384, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastroMaoDeObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroMaoDeObra";
            this.Text = "Sistema de Gerenciamento Mecânica - Cadastro de Mão de Obra (Serviços)";
            this.Load += new System.EventHandler(this.FrmCadastroMaoDeObra_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaoDeObraId;
        private System.Windows.Forms.MaskedTextBox txtVigenciaFinal;
        private System.Windows.Forms.MaskedTextBox txtVigenciaInicial;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtMaoDeObra;
        private System.Windows.Forms.TextBox txtMaoDeObraId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVigenciaInicial;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMaoDeObra;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.ComboBox cboAtivo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
