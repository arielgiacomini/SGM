using System;

namespace Modelo.Entities
{
    public class ClienteVeiculo
    {
        public int ClienteVeiculoId { get; set; }
        public int ClienteId { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public int KmRodados { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
