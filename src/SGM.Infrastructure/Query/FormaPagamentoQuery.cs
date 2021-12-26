using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.Infrastructure.Query
{
    public class FormaPagamentoQuery : IFormaPagamentoQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public FormaPagamentoQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public IList<FormaPagamento> GetFormaPagamentoByAll()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/forma-pagamento").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<IList<FormaPagamento>>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new List<FormaPagamento>();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}