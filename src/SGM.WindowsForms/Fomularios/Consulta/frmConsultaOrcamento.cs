using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.DataSources;
using SGM.Domain.Enumeration;
using SGM.WindowsForms.IoC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmConsultaOrcamento : Form
    {
        private readonly IOrcamentoApplication _orcamentoApplication;
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly IVeiculoApplication _veiculoApplication;

        public int orcamentoId = 0;
        public int clienteId = 0;
        public string placaVeiculo = "";

        public FrmConsultaOrcamento(IOrcamentoApplication orcamentoApplication, IClienteApplication clienteApplication, IClienteVeiculoApplication clienteVeiculoApplication, IVeiculoApplication veiculoApplication)
        {
            _orcamentoApplication = orcamentoApplication;
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _veiculoApplication = veiculoApplication;
            InitializeComponent();
        }

        private void FrmConsultaOrcamento_Load(object sender, EventArgs e)
        {
            IList<PesquisaOrcamentoDataSource> pesquisaOrcamento = new List<PesquisaOrcamentoDataSource>();

            if (orcamentoId > 0)
            {
                var orcamento = _orcamentoApplication.GetOrcamentoByOrcamentoId(orcamentoId);

                var clienteVeiculo = _clienteVeiculoApplication.GetVeiculoClienteByClienteVeiculoId(orcamento.ClienteVeiculoId);

                var cliente = _clienteApplication.GetClienteById(clienteVeiculo.ClienteId);

                var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                pesquisaOrcamento.Add(new PesquisaOrcamentoDataSource
                {
                    OrcamentoId = orcamento.OrcamentoId,
                    DataCadastro = orcamento.DataCadastro,
                    NomeCliente = cliente.NomeCliente,
                    MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                    Placa = clienteVeiculo.PlacaVeiculo,
                    Status = TranslateStatusOrcamento(orcamento.Status),
                    ValorTotal = orcamento.ValorTotal,
                    ValorAdicional = orcamento.ValorAdicional,
                    PercentualDesconto = orcamento.PercentualDesconto,
                    ValorDesconto = orcamento.ValorDesconto,
                    DataAlteracao = orcamento.DataAlteracao,
                    ClienteId = cliente.ClienteId
                });
            }
            else
            {
                var ultimosOrcamentos = _orcamentoApplication.GetUltimosOrcamentos();

                foreach (var orcamento in ultimosOrcamentos)
                {
                    var clienteVeiculo = _clienteVeiculoApplication.GetVeiculoClienteByClienteVeiculoId(orcamento.ClienteVeiculoId);

                    var cliente = _clienteApplication.GetClienteById(clienteVeiculo.ClienteId);

                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    pesquisaOrcamento.Add(new PesquisaOrcamentoDataSource
                    {
                        OrcamentoId = orcamento.OrcamentoId,
                        DataCadastro = orcamento.DataCadastro,
                        NomeCliente = cliente.NomeCliente,
                        MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                        Placa = clienteVeiculo.PlacaVeiculo,
                        Status = TranslateStatusOrcamento(orcamento.Status),
                        ValorTotal = orcamento.ValorTotal,
                        ValorAdicional = orcamento.ValorAdicional,
                        PercentualDesconto = orcamento.PercentualDesconto,
                        ValorDesconto = orcamento.ValorDesconto,
                        DataAlteracao = orcamento.DataAlteracao,
                        ClienteId = cliente.ClienteId
                    });
                }
            }

            CarregaGridView(pesquisaOrcamento);
        }

        private void BtnPlacaClienteVeiculoConsulta_Click(object sender, EventArgs e)
        {
            if (txtPlacaClienteVeiculoConsulta.Text != "" || txtPlacaClienteVeiculoConsulta.Text != null)
            {
                IList<PesquisaOrcamentoDataSource> pesquisaOrcamento = new List<PesquisaOrcamentoDataSource>();

                var cliente = _clienteApplication.GetClienteByLikePlacaOrNomeOrApelido(txtPlacaClienteVeiculoConsulta.Text);

                foreach (var veiculoCliente in cliente.ClienteVeiculo)
                {
                    var orcamentos = _orcamentoApplication.GetOrcamentoByClienteVeiculoId(veiculoCliente.ClienteVeiculoId);
                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(veiculoCliente.VeiculoId);
                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    foreach (var orcamento in orcamentos)
                    {
                        pesquisaOrcamento.Add(new PesquisaOrcamentoDataSource
                        {
                            OrcamentoId = orcamento.OrcamentoId,
                            DataCadastro = orcamento.DataCadastro,
                            NomeCliente = cliente.NomeCliente,
                            MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                            Placa = veiculoCliente.PlacaVeiculo,
                            Status = "",
                            ValorTotal = orcamento.ValorTotal,
                            ValorAdicional = orcamento.ValorAdicional,
                            PercentualDesconto = orcamento.PercentualDesconto,
                            ValorDesconto = orcamento.ValorDesconto,
                            DataAlteracao = orcamento.DataAlteracao,
                            ClienteId = cliente.ClienteId
                        });
                    }
                }

                CarregaGridView(pesquisaOrcamento);
            }
        }

        private void DgvOrcamentoHistoricoClienteVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.orcamentoId = Convert.ToInt32(dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value == null ? 0 : dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value);
                this.clienteId = Convert.ToInt32(dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[11].Value);
                this.placaVeiculo = Convert.ToString(dgvOrcamentoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[4].Value);
                this.Close();

                FrmDetalhesOrcamentoGerado formDetalheOrcamentoGerado = FormResolve.Resolve<FrmDetalhesOrcamentoGerado>();
                formDetalheOrcamentoGerado.orcamentoId = orcamentoId;
                formDetalheOrcamentoGerado.ShowDialog();
            }
        }

        private string TranslateStatusOrcamento(int statusOrcamento)
        {
            if (statusOrcamento == (int)EnumStatusOrcamento.IniciadoPendente)
            {
                return EnumStatusOrcamento.IniciadoPendente.ToString();
            }
            else if (statusOrcamento == (int)EnumStatusOrcamento.Expirado)
            {
                return EnumStatusOrcamento.Expirado.ToString();
            }
            else if (statusOrcamento == (int)EnumStatusOrcamento.Desistido)
            {
                return EnumStatusOrcamento.Desistido.ToString();
            }
            else if (statusOrcamento == (int)EnumStatusOrcamento.ConcluidoSemGerarServico)
            {
                return EnumStatusOrcamento.ConcluidoSemGerarServico.ToString();
            }
            else if (statusOrcamento == (int)EnumStatusOrcamento.GerouServico)
            {
                return EnumStatusOrcamento.GerouServico.ToString();
            }
            else
            {
                return "";
            }
        }

        public void CarregaGridView(IList<PesquisaOrcamentoDataSource> orcamentos)
        {
            dgvOrcamentoHistoricoClienteVeiculo.DataSource = orcamentos;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[0].HeaderText = "Código";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[0].Width = 50;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[1].HeaderText = "Status";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[1].Width = 80;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[2].HeaderText = "Cliente";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[2].Width = 150;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[3].HeaderText = "Veiculo";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[3].Width = 250;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[4].HeaderText = "Placa";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[4].Width = 80;

            dgvOrcamentoHistoricoClienteVeiculo.Columns[5].HeaderText = "Valor Total";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[5].Width = 70;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[5].DefaultCellStyle.Format = "C2";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvOrcamentoHistoricoClienteVeiculo.Columns[6].HeaderText = "Valor Adicional";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[6].Width = 70;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[6].DefaultCellStyle.Format = "C2";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvOrcamentoHistoricoClienteVeiculo.Columns[7].HeaderText = "% de Desconto";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[7].Width = 70;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[7].DefaultCellStyle.Format = "P1";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrcamentoHistoricoClienteVeiculo.Columns[8].HeaderText = "Valor Desconto";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[8].Width = 70;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Format = "C2";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvOrcamentoHistoricoClienteVeiculo.Columns[9].HeaderText = "Data Cadastro";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[9].Width = 110;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";

            dgvOrcamentoHistoricoClienteVeiculo.Columns[10].HeaderText = "Data Alteração";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[10].Width = 110;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";

            dgvOrcamentoHistoricoClienteVeiculo.Columns[11].HeaderText = "ClienteId";
            dgvOrcamentoHistoricoClienteVeiculo.Columns[11].Width = 50;
            dgvOrcamentoHistoricoClienteVeiculo.Columns[11].Visible = false;
        }
    }
}