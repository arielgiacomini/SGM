using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmConsultaMaoDeObra : Form
    {
        public int codigo = 0;

        public FrmConsultaMaoDeObra()
        {
            InitializeComponent();
        }

        private void btnConsultaMaoDeObra_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLMaoDeObra bll = new BLLMaoDeObra(cx);
            dgvConsultaMaoDeObra.DataSource = bll.Localizar(txtConsultaMaoDeObra.Text);
        }

        private void frmConsultaMaoDeObra_Load(object sender, EventArgs e)
        {
            btnConsultaMaoDeObra_Click(sender, e);
            dgvConsultaMaoDeObra.Columns[0].HeaderText = "Código";
            dgvConsultaMaoDeObra.Columns[0].Width = 50;
            dgvConsultaMaoDeObra.Columns[1].HeaderText = "Mão-de-Obra/Serviço";
            dgvConsultaMaoDeObra.Columns[1].Width = 230;
            dgvConsultaMaoDeObra.Columns[2].HeaderText = "Tipo";
            dgvConsultaMaoDeObra.Columns[2].Width = 120;
            dgvConsultaMaoDeObra.Columns[3].HeaderText = "Valor";
            dgvConsultaMaoDeObra.Columns[3].Width = 70;
            dgvConsultaMaoDeObra.Columns[4].HeaderText = "Vigência Inicial";
            dgvConsultaMaoDeObra.Columns[4].Width = 70;
            dgvConsultaMaoDeObra.Columns[5].HeaderText = "Vigência Final";
            dgvConsultaMaoDeObra.Columns[5].Width = 70;
            dgvConsultaMaoDeObra.Columns[6].HeaderText = "Ativo";
            dgvConsultaMaoDeObra.Columns[6].Width = 45;
            dgvConsultaMaoDeObra.Columns[7].HeaderText = "Data Cadastro";
            dgvConsultaMaoDeObra.Columns[7].Width = 70;
        }

        private void dgvConsultaMaoDeObra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsultaMaoDeObra.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
