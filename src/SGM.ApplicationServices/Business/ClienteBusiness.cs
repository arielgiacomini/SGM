using SGM.Domain.Entities;
using SGM.Domain.Intern.Entities;
using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Application.External;
using System;

namespace SGM.ApplicationServices.Business
{
    public class ClienteBusiness
    {
        private readonly IClienteApplication _clienteApplication;
        private readonly IClienteVeiculoApplication _clienteVeiculoApplication;
        private readonly ICorreriosApplication _correriosApplication;

        public ClienteBusiness(IClienteApplication clienteApplication, IClienteVeiculoApplication clienteVeiculoApplication, ICorreriosApplication correriosApplication)
        {
            _clienteApplication = clienteApplication;
            _clienteVeiculoApplication = clienteVeiculoApplication;
            _correriosApplication = correriosApplication;
        }

        public CallbackFrontEndCliente SalvarCliente(string operacao, Cliente cliente)
        {
            CallbackFrontEndCliente callback = new CallbackFrontEndCliente();

            if (operacao == "inserir")
            {
                try
                {
                    _clienteApplication.SalvarCliente(cliente);
                    callback.Mensagem = $"Cadastro inserido com sucesso! Cliente: {cliente.NomeCliente}";
                }
                catch (Exception ex)
                {
                    callback.Mensagem = $"Cadastro NÃO EFETUADO! Cliente: {cliente.NomeCliente}, Mensagem de erro: {ex}";
                }
            }

            return callback;
        }
    }
}