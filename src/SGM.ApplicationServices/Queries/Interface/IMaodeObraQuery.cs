using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IMaodeObraQuery
    {
        IList<MaodeObra> GetMaodeObraByAll();
        IList<MaodeObra> GetMaodeObraByDescricao(string descricaoMaodeObra);
        MaodeObra GetMaodeObraById(int maoDeObraId);
    }
}