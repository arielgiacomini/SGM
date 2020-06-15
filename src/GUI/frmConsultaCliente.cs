using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        public int codigo = 0;
        public string nomeCliente = "";

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvConsultCliente.DataSource = bll.Localizar(txtConsultaCliente.Text);
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            if (codigo > 0)
            {
                CarregandoGridViewFiltradoPorCliente(codigo);
            }
            else
            {
                btnConsultaCliente_Click(sender, e);
            }

           
            dgvConsultCliente.Columns[0].HeaderText = "Código";
            dgvConsultCliente.Columns[0].Width = 50;
            dgvConsultCliente.Columns[1].HeaderText = "Cliente";
            dgvConsultCliente.Columns[1].Width = 220;
            dgvConsultCliente.Columns[2].HeaderText = "Apelido";
            dgvConsultCliente.Columns[2].Width = 90;
            dgvConsultCliente.Columns[3].HeaderText = "CPF";
            dgvConsultCliente.Columns[3].Width = 75;
            dgvConsultCliente.Columns[4].HeaderText = "Sexo";
            dgvConsultCliente.Columns[4].Width = 60;
            dgvConsultCliente.Columns[5].HeaderText = "Estado Civil";
            dgvConsultCliente.Columns[5].Width = 75;
            dgvConsultCliente.Columns[6].HeaderText = "Data Nascimento";
            dgvConsultCliente.Columns[6].Width = 75;
        }

        private void CarregandoGridViewFiltradoPorCliente(int clienteId)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);

            dgvConsultCliente.DataSource = bll.LocalizarClienteByClienteId(clienteId);
        }

        private void dgvConsultCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvConsultCliente.Rows[e.RowIndex].Cells[0].Value);
                this.nomeCliente = Convert.ToString(dgvConsultCliente.Rows[e.RowIndex].Cells[3].Value);
                this.Close();
            }
        }
    }
}
