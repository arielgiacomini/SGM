using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IClienteApplication
    {
        Cliente GetClienteById(int clienteId);
        void SalvarCliente(Cliente cliente);
    }
}
