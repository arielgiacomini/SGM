using Newtonsoft.Json;
using SGM.Infrastructure.Command.Interface;
using SGM.Infrastructure.Configuration;
using SGM.Domain.Entities;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.Infrastructure.Command
{
    public class MaodeObraCommand : IMaodeObraCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public MaodeObraCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public void SalvarMaodeObra(MaodeObra maoDeObra)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(maoDeObra), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/mao-de-obra", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR mão de obra. Descrição: {maoDeObra.Descricao}");
                }
            }
        }

        public void AtualizarMaodeObra(MaodeObra maoDeObra)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(maoDeObra), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/mao-de-obra/{maoDeObra.MaodeObraId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR mão de obra. Descrição: {maoDeObra.Descricao}");
                }
            }
        }

        public void InativarMaoDeObra(int maoDeObraId)
        {
            using (var client = new HttpClient())
            {
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/mao-de-obra/inativar/{maoDeObraId}", null).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao INATIVAR mão de obra. Identificador: {maoDeObraId}");
                }
            }
        }

        public void SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {

        }
    }
}