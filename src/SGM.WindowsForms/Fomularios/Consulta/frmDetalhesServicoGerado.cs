using BLL;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmDetalhesServicoGerado : Form
    {
        public FrmDetalhesServicoGerado()
        {
            InitializeComponent();
        }

        public int servicoId = 0;

        private void FrmDetalhesServicoGerado_Load(object sender, System.EventArgs e)
        {

            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLServico bll = new BLLServico(cx);

            lblServicoId.Text += Convert.ToString(servicoId);

            dgvMaodeObraServicoGerado.DataSource = bll.LocalizarServicoMaodeObra(servicoId);
            dgvMaodeObraServicoGerado.Columns[0].HeaderText = "Código";
            dgvMaodeObraServicoGerado.Columns[0].Width = 50;
            dgvMaodeObraServicoGerado.Columns[1].HeaderText = "Mão de Obra";
            dgvMaodeObraServicoGerado.Columns[1].Width = 330;
            dgvMaodeObraServicoGerado.Columns[2].HeaderText = "Valor";
            dgvMaodeObraServicoGerado.Columns[2].Width = 70;
            dgvMaodeObraServicoGerado.Columns[2].DefaultCellStyle.Format = "C2";
            dgvMaodeObraServicoGerado.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPecasServicosGerados.DataSource = bll.LocalizarServicoPeca(servicoId);
            dgvPecasServicosGerados.Columns[0].HeaderText = "Código";
            dgvPecasServicosGerados.Columns[0].Width = 50;
            dgvPecasServicosGerados.Columns[1].HeaderText = "Produtos/Peças";
            dgvPecasServicosGerados.Columns[1].Width = 330;
            dgvPecasServicosGerados.Columns[2].HeaderText = "Valor";
            dgvPecasServicosGerados.Columns[2].Width = 70;
            dgvPecasServicosGerados.Columns[2].DefaultCellStyle.Format = "C2";
            dgvPecasServicosGerados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var servicoGerado = bll.BuscarDetalheServicoGerado(servicoId);

            txtValorMaodeObraTotal.Text = 0.ToString("C");
            txtValorProdutosPecasTotal.Text = 0.ToString("C");
            txtValorAdicionalTotal.Text = servicoGerado.CValorAdicional.ToString("C");
            txtPercentualDesconto.Text = servicoGerado.CPercentualDesconto.ToString("P");
            txtValorDescontoTotal.Text = servicoGerado.CValorDesconto.ToString("C");
            txtValorTotal.Text = servicoGerado.CValorTotal.ToString("C");

            lblQtdRegistrosMaodeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObraServicoGerado.Rows.Count.ToString();
            lblQtdRegistrosPecasProdutos.Text = "Quantidade de Registros: " + this.dgvPecasServicosGerados.Rows.Count.ToString();


            decimal valorTotalGridMaodeObra = Convert.ToDecimal(dgvMaodeObraServicoGerado.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));
            txtValorMaodeObraTotal.Text = (valorTotalGridMaodeObra.ToString("C"));
            decimal valorTotalGridProdutosPecas = Convert.ToDecimal(dgvPecasServicosGerados.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["ValorTotal"].Value)));
            txtValorProdutosPecasTotal.Text = (valorTotalGridProdutosPecas.ToString("C"));
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
