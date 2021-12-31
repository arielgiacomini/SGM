using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.DataSources;
using SGM.Domain.Enumeration;
using SGM.WindowsForms.IoC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmConsultaServico : Form
    {
        private readonly IServicoApplication _servicoApplication;
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly IVeiculoApplication _veiculoApplication;

        public int servicoId = 0;
        public int clienteId = 0;
        public string placaVeiculo = "";

        public FrmConsultaServico(IServicoApplication servicoApplication, IClienteApplication clienteApplication, IClienteVeiculoApplication clienteVeiculoApplication, IVeiculoApplication veiculoApplication)
        {
            _servicoApplication = servicoApplication;
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _veiculoApplication = veiculoApplication;
            InitializeComponent();
        }

        private void FrmConsultaHistoricoServicoClienteVeiculo_Load(object sender, EventArgs e)
        {
            IList<PesquisaServicoDataSource> pesquisaServico = new List<PesquisaServicoDataSource>();

            if (servicoId > 0)
            {
                var servico = _servicoApplication.GetServicoByServicoId(servicoId);

                var clienteVeiculo = _clienteVeiculoApplication.GetVeiculoClienteByClienteVeiculoId(servico.ClienteVeiculoId);

                var cliente = _clienteApplication.GetClienteById(clienteVeiculo.ClienteId);

                var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                pesquisaServico.Add(new PesquisaServicoDataSource
                {
                    ServicoId = servico.ServicoId,
                    DataCadastro = servico.DataCadastro,
                    NomeCliente = cliente.NomeCliente,
                    MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                    Placa = clienteVeiculo.PlacaVeiculo,
                    Status = StatusServico.TranslateStatusServico(servico.Status),
                    ValorTotal = servico.ValorTotal,
                    ValorAdicional = servico.ValorAdicional,
                    PercentualDesconto = servico.PercentualDesconto,
                    ValorDesconto = servico.ValorDesconto,
                    DataAlteracao = servico.DataAlteracao,
                    ClienteId = cliente.ClienteId
                });
            }
            else
            {
                var ultimosServicos = _servicoApplication.GetUltimosServicos();

                foreach (var servico in ultimosServicos)
                {
                    var clienteVeiculo = _clienteVeiculoApplication.GetVeiculoClienteByClienteVeiculoId(servico.ClienteVeiculoId);

                    var cliente = _clienteApplication.GetClienteById(clienteVeiculo.ClienteId);

                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    pesquisaServico.Add(new PesquisaServicoDataSource
                    {
                        ServicoId = servico.ServicoId,
                        DataCadastro = servico.DataCadastro,
                        NomeCliente = cliente.NomeCliente,
                        MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                        Placa = clienteVeiculo.PlacaVeiculo,
                        Status = StatusServico.TranslateStatusServico(servico.Status),
                        ValorTotal = servico.ValorTotal,
                        ValorAdicional = servico.ValorAdicional,
                        PercentualDesconto = servico.PercentualDesconto,
                        ValorDesconto = servico.ValorDesconto,
                        DataAlteracao = servico.DataAlteracao,
                        ClienteId = cliente.ClienteId
                    });
                }
            }

            CarregaGridView(pesquisaServico);
        }

        private void BtnPlacaClienteVeiculoConsulta_Click(object sender, EventArgs e)
        {
            if (txtPlacaClienteVeiculoConsulta.Text != "" || txtPlacaClienteVeiculoConsulta.Text != null)
            {
                IList<PesquisaServicoDataSource> pesquisaOrcamento = new List<PesquisaServicoDataSource>();

                var cliente = _clienteApplication.GetClienteByLikePlacaOrNomeOrApelido(txtPlacaClienteVeiculoConsulta.Text);

                foreach (var veiculoCliente in cliente.ClienteVeiculo)
                {
                    var servicos = _servicoApplication.GetServicoByClienteVeiculoId(veiculoCliente.ClienteVeiculoId);
                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(veiculoCliente.VeiculoId);
                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    foreach (var servico in servicos)
                    {
                        pesquisaOrcamento.Add(new PesquisaServicoDataSource
                        {
                            ServicoId = servico.ServicoId,
                            DataCadastro = servico.DataCadastro,
                            NomeCliente = cliente.NomeCliente,
                            MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                            Placa = veiculoCliente.PlacaVeiculo,
                            Status = "",
                            ValorTotal = servico.ValorTotal,
                            ValorAdicional = servico.ValorAdicional,
                            PercentualDesconto = servico.PercentualDesconto,
                            ValorDesconto = servico.ValorDesconto,
                            DataAlteracao = servico.DataAlteracao,
                            ClienteId = cliente.ClienteId
                        });
                    }
                }

                CarregaGridView(pesquisaOrcamento);
            }
        }

        private void DgvServicoHistoricoClienteVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.servicoId = Convert.ToInt32(dgvServicoHistoricoClienteVeiculo.Rows[e.RowIndex].Cells[0].Value ?? 0);

                FrmDetalhesServicoGerado formDetalhesServicoGerado = FormResolve.Resolve<FrmDetalhesServicoGerado>();
                formDetalhesServicoGerado.servicoId = servicoId;
                formDetalhesServicoGerado.ShowDialog();
            }
        }

        public void CarregaGridView(IList<PesquisaServicoDataSource> orcamentos)
        {
            dgvServicoHistoricoClienteVeiculo.DataSource = orcamentos;
            dgvServicoHistoricoClienteVeiculo.Columns[0].HeaderText = "Código";
            dgvServicoHistoricoClienteVeiculo.Columns[0].Width = 50;
            dgvServicoHistoricoClienteVeiculo.Columns[1].HeaderText = "Status";
            dgvServicoHistoricoClienteVeiculo.Columns[1].Width = 165;
            dgvServicoHistoricoClienteVeiculo.Columns[2].HeaderText = "Cliente";
            dgvServicoHistoricoClienteVeiculo.Columns[2].Width = 150;
            dgvServicoHistoricoClienteVeiculo.Columns[3].HeaderText = "Veiculo";
            dgvServicoHistoricoClienteVeiculo.Columns[3].Width = 250;
            dgvServicoHistoricoClienteVeiculo.Columns[4].HeaderText = "Placa";
            dgvServicoHistoricoClienteVeiculo.Columns[4].Width = 80;

            dgvServicoHistoricoClienteVeiculo.Columns[5].HeaderText = "Valor Total";
            dgvServicoHistoricoClienteVeiculo.Columns[5].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[5].DefaultCellStyle.Format = "C2";
            dgvServicoHistoricoClienteVeiculo.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvServicoHistoricoClienteVeiculo.Columns[6].HeaderText = "Valor Adicional";
            dgvServicoHistoricoClienteVeiculo.Columns[6].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[6].DefaultCellStyle.Format = "C2";
            dgvServicoHistoricoClienteVeiculo.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvServicoHistoricoClienteVeiculo.Columns[7].HeaderText = "% de Desconto";
            dgvServicoHistoricoClienteVeiculo.Columns[7].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[7].DefaultCellStyle.Format = "P1";
            dgvServicoHistoricoClienteVeiculo.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvServicoHistoricoClienteVeiculo.Columns[8].HeaderText = "Valor Desconto";
            dgvServicoHistoricoClienteVeiculo.Columns[8].Width = 70;
            dgvServicoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Format = "C2";
            dgvServicoHistoricoClienteVeiculo.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvServicoHistoricoClienteVeiculo.Columns[9].HeaderText = "Data Cadastro";
            dgvServicoHistoricoClienteVeiculo.Columns[9].Width = 110;
            dgvServicoHistoricoClienteVeiculo.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";

            dgvServicoHistoricoClienteVeiculo.Columns[10].HeaderText = "Data Alteração";
            dgvServicoHistoricoClienteVeiculo.Columns[10].Width = 110;
            dgvServicoHistoricoClienteVeiculo.Columns[10].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";

            dgvServicoHistoricoClienteVeiculo.Columns[11].HeaderText = "ClienteId";
            dgvServicoHistoricoClienteVeiculo.Columns[11].Width = 50;
            dgvServicoHistoricoClienteVeiculo.Columns[11].Visible = false;
        }
    }
}