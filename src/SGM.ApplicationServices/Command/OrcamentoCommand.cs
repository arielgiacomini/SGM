using Newtonsoft.Json;
using SGM.ApplicationServices.Command.Interface;
using SGM.Infrastructure.Configuration;
using SGM.Domain.Entities;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.ApplicationServices.Command
{
    public class OrcamentoCommand : IOrcamentoCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public OrcamentoCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public int SalvarOrcamento(Orcamento orcamento)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(orcamento), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR orcamento. OrcamentoId: {orcamento.OrcamentoId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public void AtualizarOrcamento(Orcamento orcamento)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(orcamento), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/{orcamento.OrcamentoId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR orçamento. Descrição: {orcamento.Descricao}");
                }
            }
        }

        public int SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(orcamentoMaodeObra), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/mao-de-obra", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR orçamento-mao-de-obra. OrcamentoId: {orcamentoMaodeObra.OrcamentoId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public int SalvarOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(orcamentoPeca), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/peca", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR orçamento-pecas. OrcamentoId: {orcamentoPeca.OrcamentoId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public void DeletarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/mao-de-obra"),
                    Content = new StringContent(JsonConvert.SerializeObject(orcamentoMaodeObra), Encoding.UTF8, "application/json")
                };

                var result = client.SendAsync(request);
                if (!result.Result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao DELETAR orçamento-mao-de-obra. OrcamentoId: {orcamentoMaodeObra.OrcamentoId}");
                }
            }
        }

        public void DeletarOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{_sGMConfiguration.SGMWebApiUrl}SGM/orcamento/peca"),
                    Content = new StringContent(JsonConvert.SerializeObject(orcamentoPeca), Encoding.UTF8, "application/json")
                };

                var result = client.SendAsync(request);
                if (!result.Result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao DELETAR orçamento-peca. OrcamentoId: {orcamentoPeca.OrcamentoId}");
                }
            }
        }
    }
}