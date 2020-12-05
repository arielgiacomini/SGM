using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.DataSources;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmDetalhesOrcamentoGerado : Form
    {
        public int orcamentoId = 0;
        private readonly IOrcamentoApplication _orcamentoApplication;
        private readonly IPecaApplication _pecaApplication;
        private readonly IMaodeObraApplication _maoDeObraApplication;

        public FrmDetalhesOrcamentoGerado(IOrcamentoApplication orcamentoApplication, IPecaApplication pecaApplication, IMaodeObraApplication maodeObraApplication)
        {
            _orcamentoApplication = orcamentoApplication;
            _pecaApplication = pecaApplication;
            _maoDeObraApplication = maodeObraApplication;

            InitializeComponent();
        }

        private void FrmDetalhesOrcamentoGerado_Load(object sender, EventArgs e)
        {
            var orcamentoGerado = _orcamentoApplication.GetOrcamentoByOrcamentoId(orcamentoId);

            if (orcamentoGerado != null || orcamentoGerado.OrcamentoId != 0)
            {
                CarregaInformacoesOrcamento(orcamentoGerado);

                var orcamentoMaodeObraSalvo = _orcamentoApplication.GetOrcamentoMaodeObraByOrcamentoId(orcamentoId);

                if (orcamentoMaodeObraSalvo != null || orcamentoMaodeObraSalvo.Count > 0)
                {
                    IList<PesquisaMaodeObraOrcamentoDataSource> maoDeObra = new List<PesquisaMaodeObraOrcamentoDataSource>();

                    foreach (var item in orcamentoMaodeObraSalvo)
                    {
                        var mao = _maoDeObraApplication.GetMaodeObraById(item.MaodeObraId);

                        maoDeObra.Add(new PesquisaMaodeObraOrcamentoDataSource
                        {
                            MaodeObraId = mao.MaodeObraId,
                            MaodeObra = mao.Descricao,
                            Valor = mao.Valor,
                            OrcamentoMaodeObraId = item.Id
                        });
                    }

                    CarregaGridViewMaodeObra(maoDeObra);
                }

                var orcamentoPecaSalvo = _orcamentoApplication.GetOrcamentoPecaByOrcamentoId(orcamentoId);

                if (orcamentoPecaSalvo != null || orcamentoPecaSalvo.Count > 0)
                {
                    IList<PesquisaPecaOrcamentoDataSource> peca = new List<PesquisaPecaOrcamentoDataSource>();

                    foreach (var item in orcamentoPecaSalvo)
                    {
                        var pec = _pecaApplication.GetPecaByPecaId(item.PecaId);
                        peca.Add(new PesquisaPecaOrcamentoDataSource
                        {
                            PecaId = pec.PecaId,
                            Peca = pec.Descricao,
                            Valor = pec.Valor,
                            OrcamentoPecaId = item.Id
                        });
                    }

                    CarregaGridViewPeca(peca);
                }
            }

            CarregaInformacoesGridView();
        }

        private void CarregaGridViewPeca(IList<PesquisaPecaOrcamentoDataSource> pesquisaPecaOrcamentoDataSources)
        {
            dgvPecasOrcamentoGerados.DataSource = pesquisaPecaOrcamentoDataSources;
            dgvPecasOrcamentoGerados.Columns[0].HeaderText = "Código";
            dgvPecasOrcamentoGerados.Columns[0].Width = 50;
            dgvPecasOrcamentoGerados.Columns[1].HeaderText = "Produtos/Peças";
            dgvPecasOrcamentoGerados.Columns[1].Width = 330;
            dgvPecasOrcamentoGerados.Columns[2].HeaderText = "Valor";
            dgvPecasOrcamentoGerados.Columns[2].Width = 70;
            dgvPecasOrcamentoGerados.Columns[2].DefaultCellStyle.Format = "C2";
            dgvPecasOrcamentoGerados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CarregaGridViewMaodeObra(IList<PesquisaMaodeObraOrcamentoDataSource> pesquisaMaodeObraOrcamentoDataSources)
        {
            dgvMaodeObraOrcamentoGerado.DataSource = pesquisaMaodeObraOrcamentoDataSources;
            dgvMaodeObraOrcamentoGerado.Columns[0].HeaderText = "Código";
            dgvMaodeObraOrcamentoGerado.Columns[0].Width = 50;
            dgvMaodeObraOrcamentoGerado.Columns[1].HeaderText = "Mão de Obra";
            dgvMaodeObraOrcamentoGerado.Columns[1].Width = 330;
            dgvMaodeObraOrcamentoGerado.Columns[2].HeaderText = "Valor";
            dgvMaodeObraOrcamentoGerado.Columns[2].Width = 70;
            dgvMaodeObraOrcamentoGerado.Columns[2].DefaultCellStyle.Format = "C2";
            dgvMaodeObraOrcamentoGerado.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CarregaInformacoesOrcamento(Orcamento orcamento)
        {
            txtValorMaodeObraTotal.Text = 0.ToString("C");
            txtValorProdutosPecasTotal.Text = 0.ToString("C");
            txtValorAdicionalTotal.Text = orcamento.ValorAdicional.ToString("C");
            txtPercentualDesconto.Text = orcamento.PercentualDesconto.ToString("P");
            txtValorDescontoTotal.Text = orcamento.ValorDesconto.ToString("C");
            txtValorTotal.Text = orcamento.ValorTotal.ToString("C");
        }

        private void CarregaInformacoesGridView()
        {
            lblQtdRegistrosMaodeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObraOrcamentoGerado.Rows.Count.ToString();
            lblQtdRegistrosPecasProdutos.Text = "Quantidade de Registros: " + this.dgvPecasOrcamentoGerados.Rows.Count.ToString();
            decimal valorTotalGridMaodeObra = Convert.ToDecimal(dgvMaodeObraOrcamentoGerado.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));
            txtValorMaodeObraTotal.Text = (valorTotalGridMaodeObra.ToString("C"));
            decimal valorTotalGridProdutosPecas = Convert.ToDecimal(dgvPecasOrcamentoGerados.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["ValorTotal"].Value)));
            txtValorProdutosPecasTotal.Text = (valorTotalGridProdutosPecas.ToString("C"));
        }
    }
}
