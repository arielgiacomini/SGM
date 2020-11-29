using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.DataSources;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmGerarOrcamento : FrmModeloDeFormularioDeCadastro
    {
        private readonly IClienteApplication _clienteApplication;
        private readonly IOrcamentoApplication _orcamentoApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly IVeiculoApplication _veiculoApplication;
        private readonly IMaodeObraApplication _maoDeObraApplication;
        private readonly IPecaApplication _pecaApplication;

        public FrmGerarOrcamento(IClienteApplication clienteApplication, IOrcamentoApplication orcamentoApplication, IClienteVeiculoApplication clienteVeiculoApplication, IVeiculoApplication veiculoApplication, IMaodeObraApplication maodeObraApplication, IPecaApplication pecaApplication)
        {
            _clienteApplication = clienteApplication;
            _orcamentoApplication = orcamentoApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _veiculoApplication = veiculoApplication;
            _maoDeObraApplication = maodeObraApplication;
            _pecaApplication = pecaApplication;

            InitializeComponent();
        }

        public int codigo = 0;
        public int clienteId = 0;
        public int veiculoId = 0;
        public string placaVeiculo = "";
        public string CellCliente = "";
        public string VerificaOrcamento = "";
        public decimal txtVA = 0;
        public decimal txtVD = 0;
        public decimal txtVP = 0;
        public decimal txtVM = 0;
        public decimal txtVT = 0;

        public void LimpaTela()
        {
            txtClienteId.Clear();
            txtConsultaCliente.Clear();
            txtClienteSelecionado.Clear();
            txtDescricao.Clear();
            txtOrcamentoId.Clear();
            txtPercentualDesconto.Clear();
            txtValorAdicional.Clear();
            txtValorDesconto.Clear();
            txtValorTotal.Clear();
            txtValorTotalMaodeObra.Clear();
            txtValorTotalPecas.Clear();

            for (int i = 0; i < dgvCliente.RowCount; i++)
            {
                dgvCliente.Rows[i].DataGridView.Columns.Clear();
            }

            for (int i = 0; i < dgvMaodeObra.RowCount; i++)
            {
                dgvMaodeObra.Rows[i].DataGridView.Columns.Clear();
            }

            for (int i = 0; i < dgvPeca.RowCount; i++)
            {
                dgvPeca.Rows[i].DataGridView.Columns.Clear();
            }

            lblQtdRegistrosMaoDeObra.Text = "Quantidade de Registros: ";
            lblQtdRegistrosPecas.Text = "Quantidade de Registros: ";
        }

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {
            var cliente = _clienteApplication.GetClienteByLikePlacaOrNomeOrApelido(txtConsultaCliente.Text);

            var dataSource = new List<PesquisaClienteOrcamentoDataSource>();

            foreach (var clienteVeiculo in cliente.ClienteVeiculo)
            {
                var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                dataSource.Add(new PesquisaClienteOrcamentoDataSource
                {
                    ClienteId = cliente.ClienteId,
                    NomeCliente = cliente.NomeCliente,
                    PlacaVeiculo = clienteVeiculo.PlacaVeiculo,
                    MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                    ClienteVeiculoId = clienteVeiculo.ClienteVeiculoId
                });
            }

            dgvCliente.DataSource = dataSource;
            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 50;
            dgvCliente.Columns[1].HeaderText = "Cliente";
            dgvCliente.Columns[1].Width = 296;
            dgvCliente.Columns[2].HeaderText = "Placa Veículo";
            dgvCliente.Columns[2].Width = 120;
            dgvCliente.Columns[3].HeaderText = "Marca/Modelo";
            dgvCliente.Columns[3].Width = 232;
            dgvCliente.Columns[4].HeaderText = "ClienteVeiculoId";
            dgvCliente.Columns[4].Width = 50;
            dgvCliente.Columns[4].Visible = false;
        }

        private void FrmGerarOrcamento_Load(object sender, EventArgs e)
        {
            OrganizarTelaOrcamento();

            if (clienteId != 0)
            {
                var cliente = _clienteApplication.GetClienteById(clienteId);

                var dataSource = new List<PesquisaClienteOrcamentoDataSource>();

                foreach (var clienteVeiculo in cliente.ClienteVeiculo)
                {
                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    dataSource.Add(new PesquisaClienteOrcamentoDataSource
                    {
                        ClienteId = cliente.ClienteId,
                        NomeCliente = cliente.NomeCliente,
                        PlacaVeiculo = clienteVeiculo.PlacaVeiculo,
                        MarcaModeloVeiculo = marca.Marca + " / " + veiculo.Modelo,
                        ClienteVeiculoId = clienteVeiculo.ClienteVeiculoId
                    });
                }

                dgvCliente.DataSource = dataSource;
                dgvCliente.Columns[0].HeaderText = "Código";
                dgvCliente.Columns[0].Width = 50;
                dgvCliente.Columns[1].HeaderText = "Cliente";
                dgvCliente.Columns[1].Width = 296;
                dgvCliente.Columns[2].HeaderText = "Placa Veículo";
                dgvCliente.Columns[2].Width = 120;
                dgvCliente.Columns[3].HeaderText = "Marca/Modelo";
                dgvCliente.Columns[3].Width = 232;
                dgvCliente.Columns[4].HeaderText = "ClienteVeiculoId";
                dgvCliente.Columns[4].Width = 50;
                dgvCliente.Columns[4].Visible = false;

                this.operacao = "inserir";
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);

                txtConsultaCliente.Enabled = false;
                btnConsultaCliente.Enabled = false;
                dgvCliente.Enabled = false;

                txtValorAdicional.Enabled = true;
                txtPercentualDesconto.Enabled = true;

                txtClienteId.Text = cliente.ClienteId.ToString();
                txtClienteSelecionado.Text = cliente.NomeCliente.ToString();
                txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
                txtDescricao.Text = "PESQUISANDO";

                Orcamento orcamento = new Orcamento
                {
                    ClienteVeiculoId = Convert.ToInt32(txtClienteId.Text),
                    Status = (int)EnumStatusOrcamento.IniciadoPendente
                };

                var orcamentoId = _orcamentoApplication.SalvarOrcamento(orcamento);

                txtOrcamentoId.Text = orcamentoId.ToString();
            }
        }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                this.CellCliente = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells[1].Value);
                txtClienteSelecionado.Text = Convert.ToString(CellCliente);
                txtClienteId.Text = Convert.ToString(codigo);
                txtClienteVeiculoId.Text = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells[4].Value);
                dgvCliente.CurrentRow.Selected = false;
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);

            txtValorAdicional.Enabled = true;
            txtPercentualDesconto.Enabled = true;
            txtClienteId.Text = Convert.ToString(1);
            txtClienteVeiculoId.Text = Convert.ToString(25);
            txtClienteSelecionado.Text = Convert.ToString("SEM CLIENTE");
            txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
            txtDescricao.Text = "PESQUISANDO";

            Orcamento orcamento = new Orcamento
            {
                ClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text),
                Descricao = txtDescricao.Text,
                Status = (int)EnumStatusOrcamento.IniciadoPendente,
                DataCadastro = DateTime.Now,
                DataAlteracao = null,
                Ativo = true,
                OrcamentoMaodeObra = new List<OrcamentoMaodeObra>(),
                OrcamentoPeca = new List<OrcamentoPeca>()
            };

            var orcamentoId = _orcamentoApplication.SalvarOrcamento(orcamento);

            txtOrcamentoId.Text = orcamentoId.ToString();
        }

        private void BtnAdicionarMaodeObra_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text == "")
            {
                MessageBox.Show("Você precisa primeiro incluir um cliente acima!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FrmConsultaMaoDeObra consultaMaodeObra = new FrmConsultaMaoDeObra();
                consultaMaodeObra.ShowDialog();

                if (consultaMaodeObra.codigo != 0)
                {
                    OrcamentoMaodeObra orcamentoMaodeObra = new OrcamentoMaodeObra()
                    {
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        MaodeObraId = consultaMaodeObra.codigo
                    };

                    var Id = _orcamentoApplication.SalvarOrcamentoMaodeObra(orcamentoMaodeObra);

                    var orcamentoMaodeObraSalvo = _orcamentoApplication.GetOrcamentoMaodeObraByOrcamentoId(Convert.ToInt32(txtOrcamentoId.Text));

                    IList<PesquisaMaodeObraOrcamentoDataSource> maoDeObra = new List<PesquisaMaodeObraOrcamentoDataSource>();

                    foreach (var item in orcamentoMaodeObraSalvo)
                    {
                        var mao = _maoDeObraApplication.GetMaodeObraById(item.MaodeObraId);

                        maoDeObra.Add(new PesquisaMaodeObraOrcamentoDataSource
                        {
                            MaodeObraId = mao.MaodeObraId,
                            MaodeObra = mao.Descricao,
                            Valor = mao.Valor,
                            OrcamentoMaodeObraId = Id
                        });
                    }

                    dgvMaodeObra.DataSource = maoDeObra;
                    dgvMaodeObra.Columns[0].HeaderText = "Código";
                    dgvMaodeObra.Columns[0].Width = 50;
                    dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                    dgvMaodeObra.Columns[1].Width = 330;
                    dgvMaodeObra.Columns[2].HeaderText = "Valor";
                    dgvMaodeObra.Columns[2].Width = 70;
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvMaodeObra.Columns[3].HeaderText = "OrcamentoMaoDeObraId";
                    dgvMaodeObra.Columns[3].Width = 20;
                    dgvMaodeObra.Columns[3].Visible = false;
                }

                OrganizarTelaOrcamento();
            }
        }

        private void BtnAdicionarPeca_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text == "")
            {
                MessageBox.Show("Você precisa primeiro incluir um cliente acima!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmConsultaPeca consultaPeca = new frmConsultaPeca();
                consultaPeca.ShowDialog();

                if (consultaPeca.codigo != 0)
                {
                    OrcamentoPeca orcamentoPeca = new OrcamentoPeca()
                    {
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        PecaId = consultaPeca.codigo
                    };

                    var Id = _orcamentoApplication.SalvarOrcamentoPeca(orcamentoPeca);

                    var orcamentoPecaSalvo = _orcamentoApplication.GetOrcamentoPecaByOrcamentoId(Convert.ToInt32(txtOrcamentoId.Text));

                    IList<PesquisaPecaOrcamentoDataSource> peca = new List<PesquisaPecaOrcamentoDataSource>();

                    foreach (var item in orcamentoPecaSalvo)
                    {
                        var mao = _pecaApplication.GetPecaByPecaId(item.PecaId);
                        peca.Add(new PesquisaPecaOrcamentoDataSource
                        {
                            PecaId = mao.PecaId,
                            Peca = mao.Descricao,
                            Valor = mao.Valor,
                            OrcamentoPecaId = Id
                        });
                    }

                    dgvPeca.DataSource = peca;
                    dgvPeca.Columns[0].HeaderText = "Código";
                    dgvPeca.Columns[0].Width = 50;
                    dgvPeca.Columns[1].HeaderText = "Peça";
                    dgvPeca.Columns[1].Width = 330;
                    dgvPeca.Columns[2].HeaderText = "Valor Integral";
                    dgvPeca.Columns[2].Width = 70;
                    dgvPeca.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvPeca.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPeca.Columns[3].HeaderText = "OrcamentoPecaId";
                    dgvPeca.Columns[3].Width = 20;
                    dgvPeca.Columns[3].Visible = false;
                }

                OrganizarTelaOrcamento();
            }
        }

        private void DgvMaodeObra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvMaodeObra.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void DgvPeca_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvPeca.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var orcamentoSalvo = _orcamentoApplication.GetOrcamentoByOrcamentoId(Convert.ToInt32(txtOrcamentoId.Text));

                Orcamento orcamento = new Orcamento
                {
                    OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                    ClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text),
                    ColaboradorId = 0,
                    Descricao = txtDescricao.Text,
                    ValorMaodeObra = txtValorTotalMaodeObra.Text == "" ? 0 : Convert.ToDecimal(txtValorTotalMaodeObra.Text.Replace("R$ ", "")),
                    ValorPeca = txtValorTotalPecas.Text == "" ? 0 : Convert.ToDecimal(txtValorTotalPecas.Text.Replace("R$ ", "")),
                    ValorAdicional = txtValorAdicional.Text == "R$ 0,00" ? 0 : Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", "")),
                    PercentualDesconto = txtValorAdicional.Text == "R$ 0,00" ? 0 : (Convert.ToDecimal(txtPercentualDesconto.Text.Replace("%", "")) / 100),
                    ValorDesconto = Convert.ToDecimal(txtValorDesconto.Text.Replace("R$ ", "")),
                    ValorTotal = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")),
                    Status = (int)EnumStatusOrcamento.ConcluidoSemGerarServico,
                    Ativo = true,
                    DataCadastro = orcamentoSalvo.DataCadastro,
                    DataAlteracao = DateTime.Now
                };

                _orcamentoApplication.AtualizarOrcamento(orcamento);

                MessageBox.Show("Cadastro alterado com sucesso! Número do Orçamento: " + orcamento.OrcamentoId.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvCliente.DataSource = null;
                dgvMaodeObra.DataSource = null;
                dgvPeca.DataSource = null;

                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TxtValorAdicional_Leave(object sender, EventArgs e)
        {
            if (txtValorTotalMaodeObra.Text.Replace("R$ 0,00", "") != "")
            {
                txtVM = Convert.ToDecimal(txtValorTotalMaodeObra.Text.Replace("R$ ", ""));
            }

            if (txtValorTotalPecas.Text.Replace("R$ 0,00", "") != "")
            {
                txtVP = Convert.ToDecimal(txtValorTotalPecas.Text.Replace("R$ ", ""));
            }

            if (txtValorAdicional.Text.Replace("R$ 0,00", "") != "")
            {
                txtVA = Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", ""));
            }

            txtValorAdicional.Text = (txtVA.ToString("C"));

            txtVT = 0;
            txtVT = (txtVM + txtVP + txtVA);

            txtValorTotal.Text = (txtVT.ToString("C"));

            //DialogResult res = MessageBox.Show("Deseja realmente incluir esse adicional de: " + txtValorAdicional.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (res.ToString() == "Yes")
            //{
            //    txtValorAdicional.Enabled = false;
            //}

            txtValorAdicional.Enabled = false;
        }

        private void TxtPercentualDesconto_Leave(object sender, EventArgs e)
        {
            decimal PDesc = Convert.ToDecimal(txtPercentualDesconto.Text.Replace("%", ""));
            decimal VTota = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
            decimal VDesc = Convert.ToDecimal(txtValorDesconto.Text.Replace("R$ ", ""));
            txtValorDesconto.Text = Convert.ToString(Convert.ToDecimal(((VTota / 100) * PDesc)).ToString("C"));
            VDesc = Convert.ToDecimal((VTota / 100) * PDesc);
            txtValorTotal.Text = Convert.ToString((VTota - VDesc).ToString("C"));
            txtPercentualDesconto.Text = Convert.ToString(Convert.ToDecimal(PDesc / 100).ToString("P"));

            if (PDesc != 0)
            {
                txtPercentualDesconto.Enabled = false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaHistoricoOrcamentoClienteVeiculo consultaHistoricoOrcamento = new frmConsultaHistoricoOrcamentoClienteVeiculo();
            consultaHistoricoOrcamento.ShowDialog();

            if (consultaHistoricoOrcamento.codigo != 0)
            {
                var orcamento = _orcamentoApplication.GetOrcamentoByOrcamentoId(consultaHistoricoOrcamento.codigo);

                txtOrcamentoId.Text = Convert.ToString(orcamento.OrcamentoId);
                txtClienteId.Text = Convert.ToString(orcamento.ClienteVeiculoId);
                txtDescricao.Text = Convert.ToString(orcamento.Descricao);
                txtValorAdicional.Text = Convert.ToString(orcamento.ValorAdicional);
                txtPercentualDesconto.Text = Convert.ToString(orcamento.PercentualDesconto);
                txtValorDesconto.Text = Convert.ToString(orcamento.ValorDesconto);
                txtValorTotal.Text = Convert.ToString(orcamento.ValorTotal);

                var orcamentoMaodeObraSalvo = _orcamentoApplication.GetOrcamentoMaodeObraByOrcamentoId(orcamento.OrcamentoId);

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

                dgvMaodeObra.DataSource = maoDeObra;
                dgvMaodeObra.Columns[0].HeaderText = "Código";
                dgvMaodeObra.Columns[0].Width = 50;
                dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                dgvMaodeObra.Columns[1].Width = 330;
                dgvMaodeObra.Columns[2].HeaderText = "Valor";
                dgvMaodeObra.Columns[2].Width = 70;
                dgvMaodeObra.Columns[2].DefaultCellStyle.Format = "C2";
                dgvMaodeObra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvMaodeObra.Columns[3].HeaderText = "OrcamentoMaoDeObraId";
                dgvMaodeObra.Columns[3].Width = 20;
                dgvMaodeObra.Columns[3].Visible = false;

                var orcamentoPecaSalvo = _orcamentoApplication.GetOrcamentoPecaByOrcamentoId(Convert.ToInt32(txtOrcamentoId.Text));

                IList<PesquisaPecaOrcamentoDataSource> peca = new List<PesquisaPecaOrcamentoDataSource>();

                foreach (var item in orcamentoPecaSalvo)
                {
                    var mao = _pecaApplication.GetPecaByPecaId(item.PecaId);
                    peca.Add(new PesquisaPecaOrcamentoDataSource
                    {
                        PecaId = mao.PecaId,
                        Peca = mao.Descricao,
                        Valor = mao.Valor,
                        OrcamentoPecaId = item.Id
                    });
                }

                dgvPeca.DataSource = peca;
                dgvPeca.Columns[0].HeaderText = "Código";
                dgvPeca.Columns[0].Width = 50;
                dgvPeca.Columns[1].HeaderText = "Peça";
                dgvPeca.Columns[1].Width = 330;
                dgvPeca.Columns[2].HeaderText = "Valor Integral";
                dgvPeca.Columns[2].Width = 70;
                dgvPeca.Columns[2].DefaultCellStyle.Format = "C2";
                dgvPeca.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DisponibilizarBotoesTela(EnumControleTelas.DisponivelExcluirAndAlterar);
            }

            else
            {
                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
            }

            consultaHistoricoOrcamento.Dispose();
        }

        private void DgvMaodeObra_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maoDeObraId = Convert.ToInt32(dgvMaodeObra.Rows[e.RowIndex].Cells[0].Value);
                int orcamentoMaodeObraId = Convert.ToInt32(dgvMaodeObra.Rows[e.RowIndex].Cells[3].Value);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    OrcamentoMaodeObra orcamentoMaodeObra = new OrcamentoMaodeObra()
                    {
                        Id = orcamentoMaodeObraId,
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        MaodeObraId = maoDeObraId
                    };

                    _orcamentoApplication.DeletarOrcamentoMaodeObra(orcamentoMaodeObra);

                    var orcamentoMaodeObraSalvo = _orcamentoApplication.GetOrcamentoMaodeObraByOrcamentoId(Convert.ToInt32(txtOrcamentoId.Text));

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

                    dgvMaodeObra.DataSource = maoDeObra;
                    dgvMaodeObra.Columns[0].HeaderText = "Código";
                    dgvMaodeObra.Columns[0].Width = 50;
                    dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                    dgvMaodeObra.Columns[1].Width = 330;
                    dgvMaodeObra.Columns[2].HeaderText = "Valor";
                    dgvMaodeObra.Columns[2].Width = 70;
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvMaodeObra.Columns[3].HeaderText = "OrcamentoMaoDeObraId";
                    dgvMaodeObra.Columns[3].Width = 20;
                    dgvMaodeObra.Columns[3].Visible = false;
                }

                OrganizarTelaOrcamento();
            }
        }

        private void DgvPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int pecaId = Convert.ToInt32(dgvPeca.Rows[e.RowIndex].Cells[0].Value);
                int orcamentoPecaId = Convert.ToInt32(dgvPeca.Rows[e.RowIndex].Cells[3].Value);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    OrcamentoPeca orcamentoPeca = new OrcamentoPeca()
                    {
                        Id = orcamentoPecaId,
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        PecaId = pecaId
                    };

                    _orcamentoApplication.DeletarOrcamentoPeca(orcamentoPeca);

                    var orcamentoPecaSalvo = _orcamentoApplication.GetOrcamentoPecaByOrcamentoId(Convert.ToInt32(txtOrcamentoId.Text));

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

                    dgvPeca.DataSource = peca;
                    dgvPeca.Columns[0].HeaderText = "Código";
                    dgvPeca.Columns[0].Width = 50;
                    dgvPeca.Columns[1].HeaderText = "Peça";
                    dgvPeca.Columns[1].Width = 330;
                    dgvPeca.Columns[2].HeaderText = "Valor Integral";
                    dgvPeca.Columns[2].Width = 70;
                    dgvPeca.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvPeca.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPeca.Columns[3].HeaderText = "OrcamentoMaoDeObraId";
                    dgvPeca.Columns[3].Width = 20;
                    dgvPeca.Columns[3].Visible = false;
                }

                OrganizarTelaOrcamento();
            }
        }

        private void OrganizarTelaOrcamento()
        {
            lblQtdRegistrosMaoDeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObra.Rows.Count.ToString();
            lblQtdRegistrosPecas.Text = "Quantidade de Registros: " + this.dgvPeca.Rows.Count.ToString();

            txtVM = Convert.ToDecimal(dgvMaodeObra.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));
            txtVP = Convert.ToDecimal(dgvPeca.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));

            txtValorTotalMaodeObra.Text = (txtVM.ToString("C"));
            txtValorTotalPecas.Text = (txtVP.ToString("C"));

            if (txtValorTotalPecas.Text.Replace("R$ 0,00", "") != "")
            {
                txtVP = Convert.ToDecimal(txtValorTotalPecas.Text.Replace("R$ ", ""));
            }

            if (txtValorAdicional.Text.Replace("R$ 0,00", "") != "")
            {
                txtVA = Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", ""));
            }

            txtVT = 0;
            txtVT = (txtVM + txtVP + txtVA);

            txtValorTotal.Text = (txtVT.ToString("C"));
        }
    }
}