using SGM.ApplicationServices.Infrastructure;
using System.Configuration;

namespace SGM.WindowsForms.Configuration
{
    public class SGMConfiguration : ISGMConfiguration
    {
        public string SGMWebApiUrl => ConfigurationManager.AppSettings["sgm.web.api.url"];
        public string QuantidadeUltimosOrcamentos => ConfigurationManager.AppSettings["quantidade-ultimos-orcamentos-gerados"];
    }
}