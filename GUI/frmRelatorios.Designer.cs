namespace GUI
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.btnConsolidadoDiario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsolidadoDiario
            // 
            this.btnConsolidadoDiario.Location = new System.Drawing.Point(43, 44);
            this.btnConsolidadoDiario.Name = "btnConsolidadoDiario";
            this.btnConsolidadoDiario.Size = new System.Drawing.Size(128, 23);
            this.btnConsolidadoDiario.TabIndex = 0;
            this.btnConsolidadoDiario.Text = "Consolidado Diário";
            this.btnConsolidadoDiario.UseVisualStyleBackColor = true;
            this.btnConsolidadoDiario.Click += new System.EventHandler(this.btnConsolidadoDiario_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnConsolidadoDiario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecânica - Emissões de Relaórios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsolidadoDiario;
    }
}