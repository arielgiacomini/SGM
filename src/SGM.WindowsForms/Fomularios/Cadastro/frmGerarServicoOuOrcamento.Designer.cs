namespace SGM.WindowsForms
{
    partial class FrmGerarServicoOuOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerarServicoOuOrcamento));
            this.btnRealizaOrcamento = new System.Windows.Forms.Button();
            this.btnRealizaMaoDeObra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRealizaOrcamento
            // 
            this.btnRealizaOrcamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizaOrcamento.Image = global::SGM.WindowsForms.Properties.Resources._3925433_budget_money_stocks_icon_111559;
            this.btnRealizaOrcamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizaOrcamento.Location = new System.Drawing.Point(41, 23);
            this.btnRealizaOrcamento.Name = "btnRealizaOrcamento";
            this.btnRealizaOrcamento.Size = new System.Drawing.Size(153, 188);
            this.btnRealizaOrcamento.TabIndex = 5;
            this.btnRealizaOrcamento.Text = "Realizar Orçamento";
            this.btnRealizaOrcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizaOrcamento.UseVisualStyleBackColor = true;
            this.btnRealizaOrcamento.Click += new System.EventHandler(this.BtnRealizaOrcamento_Click);
            // 
            // btnRealizaMaoDeObra
            // 
            this.btnRealizaMaoDeObra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizaMaoDeObra.Image = global::SGM.WindowsForms.Properties.Resources.cashier_icon_icons_com_53629;
            this.btnRealizaMaoDeObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizaMaoDeObra.Location = new System.Drawing.Point(251, 23);
            this.btnRealizaMaoDeObra.Name = "btnRealizaMaoDeObra";
            this.btnRealizaMaoDeObra.Size = new System.Drawing.Size(153, 188);
            this.btnRealizaMaoDeObra.TabIndex = 6;
            this.btnRealizaMaoDeObra.Text = "Realizar Serviço";
            this.btnRealizaMaoDeObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizaMaoDeObra.UseVisualStyleBackColor = true;
            this.btnRealizaMaoDeObra.Click += new System.EventHandler(this.BtnRealizaMaoDeObra_Click);
            // 
            // frmPerguntaQualItemAbrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 240);
            this.Controls.Add(this.btnRealizaMaoDeObra);
            this.Controls.Add(this.btnRealizaOrcamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerguntaQualItemAbrir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecânica - O que deseja fazer?";
            this.Load += new System.EventHandler(this.FrmPerguntaQualItemAbrir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRealizaOrcamento;
        private System.Windows.Forms.Button btnRealizaMaoDeObra;
    }
}