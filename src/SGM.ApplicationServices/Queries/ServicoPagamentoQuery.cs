using Newtonsoft.Json;
using SGM.Infrastructure.Configuration;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace SGM.ApplicationServices.Queries
{
    public class ServicoPagamentoQuery : IServicoPagamentoQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ServicoPagamentoQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public ServicoPagamento GetServicoPagamentoByServicoId(int servicoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico-pagamento/{servicoId}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var servicoPagamento = JsonConvert.DeserializeObject<IList<ServicoPagamento>>(result.Content.ReadAsStringAsync().Result);

                    return servicoPagamento.FirstOrDefault();
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new ServicoPagamento();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}