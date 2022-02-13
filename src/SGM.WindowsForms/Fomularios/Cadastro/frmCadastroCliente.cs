using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using SGM.Domain.Intern.Enum;
using SGM.Domain.Intern.Interfaces.Business;
using SGM.Domain.Utils;
using SGM.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmCadastroCliente : FrmModeloDeFormularioDeCadastro
    {
        private readonly ICorreiosBusiness _correriosBusiness;
        private readonly IClienteBusiness _clienteBusiness;

        public FrmCadastroCliente(
            ICorreiosBusiness correriosBusiness,
            IClienteBusiness clienteBusiness)
        {
            _correriosBusiness = correriosBusiness;
            _clienteBusiness = clienteBusiness;

            InitializeComponent();
        }

        public void Clean()
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
            DialogResult desejaExcluir = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (desejaExcluir.ToString() == "Yes")
            {
                var response = _clienteBusiness.Delete(txtClienteId.Text);

                switch (response.TipoResponse)
                {
                    case TipoResponseEnum.Sucess:
                        foreach (var message in response.Mensagem)
                        {
                            switch (message.Key)
                            {
                                case TipoMensagemEnum.SucessWithMessage:
                                    MessageBox.Show(
                                        message.Value,
                                        typeof(FrmCadastroCliente).Name,
                                        response.MessageBoxButtons,
                                        response.MessageBoxIcon);
                                    this.Clean();
                                    this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case TipoResponseEnum.Error:
                        foreach (var message in response.Mensagem)
                        {
                            switch (message.Key)
                            {
                                case TipoMensagemEnum.ErrorInDelete:
                                    MessageBox.Show(
                                        message.Value,
                                        typeof(FrmCadastroCliente).Name,
                                        response.MessageBoxButtons,
                                        response.MessageBoxIcon);

                                    if (response.InativacaoClienteWithError)
                                    {
                                        this.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
                                    }

                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case TipoResponseEnum.Information:
                        break;
                    default:
                        break;
                }
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

                var response = _clienteBusiness.SaveOrUpdate(this.operacao, cliente);

                switch (response.TipoResponse)
                {
                    case TipoResponseEnum.Sucess:
                        foreach (var message in response.Mensagem)
                        {
                            switch (message.Key)
                            {
                                case TipoMensagemEnum.Information:
                                    MessageBox.Show(
                                                    message.Value,
                                                    typeof(FrmCadastroCliente).Name,
                                                    response.MessageBoxButtons,
                                                    response.MessageBoxIcon);
                                    break;
                                case TipoMensagemEnum.SucessWithMessage:
                                    MessageBox.Show(
                                                    message.Value,
                                                    typeof(FrmCadastroCliente).Name,
                                                    response.MessageBoxButtons,
                                                    response.MessageBoxIcon);

                                    if (response.DeveAbrirFormularioCadastroVeiculoDoCliente)
                                    {
                                        FrmCadastroClienteVeiculo formCadastroClienteVeiculo = FormResolve.Resolve<FrmCadastroClienteVeiculo>();
                                        formCadastroClienteVeiculo.clienteId = response.ClienteId;
                                        formCadastroClienteVeiculo.clienteVeiculoId = response.ClienteVeiculoId;
                                        formCadastroClienteVeiculo.ShowDialog();
                                        formCadastroClienteVeiculo.Dispose();
                                    }
                                    break;
                                case TipoMensagemEnum.SucessWithQuestion:
                                    DialogResult respostaUsuario = MessageBox.Show(
                                                    message.Value,
                                                    typeof(FrmCadastroCliente).Name,
                                                    response.MessageBoxButtons,
                                                    response.MessageBoxIcon);

                                    if (respostaUsuario.ToString() == "Yes")
                                    {
                                        if (response.DeveAbrirFormularioCadastroVeiculoDoCliente)
                                        {
                                            FrmCadastroClienteVeiculo formCadastroClienteVeiculo = FormResolve.Resolve<FrmCadastroClienteVeiculo>();
                                            formCadastroClienteVeiculo.clienteId = response.ClienteId;
                                            formCadastroClienteVeiculo.ShowDialog();
                                            formCadastroClienteVeiculo.Dispose();
                                        }
                                        else if (response.DeveAbrirFormularioConsultaVeiculoDoCliente)
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
                                    break;
                                default:
                                    break;
                            }
                        };
                        break;
                    case TipoResponseEnum.Error:
                        foreach (var message in response.Mensagem)
                        {
                            switch (message.Key)
                            {
                                case TipoMensagemEnum.ErrorInSave:
                                    MessageBox.Show(
                                                message.Value,
                                                typeof(FrmCadastroCliente).Name,
                                                response.MessageBoxButtons,
                                                response.MessageBoxIcon);
                                    break;
                                case TipoMensagemEnum.ErrorInUpdate:
                                    MessageBox.Show(
                                                message.Value,
                                                typeof(FrmCadastroCliente).Name,
                                                response.MessageBoxButtons,
                                                response.MessageBoxIcon);
                                    break;
                                case TipoMensagemEnum.ErrorInValidation:
                                    MessageBox.Show(
                                                message.Value,
                                                typeof(FrmCadastroCliente).Name,
                                                response.MessageBoxButtons,
                                                response.MessageBoxIcon);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case TipoResponseEnum.Information:
                        break;
                    default:
                        break;
                }

                this.Clean();
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
            this.Clean();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            var oneResponse = _clienteBusiness.Search();

            switch (oneResponse.TipoResponse)
            {
                case TipoResponseEnum.Sucess:
                    if (oneResponse.DeveAbrirFormularioConsultaCliente)
                    {
                        frmConsultaCliente formConsultaCliente = FormResolve.Resolve<frmConsultaCliente>();
                        formConsultaCliente.ShowDialog();

                        if (formConsultaCliente.codigo != 0)
                        {
                            var twoResponse = _clienteBusiness.SearchByClienteId(formConsultaCliente.codigo);

                            switch (twoResponse.TipoResponse)
                            {
                                case TipoResponseEnum.SucessWithoutMessageOrQuestion:

                                    txtClienteId.Text = twoResponse.Cliente.ClienteId.ToString();
                                    txtCliente.Text = twoResponse.Cliente.NomeCliente;
                                    txtApelido.Text = twoResponse.Cliente.Apelido;
                                    txtCPF.Text = twoResponse.Cliente.DocumentoCliente;
                                    cboSexo.Text = twoResponse.Cliente.Sexo;
                                    cboEstadoCivil.Text = twoResponse.Cliente.EstadoCivil;
                                    dtpDataNascimento.Value = Convert.ToDateTime(twoResponse.Cliente.DataNascimento);
                                    txtEmail.Text = twoResponse.Cliente.Email;
                                    txtTelefoneFixo.Text = twoResponse.Cliente.TelefoneFixo;
                                    txtCelular.Text = twoResponse.Cliente.TelefoneCelular;
                                    txtTelefoneOutros.Text = twoResponse.Cliente.TelefoneOutros;
                                    txtCEP.Text = twoResponse.Cliente.LogradouroCEP;
                                    txtEndereco.Text = twoResponse.Cliente.LogradouroNome;
                                    txtNumero.Text = twoResponse.Cliente.LogradouroNumero;
                                    txtComplemento.Text = twoResponse.Cliente.LogradouroComplemento;
                                    txtCidade.Text = twoResponse.Cliente.LogradouroMunicipio;
                                    txtBairro.Text = twoResponse.Cliente.LogradouroBairro;
                                    txtUF.Text = twoResponse.Cliente.LogradouroUF;
                                    txtDataCadastro.Text = Convert.ToString(Util.ConvertHorarioOfServerToWorldReal(twoResponse.Cliente.DataCadastro.Value, 5));

                                    DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
                                    formConsultaCliente.Dispose();

                                    break;
                                case TipoResponseEnum.Error:
                                    foreach (var message in twoResponse.Mensagem)
                                    {
                                        switch (message.Key)
                                        {
                                            case TipoMensagemEnum.ErrorInSearch:
                                                MessageBox.Show(
                                                    message.Value,
                                                    typeof(FrmCadastroCliente).Name,
                                                    twoResponse.MessageBoxButtons,
                                                    twoResponse.MessageBoxIcon);
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        this.Clean();
                        this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
                    }
                    break;
                default:
                    break;
            }
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            txtCPF.Mask = "000,000,000-00";

            var pesquisa = _clienteBusiness.SearchByCPF(this.operacao, txtCPF.Text);

            switch (pesquisa.TipoResponse)
            {
                case TipoResponseEnum.Sucess:
                    foreach (var message in pesquisa.Mensagem)
                    {
                        switch (message.Key)
                        {
                            case TipoMensagemEnum.SucessWithQuestion:
                                var respostaUser = MessageBox.Show(
                                    message.Value,
                                    typeof(FrmCadastroCliente).Name,
                                    pesquisa.MessageBoxButtons,
                                    pesquisa.MessageBoxIcon);

                                if (respostaUser.ToString() == "Yes")
                                {
                                    this.operacao = "alterar";

                                    txtClienteId.Text = Convert.ToString(pesquisa.Cliente.ClienteId);
                                    txtCliente.Text = pesquisa.Cliente.NomeCliente;
                                    txtApelido.Text = pesquisa.Cliente.Apelido;
                                    txtCPF.Text = pesquisa.Cliente.DocumentoCliente;
                                    cboSexo.Text = pesquisa.Cliente.Sexo;
                                    cboEstadoCivil.Text = pesquisa.Cliente.EstadoCivil;
                                    dtpDataNascimento.Value = Convert.ToDateTime(pesquisa.Cliente.DataNascimento);
                                    txtEmail.Text = pesquisa.Cliente.Email;
                                    txtTelefoneFixo.Text = pesquisa.Cliente.TelefoneFixo;
                                    txtCelular.Text = pesquisa.Cliente.TelefoneCelular;
                                    txtTelefoneOutros.Text = pesquisa.Cliente.TelefoneOutros;
                                    txtCEP.Text = pesquisa.Cliente.LogradouroCEP;
                                    txtEndereco.Text = pesquisa.Cliente.LogradouroNome;
                                    txtNumero.Text = pesquisa.Cliente.LogradouroNumero;
                                    txtComplemento.Text = pesquisa.Cliente.LogradouroComplemento;
                                    txtCidade.Text = pesquisa.Cliente.LogradouroMunicipio;
                                    txtBairro.Text = pesquisa.Cliente.LogradouroBairro;
                                    txtUF.Text = pesquisa.Cliente.LogradouroUF;
                                    txtDataCadastro.Text = Convert.ToString(Util.ConvertHorarioOfServerToWorldReal(pesquisa.Cliente.DataCadastro.Value, 5));
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TipoResponseEnum.Error:
                    foreach (var message in pesquisa.Mensagem)
                    {
                        switch (message.Key)
                        {
                            case TipoMensagemEnum.ErrorInSearch:
                                MessageBox.Show(
                                            message.Value,
                                            typeof(FrmCadastroCliente).Name,
                                            pesquisa.MessageBoxButtons,
                                            pesquisa.MessageBoxIcon);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TipoResponseEnum.Information:
                    foreach (var message in pesquisa.Mensagem)
                    {
                        switch (message.Key)
                        {
                            case TipoMensagemEnum.Information:
                                MessageBox.Show(
                                    message.Value,
                                    typeof(FrmCadastroCliente).Name,
                                    pesquisa.MessageBoxButtons,
                                    pesquisa.MessageBoxIcon);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void TxtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.Mask = "";
            txtCPF.Text = "";
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            txtCEP.Mask = "00000-000";

            var response = _correriosBusiness.SearchByCEP(txtCEP.Text);

            switch (response.TipoResponse)
            {
                case TipoResponseEnum.SucessWithoutMessageOrQuestion:
                    foreach (var message in response.Mensagem)
                    {
                        switch (message.Key)
                        {
                            case TipoMensagemEnum.Information:
                                if (response.ReturnCompleted)
                                {
                                    txtEndereco.Text = response.Logradouro;
                                    txtBairro.Text = response.Bairro;
                                    txtCidade.Text = response.Localidade;
                                    txtUF.Text = response.UF;

                                    if (response.FocusNumber)
                                    {
                                        txtNumero.Focus();
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TipoResponseEnum.Information:
                    foreach (var message in response.Mensagem)
                    {
                        switch (message.Key)
                        {
                            case TipoMensagemEnum.Information:
                                MessageBox.Show(
                                    message.Value,
                                    typeof(FrmCadastroCliente).Name,
                                    response.MessageBoxButtons,
                                    response.MessageBoxIcon);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TipoResponseEnum.Error:
                    foreach (var message in response.Mensagem)
                    {
                        switch (message.Key)
                        {
                            case TipoMensagemEnum.ErrorInSearch:
                                MessageBox.Show(
                                            message.Value,
                                            typeof(FrmCadastroCliente).Name,
                                            response.MessageBoxButtons,
                                            response.MessageBoxIcon);
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            };
        }

        private void TxtCEP_Enter(object sender, EventArgs e)
        {
            txtCEP.Mask = "";
            txtCEP.Text = "";
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