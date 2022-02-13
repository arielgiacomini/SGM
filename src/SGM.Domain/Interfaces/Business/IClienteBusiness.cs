using SGM.Domain.Entities;
using SGM.Domain.Intern.Entities;

namespace SGM.Domain.Intern.Interfaces.Business
{
    public interface IClienteBusiness
    {
        ResponseCliente Delete(string clienteId);
        ResponseCliente SaveOrUpdate(string operacao, Cliente cliente);
        ResponseCliente Search();
        ResponseCliente SearchByClienteId(int clienteId);
        ResponseCliente SearchByCPF(string operacao, string documentoCliente);
    }
}