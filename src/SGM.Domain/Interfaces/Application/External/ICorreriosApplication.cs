using SGM.Domain.Entities.External;

namespace SGM.Domain.Intern.Interfaces.Application.External
{
    public interface ICorreriosApplication
    {
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}