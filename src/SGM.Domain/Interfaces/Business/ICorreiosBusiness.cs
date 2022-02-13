using SGM.Domain.Intern.Entities;

namespace SGM.Domain.Intern.Interfaces.Business
{
    public interface ICorreiosBusiness
    {
        ResponseCorreios SearchByCEP(string cep);
    }
}