using SGM.Domain.Entities.External;

namespace SGM.ApplicationServices.Queries.Interface.External
{
    public interface ICorreiosQuery
    {
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}