using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IOrcamentoCommand
    {
        void AtualizarOrcamento(Orcamento orcamento);
        void DeletarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra);
        void DeletarOrcamentoPeca(OrcamentoPeca orcamentoPeca);
        int SalvarOrcamento(Orcamento orcamento);
        int SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra);
        int SalvarOrcamentoPeca(OrcamentoPeca orcamentoPeca);
    }
}