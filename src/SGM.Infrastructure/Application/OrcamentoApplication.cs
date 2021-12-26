using SGM.Domain.Entities;
using SGM.Infrastructure.Application.Interface;
using SGM.Infrastructure.Command.Interface;
using SGM.Infrastructure.Queries.Interface;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application
{
    public class OrcamentoApplication : IOrcamentoApplication
    {
        private readonly IOrcamentoCommand _orcamentoCommand;
        private readonly IOrcamentoQuery _orcamentoQuery;

        public OrcamentoApplication(IOrcamentoCommand orcamentoCommand, IOrcamentoQuery orcamentoQuery)
        {
            _orcamentoCommand = orcamentoCommand;
            _orcamentoQuery = orcamentoQuery;
        }

        public int SalvarOrcamento(Orcamento orcamento)
        {
            return _orcamentoCommand.SalvarOrcamento(orcamento);
        }

        public Orcamento GetOrcamentoByOrcamentoId(int orcamentoId)
        {
            return _orcamentoQuery.GetOrcamentoByOrcamentoId(orcamentoId);
        }

        public IList<Orcamento> GetOrcamentoByClienteVeiculoId(int clienteVeiculoId)
        {
            return _orcamentoQuery.GetOrcamentoByClienteVeiculoId(clienteVeiculoId);
        }

        public void AtualizarOrcamento(Orcamento orcamento)
        {
            _orcamentoCommand.AtualizarOrcamento(orcamento);
        }

        public int SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            return _orcamentoCommand.SalvarOrcamentoMaodeObra(orcamentoMaodeObra);
        }

        public int SalvarOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            return _orcamentoCommand.SalvarOrcamentoPeca(orcamentoPeca);
        }

        public void DeletarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            _orcamentoCommand.DeletarOrcamentoMaodeObra(orcamentoMaodeObra);
        }

        public void DeletarOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            _orcamentoCommand.DeletarOrcamentoPeca(orcamentoPeca);
        }

        public IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId)
        {
            return _orcamentoQuery.GetOrcamentoMaodeObraByOrcamentoId(orcamentoId);
        }

        public IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId)
        {
            return _orcamentoQuery.GetOrcamentoPecaByOrcamentoId(orcamentoId);
        }

        public IList<Orcamento> GetUltimosOrcamentos()
        {
            return _orcamentoQuery.GetUltimosOrcamentos();
        }
    }
}