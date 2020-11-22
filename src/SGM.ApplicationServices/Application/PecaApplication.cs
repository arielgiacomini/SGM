using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application
{
    public class PecaApplication : IPecaApplication
    {
        private readonly IPecaCommand _pecaCommand;

        public PecaApplication(IPecaCommand pecaCommand)
        {
            _pecaCommand = pecaCommand;
        }

        public void SalvarPeca(Peca peca)
        {
            _pecaCommand.SalvarPeca(peca);
        }

        public void AtualizarPeca(Peca peca)
        {
            _pecaCommand.AtualizarPeca(peca);
        }
    }
}