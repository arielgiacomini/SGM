using Modelo;
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

        public DataTable BuscarHistoricoServicoClienteByClienteId(int clienteId)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
            "SELECT " +
            " Servico.ServicoId " +
            ",Cliente.ClienteId " +
            ",Servico.DataCadastro AS DataServico " +
            ",Cliente.NomeCliente " +
            ",VeiculoMarca.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
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
            "INNER JOIN VeiculoMarca ON VeiculoMarca.MarcaId = Veiculo.MarcaId " +
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
            ",VeiculoMarca.Marca + ' - ' + Veiculo.Modelo AS MarcaModeloVeiculo " +
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
            "INNER JOIN VeiculoMarca ON VeiculoMarca.MarcaId = Veiculo.MarcaId " +
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
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Servico WHERE ServicoId = @ServicoId"
            };

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
