namespace SGM.WindowsForms
{
    partial class FrmCadastroCliente
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
            this.lblClienteId = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefoneFixo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefoneOutros = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.gbLogradouro = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneOutros = new System.Windows.Forms.MaskedTextBox();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbControleDatas = new System.Windows.Forms.GroupBox();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.lblDataAlteracao = new System.Windows.Forms.Label();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gbLogradouro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbControleDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.gbControleDatas);
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.txtTelefoneOutros);
            this.pnCadastro.Controls.Add(this.txtCelular);
            this.pnCadastro.Controls.Add(this.txtTelefoneFixo);
            this.pnCadastro.Controls.Add(this.txtEmail);
            this.pnCadastro.Controls.Add(this.dtpDataNascimento);
            this.pnCadastro.Controls.Add(this.cboEstadoCivil);
            this.pnCadastro.Controls.Add(this.cboSexo);
            this.pnCadastro.Controls.Add(this.txtCPF);
            this.pnCadastro.Controls.Add(this.txtApelido);
            this.pnCadastro.Controls.Add(this.txtCliente);
            this.pnCadastro.Controls.Add(this.txtClienteId);
            this.pnCadastro.Controls.Add(this.gbLogradouro);
            this.pnCadastro.Controls.Add(this.lblClienteId);
            this.pnCadastro.Controls.Add(this.lblCliente);
            this.pnCadastro.Controls.Add(this.lblApelido);
            this.pnCadastro.Controls.Add(this.lblCPF);
            this.pnCadastro.Controls.Add(this.lblSexo);
            this.pnCadastro.Controls.Add(this.lblDataNascimento);
            this.pnCadastro.Controls.Add(this.lblEstadoCivil);
            this.pnCadastro.Controls.Add(this.lblTelefoneOutros);
            this.pnCadastro.Controls.Add(this.lblEmail);
            this.pnCadastro.Controls.Add(this.lblCelular);
            this.pnCadastro.Controls.Add(this.lblTelefoneFixo);
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.TabIndex = 41;
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 45;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.TabIndex = 42;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.TabIndex = 40;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Location = new System.Drawing.Point(26, 21);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(46, 13);
            this.lblClienteId.TabIndex = 2;
            this.lblClienteId.Text = "Código: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 49);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente: ";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(25, 77);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(48, 13);
            this.lblApelido.TabIndex = 4;
            this.lblApelido.Text = "Apelido: ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(33, 106);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF: ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(31, 135);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(37, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo: ";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(13, 167);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(68, 13);
            this.lblEstadoCivil.TabIndex = 7;
            this.lblEstadoCivil.Text = "Estado Civil: ";
            this.lblEstadoCivil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(15, 192);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(69, 26);
            this.lblDataNascimento.TabIndex = 8;
            this.lblDataNascimento.Text = "Data \r\nNascimento: ";
            this.lblDataNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblTelefoneFixo
            // 
            this.lblTelefoneFixo.AutoSize = true;
            this.lblTelefoneFixo.Location = new System.Drawing.Point(11, 270);
            this.lblTelefoneFixo.Name = "lblTelefoneFixo";
            this.lblTelefoneFixo.Size = new System.Drawing.Size(77, 13);
            this.lblTelefoneFixo.TabIndex = 10;
            this.lblTelefoneFixo.Text = "Telefone Fixo: ";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(21, 301);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(45, 13);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular: ";
            // 
            // lblTelefoneOutros
            // 
            this.lblTelefoneOutros.AutoSize = true;
            this.lblTelefoneOutros.Location = new System.Drawing.Point(21, 328);
            this.lblTelefoneOutros.Name = "lblTelefoneOutros";
            this.lblTelefoneOutros.Size = new System.Drawing.Size(52, 26);
            this.lblTelefoneOutros.TabIndex = 12;
            this.lblTelefoneOutros.Text = "Telefone \r\nOutros: ";
            this.lblTelefoneOutros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(27, 52);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(34, 13);
            this.lblCEP.TabIndex = 13;
            this.lblCEP.Text = "CEP: ";
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(16, 82);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(59, 13);
            this.lblEndereço.TabIndex = 14;
            this.lblEndereço.Text = "Endereço: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(18, 112);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Número: ";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 144);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "Complemento: ";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(21, 202);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(46, 13);
            this.lblMunicipio.TabIndex = 17;
            this.lblMunicipio.Text = "Cidade: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(21, 174);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 13);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro: ";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(34, 229);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(27, 13);
            this.lblUF.TabIndex = 19;
            this.lblUF.Text = "UF: ";
            // 
            // gbLogradouro
            // 
            this.gbLogradouro.Controls.Add(this.txtUF);
            this.gbLogradouro.Controls.Add(this.txtBairro);
            this.gbLogradouro.Controls.Add(this.txtCidade);
            this.gbLogradouro.Controls.Add(this.txtComplemento);
            this.gbLogradouro.Controls.Add(this.txtNumero);
            this.gbLogradouro.Controls.Add(this.txtEndereco);
            this.gbLogradouro.Controls.Add(this.txtCEP);
            this.gbLogradouro.Controls.Add(this.lblEndereço);
            this.gbLogradouro.Controls.Add(this.lblUF);
            this.gbLogradouro.Controls.Add(this.lblNumero);
            this.gbLogradouro.Controls.Add(this.lblComplemento);
            this.gbLogradouro.Controls.Add(this.lblMunicipio);
            this.gbLogradouro.Controls.Add(this.lblBairro);
            this.gbLogradouro.Controls.Add(this.lblCEP);
            this.gbLogradouro.Location = new System.Drawing.Point(364, 117);
            this.gbLogradouro.Name = "gbLogradouro";
            this.gbLogradouro.Size = new System.Drawing.Size(399, 263);
            this.gbLogradouro.TabIndex = 32;
            this.gbLogradouro.TabStop = false;
            this.gbLogradouro.Text = "Endereço";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(87, 226);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(37, 20);
            this.txtUF.TabIndex = 39;
            this.txtUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(87, 171);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(306, 20);
            this.txtBairro.TabIndex = 37;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(87, 199);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(306, 20);
            this.txtCidade.TabIndex = 38;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(87, 141);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(306, 20);
            this.txtComplemento.TabIndex = 36;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(87, 109);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 20);
            this.txtNumero.TabIndex = 35;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(87, 79);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(306, 20);
            this.txtEndereco.TabIndex = 34;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(87, 49);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(63, 20);
            this.txtCEP.TabIndex = 33;
            this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCEP.Enter += new System.EventHandler(this.TxtCEP_Enter);
            this.txtCEP.Leave += new System.EventHandler(this.TxtCEP_Leave);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(87, 18);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(137, 20);
            this.txtClienteId.TabIndex = 21;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(87, 46);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(535, 20);
            this.txtCliente.TabIndex = 22;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(87, 74);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(321, 20);
            this.txtApelido.TabIndex = 23;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(87, 103);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(90, 20);
            this.txtCPF.TabIndex = 24;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.Enter += new System.EventHandler(this.TxtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.TxtCPF_Leave);
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Indefinido",
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(87, 132);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(121, 21);
            this.cboSexo.TabIndex = 25;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "Indefinido",
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "União Estável"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(87, 164);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoCivil.TabIndex = 26;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.Location = new System.Drawing.Point(87, 198);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(97, 20);
            this.dtpDataNascimento.TabIndex = 27;
            this.dtpDataNascimento.Enter += new System.EventHandler(this.DtpDataNascimento_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Location = new System.Drawing.Point(87, 267);
            this.txtTelefoneFixo.Mask = "(00) 0000-0000";
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(90, 20);
            this.txtTelefoneFixo.TabIndex = 29;
            this.txtTelefoneFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(87, 298);
            this.txtCelular.Mask = "(00) 0,0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 20);
            this.txtCelular.TabIndex = 30;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefoneOutros
            // 
            this.txtTelefoneOutros.Location = new System.Drawing.Point(87, 328);
            this.txtTelefoneOutros.Mask = "(00) 000000000";
            this.txtTelefoneOutros.Name = "txtTelefoneOutros";
            this.txtTelefoneOutros.Size = new System.Drawing.Size(97, 20);
            this.txtTelefoneOutros.TabIndex = 31;
            this.txtTelefoneOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(99, 19);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.ReadOnly = true;
            this.txtDataCadastro.Size = new System.Drawing.Size(115, 20);
            this.txtDataCadastro.TabIndex = 34;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Enabled = false;
            this.lblDataCadastro.Location = new System.Drawing.Point(5, 22);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(93, 13);
            this.lblDataCadastro.TabIndex = 35;
            this.lblDataCadastro.Text = "Data de Cadastro:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGM.WindowsForms.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(628, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // gbControleDatas
            // 
            this.gbControleDatas.Controls.Add(this.txtDataAlteracao);
            this.gbControleDatas.Controls.Add(this.lblDataAlteracao);
            this.gbControleDatas.Controls.Add(this.txtDataCadastro);
            this.gbControleDatas.Controls.Add(this.lblDataCadastro);
            this.gbControleDatas.Location = new System.Drawing.Point(9, 379);
            this.gbControleDatas.Name = "gbControleDatas";
            this.gbControleDatas.Size = new System.Drawing.Size(444, 46);
            this.gbControleDatas.TabIndex = 37;
            this.gbControleDatas.TabStop = false;
            this.gbControleDatas.Text = "Controle de Datas";
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Location = new System.Drawing.Point(319, 18);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.ReadOnly = true;
            this.txtDataAlteracao.Size = new System.Drawing.Size(115, 20);
            this.txtDataAlteracao.TabIndex = 37;
            // 
            // lblDataAlteracao
            // 
            this.lblDataAlteracao.AutoSize = true;
            this.lblDataAlteracao.Location = new System.Drawing.Point(217, 22);
            this.lblDataAlteracao.Name = "lblDataAlteracao";
            this.lblDataAlteracao.Size = new System.Drawing.Size(96, 13);
            this.lblDataAlteracao.TabIndex = 36;
            this.lblDataAlteracao.Text = "Data de Alteração:";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FrmCadastroCliente";
            this.Text = "Sistema de Gerenciamento Mecânica - Cadastro de Clientes";
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.gbLogradouro.ResumeLayout(false);
            this.gbLogradouro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbControleDatas.ResumeLayout(false);
            this.gbControleDatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefoneOutros;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.GroupBox gbLogradouro;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblTelefoneOutros;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefoneFixo;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtDataCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbControleDatas;
        private System.Windows.Forms.Label lblDataAlteracao;
        private System.Windows.Forms.TextBox txtDataAlteracao;
    }
}
