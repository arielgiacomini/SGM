using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IPecaCommand
    {
        void SalvarPeca(Peca peca);
        void AtualizarPeca(Peca peca);
        void InativarPeca(int pecaId);
    }
}