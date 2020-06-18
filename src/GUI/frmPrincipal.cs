using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void VeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculo f = new frmCadastroVeiculo();
            f.ShowDialog();
            f.Dispose();
        }

        private void VeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculo v = new frmConsultaVeiculo();
            v.ShowDialog();
            v.Dispose();
        }

        private void ClienteVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClienteVeiculo k = new frmCadastroClienteVeiculo();
            k.ShowDialog();
            k.Dispose();
        }

        private void BtnPrincipalCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente c = new FrmCadastroCliente();
            c.ShowDialog();
            c.Dispose();
        }

        private void BtnPrincipalOrcamento_Click(object sender, EventArgs e)
        {
            frmGerarOrcamento g = new frmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();
        }

        private void BtnPrincipalRealizaMaoDeObra_Click(object sender, EventArgs e)
        {
            frmGerarServico h = new frmGerarServico();
            h.ShowDialog();
            h.Dispose();
        }

        private void BtnPrincipalEmitirNotas_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre p = new frmSobre();
            p.ShowDialog();
            p.Dispose();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente c = new FrmCadastroCliente();
            c.ShowDialog();
            c.Dispose();
        }

        private void MovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ImprimeNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClienteVeiculo p = new frmConsultaClienteVeiculo();
            p.ShowDialog();
            p.Dispose();
        }

        private void BtnVeiculoCliente_Click(object sender, EventArgs e)
        {
            frmConsultaClienteVeiculo x = new frmConsultaClienteVeiculo();
            x.ShowDialog();
            if (x.codigo != 0)
            {
                frmCadastroClienteVeiculo clivei = new frmCadastroClienteVeiculo
                {
                    clienteId = x.clienteId,
                    placaVeiculo = x.placaVeiculo
                };

                clivei.ShowDialog();
                clivei.Dispose();
            }
        }

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente t = new frmConsultaCliente();
            t.ShowDialog();
            t.Dispose();
        }

        private void PeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPeca o = new frmCadastroPeca();
            o.ShowDialog();
            o.Dispose();
        }

        private void PecasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPeca i = new frmConsultaPeca();
            i.ShowDialog();
            i.Dispose();
        }

        private void MaoDeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMaoDeObra u = new frmCadastroMaoDeObra();
            u.ShowDialog();
            u.Dispose();
        }

        private void MaoDeObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaMaoDeObra b = new FrmConsultaMaoDeObra();
            b.ShowDialog();
            b.Dispose();
        }

        private void RealizarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarOrcamento g = new frmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();
        }

        private void RealizaMãodeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarServico j = new frmGerarServico();
            j.ShowDialog();
            j.Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string texto = "Versão: ";

            lblVersionSystem.Text = texto + ProductVersion.ToString();
        }

        private void BtnBuscarHistoricoServicoCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaHistoricoServicoClienteVeiculo consultaHistorico = new FrmConsultaHistoricoServicoClienteVeiculo();
            consultaHistorico.ShowDialog();
            consultaHistorico.Dispose();
        }
    }
}
