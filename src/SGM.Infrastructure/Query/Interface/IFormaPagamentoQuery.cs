using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Queries.Interface
{
    public interface IFormaPagamentoQuery
    {
        IList<FormaPagamento> GetFormaPagamentoByAll();
    }
}