namespace GUI
{
    partial class frmConsultaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVeiculo));
            this.lblModeloMarca = new System.Windows.Forms.Label();
            this.txtModeloMarcaConsulta = new System.Windows.Forms.TextBox();
            this.dgvModeloMarcaConsulta = new System.Windows.Forms.DataGridView();
            this.btnModeloMarcaConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeloMarcaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModeloMarca
            // 
            this.lblModeloMarca.AutoSize = true;
            this.lblModeloMarca.Location = new System.Drawing.Point(13, 24);
            this.lblModeloMarca.Name = "lblModeloMarca";
            this.lblModeloMarca.Size = new System.Drawing.Size(198, 13);
            this.lblModeloMarca.TabIndex = 0;
            this.lblModeloMarca.Text = "Digite um Modelo ou Marca de Veículo: ";
            // 
            // txtModeloMarcaConsulta
            // 
            this.txtModeloMarcaConsulta.Location = new System.Drawing.Point(12, 40);
            this.txtModeloMarcaConsulta.Name = "txtModeloMarcaConsulta";
            this.txtModeloMarcaConsulta.Size = new System.Drawing.Size(594, 20);
            this.txtModeloMarcaConsulta.TabIndex = 1;
            // 
            // dgvModeloMarcaConsulta
            // 
            this.dgvModeloMarcaConsulta.AllowUserToAddRows = false;
            this.dgvModeloMarcaConsulta.AllowUserToDeleteRows = false;
            this.dgvModeloMarcaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeloMarcaConsulta.Location = new System.Drawing.Point(12, 77);
            this.dgvModeloMarcaConsulta.Name = "dgvModeloMarcaConsulta";
            this.dgvModeloMarcaConsulta.ReadOnly = true;
            this.dgvModeloMarcaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModeloMarcaConsulta.Size = new System.Drawing.Size(760, 472);
            this.dgvModeloMarcaConsulta.TabIndex = 3;
            this.dgvModeloMarcaConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModeloMarcaConsulta_CellDoubleClick);
            // 
            // btnModeloMarcaConsulta
            // 
            this.btnModeloMarcaConsulta.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnModeloMarcaConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModeloMarcaConsulta.Location = new System.Drawing.Point(612, 36);
            this.btnModeloMarcaConsulta.Name = "btnModeloMarcaConsulta";
            this.btnModeloMarcaConsulta.Size = new System.Drawing.Size(160, 27);
            this.btnModeloMarcaConsulta.TabIndex = 2;
            this.btnModeloMarcaConsulta.Text = "Consultar";
            this.btnModeloMarcaConsulta.UseVisualStyleBackColor = true;
            this.btnModeloMarcaConsulta.Click += new System.EventHandler(this.btnModeloMarcaConsulta_Click);
            // 
            // frmConsultaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvModeloMarcaConsulta);
            this.Controls.Add(this.btnModeloMarcaConsulta);
            this.Controls.Add(this.txtModeloMarcaConsulta);
            this.Controls.Add(this.lblModeloMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciamento Mecânica - Consulta Veiculos";
            this.Load += new System.EventHandler(this.frmConsultaVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeloMarcaConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeloMarca;
        private System.Windows.Forms.TextBox txtModeloMarcaConsulta;
        private System.Windows.Forms.Button btnModeloMarcaConsulta;
        private System.Windows.Forms.DataGridView dgvModeloMarcaConsulta;
    }
}