using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.DataSources;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using SGM.Domain.Utils;
using SGM.WindowsForms.IoC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmGerarServico : FrmModeloDeFormularioDeCadastro
    {

        private readonly IClienteApplication _clienteApplication;
        private readonly IServicoApplication _servicoApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly IVeiculoApplication _veiculoApplication;
        private readonly IMaodeObraApplication _maoDeObraApplication;
        private readonly IPecaApplication _pecaApplication;

        public FrmGerarServico(IClienteApplication clienteApplication, IServicoApplication servicoApplication, IClienteVeiculoApplication clienteVeiculoApplication, IVeiculoApplication veiculoApplication, IMaodeObraApplication maodeObraApplication, IPecaApplication pecaApplication)
        {
            _clienteApplication = clienteApplication;
            _servicoApplication = servicoApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _veiculoApplication = veiculoApplication;
            _maoDeObraApplication = maodeObraApplication;
            _pecaApplication = pecaApplication;
            InitializeComponent();
        }

        public int codigo = 0;
        public int clienteId = 0;
        public int clienteVeiculoId = 0;
        public int veiculoId = 0;
        public string placaVeiculo = "";
        public string nomeCliente = "";
        public IList<ServicoMaodeObra> servicoMaoDeObraTemporaria = new List<ServicoMaodeObra>(); //TO DO: Utilizar o objeto temporário para as alimentações
        public decimal valorMaoDeObraDigitadoTextBox = 0;
        public decimal valorPecaDigitadoTextBox = 0;

        public void LimpaTela()
        {
            txtClienteId.Clear();
            txtConsultaCliente.Clear();
            txtClienteSelecionado.Clear();
            txtDescricao.Clear();
            txtServicoId.Clear();
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

        private void FrmGerarServico_Load(object sender, EventArgs e)
        {
            OrganizaTela();

            if (clienteId != 0 || clienteVeiculoId != 0)
            {
                var cliente = _clienteApplication.GetClienteById(clienteId);

                var dataSource = new List<PesquisaClienteServicoDataSource>();

                foreach (var clienteVeiculo in cliente.ClienteVeiculo)
                {
                    var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                    var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                    dataSource.Add(new PesquisaClienteServicoDataSource
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

                txtClienteId.Text = cliente.ClienteId.ToString();
                txtClienteVeiculoId.Text = clienteVeiculoId.ToString();
                txtClienteSelecionado.Text = cliente.NomeCliente.ToString();
                txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
                txtValorAdicional.Text = Convert.ToDecimal("0").ToString("C");
                txtPercentualDesconto.Text = Convert.ToDecimal("0").ToString("P");
                txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
                txtDescricao.Text = "GERANDO SERVIÇO";

                Servico servico = new Servico
                {
                    ClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text),
                    Status = (int)EnumStatusServico.IniciadoPendente,
                    DataCadastro = DateTime.Now,
                    Descricao = txtDescricao.Text
                };

                var servicoId = _servicoApplication.SalvarServico(servico);

                txtServicoId.Text = servicoId.ToString();

                this.operacao = "inserir";
                this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);

                txtConsultaCliente.Enabled = false;
                btnConsultaCliente.Enabled = false;
                dgvCliente.Enabled = false;
            }

            txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
            txtValorAdicional.Text = Convert.ToDecimal("0").ToString("C");
            txtPercentualDesconto.Text = Convert.ToDecimal("0").ToString("P");
            txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
            txtDescricao.Text = "GERANDO SERVIÇO";
        }

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {
            var cliente = _clienteApplication.GetClienteByLikePlacaOrNomeOrApelido(txtConsultaCliente.Text);

            var dataSource = new List<PesquisaClienteServicoDataSource>();

            foreach (var clienteVeiculo in cliente.ClienteVeiculo)
            {
                var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(clienteVeiculo.VeiculoId);

                var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                dataSource.Add(new PesquisaClienteServicoDataSource
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

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);

            txtValorAdicional.Enabled = true;
            txtPercentualDesconto.Enabled = true;
            txtClienteId.Text = Convert.ToString(1);
            txtClienteVeiculoId.Text = Convert.ToString(1);
            txtClienteSelecionado.Text = Convert.ToString("SEM CLIENTE");
            txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
            txtDescricao.Text = "PESQUISANDO";

            Servico servico = new Servico
            {
                ClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text),
                Descricao = txtDescricao.Text,
                Status = (int)EnumStatusOrcamento.IniciadoPendente,
                DataCadastro = DateTime.Now,
                DataAlteracao = null,
                Ativo = true,
                ServicoMaodeObra = new List<ServicoMaodeObra>(),
                ServicoPeca = new List<ServicoPeca>()
            };

            var servicoId = _servicoApplication.SalvarServico(servico);

            txtServicoId.Text = servicoId.ToString();
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
                FrmConsultaMaoDeObra consultaMaodeObra = FormResolve.Resolve<FrmConsultaMaoDeObra>();
                consultaMaodeObra.ShowDialog();

                if (consultaMaodeObra.codigo != 0)
                {
                    ServicoMaodeObra servicoMaodeObra = new ServicoMaodeObra()
                    {
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        MaodeObraId = consultaMaodeObra.codigo
                    };

                    var Id = _servicoApplication.SalvarServicoMaodeObra(servicoMaodeObra);

                    var servicoMaodeObraSalvo = _servicoApplication.GetServicoMaodeObraByServicoId(Convert.ToInt32(txtServicoId.Text));

                    IList<PesquisaMaodeObraServicoDataSource> maoDeObra = new List<PesquisaMaodeObraServicoDataSource>();

                    foreach (var item in servicoMaodeObraSalvo)
                    {
                        var mao = _maoDeObraApplication.GetMaodeObraById(item.MaodeObraId);

                        maoDeObra.Add(new PesquisaMaodeObraServicoDataSource
                        {
                            MaodeObraId = mao.MaodeObraId,
                            MaodeObra = mao.Descricao,
                            Valor = mao.Valor,
                            ServicoMaodeObraId = Id
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
                    dgvMaodeObra.Columns[3].HeaderText = "ServicoMaoDeObraId";
                    dgvMaodeObra.Columns[3].Width = 20;
                    dgvMaodeObra.Columns[3].Visible = false;
                }

                OrganizaTela();
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
                FrmConsultaPeca consultaPeca = FormResolve.Resolve<FrmConsultaPeca>();
                consultaPeca.ShowDialog();

                if (consultaPeca.codigo != 0)
                {
                    ServicoPeca servicoPeca = new ServicoPeca()
                    {
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        PecaId = consultaPeca.codigo
                    };

                    var Id = _servicoApplication.SalvarServicoPeca(servicoPeca);

                    var servicoPecaSalvo = _servicoApplication.GetServicoPecaByServicoId(Convert.ToInt32(txtServicoId.Text));

                    IList<PesquisaPecaServicoDataSource> peca = new List<PesquisaPecaServicoDataSource>();

                    foreach (var item in servicoPecaSalvo)
                    {
                        var mao = _pecaApplication.GetPecaByPecaId(item.PecaId);
                        peca.Add(new PesquisaPecaServicoDataSource
                        {
                            PecaId = mao.PecaId,
                            Peca = mao.Descricao,
                            Valor = mao.Valor,
                            ServicoPecaId = Id
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

                OrganizaTela();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var servicoSalvo = _servicoApplication.GetServicoByServicoId(Convert.ToInt32(txtServicoId.Text));

                Servico servico = new Servico
                {
                    ServicoId = Convert.ToInt32(txtServicoId.Text),
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
                    DataCadastro = servicoSalvo.DataCadastro,
                    DataAlteracao = DateTime.Now,
                    ServicoMaodeObra = new List<ServicoMaodeObra>(),
                    ServicoPeca = new List<ServicoPeca>()
                };

                _servicoApplication.AtualizarServico(servico);

                MessageBox.Show("Cadastro alterado com sucesso! Número do Serviço: " + servico.ServicoId.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvCliente.DataSource = null;
                dgvMaodeObra.DataSource = null;
                dgvPeca.DataSource = null;

                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaServico consultaServico = FormResolve.Resolve<FrmConsultaServico>();
            consultaServico.ShowDialog();

            DialogResult res = MessageBox.Show("Deseja efetuar alguma alteração no Serviço?", "Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res.ToString() == "Yes")
            {
                if (consultaServico.servicoId != 0)
                {
                    var servico = _servicoApplication.GetServicoByServicoId(consultaServico.servicoId);
                    var clienteVeiculo = _clienteVeiculoApplication.GetVeiculoClienteByClienteVeiculoId(servico.ClienteVeiculoId);
                    var cliente = _clienteApplication.GetClienteById(clienteVeiculo.ClienteId);

                    txtServicoId.Text = Convert.ToString(servico.ServicoId);
                    txtClienteId.Text = servico.ClienteVeiculoId.ToString();
                    txtClienteVeiculoId.Text = servico.ClienteVeiculoId.ToString();
                    txtValorTotalMaodeObra.Text = servico.ValorMaodeObra.ToString("C");
                    txtValorTotalPecas.Text = servico.ValorPeca.ToString("C");
                    txtValorAdicional.Text = servico.ValorAdicional.ToString("C");
                    txtPercentualDesconto.Text = servico.PercentualDesconto.ToString("P");
                    txtValorDesconto.Text = servico.ValorDesconto.ToString("C");
                    txtValorTotal.Text = servico.ValorTotal.ToString("C");
                    txtClienteSelecionado.Text = cliente.NomeCliente;
                    txtDescricao.Text = servico.Descricao.ToString();

                    var servicoMaodeObraSalvo = _servicoApplication.GetServicoMaodeObraByServicoId(servico.ServicoId);

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

                    dgvMaodeObra.DataSource = maoDeObra;
                    dgvMaodeObra.Columns[0].HeaderText = "Código";
                    dgvMaodeObra.Columns[0].Width = 50;
                    dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                    dgvMaodeObra.Columns[1].Width = 300;
                    dgvMaodeObra.Columns[2].HeaderText = "Valor";
                    dgvMaodeObra.Columns[2].Width = 70;
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvMaodeObra.Columns[3].HeaderText = "ServicoMaoDeObraId";
                    dgvMaodeObra.Columns[3].Width = 20;
                    dgvMaodeObra.Columns[3].Visible = false;

                    var servicoPecaSalvo = _servicoApplication.GetServicoPecaByServicoId(servico.ServicoId);

                    IList<PesquisaPecaServicoDataSource> peca = new List<PesquisaPecaServicoDataSource>();

                    foreach (var item in servicoPecaSalvo)
                    {
                        var mao = _pecaApplication.GetPecaByPecaId(item.PecaId);
                        peca.Add(new PesquisaPecaServicoDataSource
                        {
                            PecaId = mao.PecaId,
                            Peca = mao.Descricao,
                            Valor = mao.Valor,
                            ServicoPecaId = item.Id
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




                    DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
                }
                else
                {
                    this.LimpaTela();
                    this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
                }
            }
            else
            {
                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
            }

            consultaServico.Dispose();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
        }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                this.nomeCliente = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells[1].Value);
                txtClienteSelecionado.Text = Convert.ToString(nomeCliente);
                txtClienteId.Text = Convert.ToString(codigo);
                txtClienteVeiculoId.Text = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells[4].Value);
                dgvCliente.CurrentRow.Selected = false;
            }
        }

        private void DgvMaodeObra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maoDeObraId = Convert.ToInt32(dgvMaodeObra.Rows[e.RowIndex].Cells[0].Value);
                int servicoMaodeObraId = Convert.ToInt32(dgvMaodeObra.Rows[e.RowIndex].Cells[3].Value);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    ServicoMaodeObra servicoMaodeObra = new ServicoMaodeObra()
                    {
                        Id = servicoMaodeObraId,
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        MaodeObraId = maoDeObraId
                    };

                    _servicoApplication.DeletarServicoMaodeObra(servicoMaodeObra);

                    var servicoMaodeObraSalvo = _servicoApplication.GetServicoMaodeObraByServicoId(Convert.ToInt32(txtServicoId.Text));

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

                OrganizaTela();
            }
        }

        private void DgvPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int pecaId = Convert.ToInt32(dgvPeca.Rows[e.RowIndex].Cells[0].Value);
                int servicoMaodeObraId = Convert.ToInt32(dgvPeca.Rows[e.RowIndex].Cells[3].Value);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    ServicoPeca servicoPeca = new ServicoPeca()
                    {
                        Id = servicoMaodeObraId,
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        PecaId = pecaId
                    };

                    _servicoApplication.DeletarServicoPeca(servicoPeca);

                    //var servicoPecaSalvo = _servicoApplication.GetServicoPecaByServicoId(Convert.ToInt32(txtServicoId.Text));

                    var servicoPecaSalvo = RemoverItemGridView(servicoPeca);

                    IList<PesquisaPecaServicoDataSource> peca = new List<PesquisaPecaServicoDataSource>();

                    foreach (var servicoPecaUniq in servicoPecaSalvo)
                    {
                        var pec = _pecaApplication.GetPecaByPecaId(servicoPecaUniq.PecaId);
                        peca.Add(new PesquisaPecaServicoDataSource
                        {
                            PecaId = pec.PecaId,
                            Peca = pec.Descricao,
                            Valor = pec.Valor,
                            ServicoPecaId = servicoPecaUniq.ServicoPecaId
                        });
                    }

                    dgvPeca.DataSource = peca;
                    dgvPeca.Columns[0].HeaderText = "Código";
                    dgvPeca.Columns[0].Width = 50;
                    dgvPeca.Columns[1].HeaderText = "Peça";
                    dgvPeca.Columns[1].Width = 330;
                    dgvPeca.Columns[2].HeaderText = "Valor";
                    dgvPeca.Columns[2].Width = 70;
                    dgvPeca.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvPeca.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPeca.Columns[3].HeaderText = "ServicoPecaId";
                    dgvPeca.Columns[3].Width = 20;
                    dgvPeca.Columns[3].Visible = false;
                }

                OrganizaTela();
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

        private void TxtValorTotalMaodeObra_Leave(object sender, EventArgs e)
        {
            valorMaoDeObraDigitadoTextBox = Util.TranslateStringEmDecimal(txtValorTotalMaodeObra.Text);
            txtValorTotalMaodeObra.Text = Util.TranslateValorEmStringDinheiro(txtValorTotalMaodeObra.Text);

            OrganizaTela();
        }

        private void TxtValorTotalPecas_Leave(object sender, EventArgs e)
        {
            valorPecaDigitadoTextBox = Util.TranslateStringEmDecimal(txtValorTotalPecas.Text);
            txtValorTotalPecas.Text = Util.TranslateValorEmStringDinheiro(txtValorTotalPecas.Text);

            OrganizaTela();
        }

        private void TxtValorAdicional_Leave(object sender, EventArgs e)
        {
            txtValorAdicional.Text = Util.TranslateValorEmStringDinheiro(txtValorAdicional.Text);

            OrganizaTela();
        }

        private void TxtPercentualDesconto_Leave(object sender, EventArgs e)
        {
            OrganizaTela();
        }

        private void TxtValorTotalMaodeObra_Enter(object sender, EventArgs e)
        {
            txtValorTotalMaodeObra.Text = "";
        }

        private void TxtValorTotalPecas_Enter(object sender, EventArgs e)
        {
            txtValorTotalPecas.Text = "";
        }

        private void TxtValorAdicional_Enter(object sender, EventArgs e)
        {
            txtValorAdicional.Text = "";
        }

        private void TxtPercentualDesconto_Enter(object sender, EventArgs e)
        {
            txtPercentualDesconto.Text = "";
        }

        private void OrganizaTela()
        {
            lblQtdRegistrosMaoDeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObra.Rows.Count.ToString();
            lblQtdRegistrosPecas.Text = "Quantidade de Registros: " + this.dgvPeca.Rows.Count.ToString();

            var valorMaodeObra = DevolutivaValoresInGridView(EnumTipoServico.ServicoMaoDeObra);
            var valorPeca = DevolutivaValoresInGridView(EnumTipoServico.ServicoPeca);
            var valorAdicional = Util.TranslateStringEmDecimal(txtValorAdicional.Text);
            var percentualDesconto = Util.TranslateStringEmDecimal(txtPercentualDesconto.Text, true);
            var valorDesconto = Convert.ToDecimal(((valorMaodeObra + valorPeca + valorAdicional) * percentualDesconto));
            var valorTotal = ((valorMaodeObra + valorPeca + valorAdicional) - valorDesconto);

            txtValorTotalMaodeObra.Text = valorMaodeObra.ToString("C");
            txtValorTotalPecas.Text = valorPeca.ToString("C");
            txtValorAdicional.Text = valorAdicional.ToString("C");
            txtPercentualDesconto.Text = percentualDesconto.ToString("P");
            txtValorDesconto.Text = valorDesconto.ToString("C");
            txtValorTotal.Text = valorTotal.ToString("C");
        }

        private decimal DevolutivaValoresInGridView(EnumTipoServico tipoServico)
        {
            decimal valorFinal = 0;

            if (tipoServico == EnumTipoServico.ServicoMaoDeObra)
            {
                var valorTotaltxtValorTotalMaodeObra = Util.TranslateStringEmDecimal(txtValorTotalMaodeObra.Text);
                var valorTotalGridViewMaoDeObra = Convert.ToDecimal(dgvMaodeObra.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));

                if (valorTotaltxtValorTotalMaodeObra == valorTotalGridViewMaoDeObra)
                {
                    valorFinal = valorTotalGridViewMaoDeObra;
                }
                else
                {
                    if (valorTotaltxtValorTotalMaodeObra == 0)
                    {
                        valorFinal = valorTotalGridViewMaoDeObra + ((valorTotaltxtValorTotalMaodeObra - valorTotalGridViewMaoDeObra) < 0 ? 0 : (valorTotaltxtValorTotalMaodeObra - valorTotalGridViewMaoDeObra));
                    }
                    else
                    {
                        valorFinal = valorTotalGridViewMaoDeObra + valorMaoDeObraDigitadoTextBox;
                    }
                }
            }
            else if (tipoServico == EnumTipoServico.ServicoPeca)
            {
                var valorTotaltxtValorTotalPeca = Util.TranslateStringEmDecimal(txtValorTotalPecas.Text);
                var valorTotalGridViewPeca = Convert.ToDecimal(dgvPeca.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));

                if (valorTotaltxtValorTotalPeca == valorTotalGridViewPeca)
                {
                    valorFinal = valorTotalGridViewPeca;
                }
                else
                {
                    if (valorTotaltxtValorTotalPeca == 0)
                    {
                        valorFinal = valorTotalGridViewPeca + ((valorTotaltxtValorTotalPeca - valorTotalGridViewPeca) < 0 ? 0 : (valorTotaltxtValorTotalPeca - valorTotalGridViewPeca));
                    }
                    else
                    {
                        valorFinal = valorTotalGridViewPeca + valorPecaDigitadoTextBox;
                    }
                }
            }

            return valorFinal;
        }

        private IList<PesquisaPecaServicoDataSource> RemoverItemGridView(ServicoPeca servicoPeca)
        {
            var dados = dgvPeca.DataSource;

            var dadinhos = dados as IList<PesquisaPecaServicoDataSource>;

            var paraRemover = dadinhos.Where(x => x.ServicoPecaId == servicoPeca.Id).FirstOrDefault();

            dadinhos.Remove(paraRemover);

            return dadinhos;
        }
    }
}