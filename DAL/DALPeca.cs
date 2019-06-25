using Modelo;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class DALPeca
    {
        private DALConexao conexao;

        public DALPeca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPeca modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO Pecas " +
                "(" +
                "Peca," +
                "Fornecedor," +
                "Valor," +
                "ValorFrete " +
                ") VALUES (" +
                "@Peca," +
                "@Fornecedor," +
                "@Valor," +
                "@ValorFrete " +
                "); " +
                "SELECT seq FROM sqlite_sequence WHERE name = 'Pecas';";
            cmd.Parameters.AddWithValue("@Peca", modelo.CPeca);
            cmd.Parameters.AddWithValue("@Fornecedor", modelo.CFornecedor);
            cmd.Parameters.AddWithValue("@Valor", modelo.CValor);
            cmd.Parameters.AddWithValue("@ValorFrete", modelo.CValorFrete);
            conexao.Conectar();
            modelo.CPecaId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloPeca modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Pecas SET " +
                "Peca = @Peca," +
                "Fornecedor = @Fornecedor," +
                "Valor = @Valor," +
                "ValorFrete = @ValorFrete " +
                "WHERE PecaId = @PecaId;";
            cmd.Parameters.AddWithValue("@PecaId", modelo.CPecaId);
            cmd.Parameters.AddWithValue("@Peca", modelo.CPeca);
            cmd.Parameters.AddWithValue("@Fornecedor", modelo.CFornecedor);
            cmd.Parameters.AddWithValue("@Valor", modelo.CValor);
            cmd.Parameters.AddWithValue("@ValorFrete", modelo.CValorFrete);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int pecaid)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM Pecas WHERE PecaId = @PecaId;";
            cmd.Parameters.AddWithValue("@PecaId", pecaid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Pecas WHERE Peca LIKE '%" + valor + "%' OR Fornecedor LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloPeca CarregaModeloPeca(int pecaid)
        {
            ModeloPeca modelo = new ModeloPeca();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM Pecas WHERE PecaId = @PecaId";
            cmd.Parameters.AddWithValue("@PecaId", pecaid);
            conexao.Conectar();
            SQLiteDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CPecaId = Convert.ToInt32(registro["PecaId"]);
                modelo.CPeca = Convert.ToString(registro["Peca"]);
                modelo.CFornecedor = Convert.ToString(registro["Fornecedor"]);
                modelo.CValor = Convert.ToDecimal(registro["Valor"]);
                modelo.CValorFrete = Convert.ToDecimal(registro["ValorFrete"]);
            }
            conexao.Desconectar();
            return modelo;

        }
    }
}
