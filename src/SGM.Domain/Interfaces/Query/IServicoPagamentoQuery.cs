using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IServicoPagamentoQuery
    {
        ServicoPagamento GetServicoPagamentoByServicoId(int servicoId);
    }
}