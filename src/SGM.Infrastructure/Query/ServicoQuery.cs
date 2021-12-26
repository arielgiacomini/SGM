using Newtonsoft.Json;
using SGM.Infrastructure.Configuration;
using SGM.Infrastructure.Queries.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.Infrastructure.Queries
{
    public class ServicoQuery : IServicoQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ServicoQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public Servico GetServicoByServicoId(int ServicoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/{ServicoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Servico>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int ServicoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/Servico/mao-de-obra/{ServicoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<ServicoMaodeObra>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<ServicoPeca> GetServicoPecaByServicoId(int ServicoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/Servico/peca/{ServicoId}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IList<ServicoPeca>>(result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<Servico> GetServicoByClienteVeiculoId(int clienteVeiculoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/veiculo-cliente?clienteVeiculoId={clienteVeiculoId}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var dados = JsonConvert.DeserializeObject<IList<Servico>>(result.Content.ReadAsStringAsync().Result);

                    if (dados != null)
                    {
                        return dados;
                    }
                    else
                    {
                        return new List<Servico>();
                    }
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public IList<Servico> GetUltimosServicos()
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/ultimos-gerados?quantidade={_sGMConfiguration.QuantidadeUltimosServicos}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var dados = JsonConvert.DeserializeObject<IList<Servico>>(result.Content.ReadAsStringAsync().Result);

                    if (dados != null)
                    {
                        return dados;
                    }
                    else
                    {
                        return new List<Servico>();
                    }
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}