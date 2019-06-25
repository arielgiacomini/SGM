namespace GUI
{
    partial class frmCadastroClienteVeiculo
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
            this.lblClienteVeiculoId = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKmVeiculo = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.txtKmVeiculo = new System.Windows.Forms.TextBox();
            this.txtClienteVeiculoId = new System.Windows.Forms.TextBox();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.txtPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.txtPlacaVeiculo);
            this.pnCadastro.Controls.Add(this.txtAnoVeiculo);
            this.pnCadastro.Controls.Add(this.txtClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.txtKmVeiculo);
            this.pnCadastro.Controls.Add(this.txtCorVeiculo);
            this.pnCadastro.Controls.Add(this.cboVeiculo);
            this.pnCadastro.Controls.Add(this.cboCliente);
            this.pnCadastro.Controls.Add(this.lblKmVeiculo);
            this.pnCadastro.Controls.Add(this.label6);
            this.pnCadastro.Controls.Add(this.label5);
            this.pnCadastro.Controls.Add(this.label4);
            this.pnCadastro.Controls.Add(this.lblVeiculo);
            this.pnCadastro.Controls.Add(this.lblCliente);
            this.pnCadastro.Controls.Add(this.lblClienteVeiculoId);
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
            // lblClienteVeiculoId
            // 
            this.lblClienteVeiculoId.AutoSize = true;
            this.lblClienteVeiculoId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteVeiculoId.Location = new System.Drawing.Point(27, 28);
            this.lblClienteVeiculoId.Name = "lblClienteVeiculoId";
            this.lblClienteVeiculoId.Size = new System.Drawing.Size(78, 25);
            this.lblClienteVeiculoId.TabIndex = 0;
            this.lblClienteVeiculoId.Text = "Código: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(28, 69);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(77, 25);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(27, 111);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(80, 25);
            this.lblVeiculo.TabIndex = 2;
            this.lblVeiculo.Text = "Veículo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano do Veículo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa do Veículo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cor do Veículo: ";
            // 
            // lblKmVeiculo
            // 
            this.lblKmVeiculo.AutoSize = true;
            this.lblKmVeiculo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmVeiculo.Location = new System.Drawing.Point(20, 218);
            this.lblKmVeiculo.Name = "lblKmVeiculo";
            this.lblKmVeiculo.Size = new System.Drawing.Size(209, 25);
            this.lblKmVeiculo.TabIndex = 6;
            this.lblKmVeiculo.Text = "Situação Odômetro: (km)";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(109, 71);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(413, 21);
            this.cboCliente.TabIndex = 1;
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(109, 113);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(413, 21);
            this.cboVeiculo.TabIndex = 2;
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Location = new System.Drawing.Point(489, 221);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(224, 20);
            this.txtCorVeiculo.TabIndex = 6;
            // 
            // txtKmVeiculo
            // 
            this.txtKmVeiculo.Location = new System.Drawing.Point(235, 221);
            this.txtKmVeiculo.Name = "txtKmVeiculo";
            this.txtKmVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtKmVeiculo.TabIndex = 5;
            // 
            // txtClienteVeiculoId
            // 
            this.txtClienteVeiculoId.Enabled = false;
            this.txtClienteVeiculoId.Location = new System.Drawing.Point(109, 32);
            this.txtClienteVeiculoId.Name = "txtClienteVeiculoId";
            this.txtClienteVeiculoId.Size = new System.Drawing.Size(132, 20);
            this.txtClienteVeiculoId.TabIndex = 0;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(167, 169);
            this.txtAnoVeiculo.MaxLength = 4;
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(60, 20);
            this.txtAnoVeiculo.TabIndex = 3;
            this.txtAnoVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(411, 170);
            this.txtPlacaVeiculo.Mask = "AAA-0000";
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(63, 20);
            this.txtPlacaVeiculo.TabIndex = 4;
            this.txtPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCadastroClienteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroClienteVeiculo";
            this.Text = "Sistema de Gerenciamento Mecânica - Cadastro de Veículos de Clientes";
            this.Load += new System.EventHandler(this.frmCadastroClienteVeiculo_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.TextBox txtClienteVeiculoId;
        private System.Windows.Forms.TextBox txtKmVeiculo;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblKmVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteVeiculoId;
        private System.Windows.Forms.MaskedTextBox txtPlacaVeiculo;
    }
}
