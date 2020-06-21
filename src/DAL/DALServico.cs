using Modelo;
using Modelo.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALServico
    {
        private readonly DALConexao conexao;

        public DALServico(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void IncluirServico(ModeloServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO Servico " +
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
                "); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@ClienteId", modelo.CClienteId);
            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
            cmd.Parameters.AddWithValue("@ValorAdicional", modelo.CValorAdicional);
            cmd.Parameters.AddWithValue("@PercentualDesconto", modelo.CPercentualDesconto);
            cmd.Parameters.AddWithValue("@ValorDesconto", modelo.CValorDesconto);
            cmd.Parameters.AddWithValue("@ValorTotal", modelo.CValorTotal);
            cmd.Parameters.AddWithValue("@Status", modelo.CStatus);
            cmd.Parameters.AddWithValue("@Ativo", modelo.CAtivo);
            conexao.Conectar();
            modelo.CServicoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void IncluirServicoMaodeObra(ServicoMaodeObra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO ServicoMaodeObra " +
                "(" +
                "ServicoId," +
                "MaodeObraId " +
                ") VALUES (" +
                "@ServicoId," +
                "@MaodeObraId " +
                ");"
            };

            cmd.Parameters.AddWithValue("@ServicoId", modelo.ServicoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.MaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void IncluirServicoPeca(ServicoPeca modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO ServicoPeca " +
                "(" +
                "ServicoId," +
                "PecaId " +
                ") VALUES (" +
                "@ServicoId," +
                "@PecaId " +
                "); SELECT TOP 1 Servico.ServicoId FROM Servico ORDER BY ServicoId DESC;"
            };

            cmd.Parameters.AddWithValue("@ServicoId", modelo.ServicoId);
            cmd.Parameters.AddWithValue("@PecaId", modelo.PecaId);
            conexao.Conectar();
            modelo.ServicoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void AlterarServico(ModeloServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Servico SET " +
                "ClienteId = @ClienteId," +
                "Descricao = @Descricao," +
                "ValorAdicional = @ValorAdicional," +
                "PercentualDesconto = @PercentualDesconto," +
                "ValorDesconto = @ValorDesconto," +
                "ValorTotal = @ValorTotal," +
                "Status = @Status," +
                "Ativo = @Ativo " +
                "WHERE ServicoId = @ServicoId;";
            cmd.Parameters.AddWithValue("@ServicoId", modelo.CServicoId);
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

        public void AlterarServicoMaodeObra(ModeloServico modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE ServicoMaodeObra SET " +
                "MaodeObraId = @MaodeObraId," +
                "WHERE ServicoId = @ServicoId;"
            };
            cmd.Parameters.AddWithValue("@ServicoId", modelo.CServicoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.CMaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void AlterarServicoPeca(ModeloServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE ServicoPeca SET " +
                "PecaId = @PecaId," +
                "WHERE ServicoId = @ServicoId;";
            cmd.Parameters.AddWithValue("@ServicoId", modelo.CServicoId);
            cmd.Parameters.AddWithValue("@PecaId", modelo.CPecaId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirServico(int ServicoId)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM Servico WHERE ServicoId = @ServicoId;"
            };

            cmd.Parameters.AddWithValue("@ServicoId", ServicoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            int servicoId = servicoMaodeObra.ServicoId;
            int maoDeObraId = servicoMaodeObra.MaodeObraId;

            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM ServicoMaodeObra WHERE ServicoId = @ServicoId AND MaodeObraId = @MaodeObraId;"
            };

            cmd.Parameters.AddWithValue("@ServicoId", servicoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", maoDeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirServicoPeca(ServicoPeca servicoPeca)
        {
            int servicoId = servicoPeca.ServicoId;
            int pecaId = servicoPeca.PecaId;

            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM ServicoPeca WHERE ServicoId = @ServicoId AND PecaId = @PecaId;"
            };

            cmd.Parameters.AddWithValue("@ServicoId", servicoId);
            cmd.Parameters.AddWithValue("@PecaId", pecaId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarServico(int ServicoId)
        {
            Convert.ToString(ServicoId);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Servico WHERE ServicoId = " + ServicoId, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarServicoMaodeObra(int ServicoId)
        {
            Convert.ToString(ServicoId);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "MaodeObra.MaodeObraId, " +
                "MaodeObra.Descricao, " +
                "MaodeObra.Valor " +
                "FROM ServicoMaodeObra " +
                "INNER JOIN MaodeObra ON MaodeObra.MaodeObraId = ServicoMaodeObra.MaodeObraId " +
                "WHERE ServicoMaodeObra.ServicoId = " + ServicoId, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarServicoPeca(int servicoId)
        {
            Convert.ToString(servicoId);
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "Peca.PecaId, " +
                "Peca.Descricao, " +
                "(Peca.Valor + Peca.ValorFrete) AS ValorTotal " +
                "FROM ServicoPeca " +
                "INNER JOIN Peca ON Peca.PecaId = ServicoPeca.PecaId " +
                "WHERE ServicoPeca.ServicoId = " + servicoId, conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable LocalizarCliente(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("" +
                "SELECT " +
                "Cliente.ClienteId, " +
                "Cliente.NomeCliente, " +
                "ClienteVeiculo.PlacaVeiculo, " +
                "Veiculo.Marca + ' - ' + Veiculo.Modelo " +
                "FROM Cliente " +
                "INNER JOIN ClienteVeiculo ON ClienteVeiculo.ClienteId = Cliente.ClienteId " +
                "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
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

        public ModeloMaoDeObra CarregaModeloServicoMaodeObra(int maodeobraid)
        {
            ModeloMaoDeObra modelo = new ModeloMaoDeObra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM MaodeObra WHERE MaodeObraId = @MaodeObraId";
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

        public DataTable BuscarHistoricoServicoClienteByClienteId(int clienteId)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
            "SELECT " +
            " Servico.ServicoId " +
            ",Cliente.ClienteId " +
            ",Servico.DataCadastro AS DataServico " +
            ",Cliente.NomeCliente " +
            ",Veiculo.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
            ",ClienteVeiculo.PlacaVeiculo " +
            ",Servico.Descricao AS DescricaoServico " +
            ",Servico.Status AS StatusServico " +
            ",Servico.ValorAdicional " +
            ",Servico.PercentualDesconto " +
            ",Servico.ValorDesconto " +
            ",Servico.ValorTotal " +
            "FROM Cliente " +
            "INNER JOIN ClienteVeiculo ON ClienteVeiculo.ClienteId = Cliente.ClienteId " +
            "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
            "INNER JOIN Servico ON Servico.ClienteId = Cliente.ClienteId " +
            "WHERE 1=1 " +
            "AND Cliente.ClienteId = " + Convert.ToString(clienteId) + " ORDER BY Servico.ServicoId DESC; ", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public DataTable BuscaHistoricoServicoClientePorPlacaVeiculo(string placaVeiculo)
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
            " Servico.ServicoId " +
            ",Cliente.ClienteId " +
            ",Servico.DataCadastro AS DataServico " +
            ",Cliente.NomeCliente " +
            ",Veiculo.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
            ",ClienteVeiculo.PlacaVeiculo " +
            ",Servico.Descricao AS DescricaoServico " +
            ",Servico.Status AS StatusServico " +
            ",Servico.ValorAdicional " +
            ",Servico.PercentualDesconto " +
            ",Servico.ValorDesconto " +
            ",Servico.ValorTotal " +
            "FROM Cliente " +
            "INNER JOIN ClienteVeiculo ON ClienteVeiculo.ClienteId = Cliente.ClienteId " +
            "INNER JOIN Veiculo ON Veiculo.VeiculoId = ClienteVeiculo.VeiculoId " +
            "INNER JOIN Servico ON Servico.ClienteId = Cliente.ClienteId " +
            "WHERE 1=1 " +
            "AND REPLACE(RTRIM(LTRIM(ClienteVeiculo.PlacaVeiculo)), '-', '') LIKE '%" + Convert.ToString(newPlacaVeiculo) + "%'" + " ORDER BY Servico.ServicoId DESC; ", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloServico BuscarDetalheServicoGerado(int servicoId)
        {
            ModeloServico modelo = new ModeloServico();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM Servico WHERE ServicoId = @ServicoId";
            cmd.Parameters.AddWithValue("@ServicoId", servicoId);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CServicoId = Convert.ToInt32(registro["ServicoId"]);
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
