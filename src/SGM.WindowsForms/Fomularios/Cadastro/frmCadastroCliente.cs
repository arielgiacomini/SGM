using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Application.Interface.External;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using SGM.Domain.Utils;
using SGM.WindowsForms.IoC;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmCadastroCliente : FrmModeloDeFormularioDeCadastro
    {
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly ICorreriosApplication _correriosApplication;

        public FrmCadastroCliente(IClienteApplication clienteApplication, IClienteVeiculoApplication clienteVeiculoApplication, ICorreriosApplication correriosApplication)
        {
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _correriosApplication = correriosApplication;
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtClienteId.Clear();
            txtCliente.Clear();
            txtApelido.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTelefoneFixo.Clear();
            txtCelular.Clear();
            txtTelefoneOutros.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtDataCadastro.Clear();
            txtDataAlteracao.Clear();
            cboSexo.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    _clienteApplication.InativarCliente(Convert.ToInt32(txtClienteId.Text));

                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    NomeCliente = txtCliente.Text,
                    Apelido = txtApelido.Text,
                    DocumentoCliente = txtCPF.Text,
                    Sexo = cboSexo.Text,
                    EstadoCivil = cboEstadoCivil.Text,
                    DataNascimento = dtpDataNascimento.Value,
                    Email = txtEmail.Text,
                    TelefoneFixo = txtTelefoneFixo.Text,
                    TelefoneCelular = txtCelular.Text,
                    TelefoneOutros = txtTelefoneOutros.Text,
                    LogradouroCEP = txtCEP.Text,
                    LogradouroNome = txtEndereco.Text,
                    LogradouroNumero = txtNumero.Text,
                    LogradouroComplemento = txtComplemento.Text,
                    LogradouroMunicipio = txtCidade.Text,
                    LogradouroBairro = txtBairro.Text,
                    LogradouroUF = txtUF.Text,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                };

                if (this.operacao == "inserir")
                {
                    _clienteApplication.SalvarCliente(cliente);
                    MessageBox.Show("Cadastro inserido com sucesso! Cliente: " + cliente.NomeCliente.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.ClienteId = Convert.ToInt32(txtClienteId.Text);
                    _clienteApplication.AtualizarCliente(cliente);
                    MessageBox.Show("Cadastro alterado com sucesso! Cliente: " + cliente.NomeCliente.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var veiculosDoCliente = _clienteVeiculoApplication.GetVeiculosClienteByClienteId(cliente.ClienteId);

                int quantidadeVeiculos = veiculosDoCliente.Count();

                if (quantidadeVeiculos <= 0)
                {
                    DialogResult res = MessageBox.Show("Deseja incluir o veículo dele agora? \n Clicando em (Sim), será aberto uma lista de clientes você escolhe o cliente que você acabou de cadastrar \n e clicando duas vezes você automáticamente poderá cadastrar o veículo dele.", "Cadastro de Veículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res.ToString() == "Yes")
                    {
                        FrmCadastroClienteVeiculo formCadastroClienteVeiculo = FormResolve.Resolve<FrmCadastroClienteVeiculo>();
                        formCadastroClienteVeiculo.clienteId = cliente.ClienteId;
                        formCadastroClienteVeiculo.ShowDialog();
                        formCadastroClienteVeiculo.Dispose();
                    }
                }
                else
                {
                    if (quantidadeVeiculos > 1)
                    {
                        DialogResult clienteJaPossuiVeiculo = MessageBox.Show("Este cliente possui + de 1 veículo cadastrado no sistema, será aberto a lista de veículos.", "Cadastro de Veículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (clienteJaPossuiVeiculo.ToString() == "Yes")
                        {
                            FrmConsultaClienteVeiculo formConsultaClienteVeiculo = FormResolve.Resolve<FrmConsultaClienteVeiculo>();
                            formConsultaClienteVeiculo.clienteId = cliente.ClienteId;
                            formConsultaClienteVeiculo.ShowDialog();

                            if (formConsultaClienteVeiculo.clienteId != 0 || formConsultaClienteVeiculo.clienteVeiculoId != 0)
                            {
                                FrmCadastroClienteVeiculo formCadastroClienteVeiculo = FormResolve.Resolve<FrmCadastroClienteVeiculo>();
                                formCadastroClienteVeiculo.clienteId = formConsultaClienteVeiculo.clienteId;
                                formCadastroClienteVeiculo.clienteVeiculoId = formConsultaClienteVeiculo.clienteVeiculoId;
                                formCadastroClienteVeiculo.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
                                formCadastroClienteVeiculo.ShowDialog();
                                formCadastroClienteVeiculo.Dispose();
                            }
                        }
                    }
                    else
                    {
                        DialogResult clienteJaPossuiVeiculo = MessageBox.Show("Este Cliente possui 1 veículo no cadastro, abriremos a tela de veiculo deste cliente.", "Cadastro de Veículo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (veiculosDoCliente.FirstOrDefault().ClienteId != 0 || veiculosDoCliente.FirstOrDefault().ClienteVeiculoId != 0)
                        {
                            FrmCadastroClienteVeiculo formCadastroClienteVeiculo = FormResolve.Resolve<FrmCadastroClienteVeiculo>();
                            formCadastroClienteVeiculo.clienteId = veiculosDoCliente.FirstOrDefault().ClienteId;
                            formCadastroClienteVeiculo.clienteVeiculoId = veiculosDoCliente.FirstOrDefault().ClienteVeiculoId;
                            formCadastroClienteVeiculo.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
                            formCadastroClienteVeiculo.ShowDialog();
                            formCadastroClienteVeiculo.Dispose();
                        }
                    }
                }

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
            frmConsultaCliente formConsultaCliente = FormResolve.Resolve<frmConsultaCliente>();
            formConsultaCliente.ShowDialog();
            if (formConsultaCliente.codigo != 0)
            {
                var cliente = _clienteApplication.GetClienteById(formConsultaCliente.codigo);

                txtClienteId.Text = cliente.ClienteId.ToString();
                txtCliente.Text = cliente.NomeCliente;
                txtApelido.Text = cliente.Apelido;
                txtCPF.Text = cliente.DocumentoCliente;
                cboSexo.Text = cliente.Sexo;
                cboEstadoCivil.Text = cliente.EstadoCivil;
                dtpDataNascimento.Value = Convert.ToDateTime(cliente.DataNascimento);
                txtEmail.Text = cliente.Email;
                txtTelefoneFixo.Text = cliente.TelefoneFixo;
                txtCelular.Text = cliente.TelefoneCelular;
                txtTelefoneOutros.Text = cliente.TelefoneOutros;
                txtCEP.Text = cliente.LogradouroCEP;
                txtEndereco.Text = cliente.LogradouroNome;
                txtNumero.Text = cliente.LogradouroNumero;
                txtComplemento.Text = cliente.LogradouroComplemento;
                txtCidade.Text = cliente.LogradouroMunicipio;
                txtBairro.Text = cliente.LogradouroBairro;
                txtUF.Text = cliente.LogradouroUF;
                txtDataCadastro.Text = Convert.ToString(Util.ConvertHorarioOfServerToWorldReal(cliente.DataCadastro.Value, 5));
                //txtDataAlteracao.Text = Convert.ToString(Util.ConvertHorarioOfServerToWorldReal(cliente.DataAlteracao.Value, 5));
                DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
            }
            else
            {
                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
            }

            formConsultaCliente.Dispose();
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text != "")
            {
                if (this.operacao == "inserir")
                {
                    var cliente = _clienteApplication.GetClienteByDocumentoCliente(txtCPF.Text);

                    if (cliente.ClienteId != 0)
                    {
                        DialogResult res = MessageBox.Show("Esse CPF já existe em nossa base de dados. Deseja alterar o registro?", "Aviso IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (res.ToString() == "Yes")
                        {
                            this.operacao = "alterar";

                            txtClienteId.Text = Convert.ToString(cliente.ClienteId);
                            txtCliente.Text = cliente.NomeCliente;
                            txtApelido.Text = cliente.Apelido;
                            txtCPF.Text = cliente.DocumentoCliente;
                            cboSexo.Text = cliente.Sexo;
                            cboEstadoCivil.Text = cliente.EstadoCivil;
                            dtpDataNascimento.Value = Convert.ToDateTime(cliente.DataNascimento);
                            txtEmail.Text = cliente.Email;
                            txtTelefoneFixo.Text = cliente.TelefoneFixo;
                            txtCelular.Text = cliente.TelefoneCelular;
                            txtTelefoneOutros.Text = cliente.TelefoneOutros;
                            txtCEP.Text = cliente.LogradouroCEP;
                            txtEndereco.Text = cliente.LogradouroNome;
                            txtNumero.Text = cliente.LogradouroNumero;
                            txtComplemento.Text = cliente.LogradouroComplemento;
                            txtCidade.Text = cliente.LogradouroMunicipio;
                            txtBairro.Text = cliente.LogradouroBairro;
                            txtUF.Text = cliente.LogradouroUF;
                            txtDataCadastro.Text = Convert.ToString(Util.ConvertHorarioOfServerToWorldReal(cliente.DataCadastro.Value, 5));
                        }
                    }
                }
            }

            txtCPF.Mask = "000,000,000-00";
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            if (txtCEP.Text != "")
            {
                var enderecoApi = _correriosApplication.GetEnderecoByCEP(txtCEP.Text.Replace("-", ""));

                if (enderecoApi.Logradouro != "" || enderecoApi.Logradouro != null)
                {
                    txtEndereco.Text = enderecoApi.Logradouro;
                    txtBairro.Text = enderecoApi.Bairro;
                    txtCidade.Text = enderecoApi.Localidade;
                    txtUF.Text = enderecoApi.UF;

                    txtNumero.Focus();
                }
            }

            txtCEP.Mask = "00000-000";
        }

        private void TxtCEP_Enter(object sender, EventArgs e)
        {
            txtCEP.Mask = "";
            txtCEP.Text = "";
        }

        private void TxtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.Mask = "";
            txtCPF.Text = "";
        }

        private void DtpDataNascimento_Enter(object sender, EventArgs e)
        {
            dtpDataNascimento.CustomFormat = "";
        }

        private void TxtTelefoneFixo_Enter(object sender, EventArgs e)
        {
            txtTelefoneFixo.Mask = "";
            txtTelefoneFixo.Text = "";
        }

        private void TxtCelular_Enter(object sender, EventArgs e)
        {
            txtCelular.Mask = "";
            txtCelular.Text = "";
        }

        private void TxtTelefoneOutros_Enter(object sender, EventArgs e)
        {
            txtTelefoneOutros.Mask = "";
            txtTelefoneOutros.Text = "";
        }

        private void TxtTelefoneFixo_Leave(object sender, EventArgs e)
        {
            txtTelefoneFixo.Mask = "(00) 0000-0000";
        }

        private void TxtCelular_Leave(object sender, EventArgs e)
        {
            txtCelular.Mask = "(00) 0,0000-0000";
        }

        private void TxtTelefoneOutros_Leave(object sender, EventArgs e)
        {
            txtTelefoneOutros.Mask = "(00) 0,0000-0000";
        }
    }
}