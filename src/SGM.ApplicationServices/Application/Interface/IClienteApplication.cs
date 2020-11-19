using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IClienteApplication
    {
        Cliente GetClienteById(int clienteId);
        void SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void InativarCliente(int clienteId);
        IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
    }
}