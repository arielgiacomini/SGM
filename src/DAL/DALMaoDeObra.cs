using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALMaoDeObra
    {
        private readonly DALConexao conexao;

        public DALMaoDeObra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MaodeObra WHERE MaodeObra.Descricao LIKE '%" + valor + "%' OR Tipo LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }
    }
}