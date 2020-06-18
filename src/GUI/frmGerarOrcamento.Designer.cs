using System.Windows.Forms;

namespace GUI
{
    partial class frmGerarOrcamento
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
            this.lblOrcamentoId = new System.Windows.Forms.Label();
            this.txtOrcamentoId = new System.Windows.Forms.TextBox();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtClienteSelecionado = new System.Windows.Forms.TextBox();
            this.lblClienteSelecionado = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValorAdicional = new System.Windows.Forms.Label();
            this.lblPercentualDesconto = new System.Windows.Forms.Label();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorAdicional = new System.Windows.Forms.TextBox();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dgvMaodeObra = new System.Windows.Forms.DataGridView();
            this.dgvPeca = new System.Windows.Forms.DataGridView();
            this.lblInformativoPeca = new System.Windows.Forms.Label();
            this.btnAdicionarPeca = new System.Windows.Forms.Button();
            this.btnAdicionarMaodeObra = new System.Windows.Forms.Button();
            this.lblInformativoMaoDeObra = new System.Windows.Forms.Label();
            this.dgvOcultoGuardaInformacao = new System.Windows.Forms.DataGridView();
            this.dgvOcultoInformacaoPecas = new System.Windows.Forms.DataGridView();
            this.lblQtdRegistrosMaoDeObra = new System.Windows.Forms.Label();
            this.txtValorTotalPecas = new System.Windows.Forms.TextBox();
            this.txtValorTotalMaodeObra = new System.Windows.Forms.TextBox();
            this.lblValorMaoDeObraTexto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdRegistrosPecas = new System.Windows.Forms.Label();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcultoGuardaInformacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcultoInformacaoPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.lblOrcamento);
            this.pnCadastro.Controls.Add(this.lblQtdRegistrosPecas);
            this.pnCadastro.Controls.Add(this.label2);
            this.pnCadastro.Controls.Add(this.lblValorMaoDeObraTexto);
            this.pnCadastro.Controls.Add(this.txtValorTotalMaodeObra);
            this.pnCadastro.Controls.Add(this.txtValorTotalPecas);
            this.pnCadastro.Controls.Add(this.lblQtdRegistrosMaoDeObra);
            this.pnCadastro.Controls.Add(this.lblInformativoMaoDeObra);
            this.pnCadastro.Controls.Add(this.btnAdicionarMaodeObra);
            this.pnCadastro.Controls.Add(this.btnAdicionarPeca);
            this.pnCadastro.Controls.Add(this.lblInformativoPeca);
            this.pnCadastro.Controls.Add(this.dgvPeca);
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
            this.pnCadastro.Controls.Add(this.txtOrcamentoId);
            this.pnCadastro.Controls.Add(this.lblOrcamentoId);
            this.pnCadastro.Controls.Add(this.dgvOcultoInformacaoPecas);
            this.pnCadastro.Controls.Add(this.dgvMaodeObra);
            this.pnCadastro.Controls.Add(this.dgvOcultoGuardaInformacao);
            this.pnCadastro.Location = new System.Drawing.Point(3, 2);
            this.pnCadastro.Size = new System.Drawing.Size(774, 528);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 536);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblOrcamentoId
            // 
            this.lblOrcamentoId.AutoSize = true;
            this.lblOrcamentoId.Location = new System.Drawing.Point(608, 503);
            this.lblOrcamentoId.Name = "lblOrcamentoId";
            this.lblOrcamentoId.Size = new System.Drawing.Size(46, 13);
            this.lblOrcamentoId.TabIndex = 0;
            this.lblOrcamentoId.Text = "Código: ";
            // 
            // txtOrcamentoId
            // 
            this.txtOrcamentoId.Enabled = false;
            this.txtOrcamentoId.Location = new System.Drawing.Point(651, 500);
            this.txtOrcamentoId.Name = "txtOrcamentoId";
            this.txtOrcamentoId.Size = new System.Drawing.Size(112, 20);
            this.txtOrcamentoId.TabIndex = 1;
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(208, 15);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(350, 20);
            this.txtConsultaCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(183, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Digite o Nome ou Apelido do Cliente: ";
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCliente.Location = new System.Drawing.Point(564, 11);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(199, 26);
            this.btnConsultaCliente.TabIndex = 7;
            this.btnConsultaCliente.Text = "Buscar Cliente";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Click += new System.EventHandler(this.BtnConsultaCliente_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(22, 43);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(741, 44);
            this.dgvCliente.TabIndex = 8;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // txtClienteSelecionado
            // 
            this.txtClienteSelecionado.Enabled = false;
            this.txtClienteSelecionado.Location = new System.Drawing.Point(123, 97);
            this.txtClienteSelecionado.Name = "txtClienteSelecionado";
            this.txtClienteSelecionado.Size = new System.Drawing.Size(539, 20);
            this.txtClienteSelecionado.TabIndex = 9;
            // 
            // lblClienteSelecionado
            // 
            this.lblClienteSelecionado.AutoSize = true;
            this.lblClienteSelecionado.Location = new System.Drawing.Point(19, 100);
            this.lblClienteSelecionado.Name = "lblClienteSelecionado";
            this.lblClienteSelecionado.Size = new System.Drawing.Size(104, 13);
            this.lblClienteSelecionado.TabIndex = 10;
            this.lblClienteSelecionado.Text = "Cliente Selecionado:";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Enabled = false;
            this.txtClienteId.Location = new System.Drawing.Point(669, 97);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(94, 20);
            this.txtClienteId.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(10, 468);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 13);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Observações:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(89, 456);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(674, 38);
            this.txtDescricao.TabIndex = 13;
            // 
            // lblValorAdicional
            // 
            this.lblValorAdicional.AutoSize = true;
            this.lblValorAdicional.Location = new System.Drawing.Point(545, 341);
            this.lblValorAdicional.Name = "lblValorAdicional";
            this.lblValorAdicional.Size = new System.Drawing.Size(83, 13);
            this.lblValorAdicional.TabIndex = 14;
            this.lblValorAdicional.Text = "Valor Adicional: ";
            this.lblValorAdicional.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(544, 367);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(85, 13);
            this.lblPercentualDesconto.TabIndex = 15;
            this.lblPercentualDesconto.Text = "% de Desconto: ";
            this.lblPercentualDesconto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Location = new System.Drawing.Point(542, 393);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(86, 13);
            this.lblValorDesconto.TabIndex = 16;
            this.lblValorDesconto.Text = "Valor Desconto: ";
            this.lblValorDesconto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(563, 419);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(64, 13);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total: ";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtValorAdicional
            // 
            this.txtValorAdicional.Location = new System.Drawing.Point(630, 338);
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(133, 20);
            this.txtValorAdicional.TabIndex = 18;
            this.txtValorAdicional.Leave += new System.EventHandler(this.txtValorAdicional_Leave);
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.Location = new System.Drawing.Point(630, 364);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.Size = new System.Drawing.Size(133, 20);
            this.txtPercentualDesconto.TabIndex = 19;
            this.txtPercentualDesconto.Leave += new System.EventHandler(this.txtPercentualDesconto_Leave);
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Enabled = false;
            this.txtValorDesconto.Location = new System.Drawing.Point(630, 390);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(133, 20);
            this.txtValorDesconto.TabIndex = 20;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(630, 416);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(133, 20);
            this.txtValorTotal.TabIndex = 21;
            // 
            // dgvMaodeObra
            // 
            this.dgvMaodeObra.AllowUserToAddRows = false;
            this.dgvMaodeObra.AllowUserToDeleteRows = false;
            this.dgvMaodeObra.AllowUserToResizeColumns = false;
            this.dgvMaodeObra.AllowUserToResizeRows = false;
            this.dgvMaodeObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaodeObra.Location = new System.Drawing.Point(22, 171);
            this.dgvMaodeObra.Name = "dgvMaodeObra";
            this.dgvMaodeObra.ReadOnly = true;
            this.dgvMaodeObra.Size = new System.Drawing.Size(494, 105);
            this.dgvMaodeObra.TabIndex = 22;
            this.dgvMaodeObra.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMaodeObra_RowsAdded);
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
            this.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeca.Location = new System.Drawing.Point(22, 327);
            this.dgvPeca.Name = "dgvPeca";
            this.dgvPeca.ReadOnly = true;
            this.dgvPeca.Size = new System.Drawing.Size(494, 105);
            this.dgvPeca.TabIndex = 23;
            this.dgvPeca.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPeca_RowsAdded);
            // 
            // lblInformativoPeca
            // 
            this.lblInformativoPeca.AutoSize = true;
            this.lblInformativoPeca.Location = new System.Drawing.Point(167, 301);
            this.lblInformativoPeca.Name = "lblInformativoPeca";
            this.lblInformativoPeca.Size = new System.Drawing.Size(290, 13);
            this.lblInformativoPeca.TabIndex = 25;
            this.lblInformativoPeca.Text = "Ao clicar no botão, selecione o registro e clique duas vezes.";
            // 
            // btnAdicionarPeca
            // 
            this.btnAdicionarPeca.Location = new System.Drawing.Point(22, 293);
            this.btnAdicionarPeca.Name = "btnAdicionarPeca";
            this.btnAdicionarPeca.Size = new System.Drawing.Size(139, 28);
            this.btnAdicionarPeca.TabIndex = 29;
            this.btnAdicionarPeca.Text = "Lista de Produtos/Peças";
            this.btnAdicionarPeca.UseVisualStyleBackColor = true;
            this.btnAdicionarPeca.Click += new System.EventHandler(this.btnAdicionarPeca_Click);
            // 
            // btnAdicionarMaodeObra
            // 
            this.btnAdicionarMaodeObra.Location = new System.Drawing.Point(22, 137);
            this.btnAdicionarMaodeObra.Name = "btnAdicionarMaodeObra";
            this.btnAdicionarMaodeObra.Size = new System.Drawing.Size(122, 28);
            this.btnAdicionarMaodeObra.TabIndex = 30;
            this.btnAdicionarMaodeObra.Text = "Lista de Mao-de-Obras";
            this.btnAdicionarMaodeObra.UseVisualStyleBackColor = true;
            this.btnAdicionarMaodeObra.Click += new System.EventHandler(this.btnAdicionarMaodeObra_Click);
            // 
            // lblInformativoMaoDeObra
            // 
            this.lblInformativoMaoDeObra.AutoSize = true;
            this.lblInformativoMaoDeObra.Location = new System.Drawing.Point(150, 145);
            this.lblInformativoMaoDeObra.Name = "lblInformativoMaoDeObra";
            this.lblInformativoMaoDeObra.Size = new System.Drawing.Size(290, 13);
            this.lblInformativoMaoDeObra.TabIndex = 31;
            this.lblInformativoMaoDeObra.Text = "Ao clicar no botão, selecione o registro e clique duas vezes.";
            // 
            // dgvOcultoGuardaInformacao
            // 
            this.dgvOcultoGuardaInformacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcultoGuardaInformacao.Enabled = false;
            this.dgvOcultoGuardaInformacao.Location = new System.Drawing.Point(46, 190);
            this.dgvOcultoGuardaInformacao.Name = "dgvOcultoGuardaInformacao";
            this.dgvOcultoGuardaInformacao.Size = new System.Drawing.Size(439, 62);
            this.dgvOcultoGuardaInformacao.TabIndex = 32;
            this.dgvOcultoGuardaInformacao.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOcultoGuardaInformacao_RowsAdded);
            // 
            // dgvOcultoInformacaoPecas
            // 
            this.dgvOcultoInformacaoPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcultoInformacaoPecas.Location = new System.Drawing.Point(46, 341);
            this.dgvOcultoInformacaoPecas.Name = "dgvOcultoInformacaoPecas";
            this.dgvOcultoInformacaoPecas.Size = new System.Drawing.Size(431, 77);
            this.dgvOcultoInformacaoPecas.TabIndex = 33;
            this.dgvOcultoInformacaoPecas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOcultoInformacaoPecas_RowsAdded);
            // 
            // lblQtdRegistrosMaoDeObra
            // 
            this.lblQtdRegistrosMaoDeObra.AutoSize = true;
            this.lblQtdRegistrosMaoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistrosMaoDeObra.Location = new System.Drawing.Point(396, 279);
            this.lblQtdRegistrosMaoDeObra.Name = "lblQtdRegistrosMaoDeObra";
            this.lblQtdRegistrosMaoDeObra.Size = new System.Drawing.Size(99, 12);
            this.lblQtdRegistrosMaoDeObra.TabIndex = 35;
            this.lblQtdRegistrosMaoDeObra.Text = "Quantidade Registros: ";
            // 
            // txtValorTotalPecas
            // 
            this.txtValorTotalPecas.Enabled = false;
            this.txtValorTotalPecas.Location = new System.Drawing.Point(630, 312);
            this.txtValorTotalPecas.Name = "txtValorTotalPecas";
            this.txtValorTotalPecas.Size = new System.Drawing.Size(133, 20);
            this.txtValorTotalPecas.TabIndex = 36;
            // 
            // txtValorTotalMaodeObra
            // 
            this.txtValorTotalMaodeObra.Enabled = false;
            this.txtValorTotalMaodeObra.Location = new System.Drawing.Point(630, 286);
            this.txtValorTotalMaodeObra.Name = "txtValorTotalMaodeObra";
            this.txtValorTotalMaodeObra.Size = new System.Drawing.Size(133, 20);
            this.txtValorTotalMaodeObra.TabIndex = 37;
            // 
            // lblValorMaoDeObraTexto
            // 
            this.lblValorMaoDeObraTexto.AutoSize = true;
            this.lblValorMaoDeObraTexto.Location = new System.Drawing.Point(549, 289);
            this.lblValorMaoDeObraTexto.Name = "lblValorMaoDeObraTexto";
            this.lblValorMaoDeObraTexto.Size = new System.Drawing.Size(75, 13);
            this.lblValorMaoDeObraTexto.TabIndex = 38;
            this.lblValorMaoDeObraTexto.Text = "Mão-de-Obra: ";
            this.lblValorMaoDeObraTexto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Produtos/Peças: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblQtdRegistrosPecas
            // 
            this.lblQtdRegistrosPecas.AutoSize = true;
            this.lblQtdRegistrosPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistrosPecas.Location = new System.Drawing.Point(396, 435);
            this.lblQtdRegistrosPecas.Name = "lblQtdRegistrosPecas";
            this.lblQtdRegistrosPecas.Size = new System.Drawing.Size(99, 12);
            this.lblQtdRegistrosPecas.TabIndex = 40;
            this.lblQtdRegistrosPecas.Text = "Quantidade Registros: ";
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrcamento.Location = new System.Drawing.Point(551, 221);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(198, 45);
            this.lblOrcamento.TabIndex = 41;
            this.lblOrcamento.Text = "ORÇAMENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(545, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmGerarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 651);
            this.Name = "frmGerarOrcamento";
            this.Text = "Sistema de Gerenciamento Mecânica - Efetuar Orçamento";
            this.Load += new System.EventHandler(this.FrmGerarOrcamento_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcultoGuardaInformacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcultoInformacaoPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrcamentoId;
        private System.Windows.Forms.Label lblOrcamentoId;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblClienteSelecionado;
        private System.Windows.Forms.TextBox txtClienteSelecionado;
        private System.Windows.Forms.TextBox txtClienteId;
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
        private System.Windows.Forms.Button btnAdicionarPeca;
        private System.Windows.Forms.Label lblInformativoPeca;
        private System.Windows.Forms.DataGridView dgvPeca;
        private System.Windows.Forms.DataGridView dgvMaodeObra;
        private System.Windows.Forms.Button btnAdicionarMaodeObra;
        private Label lblInformativoMaoDeObra;
        private DataGridView dgvOcultoGuardaInformacao;
        private DataGridView dgvOcultoInformacaoPecas;
        private Label lblQtdRegistrosMaoDeObra;
        private Label label2;
        private Label lblValorMaoDeObraTexto;
        private TextBox txtValorTotalMaodeObra;
        private TextBox txtValorTotalPecas;
        private Label lblQtdRegistrosPecas;
        private Label lblOrcamento;
        private PictureBox pictureBox1;
    }
}
