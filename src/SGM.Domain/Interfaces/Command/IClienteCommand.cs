using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IClienteCommand
    {
        void SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void InativarCliente(int clienteId);
    }
}