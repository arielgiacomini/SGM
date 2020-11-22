using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCliente CarregaModeloCliente(int clienteid)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(clienteid);
        }

        public DataTable LocalizarClienteByClienteId(int clienteId)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarClienteById(clienteId);
        }
    }
}
