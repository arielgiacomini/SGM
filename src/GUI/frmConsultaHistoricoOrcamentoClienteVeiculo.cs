using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaHistoricoOrcamentoClienteVeiculo : Form
    {
        public int codigo = 0;
        public int clienteId = 0;
        public string placaVeiculo = "";

        public frmConsultaHistoricoOrcamentoClienteVeiculo()
        {
            InitializeComponent();
        }

        private void FrmConsultaHistoricoOrcamentoClienteVeiculo_Load(object sender, EventArgs e)
        {
            if (clienteId > 0 && txtPlacaClienteVeiculoConsulta.Text == "")
            {
                CarregandoGridViewFiltradoPorCliente(clienteId);
            }
            else
            {
                BtnPlacaClienteVeiculoConsulta_Click(sender, e);
            }

            if (dgvOrcamentoHistoricoClienteVeiculo.Columns.Count > 0)
            {
                dgvOrcamentoHistoricoClienteVeiculo.Columns[0].HeaderText = "Código Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[0].Width = 50;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[1].HeaderText = "Código Cliente";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[1].Width = 50;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[2].HeaderText = "Data do Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[2].Width = 110;
                dgvOrcamentoHistoricoClienteVeiculo.Columns["DataOrcamento"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[3].HeaderText = "Cliente";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[3].Width = 150;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[4].HeaderText = "Marca / Modelo";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[4].Width = 120;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[5].HeaderText = "Placa";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[5].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[6].HeaderText = "Descrição do Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[6].Width = 200;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[7].HeaderText = "Status Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[7].Width = 150;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].HeaderText = "Valor Adicional";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].HeaderText = "% de Desconto";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Format = "P1";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].HeaderText = "Valor Desconto";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].HeaderText = "Valor Total";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void BtnPlacaClienteVeiculoConsulta_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLOrcamento servico = new BLLOrcamento(cx);
            var dados = servico.BuscaHistoricoOrcamentoClientePorPlacaVeiculo(txtPlacaClienteVeiculoConsulta.Text);
            dgvOrcamentoHistoricoClienteVeiculo.DataSource = dados;

            if (dgvOrcamentoHistoricoClienteVeiculo.Rows.Count > 0)
            {
                dgvOrcamentoHistoricoClienteVeiculo.Columns[0].HeaderText = "Código Serviço";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[0].Width = 50;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[1].HeaderText = "Código Cliente";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[1].Width = 50;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[2].HeaderText = "Data do Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[2].Width = 110;
                dgvOrcamentoHistoricoClienteVeiculo.Columns["DataOrcamento"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[3].HeaderText = "Cliente";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[3].Width = 150;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[4].HeaderText = "Marca / Modelo";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[4].Width = 120;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[5].HeaderText = "Placa";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[5].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[6].HeaderText = "Descrição do Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[6].Width = 200;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[7].HeaderText = "Status Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[7].Width = 150;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].HeaderText = "Valor Adicional";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].HeaderText = "% de Desconto";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Format = "P1";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].HeaderText = "Valor Desconto";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].HeaderText = "Valor Total";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void CarregandoGridViewFiltradoPorCliente(int clienteId)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLOrcamento bll = new BLLOrcamento(cx);

            dgvOrcamentoHistoricoClienteVeiculo.DataSource = bll.BuscarHistoricoOrcamentoClienteByClienteId(clienteId);

            if (dgvOrcamentoHistoricoClienteVeiculo.Rows.Count > 0)
            {
                dgvOrcamentoHistoricoClienteVeiculo.Columns[0].HeaderText = "Código Serviço";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[0].Width = 50;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[1].HeaderText = "Código Cliente";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[1].Width = 50;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[2].HeaderText = "Data do Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[2].Width = 110;
                dgvOrcamentoHistoricoClienteVeiculo.Columns["DataOrcamento"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[3].HeaderText = "Cliente";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[3].Width = 150;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[4].HeaderText = "Marca / Modelo";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[4].Width = 120;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[5].HeaderText = "Placa";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[5].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[6].HeaderText = "Descrição do Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[6].Width = 200;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[7].HeaderText = "Status Orçamento";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[7].Width = 150;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].HeaderText = "Valor Adicional";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].HeaderText = "% de Desconto";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Format = "P1";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].HeaderText = "Valor Desconto";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].HeaderText = "Valor Total";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].Width = 70;
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].DefaultCellStyle.Format = "C2";
                dgvOrcamentoHistoricoClienteVeiculo.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void DgvOrcamentoHistoricoClienteVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value == null ? 0 : dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value);
                this.clienteId = Convert.ToInt32(dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[1].Value);
                this.placaVeiculo = Convert.ToString(dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[5].Value);
                this.Close();

                frmDetalhesOrcamentoGerado formDetahleOrcamento = new frmDetalhesOrcamentoGerado
                {
                    orcamentoId = codigo
                };

                formDetahleOrcamento.ShowDialog();
            }
        }
    }
}
