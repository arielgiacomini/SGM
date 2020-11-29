using BLL;
using DAL;
using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmCadastroClienteVeiculo : FrmModeloDeFormularioDeCadastro
    {
        public int clienteId = 0;
        public string placaVeiculo = "";
        public int clienteVeiculoId = 0;
        private readonly IClienteApplication _clienteApplication;
        private readonly IVeiculoApplication _veiculoApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;

        public FrmCadastroClienteVeiculo(IClienteApplication clienteApplication, IVeiculoApplication veiculoApplication, IClienteVeiculoApplication clienteVeiculoApplication)
        {
            _clienteApplication = clienteApplication;
            _veiculoApplication = veiculoApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtClienteVeiculoId.Clear();
            txtCorVeiculo.Clear();
            txtKmVeiculo.Clear();
            txtPlacaVeiculo.Clear();
            txtClienteId.Clear();
            txtCliente.Clear();
            txtTelefoneCliente.Clear();
            txtAnoModeloVeiculo.Clear();
            cboVeiculo.SelectedIndex = -1;
            cboMarcaVeiculo.SelectedIndex = -1;
            checkBoxAtivo.Checked = false;
            txtDataCadastro.Clear();
            txtDataAlteracao.Clear();
        }

        private void FrmCadastroClienteVeiculo_Load(object sender, EventArgs e)
        {
            this.txtClienteId.Enabled = false;
            this.txtCliente.Enabled = false;
            this.txtTelefoneCliente.Enabled = false;
            this.txtAnoModeloVeiculo.Enabled = false;

            this.LimpaTela();
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);

            if (cboMarcaVeiculo.DataSource == null)
            {
                cboMarcaVeiculo.DataSource = _veiculoApplication.GetMarcasByAll();
                cboMarcaVeiculo.DisplayMember = "Marca";
                cboMarcaVeiculo.ValueMember = "MarcaId";
            }

            ClienteVeiculo dadosVeiculoCliente = new ClienteVeiculo();
            Cliente dadosCliente = null;
            Veiculo dadosVeiculo = new Veiculo();
            VeiculoMarca dadosMarcaVeiculo = new VeiculoMarca();

            if (placaVeiculo != null && placaVeiculo != "")
            {
                dadosVeiculoCliente = _clienteVeiculoApplication.GetVeiculoClienteByPlaca(placaVeiculo);
                dadosCliente = _clienteApplication.GetClienteById(dadosVeiculoCliente.ClienteId);
                dadosVeiculo = _veiculoApplication.GetVeiculoByVeiculoId(dadosVeiculoCliente.VeiculoId);
                dadosMarcaVeiculo = _veiculoApplication.GetMarcaByMarcaId(dadosVeiculo.MarcaId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelExcluirAndAlterar);
                this.operacao = "alterar";
            }
            else if (clienteVeiculoId != 0)
            {
                dadosVeiculoCliente = _clienteVeiculoApplication.GetVeiculoClienteByClienteVeiculoId(clienteVeiculoId);
                dadosCliente = _clienteApplication.GetClienteById(dadosVeiculoCliente.ClienteId);
                dadosVeiculo = _veiculoApplication.GetVeiculoByVeiculoId(dadosVeiculoCliente.VeiculoId);
                dadosMarcaVeiculo = _veiculoApplication.GetMarcaByMarcaId(dadosVeiculo.MarcaId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelExcluirAndAlterar);
                this.operacao = "alterar";
            }
            else if (clienteId != 0 && (placaVeiculo == null || clienteVeiculoId == 0 || clienteVeiculoId == 0))
            {
                dadosCliente = _clienteApplication.GetClienteById(clienteId);
                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
                this.operacao = "inserir";
            }
            else
            {
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
                this.operacao = "inserir";
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloVeiculo.Enabled = false;

            if (cboMarcaVeiculo.DataSource == null)
            {
                cboMarcaVeiculo.DataSource = _veiculoApplication.GetMarcasByAll();
                cboMarcaVeiculo.DisplayMember = "Marca";
                cboMarcaVeiculo.ValueMember = "MarcaId";
            }

            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
            this.operacao = "inserir";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloVeiculo.Enabled = false;
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
            this.LimpaTela();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloVeiculo.Enabled = false;

            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelExcluirAndAlterar);
            this.operacao = "alterar";
            txtCliente.Enabled = false;
            txtClienteId.Enabled = false;
            txtTelefoneCliente.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int veiculoId = 0;

                if (txtClienteVeiculoId.Text != "")
                {
                    this.operacao = "alterar";
                }

                if (Convert.ToInt32(cboVeiculo.SelectedValue) == 0)
                {
                    Veiculo novoVeiculo = new Veiculo()
                    {
                        CodigoFipe = 0,
                        MarcaId = Convert.ToInt32(cboMarcaVeiculo.SelectedValue),
                        Modelo = cboVeiculo.Text,
                        VeiculoAtivo = true,
                        DataCadastro = DateTime.Now
                    };
                    try
                    {
                        veiculoId = _veiculoApplication.SalvarVeiculo(novoVeiculo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HOUVE ALGUM ERRO AO CADASTRAR O VEICULO: " + Convert.ToString(ex), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                ClienteVeiculo clienteVeiculo = new ClienteVeiculo
                {
                    ClienteId = Convert.ToInt32(txtClienteId.Text),
                    VeiculoId = veiculoId == 0 ? Convert.ToInt32(cboVeiculo.SelectedValue) : veiculoId,
                    CorVeiculo = txtCorVeiculo.Text,
                    PlacaVeiculo = txtPlacaVeiculo.Text,
                    KmRodados = txtKmVeiculo.Text.Length == 0 ? 0 : Convert.ToInt32(txtKmVeiculo.Text),
                    AnoVeiculo = Convert.ToInt32(txtAnoModeloVeiculo.Text),
                    Ativo = checkBoxAtivo.Checked,
                    DataCadastro = DateTime.Now
                };

                if (this.operacao == "inserir")
                {
                    try
                    {
                        txtClienteVeiculoId.Text = Convert.ToString(_clienteVeiculoApplication.SalvarClienteVeiculo(clienteVeiculo));
                        MessageBox.Show("Cadastro inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AbrirPerguntaQualItemDesejaEfetuarParaCliente(Convert.ToInt32(txtClienteId.Text), Convert.ToInt32(cboVeiculo.SelectedValue), Convert.ToString(txtPlacaVeiculo.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HOUVE ALGUM ERRO AO CADASTRAR: " + Convert.ToString(ex), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        clienteVeiculo.ClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text);
                        clienteVeiculo.DataAlteracao = DateTime.Now;
                        _clienteVeiculoApplication.AtualizarClienteVeiculo(clienteVeiculo);
                        MessageBox.Show("Cadastro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AbrirPerguntaQualItemDesejaEfetuarParaCliente(Convert.ToInt32(txtClienteId.Text), Convert.ToInt32(cboVeiculo.SelectedValue), Convert.ToString(txtPlacaVeiculo.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HOUVE ALGUM ERRO AO ALTERAR: " + Convert.ToString(ex), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.ToString() == "Yes")
                {
                    _clienteVeiculoApplication.InativarClienteVeiculo(Convert.ToInt32(txtClienteVeiculoId.Text));

                    this.LimpaTela();
                    this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);

                    MessageBox.Show("Registro Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelExcluirAndAlterar);
            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaClienteVeiculo c = new FrmConsultaClienteVeiculo();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                this.txtClienteId.Enabled = false;
                this.txtCliente.Enabled = false;
                this.txtTelefoneCliente.Enabled = false;

                if (cboMarcaVeiculo.DataSource == null)
                {
                    cboMarcaVeiculo.DataSource = _veiculoApplication.GetMarcasByAll();
                    cboMarcaVeiculo.DisplayMember = "Marca";
                    cboMarcaVeiculo.ValueMember = "MarcaId";
                }

                if (placaVeiculo != null && placaVeiculo != "")
                {
                    var dadosVeiculoCliente = _clienteVeiculoApplication.GetVeiculoClienteByPlaca(placaVeiculo);
                    var dadosCliente = _clienteApplication.GetClienteById(dadosVeiculoCliente.ClienteId);
                    var dadosVeiculo = _veiculoApplication.GetVeiculoByVeiculoId(dadosVeiculoCliente.VeiculoId);
                    var dadosMarcaVeiculo = _veiculoApplication.GetMarcaByMarcaId(dadosVeiculo.MarcaId);

                    PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                    this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
                    this.operacao = "alterar";
                }
            }
            else
            {
                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
            }

            c.Dispose();
        }

        private void BtnBuscarHistoricoCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaHistoricoServicoClienteVeiculo consultaHistorico = new FrmConsultaHistoricoServicoClienteVeiculo
            {
                clienteId = Convert.ToInt32(txtClienteId.Text)
            };

            consultaHistorico.ShowDialog();
            consultaHistorico.Dispose();
            consultaHistorico.Close();
        }

        private void ComboBoxMarcaVeiculoAlteracaoValor(object sender, EventArgs e)
        {
            VeiculoMarca marcaVeiculo = (VeiculoMarca)cboMarcaVeiculo.SelectedItem;
            if (marcaVeiculo != null && marcaVeiculo.Marca != "Escolher Item")
            {
                this.txtAnoModeloVeiculo.Enabled = true;
            }
            else
            {
                txtAnoModeloVeiculo.Clear();
                cboVeiculo.SelectedIndex = -1;
            }
        }

        private void TextBoxAnoModeloSaidaCampo(object sender, EventArgs e)
        {
            var anoModeloFabricacao = txtAnoModeloVeiculo.Text;

            VeiculoMarca marcaVeiculo = (VeiculoMarca)cboMarcaVeiculo.SelectedItem;

            int marcaId = Convert.ToInt32(marcaVeiculo.MarcaId);

            if (!Utils.VerificaSeEhNumero(anoModeloFabricacao))
            {
                MessageBox.Show("O Ano Modelo/Fabricação deve ser um número: ex.: 2020 ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoModeloVeiculo.Clear();
            }

            else
            {
                cboVeiculo.DataSource = _veiculoApplication.GetVeiculosByMarcaId(marcaId);
                cboVeiculo.DisplayMember = "Modelo";
                cboVeiculo.ValueMember = "VeiculoId";
            }
        }

        public void PreencheInformacoesNaTela(Cliente cliente, ClienteVeiculo veiculoCliente, Veiculo veiculo, VeiculoMarca veiculoMarca)
        {
            if (cliente != null && cliente.ClienteId != 0)
            {
                txtClienteId.Text = cliente.ClienteId.ToString();
                txtCliente.Text = cliente.NomeCliente.ToString();
                txtTelefoneCliente.Text = cliente.TelefoneCelular.ToString();
            }

            if (veiculoCliente != null && veiculoCliente.ClienteVeiculoId != 0)
            {
                txtClienteVeiculoId.Text = veiculoCliente.ClienteVeiculoId.ToString();
                txtPlacaVeiculo.Text = veiculoCliente.PlacaVeiculo.ToString();
                txtKmVeiculo.Text = veiculoCliente.KmRodados.ToString();
                txtCorVeiculo.Text = veiculoCliente.CorVeiculo.ToString();
                txtAnoModeloVeiculo.Text = veiculoCliente.AnoVeiculo.ToString();
                checkBoxAtivo.Checked = veiculoCliente.Ativo;
                txtDataCadastro.Text = veiculoCliente.DataCadastro.ToLongDateString();
                txtDataAlteracao.Text = veiculoCliente.DataAlteracao.HasValue ? veiculoCliente.DataAlteracao.Value.ToLongDateString() : "";
            }

            if (veiculo != null && veiculo.VeiculoId != 0)
            {
                cboMarcaVeiculo.SelectedValue = veiculoMarca.MarcaId;

                if (cboMarcaVeiculo.SelectedIndex > 0)
                {
                    DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLVeiculo veaquinho = new BLLVeiculo(conexao);
                    cboVeiculo.DataSource = veaquinho.BuscarVeiculoByMarcaId(veiculoMarca.MarcaId);
                    cboVeiculo.DisplayMember = "Modelo";
                    cboVeiculo.ValueMember = "VeiculoId";
                    cboVeiculo.SelectedValue = veiculoCliente.VeiculoId;
                }
            }

            if (veiculoMarca != null && veiculoMarca.MarcaId != 0)
            {
                cboMarcaVeiculo.DisplayMember = veiculoMarca.Marca.ToString();
            }
        }

        private void AbrirPerguntaQualItemDesejaEfetuarParaCliente(int clienteId, int veiculoId, string placaVeiculo)
        {
            FrmPerguntaQualItemAbrir questionItemAbrir = new FrmPerguntaQualItemAbrir
            {
                clienteId = clienteId,
                veiculoId = veiculoId,
                placaVeiculo = placaVeiculo
            };

            questionItemAbrir.ShowDialog();
        }

        private void CboVeiculo_Leave(object sender, EventArgs e)
        {
            txtKmVeiculo.Focus();
        }
    }
}