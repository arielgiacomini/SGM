using System;

namespace Modelo
{
    public class ModeloVeiculoCliente
    {

        public ModeloVeiculoCliente()
        {
            this.ClienteVeiculoId = 0;
            this.ClienteId = 0;
            this.VeiculoId = 0;
            this.PlacaVeiculo = "";
            this.CorVeiculo = "";
            this.KmRodados = 0;
            this.DataCadastro = DateTime.UtcNow;
        }

        public ModeloVeiculoCliente(int clienteveiculoid, int clienteid, int veiculoid, string placaveiculo, string corveiculo, float kmrodados, DateTime dataCadastro)
        {
            this.ClienteVeiculoId = clienteveiculoid;
            this.ClienteId = clienteid;
            this.VeiculoId = veiculoid;
            this.PlacaVeiculo = placaveiculo;
            this.CorVeiculo = corveiculo;
            this.KmRodados = kmrodados;
            this.DataCadastro = dataCadastro;
        }

        private int ClienteVeiculoId;
        private int ClienteId;
        private int VeiculoId;
        private string PlacaVeiculo;
        private string CorVeiculo;
        private float KmRodados;
        private DateTime DataCadastro;


        public int CClienteVeiculoId
        {
            get { return this.ClienteVeiculoId; }
            set { this.ClienteVeiculoId = value; }
        }

        public int CClienteId
        {
            get { return this.ClienteId; }
            set { this.ClienteId = value; }
        }

        public int CVeiculoId
        {
            get { return this.VeiculoId; }
            set { this.VeiculoId = value; }
        }

        public String CPlacaVeiculo
        {
            get { return this.PlacaVeiculo; }
            set { this.PlacaVeiculo = value; }
        }

        public String CCorVeiculo
        {
            get { return this.CorVeiculo; }
            set { this.CorVeiculo = value; }
        }

        public float CKmRodados
        {
            get { return this.KmRodados; }
            set { this.KmRodados = value; }
        }
        public DateTime CDataCadastro
        {
            get { return this.DataCadastro; }
            set { this.DataCadastro = value; }
        }
    }
}
