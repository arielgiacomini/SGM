using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaMaoDeObra : Form
    {
        public int codigo = 0;

        public frmConsultaMaoDeObra()
        {
            InitializeComponent();
        }

        private void btnConsultaMaoDeObra_Click(object sender, EventArgs e)
        {
            // objeto para gravar os dados no banco de dados
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLMaoDeObra bll = new BLLMaoDeObra(cx);
            dgvConsultaMaoDeObra.DataSource = bll.Localizar(txtConsultaMaoDeObra.Text);
        }

        private void frmConsultaMaoDeObra_Load(object sender, EventArgs e)
        {
            btnConsultaMaoDeObra_Click(sender, e); // para carregar o grid na chamada da tela
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
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvConsultaMaoDeObra.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
