using Modelo;
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

        public void Incluir(ModeloVeiculoCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conexao.ObjetoConexao,
                    CommandText = "INSERT INTO ClienteVeiculo (ClienteId, VeiculoId, PlacaVeiculo, CorVeiculo, KmRodados) VALUES (@clienteid, @veiculoid, @placaveiculo, @corveiculo, @kmrodados);"
                };
                cmd.Parameters.AddWithValue("@clienteid", modelo.CClienteId);
                cmd.Parameters.AddWithValue("@veiculoid", modelo.CVeiculoId);
                cmd.Parameters.AddWithValue("@placaveiculo", modelo.CPlacaVeiculo);
                cmd.Parameters.AddWithValue("@corveiculo", modelo.CCorVeiculo);
                cmd.Parameters.AddWithValue("@kmrodados", modelo.CKmRodados);
                conexao.Conectar();
                modelo.CVeiculoId = Convert.ToInt32(cmd.ExecuteScalar()); // sempre assim, porque retorna registro
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

        public void Alterar(ModeloVeiculoCliente modelo)
        {
            try
            {
                using (SqlConnection c = new SqlConnection(conexao.StringConexao))
                {
                    c.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE ClienteVeiculo SET ClienteId = @clienteid, VeiculoId = @veiculoid, PlacaVeiculo = @placaveiculo, CorVeiculo = @corveiculo, KmRodados = @kmrodados WHERE ClienteVeiculoId = @clienteveiculoid;", c))
                    {
                        cmd.Parameters.AddWithValue("@clienteveiculoid", modelo.CClienteVeiculoId);
                        cmd.Parameters.AddWithValue("@clienteid", modelo.CClienteId);
                        cmd.Parameters.AddWithValue("@veiculoid", modelo.CVeiculoId);
                        cmd.Parameters.AddWithValue("@placaveiculo", modelo.CPlacaVeiculo);
                        cmd.Parameters.AddWithValue("@corveiculo", modelo.CCorVeiculo);
                        cmd.Parameters.AddWithValue("@kmrodados", modelo.CKmRodados);
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

        public ModeloVeiculoCliente CarregaModeloVeiculo(int ClienteVeiculoId)
        {
            ModeloVeiculoCliente modelo = new ModeloVeiculoCliente();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT ClienteVeiculoId, ClienteId, VeiculoId, PlacaVeiculo, CorVeiculo, KmRodados FROM ClienteVeiculo WHERE ClienteVeiculoId = @ClienteVeiculoId"
            };
            cmd.Parameters.AddWithValue("@ClienteVeiculoId", ClienteVeiculoId);
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

        public ModeloVeiculoCliente CarregaModeloVeiculoClienteByPlaca(string placaVeiculo)
        {
            ModeloVeiculoCliente modelo = new ModeloVeiculoCliente();
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
