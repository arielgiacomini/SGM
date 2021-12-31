using SGM.Domain.Entities.External;

namespace SGM.Domain.Intern.Interfaces.Query.External
{
    public interface ICorreiosQuery
    {
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}