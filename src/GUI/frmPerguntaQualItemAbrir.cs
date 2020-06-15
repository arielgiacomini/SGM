using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPerguntaQualItemAbrir : Form
    {
        public frmPerguntaQualItemAbrir()
        {
            InitializeComponent();
        }

        private void frmPerguntaQualItemAbrir_Load(object sender, EventArgs e)
        {

        }

        private void btnRealizaOrcamento_Click(object sender, EventArgs e)
        {
            frmGerarOrcamento g = new frmGerarOrcamento();
            g.ShowDialog();
            g.Dispose();
        }

        private void btnRealizaMaoDeObra_Click(object sender, EventArgs e)
        {
            frmGerarServico h = new frmGerarServico();
            h.ShowDialog();
            h.Dispose();
        }
    }
}
