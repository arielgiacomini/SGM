using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Application
{
    public interface IServicoPagamentoApplication
    {
        IList<FormaPagamento> GetFormaPagamentoByAll();
        ServicoPagamento GetServicoPagamentoByServicoId(int servicoId);
    }
}