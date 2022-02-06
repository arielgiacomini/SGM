using SGM.Domain.Entities;
using SGM.Domain.Intern.Entities;
using SGM.Domain.Intern.Enum;
using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static SGM.ApplicationServices.Messages;

namespace SGM.ApplicationServices.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;

        public ClienteBusiness(
            IClienteApplication clienteApplication,
            IClienteVeiculoApplication clienteVeiculoApplication)
        {
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
        }

        public ResponseCliente SaveOrUpdate(string operacao, Cliente cliente)
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
                    response.Mensagem.Add(TipoMensagemEnum.Information, $"{Messages.Mensagem(MensagemEnum.CadastroInseridoComSucesso)}{cliente.NomeCliente}");
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithQuestion, Messages.Mensagem(MensagemEnum.ClienteSemVeiculo));
                    response.MessageBoxButtons = MessageBoxButtons.YesNo;
                    response.MessageBoxIcon = MessageBoxIcon.Question;

                    response.DeveAbrirFormularioCadastroVeiculoDoCliente = true;
                    response.ClienteId = clienteId;

                    return response;
                }
                catch (Exception ex)
                {
                    response.TipoResponse = TipoResponseEnum.Error;
                    response.Mensagem.Add(TipoMensagemEnum.ErrorInSave, $"{Messages.Mensagem(MensagemEnum.CadastroInseridoSemSucesso)}{cliente.NomeCliente}, Mensagem de erro: {ex.Message}");
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
                    response.Mensagem.Add(TipoMensagemEnum.Information, $"{Messages.Mensagem(MensagemEnum.AtualizacaoComSucesso)}{cliente.NomeCliente}");
                }
                catch (Exception ex)
                {
                    response.TipoResponse = TipoResponseEnum.Error;
                    response.Mensagem.Add(TipoMensagemEnum.ErrorInUpdate, $"{Messages.Mensagem(MensagemEnum.AtualizacaoSemSucesso)}{cliente.NomeCliente}, Mensagem de erro: {ex.Message}");
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
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithQuestion, Messages.Mensagem(MensagemEnum.ClienteSemVeiculo));
                    response.MessageBoxButtons = MessageBoxButtons.YesNo;
                    response.MessageBoxIcon = MessageBoxIcon.Question;

                    return response;
                }
                else if (response.QuantidadeVeiculoCliente == 1)
                {
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithMessage, Messages.Mensagem(MensagemEnum.ClienteComApenasUmVeiculo));
                    response.MessageBoxButtons = MessageBoxButtons.OK;
                    response.MessageBoxIcon = MessageBoxIcon.Information;

                    response.DeveAbrirFormularioCadastroVeiculoDoCliente = true;
                    response.ClienteId = cliente.ClienteId;
                    response.ClienteVeiculoId = veiculosDoCliente.FirstOrDefault().ClienteVeiculoId;

                    return response;
                }
                else
                {
                    response.Mensagem.Add(TipoMensagemEnum.SucessWithQuestion, Messages.Mensagem(MensagemEnum.ClienteComMaisDeUmVeiculo));
                    response.MessageBoxButtons = MessageBoxButtons.YesNo;
                    response.MessageBoxIcon = MessageBoxIcon.Question;

                    response.DeveAbrirFormularioConsultaVeiculoDoCliente = true;

                    return response;
                }
            }
            catch (Exception ex)
            {
                response.TipoResponse = TipoResponseEnum.Error;

                response.Mensagem.Add(TipoMensagemEnum.ErrorInValidation, $"{Messages.Mensagem(MensagemEnum.NaoFoiPossivelValidarVeiculo)}, Mensagem de erro: {ex.Message}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Error;

                return response;
            }
        }

        public ResponseCliente Delete(string clienteId)
        {
            ResponseCliente response = new ResponseCliente
            {
                Mensagem = new Dictionary<TipoMensagemEnum, string>()
            };

            int.TryParse(clienteId, out int intClienteId);

            try
            {
                _clienteApplication.InativarCliente(intClienteId);

                response.TipoResponse = TipoResponseEnum.Sucess;
                response.Mensagem.Add(TipoMensagemEnum.SucessWithMessage, $"{Messages.Mensagem(MensagemEnum.ExclusaoComSucesso)}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Warning;

                return response;
            }
            catch (Exception ex)
            {
                response.TipoResponse = TipoResponseEnum.Error;
                response.Mensagem.Add(TipoMensagemEnum.ErrorInDelete, $"{Messages.Mensagem(MensagemEnum.ExclusaoSemSucesso)}, Mensagem de erro: {ex.Message}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Error;

                response.InativacaoClienteWithError = true;
            }

            return new ResponseCliente();
        }

        public ResponseCliente Search()
        {
            ResponseCliente response = new ResponseCliente
            {
                Mensagem = new Dictionary<TipoMensagemEnum, string>()
            };

            response.DeveAbrirFormularioConsultaCliente = true;
            response.TipoResponse = TipoResponseEnum.Sucess;

            return response;
        }

        public ResponseCliente Search(int clienteId)
        {
            ResponseCliente response = new ResponseCliente
            {
                Mensagem = new Dictionary<TipoMensagemEnum, string>()
            };

            try
            {
                var cliente = _clienteApplication.GetClienteById(clienteId);
                response.Cliente = cliente;
                response.TipoResponse = TipoResponseEnum.SucessWithoutMessageOrQuestion;
            }
            catch (Exception ex)
            {
                response.TipoResponse = TipoResponseEnum.Error;
                response.Mensagem.Add(TipoMensagemEnum.ErrorInSearch, $"{Messages.Mensagem(MensagemEnum.PesquisaSemSucesso)}, Mensagem de erro: {ex.Message}");
                response.MessageBoxButtons = MessageBoxButtons.OK;
                response.MessageBoxIcon = MessageBoxIcon.Error;

                response.InativacaoClienteWithError = true;
            }

            return response;
        }
    }
}