using DAL;
using System;
using System.Data;

namespace BLL
{
    public class BLLPeca
    {
        private DALConexao conexao;

        public BLLPeca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(String valor)
        {
            DALPeca DALobj = new DALPeca(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
