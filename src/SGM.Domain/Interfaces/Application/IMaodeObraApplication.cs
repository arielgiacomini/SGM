using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Application
{
    public interface IMaodeObraApplication
    {
        void SalvarMaodeObra(MaodeObra maoDeObra);
        void AtualizarMaodeObra(MaodeObra maoDeObra);
        void InativarMaodeObra(int maoDeObraId);
        MaodeObra GetMaodeObraById(int maoDeObraId);
        IList<MaodeObra> GetMaodeObraByDescricao(string descricaoMaodeObra);
        IList<MaodeObra> GetMaodeObraByAll();
    }
}