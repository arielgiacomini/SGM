using DAL;
using Modelo.Entities;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BLLVeiculo
    {
        private readonly DALConexao conexao;

        public BLLVeiculo(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(string valor)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.Localizar(valor);
        }

        public List<Veiculo> BuscarVeiculoByMarcaId(int marcaId)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.BuscarVeiculoByMarcaId(marcaId);
        }
    }
}