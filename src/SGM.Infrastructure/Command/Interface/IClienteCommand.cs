using SGM.Domain.Entities;

namespace SGM.Infrastructure.Command.Interface
{
    public interface IClienteCommand
    {
        void SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void InativarCliente(int clienteId);
    }
}