using SGM.ApplicationServices.Application.Interface.External;
using SGM.ApplicationServices.Queries.Interface.External;
using SGM.Domain.Entities.External;

namespace SGM.ApplicationServices.Application.External
{
    public class CorreiosApplication : ICorreriosApplication
    {
        private readonly ICorreiosQuery _correiosQuery;

        public CorreiosApplication(ICorreiosQuery correiosQuery)
        {
            _correiosQuery = correiosQuery;
        }

        public CorreiosEndereco GetEnderecoByCEP(string cEP)
        {
            return _correiosQuery.GetEnderecoByCEP(cEP);
        }
    }
}