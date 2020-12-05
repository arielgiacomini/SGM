using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IOrcamentoQuery
    {
        IList<Orcamento> GetOrcamentoByClienteVeiculoId(int clienteVeiculoId);
        Orcamento GetOrcamentoByOrcamentoId(int orcamentoId);
        IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
    }
}