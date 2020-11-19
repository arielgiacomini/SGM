using BLL;
using DAL;
using Modelo;
using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmCadastroCliente : FrmModeloDeFormularioDeCadastro
    {
        private readonly IClienteApplication _clienteApplication;

        public FrmCadastroCliente(IClienteApplication clienteApplication)
        {
            _clienteApplication = clienteApplication;

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
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLCliente bll = new BLLCliente(cx);
                    bll.Excluir(Convert.ToInt32(txtClienteId.Text));
                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AlteraBotoes(3);
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

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLCliente bll = new BLLCliente(cx);
                BLLVeiculoCliente bllVeiculoCliente = new BLLVeiculoCliente(cx);

                if (this.operacao == "inserir")
                {
                    _clienteApplication.SalvarCliente(cliente);
                    MessageBox.Show("Cadastro inserido com sucesso! Cliente: " + cliente.NomeCliente.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    cliente.ClienteId = Convert.ToInt32(txtClienteId.Text);
                    //bll.Alterar(cliente);
                    MessageBox.Show("Cadastro alterado com sucesso! Cliente: " + cliente.NomeCliente.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var veiculosDoCliente = bllVeiculoCliente.BuscarVeiculosCliente(cliente.ClienteId);

                if (veiculosDoCliente.CClienteVeiculoId == 0)
                {
                    DialogResult res = MessageBox.Show("Deseja incluir o veículo dele agora? \n Clicando em (Sim), será aberto uma lista de clientes você escolhe o cliente que você acabou de cadastrar \n e clicando duas vezes você automáticamente poderá cadastrar o veículo dele.", "Cadastro de Veículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res.ToString() == "Yes")
                    {
                        frmConsultaCliente c = new frmConsultaCliente
                        {
                            codigo = cliente.ClienteId
                        };

                        c.ShowDialog();

                        if (c.codigo != 0)
                        {
                            FrmCadastroClienteVeiculo g = new FrmCadastroClienteVeiculo();
                            g.AlteraBotoes(1);
                            g.clienteId = c.codigo;
                            g.ShowDialog();
                            g.Dispose();
                        }
                    }
                }
                else
                {
                    DialogResult clienteJaPossuiVeiculo = MessageBox.Show("Este Cliente já possui veículo cadastrado no sistema. Deseja visualizar? \n Clicando em (Sim), será aberto uma lista dos veiculos deste cliente.", "Cadastro de Veículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (clienteJaPossuiVeiculo.ToString() == "Yes")
                    {
                        FrmConsultaClienteVeiculo c = new FrmConsultaClienteVeiculo
                        {
                            clienteId = cliente.ClienteId
                        };

                        c.ShowDialog();

                        if (c.clienteId != 0)
                        {
                            FrmCadastroClienteVeiculo g = new FrmCadastroClienteVeiculo
                            {
                                clienteId = c.clienteId,
                                clienteVeiculoId = c.codigo
                            };

                            g.AlteraBotoes(3);
                            g.ShowDialog();
                            g.Dispose();
                        }
                    }
                }

                this.LimpaTela();
                this.AlteraBotoes(1);
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
            this.AlteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaCliente c = new frmConsultaCliente();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                var cliente = _clienteApplication.GetClienteById(c.codigo);

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
                txtDataCadastro.Text = Convert.ToString(cliente.DataCadastro);

                AlteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            c.Dispose(); //destrói o formulário de consulta, para não ocupar memória.
        }

        /* ABAIXO O EVENTO QUE VERIFICA SE JÁ EXISTE O CLIENTE NA BASE DE DADOS.*/
        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLCliente bll = new BLLCliente(cx);
                int retorno = bll.VerificaCPFCliente(txtCPF.Text);

                if (retorno > 0)
                {
                    DialogResult res = MessageBox.Show("Esse CPF já existe em nossa base de dados. Deseja alterar o registro?", "Aviso IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloCliente modelo = bll.CarregaModeloCliente(retorno);
                        txtClienteId.Text = Convert.ToString(modelo.CClienteId);
                        txtCliente.Text = modelo.CNomeCliente;
                        txtApelido.Text = modelo.CApelido;
                        txtCPF.Text = modelo.CDocumentoCliente;
                        cboSexo.Text = modelo.CSexo;
                        cboEstadoCivil.Text = modelo.CEstadoCivil;
                        dtpDataNascimento.Value = Convert.ToDateTime(modelo.CDataNascimento);
                        txtEmail.Text = modelo.CEmail;
                        txtTelefoneFixo.Text = modelo.CTelefoneFixo;
                        txtCelular.Text = modelo.CTelefoneCelular;
                        txtTelefoneOutros.Text = modelo.CTelefoneOutros;
                        txtCEP.Text = modelo.CLogradouroCEP;
                        txtEndereco.Text = modelo.CLogradouroNome;
                        txtNumero.Text = modelo.CLogradouroNumero;
                        txtComplemento.Text = modelo.CLogradouroComplemento;
                        txtCidade.Text = modelo.CLogradouroMunicipio;
                        txtBairro.Text = modelo.CLogradouroBairro;
                        txtUF.Text = modelo.CLogradouroUF;
                        txtDataCadastro.Text = Convert.ToString(modelo.CDataCadastro);
                        //alteraBotoes(3);
                    }
                }
            }
        }
    }
}
