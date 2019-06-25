using System;

namespace Modelo
{
    public class ModeloPeca
    {
        public ModeloPeca()
        {
            this.PecaId = 0;
            this.Peca = "";
            this.Fornecedor = "";
            this.Valor = 0;
            this.ValorFrete = 0;
        }

        public ModeloPeca(int PecaId, String Peca, String Fornecedor, Decimal Valor, Decimal ValorFrete)
        {
            this.PecaId = PecaId;
            this.Peca = Peca;
            this.Fornecedor = Fornecedor;
            this.Valor = Valor;
            this.ValorFrete = ValorFrete;
        }

        private int PecaId;
        private String Peca;
        private String Fornecedor;
        private decimal Valor;
        private decimal ValorFrete;

        public int CPecaId
        {
            get { return this.PecaId; }
            set { this.PecaId = value; }
        }

        public String CPeca
        {
            get { return this.Peca; }
            set { this.Peca = value; }
        }

        public String CFornecedor
        {
            get { return this.Fornecedor; }
            set { this.Fornecedor = value; }
        }

        public decimal CValor
        {
            get { return this.Valor; }
            set { this.Valor = value; }
        }

        public decimal CValorFrete
        {
            get { return this.ValorFrete; }
            set { this.ValorFrete = value; }
        }
    }
}
