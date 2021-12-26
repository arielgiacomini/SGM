using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IServicoQuery
    {
        IList<Servico> GetServicoByClienteVeiculoId(int clienteVeiculoId);
        Servico GetServicoByServicoId(int ServicoId);
        IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int ServicoId);
        IList<ServicoPeca> GetServicoPecaByServicoId(int ServicoId);
        IList<Servico> GetUltimosServicos();
    }
}