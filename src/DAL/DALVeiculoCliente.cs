using Modelo;
using Modelo.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALVeiculoCliente
    {
        private readonly DALConexao conexao;

        public DALVeiculoCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public int Incluir(ClienteVeiculo modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "INSERT INTO ClienteVeiculo (ClienteId, VeiculoId, PlacaVeiculo, CorVeiculo, KmRodados, AnoVeiculo) VALUES (@clienteid, @veiculoid, @placaveiculo, @corveiculo, @kmrodados, @anoVeiculo); " + "SELECT CAST(SCOPE_IDENTITY() AS INT); "
            };
                cmd.Parameters.AddWithValue("@clienteid", modelo.ClienteId);
                cmd.Parameters.AddWithValue("@veiculoid", modelo.VeiculoId);
                cmd.Parameters.AddWithValue("@placaveiculo", modelo.PlacaVeiculo);
                cmd.Parameters.AddWithValue("@corveiculo", modelo.CorVeiculo);
                cmd.Parameters.AddWithValue("@kmrodados", modelo.KmRodados);
                cmd.Parameters.AddWithValue("@anoVeiculo", modelo.AnoVeiculo);
                conexao.Conectar();
                int veiculoId = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Desconectar();
                return veiculoId;
            }
            catch (Exception erro)
            {
                conexao.Desconectar();
                throw new Exception(erro.Message);
            }
        }

        public void Alterar(ClienteVeiculo modelo)
        {
            try
            {
                using (SqlConnection c = new SqlConnection(conexao.StringConexao))
                {
                    c.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE ClienteVeiculo SET ClienteId = @clienteid, VeiculoId = @veiculoid, PlacaVeiculo = @placaveiculo, CorVeiculo = @corveiculo, KmRodados = @kmrodados, AnoVeiculo = @anoVeiculo WHERE ClienteVeiculoId = @clienteveiculoid;", c))
                    {
                        cmd.Parameters.AddWithValue("@clienteveiculoid", modelo.ClienteVeiculoId);
                        cmd.Parameters.AddWithValue("@clienteid", modelo.ClienteId);
                        cmd.Parameters.AddWithValue("@veiculoid", modelo.VeiculoId);
                        cmd.Parameters.AddWithValue("@placaveiculo", modelo.PlacaVeiculo);
                        cmd.Parameters.AddWithValue("@corveiculo", modelo.CorVeiculo);
                        cmd.Parameters.AddWithValue("@kmrodados", modelo.KmRodados);
                        cmd.Parameters.AddWithValue("@anoVeiculo", modelo.AnoVeiculo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Excluir(int ClienteVeiculoId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "DELETE FROM ClienteVeiculo WHERE ClienteVeiculoId = @ClienteVeiculoId;"
                };

                cmd.Parameters.AddWithValue("@ClienteVeiculoId", ClienteVeiculoId);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "ClienteVeiculo.ClienteVeiculoId, " +
                "Cliente.NomeCliente, " +
                "Veiculo.Modelo, " +
                "ClienteVeiculo.PlacaVeiculo, " +
                "ClienteVeiculo.CorVeiculo, " +
                "ClienteVeiculo.KmRodados, " +
                "Cliente.ClienteId " +
                "FROM ClienteVeiculo " +
                "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
                "INNER JOIN Cliente ON Cliente.ClienteId = ClienteVeiculo.ClienteId " +
                "WHERE " +
                "ClienteVeiculo.PlacaVeiculo LIKE '%" + Convert.ToString(valor) + "%' " +
                "OR Cliente.NomeCliente LIKE '%" + Convert.ToString(valor) + "%'" +
                "OR Veiculo.Modelo = '" + Convert.ToString(valor) + "'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ClienteVeiculo CarregaModeloVeiculo(int ClienteVeiculoId)
        {
            ClienteVeiculo modelo = new ClienteVeiculo();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT ClienteVeiculoId, ClienteId, VeiculoId, PlacaVeiculo, CorVeiculo, KmRodados, AnoVeiculo FROM ClienteVeiculo WHERE ClienteVeiculoId = @ClienteVeiculoId"
            };

            cmd.Parameters.AddWithValue("@ClienteVeiculoId", ClienteVeiculoId);
            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ClienteVeiculoId = Convert.ToInt32(registro["ClienteVeiculoId"]);
                modelo.ClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.VeiculoId = Convert.ToInt32(registro["VeiculoId"]);
                modelo.PlacaVeiculo = Convert.ToString(registro["PlacaVeiculo"]);
                modelo.CorVeiculo = Convert.ToString(registro["CorVeiculo"]);
                modelo.KmRodados = Convert.ToInt32(registro["KmRodados"]);
                modelo.AnoVeiculo = Convert.ToInt32(registro["AnoVeiculo"]);
            }

            conexao.Desconectar();
            return modelo;
        }

        public ClienteVeiculo CarregaModeloVeiculoClienteByPlaca(string placaVeiculo)
        {
            ClienteVeiculo modelo = new ClienteVeiculo();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM ClienteVeiculo WHERE PlacaVeiculo = @PlacaVeiculo"
            };

            cmd.Parameters.AddWithValue("@PlacaVeiculo", placaVeiculo);
            conexao.Conectar();

            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ClienteVeiculoId = Convert.ToInt32(registro["ClienteVeiculoId"]);
                modelo.ClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.VeiculoId = Convert.ToInt32(registro["VeiculoId"]);
                modelo.PlacaVeiculo = Convert.ToString(registro["PlacaVeiculo"]);
                modelo.CorVeiculo = Convert.ToString(registro["CorVeiculo"]);
                modelo.KmRodados = Convert.ToInt32(registro["KmRodados"]);
                modelo.AnoVeiculo = Convert.ToInt32(registro["AnoVeiculo"]);
            }

            conexao.Desconectar();
            return modelo;
        }

        public ModeloVeiculoCliente BuscarVeiculosCliente(int clienteId)
        {
            ModeloVeiculoCliente modelo = new ModeloVeiculoCliente();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM ClienteVeiculo WHERE ClienteId = @ClienteId"
            };
            cmd.Parameters.AddWithValue("@ClienteId", clienteId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CClienteVeiculoId = Convert.ToInt32(registro["ClienteVeiculoId"]);
                modelo.CClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.CVeiculoId = Convert.ToInt32(registro["VeiculoId"]);
                modelo.CPlacaVeiculo = Convert.ToString(registro["PlacaVeiculo"]);
                modelo.CCorVeiculo = Convert.ToString(registro["CorVeiculo"]);
                modelo.CKmRodados = Convert.ToInt32(registro["KmRodados"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public DataTable LocalizarTodosVeiculosCliente(int clienteId)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "ClienteVeiculo.ClienteVeiculoId, " +
                "Cliente.NomeCliente, " +
                "Veiculo.Modelo, " +
                "ClienteVeiculo.PlacaVeiculo, " +
                "ClienteVeiculo.CorVeiculo, " +
                "ClienteVeiculo.KmRodados, " +
                "Cliente.ClienteId " +
                "FROM ClienteVeiculo " +
                "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
                "INNER JOIN Cliente ON Cliente.ClienteId = ClienteVeiculo.ClienteId " +
                "WHERE " +
                "ClienteVeiculo.ClienteId = " + Convert.ToString(clienteId), conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }
    }
}
