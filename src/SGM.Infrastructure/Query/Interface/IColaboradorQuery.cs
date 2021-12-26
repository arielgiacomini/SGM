using SGM.Domain.Entities;

namespace SGM.Infrastructure.Queries.Interface
{
    public interface IColaboradorQuery
    {
        Colaborador GetColaboradorByColaboradorLogin(string colaboradorLogin);
    }
}