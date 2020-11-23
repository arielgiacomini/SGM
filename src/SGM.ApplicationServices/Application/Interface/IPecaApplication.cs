using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IPecaApplication
    {
        void SalvarPeca(Peca peca);
        void AtualizarPeca(Peca peca);
        void InativarPeca(int pecaId);
        Peca GetPecaByPecaId(int pecaId);
    }
}