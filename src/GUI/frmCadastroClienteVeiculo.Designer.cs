namespace GUI
{
    partial class FrmCadastroClienteVeiculo
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
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKmVeiculo = new System.Windows.Forms.Label();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.txtKmVeiculo = new System.Windows.Forms.TextBox();
            this.txtClienteVeiculoId = new System.Windows.Forms.TextBox();
            this.txtPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.gbInfoCliente = new System.Windows.Forms.GroupBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarHistoricoCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarcaVeiculo = new System.Windows.Forms.ComboBox();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.lblAnoModelo = new System.Windows.Forms.Label();
            this.txtAnoModeloInicial = new System.Windows.Forms.TextBox();
            this.txtAnoModeloFinal = new System.Windows.Forms.TextBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gbInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.txtAnoModeloFinal);
            this.pnCadastro.Controls.Add(this.txtAnoModeloInicial);
            this.pnCadastro.Controls.Add(this.lblAnoModelo);
            this.pnCadastro.Controls.Add(this.lblAnoFabricacao);
            this.pnCadastro.Controls.Add(this.cboMarcaVeiculo);
            this.pnCadastro.Controls.Add(this.lblMarca);
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.gbInfoCliente);
            this.pnCadastro.Controls.Add(this.label3);
            this.pnCadastro.Controls.Add(this.txtPlacaVeiculo);
            this.pnCadastro.Controls.Add(this.btnBuscarHistoricoCliente);
            this.pnCadastro.Controls.Add(this.txtClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.txtKmVeiculo);
            this.pnCadastro.Controls.Add(this.txtCorVeiculo);
            this.pnCadastro.Controls.Add(this.cboVeiculo);
            this.pnCadastro.Controls.Add(this.lblKmVeiculo);
            this.pnCadastro.Controls.Add(this.label6);
            this.pnCadastro.Controls.Add(this.label5);
            this.pnCadastro.Controls.Add(this.lblVeiculo);
            this.pnCadastro.Controls.Add(this.lblClienteVeiculoId);
            this.pnCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.PnCadastro_Paint);
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
            // lblClienteVeiculoId
            // 
            this.lblClienteVeiculoId.AutoSize = true;
            this.lblClienteVeiculoId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteVeiculoId.Location = new System.Drawing.Point(17, 21);
            this.lblClienteVeiculoId.Name = "lblClienteVeiculoId";
            this.lblClienteVeiculoId.Size = new System.Drawing.Size(52, 20);
            this.lblClienteVeiculoId.TabIndex = 0;
            this.lblClienteVeiculoId.Text = "Código:";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(21, 130);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(56, 20);
            this.lblVeiculo.TabIndex = 2;
            this.lblVeiculo.Text = "Veículo: ";
            this.lblVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa do Veículo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cor do Veículo: ";
            // 
            // lblKmVeiculo
            // 
            this.lblKmVeiculo.AutoSize = true;
            this.lblKmVeiculo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmVeiculo.Location = new System.Drawing.Point(38, 178);
            this.lblKmVeiculo.Name = "lblKmVeiculo";
            this.lblKmVeiculo.Size = new System.Drawing.Size(148, 20);
            this.lblKmVeiculo.TabIndex = 6;
            this.lblKmVeiculo.Text = "Situação Odômetro: (km)";
            // 
            // cboVeiculo
            // 
            this.cboVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVeiculo.FormattingEnabled = true;
            this.cboVeiculo.Location = new System.Drawing.Point(77, 129);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(470, 21);
            this.cboVeiculo.TabIndex = 1;
            this.cboVeiculo.SelectedValueChanged += new System.EventHandler(this.CboVeiculo_SelectedValueChanged);
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Location = new System.Drawing.Point(439, 178);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(224, 20);
            this.txtCorVeiculo.TabIndex = 4;
            // 
            // txtKmVeiculo
            // 
            this.txtKmVeiculo.Location = new System.Drawing.Point(192, 178);
            this.txtKmVeiculo.Name = "txtKmVeiculo";
            this.txtKmVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtKmVeiculo.TabIndex = 3;
            // 
            // txtClienteVeiculoId
            // 
            this.txtClienteVeiculoId.Enabled = false;
            this.txtClienteVeiculoId.Location = new System.Drawing.Point(73, 22);
            this.txtClienteVeiculoId.Name = "txtClienteVeiculoId";
            this.txtClienteVeiculoId.ReadOnly = true;
            this.txtClienteVeiculoId.Size = new System.Drawing.Size(93, 20);
            this.txtClienteVeiculoId.TabIndex = 0;
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(294, 237);
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(139, 26);
            this.txtPlacaVeiculo.TabIndex = 5;
            this.txtPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbInfoCliente
            // 
            this.gbInfoCliente.Controls.Add(this.txtClienteId);
            this.gbInfoCliente.Controls.Add(this.label7);
            this.gbInfoCliente.Controls.Add(this.label2);
            this.gbInfoCliente.Controls.Add(this.txtCliente);
            this.gbInfoCliente.Controls.Add(this.label1);
            this.gbInfoCliente.Controls.Add(this.txtTelefoneCliente);
            this.gbInfoCliente.Location = new System.Drawing.Point(24, 283);
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.Size = new System.Drawing.Size(519, 109);
            this.gbInfoCliente.TabIndex = 7;
            this.gbInfoCliente.TabStop = false;
            this.gbInfoCliente.Text = "Informações do Cliente";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(32, 33);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(48, 20);
            this.txtClienteId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Id:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(206, 33);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(295, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefone:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(77, 70);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(119, 20);
            this.txtTelefoneCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar Histórico de \r\nServiços do Cliente";
            // 
            // btnBuscarHistoricoCliente
            // 
            this.btnBuscarHistoricoCliente.BackgroundImage = global::GUI.Properties.Resources.localizar1;
            this.btnBuscarHistoricoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarHistoricoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistoricoCliente.Location = new System.Drawing.Point(593, 283);
            this.btnBuscarHistoricoCliente.Name = "btnBuscarHistoricoCliente";
            this.btnBuscarHistoricoCliente.Size = new System.Drawing.Size(128, 109);
            this.btnBuscarHistoricoCliente.TabIndex = 10;
            this.btnBuscarHistoricoCliente.Text = "Localizar";
            this.btnBuscarHistoricoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarHistoricoCliente.Click += new System.EventHandler(this.BtnBuscarHistoricoCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(640, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblMarca.Location = new System.Drawing.Point(26, 83);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 20);
            this.lblMarca.TabIndex = 35;
            this.lblMarca.Text = "Marca:";
            // 
            // cboMarcaVeiculo
            // 
            this.cboMarcaVeiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMarcaVeiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMarcaVeiculo.FormattingEnabled = true;
            this.cboMarcaVeiculo.Location = new System.Drawing.Point(78, 82);
            this.cboMarcaVeiculo.Name = "cboMarcaVeiculo";
            this.cboMarcaVeiculo.Size = new System.Drawing.Size(226, 21);
            this.cboMarcaVeiculo.TabIndex = 36;
            this.cboMarcaVeiculo.SelectedValueChanged += new System.EventHandler(this.CboMarcaVeiculo_SelectedValueChanged);
            this.cboMarcaVeiculo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CboMarcaVeiculo_MouseClick);
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblAnoFabricacao.Location = new System.Drawing.Point(321, 83);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(117, 20);
            this.lblAnoFabricacao.TabIndex = 37;
            this.lblAnoFabricacao.Text = "Ano de Fabricação:";
            // 
            // lblAnoModelo
            // 
            this.lblAnoModelo.AutoSize = true;
            this.lblAnoModelo.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblAnoModelo.Location = new System.Drawing.Point(556, 83);
            this.lblAnoModelo.Name = "lblAnoModelo";
            this.lblAnoModelo.Size = new System.Drawing.Size(78, 20);
            this.lblAnoModelo.TabIndex = 39;
            this.lblAnoModelo.Text = "Ano Modelo:";
            // 
            // txtAnoModeloInicial
            // 
            this.txtAnoModeloInicial.Location = new System.Drawing.Point(438, 82);
            this.txtAnoModeloInicial.Name = "txtAnoModeloInicial";
            this.txtAnoModeloInicial.Size = new System.Drawing.Size(109, 20);
            this.txtAnoModeloInicial.TabIndex = 40;
            this.txtAnoModeloInicial.Leave += new System.EventHandler(this.TxtAnoModeloInicial_Leave);
            // 
            // txtAnoModeloFinal
            // 
            this.txtAnoModeloFinal.Location = new System.Drawing.Point(636, 82);
            this.txtAnoModeloFinal.Name = "txtAnoModeloFinal";
            this.txtAnoModeloFinal.Size = new System.Drawing.Size(100, 20);
            this.txtAnoModeloFinal.TabIndex = 41;
            this.txtAnoModeloFinal.Leave += new System.EventHandler(this.TxtAnoModeloFinal_Leave);
            // 
            // FrmCadastroClienteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FrmCadastroClienteVeiculo";
            this.Text = "Sistema de Gerenciamento Mecânica - Cadastro de Veículos de Clientes";
            this.Load += new System.EventHandler(this.FrmCadastroClienteVeiculo_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.gbInfoCliente.ResumeLayout(false);
            this.gbInfoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtClienteVeiculoId;
        private System.Windows.Forms.TextBox txtKmVeiculo;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.Label lblKmVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblClienteVeiculoId;
        private System.Windows.Forms.MaskedTextBox txtPlacaVeiculo;
        private System.Windows.Forms.GroupBox gbInfoCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnBuscarHistoricoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAnoModelo;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.ComboBox cboMarcaVeiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtAnoModeloFinal;
        private System.Windows.Forms.TextBox txtAnoModeloInicial;
    }
}
