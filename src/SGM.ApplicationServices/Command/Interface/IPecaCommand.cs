using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Command.Interface
{
    public interface IPecaCommand
    {
        void SalvarPeca(Peca peca);
        void AtualizarPeca(Peca peca);
    }
}