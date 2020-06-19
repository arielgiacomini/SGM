using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPerguntaQualItemAbrir : Form
    {
        public FrmPerguntaQualItemAbrir()
        {
            InitializeComponent();
        }
        
        public int clienteId = 0;

        private void FrmPerguntaQualItemAbrir_Load(object sender, EventArgs e)
        {

        }

        private void BtnRealizaOrcamento_Click(object sender, EventArgs e)
        {
            FrmGerarOrcamento formGerarOrcamento = new FrmGerarOrcamento
            {
                clienteId = clienteId
            };

            formGerarOrcamento.ShowDialog();
            formGerarOrcamento.Dispose();
        }

        private void BtnRealizaMaoDeObra_Click(object sender, EventArgs e)
        {
            FrmGerarServico formGerarServico = new FrmGerarServico
            {
                clienteId = clienteId
            };

            formGerarServico.ShowDialog();
            formGerarServico.Dispose();
        }
    }
}
