﻿using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteCommand _clienteCommand;
        private readonly IClienteQuery _clienteQuery;
        private readonly IClienteVeiculoQuery _clienteVeiculoQuery;

        public ClienteApplication(IClienteCommand clienteCommand, IClienteQuery clienteQuery, IClienteVeiculoQuery clienteVeiculoQuery)
        {
            _clienteCommand = clienteCommand;
            _clienteQuery = clienteQuery;
            _clienteVeiculoQuery = clienteVeiculoQuery;
        }

        public Cliente GetClienteById(int clienteId)
        {
            var cliente = _clienteQuery.GetClienteById(clienteId);

            return cliente;
        }

        public void SalvarCliente(Cliente cliente)
        {
            _clienteCommand.SalvarCliente(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _clienteCommand.AtualizarCliente(cliente);
        }

        public void InativarCliente(int clienteId)
        {
            _clienteCommand.InativarCliente(clienteId);
        }

        public IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId)
        {
            return _clienteVeiculoQuery.GetClienteVeiculoById(clienteId);
        }

        public Cliente GetClienteByDocumentoCliente(string documentoCliente)
        {
            return _clienteQuery.GetClienteByDocumentoCliente(documentoCliente);
        }
    }
}