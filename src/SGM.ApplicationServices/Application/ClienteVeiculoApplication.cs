using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application
{
    public class ClienteVeiculoApplication : IClienteVeiculoApplication
    {
        private readonly IClienteVeiculoQuery _clienteVeiculoQuery;
        private readonly IClienteVeiculoCommand _clienteVeiculoCommand;

        public ClienteVeiculoApplication(IClienteVeiculoQuery clienteVeiculoQuery, IClienteVeiculoCommand clienteVeiculoCommand)
        {
            _clienteVeiculoQuery = clienteVeiculoQuery;
            _clienteVeiculoCommand = clienteVeiculoCommand;
        }

        public IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId)
        {
            return _clienteVeiculoQuery.GetClienteVeiculoById(clienteId);
        }

        public ClienteVeiculo GetVeiculoClienteByPlaca(string placa)
        {
            return _clienteVeiculoQuery.GetVeiculoClienteByPlaca(placa);
        }

        public ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId)
        {
            return _clienteVeiculoQuery.GetVeiculoClienteByClienteVeiculoId(clienteVeiculoId);
        }

        public int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo)
        {
            return _clienteVeiculoCommand.SalvarClienteVeiculo(clienteVeiculo);
        }

        public void AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo)
        {
            _clienteVeiculoCommand.AtualizarClienteVeiculo(clienteVeiculo);
        }

        public void InativarClienteVeiculo(int clienteVeiculoId)
        {
            _clienteVeiculoCommand.InativarClienteVeiculo(clienteVeiculoId);
        }
    }
}
