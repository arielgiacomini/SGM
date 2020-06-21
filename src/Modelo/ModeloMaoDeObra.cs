using System;

namespace Modelo
{
    public class ModeloMaoDeObra
    {
        public ModeloMaoDeObra()
        {
            this.MaodeObraId = 0;
            this.MaodeObra = "";
            this.Tipo = "";
            this.Valor = 0;
            this.VigenciaInicial = DateTime.Today;
            this.VigenciaFinal = DateTime.Today;
            this.Ativo = true;
        }

        public ModeloMaoDeObra(int MaodeObraId, String MaodeObra, String Tipo, Decimal Valor, DateTime VigenciaInicial, DateTime VigenciaFinal, Boolean Ativo)
        {
            this.MaodeObraId = MaodeObraId;
            this.MaodeObra = MaodeObra;
            this.Tipo = Tipo;
            this.Valor = Valor;
            this.VigenciaInicial = VigenciaInicial;
            this.VigenciaFinal = VigenciaFinal;
            this.Ativo = Ativo;
        }

        private int MaodeObraId;
        private String MaodeObra;
        private String Tipo;
        private Decimal Valor;
        private DateTime VigenciaInicial;
        private DateTime VigenciaFinal;
        private Boolean Ativo;

        public int CMaodeObraId
        {
            get { return this.MaodeObraId; }
            set { this.MaodeObraId = value; }
        }

        public String CDescricao
        {
            get { return this.MaodeObra; }
            set { this.MaodeObra = value; }
        }

        public String CTipo
        {
            get { return this.Tipo; }
            set { this.Tipo = value; }
        }

        public Decimal CValor
        {
            get { return this.Valor; }
            set { this.Valor = value; }
        }

        public DateTime CVigenciaInicial
        {
            get { return this.VigenciaInicial; }
            set { this.VigenciaInicial = value; }
        }

        public DateTime CVigenciaFinal
        {
            get { return this.VigenciaFinal; }
            set { this.VigenciaFinal = value; }
        }

        public Boolean CAtivo
        {
            get { return this.Ativo; }
            set { this.Ativo = value; }
        }
    }
}
