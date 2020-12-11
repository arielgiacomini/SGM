using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IColaboradorQuery
    {
        Colaborador GetColaboradorByColaboradorLogin(string colaboradorLogin);
    }
}