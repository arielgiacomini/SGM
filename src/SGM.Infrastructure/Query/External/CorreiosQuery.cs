using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Query.External;
using SGM.Domain.Entities.External;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;

namespace SGM.Infrastructure.Query.External
{
    public class CorreiosQuery : ICorreiosQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public CorreiosQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public CorreiosEndereco GetEnderecoByCEP(string cEP)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.ViaCepApiUrl}/{cEP}/json/").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<CorreiosEndereco>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new CorreiosEndereco();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}