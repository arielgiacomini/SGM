using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsultaGerarOrcamento : Form
    {
        public int codigo = 0;

        public FrmConsultaGerarOrcamento()
        {
            InitializeComponent();
        }

        private void BtnConsultaOrcamentosGerados_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLOrcamento bll = new BLLOrcamento(cx);
            dgvConsultaOrcamentoGerados.DataSource = bll.BuscaHistoricoOrcamentoClientePorPlacaVeiculo(txtConsultaOrcamentosGerados.Text);
        }

        private void FrmConsultaGerarOrcamento_Load(object sender, EventArgs e)
        {
            BtnConsultaOrcamentosGerados_Click(sender, e);
            dgvConsultaOrcamentoGerados.Columns[0].HeaderText = "Código";
            dgvConsultaOrcamentoGerados.Columns[0].Width = 50;
            dgvConsultaOrcamentoGerados.Columns[1].HeaderText = "Cliente";
            dgvConsultaOrcamentoGerados.Columns[1].Width = 230;
            dgvConsultaOrcamentoGerados.Columns[3].HeaderText = "Valor Total";
            dgvConsultaOrcamentoGerados.Columns[3].Width = 70;
            dgvConsultaOrcamentoGerados.Columns[3].ToolTipText = "Já considerando o adicional e descontos se houver ambos. ;)";
            dgvConsultaOrcamentoGerados.Columns[4].HeaderText = "Status";
            dgvConsultaOrcamentoGerados.Columns[4].Width = 70;
        }

        private void DgvConsultaOrcamentoGerados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
            {
                this.codigo = Convert.ToInt32(dgvConsultaOrcamentoGerados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
