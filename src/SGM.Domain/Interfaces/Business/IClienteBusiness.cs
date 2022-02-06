using SGM.Domain.Entities;
using SGM.Domain.Intern.Entities;

namespace SGM.Domain.Intern.Interfaces.Business
{
    public interface IClienteBusiness
    {
        ResponseCliente SalvarCliente(string operacao, Cliente cliente);
    }
}