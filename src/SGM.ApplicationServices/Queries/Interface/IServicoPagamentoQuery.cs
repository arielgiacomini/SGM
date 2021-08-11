using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IServicoPagamentoQuery
    {
        ServicoPagamento GetServicoPagamentoByServicoId(int servicoId);
    }
}