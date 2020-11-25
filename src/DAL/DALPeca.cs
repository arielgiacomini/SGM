using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALPeca
    {
        private readonly DALConexao conexao;

        public DALPeca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Peca WHERE Peca.Descricao LIKE '%" + valor + "%' OR Fornecedor LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }
    }
}