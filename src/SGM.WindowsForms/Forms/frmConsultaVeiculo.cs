using BLL;
using DAL;
using System;
using System.Windows.Forms;


namespace SGM.WindowsForms
{
    public partial class frmConsultaVeiculo : Form
    {

        public int codigo = 0;

        public frmConsultaVeiculo()
        {
            InitializeComponent();
        }

        private void btnModeloMarcaConsulta_Click(object sender, EventArgs e)
        {
            // objeto para gravar os dados no banco de dados
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculo bll = new BLLVeiculo(cx);
            dgvModeloMarcaConsulta.DataSource = bll.Localizar(txtModeloMarcaConsulta.Text);
        }

        private void frmConsultaVeiculo_Load(object sender, EventArgs e)
        {
            btnModeloMarcaConsulta_Click(sender, e); // para carregar o grid na chamada da tela
            dgvModeloMarcaConsulta.Columns[0].HeaderText = "Código";
            dgvModeloMarcaConsulta.Columns[0].Width = 50;
            dgvModeloMarcaConsulta.Columns[1].HeaderText = "Marca Veículo";
            dgvModeloMarcaConsulta.Columns[1].Width = 245;
            dgvModeloMarcaConsulta.Columns[2].HeaderText = "Modelo Veículo";
            dgvModeloMarcaConsulta.Columns[2].Width = 260;
            dgvModeloMarcaConsulta.Columns[3].HeaderText = "Status";
            dgvModeloMarcaConsulta.Columns[3].Width = 65;
            dgvModeloMarcaConsulta.Columns[4].HeaderText = "Data Cadastro";
            dgvModeloMarcaConsulta.Columns[4].Width = 78;

        }

        private void dgvModeloMarcaConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvModeloMarcaConsulta.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
