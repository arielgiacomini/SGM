using DAL;
using System;
using System.Data;

namespace BLL
{
    public class BLLVeiculoCliente
    {
        private readonly DALConexao conexao;

        public BLLVeiculoCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(String valor)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarTodosVeiculosCliente(int clienteId)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.LocalizarTodosVeiculosCliente(clienteId);
        }
    }
}