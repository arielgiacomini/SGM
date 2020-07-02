using Modelo;
using Modelo.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALOrcamento
    {
        private readonly DALConexao conexao;

        public DALOrcamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloOrcamento modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO Orcamento " +
                "(" +
                "ClienteId," +
                "Descricao," +
                "ValorAdicional," +
                "PercentualDesconto," +
                "ValorDesconto," +
                "ValorTotal," +
                "Status," +
                "Ativo " +
                ") VALUES (" +
                "@ClienteId," +
                "@Descricao," +
                "@ValorAdicional," +
                "@PercentualDesconto," +
                "@ValorDesconto," +
                "@ValorTotal," +
                "@Status," +
                "@Ativo " +
                "); SELECT @@IDENTITY;"
            };

            cmd.Parameters.AddWithValue("@ClienteId", modelo.CClienteId);
            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
            cmd.Parameters.AddWithValue("@ValorAdicional", modelo.CValorAdicional);
            cmd.Parameters.AddWithValue("@PercentualDesconto", modelo.CPercentualDesconto);
            cmd.Parameters.AddWithValue("@ValorDesconto", modelo.CValorDesconto);
            cmd.Parameters.AddWithValue("@ValorTotal", modelo.CValorTotal);
            cmd.Parameters.AddWithValue("@Status", modelo.CStatus);
            cmd.Parameters.AddWithValue("@Ativo", modelo.CAtivo);
            conexao.Conectar();
            modelo.COrcamentoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void IncluirOrcamentoMaodeObra(OrcamentoMaodeObra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO OrcamentoMaodeObra " +
                "(" +
                "OrcamentoId," +
                "MaodeObraId " +
                ") VALUES (" +
                "@OrcamentoId," +
                "@MaodeObraId " +
                "); "
            };
            cmd.Parameters.AddWithValue("@OrcamentoId", modelo.OrcamentoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.MaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void IncluirOrcamentoPeca(OrcamentoPeca modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO OrcamentoPeca " +
                "(" +
                "OrcamentoId," +
                "PecaId " +
                ") VALUES (" +
                "@OrcamentoId," +
                "@PecaId " +
                "); SELECT TOP 1 Orcamento.OrcamentoId FROM Orcamento ORDER BY OrcamentoId DESC;"
            };
            cmd.Parameters.AddWithValue("@OrcamentoId", modelo.OrcamentoId);
            cmd.Parameters.AddWithValue("@PecaId", modelo.PecaId);
            conexao.Conectar();
            modelo.OrcamentoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void AlterarOrcamento(ModeloOrcamento modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE Orcamento SET " +
                "ClienteId = @ClienteId," +
                "Descricao = @Descricao," +
                "ValorAdicional = @ValorAdicional," +
                "PercentualDesconto = @PercentualDesconto," +
                "ValorDesconto = @ValorDesconto," +
                "ValorTotal = @ValorTotal," +
                "Status = @Status," +
                "Ativo = @Ativo " +
                "WHERE OrcamentoId = @OrcamentoId;"
            };

            cmd.Parameters.AddWithValue("@OrcamentoId", modelo.COrcamentoId);
            cmd.Parameters.AddWithValue("@ClienteId", modelo.CClienteId);
            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
            cmd.Parameters.AddWithValue("@ValorAdicional", modelo.CValorAdicional);
            cmd.Parameters.AddWithValue("@PercentualDesconto", modelo.CPercentualDesconto);
            cmd.Parameters.AddWithValue("@ValorDesconto", modelo.CValorDesconto);
            cmd.Parameters.AddWithValue("@ValorTotal", modelo.CValorTotal);
            cmd.Parameters.AddWithValue("@Status", modelo.CStatus);
            cmd.Parameters.AddWithValue("@Ativo", modelo.CAtivo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void AlterarOrcamentoMaodeObra(ModeloOrcamento modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE OrcamentoMaodeObra SET " +
                "MaodeObraId = @MaodeObraId," +
                "WHERE OrcamentoId = @OrcamentoId;"
            };

            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.CMaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void AlterarOrcamentoPeca(ModeloOrcamento modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE OrcamentoPeca SET " +
                "PecaId = @PecaId," +
                "WHERE OrcamentoId = @OrcamentoId;"
            };

            cmd.Parameters.AddWithValue("@PecaId", modelo.CPecaId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirOrcamento(int OrcamentoId)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM Orcamento WHERE OrcamentoId = @OrcamentoId;"
            };

            cmd.Parameters.AddWithValue("@ClienteId", OrcamentoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            int orcamentoId = orcamentoMaodeObra.OrcamentoId;
            int maoDeObraId = orcamentoMaodeObra.MaodeObraId;

            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM OrcamentoMaodeObra WHERE OrcamentoId = @OrcamentoId AND MaodeObraId = @MaodeObraId;"
            };

            cmd.Parameters.AddWithValue("@OrcamentoId", orcamentoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", maoDeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            int orcamentoId = orcamentoPeca.OrcamentoId;
            int pecaId = orcamentoPeca.PecaId;

            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM OrcamentoPeca WHERE OrcamentoId = @OrcamentoId AND PecaId = @PecaId;"
            };

            cmd.Parameters.AddWithValue("@OrcamentoId", orcamentoId);
            cmd.Parameters.AddWithValue("@PecaId", pecaId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarOrcamento(int OrcamentoId)
        {
            Convert.ToString(OrcamentoId);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "Orcamento.OrcamentoId, " +
                "Cliente.NomeCliente, " +
                "Orcamento.Descricao, " +
                "Orcamento.ValorTotal, " +
                "Orcamento.Status, " +
                "Orcamento.Ativo, " +
                "Orcamento.DataCadastro " +
                "FROM Orcamento " +
                "INNER JOIN Cliente ON Cliente.ClienteId = Orcamento.ClienteId " +
                "WHERE Orcamento.OrcamentoId = " + OrcamentoId, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarOrcamentoMaodeObra(int OrcamentoId)
        {
            Convert.ToString(OrcamentoId);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "MaodeObra.MaodeObraId, " +
                "MaodeObra.Descricao AS MaodeObra, " +
                "MaodeObra.Valor " +
                "FROM OrcamentoMaodeObra " +
                "INNER JOIN MaodeObra ON MaodeObra.MaodeObraId = OrcamentoMaodeObra.MaodeObraId " +
                "WHERE OrcamentoMaodeObra.OrcamentoId = " + OrcamentoId, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarOrcamentoPeca(int OrcamentoId)
        {
            Convert.ToString(OrcamentoId);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "Peca.PecaId, " +
                "Peca.Descricao, " +
                "(Peca.Valor + Peca.ValorFrete) AS ValorTotal " +
                "FROM OrcamentoPeca " +
                "INNER JOIN Peca ON Peca.PecaId = OrcamentoPeca.PecaId " +
                "WHERE OrcamentoPeca.OrcamentoId = " + OrcamentoId, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarCliente(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "Cliente.ClienteId, " +
                "Cliente.NomeCliente, " +
                "ClienteVeiculo.PlacaVeiculo, " +
                "VeiculoMarca.Marca + ' - ' + Veiculo.Modelo " +
                "FROM Cliente " +
                "INNER JOIN ClienteVeiculo ON ClienteVeiculo.ClienteId = Cliente.ClienteId " +
                "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
                "INNER JOIN VeiculoMarca ON VeiculoMarca.MarcaId = Veiculo.MarcaId " +
                "WHERE Cliente.NomeCliente LIKE '%" + valor + "%' OR Cliente.Apelido LIKE '%" + valor + "%' OR ClienteVeiculo.PlacaVeiculo LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarMaodeObra(int valor)
        {
            Convert.ToString(valor);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaodeObra.MaodeObraId, MaodeObra.MaodeObra, MaodeObra.Valor FROM MaodeObra WHERE MaodeObra.MaodeObraId = " + valor, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarPeca(int valor)
        {
            Convert.ToString(valor);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Peca.PecaId, Peca.Descricao, (Peca.Valor + Peca.ValorFrete) AS ValorTotal FROM Peca WHERE Peca.PecaId = " + valor, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloOrcamento CarregaModeloOrcamento(int OrcamentoId)
        {
            ModeloOrcamento modelo = new ModeloOrcamento();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Orcamento WHERE OrcamentoId = @OrcamentoId"
            };
            cmd.Parameters.AddWithValue("@OrcamentoId", OrcamentoId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.COrcamentoId = Convert.ToInt32(registro["OrcamentoId"]);
                modelo.CClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.CDescricao = Convert.ToString(registro["Descricao"]);
                modelo.CValorAdicional = Convert.ToDecimal(registro["ValorAdicional"]);
                modelo.CPercentualDesconto = Convert.ToDecimal(registro["PercentualDesconto"]);
                modelo.CValorDesconto = Convert.ToDecimal(registro["ValorDesconto"]);
                modelo.CValorTotal = Convert.ToDecimal(registro["ValorTotal"]);
                modelo.CStatus = Convert.ToString(registro["Status"]);
                modelo.CDataCadastro = Convert.ToDateTime(registro["DataCadastro"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloMaoDeObra CarregaModeloOrcamentoMaodeObra(int maodeobraid)
        {
            ModeloMaoDeObra modelo = new ModeloMaoDeObra();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM MaodeObra WHERE MaodeObraId = @MaodeObraId"
            };

            cmd.Parameters.AddWithValue("@MaodeObraId", maodeobraid);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CMaodeObraId = Convert.ToInt32(registro["MaodeObraId"]);
                modelo.CDescricao = Convert.ToString(registro["MaodeObra"]);
                modelo.CTipo = Convert.ToString(registro["Tipo"]);
                modelo.CValor = Convert.ToDecimal(registro["Valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public DataTable BuscarHistoricoOrcamentoClienteByClienteId(int clienteId)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
            "SELECT " +
            " Orcamento.OrcamentoId " +
            ",Cliente.ClienteId " +
            ",Orcamento.DataCadastro AS DataOrcamento " +
            ",Cliente.NomeCliente " +
            ",Veiculo.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
            ",ClienteVeiculo.PlacaVeiculo " +
            ",Orcamento.Descricao AS DescricaoOrcamento " +
            ",Orcamento.Status AS StatusOrcamento " +
            ",Orcamento.ValorAdicional " +
            ",Orcamento.PercentualDesconto " +
            ",Orcamento.ValorDesconto " +
            ",Orcamento.ValorTotal " +
            "FROM Cliente " +
            "INNER JOIN ClienteVeiculo ON ClienteVeiculo.ClienteId = Cliente.ClienteId " +
            "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
            "INNER JOIN Orcamento ON Orcamento.ClienteId = Cliente.ClienteId " +
            "WHERE 1=1 " +
            "AND Cliente.ClienteId = " + Convert.ToString(clienteId) + " ORDER BY Orcamento.DataCadastro DESC; ", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable BuscaHistoricoOrcamentoClientePorPlacaVeiculo(string placaVeiculo)
        {
            DataTable tabela = new DataTable();
            string newPlacaVeiculo;

            if (placaVeiculo.Contains("-"))
            {
                newPlacaVeiculo = placaVeiculo.Replace("-", "");
            }
            else if (placaVeiculo.Length == 0)
            {
                return tabela;
            }
            else
            {
                newPlacaVeiculo = placaVeiculo;
            }

            SqlDataAdapter da = new SqlDataAdapter(
            "SELECT " +
            " Orcamento.OrcamentoId " +
            ",Cliente.ClienteId " +
            ",Orcamento.DataCadastro AS DataOrcamento " +
            ",Cliente.NomeCliente " +
            ",Veiculo.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
            ",ClienteVeiculo.PlacaVeiculo " +
            ",Orcamento.Descricao AS DescricaoServico " +
            ",Orcamento.Status AS StatusServico " +
            ",Orcamento.ValorAdicional " +
            ",Orcamento.PercentualDesconto " +
            ",Orcamento.ValorDesconto " +
            ",Orcamento.ValorTotal " +
            "FROM Cliente " +
            "INNER JOIN ClienteVeiculo ON ClienteVeiculo.ClienteId = Cliente.ClienteId " +
            "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
            "INNER JOIN Orcamento ON Orcamento.ClienteId = Cliente.ClienteId " +
            "WHERE 1=1 " +
            "AND REPLACE(RTRIM(LTRIM(ClienteVeiculo.PlacaVeiculo)), '-', '') LIKE '%" + Convert.ToString(newPlacaVeiculo) + "%'" + " ORDER BY Orcamento.DataCadastro DESC; ", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloOrcamento BuscarDetalheOrcamentoGerado(int orcamentoId)
        {
            ModeloOrcamento modelo = new ModeloOrcamento();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Orcamento WHERE OrcamentoId = @OrcamentoId"
            };

            cmd.Parameters.AddWithValue("@OrcamentoId", orcamentoId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.COrcamentoId = Convert.ToInt32(registro["OrcamentoId"]);
                modelo.CClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.CDescricao = Convert.ToString(registro["Descricao"]);
                modelo.CValorAdicional = Convert.ToDecimal(registro["ValorAdicional"]);
                modelo.CPercentualDesconto = Convert.ToDecimal(registro["PercentualDesconto"]);
                modelo.CValorDesconto = Convert.ToDecimal(registro["ValorDesconto"]);
                modelo.CValorTotal = Convert.ToDecimal(registro["ValorTotal"]);
                modelo.CStatus = Convert.ToString(registro["Status"]);
                modelo.CAtivo = Convert.ToBoolean(registro["Ativo"]);
                modelo.CDataCadastro = Convert.ToDateTime(registro["DataCadastro"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}