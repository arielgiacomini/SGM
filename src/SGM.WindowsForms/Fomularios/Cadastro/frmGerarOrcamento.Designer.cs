using System.Windows.Forms;

namespace SGM.WindowsForms
{
    partial class FrmGerarOrcamento
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
            this.lblQtdRegistrosMaoDeObra = new System.Windows.Forms.Label();
            this.txtValorTotalPecas = new System.Windows.Forms.TextBox();
            this.txtValorTotalMaodeObra = new System.Windows.Forms.TextBox();
            this.lblValorMaoDeObraTexto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdRegistrosPecas = new System.Windows.Forms.Label();
            this.lblOrcamento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClienteVeiculoId = new System.Windows.Forms.Label();
            this.txtClienteVeiculoId = new System.Windows.Forms.TextBox();
            this.checkInclusaoManual = new System.Windows.Forms.CheckBox();
            this.grpMaoObraPecas = new System.Windows.Forms.GroupBox();
            this.txtValorMaoDeObraManual = new System.Windows.Forms.TextBox();
            this.txtValorPecaManual = new System.Windows.Forms.TextBox();
            this.lblValorMaoDeObraManual = new System.Windows.Forms.Label();
            this.lblValorPecaManual = new System.Windows.Forms.Label();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMaoObraPecas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.grpMaoObraPecas);
            this.pnCadastro.Controls.Add(this.txtClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.lblClienteVeiculoId);
            this.pnCadastro.Controls.Add(this.pictureBox1);
            this.pnCadastro.Controls.Add(this.lblOrcamento);
            this.pnCadastro.Controls.Add(this.lblQtdRegistrosPecas);
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
            this.pnCadastro.Controls.Add(this.dgvMaodeObra);
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
            this.btnSalvar.TabIndex = 50;
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
            // lblOrcamentoId
            // 
            this.lblOrcamentoId.AutoSize = true;
            this.lblOrcamentoId.Location = new System.Drawing.Point(611, 126);
            this.lblOrcamentoId.Name = "lblOrcamentoId";
            this.lblOrcamentoId.Size = new System.Drawing.Size(110, 13);
            this.lblOrcamentoId.TabIndex = 0;
            this.lblOrcamentoId.Text = "Código do Orçamento";
            // 
            // txtOrcamentoId
            // 
            this.txtOrcamentoId.Enabled = false;
            this.txtOrcamentoId.Location = new System.Drawing.Point(719, 123);
            this.txtOrcamentoId.Name = "txtOrcamentoId";
            this.txtOrcamentoId.ReadOnly = true;
            this.txtOrcamentoId.Size = new System.Drawing.Size(44, 20);
            this.txtOrcamentoId.TabIndex = 1;
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(208, 15);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(350, 20);
            this.txtConsultaCliente.TabIndex = 36;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(186, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Nome, Apelido ou PLACA do Veículo:";
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Image = global::SGM.WindowsForms.Properties.Resources.LocalicarRedimensionado3;
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
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellDoubleClick);
            // 
            // txtClienteSelecionado
            // 
            this.txtClienteSelecionado.Enabled = false;
            this.txtClienteSelecionado.Location = new System.Drawing.Point(123, 97);
            this.txtClienteSelecionado.Name = "txtClienteSelecionado";
            this.txtClienteSelecionado.ReadOnly = true;
            this.txtClienteSelecionado.Size = new System.Drawing.Size(421, 20);
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
            this.txtClienteId.Location = new System.Drawing.Point(548, 97);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(45, 20);
            this.txtClienteId.TabIndex = 11;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(10, 492);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(73, 13);
            this.lblDescricao.TabIndex = 12;
            this.lblDescricao.Text = "Observações:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(89, 474);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(416, 49);
            this.txtDescricao.TabIndex = 49;
            // 
            // lblValorAdicional
            // 
            this.lblValorAdicional.AutoSize = true;
            this.lblValorAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAdicional.Location = new System.Drawing.Point(529, 396);
            this.lblValorAdicional.Name = "lblValorAdicional";
            this.lblValorAdicional.Size = new System.Drawing.Size(102, 16);
            this.lblValorAdicional.TabIndex = 14;
            this.lblValorAdicional.Text = "Valor Adicional:";
            this.lblValorAdicional.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDesconto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(528, 433);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(103, 16);
            this.lblPercentualDesconto.TabIndex = 15;
            this.lblPercentualDesconto.Text = "% de Desconto:";
            this.lblPercentualDesconto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblValorDesconto.Location = new System.Drawing.Point(527, 464);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(104, 16);
            this.lblValorDesconto.TabIndex = 16;
            this.lblValorDesconto.Text = "Valor Desconto:";
            this.lblValorDesconto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(521, 495);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(101, 20);
            this.lblValorTotal.TabIndex = 17;
            this.lblValorTotal.Text = "Valor Total:";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtValorAdicional
            // 
            this.txtValorAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAdicional.Location = new System.Drawing.Point(633, 393);
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(131, 26);
            this.txtValorAdicional.TabIndex = 47;
            this.txtValorAdicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorAdicional.Enter += new System.EventHandler(this.TxtValorAdicional_Enter);
            this.txtValorAdicional.Leave += new System.EventHandler(this.TxtValorAdicional_Leave);
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualDesconto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPercentualDesconto.Location = new System.Drawing.Point(633, 430);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.Size = new System.Drawing.Size(131, 22);
            this.txtPercentualDesconto.TabIndex = 48;
            this.txtPercentualDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPercentualDesconto.Enter += new System.EventHandler(this.TxtPercentualDesconto_Enter);
            this.txtPercentualDesconto.Leave += new System.EventHandler(this.TxtPercentualDesconto_Leave);
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Enabled = false;
            this.txtValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtValorDesconto.Location = new System.Drawing.Point(633, 461);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.ReadOnly = true;
            this.txtValorDesconto.Size = new System.Drawing.Size(131, 22);
            this.txtValorDesconto.TabIndex = 20;
            this.txtValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(633, 492);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(130, 29);
            this.txtValorTotal.TabIndex = 21;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvMaodeObra
            // 
            this.dgvMaodeObra.AllowUserToAddRows = false;
            this.dgvMaodeObra.AllowUserToDeleteRows = false;
            this.dgvMaodeObra.AllowUserToResizeColumns = false;
            this.dgvMaodeObra.AllowUserToResizeRows = false;
            this.dgvMaodeObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaodeObra.Location = new System.Drawing.Point(12, 174);
            this.dgvMaodeObra.Name = "dgvMaodeObra";
            this.dgvMaodeObra.ReadOnly = true;
            this.dgvMaodeObra.Size = new System.Drawing.Size(493, 116);
            this.dgvMaodeObra.TabIndex = 22;
            this.dgvMaodeObra.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMaodeObra_CellMouseDoubleClick);
            this.dgvMaodeObra.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvMaodeObra_RowsAdded);
            // 
            // dgvPeca
            // 
            this.dgvPeca.AllowUserToAddRows = false;
            this.dgvPeca.AllowUserToDeleteRows = false;
            this.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeca.Location = new System.Drawing.Point(11, 338);
            this.dgvPeca.Name = "dgvPeca";
            this.dgvPeca.ReadOnly = true;
            this.dgvPeca.Size = new System.Drawing.Size(494, 118);
            this.dgvPeca.TabIndex = 23;
            this.dgvPeca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPeca_CellDoubleClick);
            this.dgvPeca.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvPeca_RowsAdded);
            // 
            // lblInformativoPeca
            // 
            this.lblInformativoPeca.AutoSize = true;
            this.lblInformativoPeca.Location = new System.Drawing.Point(157, 315);
            this.lblInformativoPeca.Name = "lblInformativoPeca";
            this.lblInformativoPeca.Size = new System.Drawing.Size(290, 13);
            this.lblInformativoPeca.TabIndex = 25;
            this.lblInformativoPeca.Text = "Ao clicar no botão, selecione o registro e clique duas vezes.";
            // 
            // btnAdicionarPeca
            // 
            this.btnAdicionarPeca.Location = new System.Drawing.Point(12, 304);
            this.btnAdicionarPeca.Name = "btnAdicionarPeca";
            this.btnAdicionarPeca.Size = new System.Drawing.Size(139, 28);
            this.btnAdicionarPeca.TabIndex = 29;
            this.btnAdicionarPeca.Text = "Lista de Produtos/Peças";
            this.btnAdicionarPeca.UseVisualStyleBackColor = true;
            this.btnAdicionarPeca.Click += new System.EventHandler(this.BtnAdicionarPeca_Click);
            // 
            // btnAdicionarMaodeObra
            // 
            this.btnAdicionarMaodeObra.Location = new System.Drawing.Point(12, 140);
            this.btnAdicionarMaodeObra.Name = "btnAdicionarMaodeObra";
            this.btnAdicionarMaodeObra.Size = new System.Drawing.Size(122, 28);
            this.btnAdicionarMaodeObra.TabIndex = 30;
            this.btnAdicionarMaodeObra.Text = "Lista de Mao-de-Obras";
            this.btnAdicionarMaodeObra.UseVisualStyleBackColor = true;
            this.btnAdicionarMaodeObra.Click += new System.EventHandler(this.BtnAdicionarMaodeObra_Click);
            // 
            // lblInformativoMaoDeObra
            // 
            this.lblInformativoMaoDeObra.AutoSize = true;
            this.lblInformativoMaoDeObra.Location = new System.Drawing.Point(140, 148);
            this.lblInformativoMaoDeObra.Name = "lblInformativoMaoDeObra";
            this.lblInformativoMaoDeObra.Size = new System.Drawing.Size(290, 13);
            this.lblInformativoMaoDeObra.TabIndex = 31;
            this.lblInformativoMaoDeObra.Text = "Ao clicar no botão, selecione o registro e clique duas vezes.";
            // 
            // lblQtdRegistrosMaoDeObra
            // 
            this.lblQtdRegistrosMaoDeObra.AutoSize = true;
            this.lblQtdRegistrosMaoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistrosMaoDeObra.Location = new System.Drawing.Point(348, 293);
            this.lblQtdRegistrosMaoDeObra.Name = "lblQtdRegistrosMaoDeObra";
            this.lblQtdRegistrosMaoDeObra.Size = new System.Drawing.Size(99, 12);
            this.lblQtdRegistrosMaoDeObra.TabIndex = 35;
            this.lblQtdRegistrosMaoDeObra.Text = "Quantidade Registros: ";
            // 
            // txtValorTotalPecas
            // 
            this.txtValorTotalPecas.Enabled = false;
            this.txtValorTotalPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalPecas.Location = new System.Drawing.Point(120, 55);
            this.txtValorTotalPecas.Name = "txtValorTotalPecas";
            this.txtValorTotalPecas.ReadOnly = true;
            this.txtValorTotalPecas.Size = new System.Drawing.Size(131, 26);
            this.txtValorTotalPecas.TabIndex = 38;
            this.txtValorTotalPecas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotalPecas.Enter += new System.EventHandler(this.TxtValorTotalPecas_Enter);
            this.txtValorTotalPecas.Leave += new System.EventHandler(this.TxtValorTotalPecas_Leave);
            // 
            // txtValorTotalMaodeObra
            // 
            this.txtValorTotalMaodeObra.Enabled = false;
            this.txtValorTotalMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalMaodeObra.Location = new System.Drawing.Point(120, 24);
            this.txtValorTotalMaodeObra.Name = "txtValorTotalMaodeObra";
            this.txtValorTotalMaodeObra.ReadOnly = true;
            this.txtValorTotalMaodeObra.Size = new System.Drawing.Size(131, 26);
            this.txtValorTotalMaodeObra.TabIndex = 37;
            this.txtValorTotalMaodeObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotalMaodeObra.Enter += new System.EventHandler(this.TxtValorTotalMaodeObra_Enter);
            this.txtValorTotalMaodeObra.Leave += new System.EventHandler(this.TxtValorTotalMaodeObra_Leave);
            // 
            // lblValorMaoDeObraTexto
            // 
            this.lblValorMaoDeObraTexto.AutoSize = true;
            this.lblValorMaoDeObraTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaoDeObraTexto.Location = new System.Drawing.Point(25, 27);
            this.lblValorMaoDeObraTexto.Name = "lblValorMaoDeObraTexto";
            this.lblValorMaoDeObraTexto.Size = new System.Drawing.Size(92, 16);
            this.lblValorMaoDeObraTexto.TabIndex = 38;
            this.lblValorMaoDeObraTexto.Text = "Mão-de-Obra:";
            this.lblValorMaoDeObraTexto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Produtos/Peças:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblQtdRegistrosPecas
            // 
            this.lblQtdRegistrosPecas.AutoSize = true;
            this.lblQtdRegistrosPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdRegistrosPecas.Location = new System.Drawing.Point(348, 459);
            this.lblQtdRegistrosPecas.Name = "lblQtdRegistrosPecas";
            this.lblQtdRegistrosPecas.Size = new System.Drawing.Size(99, 12);
            this.lblQtdRegistrosPecas.TabIndex = 40;
            this.lblQtdRegistrosPecas.Text = "Quantidade Registros: ";
            // 
            // lblOrcamento
            // 
            this.lblOrcamento.AutoSize = true;
            this.lblOrcamento.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrcamento.Location = new System.Drawing.Point(556, 148);
            this.lblOrcamento.Name = "lblOrcamento";
            this.lblOrcamento.Size = new System.Drawing.Size(198, 45);
            this.lblOrcamento.TabIndex = 41;
            this.lblOrcamento.Text = "ORÇAMENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGM.WindowsForms.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(449, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblClienteVeiculoId
            // 
            this.lblClienteVeiculoId.AutoSize = true;
            this.lblClienteVeiculoId.Location = new System.Drawing.Point(593, 100);
            this.lblClienteVeiculoId.Name = "lblClienteVeiculoId";
            this.lblClienteVeiculoId.Size = new System.Drawing.Size(128, 13);
            this.lblClienteVeiculoId.TabIndex = 42;
            this.lblClienteVeiculoId.Text = "Código do Veiculo Cliente";
            // 
            // txtClienteVeiculoId
            // 
            this.txtClienteVeiculoId.Location = new System.Drawing.Point(719, 97);
            this.txtClienteVeiculoId.Name = "txtClienteVeiculoId";
            this.txtClienteVeiculoId.ReadOnly = true;
            this.txtClienteVeiculoId.Size = new System.Drawing.Size(44, 20);
            this.txtClienteVeiculoId.TabIndex = 43;
            // 
            // checkInclusaoManual
            // 
            this.checkInclusaoManual.AutoSize = true;
            this.checkInclusaoManual.Location = new System.Drawing.Point(54, 94);
            this.checkInclusaoManual.Name = "checkInclusaoManual";
            this.checkInclusaoManual.Size = new System.Drawing.Size(134, 17);
            this.checkInclusaoManual.TabIndex = 44;
            this.checkInclusaoManual.Text = "Deseja Incluir Manual?";
            this.checkInclusaoManual.UseVisualStyleBackColor = true;
            this.checkInclusaoManual.CheckedChanged += new System.EventHandler(this.CheckInclusaoManual_CheckedChanged);
            // 
            // grpMaoObraPecas
            // 
            this.grpMaoObraPecas.Controls.Add(this.txtValorMaoDeObraManual);
            this.grpMaoObraPecas.Controls.Add(this.txtValorPecaManual);
            this.grpMaoObraPecas.Controls.Add(this.lblValorMaoDeObraManual);
            this.grpMaoObraPecas.Controls.Add(this.lblValorPecaManual);
            this.grpMaoObraPecas.Controls.Add(this.txtValorTotalMaodeObra);
            this.grpMaoObraPecas.Controls.Add(this.checkInclusaoManual);
            this.grpMaoObraPecas.Controls.Add(this.txtValorTotalPecas);
            this.grpMaoObraPecas.Controls.Add(this.lblValorMaoDeObraTexto);
            this.grpMaoObraPecas.Controls.Add(this.label2);
            this.grpMaoObraPecas.Location = new System.Drawing.Point(511, 206);
            this.grpMaoObraPecas.Name = "grpMaoObraPecas";
            this.grpMaoObraPecas.Size = new System.Drawing.Size(260, 181);
            this.grpMaoObraPecas.TabIndex = 45;
            this.grpMaoObraPecas.TabStop = false;
            this.grpMaoObraPecas.Text = "Mão de Obras/Peças";
            // 
            // txtValorMaoDeObraManual
            // 
            this.txtValorMaoDeObraManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMaoDeObraManual.Location = new System.Drawing.Point(121, 122);
            this.txtValorMaoDeObraManual.Name = "txtValorMaoDeObraManual";
            this.txtValorMaoDeObraManual.Size = new System.Drawing.Size(131, 26);
            this.txtValorMaoDeObraManual.TabIndex = 45;
            this.txtValorMaoDeObraManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorMaoDeObraManual.Visible = false;
            this.txtValorMaoDeObraManual.Enter += new System.EventHandler(this.TxtValorMaoDeObraManual_Enter);
            this.txtValorMaoDeObraManual.Leave += new System.EventHandler(this.TxtValorMaoDeObraManual_Leave);
            // 
            // txtValorPecaManual
            // 
            this.txtValorPecaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPecaManual.Location = new System.Drawing.Point(121, 153);
            this.txtValorPecaManual.Name = "txtValorPecaManual";
            this.txtValorPecaManual.Size = new System.Drawing.Size(131, 26);
            this.txtValorPecaManual.TabIndex = 46;
            this.txtValorPecaManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPecaManual.Visible = false;
            this.txtValorPecaManual.Enter += new System.EventHandler(this.TxtValorPecaManual_Enter);
            this.txtValorPecaManual.Leave += new System.EventHandler(this.TxtValorPecaManual_Leave);
            // 
            // lblValorMaoDeObraManual
            // 
            this.lblValorMaoDeObraManual.AutoSize = true;
            this.lblValorMaoDeObraManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaoDeObraManual.Location = new System.Drawing.Point(26, 125);
            this.lblValorMaoDeObraManual.Name = "lblValorMaoDeObraManual";
            this.lblValorMaoDeObraManual.Size = new System.Drawing.Size(92, 16);
            this.lblValorMaoDeObraManual.TabIndex = 47;
            this.lblValorMaoDeObraManual.Text = "Mão-de-Obra:";
            this.lblValorMaoDeObraManual.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblValorMaoDeObraManual.Visible = false;
            // 
            // lblValorPecaManual
            // 
            this.lblValorPecaManual.AutoSize = true;
            this.lblValorPecaManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPecaManual.Location = new System.Drawing.Point(11, 156);
            this.lblValorPecaManual.Name = "lblValorPecaManual";
            this.lblValorPecaManual.Size = new System.Drawing.Size(108, 16);
            this.lblValorPecaManual.TabIndex = 48;
            this.lblValorPecaManual.Text = "Produtos/Peças:";
            this.lblValorPecaManual.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblValorPecaManual.Visible = false;
            // 
            // FrmGerarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 651);
            this.Name = "FrmGerarOrcamento";
            this.Text = "Sistema de Gerenciamento Mecânica - Efetuar Orçamento";
            this.Load += new System.EventHandler(this.FrmGerarOrcamento_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMaoObraPecas.ResumeLayout(false);
            this.grpMaoObraPecas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtOrcamentoId;
        private Label lblOrcamentoId;
        private Label lblCliente;
        private TextBox txtConsultaCliente;
        private Button btnConsultaCliente;
        private DataGridView dgvCliente;
        private Label lblClienteSelecionado;
        private TextBox txtClienteSelecionado;
        private TextBox txtClienteId;
        private TextBox txtValorTotal;
        private TextBox txtValorDesconto;
        private TextBox txtPercentualDesconto;
        private TextBox txtValorAdicional;
        private Label lblValorTotal;
        private Label lblValorDesconto;
        private Label lblPercentualDesconto;
        private Label lblValorAdicional;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private Button btnAdicionarPeca;
        private Label lblInformativoPeca;
        private DataGridView dgvPeca;
        private DataGridView dgvMaodeObra;
        private Button btnAdicionarMaodeObra;
        private Label lblInformativoMaoDeObra;
        private Label lblQtdRegistrosMaoDeObra;
        private Label label2;
        private Label lblValorMaoDeObraTexto;
        private TextBox txtValorTotalMaodeObra;
        private TextBox txtValorTotalPecas;
        private Label lblQtdRegistrosPecas;
        private Label lblOrcamento;
        private PictureBox pictureBox1;
        private TextBox txtClienteVeiculoId;
        private Label lblClienteVeiculoId;
        private GroupBox grpMaoObraPecas;
        private TextBox txtValorMaoDeObraManual;
        private TextBox txtValorPecaManual;
        private Label lblValorMaoDeObraManual;
        private Label lblValorPecaManual;
        private CheckBox checkInclusaoManual;
    }
}