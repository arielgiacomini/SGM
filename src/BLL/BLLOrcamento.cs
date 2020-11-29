using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLOrcamento
    {
        private DALConexao conexao;

        public BLLOrcamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable LocalizarOrcamentoMaodeObra(int OrcamentoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarOrcamentoMaodeObra(OrcamentoId);
        }

        public DataTable LocalizarOrcamentoPeca(int OrcamentoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarOrcamentoPeca(OrcamentoId);
        }

        public DataTable BuscaHistoricoOrcamentoClientePorPlacaVeiculo(string placaVeiculo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.BuscaHistoricoOrcamentoClientePorPlacaVeiculo(placaVeiculo);
        }

        public DataTable BuscarHistoricoOrcamentoClienteByClienteId(int clienteId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.BuscarHistoricoOrcamentoClienteByClienteId(clienteId);
        }

        public ModeloOrcamento BuscarDetalheOrcamentoGerado(int servicoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.BuscarDetalheOrcamentoGerado(servicoId);
        }
    }
}