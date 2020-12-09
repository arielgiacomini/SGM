using SGM.Domain.Entities.External;

namespace SGM.ApplicationServices.Application.Interface.External
{
    public interface ICorreriosApplication
    {
        CorreiosEndereco GetEnderecoByCEP(string cEP);
    }
}