using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IClienteVeiculoQuery
    {
        IEnumerable<ClienteVeiculo> GetClienteVeiculoById(int clienteId);
    }
}