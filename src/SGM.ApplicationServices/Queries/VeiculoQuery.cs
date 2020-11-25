using Newtonsoft.Json;
using SGM.ApplicationServices.Infrastructure;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.ApplicationServices.Queries
{
    public class VeiculoQuery : IVeiculoQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public VeiculoQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public Veiculo GetVeiculoByVeiculoId(int veiculoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo/{veiculoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Veiculo>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public VeiculoMarca GetMarcaByMarcaId(int marcaId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/marca/{marcaId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<VeiculoMarca>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<VeiculoMarca> GetMarcasByAll()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/marcas").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<VeiculoMarca>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}