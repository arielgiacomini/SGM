using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALVeiculo
    {
        private readonly DALConexao conexao;

        public DALVeiculo(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVeiculo modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO Veiculo (Marca, Modelo) VALUES (@marca, @modelo);"
            };

            cmd.Parameters.AddWithValue("@marca", modelo.CMarca);
            cmd.Parameters.AddWithValue("@modelo", modelo.CModelo);
            conexao.Conectar();
            modelo.CVeiculoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloVeiculo modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE Veiculo SET Marca = @marca, Modelo =  @modelo WHERE VeiculoId = @veiculoid;"
            };

            cmd.Parameters.AddWithValue("@marca", modelo.CMarca);
            cmd.Parameters.AddWithValue("@modelo", modelo.CModelo);
            cmd.Parameters.AddWithValue("@veiculoid", modelo.CVeiculoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int veiculoid)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM Veiculo WHERE VeiculoId = @veiculoid;"
            };

            cmd.Parameters.AddWithValue("@veiculoid", veiculoid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Veiculo WHERE Modelo LIKE '%" + valor + "%' OR Marca LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloVeiculo CarregaModeloVeiculo(int veiculoid)
        {
            ModeloVeiculo modelo = new ModeloVeiculo();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Veiculo WHERE VeiculoId = @veiculoid"
            };

            cmd.Parameters.AddWithValue("@veiculoid", veiculoid);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

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
