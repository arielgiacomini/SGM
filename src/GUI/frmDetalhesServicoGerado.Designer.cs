namespace GUI
{
    partial class FrmDetalhesServicoGerado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalhesServicoGerado));
            this.dgvPecasServicosGerados = new System.Windows.Forms.DataGridView();
            this.dgvMaodeObraServicoGerado = new System.Windows.Forms.DataGridView();
            this.lblValorMaodeObra = new System.Windows.Forms.Label();
            this.txtValorMaodeObraTotal = new System.Windows.Forms.TextBox();
            this.lblValorProdutosPecasTotal = new System.Windows.Forms.Label();
            this.txtValorProdutosPecasTotal = new System.Windows.Forms.TextBox();
            this.txtValorAdicionalTotal = new System.Windows.Forms.TextBox();
            this.lblValorAdicionalTotal = new System.Windows.Forms.Label();
            this.lblPercentualDesconto = new System.Windows.Forms.Label();
            this.txtPercentualDesconto = new System.Windows.Forms.TextBox();
            this.lblValorDescontoTotal = new System.Windows.Forms.Label();
            this.txtValorDescontoTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblTextoMaodeObra = new System.Windows.Forms.Label();
            this.lblTextoPecaProduto = new System.Windows.Forms.Label();
            this.lblServicoId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasServicosGerados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObraServicoGerado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPecasServicosGerados
            // 
            this.dgvPecasServicosGerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecasServicosGerados.Location = new System.Drawing.Point(12, 300);
            this.dgvPecasServicosGerados.Name = "dgvPecasServicosGerados";
            this.dgvPecasServicosGerados.ReadOnly = true;
            this.dgvPecasServicosGerados.Size = new System.Drawing.Size(494, 190);
            this.dgvPecasServicosGerados.TabIndex = 0;
            // 
            // dgvMaodeObraServicoGerado
            // 
            this.dgvMaodeObraServicoGerado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaodeObraServicoGerado.Location = new System.Drawing.Point(12, 60);
            this.dgvMaodeObraServicoGerado.Name = "dgvMaodeObraServicoGerado";
            this.dgvMaodeObraServicoGerado.ReadOnly = true;
            this.dgvMaodeObraServicoGerado.Size = new System.Drawing.Size(494, 190);
            this.dgvMaodeObraServicoGerado.TabIndex = 1;
            // 
            // lblValorMaodeObra
            // 
            this.lblValorMaodeObra.AutoSize = true;
            this.lblValorMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMaodeObra.Location = new System.Drawing.Point(563, 116);
            this.lblValorMaodeObra.Name = "lblValorMaodeObra";
            this.lblValorMaodeObra.Size = new System.Drawing.Size(136, 18);
            this.lblValorMaodeObra.TabIndex = 2;
            this.lblValorMaodeObra.Text = "Mão de Obra Total:";
            this.lblValorMaodeObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorMaodeObraTotal
            // 
            this.txtValorMaodeObraTotal.Location = new System.Drawing.Point(707, 117);
            this.txtValorMaodeObraTotal.Name = "txtValorMaodeObraTotal";
            this.txtValorMaodeObraTotal.ReadOnly = true;
            this.txtValorMaodeObraTotal.Size = new System.Drawing.Size(137, 20);
            this.txtValorMaodeObraTotal.TabIndex = 3;
            this.txtValorMaodeObraTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorProdutosPecasTotal
            // 
            this.lblValorProdutosPecasTotal.AutoSize = true;
            this.lblValorProdutosPecasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProdutosPecasTotal.Location = new System.Drawing.Point(546, 167);
            this.lblValorProdutosPecasTotal.Name = "lblValorProdutosPecasTotal";
            this.lblValorProdutosPecasTotal.Size = new System.Drawing.Size(156, 18);
            this.lblValorProdutosPecasTotal.TabIndex = 4;
            this.lblValorProdutosPecasTotal.Text = "Produtos/Peças Total:";
            this.lblValorProdutosPecasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorProdutosPecasTotal
            // 
            this.txtValorProdutosPecasTotal.Location = new System.Drawing.Point(707, 168);
            this.txtValorProdutosPecasTotal.Name = "txtValorProdutosPecasTotal";
            this.txtValorProdutosPecasTotal.ReadOnly = true;
            this.txtValorProdutosPecasTotal.Size = new System.Drawing.Size(137, 20);
            this.txtValorProdutosPecasTotal.TabIndex = 5;
            this.txtValorProdutosPecasTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorAdicionalTotal
            // 
            this.txtValorAdicionalTotal.Location = new System.Drawing.Point(707, 221);
            this.txtValorAdicionalTotal.Name = "txtValorAdicionalTotal";
            this.txtValorAdicionalTotal.ReadOnly = true;
            this.txtValorAdicionalTotal.Size = new System.Drawing.Size(137, 20);
            this.txtValorAdicionalTotal.TabIndex = 6;
            this.txtValorAdicionalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorAdicionalTotal
            // 
            this.lblValorAdicionalTotal.AutoSize = true;
            this.lblValorAdicionalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAdicionalTotal.Location = new System.Drawing.Point(558, 220);
            this.lblValorAdicionalTotal.Name = "lblValorAdicionalTotal";
            this.lblValorAdicionalTotal.Size = new System.Drawing.Size(146, 18);
            this.lblValorAdicionalTotal.TabIndex = 7;
            this.lblValorAdicionalTotal.Text = "Valor Adicional Total:";
            this.lblValorAdicionalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(587, 277);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(114, 18);
            this.lblPercentualDesconto.TabIndex = 8;
            this.lblPercentualDesconto.Text = "% de Desconto:";
            this.lblPercentualDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPercentualDesconto
            // 
            this.txtPercentualDesconto.ForeColor = System.Drawing.Color.Red;
            this.txtPercentualDesconto.Location = new System.Drawing.Point(707, 278);
            this.txtPercentualDesconto.Name = "txtPercentualDesconto";
            this.txtPercentualDesconto.ReadOnly = true;
            this.txtPercentualDesconto.Size = new System.Drawing.Size(135, 20);
            this.txtPercentualDesconto.TabIndex = 9;
            this.txtPercentualDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorDescontoTotal
            // 
            this.lblValorDescontoTotal.AutoSize = true;
            this.lblValorDescontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDescontoTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorDescontoTotal.Location = new System.Drawing.Point(586, 332);
            this.lblValorDescontoTotal.Name = "lblValorDescontoTotal";
            this.lblValorDescontoTotal.Size = new System.Drawing.Size(115, 18);
            this.lblValorDescontoTotal.TabIndex = 10;
            this.lblValorDescontoTotal.Text = "Valor Desconto:";
            this.lblValorDescontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorDescontoTotal
            // 
            this.txtValorDescontoTotal.ForeColor = System.Drawing.Color.Red;
            this.txtValorDescontoTotal.Location = new System.Drawing.Point(707, 332);
            this.txtValorDescontoTotal.Name = "txtValorDescontoTotal";
            this.txtValorDescontoTotal.ReadOnly = true;
            this.txtValorDescontoTotal.Size = new System.Drawing.Size(135, 20);
            this.txtValorDescontoTotal.TabIndex = 11;
            this.txtValorDescontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(621, 409);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(117, 24);
            this.lblValorTotal.TabIndex = 12;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(594, 453);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(179, 26);
            this.txtValorTotal.TabIndex = 13;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTextoMaodeObra
            // 
            this.lblTextoMaodeObra.AutoSize = true;
            this.lblTextoMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoMaodeObra.Location = new System.Drawing.Point(159, 23);
            this.lblTextoMaodeObra.Name = "lblTextoMaodeObra";
            this.lblTextoMaodeObra.Size = new System.Drawing.Size(132, 24);
            this.lblTextoMaodeObra.TabIndex = 14;
            this.lblTextoMaodeObra.Text = "Mão de Obra";
            // 
            // lblTextoPecaProduto
            // 
            this.lblTextoPecaProduto.AutoSize = true;
            this.lblTextoPecaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoPecaProduto.Location = new System.Drawing.Point(159, 264);
            this.lblTextoPecaProduto.Name = "lblTextoPecaProduto";
            this.lblTextoPecaProduto.Size = new System.Drawing.Size(156, 24);
            this.lblTextoPecaProduto.TabIndex = 15;
            this.lblTextoPecaProduto.Text = "Peças/Produtos";
            // 
            // lblServicoId
            // 
            this.lblServicoId.AutoSize = true;
            this.lblServicoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicoId.Location = new System.Drawing.Point(524, 23);
            this.lblServicoId.Name = "lblServicoId";
            this.lblServicoId.Size = new System.Drawing.Size(131, 24);
            this.lblServicoId.TabIndex = 16;
            this.lblServicoId.Text = "Nº do Serviço:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(733, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDetalhesServicoGerado
            // 
            this.ClientSize = new System.Drawing.Size(887, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblServicoId);
            this.Controls.Add(this.lblTextoPecaProduto);
            this.Controls.Add(this.lblTextoMaodeObra);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txtValorDescontoTotal);
            this.Controls.Add(this.dgvMaodeObraServicoGerado);
            this.Controls.Add(this.lblValorDescontoTotal);
            this.Controls.Add(this.dgvPecasServicosGerados);
            this.Controls.Add(this.txtPercentualDesconto);
            this.Controls.Add(this.lblValorMaodeObra);
            this.Controls.Add(this.lblPercentualDesconto);
            this.Controls.Add(this.txtValorMaodeObraTotal);
            this.Controls.Add(this.lblValorAdicionalTotal);
            this.Controls.Add(this.lblValorProdutosPecasTotal);
            this.Controls.Add(this.txtValorAdicionalTotal);
            this.Controls.Add(this.txtValorProdutosPecasTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetalhesServicoGerado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecânica - Detalhe de Serviço Gerado pelo Cliente";
            this.Load += new System.EventHandler(this.FrmDetalhesServicoGerado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecasServicosGerados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaodeObraServicoGerado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaodeObraServicoGerado;
        private System.Windows.Forms.DataGridView dgvPecasServicosGerados;
        private System.Windows.Forms.TextBox txtValorProdutosPecasTotal;
        private System.Windows.Forms.Label lblValorProdutosPecasTotal;
        private System.Windows.Forms.TextBox txtValorMaodeObraTotal;
        private System.Windows.Forms.Label lblValorMaodeObra;
        private System.Windows.Forms.TextBox txtValorDescontoTotal;
        private System.Windows.Forms.Label lblValorDescontoTotal;
        private System.Windows.Forms.TextBox txtPercentualDesconto;
        private System.Windows.Forms.Label lblPercentualDesconto;
        private System.Windows.Forms.Label lblValorAdicionalTotal;
        private System.Windows.Forms.TextBox txtValorAdicionalTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTextoMaodeObra;
        private System.Windows.Forms.Label lblTextoPecaProduto;
        private System.Windows.Forms.Label lblServicoId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
