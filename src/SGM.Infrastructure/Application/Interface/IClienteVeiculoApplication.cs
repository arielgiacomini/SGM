using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application.Interface
{
    public interface IClienteVeiculoApplication
    {
        IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId);
        ClienteVeiculo GetVeiculoClienteByPlaca(string placa);
        ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId);
        int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void InativarClienteVeiculo(int clienteVeiculoId);
    }
}