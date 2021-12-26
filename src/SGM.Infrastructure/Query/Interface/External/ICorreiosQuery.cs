using SGM.Domain.Entities.External;

namespace SGM.Infrastructure.Queries.Interface.External
{
    public interface ICorreiosQuery
    {
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}