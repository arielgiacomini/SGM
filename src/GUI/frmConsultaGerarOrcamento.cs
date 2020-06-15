using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaGerarOrcamento : Form
    {

        public int codigo = 0;

        public frmConsultaGerarOrcamento()
        {
            InitializeComponent();
        }

        private void btnConsultaOrcamentosGerados_Click(object sender, EventArgs e)
        {
            // objeto para gravar os dados no banco de dados
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLOrcamento bll = new BLLOrcamento(cx);
            dgvConsultaOrcamentoGerados.DataSource = bll.LocalizarFrmConsultaGerarOrcamento(txtConsultaOrcamentosGerados.Text);
        }

        private void frmConsultaGerarOrcamento_Load(object sender, EventArgs e)
        {
            btnConsultaOrcamentosGerados_Click(sender, e); // para carregar o grid na chamada da tela
            dgvConsultaOrcamentoGerados.Columns[0].HeaderText = "Código";
            dgvConsultaOrcamentoGerados.Columns[0].Width = 50;
            dgvConsultaOrcamentoGerados.Columns[1].HeaderText = "Cliente";
            dgvConsultaOrcamentoGerados.Columns[1].Width = 230;
            dgvConsultaOrcamentoGerados.Columns[3].HeaderText = "Valor Total";
            dgvConsultaOrcamentoGerados.Columns[3].Width = 70;
            dgvConsultaOrcamentoGerados.Columns[3].ToolTipText = "Já considerando o adicional e descontos se houver ambos. ;)";
            dgvConsultaOrcamentoGerados.Columns[4].HeaderText = "Status";
            dgvConsultaOrcamentoGerados.Columns[4].Width = 70;
            //dgvConsultaOrcamentoGerados.Columns[2].HeaderText = "Descrição Orçamento";
            //dgvConsultaOrcamentoGerados.Columns[2].Width = 120;
        }

        private void dgvConsultaOrcamentoGerados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvConsultaOrcamentoGerados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
