using SGM.Domain.Entities;
using SGM.Domain.Intern.Entities;
using SGM.Domain.Intern.Enum;
using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Application.External;
using SGM.Domain.Intern.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGM.ApplicationServices.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly ICorreriosApplication _correriosApplication;

        const string CadastroInseridoComSucesso = "Cadastro inserido com sucesso! Cliente: ";
        const string CadastroInseridoSemSucesso = "Cadastro NÃO EFETUADO! Cliente: ";
        const string AtualizacaoComSucesso = "Atualização de cliente com sucesso! Cliente: ";
        const string AtualizacaoSemSucesso = "Atualização de cliente NÃO EFETUADO! Cliente: ";

        const string NaoFoiPossivelValidarVeiculo = "Não foi possível verificar/validar veiculo(s) do cliente. ";

        const string ClienteSemVeiculo = "Deseja incluir o veículo dele agora? " +
                        "\n Clicando em (Sim), será aberto uma lista de clientes você escolhe o " +
                        "cliente que você acabou de cadastrar \n " +
                        "e clicando duas vezes você automáticamente poderá cadastrar o veículo dele.";

        const string ClienteComApenasUmVeiculo = "Este Cliente possui 1 veículo no cadastro, " +
                            "abriremos a tela de veiculo deste cliente.";

        const string ClienteComMaisDeUmVeiculo = "Este cliente possui + de 1 veículo cadastrado no sistema, " +
                            "será aberto a lista de veículos.";

        public ClienteBusiness(IClienteApplication clienteApplication, IClienteVeiculoApplication clienteVeiculoApplication, ICorreriosApplication correriosApplication)
        {
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _correriosApplication = correriosApplication;
        }

        public ResponseCliente SalvarCliente(string operacao, Cliente cliente)
        {
            ResponseCliente response = new ResponseCliente
            {
                Mensagem = new Dictionary<TipoMensagemEnum, string>()
            };

            if (operacao == "inserir")
            {
                try
                {
                    var clienteId = _clienteApplication.SalvarCliente(cliente);

                    response.TipoResponse = TipoResponseEnum.Sucess;
                    response.Mensagem.Add(TipoMensagemEnum.Information, $"{CadastroInseridoComSucesso}{cliente.NomeCliente}");
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithQuestion, ClienteSemVeiculo);
                    response.MessageBoxButtons = MessageBoxButtons.YesNo;
                    response.MessageBoxIcon = MessageBoxIcon.Question;

                    response.DeveAbrirFormularioCadastroVeiculoDoCliente = true;
                    response.ClienteId = clienteId;

                    return response;
                }
                catch (Exception ex)
                {
                    response.TipoResponse = TipoResponseEnum.Error;
                    response.Mensagem.Add(TipoMensagemEnum.ErrorInSave, $"{CadastroInseridoSemSucesso}{cliente.NomeCliente}, Mensagem de erro: {ex.Message}");
                    response.MessageBoxButtons = MessageBoxButtons.OK;
                    response.MessageBoxIcon = MessageBoxIcon.Error;

                    return response;
                }
            }
            else
            {
                try
                {
                    _clienteApplication.AtualizarCliente(cliente);
                    response.Mensagem.Add(TipoMensagemEnum.Information, $"{AtualizacaoComSucesso}{cliente.NomeCliente}");
                }
                catch (Exception ex)
                {
                    response.TipoResponse = TipoResponseEnum.Error;
                    response.Mensagem.Add(TipoMensagemEnum.ErrorInUpdate, $"{AtualizacaoSemSucesso}{cliente.NomeCliente}, Mensagem de erro: {ex.Message}");
                    response.MessageBoxButtons = MessageBoxButtons.OK;
                    response.MessageBoxIcon = MessageBoxIcon.Error;

                    return response;
                }
            }

            try
            {
                response.TipoResponse = TipoResponseEnum.Sucess;

                var veiculosDoCliente = _clienteVeiculoApplication.GetVeiculosClienteByClienteId(cliente.ClienteId);

                response.QuantidadeVeiculoCliente = veiculosDoCliente.Count();

                if (response.QuantidadeVeiculoCliente <= 0)
                {
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithQuestion, ClienteSemVeiculo);
                    response.MessageBoxButtons = MessageBoxButtons.YesNo;
                    response.MessageBoxIcon = MessageBoxIcon.Question;

                    return response;
                }
                else if (response.QuantidadeVeiculoCliente == 1)
                {
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithMessage, ClienteComApenasUmVeiculo);
                    response.MessageBoxButtons = MessageBoxButtons.OK;
                    response.MessageBoxIcon = MessageBoxIcon.Information;

                    response.DeveAbrirFormularioCadastroVeiculoDoCliente = true;
                    response.ClienteId = cliente.ClienteId;
                    response.ClienteVeiculoId = veiculosDoCliente.FirstOrDefault().ClienteVeiculoId;

                    return response;
                }
                else
                {
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithQuestion, ClienteComMaisDeUmVeiculo);
                    response.MessageBoxButtons = MessageBoxButtons.YesNo;
                    response.MessageBoxIcon = MessageBoxIcon.Question;

                    response.DeveAbrirFormularioConsultaVeiculoDoCliente = true;

                    return response;
                }
            }
            catch (Exception ex)
            {
                response.TipoResponse = TipoResponseEnum.Error;

                response.Mensagem.Add(TipoMensagemEnum.ErrorInValidation, $"{NaoFoiPossivelValidarVeiculo}, Mensagem de erro: {ex.Message}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Error;

                return response;
            }
        }
    }
}