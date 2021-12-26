using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IMaodeObraCommand
    {
        void SalvarMaodeObra(MaodeObra maoDeObra);
        void AtualizarMaodeObra(MaodeObra maoDeObra);
        void InativarMaoDeObra(int maoDeObraId);
    }
}