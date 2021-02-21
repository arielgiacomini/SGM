namespace SGM.WindowsForms
{
    partial class frmCadastroVeiculo
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
            this.lblVeiculoId = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtVeiculoid = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboMarcaVeiculo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoFipe = new System.Windows.Forms.Label();
            this.txtCodigoFipe = new System.Windows.Forms.TextBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.txtCodigoFipe);
            this.pnCadastro.Controls.Add(this.lblCodigoFipe);
            this.pnCadastro.Controls.Add(this.cboMarcaVeiculo);
            this.pnCadastro.Controls.Add(this.lblMarca);
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.txtModelo);
            this.pnCadastro.Controls.Add(this.txtVeiculoid);
            this.pnCadastro.Controls.Add(this.lblModelo);
            this.pnCadastro.Controls.Add(this.lblVeiculoId);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // lblVeiculoId
            // 
            this.lblVeiculoId.AutoSize = true;
            this.lblVeiculoId.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblVeiculoId.Location = new System.Drawing.Point(24, 25);
            this.lblVeiculoId.Name = "lblVeiculoId";
            this.lblVeiculoId.Size = new System.Drawing.Size(49, 20);
            this.lblVeiculoId.TabIndex = 0;
            this.lblVeiculoId.Text = "Código";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblModelo.Location = new System.Drawing.Point(25, 127);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 20);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtVeiculoid
            // 
            this.txtVeiculoid.Enabled = false;
            this.txtVeiculoid.Location = new System.Drawing.Point(80, 25);
            this.txtVeiculoid.Name = "txtVeiculoid";
            this.txtVeiculoid.Size = new System.Drawing.Size(119, 20);
            this.txtVeiculoid.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(80, 127);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(644, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGM.WindowsForms.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(378, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // cboMarcaVeiculo
            // 
            this.cboMarcaVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMarcaVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMarcaVeiculo.FormattingEnabled = true;
            this.cboMarcaVeiculo.Location = new System.Drawing.Point(80, 74);
            this.cboMarcaVeiculo.Name = "cboMarcaVeiculo";
            this.cboMarcaVeiculo.Size = new System.Drawing.Size(455, 21);
            this.cboMarcaVeiculo.TabIndex = 36;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblMarca.Location = new System.Drawing.Point(24, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 20);
            this.lblMarca.TabIndex = 37;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodigoFipe
            // 
            this.lblCodigoFipe.AutoSize = true;
            this.lblCodigoFipe.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblCodigoFipe.Location = new System.Drawing.Point(28, 180);
            this.lblCodigoFipe.Name = "lblCodigoFipe";
            this.lblCodigoFipe.Size = new System.Drawing.Size(82, 20);
            this.lblCodigoFipe.TabIndex = 38;
            this.lblCodigoFipe.Text = "Código FIPE:";
            // 
            // txtCodigoFipe
            // 
            this.txtCodigoFipe.Location = new System.Drawing.Point(116, 180);
            this.txtCodigoFipe.Name = "txtCodigoFipe";
            this.txtCodigoFipe.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoFipe.TabIndex = 39;
            // 
            // frmCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroVeiculo";
            this.Text = "Sistema de Gerenciamento Mecânica - Cadastro de Veiculos";
            this.Load += new System.EventHandler(this.FrmCadastroVeiculo_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtVeiculoid;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblVeiculoId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMarcaVeiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCodigoFipe;
        private System.Windows.Forms.Label lblCodigoFipe;
    }
}
