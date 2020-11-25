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