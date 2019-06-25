namespace GUI
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblSobreNomeSistema = new System.Windows.Forms.Label();
            this.lblSobreVersao = new System.Windows.Forms.Label();
            this.lblSobreAno = new System.Windows.Forms.Label();
            this.lblSobreCriador = new System.Windows.Forms.Label();
            this.lblSobreBancoDeDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSobreNomeSistema
            // 
            this.lblSobreNomeSistema.AutoSize = true;
            this.lblSobreNomeSistema.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNomeSistema.Location = new System.Drawing.Point(22, 32);
            this.lblSobreNomeSistema.Name = "lblSobreNomeSistema";
            this.lblSobreNomeSistema.Size = new System.Drawing.Size(208, 16);
            this.lblSobreNomeSistema.TabIndex = 0;
            this.lblSobreNomeSistema.Text = "Sistema Gerenciamento Mecânica";
            // 
            // lblSobreVersao
            // 
            this.lblSobreVersao.AutoSize = true;
            this.lblSobreVersao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreVersao.Location = new System.Drawing.Point(85, 60);
            this.lblSobreVersao.Name = "lblSobreVersao";
            this.lblSobreVersao.Size = new System.Drawing.Size(70, 16);
            this.lblSobreVersao.TabIndex = 1;
            this.lblSobreVersao.Text = "Versão 1.0";
            // 
            // lblSobreAno
            // 
            this.lblSobreAno.AutoSize = true;
            this.lblSobreAno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreAno.Location = new System.Drawing.Point(102, 87);
            this.lblSobreAno.Name = "lblSobreAno";
            this.lblSobreAno.Size = new System.Drawing.Size(36, 16);
            this.lblSobreAno.TabIndex = 2;
            this.lblSobreAno.Text = "2019";
            // 
            // lblSobreCriador
            // 
            this.lblSobreCriador.AutoSize = true;
            this.lblSobreCriador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreCriador.Location = new System.Drawing.Point(33, 144);
            this.lblSobreCriador.Name = "lblSobreCriador";
            this.lblSobreCriador.Size = new System.Drawing.Size(185, 16);
            this.lblSobreCriador.TabIndex = 3;
            this.lblSobreCriador.Text = "Desenvolvedor: Ariel Giacomini";
            // 
            // lblSobreBancoDeDados
            // 
            this.lblSobreBancoDeDados.AutoSize = true;
            this.lblSobreBancoDeDados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreBancoDeDados.Location = new System.Drawing.Point(47, 116);
            this.lblSobreBancoDeDados.Name = "lblSobreBancoDeDados";
            this.lblSobreBancoDeDados.Size = new System.Drawing.Size(152, 16);
            this.lblSobreBancoDeDados.TabIndex = 4;
            this.lblSobreBancoDeDados.Text = "Banco de Dados: SQLite";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 196);
            this.Controls.Add(this.lblSobreBancoDeDados);
            this.Controls.Add(this.lblSobreCriador);
            this.Controls.Add(this.lblSobreAno);
            this.Controls.Add(this.lblSobreVersao);
            this.Controls.Add(this.lblSobreNomeSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSobreNomeSistema;
        private System.Windows.Forms.Label lblSobreVersao;
        private System.Windows.Forms.Label lblSobreAno;
        private System.Windows.Forms.Label lblSobreCriador;
        private System.Windows.Forms.Label lblSobreBancoDeDados;
    }
}