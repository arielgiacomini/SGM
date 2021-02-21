namespace SGM.WindowsForms
{
    partial class FrmGerarServico
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
            this.lblQtdRegistrosPecas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorMaoDeObraTexto = new System.Windows.Forms.Label();
            this.txtValorTotalMaodeObra = new System.Windows.Forms.TextBox();
            this.txtValorTotalPecas = new System.Windows.Forms.TextBox();
            this.lblQtdRegistrosMaoDeObra = new System.Windows.Forms.Label();
            this.lblInformativoMaoDeObra = new System.Windows.Forms.Label();
            this.btnAdicionarMaodeObra = new System.Windows.Forms.Button();
            this.btnAdicionarPeca = new System.Windows.Forms.Button();
            this.lblInformativoPeca = new System.Windows.Forms.Label();
            this.dgvPeca = new System.Windows.Forms.DataGridView();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.txtValorAdicional = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.lblPercentualDesconto = new System.Windows.Forms.Label();
            this.lblValorAdicional = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblClienteSelecionado = new System.Windows.Forms.Label();
            this.txtClienteSelecionado = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.txtServicoId = new System.Windows.Forms.TextBox();
            this.lblOrcamentoId = new System.Windows.Forms.Label();
            this.dgvMaodeObra = new System.Windows.Forms.DataGridView();
            this.lblServico = new System.Windows.Forms.Label();
            this.txtClienteVeiculoId = new System.Windows.Forms.TextBox();
            this.lblClienteVeiculoId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblValorPecaManual = new System.Windows.Forms.Label();
            this.lblValorMaoDeObraManual = new System.Windows.Forms.Label();
            this.txtValorMaoDeObraManual = new System.Windows.Forms.TextBox();
            this.txtValorPecaManual = new System.Windows.Forms.TextBox();
            this.grpMaoDeObraPeca = new System.Windows.Forms.GroupBox();
            this.checkInclusaoManual = new System.Windows.Forms.CheckBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMaoDeObraPeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.grpMaoDeObraPeca);
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.txtClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.lblClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.lblServico);
            this.pnCadastro.Controls.Add(this.lblQtdRegistrosPecas);
            this.pnCadastro.Controls.Add(this.lblQtdRegistrosMaoDeObra);
            this.pnCadastro.Controls.Add(this.lblInformativoMaoDeObra);
            this.pnCadastro.Controls.Add(this.btnAdicionarMaodeObra);
            this.pnCadastro.Controls.Add(this.btnAdicionarPeca);
            this.pnCadastro.Controls.Add(this.lblInformativoPeca);
            this.pnCadastro.Controls.Add(this.txtValorTotal);
            this.pnCadastro.Controls.Add(this.txtValorDesconto);
            this.pnCadastro.Controls.Add(this.txtPercentualDesconto);
            this.pnCadastro.Controls.Add(this.txtValorAdicional);
            this.pnCadastro.Controls.Add(this.lblValorTotal);
            this.pnCadastro.Controls.Add(this.lblValorDesconto);
            this.pnCadastro.Controls.Add(this.lblPercentualDesconto);
            this.pnCadastro.Controls.Add(this.lblValorAdicional);
            this.pnCadastro.Controls.Add(this.txtDescricao);
            this.pnCadastro.Controls.Add(this.lblDescricao);
            this.pnCadastro.Controls.Add(this.txtClienteId);
            this.pnCadastro.Controls.Add(this.lblClienteSelecionado);
            this.pnCadastro.Controls.Add(this.txtClienteSelecionado);
            this.pnCadastro.Controls.Add(this.dgvCliente);
            this.pnCadastro.Controls.Add(this.btnConsultaCliente);
            this.pnCadastro.Controls.Add(this.lblCliente);
            this.pnCadastro.Controls.Add(this.txtConsultaCliente);
            this.pnCadastro.Controls.Add(this.txtServicoId);
            this.pnCadastro.Controls.Add(this.lblOrcamentoId);
            this.pnCadastro.Controls.Add(this.dgvMaodeObra);
            this.pnCadastro.Controls.Add(this.dgvPeca);
            this.pnCadastro.Location = new System.Drawing.Point(3, 2);
            this.pnCadastro.Size = new System.Drawing.Size(774, 528);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 536);
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
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // lblQtdRegistrosPecas
            // 
            this.lblQtdRegistrosPecas.AutoSize = true;
            this.lblQtdRegistrosPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistrosPecas.Location = new System.Drawing.Point(318, 461);
            this.lblQtdRegistrosPecas.Name = "lblQtdRegistrosPecas";
            this.lblQtdRegistrosPecas.Size = new System.Drawing.Size(99, 12);
            this.lblQtdRegistrosPecas.TabIndex = 73;
            this.lblQtdRegistrosPecas.Text = "Quantidade Registros: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Produtos/Peças:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorMaoDeObraTexto
            // 
            this.lblValorMaoDeObraTexto.AutoSize = true;
            this.lblValorMaoDeObraTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaoDeObraTexto.Location = new System.Drawing.Point(18, 22);
            this.lblValorMaoDeObraTexto.Name = "lblValorMaoDeObraTexto";
            this.lblValorMaoDeObraTexto.Size = new System.Drawing.Size(95, 16);
            this.lblValorMaoDeObraTexto.TabIndex = 16;
            this.lblValorMaoDeObraTexto.Text = "Mão-de-Obra: ";
            this.lblValorMaoDeObraTexto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtValorTotalMaodeObra
            // 
            this.txtValorTotalMaodeObra.Enabled = false;
            this.txtValorTotalMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorTotalMaodeObra.Location = new System.Drawing.Point(114, 19);
            this.txtValorTotalMaodeObra.Name = "txtValorTotalMaodeObra";
            this.txtValorTotalMaodeObra.Size = new System.Drawing.Size(129, 26);
            this.txtValorTotalMaodeObra.TabIndex = 17;
            this.txtValorTotalMaodeObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotalMaodeObra.Enter += new System.EventHandler(this.TxtValorTotalMaodeObra_Enter);
            this.txtValorTotalMaodeObra.Leave += new System.EventHandler(this.TxtValorTotalMaodeObra_Leave);
            // 
            // txtValorTotalPecas
            // 
            this.txtValorTotalPecas.Enabled = false;
            this.txtValorTotalPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorTotalPecas.Location = new System.Drawing.Point(114, 52);
            this.txtValorTotalPecas.Name = "txtValorTotalPecas";
            this.txtValorTotalPecas.Size = new System.Drawing.Size(129, 26);
            this.txtValorTotalPecas.TabIndex = 18;
            this.txtValorTotalPecas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotalPecas.Enter += new System.EventHandler(this.TxtValorTotalPecas_Enter);
            this.txtValorTotalPecas.Leave += new System.EventHandler(this.TxtValorTotalPecas_Leave);
            // 
            // lblQtdRegistrosMaoDeObra
            // 
            this.lblQtdRegistrosMaoDeObra.AutoSize = true;
            this.lblQtdRegistrosMaoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistrosMaoDeObra.Location = new System.Drawing.Point(310, 284);
            this.lblQtdRegistrosMaoDeObra.Name = "lblQtdRegistrosMaoDeObra";
            this.lblQtdRegistrosMaoDeObra.Size = new System.Drawing.Size(99, 12);
            this.lblQtdRegistrosMaoDeObra.TabIndex = 68;
            this.lblQtdRegistrosMaoDeObra.Text = "Quantidade Registros: ";
            // 
            // lblInformativoMaoDeObra
            // 
            this.lblInformativoMaoDeObra.AutoSize = true;
            this.lblInformativoMaoDeObra.Location = new System.Drawing.Point(142, 142);
            this.lblInformativoMaoDeObra.Name = "lblInformativoMaoDeObra";
            this.lblInformativoMaoDeObra.Size = new System.Drawing.Size(290, 13);
            this.lblInformativoMaoDeObra.TabIndex = 11;
            this.lblInformativoMaoDeObra.Text = "Ao clicar no botão, selecione o registro e clique duas vezes.";
            // 
            // btnAdicionarMaodeObra
            // 
            this.btnAdicionarMaodeObra.Location = new System.Drawing.Point(14, 134);
            this.btnAdicionarMaodeObra.Name = "btnAdicionarMaodeObra";
            this.btnAdicionarMaodeObra.Size = new System.Drawing.Size(122, 28);
            this.btnAdicionarMaodeObra.TabIndex = 10;
            this.btnAdicionarMaodeObra.Text = "Lista de Mao-de-Obras";
            this.btnAdicionarMaodeObra.UseVisualStyleBackColor = true;
            this.btnAdicionarMaodeObra.Click += new System.EventHandler(this.BtnAdicionarMaodeObra_Click);
            // 
            // btnAdicionarPeca
            // 
            this.btnAdicionarPeca.Location = new System.Drawing.Point(14, 309);
            this.btnAdicionarPeca.Name = "btnAdicionarPeca";
            this.btnAdicionarPeca.Size = new System.Drawing.Size(139, 28);
            this.btnAdicionarPeca.TabIndex = 63;
            this.btnAdicionarPeca.Text = "Lista de Produtos/Peças";
            this.btnAdicionarPeca.UseVisualStyleBackColor = true;
            this.btnAdicionarPeca.Click += new System.EventHandler(this.BtnAdicionarPeca_Click);
            // 
            // lblInformativoPeca
            // 
            this.lblInformativoPeca.AutoSize = true;
            this.lblInformativoPeca.Location = new System.Drawing.Point(159, 317);
            this.lblInformativoPeca.Name = "lblInformativoPeca";
            this.lblInformativoPeca.Size = new System.Drawing.Size(290, 13);
            this.lblInformativoPeca.TabIndex = 62;
            this.lblInformativoPeca.Text = "Ao clicar no botão, selecione o registro e clique duas vezes.";
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
            this.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeca.Location = new System.Drawing.Point(14, 342);
            this.dgvPeca.Name = "dgvPeca";
            this.dgvPeca.ReadOnly = true;
            this.dgvPeca.Size = new System.Drawing.Size(500, 116);
            this.dgvPeca.TabIndex = 61;
            this.dgvPeca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeca_CellDoubleClick);
            this.dgvPeca.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvPeca_RowsAdded);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(635, 494);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(129, 29);
            this.txtValorTotal.TabIndex = 25;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Enabled = false;
            this.txtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtValorDesconto.Location = new System.Drawing.Point(635, 464);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.ReadOnly = true;
            this.txtValorDesconto.Size = new System.Drawing.Size(129, 26);
            this.txtValorDesconto.TabIndex = 24;
            this.txtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPercentualDesconto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPercentualDesconto.Location = new System.Drawing.Point(635, 433);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.Size = new System.Drawing.Size(129, 26);
            this.txtPercentualDesconto.TabIndex = 23;
            this.txtPercentualDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercentualDesconto.Enter += new System.EventHandler(this.TxtPercentualDesconto_Enter);
            this.txtPercentualDesconto.Leave += new System.EventHandler(this.TxtPercentualDesconto_Leave);
            // 
            // txtValorAdicional
            // 
            this.txtValorAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorAdicional.Location = new System.Drawing.Point(634, 400);
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(129, 26);
            this.txtValorAdicional.TabIndex = 22;
            this.txtValorAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorAdicional.Enter += new System.EventHandler(this.TxtValorAdicional_Enter);
            this.txtValorAdicional.Leave += new System.EventHandler(this.TxtValorAdicional_Leave);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(528, 497);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(101, 20);
            this.lblValorTotal.TabIndex = 34;
            this.lblValorTotal.Text = "Valor Total:";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblValorDesconto.Location = new System.Drawing.Point(529, 467);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(104, 16);
            this.lblValorDesconto.TabIndex = 33;
            this.lblValorDesconto.Text = "Valor Desconto:";
            this.lblValorDesconto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDesconto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(528, 436);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(103, 16);
            this.lblPercentualDesconto.TabIndex = 32;
            this.lblPercentualDesconto.Text = "% de Desconto:";
            this.lblPercentualDesconto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorAdicional
            // 
            this.lblValorAdicional.AutoSize = true;
            this.lblValorAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAdicional.Location = new System.Drawing.Point(527, 403);
            this.lblValorAdicional.Name = "lblValorAdicional";
            this.lblValorAdicional.Size = new System.Drawing.Size(102, 16);
            this.lblValorAdicional.TabIndex = 31;
            this.lblValorAdicional.Text = "Valor Adicional:";
            this.lblValorAdicional.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(90, 476);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(424, 49);
            this.txtDescricao.TabIndex = 26;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(11, 494);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 13);
            this.lblDescricao.TabIndex = 50;
            this.lblDescricao.Text = "Observações:";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(527, 91);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(49, 20);
            this.txtClienteId.TabIndex = 7;
            // 
            // lblClienteSelecionado
            // 
            this.lblClienteSelecionado.AutoSize = true;
            this.lblClienteSelecionado.Location = new System.Drawing.Point(5, 94);
            this.lblClienteSelecionado.Name = "lblClienteSelecionado";
            this.lblClienteSelecionado.Size = new System.Drawing.Size(104, 13);
            this.lblClienteSelecionado.TabIndex = 5;
            this.lblClienteSelecionado.Text = "Cliente Selecionado:";
            // 
            // txtClienteSelecionado
            // 
            this.txtClienteSelecionado.Enabled = false;
            this.txtClienteSelecionado.Location = new System.Drawing.Point(109, 91);
            this.txtClienteSelecionado.Name = "txtClienteSelecionado";
            this.txtClienteSelecionado.ReadOnly = true;
            this.txtClienteSelecionado.Size = new System.Drawing.Size(416, 20);
            this.txtClienteSelecionado.TabIndex = 6;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(23, 37);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(741, 44);
            this.dgvCliente.TabIndex = 4;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellDoubleClick);
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Image = global::SGM.WindowsForms.Properties.Resources.LocalicarRedimensionado3;
            this.btnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCliente.Location = new System.Drawing.Point(565, 5);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(199, 26);
            this.btnConsultaCliente.TabIndex = 3;
            this.btnConsultaCliente.Text = "Buscar Cliente";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Click += new System.EventHandler(this.BtnConsultaCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(186, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Nome, Apelido ou PLACA do Veículo:";
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(209, 9);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(350, 20);
            this.txtConsultaCliente.TabIndex = 2;
            // 
            // txtServicoId
            // 
            this.txtServicoId.Enabled = false;
            this.txtServicoId.Location = new System.Drawing.Point(699, 117);
            this.txtServicoId.Name = "txtServicoId";
            this.txtServicoId.ReadOnly = true;
            this.txtServicoId.Size = new System.Drawing.Size(64, 20);
            this.txtServicoId.TabIndex = 13;
            // 
            // lblOrcamentoId
            // 
            this.lblOrcamentoId.AutoSize = true;
            this.lblOrcamentoId.Location = new System.Drawing.Point(596, 120);
            this.lblOrcamentoId.Name = "lblOrcamentoId";
            this.lblOrcamentoId.Size = new System.Drawing.Size(97, 13);
            this.lblOrcamentoId.TabIndex = 12;
            this.lblOrcamentoId.Text = "Código do Serviço:";
            // 
            // dgvMaodeObra
            // 
            this.dgvMaodeObra.AllowUserToAddRows = false;
            this.dgvMaodeObra.AllowUserToDeleteRows = false;
            this.dgvMaodeObra.AllowUserToResizeColumns = false;
            this.dgvMaodeObra.AllowUserToResizeRows = false;
            this.dgvMaodeObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaodeObra.Location = new System.Drawing.Point(14, 166);
            this.dgvMaodeObra.Name = "dgvMaodeObra";
            this.dgvMaodeObra.ReadOnly = true;
            this.dgvMaodeObra.Size = new System.Drawing.Size(500, 116);
            this.dgvMaodeObra.TabIndex = 14;
            this.dgvMaodeObra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaodeObra_CellDoubleClick);
            this.dgvMaodeObra.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvMaodeObra_RowsAdded);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(593, 142);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(135, 68);
            this.lblServico.TabIndex = 42;
            this.lblServico.Text = "ORDEM DE \r\nSERVIÇO";
            this.lblServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClienteVeiculoId
            // 
            this.txtClienteVeiculoId.Enabled = false;
            this.txtClienteVeiculoId.Location = new System.Drawing.Point(724, 91);
            this.txtClienteVeiculoId.Name = "txtClienteVeiculoId";
            this.txtClienteVeiculoId.ReadOnly = true;
            this.txtClienteVeiculoId.Size = new System.Drawing.Size(39, 20);
            this.txtClienteVeiculoId.TabIndex = 9;
            // 
            // lblClienteVeiculoId
            // 
            this.lblClienteVeiculoId.AutoSize = true;
            this.lblClienteVeiculoId.Location = new System.Drawing.Point(576, 94);
            this.lblClienteVeiculoId.Name = "lblClienteVeiculoId";
            this.lblClienteVeiculoId.Size = new System.Drawing.Size(149, 13);
            this.lblClienteVeiculoId.TabIndex = 8;
            this.lblClienteVeiculoId.Text = "Código do Veiculo do Cliente: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGM.WindowsForms.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(490, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // lblValorPecaManual
            // 
            this.lblValorPecaManual.AutoSize = true;
            this.lblValorPecaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPecaManual.Location = new System.Drawing.Point(4, 152);
            this.lblValorPecaManual.Name = "lblValorPecaManual";
            this.lblValorPecaManual.Size = new System.Drawing.Size(108, 16);
            this.lblValorPecaManual.TabIndex = 30;
            this.lblValorPecaManual.Text = "Produtos/Peças:";
            this.lblValorPecaManual.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblValorPecaManual.Visible = false;
            // 
            // lblValorMaoDeObraManual
            // 
            this.lblValorMaoDeObraManual.AutoSize = true;
            this.lblValorMaoDeObraManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaoDeObraManual.Location = new System.Drawing.Point(18, 121);
            this.lblValorMaoDeObraManual.Name = "lblValorMaoDeObraManual";
            this.lblValorMaoDeObraManual.Size = new System.Drawing.Size(95, 16);
            this.lblValorMaoDeObraManual.TabIndex = 29;
            this.lblValorMaoDeObraManual.Text = "Mão-de-Obra: ";
            this.lblValorMaoDeObraManual.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblValorMaoDeObraManual.Visible = false;
            // 
            // txtValorMaoDeObraManual
            // 
            this.txtValorMaoDeObraManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorMaoDeObraManual.Location = new System.Drawing.Point(114, 118);
            this.txtValorMaoDeObraManual.Name = "txtValorMaoDeObraManual";
            this.txtValorMaoDeObraManual.Size = new System.Drawing.Size(129, 26);
            this.txtValorMaoDeObraManual.TabIndex = 20;
            this.txtValorMaoDeObraManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorMaoDeObraManual.Visible = false;
            this.txtValorMaoDeObraManual.Enter += new System.EventHandler(this.TxtValorMaoDeObraManual_Enter);
            this.txtValorMaoDeObraManual.Leave += new System.EventHandler(this.TxtValorMaoDeObraManual_Leave);
            // 
            // txtValorPecaManual
            // 
            this.txtValorPecaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorPecaManual.Location = new System.Drawing.Point(114, 149);
            this.txtValorPecaManual.Name = "txtValorPecaManual";
            this.txtValorPecaManual.Size = new System.Drawing.Size(129, 26);
            this.txtValorPecaManual.TabIndex = 21;
            this.txtValorPecaManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPecaManual.Visible = false;
            this.txtValorPecaManual.Enter += new System.EventHandler(this.TxtValorPecaManual_Enter);
            this.txtValorPecaManual.Leave += new System.EventHandler(this.TxtValorPecaManual_Leave);
            // 
            // grpMaoDeObraPeca
            // 
            this.grpMaoDeObraPeca.Controls.Add(this.checkInclusaoManual);
            this.grpMaoDeObraPeca.Controls.Add(this.lblValorMaoDeObraTexto);
            this.grpMaoDeObraPeca.Controls.Add(this.lblValorPecaManual);
            this.grpMaoDeObraPeca.Controls.Add(this.txtValorTotalPecas);
            this.grpMaoDeObraPeca.Controls.Add(this.lblValorMaoDeObraManual);
            this.grpMaoDeObraPeca.Controls.Add(this.txtValorTotalMaodeObra);
            this.grpMaoDeObraPeca.Controls.Add(this.txtValorMaoDeObraManual);
            this.grpMaoDeObraPeca.Controls.Add(this.label2);
            this.grpMaoDeObraPeca.Controls.Add(this.txtValorPecaManual);
            this.grpMaoDeObraPeca.Location = new System.Drawing.Point(520, 213);
            this.grpMaoDeObraPeca.Name = "grpMaoDeObraPeca";
            this.grpMaoDeObraPeca.Size = new System.Drawing.Size(251, 181);
            this.grpMaoDeObraPeca.TabIndex = 15;
            this.grpMaoDeObraPeca.TabStop = false;
            this.grpMaoDeObraPeca.Text = "Mão de Obra/Peça";
            // 
            // checkInclusaoManual
            // 
            this.checkInclusaoManual.AutoSize = true;
            this.checkInclusaoManual.Location = new System.Drawing.Point(57, 89);
            this.checkInclusaoManual.Name = "checkInclusaoManual";
            this.checkInclusaoManual.Size = new System.Drawing.Size(134, 17);
            this.checkInclusaoManual.TabIndex = 19;
            this.checkInclusaoManual.Text = "Deseja Incluir Manual?";
            this.checkInclusaoManual.UseVisualStyleBackColor = true;
            this.checkInclusaoManual.CheckedChanged += new System.EventHandler(this.checkInclusaoManual_CheckedChanged_1);
            // 
            // FrmGerarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 651);
            this.Name = "FrmGerarServico";
            this.Text = "Sistema de Gerenciamento Mecânica - Efetuar Serviço";
            this.Load += new System.EventHandler(this.FrmGerarServico_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMaoDeObraPeca.ResumeLayout(false);
            this.grpMaoDeObraPeca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQtdRegistrosPecas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorMaoDeObraTexto;
        private System.Windows.Forms.TextBox txtValorTotalMaodeObra;
        private System.Windows.Forms.TextBox txtValorTotalPecas;
        private System.Windows.Forms.Label lblQtdRegistrosMaoDeObra;
        private System.Windows.Forms.Label lblInformativoMaoDeObra;
        private System.Windows.Forms.Button btnAdicionarMaodeObra;
        private System.Windows.Forms.Button btnAdicionarPeca;
        private System.Windows.Forms.Label lblInformativoPeca;
        private System.Windows.Forms.DataGridView dgvPeca;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.TextBox txtPercentualDesconto;
        private System.Windows.Forms.TextBox txtValorAdicional;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.Label lblPercentualDesconto;
        private System.Windows.Forms.Label lblValorAdicional;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label lblClienteSelecionado;
        private System.Windows.Forms.TextBox txtClienteSelecionado;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.TextBox txtServicoId;
        private System.Windows.Forms.Label lblOrcamentoId;
        private System.Windows.Forms.DataGridView dgvMaodeObra;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TextBox txtClienteVeiculoId;
        private System.Windows.Forms.Label lblClienteVeiculoId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpMaoDeObraPeca;
        private System.Windows.Forms.Label lblValorPecaManual;
        private System.Windows.Forms.Label lblValorMaoDeObraManual;
        private System.Windows.Forms.TextBox txtValorMaoDeObraManual;
        private System.Windows.Forms.TextBox txtValorPecaManual;
        private System.Windows.Forms.CheckBox checkInclusaoManual;
    }
}
