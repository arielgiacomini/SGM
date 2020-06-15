using Modelo.Interfaces;
using System.Configuration;

namespace BBL.Configuration
{
    public class SGMLoquinhoConfiguration : ISGMLoquinhoConfiguration
    {
        public string SGMLoquinhoApiUrl => ConfigurationManager.AppSettings["SGMLoquinho.Api.Url"];
    }
}
