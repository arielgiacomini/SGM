using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Application
{
    public interface IClienteApplication
    {
        Cliente GetClienteById(int clienteId);
        int SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void InativarCliente(int clienteId);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
        Cliente GetClienteByLikePlacaOrNomeOrApelido(string valor);
        Cliente GetClienteByPlaca(string placaVeiculo);
    }
}