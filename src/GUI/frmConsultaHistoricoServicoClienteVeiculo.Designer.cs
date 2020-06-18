namespace GUI
{
    partial class FrmConsultaHistoricoServicoClienteVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaHistoricoServicoClienteVeiculo));
            this.dgvServicoHistoricoClienteVeiculo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlacaClienteVeiculoConsulta = new System.Windows.Forms.Button();
            this.txtPlacaClienteVeiculoConsulta = new System.Windows.Forms.TextBox();
            this.lblPlacaClienteVeiculoConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicoHistoricoClienteVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicoHistoricoClienteVeiculo
            // 
            this.dgvServicoHistoricoClienteVeiculo.AllowUserToAddRows = false;
            this.dgvServicoHistoricoClienteVeiculo.AllowUserToDeleteRows = false;
            this.dgvServicoHistoricoClienteVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicoHistoricoClienteVeiculo.Location = new System.Drawing.Point(11, 81);
            this.dgvServicoHistoricoClienteVeiculo.Name = "dgvServicoHistoricoClienteVeiculo";
            this.dgvServicoHistoricoClienteVeiculo.ReadOnly = true;
            this.dgvServicoHistoricoClienteVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicoHistoricoClienteVeiculo.Size = new System.Drawing.Size(760, 472);
            this.dgvServicoHistoricoClienteVeiculo.TabIndex = 8;
            this.dgvServicoHistoricoClienteVeiculo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvServicoHistoricoClienteVeiculo_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(357, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlacaClienteVeiculoConsulta
            // 
            this.btnPlacaClienteVeiculoConsulta.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnPlacaClienteVeiculoConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(612, 41);
            this.btnPlacaClienteVeiculoConsulta.Name = "btnPlacaClienteVeiculoConsulta";
            this.btnPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(160, 27);
            this.btnPlacaClienteVeiculoConsulta.TabIndex = 38;
            this.btnPlacaClienteVeiculoConsulta.Text = "Consultar";
            this.btnPlacaClienteVeiculoConsulta.UseVisualStyleBackColor = true;
            this.btnPlacaClienteVeiculoConsulta.Click += new System.EventHandler(this.BtnPlacaClienteVeiculoConsulta_Click);
            // 
            // txtPlacaClienteVeiculoConsulta
            // 
            this.txtPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(12, 45);
            this.txtPlacaClienteVeiculoConsulta.Name = "txtPlacaClienteVeiculoConsulta";
            this.txtPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(594, 20);
            this.txtPlacaClienteVeiculoConsulta.TabIndex = 37;
            // 
            // lblPlacaClienteVeiculoConsulta
            // 
            this.lblPlacaClienteVeiculoConsulta.AutoSize = true;
            this.lblPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(13, 29);
            this.lblPlacaClienteVeiculoConsulta.Name = "lblPlacaClienteVeiculoConsulta";
            this.lblPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(161, 13);
            this.lblPlacaClienteVeiculoConsulta.TabIndex = 36;
            this.lblPlacaClienteVeiculoConsulta.Text = "Busque pela PLACA do Veículo:";
            // 
            // FrmConsultaHistoricoServicoClienteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.txtPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.lblPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.dgvServicoHistoricoClienteVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaHistoricoServicoClienteVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecãnica - Consulta de Histórico de Serviços";
            this.Load += new System.EventHandler(this.FrmConsultaHistoricoServicoClienteVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicoHistoricoClienteVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicoHistoricoClienteVeiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.TextBox txtPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.Label lblPlacaClienteVeiculoConsulta;
    }
}