using SGM.ApplicationServices.Infrastructure;
using System.Configuration;

namespace SGM.WindowsForms.Configuration
{
    public class SGMConfiguration : ISGMConfiguration
    {
        public string SGMWebApiUrl => ConfigurationManager.AppSettings["sgm.web.api.url"];
        public string QuantidadeUltimosOrcamentos => ConfigurationManager.AppSettings["quantidade-ultimos-orcamentos-gerados"];
        public string QuantidadeUltimosServicos => ConfigurationManager.AppSettings["quantidade-ultimos-servicos-gerados"];
        public string ViaCepApiUrl => ConfigurationManager.AppSettings["via.cep.api.url"];
    }
}