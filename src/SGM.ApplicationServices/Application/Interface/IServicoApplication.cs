using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IServicoApplication
    {
        void AtualizarServico(Servico servico);
        void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        void DeletarServicoPeca(ServicoPeca servicoPeca);
        Servico GetServicoByServicoId(int servicoId);
        IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int servicoId);
        IList<ServicoPeca> GetServicoPecaByServicoId(int servicoId);
        int SalvarServico(Servico servico);
        int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        int SalvarServicoPeca(ServicoPeca servicoPeca);
    }
}