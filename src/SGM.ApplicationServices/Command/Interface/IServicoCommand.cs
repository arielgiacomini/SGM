using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Command.Interface
{
    public interface IServicoCommand
    {
        void AtualizarServico(Servico servico);
        void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        void DeletarServicoPeca(ServicoPeca servicoPeca);
        int SalvarServico(Servico servico);
        int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra);
        int SalvarServicoPeca(ServicoPeca servicoPeca);
    }
}