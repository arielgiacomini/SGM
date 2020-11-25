using Modelo.Entities;
using System;
using System.Collections.Generic;
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

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Veiculo WHERE Modelo LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public List<Veiculo> BuscarVeiculoByMarcaId(int marcaId)
        {
            List<Veiculo> veiculoMarca = new List<Veiculo>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Veiculo WHERE MarcaId = @marcaId"
            };

            cmd.Parameters.AddWithValue("@marcaId", marcaId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    veiculoMarca.Add(new Veiculo()
                    {
                        VeiculoId = Convert.ToInt32(registro["VeiculoId"]),
                        CodigoFipe = Convert.ToInt32(registro["CodigoFipe"]),
                        MarcaId = Convert.ToInt32(registro["MarcaId"]),
                        Modelo = Convert.ToString(registro["Modelo"]),
                        VeiculoAtivo = Convert.ToBoolean(registro["VeiculoAtivo"]),
                        DataCadastro = Convert.ToDateTime(registro["DataCadastro"])
                    });
                }
            }
            conexao.Desconectar();
            return veiculoMarca;
        }
    }
}