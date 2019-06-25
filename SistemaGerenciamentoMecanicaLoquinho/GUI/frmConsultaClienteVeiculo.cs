using BBL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaClienteVeiculo : Form
    {
        public int codigo = 0;

        public frmConsultaClienteVeiculo()
        {
            InitializeComponent();
        }

        private void frmConsultaClienteVeiculo_Load(object sender, EventArgs e)
        {
            btnPlacaClienteVeiculoConsulta_Click(sender, e); // para carregar o grid na chamada da tela
            dgvClienteVeiculoConsulta.Columns[0].HeaderText = "Código";
            dgvClienteVeiculoConsulta.Columns[0].Width = 50;
            dgvClienteVeiculoConsulta.Columns[1].HeaderText = "Cliente";
            dgvClienteVeiculoConsulta.Columns[1].Width = 250;
            dgvClienteVeiculoConsulta.Columns[2].HeaderText = "Veículo";
            dgvClienteVeiculoConsulta.Columns[2].Width = 265;
            dgvClienteVeiculoConsulta.Columns[3].HeaderText = "Ano Veículo";
            dgvClienteVeiculoConsulta.Columns[3].Width = 70;
            dgvClienteVeiculoConsulta.Columns[4].HeaderText = "Placa";
            dgvClienteVeiculoConsulta.Columns[4].Width = 80;
        }

        private void btnPlacaClienteVeiculoConsulta_Click(object sender, EventArgs e)
        {
            // objeto para gravar os dados no banco de dados
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
            dgvClienteVeiculoConsulta.DataSource = bll.Localizar(txtPlacaClienteVeiculoConsulta.Text);

        }

        private void dgvClienteVeiculoConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvClienteVeiculoConsulta.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
