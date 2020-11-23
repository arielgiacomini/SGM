using Newtonsoft.Json;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Infrastructure;
using SGM.Domain.Entities;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.ApplicationServices.Command
{
    public class VeiculoCommand : IVeiculoCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public VeiculoCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public void SalvarVeiculo(Veiculo veiculo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(veiculo), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR veiculo. Modelo: {veiculo.Modelo}");
                }
            }
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(veiculo), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo/{veiculo.VeiculoId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR veiculo. Modelo: {veiculo.Modelo}");
                }
            }
        }

        public void InativarVeiculo(int veiculoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/veiculo/inativar/{veiculoId}", null).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao INATIVAR veiculo. Identificador: {veiculoId}");
                }
            }
        }
    }
}