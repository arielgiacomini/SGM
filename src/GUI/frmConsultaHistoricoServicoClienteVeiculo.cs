using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaHistoricoServicoClienteVeiculo : Form
    {
        public int codigo = 0;
        public int clienteId = 0;
        public string placaVeiculo = "";

        public frmConsultaHistoricoServicoClienteVeiculo()
        {
            InitializeComponent();
        }

        private void FrmConsultaHistoricoServicoClienteVeiculo_Load(object sender, System.EventArgs e)
        {
            if (clienteId > 0 && txtPlacaClienteVeiculoConsulta.Text == "")
            {
                CarregandoGridViewFiltradoPorCliente(clienteId);
            }
            else
            {
                BtnPlacaClienteVeiculoConsulta_Click(sender, e);
            }

            dgvServicoHistoricoClienteVeiculo.Columns[0].HeaderText = "Código Serviço";
            dgvServicoHistoricoClienteVeiculo.Columns[0].Width = 50;
            dgvServicoHistoricoClienteVeiculo.Columns[1].HeaderText = "Código Cliente";
            dgvServicoHistoricoClienteVeiculo.Columns[1].Width = 50;
            dgvServicoHistoricoClienteVeiculo.Columns[2].HeaderText = "Data do Serviço";
            dgvServicoHistoricoClienteVeiculo.Columns[2].Width = 100;
            dgvServicoHistoricoClienteVeiculo.Columns[3].HeaderText = "Cliente";
            dgvServicoHistoricoClienteVeiculo.Columns[3].Width = 150;
            dgvServicoHistoricoClienteVeiculo.Columns[4].HeaderText = "Marca / Modelo";
            dgvServicoHistoricoClienteVeiculo.Columns[4].Width = 120;
            dgvServicoHistoricoClienteVeiculo.Columns[5].HeaderText = "Placa";
            dgvServicoHistoricoClienteVeiculo.Columns[5].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[6].HeaderText = "Descrição do Serviço";
            dgvServicoHistoricoClienteVeiculo.Columns[6].Width = 200;
            dgvServicoHistoricoClienteVeiculo.Columns[7].HeaderText = "Status Serviço";
            dgvServicoHistoricoClienteVeiculo.Columns[7].Width = 150;
            dgvServicoHistoricoClienteVeiculo.Columns[8].HeaderText = "Valor Adicional";
            dgvServicoHistoricoClienteVeiculo.Columns[8].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[9].HeaderText = "% de Desconto";
            dgvServicoHistoricoClienteVeiculo.Columns[9].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[10].HeaderText = "Valor Desconto";
            dgvServicoHistoricoClienteVeiculo.Columns[10].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[11].HeaderText = "Valor Total";
            dgvServicoHistoricoClienteVeiculo.Columns[11].Width = 70;
        }

        private void BtnPlacaClienteVeiculoConsulta_Click(object sender, System.EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLServico servico = new BLLServico(cx);
            dgvServicoHistoricoClienteVeiculo.DataSource = servico.BuscaHistoricoServicoClientePorPlacaVeiculo(txtPlacaClienteVeiculoConsulta.Text);
        }

        private void CarregandoGridViewFiltradoPorCliente(int clienteId)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLServico bll = new BLLServico(cx);

            dgvServicoHistoricoClienteVeiculo.DataSource = bll.BuscarHistoricoServicoClienteByClienteId(clienteId);
        }

        private void dgvServicoHistoricoClienteVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvServicoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value == null ? 0 : dgvServicoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value);
                this.clienteId = Convert.ToInt32(dgvServicoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[1].Value);
                this.placaVeiculo = Convert.ToString(dgvServicoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[4].Value);
                this.Close();
            }
        }
    }
}
