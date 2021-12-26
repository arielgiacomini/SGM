﻿using Newtonsoft.Json;
using SGM.Domain.Intern.Interfaces.Command.External;
using SGM.Domain.Entities.External;
using SGM.Domain.Intern.Interfaces.Configuration;
using System;
using System.Net.Http;

namespace SGM.Infrastructure.Command.External
{
    public class WhatsAppCommand : IWhatsAppCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public WhatsAppCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }

        public WhatsAppMessage EnviarMensagemWhatsApp(WhatsAppMessage whatsAppMessage)
        {
            using (var client = new HttpClient())
            {
                var result = client.GetAsync($"{_sGMConfiguration.WhatsAppApiUrl}send?phone=5511982505422&text=oi").Result;

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<WhatsAppMessage>(result.Content.ReadAsStringAsync().Result);
                }
                else if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return new WhatsAppMessage();
                }
                else
                {
                    throw new ApplicationException($"Problema ao consumir a API, resultado: {result.Content.ReadAsStringAsync().Result}");
                }
            }
        }
    }
}