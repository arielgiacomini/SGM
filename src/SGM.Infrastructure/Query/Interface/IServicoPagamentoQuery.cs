using SGM.Domain.Entities;

namespace SGM.Infrastructure.Queries.Interface
{
    public interface IServicoPagamentoQuery
    {
        ServicoPagamento GetServicoPagamentoByServicoId(int servicoId);
    }
}