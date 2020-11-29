using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IOrcamentoQuery
    {
        Orcamento GetOrcamentoByOrcamentoId(int orcamentoId);
        IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
    }
}