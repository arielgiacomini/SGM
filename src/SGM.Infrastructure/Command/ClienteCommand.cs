using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Entities;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.Infrastructure.Command
{
    public class ClienteCommand : IClienteCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ClienteCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public int SalvarCliente(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao SALVAR cliente. DocumentoCliente: {cliente.DocumentoCliente}");
                }

                int.TryParse(result.Content.ReadAsStringAsync().Result, out int clienteId);

                return clienteId;
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente/{cliente.ClienteId}", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao ATUALIZAR cliente. DocumentoCliente: {cliente.DocumentoCliente}");
                }
            }
        }

        public void InativarCliente(int clienteId)
        {
            using (var client = new HttpClient())
            {
                var result = client.PutAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente/inativar/{clienteId}", null).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao INATIVAR cliente. ClienteId: {clienteId}");
                }
            }
        }
    }
}