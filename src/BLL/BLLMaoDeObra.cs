using DAL;
using System;
using System.Data;

namespace BLL
{
    public class BLLMaoDeObra
    {
        private DALConexao conexao;

        public BLLMaoDeObra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(String valor)
        {
            DALMaoDeObra DALobj = new DALMaoDeObra(conexao);
            return DALobj.Localizar(valor);
        }
    }
}
