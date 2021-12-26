using Newtonsoft.Json;
using SGM.Infrastructure.Configuration;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.ApplicationServices.Queries
{
    public class PecaQuery : IPecaQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public PecaQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public Peca GetPecaByPecaId(int pecaId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/peca/{pecaId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Peca>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<Peca> GetPecaByDescricao(string descricaoPeca)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/peca/descricao?descricaoPeca={descricaoPeca}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<Peca>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<Peca> GetPecaByAll()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/peca").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<Peca>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}