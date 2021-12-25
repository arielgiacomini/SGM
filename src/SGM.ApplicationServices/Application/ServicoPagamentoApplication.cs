using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application
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