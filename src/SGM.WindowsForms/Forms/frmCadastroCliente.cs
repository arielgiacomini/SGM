﻿using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using System;
using System.Linq;
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
                    _clienteApplication.InativarCliente(Convert.ToInt32(txtClienteId.Text));

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

                var veiculosDoCliente = _clienteApplication.GetVeiculosClienteByClienteId(cliente.ClienteId);

                bool existeVeiculoCliente = veiculosDoCliente.Any();

                if (existeVeiculoCliente)
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

        private void VerificaSeCPFJaExisteNaBaseDados_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                var cliente = _clienteApplication.GetClienteByDocumentoCliente(txtCPF.Text);

                if (cliente != null)
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
                        txtDataCadastro.Text = Convert.ToString(cliente.DataCadastro);
                    }
                }
            }
        }
    }
}