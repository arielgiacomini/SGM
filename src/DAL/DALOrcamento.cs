using Modelo;
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

        public DataTable BuscarHistoricoOrcamentoClienteByClienteId(int clienteId)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
            "SELECT " +
            " Orcamento.OrcamentoId " +
            ",Cliente.ClienteId " +
            ",Orcamento.DataCadastro AS DataOrcamento " +
            ",Cliente.NomeCliente " +
            ",VeiculoMarca.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
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
            "INNER JOIN VeiculoMarca ON VeiculoMarca.MarcaId = Veiculo.MarcaId " +
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
            ",VeiculoMarca.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
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
            "INNER JOIN VeiculoMarca ON VeiculoMarca.MarcaId = Veiculo.MarcaId " +
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