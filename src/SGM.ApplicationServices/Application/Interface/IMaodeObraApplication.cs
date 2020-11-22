using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IMaodeObraApplication
    {
        void SalvarMaodeObra(MaodeObra maoDeObra);
        void AtualizarMaodeObra(MaodeObra maoDeObra);
        void InativarMaodeObra(int maoDeObraId);
        MaodeObra GetMaodeObraById(int maoDeObraId);
    }
}