using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application
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

        public IList<MaodeObra> GetMaodeObraByDescricao(string descricaoMaodeObra)
        {
            return _maodeObraQuery.GetMaodeObraByDescricao(descricaoMaodeObra);
        }

        public IList<MaodeObra> GetMaodeObraByAll()
        {
            return _maodeObraQuery.GetMaodeObraByAll();
        }
    }
}