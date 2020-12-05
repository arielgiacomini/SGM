using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IPecaApplication
    {
        void SalvarPeca(Peca peca);
        void AtualizarPeca(Peca peca);
        void InativarPeca(int pecaId);
        Peca GetPecaByPecaId(int pecaId);
        IList<Peca> GetPecaByDescricao(string descricaoPeca);
        IList<Peca> GetPecaByAll();
    }
}