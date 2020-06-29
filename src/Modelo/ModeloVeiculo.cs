using System;

namespace Modelo
{
    public class ModeloVeiculo
    {
        public ModeloVeiculo()
        {
            this.VeiculoId = 0;
            this.Marca = "";
            this.Modelo = "";
        }

        public ModeloVeiculo(int veiculoid, string marca, string modelo)
        {
            this.VeiculoId = veiculoid;
            this.Marca = marca;
            this.Modelo = modelo;
        }

        private int VeiculoId;
        private String Marca;
        private String Modelo;

        public int CVeiculoId
        {
            get { return this.VeiculoId; }
            set { this.VeiculoId = value; }
        }

        public String CMarca
        {
            get { return this.Marca; }
            set { this.Marca = value; }
        }

        public String CModelo
        {
            get { return this.Modelo; }
            set { this.Modelo = value; }
        }

    }
}
