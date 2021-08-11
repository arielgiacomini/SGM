
namespace SGM.WindowsForms.Fomularios.Cadastro
{
    partial class FrmGerarServicoPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorPagamento1 = new System.Windows.Forms.Label();
            this.txtValorPagamento1 = new System.Windows.Forms.TextBox();
            this.ckbDuasFormasPagamento = new System.Windows.Forms.CheckBox();
            this.cboFormaPagamento1 = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento1 = new System.Windows.Forms.Label();
            this.lblQuantidadeParcelas1 = new System.Windows.Forms.Label();
            this.cboQuantidadeParcelas1 = new System.Windows.Forms.ComboBox();
            this.grbFormaPagamento1 = new System.Windows.Forms.GroupBox();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbFormaPagamento2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvServicoPagamentoParcela = new System.Windows.Forms.DataGridView();
            this.ServicoPagamentoParcelaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicoPagamentoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorOriginalParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelaGeradaAutomaticamente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUltimosServicosGerados = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblVeiculoCliente = new System.Windows.Forms.Label();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.btnExcluirParcelas = new System.Windows.Forms.Button();
            this.lblInformacoesParaGridView = new System.Windows.Forms.Label();
            this.pnCadastro.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.grbFormaPagamento1.SuspendLayout();
            this.grbFormaPagamento2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicoPagamentoParcela)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.lblInformacoesParaGridView);
            this.pnCadastro.Controls.Add(this.btnExcluirParcelas);
            this.pnCadastro.Controls.Add(this.btnGerarParcelas);
            this.pnCadastro.Controls.Add(this.lblVeiculoCliente);
            this.pnCadastro.Controls.Add(this.lblNomeCliente);
            this.pnCadastro.Controls.Add(this.btnUltimosServicosGerados);
            this.pnCadastro.Controls.Add(this.dgvServicoPagamentoParcela);
            this.pnCadastro.Controls.Add(this.grbFormaPagamento2);
            this.pnCadastro.Controls.Add(this.grbFormaPagamento1);
            this.pnCadastro.Controls.Add(this.ckbDuasFormasPagamento);
            this.pnCadastro.Size = new System.Drawing.Size(974, 648);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(3, 666);
            this.pnBotoes.Size = new System.Drawing.Size(974, 109);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(874, 13);
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(523, 13);
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(693, 13);
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(345, 13);
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(173, 13);
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // lblValorPagamento1
            // 
            this.lblValorPagamento1.AutoSize = true;
            this.lblValorPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagamento1.Location = new System.Drawing.Point(24, 29);
            this.lblValorPagamento1.Name = "lblValorPagamento1";
            this.lblValorPagamento1.Size = new System.Drawing.Size(116, 16);
            this.lblValorPagamento1.TabIndex = 15;
            this.lblValorPagamento1.Text = "Valor Pagamento:";
            this.lblValorPagamento1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtValorPagamento1
            // 
            this.txtValorPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagamento1.Location = new System.Drawing.Point(146, 26);
            this.txtValorPagamento1.Name = "txtValorPagamento1";
            this.txtValorPagamento1.Size = new System.Drawing.Size(199, 22);
            this.txtValorPagamento1.TabIndex = 16;
            this.txtValorPagamento1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbDuasFormasPagamento
            // 
            this.ckbDuasFormasPagamento.AutoSize = true;
            this.ckbDuasFormasPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ckbDuasFormasPagamento.Location = new System.Drawing.Point(360, 22);
            this.ckbDuasFormasPagamento.Name = "ckbDuasFormasPagamento";
            this.ckbDuasFormasPagamento.Size = new System.Drawing.Size(207, 20);
            this.ckbDuasFormasPagamento.TabIndex = 17;
            this.ckbDuasFormasPagamento.Text = "Duas Formas de Pagamento?";
            this.ckbDuasFormasPagamento.UseVisualStyleBackColor = true;
            this.ckbDuasFormasPagamento.CheckedChanged += new System.EventHandler(this.CkbDuasFormasPagamento_CheckedChanged);
            // 
            // cboFormaPagamento1
            // 
            this.cboFormaPagamento1.FormattingEnabled = true;
            this.cboFormaPagamento1.Location = new System.Drawing.Point(523, 24);
            this.cboFormaPagamento1.Name = "cboFormaPagamento1";
            this.cboFormaPagamento1.Size = new System.Drawing.Size(175, 21);
            this.cboFormaPagamento1.TabIndex = 20;
            // 
            // lblFormaPagamento1
            // 
            this.lblFormaPagamento1.AutoSize = true;
            this.lblFormaPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagamento1.Location = new System.Drawing.Point(375, 28);
            this.lblFormaPagamento1.Name = "lblFormaPagamento1";
            this.lblFormaPagamento1.Size = new System.Drawing.Size(142, 16);
            this.lblFormaPagamento1.TabIndex = 21;
            this.lblFormaPagamento1.Text = "Forma de Pagamento:";
            this.lblFormaPagamento1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblQuantidadeParcelas1
            // 
            this.lblQuantidadeParcelas1.AutoSize = true;
            this.lblQuantidadeParcelas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQuantidadeParcelas1.Location = new System.Drawing.Point(24, 69);
            this.lblQuantidadeParcelas1.Name = "lblQuantidadeParcelas1";
            this.lblQuantidadeParcelas1.Size = new System.Drawing.Size(154, 16);
            this.lblQuantidadeParcelas1.TabIndex = 24;
            this.lblQuantidadeParcelas1.Text = "Quantidade de Parcelas";
            // 
            // cboQuantidadeParcelas1
            // 
            this.cboQuantidadeParcelas1.FormattingEnabled = true;
            this.cboQuantidadeParcelas1.Location = new System.Drawing.Point(184, 66);
            this.cboQuantidadeParcelas1.Name = "cboQuantidadeParcelas1";
            this.cboQuantidadeParcelas1.Size = new System.Drawing.Size(378, 21);
            this.cboQuantidadeParcelas1.TabIndex = 25;
            // 
            // grbFormaPagamento1
            // 
            this.grbFormaPagamento1.Controls.Add(this.cboFormaPagamento1);
            this.grbFormaPagamento1.Controls.Add(this.lblDataPagamento);
            this.grbFormaPagamento1.Controls.Add(this.cboQuantidadeParcelas1);
            this.grbFormaPagamento1.Controls.Add(this.lblQuantidadeParcelas1);
            this.grbFormaPagamento1.Controls.Add(this.dateTimePicker1);
            this.grbFormaPagamento1.Controls.Add(this.txtValorPagamento1);
            this.grbFormaPagamento1.Controls.Add(this.lblValorPagamento1);
            this.grbFormaPagamento1.Controls.Add(this.lblFormaPagamento1);
            this.grbFormaPagamento1.Location = new System.Drawing.Point(15, 66);
            this.grbFormaPagamento1.Name = "grbFormaPagamento1";
            this.grbFormaPagamento1.Size = new System.Drawing.Size(943, 100);
            this.grbFormaPagamento1.TabIndex = 26;
            this.grbFormaPagamento1.TabStop = false;
            this.grbFormaPagamento1.Text = "Forma de Pagamento 1";
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPagamento.Location = new System.Drawing.Point(580, 69);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(113, 16);
            this.lblDataPagamento.TabIndex = 27;
            this.lblDataPagamento.Text = "Data Pagamento:";
            this.lblDataPagamento.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(699, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // grbFormaPagamento2
            // 
            this.grbFormaPagamento2.Controls.Add(this.comboBox1);
            this.grbFormaPagamento2.Controls.Add(this.comboBox3);
            this.grbFormaPagamento2.Controls.Add(this.label2);
            this.grbFormaPagamento2.Controls.Add(this.textBox2);
            this.grbFormaPagamento2.Controls.Add(this.label4);
            this.grbFormaPagamento2.Controls.Add(this.label5);
            this.grbFormaPagamento2.Location = new System.Drawing.Point(15, 172);
            this.grbFormaPagamento2.Name = "grbFormaPagamento2";
            this.grbFormaPagamento2.Size = new System.Drawing.Size(943, 100);
            this.grbFormaPagamento2.TabIndex = 27;
            this.grbFormaPagamento2.TabStop = false;
            this.grbFormaPagamento2.Text = "Forma de Pagamento 2";
            this.grbFormaPagamento2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(184, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(378, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantidade de Parcelas";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(146, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor Pagamento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Forma de Pagamento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dgvServicoPagamentoParcela
            // 
            this.dgvServicoPagamentoParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicoPagamentoParcela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServicoPagamentoParcelaId,
            this.ServicoPagamentoId,
            this.Parcela,
            this.ValorOriginalParcela,
            this.DataPagamento,
            this.Descricao,
            this.ParcelaGeradaAutomaticamente,
            this.DataCadastro,
            this.DataAlteracao});
            this.dgvServicoPagamentoParcela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvServicoPagamentoParcela.Location = new System.Drawing.Point(15, 298);
            this.dgvServicoPagamentoParcela.Name = "dgvServicoPagamentoParcela";
            this.dgvServicoPagamentoParcela.Size = new System.Drawing.Size(943, 338);
            this.dgvServicoPagamentoParcela.TabIndex = 28;
            // 
            // ServicoPagamentoParcelaId
            // 
            this.ServicoPagamentoParcelaId.HeaderText = "ID";
            this.ServicoPagamentoParcelaId.Name = "ServicoPagamentoParcelaId";
            this.ServicoPagamentoParcelaId.Width = 30;
            // 
            // ServicoPagamentoId
            // 
            this.ServicoPagamentoId.HeaderText = "ID Pagamento";
            this.ServicoPagamentoId.Name = "ServicoPagamentoId";
            this.ServicoPagamentoId.Width = 70;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Nº Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.Width = 50;
            // 
            // ValorOriginalParcela
            // 
            this.ValorOriginalParcela.HeaderText = "Valor";
            this.ValorOriginalParcela.Name = "ValorOriginalParcela";
            // 
            // DataPagamento
            // 
            this.DataPagamento.HeaderText = "Pagamento";
            this.DataPagamento.Name = "DataPagamento";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Informações";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 280;
            // 
            // ParcelaGeradaAutomaticamente
            // 
            this.ParcelaGeradaAutomaticamente.HeaderText = "Gerado Automatico?";
            this.ParcelaGeradaAutomaticamente.Name = "ParcelaGeradaAutomaticamente";
            this.ParcelaGeradaAutomaticamente.Width = 70;
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "Data de Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.HeaderText = "Data de Alteração";
            this.DataAlteracao.Name = "DataAlteracao";
            // 
            // btnUltimosServicosGerados
            // 
            this.btnUltimosServicosGerados.Location = new System.Drawing.Point(858, 14);
            this.btnUltimosServicosGerados.Name = "btnUltimosServicosGerados";
            this.btnUltimosServicosGerados.Size = new System.Drawing.Size(108, 34);
            this.btnUltimosServicosGerados.TabIndex = 29;
            this.btnUltimosServicosGerados.Text = "Últimos \r\nServiços Gerados";
            this.btnUltimosServicosGerados.UseVisualStyleBackColor = true;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(21, 14);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(76, 13);
            this.lblNomeCliente.TabIndex = 30;
            this.lblNomeCliente.Text = "Nome Cliente: ";
            // 
            // lblVeiculoCliente
            // 
            this.lblVeiculoCliente.AutoSize = true;
            this.lblVeiculoCliente.Location = new System.Drawing.Point(21, 40);
            this.lblVeiculoCliente.Name = "lblVeiculoCliente";
            this.lblVeiculoCliente.Size = new System.Drawing.Size(45, 13);
            this.lblVeiculoCliente.TabIndex = 31;
            this.lblVeiculoCliente.Text = "Veiculo:";
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Location = new System.Drawing.Point(15, 273);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(103, 23);
            this.btnGerarParcelas.TabIndex = 32;
            this.btnGerarParcelas.Text = "Gerar Parcela(s)";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            // 
            // btnExcluirParcelas
            // 
            this.btnExcluirParcelas.Location = new System.Drawing.Point(853, 273);
            this.btnExcluirParcelas.Name = "btnExcluirParcelas";
            this.btnExcluirParcelas.Size = new System.Drawing.Size(103, 23);
            this.btnExcluirParcelas.TabIndex = 33;
            this.btnExcluirParcelas.Text = "Excluir Parcela(s)";
            this.btnExcluirParcelas.UseVisualStyleBackColor = true;
            // 
            // lblInformacoesParaGridView
            // 
            this.lblInformacoesParaGridView.AutoSize = true;
            this.lblInformacoesParaGridView.Location = new System.Drawing.Point(295, 278);
            this.lblInformacoesParaGridView.Name = "lblInformacoesParaGridView";
            this.lblInformacoesParaGridView.Size = new System.Drawing.Size(326, 13);
            this.lblInformacoesParaGridView.TabIndex = 34;
            this.lblInformacoesParaGridView.Text = "Para abrir mais informações da parcela clique duas vezes na linha...\r\n";
            // 
            // FrmGerarServicoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(985, 783);
            this.Name = "FrmGerarServicoPagamento";
            this.Text = "Sistema de Gerenciamento Mecânica - Registrar Pagamento";
            this.Load += new System.EventHandler(this.FrmGerarServicoPagamento_Load);
            this.pnCadastro.ResumeLayout(false);
            this.pnCadastro.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.grbFormaPagamento1.ResumeLayout(false);
            this.grbFormaPagamento1.PerformLayout();
            this.grbFormaPagamento2.ResumeLayout(false);
            this.grbFormaPagamento2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicoPagamentoParcela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFormaPagamento2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbFormaPagamento1;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboFormaPagamento1;
        private System.Windows.Forms.ComboBox cboQuantidadeParcelas1;
        private System.Windows.Forms.Label lblQuantidadeParcelas1;
        private System.Windows.Forms.TextBox txtValorPagamento1;
        private System.Windows.Forms.Label lblValorPagamento1;
        private System.Windows.Forms.Label lblFormaPagamento1;
        private System.Windows.Forms.CheckBox ckbDuasFormasPagamento;
        private System.Windows.Forms.DataGridView dgvServicoPagamentoParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicoPagamentoParcelaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicoPagamentoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorOriginalParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelaGeradaAutomaticamente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
        private System.Windows.Forms.Label lblInformacoesParaGridView;
        private System.Windows.Forms.Button btnExcluirParcelas;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.Label lblVeiculoCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnUltimosServicosGerados;
    }
}