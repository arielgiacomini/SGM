using Newtonsoft.Json;
using SGM.ApplicationServices.Infrastructure;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.ApplicationServices.Queries
{
    public class MaodeObraQuery : IMaodeObraQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public MaodeObraQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public MaodeObra GetMaodeObraById(int maoDeObraId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/mao-de-obra/{maoDeObraId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<MaodeObra>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<MaodeObra> GetMaodeObraByDescricao(string descricaoMaodeObra)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/mao-de-obra/descricao?descricaoMaodeObra={descricaoMaodeObra}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<MaodeObra>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<MaodeObra> GetMaodeObraByAll()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/mao-de-obra").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<MaodeObra>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}