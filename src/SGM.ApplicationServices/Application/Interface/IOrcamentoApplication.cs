using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IOrcamentoApplication
    {
        void AtualizarOrcamento(Orcamento orcamento);
        void DeletarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra);
        void DeletarOrcamentoPeca(OrcamentoPeca orcamentoPeca);
        IList<Orcamento> GetOrcamentoByClienteVeiculoId(int clienteVeiculoId);
        Orcamento GetOrcamentoByOrcamentoId(int orcamentoId);
        IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
        IList<Orcamento> GetUltimosOrcamentos();
        int SalvarOrcamento(Orcamento orcamento);
        int SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra);
        int SalvarOrcamentoPeca(OrcamentoPeca orcamentoPeca);
    }
}