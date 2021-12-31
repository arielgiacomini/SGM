using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.DataSources;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmDetalhesServicoGerado : Form
    {
        public int servicoId = 0;
        private readonly IServicoApplication _servicoApplication;
        private readonly IPecaApplication _pecaApplication;
        private readonly IMaodeObraApplication _maoDeObraApplication;

        public FrmDetalhesServicoGerado(IServicoApplication servicoApplication, IPecaApplication pecaApplication, IMaodeObraApplication maodeObraApplication)
        {
            _servicoApplication = servicoApplication;
            _pecaApplication = pecaApplication;
            _maoDeObraApplication = maodeObraApplication;
            InitializeComponent();
        }

        private void FrmDetalhesServicoGerado_Load(object sender, EventArgs e)
        {
            var servicoGerado = _servicoApplication.GetServicoByServicoId(servicoId);

            if (servicoGerado != null || servicoGerado.ServicoId != 0)
            {
                CarregaInformacoesServico(servicoGerado);

                var servicoMaodeObraSalvo = _servicoApplication.GetServicoMaodeObraByServicoId(servicoId);

                if (servicoMaodeObraSalvo != null || servicoMaodeObraSalvo.Count > 0)
                {
                    IList<PesquisaMaodeObraServicoDataSource> maoDeObra = new List<PesquisaMaodeObraServicoDataSource>();

                    foreach (var item in servicoMaodeObraSalvo)
                    {
                        var mao = _maoDeObraApplication.GetMaodeObraById(item.MaodeObraId);

                        maoDeObra.Add(new PesquisaMaodeObraServicoDataSource
                        {
                            MaodeObraId = mao.MaodeObraId,
                            MaodeObra = mao.Descricao,
                            Valor = mao.Valor,
                            ServicoMaodeObraId = item.Id
                        });
                    }

                    CarregaGridViewMaodeObra(maoDeObra);
                }

                var servicoPecaSalvo = _servicoApplication.GetServicoPecaByServicoId(servicoId);

                if (servicoPecaSalvo != null || servicoPecaSalvo.Count > 0)
                {
                    IList<PesquisaPecaServicoDataSource> peca = new List<PesquisaPecaServicoDataSource>();

                    foreach (var item in servicoPecaSalvo)
                    {
                        var pec = _pecaApplication.GetPecaByPecaId(item.PecaId);
                        peca.Add(new PesquisaPecaServicoDataSource
                        {
                            PecaId = pec.PecaId,
                            Peca = pec.Descricao,
                            Valor = pec.Valor,
                            ServicoPecaId = item.Id
                        });
                    }

                    CarregaGridViewPeca(peca);
                }
            }

            CarregaInformacoesGridView();
        }

        private void CarregaGridViewPeca(IList<PesquisaPecaServicoDataSource> pesquisaPecaServicoDataSources)
        {
            dgvPecasServicosGerados.DataSource = pesquisaPecaServicoDataSources;
            dgvPecasServicosGerados.Columns[0].HeaderText = "Código";
            dgvPecasServicosGerados.Columns[0].Width = 50;
            dgvPecasServicosGerados.Columns[1].HeaderText = "Produtos/Peças";
            dgvPecasServicosGerados.Columns[1].Width = 330;
            dgvPecasServicosGerados.Columns[2].HeaderText = "Valor";
            dgvPecasServicosGerados.Columns[2].Width = 70;
            dgvPecasServicosGerados.Columns[2].DefaultCellStyle.Format = "C2";
            dgvPecasServicosGerados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CarregaGridViewMaodeObra(IList<PesquisaMaodeObraServicoDataSource> pesquisaMaodeObraServicoDataSources)
        {
            dgvMaodeObraServicoGerado.DataSource = pesquisaMaodeObraServicoDataSources;
            dgvMaodeObraServicoGerado.Columns[0].HeaderText = "Código";
            dgvMaodeObraServicoGerado.Columns[0].Width = 50;
            dgvMaodeObraServicoGerado.Columns[1].HeaderText = "Mão de Obra";
            dgvMaodeObraServicoGerado.Columns[1].Width = 330;
            dgvMaodeObraServicoGerado.Columns[2].HeaderText = "Valor";
            dgvMaodeObraServicoGerado.Columns[2].Width = 70;
            dgvMaodeObraServicoGerado.Columns[2].DefaultCellStyle.Format = "C2";
            dgvMaodeObraServicoGerado.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CarregaInformacoesServico(Servico servico)
        {
            txtValorMaodeObraTotal.Text = servico.ValorMaodeObra.ToString("C");
            txtValorProdutosPecasTotal.Text = servico.ValorPeca.ToString("C");
            txtValorAdicionalTotal.Text = servico.ValorAdicional.ToString("C");
            txtPercentualDesconto.Text = servico.PercentualDesconto.ToString("P");
            txtValorDescontoTotal.Text = servico.ValorDesconto.ToString("C");
            txtValorTotal.Text = servico.ValorTotal.ToString("C");
            txtDescricaoServico.Text = servico.Descricao;
            lblServicoId.Text = lblServicoId.Text + " 000" + servico.ServicoId.ToString();
        }

        private void CarregaInformacoesGridView()
        {
            lblQtdRegistrosMaodeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObraServicoGerado.Rows.Count.ToString();
            lblQtdRegistrosPecasProdutos.Text = "Quantidade de Registros: " + this.dgvPecasServicosGerados.Rows.Count.ToString();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}