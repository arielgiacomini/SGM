using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Command.Interface
{
    public interface IMaodeObraCommand
    {
        void SalvarMaodeObra(MaodeObra maoDeObra);
        void AtualizarMaodeObra(MaodeObra maoDeObra);
        void InativarMaoDeObra(int maoDeObraId);
    }
}