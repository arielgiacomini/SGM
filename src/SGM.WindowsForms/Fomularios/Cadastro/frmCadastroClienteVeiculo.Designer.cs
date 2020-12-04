namespace SGM.WindowsForms
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
            this.lblPlacaVeiculo = new System.Windows.Forms.Label();
            this.lblCorVeiculo = new System.Windows.Forms.Label();
            this.lblKmVeiculo = new System.Windows.Forms.Label();
            this.cboVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.txtKmVeiculo = new System.Windows.Forms.TextBox();
            this.txtClienteVeiculoId = new System.Windows.Forms.TextBox();
            this.txtPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.gbInfoCliente = new System.Windows.Forms.GroupBox();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.lblBuscarHistoricoServicoCliente = new System.Windows.Forms.Label();
            this.btnBuscarHistoricoCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarcaVeiculo = new System.Windows.Forms.ComboBox();
            this.lblAnoModelo = new System.Windows.Forms.Label();
            this.txtAnoModeloVeiculo = new System.Windows.Forms.TextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.grbBoxDatas = new System.Windows.Forms.GroupBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gbInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbBoxDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.checkBoxAtivo);
            this.pnCadastro.Controls.Add(this.txtAnoModeloVeiculo);
            this.pnCadastro.Controls.Add(this.lblAnoModelo);
            this.pnCadastro.Controls.Add(this.cboMarcaVeiculo);
            this.pnCadastro.Controls.Add(this.lblMarca);
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.lblBuscarHistoricoServicoCliente);
            this.pnCadastro.Controls.Add(this.btnBuscarHistoricoCliente);
            this.pnCadastro.Controls.Add(this.gbInfoCliente);
            this.pnCadastro.Controls.Add(this.txtPlacaVeiculo);
            this.pnCadastro.Controls.Add(this.txtClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.txtKmVeiculo);
            this.pnCadastro.Controls.Add(this.txtCorVeiculo);
            this.pnCadastro.Controls.Add(this.cboVeiculo);
            this.pnCadastro.Controls.Add(this.lblKmVeiculo);
            this.pnCadastro.Controls.Add(this.lblCorVeiculo);
            this.pnCadastro.Controls.Add(this.lblPlacaVeiculo);
            this.pnCadastro.Controls.Add(this.lblVeiculo);
            this.pnCadastro.Controls.Add(this.lblClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.grbBoxDatas);
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
            this.btnSalvar.TabIndex = 7;
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
            this.lblVeiculo.Location = new System.Drawing.Point(16, 228);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(56, 20);
            this.lblVeiculo.TabIndex = 2;
            this.lblVeiculo.Text = "Veículo: ";
            this.lblVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlacaVeiculo
            // 
            this.lblPlacaVeiculo.AutoSize = true;
            this.lblPlacaVeiculo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaVeiculo.Location = new System.Drawing.Point(106, 338);
            this.lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            this.lblPlacaVeiculo.Size = new System.Drawing.Size(119, 20);
            this.lblPlacaVeiculo.TabIndex = 4;
            this.lblPlacaVeiculo.Text = "Placa do Veículo: ";
            // 
            // lblCorVeiculo
            // 
            this.lblCorVeiculo.AutoSize = true;
            this.lblCorVeiculo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorVeiculo.Location = new System.Drawing.Point(332, 276);
            this.lblCorVeiculo.Name = "lblCorVeiculo";
            this.lblCorVeiculo.Size = new System.Drawing.Size(96, 20);
            this.lblCorVeiculo.TabIndex = 5;
            this.lblCorVeiculo.Text = "Cor do Veículo: ";
            // 
            // lblKmVeiculo
            // 
            this.lblKmVeiculo.AutoSize = true;
            this.lblKmVeiculo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmVeiculo.Location = new System.Drawing.Point(33, 276);
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
            this.cboVeiculo.Location = new System.Drawing.Point(72, 227);
            this.cboVeiculo.Name = "cboVeiculo";
            this.cboVeiculo.Size = new System.Drawing.Size(470, 21);
            this.cboVeiculo.TabIndex = 3;
            this.cboVeiculo.Leave += new System.EventHandler(this.CboVeiculo_Leave);
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Location = new System.Drawing.Point(434, 276);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(224, 20);
            this.txtCorVeiculo.TabIndex = 5;
            // 
            // txtKmVeiculo
            // 
            this.txtKmVeiculo.Location = new System.Drawing.Point(187, 276);
            this.txtKmVeiculo.Name = "txtKmVeiculo";
            this.txtKmVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtKmVeiculo.TabIndex = 4;
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
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(231, 335);
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(139, 26);
            this.txtPlacaVeiculo.TabIndex = 6;
            this.txtPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbInfoCliente
            // 
            this.gbInfoCliente.Controls.Add(this.btnConsultaCliente);
            this.gbInfoCliente.Controls.Add(this.txtClienteId);
            this.gbInfoCliente.Controls.Add(this.lblClienteId);
            this.gbInfoCliente.Controls.Add(this.lblNomeCliente);
            this.gbInfoCliente.Controls.Add(this.txtCliente);
            this.gbInfoCliente.Controls.Add(this.lblTelefone);
            this.gbInfoCliente.Controls.Add(this.txtTelefoneCliente);
            this.gbInfoCliente.Location = new System.Drawing.Point(23, 57);
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.Size = new System.Drawing.Size(729, 109);
            this.gbInfoCliente.TabIndex = 7;
            this.gbInfoCliente.TabStop = false;
            this.gbInfoCliente.Text = "Informações do Cliente";
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.BackgroundImage = global::GUI.Properties.Resources.localizar1;
            this.btnConsultaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultaCliente.Enabled = false;
            this.btnConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCliente.ForeColor = System.Drawing.Color.Red;
            this.btnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnConsultaCliente.Location = new System.Drawing.Point(638, 15);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(85, 88);
            this.btnConsultaCliente.TabIndex = 46;
            this.btnConsultaCliente.Text = "Busca Cliente";
            this.btnConsultaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(32, 33);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(48, 20);
            this.txtClienteId.TabIndex = 9;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(6, 33);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(24, 20);
            this.lblClienteId.TabIndex = 8;
            this.lblClienteId.Text = "Id:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(86, 33);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(114, 20);
            this.lblNomeCliente.TabIndex = 6;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(206, 33);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(295, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(6, 70);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 20);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(77, 70);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(119, 20);
            this.txtTelefoneCliente.TabIndex = 2;
            // 
            // lblBuscarHistoricoServicoCliente
            // 
            this.lblBuscarHistoricoServicoCliente.AutoSize = true;
            this.lblBuscarHistoricoServicoCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarHistoricoServicoCliente.Location = new System.Drawing.Point(504, 352);
            this.lblBuscarHistoricoServicoCliente.Name = "lblBuscarHistoricoServicoCliente";
            this.lblBuscarHistoricoServicoCliente.Size = new System.Drawing.Size(130, 40);
            this.lblBuscarHistoricoServicoCliente.TabIndex = 7;
            this.lblBuscarHistoricoServicoCliente.Text = "Buscar Histórico de \r\nServiços do Cliente";
            // 
            // btnBuscarHistoricoCliente
            // 
            this.btnBuscarHistoricoCliente.BackgroundImage = global::GUI.Properties.Resources.localizar1;
            this.btnBuscarHistoricoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscarHistoricoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHistoricoCliente.Location = new System.Drawing.Point(640, 324);
            this.btnBuscarHistoricoCliente.Name = "btnBuscarHistoricoCliente";
            this.btnBuscarHistoricoCliente.Size = new System.Drawing.Size(96, 90);
            this.btnBuscarHistoricoCliente.TabIndex = 10;
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
            this.lblMarca.Location = new System.Drawing.Point(21, 181);
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
            this.cboMarcaVeiculo.Location = new System.Drawing.Point(73, 180);
            this.cboMarcaVeiculo.Name = "cboMarcaVeiculo";
            this.cboMarcaVeiculo.Size = new System.Drawing.Size(297, 21);
            this.cboMarcaVeiculo.TabIndex = 1;
            this.cboMarcaVeiculo.SelectedValueChanged += new System.EventHandler(this.ComboBoxMarcaVeiculoAlteracaoValor);
            // 
            // lblAnoModelo
            // 
            this.lblAnoModelo.AutoSize = true;
            this.lblAnoModelo.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblAnoModelo.Location = new System.Drawing.Point(402, 181);
            this.lblAnoModelo.Name = "lblAnoModelo";
            this.lblAnoModelo.Size = new System.Drawing.Size(78, 20);
            this.lblAnoModelo.TabIndex = 39;
            this.lblAnoModelo.Text = "Ano Modelo:";
            // 
            // txtAnoModeloVeiculo
            // 
            this.txtAnoModeloVeiculo.Location = new System.Drawing.Point(482, 180);
            this.txtAnoModeloVeiculo.Name = "txtAnoModeloVeiculo";
            this.txtAnoModeloVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtAnoModeloVeiculo.TabIndex = 2;
            this.txtAnoModeloVeiculo.Leave += new System.EventHandler(this.TextBoxAnoModeloSaidaCampo);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.Location = new System.Drawing.Point(620, 198);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(104, 24);
            this.checkBoxAtivo.TabIndex = 40;
            this.checkBoxAtivo.Text = "Veiculo Ativo?";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Location = new System.Drawing.Point(93, 19);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(125, 20);
            this.txtDataCadastro.TabIndex = 41;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(11, 22);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(81, 13);
            this.lblDataCadastro.TabIndex = 42;
            this.lblDataCadastro.Text = "Data Cadastro: ";
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(227, 22);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(84, 13);
            this.lblDataAlteracao.TabIndex = 43;
            this.lblDataAlteracao.Text = "Data Alteração: ";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(312, 19);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(115, 20);
            this.txtDataAlteracao.TabIndex = 44;
            // 
            // grbBoxDatas
            // 
            this.grbBoxDatas.Controls.Add(this.lblDataCadastro);
            this.grbBoxDatas.Controls.Add(this.txtDataAlteracao);
            this.grbBoxDatas.Controls.Add(this.txtDataCadastro);
            this.grbBoxDatas.Controls.Add(this.lblDataAlteracao);
            this.grbBoxDatas.Enabled = false;
            this.grbBoxDatas.Location = new System.Drawing.Point(9, 379);
            this.grbBoxDatas.Name = "grbBoxDatas";
            this.grbBoxDatas.Size = new System.Drawing.Size(444, 46);
            this.grbBoxDatas.TabIndex = 45;
            this.grbBoxDatas.TabStop = false;
            this.grbBoxDatas.Text = "Controle Datas";
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
            this.grbBoxDatas.ResumeLayout(false);
            this.grbBoxDatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtClienteVeiculoId;
        private System.Windows.Forms.TextBox txtKmVeiculo;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.ComboBox cboVeiculo;
        private System.Windows.Forms.Label lblKmVeiculo;
        private System.Windows.Forms.Label lblCorVeiculo;
        private System.Windows.Forms.Label lblPlacaVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblClienteVeiculoId;
        private System.Windows.Forms.MaskedTextBox txtPlacaVeiculo;
        private System.Windows.Forms.GroupBox gbInfoCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label lblBuscarHistoricoServicoCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        protected System.Windows.Forms.Button btnBuscarHistoricoCliente;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAnoModelo;
        private System.Windows.Forms.ComboBox cboMarcaVeiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtAnoModeloVeiculo;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.GroupBox grbBoxDatas;
        protected System.Windows.Forms.Button btnConsultaCliente;
    }
}
