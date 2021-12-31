using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IClienteVeiculoQuery
    {
        IEnumerable<ClienteVeiculo> GetClienteVeiculoById(int clienteId);
        ClienteVeiculo GetVeiculoClienteByPlaca(string placa);
        ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId);
    }
}