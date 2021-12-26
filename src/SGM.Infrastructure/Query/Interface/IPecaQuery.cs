using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Queries.Interface
{
    public interface IPecaQuery
    {
        IList<Peca> GetPecaByAll();
        IList<Peca> GetPecaByDescricao(string descricaoPeca);
        Peca GetPecaByPecaId(int pecaId);
    }
}