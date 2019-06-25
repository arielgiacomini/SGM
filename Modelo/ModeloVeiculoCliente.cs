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
            this.AnoVeiculo = 0;
            this.PlacaVeiculo = "";
            this.CorVeiculo = "";
            this.KmRodados = 0;
        }

        public ModeloVeiculoCliente(int clienteveiculoid, int clienteid, int veiculoid, int anoveiculo, String placaveiculo, String corveiculo, float kmrodados)
        {
            this.ClienteVeiculoId = clienteveiculoid;
            this.ClienteId = clienteid;
            this.VeiculoId = veiculoid;
            this.AnoVeiculo = anoveiculo;
            this.PlacaVeiculo = placaveiculo;
            this.CorVeiculo = corveiculo;
            this.KmRodados = kmrodados;
        }

        private int ClienteVeiculoId;
        private int ClienteId;
        private int VeiculoId;
        private int AnoVeiculo;
        private String PlacaVeiculo;
        private String CorVeiculo;
        private float KmRodados;


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

        public int CAnoVeiculo
        {
            get { return this.AnoVeiculo; }
            set { this.AnoVeiculo = value; }
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
    }
}
