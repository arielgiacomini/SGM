using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application
{
    public class ServicoPagamentoApplication : IServicoPagamentoApplication
    {
        private readonly IServicoPagamentoQuery _servicoPagamentoQuery;
        private readonly IFormaPagamentoQuery _formaPagamentoQuery;

        public ServicoPagamentoApplication(IServicoPagamentoQuery servicoPagamentoQuery, IFormaPagamentoQuery formaPagamentoQuery)
        {
            _servicoPagamentoQuery = servicoPagamentoQuery;
            _formaPagamentoQuery = formaPagamentoQuery;
        }

        public ServicoPagamento GetServicoPagamentoByServicoId(int servicoId)
        {
            return _servicoPagamentoQuery.GetServicoPagamentoByServicoId(servicoId);
        }

        public IList<FormaPagamento> GetFormaPagamentoByAll()
        {
            return _formaPagamentoQuery.GetFormaPagamentoByAll();
        }
    }
}