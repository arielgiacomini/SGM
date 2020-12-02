using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IServicoQuery
    {
        Servico GetServicoByServicoId(int ServicoId);
        IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int ServicoId);
        IList<ServicoPeca> GetServicoPecaByServicoId(int ServicoId);
    }
}