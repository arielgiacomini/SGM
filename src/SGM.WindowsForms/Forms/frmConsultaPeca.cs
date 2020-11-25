using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class frmConsultaPeca : Form
    {

        public int codigo = 0;

        public frmConsultaPeca()
        {
            InitializeComponent();
        }

        private void btnConsultaPeca_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLPeca bll = new BLLPeca(cx);
            dgvConsultaPeca.DataSource = bll.Localizar(txtConsultaPeca.Text);
        }

        private void frmConsultaPeca_Load(object sender, EventArgs e)
        {
            btnConsultaPeca_Click(sender, e);
            dgvConsultaPeca.Columns[0].HeaderText = "Código";
            dgvConsultaPeca.Columns[0].Width = 50;
            dgvConsultaPeca.Columns[1].HeaderText = "Peça/Produto";
            dgvConsultaPeca.Columns[1].Width = 250;
            dgvConsultaPeca.Columns[2].HeaderText = "Fornecedor";
            dgvConsultaPeca.Columns[2].Width = 117;
            dgvConsultaPeca.Columns[3].HeaderText = "Valor Peça/Produto";
            dgvConsultaPeca.Columns[3].Width = 90;
            dgvConsultaPeca.Columns[4].HeaderText = "Frete/Adicional";
            dgvConsultaPeca.Columns[4].Width = 90;
            dgvConsultaPeca.Columns[5].HeaderText = "Status";
            dgvConsultaPeca.Columns[5].Width = 50;
            dgvConsultaPeca.Columns[6].HeaderText = "Data Cadastro";
            dgvConsultaPeca.Columns[6].Width = 70;
        }

        private void dgvConsultaPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvConsultaPeca.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
