using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SGM.Infrastructure.Command
{
    public class ServicoCommand : IServicoCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ServicoCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public int SalvarServico(Servico servico)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(servico), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR Servico. ServicoId: {servico.ServicoId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public void AtualizarServico(Servico servico)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(servico), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/{servico.ServicoId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR serviço. Descrição: {servico.Descricao}");
                }
            }
        }

        public int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(servicoMaodeObra), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/mao-de-obra", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR serviço-mao-de-obra. ServicoId: {servicoMaodeObra.ServicoId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public int SalvarServicoPeca(ServicoPeca servicoPeca)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(servicoPeca), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/peca", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR serviço-pecas. ServicoId: {servicoPeca.ServicoId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/mao-de-obra"),
                    Content = new StringContent(JsonConvert.SerializeObject(servicoMaodeObra), Encoding.UTF8, "application/json")
                };

                var result = client.SendAsync(request);
                if (!result.Result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao DELETAR serviço-mao-de-obra. ServicoId: {servicoMaodeObra.ServicoId}");
                }
            }
        }

        public async Task DeletarServicoPecaAsync(ServicoPeca servicoPeca)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{_sGMConfiguration.SGMWebApiUrl}SGM/servico/peca"),
                    Content = new StringContent(JsonConvert.SerializeObject(servicoPeca), Encoding.UTF8, "application/json")
                };

                var result = await client.SendAsync(request);
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao DELETAR serviço-peca. ServicoId: {servicoPeca.ServicoId}");
                }
            }
        }
    }
}