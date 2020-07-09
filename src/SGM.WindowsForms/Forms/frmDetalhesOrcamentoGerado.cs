using BLL;
using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class frmDetalhesOrcamentoGerado : Form
    {
        public frmDetalhesOrcamentoGerado()
        {
            InitializeComponent();
        }

        public int orcamentoId = 0;

        private void FrmDetalhesOrcamentoGerado_Load(object sender, System.EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLOrcamento bll = new BLLOrcamento(cx);

            lblOrcamentoId.Text += Convert.ToString(orcamentoId);

            dgvMaodeObraOrcamentoGerado.DataSource = bll.LocalizarOrcamentoMaodeObra(orcamentoId);
            dgvMaodeObraOrcamentoGerado.Columns[0].HeaderText = "Código";
            dgvMaodeObraOrcamentoGerado.Columns[0].Width = 50;
            dgvMaodeObraOrcamentoGerado.Columns[1].HeaderText = "Mão de Obra";
            dgvMaodeObraOrcamentoGerado.Columns[1].Width = 330;
            dgvMaodeObraOrcamentoGerado.Columns[2].HeaderText = "Valor";
            dgvMaodeObraOrcamentoGerado.Columns[2].Width = 70;
            dgvMaodeObraOrcamentoGerado.Columns[2].DefaultCellStyle.Format = "C2";
            dgvMaodeObraOrcamentoGerado.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPecasOrcamentoGerados.DataSource = bll.LocalizarOrcamentoPeca(orcamentoId);
            dgvPecasOrcamentoGerados.Columns[0].HeaderText = "Código";
            dgvPecasOrcamentoGerados.Columns[0].Width = 50;
            dgvPecasOrcamentoGerados.Columns[1].HeaderText = "Produtos/Peças";
            dgvPecasOrcamentoGerados.Columns[1].Width = 330;
            dgvPecasOrcamentoGerados.Columns[2].HeaderText = "Valor";
            dgvPecasOrcamentoGerados.Columns[2].Width = 70;
            dgvPecasOrcamentoGerados.Columns[2].DefaultCellStyle.Format = "C2";
            dgvPecasOrcamentoGerados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            var orcamentoGerado = bll.BuscarDetalheOrcamentoGerado(orcamentoId);

            txtValorMaodeObraTotal.Text = 0.ToString("C");
            txtValorProdutosPecasTotal.Text = 0.ToString("C");
            txtValorAdicionalTotal.Text = orcamentoGerado.CValorAdicional.ToString("C");
            txtPercentualDesconto.Text = orcamentoGerado.CPercentualDesconto.ToString("P");
            txtValorDescontoTotal.Text = orcamentoGerado.CValorDesconto.ToString("C");
            txtValorTotal.Text = orcamentoGerado.CValorTotal.ToString("C");

            lblQtdRegistrosMaodeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObraOrcamentoGerado.Rows.Count.ToString();
            lblQtdRegistrosPecasProdutos.Text = "Quantidade de Registros: " + this.dgvPecasOrcamentoGerados.Rows.Count.ToString();


            decimal valorTotalGridMaodeObra = Convert.ToDecimal(dgvMaodeObraOrcamentoGerado.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));
            txtValorMaodeObraTotal.Text = (valorTotalGridMaodeObra.ToString("C"));
            decimal valorTotalGridProdutosPecas = Convert.ToDecimal(dgvPecasOrcamentoGerados.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["ValorTotal"].Value)));
            txtValorProdutosPecasTotal.Text = (valorTotalGridProdutosPecas.ToString("C"));
        }
    }
}
