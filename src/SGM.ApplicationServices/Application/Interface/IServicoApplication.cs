using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IServicoApplication
    {
        void AtualizarServico(Servico servico);
        void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        void DeletarServicoPeca(ServicoPeca servicoPeca);
        IList<Servico> GetServicoByClienteVeiculoId(int clienteVeiculoId);
        Servico GetServicoByServicoId(int servicoId);
        IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int servicoId);
        IList<ServicoPeca> GetServicoPecaByServicoId(int servicoId);
        IList<Servico> GetUltimosServicos();
        int SalvarServico(Servico servico);
        int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        int SalvarServicoPeca(ServicoPeca servicoPeca);
    }
}