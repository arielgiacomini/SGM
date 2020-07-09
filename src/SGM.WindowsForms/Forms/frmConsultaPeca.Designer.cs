namespace SGM.WindowsForms
{
    partial class frmConsultaPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPeca));
            this.dgvConsultaPeca = new System.Windows.Forms.DataGridView();
            this.btnConsultaPeca = new System.Windows.Forms.Button();
            this.txtConsultaPeca = new System.Windows.Forms.TextBox();
            this.lblConsultaPeca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaPeca
            // 
            this.dgvConsultaPeca.AllowUserToAddRows = false;
            this.dgvConsultaPeca.AllowUserToDeleteRows = false;
            this.dgvConsultaPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPeca.Location = new System.Drawing.Point(12, 71);
            this.dgvConsultaPeca.Name = "dgvConsultaPeca";
            this.dgvConsultaPeca.ReadOnly = true;
            this.dgvConsultaPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaPeca.Size = new System.Drawing.Size(760, 472);
            this.dgvConsultaPeca.TabIndex = 11;
            this.dgvConsultaPeca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPeca_CellDoubleClick);
            // 
            // btnConsultaPeca
            // 
            this.btnConsultaPeca.Image = global::SGM.WindowsForms.Properties.Resources.LocalicarRedimensionado3;
            this.btnConsultaPeca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaPeca.Location = new System.Drawing.Point(612, 30);
            this.btnConsultaPeca.Name = "btnConsultaPeca";
            this.btnConsultaPeca.Size = new System.Drawing.Size(160, 27);
            this.btnConsultaPeca.TabIndex = 10;
            this.btnConsultaPeca.Text = "Consultar";
            this.btnConsultaPeca.UseVisualStyleBackColor = true;
            this.btnConsultaPeca.Click += new System.EventHandler(this.btnConsultaPeca_Click);
            // 
            // txtConsultaPeca
            // 
            this.txtConsultaPeca.Location = new System.Drawing.Point(12, 34);
            this.txtConsultaPeca.Name = "txtConsultaPeca";
            this.txtConsultaPeca.Size = new System.Drawing.Size(594, 20);
            this.txtConsultaPeca.TabIndex = 9;
            // 
            // lblConsultaPeca
            // 
            this.lblConsultaPeca.AutoSize = true;
            this.lblConsultaPeca.Location = new System.Drawing.Point(13, 18);
            this.lblConsultaPeca.Name = "lblConsultaPeca";
            this.lblConsultaPeca.Size = new System.Drawing.Size(163, 13);
            this.lblConsultaPeca.TabIndex = 8;
            this.lblConsultaPeca.Text = "Digite o nome da Peça/Produto: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGM.WindowsForms.Properties.Resources.LogotipoLoquinho;
            this.pictureBox1.Location = new System.Drawing.Point(323, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultaPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvConsultaPeca);
            this.Controls.Add(this.btnConsultaPeca);
            this.Controls.Add(this.txtConsultaPeca);
            this.Controls.Add(this.lblConsultaPeca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciamento Mecânica - Consulta de Peças/Produtos";
            this.Load += new System.EventHandler(this.frmConsultaPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaPeca;
        private System.Windows.Forms.Button btnConsultaPeca;
        private System.Windows.Forms.TextBox txtConsultaPeca;
        private System.Windows.Forms.Label lblConsultaPeca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}