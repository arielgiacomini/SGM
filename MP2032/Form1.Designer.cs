namespace MP2032
{
    partial class frmFuncionalidadesImpressora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnModeloImpressora = new System.Windows.Forms.Button();
            this.btnPortaImpressora = new System.Windows.Forms.Button();
            this.btnGuilhotinaImpressora = new System.Windows.Forms.Button();
            this.btnGavetaImpressora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(271, 72);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 23);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnModeloImpressora
            // 
            this.btnModeloImpressora.Location = new System.Drawing.Point(12, 72);
            this.btnModeloImpressora.Name = "btnModeloImpressora";
            this.btnModeloImpressora.Size = new System.Drawing.Size(126, 23);
            this.btnModeloImpressora.TabIndex = 1;
            this.btnModeloImpressora.Text = "Modelo da Impressora";
            this.btnModeloImpressora.UseVisualStyleBackColor = true;
            this.btnModeloImpressora.Click += new System.EventHandler(this.btnModeloImpressora_Click);
            // 
            // btnPortaImpressora
            // 
            this.btnPortaImpressora.Location = new System.Drawing.Point(144, 72);
            this.btnPortaImpressora.Name = "btnPortaImpressora";
            this.btnPortaImpressora.Size = new System.Drawing.Size(121, 23);
            this.btnPortaImpressora.TabIndex = 2;
            this.btnPortaImpressora.Text = "Porta da Impressora";
            this.btnPortaImpressora.UseVisualStyleBackColor = true;
            this.btnPortaImpressora.Click += new System.EventHandler(this.btnPortaImpressora_Click);
            // 
            // btnGuilhotinaImpressora
            // 
            this.btnGuilhotinaImpressora.Location = new System.Drawing.Point(353, 72);
            this.btnGuilhotinaImpressora.Name = "btnGuilhotinaImpressora";
            this.btnGuilhotinaImpressora.Size = new System.Drawing.Size(141, 23);
            this.btnGuilhotinaImpressora.TabIndex = 3;
            this.btnGuilhotinaImpressora.Text = "Guilhotina da Impressora";
            this.btnGuilhotinaImpressora.UseVisualStyleBackColor = true;
            this.btnGuilhotinaImpressora.Click += new System.EventHandler(this.btnGuilhotinaImpressora_Click);
            // 
            // btnGavetaImpressora
            // 
            this.btnGavetaImpressora.Location = new System.Drawing.Point(501, 72);
            this.btnGavetaImpressora.Name = "btnGavetaImpressora";
            this.btnGavetaImpressora.Size = new System.Drawing.Size(128, 23);
            this.btnGavetaImpressora.TabIndex = 4;
            this.btnGavetaImpressora.Text = "Gaveta da Impressora";
            this.btnGavetaImpressora.UseVisualStyleBackColor = true;
            this.btnGavetaImpressora.Click += new System.EventHandler(this.btnGavetaImpressora_Click);
            // 
            // frmFuncionalidadesImpressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 199);
            this.Controls.Add(this.btnGavetaImpressora);
            this.Controls.Add(this.btnGuilhotinaImpressora);
            this.Controls.Add(this.btnPortaImpressora);
            this.Controls.Add(this.btnModeloImpressora);
            this.Controls.Add(this.btnImprimir);
            this.Name = "frmFuncionalidadesImpressora";
            this.Text = "Funcionalidades da Impressora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModeloImpressora;
        private System.Windows.Forms.Button btnPortaImpressora;
        private System.Windows.Forms.Button btnGuilhotinaImpressora;
        private System.Windows.Forms.Button btnGavetaImpressora;
    }
}

