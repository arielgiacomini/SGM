using Newtonsoft.Json;
using SGM.ApplicationServices.Command.Interface;
using SGM.Infrastructure.Configuration;
using SGM.Domain.Entities;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.ApplicationServices.Command
{
    public class PecaCommand : IPecaCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public PecaCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public void SalvarPeca(Peca peca)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(peca), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/peca", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR peças. Descrição: {peca.Descricao}");
                }
            }
        }

        public void AtualizarPeca(Peca peca)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(peca), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/peca/{peca.PecaId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR peças. Descrição: {peca.Descricao}");
                }
            }
        }

        public void InativarPeca(int pecaId)
        {
            using (var client = new HttpClient())
            {
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/peca/inativar/{pecaId}", null).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao INATIVAR peças. Identificador: {pecaId}");
                }
            }
        }
    }
}