using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IColaboradorQuery
    {
        Colaborador GetColaboradorByColaboradorLogin(string colaboradorLogin);
    }
}