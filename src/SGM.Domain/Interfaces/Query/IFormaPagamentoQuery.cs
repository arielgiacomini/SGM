using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IFormaPagamentoQuery
    {
        IList<FormaPagamento> GetFormaPagamentoByAll();
    }
}