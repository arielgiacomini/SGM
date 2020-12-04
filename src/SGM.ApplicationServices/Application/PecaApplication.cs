using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application
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
    }
}