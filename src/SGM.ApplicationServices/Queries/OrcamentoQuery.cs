using Newtonsoft.Json;
using SGM.ApplicationServices.Infrastructure;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.ApplicationServices.Queries
{
    public class OrcamentoQuery : IOrcamentoQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public OrcamentoQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public Orcamento GetOrcamentoByOrcamentoId(int orcamentoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/{orcamentoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Orcamento>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/mao-de-obra/{orcamentoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<OrcamentoMaodeObra>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/peca/{orcamentoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<OrcamentoPeca>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}