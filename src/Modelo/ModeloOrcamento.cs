using System;

namespace Modelo
{
    public class ModeloOrcamento
    {
        public ModeloOrcamento()
        {
            /*
                Tabela Orcamento
            */
            this.OrcamentoId = 0;
            this.ClienteId = 0;
            this.Descricao = "";
            this.ValorAdicional = 0;
            this.PercentualDesconto = 0;
            this.ValorDesconto = 0;
            this.ValorTotal = 0;
            this.Status = "";
            this.Ativo = true;
            this.DataCadastro = DateTime.Today;

            this.MaodeObraId = 0;
            this.PecaId = 0;

        }

        public ModeloOrcamento(int OrcamentoId, int ClienteId, String Descricao, decimal ValorAdicional, decimal PercentualDesconto, decimal ValorDesconto, decimal ValorTotal, String Status, bool Ativo, DateTime DataCadastro, int MaodeObraId, int PecaId)
        {
            this.OrcamentoId = OrcamentoId;
            this.ClienteId = ClienteId;
            this.Descricao = Descricao;
            this.ValorAdicional = ValorAdicional;
            this.PercentualDesconto = PercentualDesconto;
            this.ValorDesconto = ValorDesconto;
            this.ValorTotal = ValorTotal;
            this.Status = Status;
            this.Ativo = Ativo;
            this.DataCadastro = DataCadastro;

            this.MaodeObraId = MaodeObraId;
            this.PecaId = PecaId;
        }

        private int OrcamentoId;
        private int ClienteId;
        private String Descricao;
        private decimal ValorAdicional;
        private decimal PercentualDesconto;
        private decimal ValorDesconto;
        private decimal ValorTotal;
        private String Status;
        private bool Ativo;
        private DateTime DataCadastro;

        private int MaodeObraId;
        private int PecaId;


        public int COrcamentoId
        {
            get { return this.OrcamentoId; }
            set { this.OrcamentoId = value; }
        }

        public int CClienteId
        {
            get { return this.ClienteId; }
            set { this.ClienteId = value; }
        }

        public String CDescricao
        {
            get { return this.Descricao; }
            set { this.Descricao = value; }
        }

        public Decimal CValorAdicional
        {
            get { return this.ValorAdicional; }
            set { this.ValorAdicional = value; }
        }

        public Decimal CPercentualDesconto
        {
            get { return this.PercentualDesconto; }
            set { this.PercentualDesconto = value; }
        }

        public Decimal CValorDesconto
        {
            get { return this.ValorDesconto; }
            set { this.ValorDesconto = value; }
        }

        public Decimal CValorTotal
        {
            get { return this.ValorTotal; }
            set { this.ValorTotal = value; }
        }

        public String CStatus
        {
            get { return this.Status; }
            set { this.Status = value; }
        }

        public Boolean CAtivo
        {
            get { return this.Ativo; }
            set { this.Ativo = value; }
        }

        public DateTime CDataCadastro
        {
            get { return this.DataCadastro; }
            set { this.DataCadastro = value; }
        }


        /*
            Tabelas Separadas         
             
        */
        public int CMaodeObraId
        {
            get { return this.MaodeObraId; }
            set { this.MaodeObraId = value; }
        }

        public int CPecaId
        {
            get { return this.PecaId; }
            set { this.PecaId = value; }
        }
    }
}
