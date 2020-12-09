using SGM.Domain.Entities;
using SGM.Domain.Entities.External;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IClienteApplication
    {
        Cliente GetClienteById(int clienteId);
        void SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void InativarCliente(int clienteId);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
        Cliente GetClienteByLikePlacaOrNomeOrApelido(string valor);
        Cliente GetClienteByPlaca(string placaVeiculo);
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}