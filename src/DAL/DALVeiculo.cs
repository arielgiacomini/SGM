using Modelo;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class DALVeiculo
    {
        private DALConexao conexao;

        public DALVeiculo(DALConexao cx)
        {

            this.conexao = cx;

        }

        public void Incluir(ModeloVeiculo modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO Veiculo (Marca, Modelo) VALUES (@marca, @modelo); SELECT seq FROM sqlite_sequence WHERE name = 'Veiculo';";
            cmd.Parameters.AddWithValue("@marca", modelo.CMarca);
            cmd.Parameters.AddWithValue("@modelo", modelo.CModelo);
            conexao.Conectar();
            modelo.CVeiculoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloVeiculo modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Veiculo SET Marca = @marca, Modelo =  @modelo WHERE VeiculoId = @veiculoid;";
            cmd.Parameters.AddWithValue("@marca", modelo.CMarca);
            cmd.Parameters.AddWithValue("@modelo", modelo.CModelo);
            cmd.Parameters.AddWithValue("@veiculoid", modelo.CVeiculoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int veiculoid)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM Veiculo WHERE VeiculoId = @veiculoid;";
            cmd.Parameters.AddWithValue("@veiculoid", veiculoid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Veiculo WHERE Modelo LIKE '%" + valor + "%' OR Marca LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloVeiculo CarregaModeloVeiculo(int veiculoid)
        {
            ModeloVeiculo modelo = new ModeloVeiculo();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM Veiculo WHERE VeiculoId = @veiculoid";
            cmd.Parameters.AddWithValue("@veiculoid", veiculoid);
            conexao.Conectar();
            SQLiteDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CVeiculoId = Convert.ToInt32(registro["VeiculoId"]);
                modelo.CMarca = Convert.ToString(registro["Marca"]);
                modelo.CModelo = Convert.ToString(registro["Modelo"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
