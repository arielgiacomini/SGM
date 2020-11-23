using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IPecaQuery
    {
        Peca GetPecaByPecaId(int pecaId);
    }
}