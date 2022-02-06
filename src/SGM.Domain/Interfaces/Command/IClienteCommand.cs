using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IClienteCommand
    {
        int SalvarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void InativarCliente(int clienteId);
    }
}