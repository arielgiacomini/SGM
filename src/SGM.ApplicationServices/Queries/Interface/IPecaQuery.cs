using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IPecaQuery
    {
        IList<Peca> GetPecaByDescricao(string descricaoPeca);
        Peca GetPecaByPecaId(int pecaId);
    }
}