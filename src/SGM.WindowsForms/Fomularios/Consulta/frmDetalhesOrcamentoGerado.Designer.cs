namespace SGM.WindowsForms
{
    partial class FrmDetalhesOrcamentoGerado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalhesOrcamentoGerado));
            this.lblQtdRegistrosMaodeObra = new System.Windows.Forms.Label();
            this.lblQtdRegistrosPecasProdutos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOrcamentoId = new System.Windows.Forms.Label();
            this.lblTextoPecaProduto = new System.Windows.Forms.Label();
            this.lblTextoMaodeObra = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorDescontoTotal = new System.Windows.Forms.TextBox();
            this.dgvMaodeObraOrcamentoGerado = new System.Windows.Forms.DataGridView();
            this.lblValorDescontoTotal = new System.Windows.Forms.Label();
            this.dgvPecasOrcamentoGerados = new System.Windows.Forms.DataGridView();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.lblValorMaodeObra = new System.Windows.Forms.Label();
            this.lblPercentualDesconto = new System.Windows.Forms.Label();
            this.txtValorMaodeObraTotal = new System.Windows.Forms.TextBox();
            this.lblValorAdicionalTotal = new System.Windows.Forms.Label();
            this.lblValorProdutosPecasTotal = new System.Windows.Forms.Label();
            this.txtValorAdicionalTotal = new System.Windows.Forms.TextBox();
            this.txtValorProdutosPecasTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObraOrcamentoGerado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasOrcamentoGerados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQtdRegistrosMaodeObra
            // 
            this.lblQtdRegistrosMaodeObra.AutoSize = true;
            this.lblQtdRegistrosMaodeObra.Location = new System.Drawing.Point(12, 41);
            this.lblQtdRegistrosMaodeObra.Name = "lblQtdRegistrosMaodeObra";
            this.lblQtdRegistrosMaodeObra.Size = new System.Drawing.Size(124, 13);
            this.lblQtdRegistrosMaodeObra.TabIndex = 97;
            this.lblQtdRegistrosMaodeObra.Text = "Quantidade de Registros";
            // 
            // lblQtdRegistrosPecasProdutos
            // 
            this.lblQtdRegistrosPecasProdutos.AutoSize = true;
            this.lblQtdRegistrosPecasProdutos.Location = new System.Drawing.Point(12, 282);
            this.lblQtdRegistrosPecasProdutos.Name = "lblQtdRegistrosPecasProdutos";
            this.lblQtdRegistrosPecasProdutos.Size = new System.Drawing.Size(124, 13);
            this.lblQtdRegistrosPecasProdutos.TabIndex = 96;
            this.lblQtdRegistrosPecasProdutos.Text = "Quantidade de Registros";
            this.lblQtdRegistrosPecasProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(732, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // lblOrcamentoId
            // 
            this.lblOrcamentoId.AutoSize = true;
            this.lblOrcamentoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrcamentoId.Location = new System.Drawing.Point(505, 20);
            this.lblOrcamentoId.Name = "lblOrcamentoId";
            this.lblOrcamentoId.Size = new System.Drawing.Size(162, 24);
            this.lblOrcamentoId.TabIndex = 94;
            this.lblOrcamentoId.Text = "Nº do Orçamento:";
            // 
            // lblTextoPecaProduto
            // 
            this.lblTextoPecaProduto.AutoSize = true;
            this.lblTextoPecaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPecaProduto.Location = new System.Drawing.Point(215, 268);
            this.lblTextoPecaProduto.Name = "lblTextoPecaProduto";
            this.lblTextoPecaProduto.Size = new System.Drawing.Size(156, 24);
            this.lblTextoPecaProduto.TabIndex = 93;
            this.lblTextoPecaProduto.Text = "Peças/Produtos";
            // 
            // lblTextoMaodeObra
            // 
            this.lblTextoMaodeObra.AutoSize = true;
            this.lblTextoMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoMaodeObra.Location = new System.Drawing.Point(215, 30);
            this.lblTextoMaodeObra.Name = "lblTextoMaodeObra";
            this.lblTextoMaodeObra.Size = new System.Drawing.Size(132, 24);
            this.lblTextoMaodeObra.TabIndex = 92;
            this.lblTextoMaodeObra.Text = "Mão de Obra";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(593, 450);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(179, 26);
            this.txtValorTotal.TabIndex = 91;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(620, 406);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(117, 24);
            this.lblValorTotal.TabIndex = 90;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorDescontoTotal
            // 
            this.txtValorDescontoTotal.ForeColor = System.Drawing.Color.Red;
            this.txtValorDescontoTotal.Location = new System.Drawing.Point(706, 329);
            this.txtValorDescontoTotal.Name = "txtValorDescontoTotal";
            this.txtValorDescontoTotal.ReadOnly = true;
            this.txtValorDescontoTotal.Size = new System.Drawing.Size(135, 20);
            this.txtValorDescontoTotal.TabIndex = 89;
            this.txtValorDescontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvMaodeObraOrcamentoGerado
            // 
            this.dgvMaodeObraOrcamentoGerado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaodeObraOrcamentoGerado.Location = new System.Drawing.Point(11, 57);
            this.dgvMaodeObraOrcamentoGerado.Name = "dgvMaodeObraOrcamentoGerado";
            this.dgvMaodeObraOrcamentoGerado.ReadOnly = true;
            this.dgvMaodeObraOrcamentoGerado.Size = new System.Drawing.Size(494, 190);
            this.dgvMaodeObraOrcamentoGerado.TabIndex = 79;
            // 
            // lblValorDescontoTotal
            // 
            this.lblValorDescontoTotal.AutoSize = true;
            this.lblValorDescontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDescontoTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorDescontoTotal.Location = new System.Drawing.Point(585, 329);
            this.lblValorDescontoTotal.Name = "lblValorDescontoTotal";
            this.lblValorDescontoTotal.Size = new System.Drawing.Size(115, 18);
            this.lblValorDescontoTotal.TabIndex = 88;
            this.lblValorDescontoTotal.Text = "Valor Desconto:";
            this.lblValorDescontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPecasOrcamentoGerados
            // 
            this.dgvPecasOrcamentoGerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecasOrcamentoGerados.Location = new System.Drawing.Point(11, 297);
            this.dgvPecasOrcamentoGerados.Name = "dgvPecasOrcamentoGerados";
            this.dgvPecasOrcamentoGerados.ReadOnly = true;
            this.dgvPecasOrcamentoGerados.Size = new System.Drawing.Size(494, 190);
            this.dgvPecasOrcamentoGerados.TabIndex = 78;
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtPercentualDesconto.Location = new System.Drawing.Point(706, 275);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.ReadOnly = true;
            this.txtPercentualDesconto.Size = new System.Drawing.Size(135, 20);
            this.txtPercentualDesconto.TabIndex = 87;
            this.txtPercentualDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorMaodeObra
            // 
            this.lblValorMaodeObra.AutoSize = true;
            this.lblValorMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaodeObra.Location = new System.Drawing.Point(562, 113);
            this.lblValorMaodeObra.Name = "lblValorMaodeObra";
            this.lblValorMaodeObra.Size = new System.Drawing.Size(136, 18);
            this.lblValorMaodeObra.TabIndex = 80;
            this.lblValorMaodeObra.Text = "Mão de Obra Total:";
            this.lblValorMaodeObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(586, 274);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(114, 18);
            this.lblPercentualDesconto.TabIndex = 86;
            this.lblPercentualDesconto.Text = "% de Desconto:";
            this.lblPercentualDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorMaodeObraTotal
            // 
            this.txtValorMaodeObraTotal.Location = new System.Drawing.Point(706, 114);
            this.txtValorMaodeObraTotal.Name = "txtValorMaodeObraTotal";
            this.txtValorMaodeObraTotal.ReadOnly = true;
            this.txtValorMaodeObraTotal.Size = new System.Drawing.Size(137, 20);
            this.txtValorMaodeObraTotal.TabIndex = 81;
            this.txtValorMaodeObraTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorAdicionalTotal
            // 
            this.lblValorAdicionalTotal.AutoSize = true;
            this.lblValorAdicionalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAdicionalTotal.Location = new System.Drawing.Point(557, 217);
            this.lblValorAdicionalTotal.Name = "lblValorAdicionalTotal";
            this.lblValorAdicionalTotal.Size = new System.Drawing.Size(146, 18);
            this.lblValorAdicionalTotal.TabIndex = 85;
            this.lblValorAdicionalTotal.Text = "Valor Adicional Total:";
            this.lblValorAdicionalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorProdutosPecasTotal
            // 
            this.lblValorProdutosPecasTotal.AutoSize = true;
            this.lblValorProdutosPecasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProdutosPecasTotal.Location = new System.Drawing.Point(545, 164);
            this.lblValorProdutosPecasTotal.Name = "lblValorProdutosPecasTotal";
            this.lblValorProdutosPecasTotal.Size = new System.Drawing.Size(156, 18);
            this.lblValorProdutosPecasTotal.TabIndex = 82;
            this.lblValorProdutosPecasTotal.Text = "Produtos/Peças Total:";
            this.lblValorProdutosPecasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorAdicionalTotal
            // 
            this.txtValorAdicionalTotal.Location = new System.Drawing.Point(706, 218);
            this.txtValorAdicionalTotal.Name = "txtValorAdicionalTotal";
            this.txtValorAdicionalTotal.ReadOnly = true;
            this.txtValorAdicionalTotal.Size = new System.Drawing.Size(137, 20);
            this.txtValorAdicionalTotal.TabIndex = 84;
            this.txtValorAdicionalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorProdutosPecasTotal
            // 
            this.txtValorProdutosPecasTotal.Location = new System.Drawing.Point(706, 165);
            this.txtValorProdutosPecasTotal.Name = "txtValorProdutosPecasTotal";
            this.txtValorProdutosPecasTotal.ReadOnly = true;
            this.txtValorProdutosPecasTotal.Size = new System.Drawing.Size(137, 20);
            this.txtValorProdutosPecasTotal.TabIndex = 83;
            this.txtValorProdutosPecasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmDetalhesOrcamentoGerado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 521);
            this.Controls.Add(this.lblQtdRegistrosMaodeObra);
            this.Controls.Add(this.lblQtdRegistrosPecasProdutos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOrcamentoId);
            this.Controls.Add(this.lblTextoPecaProduto);
            this.Controls.Add(this.lblTextoMaodeObra);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorDescontoTotal);
            this.Controls.Add(this.dgvMaodeObraOrcamentoGerado);
            this.Controls.Add(this.lblValorDescontoTotal);
            this.Controls.Add(this.dgvPecasOrcamentoGerados);
            this.Controls.Add(this.txtPercentualDesconto);
            this.Controls.Add(this.lblValorMaodeObra);
            this.Controls.Add(this.lblPercentualDesconto);
            this.Controls.Add(this.txtValorMaodeObraTotal);
            this.Controls.Add(this.lblValorAdicionalTotal);
            this.Controls.Add(this.lblValorProdutosPecasTotal);
            this.Controls.Add(this.txtValorAdicionalTotal);
            this.Controls.Add(this.txtValorProdutosPecasTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalhesOrcamentoGerado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecânica - Detalhe de Orçamento Gerado para Cliente";
            this.Load += new System.EventHandler(this.FrmDetalhesOrcamentoGerado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObraOrcamentoGerado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasOrcamentoGerados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtdRegistrosMaodeObra;
        private System.Windows.Forms.Label lblQtdRegistrosPecasProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOrcamentoId;
        private System.Windows.Forms.Label lblTextoPecaProduto;
        private System.Windows.Forms.Label lblTextoMaodeObra;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorDescontoTotal;
        private System.Windows.Forms.DataGridView dgvMaodeObraOrcamentoGerado;
        private System.Windows.Forms.Label lblValorDescontoTotal;
        private System.Windows.Forms.DataGridView dgvPecasOrcamentoGerados;
        private System.Windows.Forms.TextBox txtPercentualDesconto;
        private System.Windows.Forms.Label lblValorMaodeObra;
        private System.Windows.Forms.Label lblPercentualDesconto;
        private System.Windows.Forms.TextBox txtValorMaodeObraTotal;
        private System.Windows.Forms.Label lblValorAdicionalTotal;
        private System.Windows.Forms.Label lblValorProdutosPecasTotal;
        private System.Windows.Forms.TextBox txtValorAdicionalTotal;
        private System.Windows.Forms.TextBox txtValorProdutosPecasTotal;
    }
}