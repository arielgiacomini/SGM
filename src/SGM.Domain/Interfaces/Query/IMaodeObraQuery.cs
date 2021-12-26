using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IMaodeObraQuery
    {
        IList<MaodeObra> GetMaodeObraByAll();
        IList<MaodeObra> GetMaodeObraByDescricao(string descricaoMaodeObra);
        MaodeObra GetMaodeObraById(int maoDeObraId);
    }
}