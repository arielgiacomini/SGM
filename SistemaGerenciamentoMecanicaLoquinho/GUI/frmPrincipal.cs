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

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculo f = new frmCadastroVeiculo();
            f.ShowDialog(); // mostra o objeto na tela
            f.Dispose();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculo v = new frmConsultaVeiculo();
            v.ShowDialog(); // mostra o objeto na tela
            v.Dispose();
        }

        private void clienteVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroClienteVeiculo k = new frmCadastroClienteVeiculo();
            k.ShowDialog(); // mostra o objeto na tela
            k.Dispose();
        }

        private void btnPrincipalCadastroCliente_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */
            //MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            frmCadastroCliente c = new frmCadastroCliente();
            c.ShowDialog();
            c.Dispose();
        }

        private void btnPrincipalOrcamento_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO 

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            */

            frmGerarOrcamento g = new frmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();

        }

        private void btnPrincipalRealizaMaoDeObra_Click(object sender, EventArgs e)
        {
            frmGerarServico h = new frmGerarServico();
            h.ShowDialog();
            h.Dispose();
        }

        private void btnPrincipalEmitirNotas_Click(object sender, EventArgs e)
        {
            /* EM IMPLANTAÇÃO */

            MessageBox.Show("Aguenta aí, que o bixo ta vindo... HAHAHA! \n Estou trabalhando para colocar essa tela no ar...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre p = new frmSobre();
            p.ShowDialog();
            p.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente c = new frmCadastroCliente();
            c.ShowDialog();
            c.Dispose();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimeNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaClienteVeiculo p = new frmConsultaClienteVeiculo();
            p.ShowDialog();
            p.Dispose();
        }

        private void btnVeiculoCliente_Click(object sender, EventArgs e)
        {
            frmConsultaClienteVeiculo x = new frmConsultaClienteVeiculo();
            x.ShowDialog();
            x.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente t = new frmConsultaCliente();
            t.ShowDialog();
            t.Dispose();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPeca o = new frmCadastroPeca();
            o.ShowDialog();
            o.Dispose();
        }

        private void peçasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPeca i = new frmConsultaPeca();
            i.ShowDialog();
            i.Dispose();
        }

        private void mãoDeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMaoDeObra u = new frmCadastroMaoDeObra();
            u.ShowDialog();
            u.Dispose();
        }

        private void mãoDeObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaMaoDeObra b = new frmConsultaMaoDeObra();
            b.ShowDialog();
            b.Dispose();
        }

        private void realizarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarOrcamento g = new frmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();
        }

        private void realizaMãodeObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarServico j = new frmGerarServico();
            j.ShowDialog();
            j.Dispose();
        }
    }
}
