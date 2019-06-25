using Modelo;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class DALVeiculoCliente
    {
        private DALConexao conexao;

        public DALVeiculoCliente(DALConexao cx)
        {

            this.conexao = cx;

        }

        public void Incluir(ModeloVeiculoCliente modelo)
        {

            try
            {

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO ClienteVeiculo (ClienteId, VeiculoId, AnoVeiculo, PlacaVeiculo, CorVeiculo, KmRodados) VALUES (@clienteid, @veiculoid, @anoveiculo, @placaveiculo, @corveiculo, @kmrodados); SELECT seq FROM sqlite_sequence WHERE name = 'ClienteVeiculo';";
                cmd.Parameters.AddWithValue("@clienteid", modelo.CClienteId);
                cmd.Parameters.AddWithValue("@veiculoid", modelo.CVeiculoId);
                cmd.Parameters.AddWithValue("@anoveiculo", modelo.CAnoVeiculo);
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
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE ClienteVeiculo SET ClienteId = @clienteid, VeiculoId =  @veiculoid, AnoVeiculo = @anoveiculo, PlacaVeiculo = @placaveiculo, CorVeiculo = @corveiculo, KmRodados = @kmrodados WHERE ClienteVeiculoId = @clienteveiculoid;";
                cmd.Parameters.AddWithValue("@clienteveiculoid", modelo.CClienteVeiculoId);
                cmd.Parameters.AddWithValue("@clienteid", modelo.CClienteId);
                cmd.Parameters.AddWithValue("@veiculoid", modelo.CVeiculoId);
                cmd.Parameters.AddWithValue("@anoveiculo", modelo.CAnoVeiculo);
                cmd.Parameters.AddWithValue("@placaveiculo", modelo.CPlacaVeiculo);
                cmd.Parameters.AddWithValue("@corveiculo", modelo.CCorVeiculo);
                cmd.Parameters.AddWithValue("@kmrodados", modelo.CKmRodados);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); // sempre assim, porque NÃO retorna registro
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

        public void Excluir(int ClienteVeiculoId)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM ClienteVeiculo WHERE ClienteVeiculoId = @ClienteVeiculoId;";
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

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("" +
                "SELECT " +
                "ClienteVeiculo.ClienteVeiculoId, " +
                "Cliente.Cliente, " +
                "Veiculo.Modelo, " +
                "ClienteVeiculo.AnoVeiculo, " +
                "ClienteVeiculo.PlacaVeiculo, " +
                "ClienteVeiculo.CorVeiculo, " +
                "ClienteVeiculo.KmRodados " +
                "FROM ClienteVeiculo " +
                "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
                "INNER JOIN Cliente ON Cliente.ClienteId = ClienteVeiculo.ClienteId " +
                "WHERE " +
                "ClienteVeiculo.PlacaVeiculo LIKE '%" + Convert.ToString(valor) + "%' " +
                "OR Cliente.Cliente LIKE '%" + Convert.ToString(valor) + "%'" +
                "OR Veiculo.Modelo = '" + Convert.ToString(valor) + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloVeiculoCliente CarregaModeloVeiculo(int ClienteVeiculoId)
        {
            ModeloVeiculoCliente modelo = new ModeloVeiculoCliente();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM ClienteVeiculo WHERE ClienteVeiculoId = @ClienteVeiculoId";
            cmd.Parameters.AddWithValue("@ClienteVeiculoId", ClienteVeiculoId);
            conexao.Conectar();
            SQLiteDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CClienteVeiculoId = Convert.ToInt32(registro["ClienteVeiculoId"]);
                modelo.CClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.CVeiculoId = Convert.ToInt32(registro["VeiculoId"]);
                modelo.CAnoVeiculo = Convert.ToInt32(registro["AnoVeiculo"]);
                modelo.CPlacaVeiculo = Convert.ToString(registro["PlacaVeiculo"]);
                modelo.CCorVeiculo = Convert.ToString(registro["CorVeiculo"]);
                modelo.CKmRodados = Convert.ToInt32(registro["KmRodados"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
