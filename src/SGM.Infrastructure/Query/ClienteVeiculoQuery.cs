using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SGM.Infrastructure.Query
{
    public class ClienteVeiculoQuery : IClienteVeiculoQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ClienteVeiculoQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public IEnumerable<ClienteVeiculo> GetClienteVeiculoById(int clienteId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente-veiculo/{clienteId}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<IEnumerable<ClienteVeiculo>>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new List<ClienteVeiculo>();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public ClienteVeiculo GetVeiculoClienteByPlaca(string placa)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente-veiculo/placa/{placa}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<ClienteVeiculo>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new ClienteVeiculo();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }

        public ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente-veiculo/id/{clienteVeiculoId}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<ClienteVeiculo>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new ClienteVeiculo();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}