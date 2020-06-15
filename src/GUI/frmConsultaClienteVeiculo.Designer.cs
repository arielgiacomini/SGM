namespace GUI
{
    partial class frmConsultaClienteVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaClienteVeiculo));
            this.dgvClienteVeiculoConsulta = new System.Windows.Forms.DataGridView();
            this.txtPlacaClienteVeiculoConsulta = new System.Windows.Forms.TextBox();
            this.lblPlacaClienteVeiculoConsulta = new System.Windows.Forms.Label();
            this.btnPlacaClienteVeiculoConsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteVeiculoConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienteVeiculoConsulta
            // 
            this.dgvClienteVeiculoConsulta.AllowUserToAddRows = false;
            this.dgvClienteVeiculoConsulta.AllowUserToDeleteRows = false;
            this.dgvClienteVeiculoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteVeiculoConsulta.Location = new System.Drawing.Point(12, 71);
            this.dgvClienteVeiculoConsulta.Name = "dgvClienteVeiculoConsulta";
            this.dgvClienteVeiculoConsulta.ReadOnly = true;
            this.dgvClienteVeiculoConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienteVeiculoConsulta.Size = new System.Drawing.Size(760, 472);
            this.dgvClienteVeiculoConsulta.TabIndex = 7;
            this.dgvClienteVeiculoConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteVeiculoConsulta_CellDoubleClick);
            // 
            // txtPlacaClienteVeiculoConsulta
            // 
            this.txtPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(12, 34);
            this.txtPlacaClienteVeiculoConsulta.Name = "txtPlacaClienteVeiculoConsulta";
            this.txtPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(594, 20);
            this.txtPlacaClienteVeiculoConsulta.TabIndex = 5;
            // 
            // lblPlacaClienteVeiculoConsulta
            // 
            this.lblPlacaClienteVeiculoConsulta.AutoSize = true;
            this.lblPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(13, 18);
            this.lblPlacaClienteVeiculoConsulta.Name = "lblPlacaClienteVeiculoConsulta";
            this.lblPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(209, 13);
            this.lblPlacaClienteVeiculoConsulta.TabIndex = 4;
            this.lblPlacaClienteVeiculoConsulta.Text = "Digite: Placa, Veículo ou Nome do Cliente:";
            // 
            // btnPlacaClienteVeiculoConsulta
            // 
            this.btnPlacaClienteVeiculoConsulta.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnPlacaClienteVeiculoConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlacaClienteVeiculoConsulta.Location = new System.Drawing.Point(612, 30);
            this.btnPlacaClienteVeiculoConsulta.Name = "btnPlacaClienteVeiculoConsulta";
            this.btnPlacaClienteVeiculoConsulta.Size = new System.Drawing.Size(160, 27);
            this.btnPlacaClienteVeiculoConsulta.TabIndex = 6;
            this.btnPlacaClienteVeiculoConsulta.Text = "Consultar";
            this.btnPlacaClienteVeiculoConsulta.UseVisualStyleBackColor = true;
            this.btnPlacaClienteVeiculoConsulta.Click += new System.EventHandler(this.BtnPlacaClienteVeiculoConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(335, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaClienteVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvClienteVeiculoConsulta);
            this.Controls.Add(this.btnPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.txtPlacaClienteVeiculoConsulta);
            this.Controls.Add(this.lblPlacaClienteVeiculoConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaClienteVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciamento Mecânica - Consulta Veículos dos Clientes";
            this.Load += new System.EventHandler(this.FrmConsultaClienteVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteVeiculoConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteVeiculoConsulta;
        private System.Windows.Forms.Button btnPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.TextBox txtPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.Label lblPlacaClienteVeiculoConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}