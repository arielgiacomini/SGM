using SGM.Domain.Entities.External;

namespace SGM.Infrastructure.Application.Interface.External
{
    public interface ICorreriosApplication
    {
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}