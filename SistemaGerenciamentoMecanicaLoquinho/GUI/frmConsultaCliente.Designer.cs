namespace GUI
{
    partial class frmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCliente));
            this.dgvConsultCliente = new System.Windows.Forms.DataGridView();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultCliente
            // 
            this.dgvConsultCliente.AllowUserToAddRows = false;
            this.dgvConsultCliente.AllowUserToDeleteRows = false;
            this.dgvConsultCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultCliente.Location = new System.Drawing.Point(12, 71);
            this.dgvConsultCliente.Name = "dgvConsultCliente";
            this.dgvConsultCliente.ReadOnly = true;
            this.dgvConsultCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultCliente.Size = new System.Drawing.Size(760, 472);
            this.dgvConsultCliente.TabIndex = 7;
            this.dgvConsultCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultCliente_CellDoubleClick);
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(12, 34);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(594, 20);
            this.txtConsultaCliente.TabIndex = 5;
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Location = new System.Drawing.Point(13, 18);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(165, 13);
            this.lblConsultaCliente.TabIndex = 4;
            this.lblConsultaCliente.Text = "Digite o Nome ou CPF do Cliente:";
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Image = global::GUI.Properties.Resources.LocalicarRedimensionado3;
            this.btnConsultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCliente.Location = new System.Drawing.Point(612, 30);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(160, 27);
            this.btnConsultaCliente.TabIndex = 6;
            this.btnConsultaCliente.Text = "Consultar";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvConsultCliente);
            this.Controls.Add(this.btnConsultaCliente);
            this.Controls.Add(this.txtConsultaCliente);
            this.Controls.Add(this.lblConsultaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultCliente;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Label lblConsultaCliente;
    }
}