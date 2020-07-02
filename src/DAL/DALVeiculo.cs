using Modelo;
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

        public int Incluir(Veiculo modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO Veiculo (CodigoFipe, MarcaId, Modelo, AnoModeloInicial, AnoModeloFinal, VeiculoAtivo, DataCadastro) VALUES (@codigoFipe, @marcaId, @modelo, @anoModeloInicial, @anoModeloFinal, @veiculoAtivo, @DataCadastro);"
            };

            cmd.Parameters.AddWithValue("@codigoFipe", modelo.CodigoFipe);
            cmd.Parameters.AddWithValue("@marcaId", modelo.MarcaId);
            cmd.Parameters.AddWithValue("@modelo", modelo.Modelo);
            cmd.Parameters.AddWithValue("@anoModeloInicial", modelo.AnoModeloInicial);
            cmd.Parameters.AddWithValue("@anoModeloFinal", modelo.AnoModeloFinal);
            cmd.Parameters.AddWithValue("@veiculoAtivo", modelo.VeiculoAtivo);
            cmd.Parameters.AddWithValue("@DataCadastro", modelo.DataCadastro);

            conexao.Conectar();
            return modelo.VeiculoId = Convert.ToInt32(cmd.ExecuteScalar());
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

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Veiculo WHERE Modelo LIKE '%" + valor + "%'", conexao.StringConexao);
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

        public List<VeiculoMarca> BuscarMarcaVeiculo()
        {
            List<VeiculoMarca> veiculoMarca = new List<VeiculoMarca>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT MarcaId, Marca, PesoOrdenacao FROM VeiculoMarca ORDER BY PesoOrdenacao"
            };

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    veiculoMarca.Add(new VeiculoMarca()
                    {
                        MarcaId = Convert.ToInt32(registro["MarcaId"]),
                        Marca = Convert.ToString(registro["Marca"]),
                        PesoOrdenacao = Convert.ToInt32(registro["PesoOrdenacao"])
                    });
                }
            }
            conexao.Desconectar();
            return veiculoMarca;
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
                        AnoModeloInicial = Convert.ToInt32(registro["AnoModeloInicial"]),
                        AnoModeloFinal = Convert.ToInt32(registro["AnoModeloFinal"]),
                        VeiculoAtivo = Convert.ToBoolean(registro["VeiculoAtivo"]),
                        DataCadastro = Convert.ToDateTime(registro["DataCadastro"])
                    });
                }
            }
            conexao.Desconectar();
            return veiculoMarca;
        }

        public Veiculo BuscarVeiculoByVeiculoId(int veiculoId)
        {
            Veiculo veiculo = new Veiculo();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Veiculo WHERE VeiculoId = @veiculoId"
            };

            cmd.Parameters.AddWithValue("@veiculoId", veiculoId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    veiculo.VeiculoId = Convert.ToInt32(registro["MarcaId"]);
                    veiculo.CodigoFipe = Convert.ToInt32(registro["CodigoFipe"]);
                    veiculo.MarcaId = Convert.ToInt32(registro["MarcaId"]);
                    veiculo.Modelo = Convert.ToString(registro["Modelo"]);
                    veiculo.AnoModeloInicial = Convert.ToInt32(registro["AnoModeloInicial"]);
                    veiculo.AnoModeloFinal = Convert.ToInt32(registro["AnoModeloFinal"]);
                    veiculo.VeiculoAtivo = Convert.ToBoolean(registro["VeiculoAtivo"]);
                    veiculo.DataCadastro = Convert.ToDateTime(registro["DataCadastro"]);
                }
            }
            conexao.Desconectar();
            return veiculo;
        }

        public VeiculoMarca BuscarMarcaVeiculoByMarcaId(int marcaId)
        {
            VeiculoMarca marca = new VeiculoMarca();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT MarcaId, Marca, PesoOrdenacao FROM VeiculoMarca WHERE MarcaId = @marcaId"
            };

            cmd.Parameters.AddWithValue("@marcaId", marcaId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                while (registro.Read())
                {
                    marca.MarcaId = Convert.ToInt32(registro["MarcaId"]);
                    marca.Marca = Convert.ToString(registro["Marca"]);
                    marca.PesoOrdenacao = Convert.ToInt32(registro["PesoOrdenacao"]);
                }
            }

            conexao.Desconectar();
            return marca;
        }

        public List<Veiculo> BuscarVeiculoByMarcaAnoModeloAnoFabricacao(int marcaId, int anoModelo, int anoFabricacao)
        {
            List<Veiculo> veiculoMarca = new List<Veiculo>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Veiculo WHERE MarcaId = @marcaId "
            };

            cmd.Parameters.AddWithValue("@marcaId", marcaId);
            //cmd.Parameters.AddWithValue("@anoModeloInicial", anoModelo);
            //cmd.Parameters.AddWithValue("@anoModeloFinal", anoFabricacao);
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
                        AnoModeloInicial = Convert.ToInt32(registro["AnoModeloInicial"]),
                        AnoModeloFinal = Convert.ToInt32(registro["AnoModeloFinal"]),
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
