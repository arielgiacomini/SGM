using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;

namespace SGM.Infrastructure.Query
{
    public class ColaboradorQuery : IColaboradorQuery
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ColaboradorQuery(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public Colaborador GetColaboradorByColaboradorLogin(string colaboradorLogin)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/colaborador/colaborador-login/{colaboradorLogin}").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<Colaborador>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new Colaborador();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}