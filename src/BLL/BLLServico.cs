using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLServico
    {
        private DALConexao conexao;

        public BLLServico(DALConexao cx)
        {
            this.conexao = cx;
        }


        public DataTable LocalizarServicoMaodeObra(int ServicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarServicoMaodeObra(ServicoId);
        }

        public DataTable LocalizarServicoPeca(int ServicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarServicoPeca(ServicoId);
        }

        public DataTable BuscarHistoricoServicoClienteByClienteId(int clienteId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.BuscarHistoricoServicoClienteByClienteId(clienteId);
        }

        public DataTable BuscaHistoricoServicoClientePorPlacaVeiculo(string valor)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.BuscaHistoricoServicoClientePorPlacaVeiculo(valor);
        }

        public ModeloServico BuscarDetalheServicoGerado(int servicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.BuscarDetalheServicoGerado(servicoId);
        }
    }
}
