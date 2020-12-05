namespace SGM.WindowsForms
{
    partial class FrmConsultaOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaOrcamento));
            this.txtPlacaClienteVeiculoConsulta = new System.Windows.Forms.TextBox();
            this.lblPlacaClienteVeiculoConsulta = new System.Windows.Forms.Label();
            this.dgvOrcamentoHistoricoClienteVeiculo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlacaClienteVeiculoConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentoHistoricoClienteVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlacaClienteVeiculoConsulta
            // 
            this.txtPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(11, 40);
            this.txtPlacaClienteVeiculoConsulta.Name = "txtPlacaClienteVeiculoConsulta";
            this.txtPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(594, 20);
            this.txtPlacaClienteVeiculoConsulta.TabIndex = 42;
            // 
            // lblPlacaClienteVeiculoConsulta
            // 
            this.lblPlacaClienteVeiculoConsulta.AutoSize = true;
            this.lblPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(11, 21);
            this.lblPlacaClienteVeiculoConsulta.Name = "lblPlacaClienteVeiculoConsulta";
            this.lblPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(161, 13);
            this.lblPlacaClienteVeiculoConsulta.TabIndex = 41;
            this.lblPlacaClienteVeiculoConsulta.Text = "Busque pela PLACA do Veículo:";
            // 
            // dgvOrcamentoHistoricoClienteVeiculo
            // 
            this.dgvOrcamentoHistoricoClienteVeiculo.AllowUserToAddRows = false;
            this.dgvOrcamentoHistoricoClienteVeiculo.AllowUserToDeleteRows = false;
            this.dgvOrcamentoHistoricoClienteVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamentoHistoricoClienteVeiculo.Location = new System.Drawing.Point(11, 75);
            this.dgvOrcamentoHistoricoClienteVeiculo.Name = "dgvOrcamentoHistoricoClienteVeiculo";
            this.dgvOrcamentoHistoricoClienteVeiculo.ReadOnly = true;
            this.dgvOrcamentoHistoricoClienteVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamentoHistoricoClienteVeiculo.Size = new System.Drawing.Size(760, 472);
            this.dgvOrcamentoHistoricoClienteVeiculo.TabIndex = 40;
            this.dgvOrcamentoHistoricoClienteVeiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrcamentoHistoricoClienteVeiculo_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(356, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlacaClienteVeiculoConsulta
            // 
            this.btnPlacaClienteVeiculoConsulta.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnPlacaClienteVeiculoConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(611, 33);
            this.btnPlacaClienteVeiculoConsulta.Name = "btnPlacaClienteVeiculoConsulta";
            this.btnPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(160, 27);
            this.btnPlacaClienteVeiculoConsulta.TabIndex = 43;
            this.btnPlacaClienteVeiculoConsulta.Text = "Consultar";
            this.btnPlacaClienteVeiculoConsulta.UseVisualStyleBackColor = true;
            this.btnPlacaClienteVeiculoConsulta.Click += new System.EventHandler(this.BtnPlacaClienteVeiculoConsulta_Click);
            // 
            // frmConsultaHistoricoOrcamentoClienteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.txtPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.lblPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.dgvOrcamentoHistoricoClienteVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaHistoricoOrcamentoClienteVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecãnica - Consulta de Histórico de Orçamentos";
            this.Load += new System.EventHandler(this.FrmConsultaHistoricoOrcamentoClienteVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentoHistoricoClienteVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.TextBox txtPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.Label lblPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.DataGridView dgvOrcamentoHistoricoClienteVeiculo;
    }
}