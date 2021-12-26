using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application
{
    public class PecaApplication : IPecaApplication
    {
        private readonly IPecaCommand _pecaCommand;
        private readonly IPecaQuery _pecaQuery;

        public PecaApplication(IPecaCommand pecaCommand, IPecaQuery pecaQuery)
        {
            _pecaCommand = pecaCommand;
            _pecaQuery = pecaQuery;
        }

        public void SalvarPeca(Peca peca)
        {
            _pecaCommand.SalvarPeca(peca);
        }

        public void AtualizarPeca(Peca peca)
        {
            _pecaCommand.AtualizarPeca(peca);
        }

        public void InativarPeca(int pecaId)
        {
            _pecaCommand.InativarPeca(pecaId);
        }

        public Peca GetPecaByPecaId(int pecaId)
        {
            return _pecaQuery.GetPecaByPecaId(pecaId);
        }

        public IList<Peca> GetPecaByDescricao(string descricaoPeca)
        {
            return _pecaQuery.GetPecaByDescricao(descricaoPeca);
        }

        public IList<Peca> GetPecaByAll()
        {
            return _pecaQuery.GetPecaByAll();
        }
    }
}