using SGM.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmGerarServicoOuOrcamento : Form
    {
        public FrmGerarServicoOuOrcamento()
        {
            InitializeComponent();
        }

        public int clienteId = 0;
        public int veiculoId = 0;
        public string placaVeiculo = "";
        public int clienteVeiculoId = 0;

        private void FrmPerguntaQualItemAbrir_Load(object sender, EventArgs e)
        {

        }

        private void BtnRealizaOrcamento_Click(object sender, EventArgs e)
        {
            FrmGerarOrcamento formGerarOrcamento = FormResolve.Resolve<FrmGerarOrcamento>();
            formGerarOrcamento.clienteId = clienteId;
            formGerarOrcamento.veiculoId = veiculoId;
            formGerarOrcamento.clienteVeiculoId = clienteVeiculoId;
            formGerarOrcamento.placaVeiculo = placaVeiculo;
            formGerarOrcamento.ShowDialog();
            formGerarOrcamento.Dispose();
        }

        private void BtnRealizaMaoDeObra_Click(object sender, EventArgs e)
        {
            FrmGerarServico formGerarServico = FormResolve.Resolve<FrmGerarServico>();
            formGerarServico.clienteId = clienteId;
            formGerarServico.veiculoId = veiculoId;
            formGerarServico.clienteVeiculoId = clienteVeiculoId;
            formGerarServico.placaVeiculo = placaVeiculo;
            formGerarServico.ShowDialog();
            formGerarServico.Dispose();
        }
    }
}
