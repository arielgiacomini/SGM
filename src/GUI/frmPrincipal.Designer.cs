namespace GUI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mãoDeObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mãoDeObraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizaMãodeObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizaNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimeNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimeOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimeMãoDeObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrincipalEmitirNotas = new System.Windows.Forms.Button();
            this.btnPrincipalCadastroCliente = new System.Windows.Forms.Button();
            this.btnPrincipalOrcamento = new System.Windows.Forms.Button();
            this.btnPrincipalRealizaMaoDeObra = new System.Windows.Forms.Button();
            this.btnVeiculoCliente = new System.Windows.Forms.Button();
            this.lblVersionSystem = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculosToolStripMenuItem,
            this.mãoDeObraToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.toolStripSeparator1,
            this.clienteToolStripMenuItem,
            this.clienteVeículosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Image = global::GUI.Properties.Resources.Cabriolet_Red_icon_icons_com_54906;
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.VeiculosToolStripMenuItem_Click);
            // 
            // mãoDeObraToolStripMenuItem
            // 
            this.mãoDeObraToolStripMenuItem.Image = global::GUI.Properties.Resources.cashier_icon_icons_com_53629;
            this.mãoDeObraToolStripMenuItem.Name = "mãoDeObraToolStripMenuItem";
            this.mãoDeObraToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mãoDeObraToolStripMenuItem.Text = "Mão-de-Obra/Serviços";
            this.mãoDeObraToolStripMenuItem.Click += new System.EventHandler(this.MaoDeObraToolStripMenuItem_Click);
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Image = global::GUI.Properties.Resources.Yahoo_Widget_Engine_icon;
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.peçasToolStripMenuItem.Text = "Peças/Produtos";
            this.peçasToolStripMenuItem.Click += new System.EventHandler(this.PeçasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::GUI.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // clienteVeículosToolStripMenuItem
            // 
            this.clienteVeículosToolStripMenuItem.Image = global::GUI.Properties.Resources.Travel_BMV_icon;
            this.clienteVeículosToolStripMenuItem.Name = "clienteVeículosToolStripMenuItem";
            this.clienteVeículosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.clienteVeículosToolStripMenuItem.Text = "Cliente e seus Veículos";
            this.clienteVeículosToolStripMenuItem.Click += new System.EventHandler(this.ClienteVeículosToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculoToolStripMenuItem,
            this.mãoDeObraToolStripMenuItem1,
            this.peçasToolStripMenuItem1,
            this.toolStripSeparator2,
            this.clienteToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.VeiculoToolStripMenuItem_Click);
            // 
            // mãoDeObraToolStripMenuItem1
            // 
            this.mãoDeObraToolStripMenuItem1.Name = "mãoDeObraToolStripMenuItem1";
            this.mãoDeObraToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.mãoDeObraToolStripMenuItem1.Text = "Mão de Obra/Serviços";
            this.mãoDeObraToolStripMenuItem1.Click += new System.EventHandler(this.MaoDeObraToolStripMenuItem1_Click);
            // 
            // peçasToolStripMenuItem1
            // 
            this.peçasToolStripMenuItem1.Name = "peçasToolStripMenuItem1";
            this.peçasToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.peçasToolStripMenuItem1.Text = "Peças/Produtos";
            this.peçasToolStripMenuItem1.Click += new System.EventHandler(this.PecasToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.ClienteToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.fornecedorToolStripMenuItem1.Text = "Clientes e seus Veículos";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.FornecedorToolStripMenuItem1_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarOrçamentoToolStripMenuItem,
            this.realizaMãodeObraToolStripMenuItem,
            this.realizaNotaFiscalToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentações";
            this.movimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.MovimentaçãoToolStripMenuItem_Click);
            // 
            // realizarOrçamentoToolStripMenuItem
            // 
            this.realizarOrçamentoToolStripMenuItem.Name = "realizarOrçamentoToolStripMenuItem";
            this.realizarOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.realizarOrçamentoToolStripMenuItem.Text = "Realizar Orçamento";
            this.realizarOrçamentoToolStripMenuItem.Click += new System.EventHandler(this.RealizarOrçamentoToolStripMenuItem_Click);
            // 
            // realizaMãodeObraToolStripMenuItem
            // 
            this.realizaMãodeObraToolStripMenuItem.Name = "realizaMãodeObraToolStripMenuItem";
            this.realizaMãodeObraToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.realizaMãodeObraToolStripMenuItem.Text = "Realizar Serviços";
            this.realizaMãodeObraToolStripMenuItem.Click += new System.EventHandler(this.RealizaMãodeObraToolStripMenuItem_Click);
            // 
            // realizaNotaFiscalToolStripMenuItem
            // 
            this.realizaNotaFiscalToolStripMenuItem.Name = "realizaNotaFiscalToolStripMenuItem";
            this.realizaNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.realizaNotaFiscalToolStripMenuItem.Text = "Realiza Nota Fiscal";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimeNotaFiscalToolStripMenuItem,
            this.imprimeOrçamentoToolStripMenuItem,
            this.imprimeMãoDeObraToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // imprimeNotaFiscalToolStripMenuItem
            // 
            this.imprimeNotaFiscalToolStripMenuItem.Name = "imprimeNotaFiscalToolStripMenuItem";
            this.imprimeNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.imprimeNotaFiscalToolStripMenuItem.Text = "Imprimir Nota Fiscal";
            this.imprimeNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.ImprimeNotaFiscalToolStripMenuItem_Click);
            // 
            // imprimeOrçamentoToolStripMenuItem
            // 
            this.imprimeOrçamentoToolStripMenuItem.Name = "imprimeOrçamentoToolStripMenuItem";
            this.imprimeOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.imprimeOrçamentoToolStripMenuItem.Text = "Imprimir Orçamento";
            // 
            // imprimeMãoDeObraToolStripMenuItem
            // 
            this.imprimeMãoDeObraToolStripMenuItem.Name = "imprimeMãoDeObraToolStripMenuItem";
            this.imprimeMãoDeObraToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.imprimeMãoDeObraToolStripMenuItem.Text = "Imprimir Mão de Obra";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // btnPrincipalEmitirNotas
            // 
            this.btnPrincipalEmitirNotas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalEmitirNotas.Image = global::GUI.Properties.Resources.Sales_report_icon;
            this.btnPrincipalEmitirNotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrincipalEmitirNotas.Location = new System.Drawing.Point(912, 380);
            this.btnPrincipalEmitirNotas.Name = "btnPrincipalEmitirNotas";
            this.btnPrincipalEmitirNotas.Size = new System.Drawing.Size(153, 188);
            this.btnPrincipalEmitirNotas.TabIndex = 7;
            this.btnPrincipalEmitirNotas.Text = "Impressão Relatórios";
            this.btnPrincipalEmitirNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrincipalEmitirNotas.UseVisualStyleBackColor = true;
            this.btnPrincipalEmitirNotas.Click += new System.EventHandler(this.BtnPrincipalEmitirNotas_Click);
            // 
            // btnPrincipalCadastroCliente
            // 
            this.btnPrincipalCadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrincipalCadastroCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalCadastroCliente.Image = global::GUI.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnPrincipalCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrincipalCadastroCliente.Location = new System.Drawing.Point(252, 380);
            this.btnPrincipalCadastroCliente.Name = "btnPrincipalCadastroCliente";
            this.btnPrincipalCadastroCliente.Size = new System.Drawing.Size(153, 188);
            this.btnPrincipalCadastroCliente.TabIndex = 6;
            this.btnPrincipalCadastroCliente.Text = "Cadastrar Cliente";
            this.btnPrincipalCadastroCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrincipalCadastroCliente.UseVisualStyleBackColor = true;
            this.btnPrincipalCadastroCliente.Click += new System.EventHandler(this.BtnPrincipalCadastroCliente_Click);
            // 
            // btnPrincipalOrcamento
            // 
            this.btnPrincipalOrcamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalOrcamento.Image = global::GUI.Properties.Resources._3925433_budget_money_stocks_icon_111559;
            this.btnPrincipalOrcamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrincipalOrcamento.Location = new System.Drawing.Point(582, 380);
            this.btnPrincipalOrcamento.Name = "btnPrincipalOrcamento";
            this.btnPrincipalOrcamento.Size = new System.Drawing.Size(153, 188);
            this.btnPrincipalOrcamento.TabIndex = 4;
            this.btnPrincipalOrcamento.Text = "Realizar Orçamento";
            this.btnPrincipalOrcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrincipalOrcamento.UseVisualStyleBackColor = true;
            this.btnPrincipalOrcamento.Click += new System.EventHandler(this.BtnPrincipalOrcamento_Click);
            // 
            // btnPrincipalRealizaMaoDeObra
            // 
            this.btnPrincipalRealizaMaoDeObra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalRealizaMaoDeObra.Image = global::GUI.Properties.Resources.cashier_icon_icons_com_53629;
            this.btnPrincipalRealizaMaoDeObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrincipalRealizaMaoDeObra.Location = new System.Drawing.Point(747, 380);
            this.btnPrincipalRealizaMaoDeObra.Name = "btnPrincipalRealizaMaoDeObra";
            this.btnPrincipalRealizaMaoDeObra.Size = new System.Drawing.Size(153, 188);
            this.btnPrincipalRealizaMaoDeObra.TabIndex = 5;
            this.btnPrincipalRealizaMaoDeObra.Text = "Realizar Serviço";
            this.btnPrincipalRealizaMaoDeObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrincipalRealizaMaoDeObra.UseVisualStyleBackColor = true;
            this.btnPrincipalRealizaMaoDeObra.Click += new System.EventHandler(this.BtnPrincipalRealizaMaoDeObra_Click);
            // 
            // btnVeiculoCliente
            // 
            this.btnVeiculoCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculoCliente.Image = global::GUI.Properties.Resources.Travel_BMV_icon2;
            this.btnVeiculoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVeiculoCliente.Location = new System.Drawing.Point(417, 380);
            this.btnVeiculoCliente.Name = "btnVeiculoCliente";
            this.btnVeiculoCliente.Size = new System.Drawing.Size(153, 188);
            this.btnVeiculoCliente.TabIndex = 8;
            this.btnVeiculoCliente.Text = "Veículos do Cliente";
            this.btnVeiculoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVeiculoCliente.UseVisualStyleBackColor = true;
            this.btnVeiculoCliente.Click += new System.EventHandler(this.BtnVeiculoCliente_Click);
            // 
            // lblVersionSystem
            // 
            this.lblVersionSystem.AutoSize = true;
            this.lblVersionSystem.Location = new System.Drawing.Point(1260, 34);
            this.lblVersionSystem.Name = "lblVersionSystem";
            this.lblVersionSystem.Size = new System.Drawing.Size(46, 13);
            this.lblVersionSystem.TabIndex = 9;
            this.lblVersionSystem.Text = "Versão: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.frmPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblVersionSystem);
            this.Controls.Add(this.btnVeiculoCliente);
            this.Controls.Add(this.btnPrincipalEmitirNotas);
            this.Controls.Add(this.btnPrincipalCadastroCliente);
            this.Controls.Add(this.btnPrincipalOrcamento);
            this.Controls.Add(this.btnPrincipalRealizaMaoDeObra);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento Mecanica";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mãoDeObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mãoDeObraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteVeículosToolStripMenuItem;
        private System.Windows.Forms.Button btnPrincipalOrcamento;
        private System.Windows.Forms.Button btnPrincipalRealizaMaoDeObra;
        private System.Windows.Forms.Button btnPrincipalCadastroCliente;
        private System.Windows.Forms.Button btnPrincipalEmitirNotas;
        private System.Windows.Forms.ToolStripMenuItem realizarOrçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizaMãodeObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizaNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimeNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimeOrçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimeMãoDeObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.Button btnVeiculoCliente;
        private System.Windows.Forms.Label lblVersionSystem;
    }
}