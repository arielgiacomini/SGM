using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsultaClienteVeiculo : Form
    {

        public int codigo = 0;
        public int clienteId = 0;
        public string nomeCliente = "";
        public string placaVeiculo = "";

        public FrmConsultaClienteVeiculo()
        {
            InitializeComponent();
        }

        private void FrmConsultaClienteVeiculo_Load(object sender, EventArgs e)
        {
            if (clienteId > 0)
            {
                CarregandoGridViewFiltradoPorCliente(clienteId);
            }
            else
            {
                BtnPlacaClienteVeiculoConsulta_Click(sender, e);
            }
            
            dgvClienteVeiculoConsulta.Columns[0].HeaderText = "Código";
            dgvClienteVeiculoConsulta.Columns[0].Width = 50;
            dgvClienteVeiculoConsulta.Columns[1].HeaderText = "Cliente";
            dgvClienteVeiculoConsulta.Columns[1].Width = 250;
            dgvClienteVeiculoConsulta.Columns[2].HeaderText = "Veículo";
            dgvClienteVeiculoConsulta.Columns[2].Width = 265;
            dgvClienteVeiculoConsulta.Columns[3].HeaderText = "Placa";
            dgvClienteVeiculoConsulta.Columns[3].Width = 80;
            dgvClienteVeiculoConsulta.Columns[4].HeaderText = "Cor";
            dgvClienteVeiculoConsulta.Columns[4].Width = 80;
            dgvClienteVeiculoConsulta.Columns[5].HeaderText = "Km Rodados";
            dgvClienteVeiculoConsulta.Columns[5].Width = 80;
            dgvClienteVeiculoConsulta.Columns[6].HeaderText = "Cliente ID";
            dgvClienteVeiculoConsulta.Columns[6].Width = 80;
        }

        private void BtnPlacaClienteVeiculoConsulta_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
            dgvClienteVeiculoConsulta.DataSource = bll.Localizar(txtPlacaClienteVeiculoConsulta.Text);
        }

        private void CarregandoGridViewFiltradoPorCliente(int clienteId)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);

            dgvClienteVeiculoConsulta.DataSource = bll.LocalizarTodosVeiculosCliente(clienteId);
        }

        private void DgvClienteVeiculoConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[0].Value == null ? 0 : dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[0].Value);
                this.clienteId = Convert.ToInt32(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[6].Value);
                this.nomeCliente = Convert.ToString(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[1].Value);
                this.placaVeiculo = Convert.ToString(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[3].Value);
                this.Close();
            }
        }
    }
}
