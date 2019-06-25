namespace GUI
{
    partial class frmConsultaGerarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaGerarOrcamento));
            this.dgvConsultaOrcamentoGerados = new System.Windows.Forms.DataGridView();
            this.btnConsultaOrcamentosGerados = new System.Windows.Forms.Button();
            this.txtConsultaOrcamentosGerados = new System.Windows.Forms.TextBox();
            this.lblConsultaMaoDeObra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaOrcamentoGerados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaOrcamentoGerados
            // 
            this.dgvConsultaOrcamentoGerados.AllowUserToAddRows = false;
            this.dgvConsultaOrcamentoGerados.AllowUserToDeleteRows = false;
            this.dgvConsultaOrcamentoGerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaOrcamentoGerados.Location = new System.Drawing.Point(12, 71);
            this.dgvConsultaOrcamentoGerados.Name = "dgvConsultaOrcamentoGerados";
            this.dgvConsultaOrcamentoGerados.ReadOnly = true;
            this.dgvConsultaOrcamentoGerados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaOrcamentoGerados.Size = new System.Drawing.Size(760, 472);
            this.dgvConsultaOrcamentoGerados.TabIndex = 19;
            this.dgvConsultaOrcamentoGerados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaOrcamentoGerados_CellDoubleClick);
            // 
            // btnConsultaOrcamentosGerados
            // 
            this.btnConsultaOrcamentosGerados.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnConsultaOrcamentosGerados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaOrcamentosGerados.Location = new System.Drawing.Point(612, 30);
            this.btnConsultaOrcamentosGerados.Name = "btnConsultaOrcamentosGerados";
            this.btnConsultaOrcamentosGerados.Size = new System.Drawing.Size(160, 27);
            this.btnConsultaOrcamentosGerados.TabIndex = 18;
            this.btnConsultaOrcamentosGerados.Text = "Consultar";
            this.btnConsultaOrcamentosGerados.UseVisualStyleBackColor = true;
            this.btnConsultaOrcamentosGerados.Click += new System.EventHandler(this.btnConsultaOrcamentosGerados_Click);
            // 
            // txtConsultaOrcamentosGerados
            // 
            this.txtConsultaOrcamentosGerados.Location = new System.Drawing.Point(12, 34);
            this.txtConsultaOrcamentosGerados.Name = "txtConsultaOrcamentosGerados";
            this.txtConsultaOrcamentosGerados.Size = new System.Drawing.Size(594, 20);
            this.txtConsultaOrcamentosGerados.TabIndex = 17;
            // 
            // lblConsultaMaoDeObra
            // 
            this.lblConsultaMaoDeObra.AutoSize = true;
            this.lblConsultaMaoDeObra.Location = new System.Drawing.Point(13, 18);
            this.lblConsultaMaoDeObra.Name = "lblConsultaMaoDeObra";
            this.lblConsultaMaoDeObra.Size = new System.Drawing.Size(227, 13);
            this.lblConsultaMaoDeObra.TabIndex = 16;
            this.lblConsultaMaoDeObra.Text = "Digite o nome do cliente/apelido ou descrição:";
            // 
            // frmConsultaGerarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvConsultaOrcamentoGerados);
            this.Controls.Add(this.btnConsultaOrcamentosGerados);
            this.Controls.Add(this.txtConsultaOrcamentosGerados);
            this.Controls.Add(this.lblConsultaMaoDeObra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaGerarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecânica - Consulta de Orçamentos Gerados";
            this.Load += new System.EventHandler(this.frmConsultaGerarOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaOrcamentoGerados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaOrcamentoGerados;
        private System.Windows.Forms.Button btnConsultaOrcamentosGerados;
        private System.Windows.Forms.TextBox txtConsultaOrcamentosGerados;
        private System.Windows.Forms.Label lblConsultaMaoDeObra;
    }
}