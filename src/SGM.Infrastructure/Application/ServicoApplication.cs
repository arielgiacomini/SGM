using SGM.Domain.Entities;
using SGM.Infrastructure.Application.Interface;
using SGM.Infrastructure.Command.Interface;
using SGM.Infrastructure.Queries.Interface;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application
{
    public class ServicoApplication : IServicoApplication
    {
        private readonly IServicoQuery _servicoQuery;
        private readonly IServicoCommand _servicoCommand;

        public ServicoApplication(IServicoQuery servicoQuery, IServicoCommand servicoCommand)
        {
            _servicoQuery = servicoQuery;
            _servicoCommand = servicoCommand;
        }

        public int SalvarServico(Servico servico)
        {
            return _servicoCommand.SalvarServico(servico);
        }

        public Servico GetServicoByServicoId(int servicoId)
        {
            return _servicoQuery.GetServicoByServicoId(servicoId);
        }

        public IList<Servico> GetServicoByClienteVeiculoId(int clienteVeiculoId)
        {
            return _servicoQuery.GetServicoByClienteVeiculoId(clienteVeiculoId);
        }

        public void AtualizarServico(Servico servico)
        {
            _servicoCommand.AtualizarServico(servico);
        }

        public int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            return _servicoCommand.SalvarServicoMaodeObra(servicoMaodeObra);
        }

        public int SalvarServicoPeca(ServicoPeca servicoPeca)
        {
            return _servicoCommand.SalvarServicoPeca(servicoPeca);
        }

        public void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            _servicoCommand.DeletarServicoMaodeObra(servicoMaodeObra);
        }

        public void DeletarServicoPeca(ServicoPeca servicoPeca)
        {
            _servicoCommand.DeletarServicoPecaAsync(servicoPeca);
        }

        public IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int servicoId)
        {
            return _servicoQuery.GetServicoMaodeObraByServicoId(servicoId);
        }

        public IList<ServicoPeca> GetServicoPecaByServicoId(int servicoId)
        {
            return _servicoQuery.GetServicoPecaByServicoId(servicoId);
        }

        public IList<Servico> GetUltimosServicos()
        {
            return _servicoQuery.GetUltimosServicos();
        }
    }
}