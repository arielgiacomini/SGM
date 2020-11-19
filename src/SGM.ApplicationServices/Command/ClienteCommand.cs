using Newtonsoft.Json;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Infrastructure;
using SGM.Domain.Entities;
using System;
using System.Net.Http;
using System.Text;

namespace SGM.ApplicationServices.Command
{
    public class ClienteCommand : IClienteCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ClienteCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public void SalvarCliente(Cliente cliente)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json");
                var result = client.PostAsync($"{_sGMConfiguration.SGMWebApiUrl}SGM/cliente", content).Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Problema ao adicionar o atendimento. DocumentoCliente: {cliente.DocumentoCliente}");
                }
            }
        }
    }
}