using Modelo;
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

        public void Incluir(ModeloPeca modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO Peca " +
                "(" +
                "Descricao," +
                "Fornecedor," +
                "Valor," +
                "ValorFrete " +
                ") VALUES (" +
                "@Descricao," +
                "@Fornecedor," +
                "@Valor," +
                "@ValorFrete " +
                "); SELECT @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
            cmd.Parameters.AddWithValue("@Fornecedor", modelo.CFornecedor);
            cmd.Parameters.AddWithValue("@Valor", modelo.CValor);
            cmd.Parameters.AddWithValue("@ValorFrete", modelo.CValorFrete);
            conexao.Conectar();
            modelo.CPecaId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloPeca modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE Peca SET " +
                "Descricao = @Descricao," +
                "Fornecedor = @Fornecedor," +
                "Valor = @Valor," +
                "ValorFrete = @ValorFrete " +
                "WHERE PecaId = @PecaId;"
            };

            cmd.Parameters.AddWithValue("@PecaId", modelo.CPecaId);
            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
            cmd.Parameters.AddWithValue("@Fornecedor", modelo.CFornecedor);
            cmd.Parameters.AddWithValue("@Valor", modelo.CValor);
            cmd.Parameters.AddWithValue("@ValorFrete", modelo.CValorFrete);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int pecaid)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM Peca WHERE PecaId = @PecaId;"
            };

            cmd.Parameters.AddWithValue("@PecaId", pecaid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Peca WHERE Peca.Descricao LIKE '%" + valor + "%' OR Fornecedor LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloPeca CarregaModeloPeca(int pecaid)
        {
            ModeloPeca modelo = new ModeloPeca();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Peca WHERE PecaId = @PecaId"
            };

            cmd.Parameters.AddWithValue("@PecaId", pecaid);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CPecaId = Convert.ToInt32(registro["PecaId"]);
                modelo.CDescricao = Convert.ToString(registro["Descricao"]);
                modelo.CFornecedor = Convert.ToString(registro["Fornecedor"]);
                modelo.CValor = Convert.ToDecimal(registro["Valor"]);
                modelo.CValorFrete = Convert.ToDecimal(registro["ValorFrete"]);
            }
            conexao.Desconectar();
            return modelo;

        }
    }
}