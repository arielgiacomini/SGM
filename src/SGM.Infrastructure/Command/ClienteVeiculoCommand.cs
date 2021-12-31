using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.Infrastructure.Command
{
    public class ClienteVeiculoCommand : IClienteVeiculoCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ClienteVeiculoCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(clienteVeiculo), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente-veiculo", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR clienteVeiculo. ClienteId: {clienteVeiculo.ClienteId}");
                }

                var response = result.Content.ReadAsStringAsync();

                return Convert.ToInt32(response.Result);
            }
        }

        public void AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(clienteVeiculo), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente-veiculo/{clienteVeiculo.ClienteVeiculoId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR clienteVeiculo. ClienteId: {clienteVeiculo.ClienteId}");
                }
            }
        }

        public void InativarClienteVeiculo(int clienteVeiculoId)
        {
            using (var client = new HttpClient())
            {
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente-veiculo/inativar/{clienteVeiculoId}", null).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao INATIVAR clienteVeiculo. ClienteVeiculoId: {clienteVeiculoId}");
                }
            }
        }
    }
}