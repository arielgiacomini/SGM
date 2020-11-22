using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application
{
    public class MaodeObraApplication : IMaodeObraApplication
    {
        private readonly IMaodeObraCommand _maoDeObraCommand;
        private readonly IMaodeObraQuery _maodeObraQuery;

        public MaodeObraApplication(IMaodeObraCommand maodeObraCommand, IMaodeObraQuery maodeObraQuery)
        {
            _maoDeObraCommand = maodeObraCommand;
            _maodeObraQuery = maodeObraQuery;
        }

        public void SalvarMaodeObra(MaodeObra maoDeObra)
        {
            _maoDeObraCommand.SalvarMaodeObra(maoDeObra);
        }

        public void AtualizarMaodeObra(MaodeObra maoDeObra)
        {
            _maoDeObraCommand.AtualizarMaodeObra(maoDeObra);
        }

        public void InativarMaodeObra(int maoDeObraId)
        {
            _maoDeObraCommand.InativarMaoDeObra(maoDeObraId);
        }

        public MaodeObra GetMaodeObraById(int maoDeObraId)
        {
            return _maodeObraQuery.GetMaodeObraById(maoDeObraId);
        }
    }
}