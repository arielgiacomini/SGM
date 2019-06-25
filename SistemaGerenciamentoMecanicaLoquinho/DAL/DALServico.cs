using Modelo;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class DALServico
    {

        private DALConexao conexao;

        public DALServico(DALConexao cx)
        {
            this.conexao = cx;
        }


        /* INSERT */

        public void IncluirServico(ModeloServico modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
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
                "); " +
                "SELECT seq FROM sqlite_sequence WHERE name = 'Servico';";
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

        public void IncluirServicoMaodeObra(ModeloServico modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO ServicoMaodeObra " +
                "(" +
                "ServicoId," +
                "MaodeObraId " +
                ") VALUES (" +
                "@ServicoId," +
                "@MaodeObraId " +
                "); ";
            cmd.Parameters.AddWithValue("@ServicoId", modelo.CServicoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.CMaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void IncluirServicoPeca(ModeloServico modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO ServicoPeca " +
                "(" +
                "ServicoId," +
                "PecaId " +
                ") VALUES (" +
                "@ServicoId," +
                "@PecaId " +
                "); " +
                "SELECT seq FROM sqlite_sequence WHERE name = 'Servico';";
            cmd.Parameters.AddWithValue("@ServicoId", modelo.CServicoId);
            cmd.Parameters.AddWithValue("@PecaId", modelo.CPecaId);
            conexao.Conectar();
            modelo.CServicoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }


        /* UPDATE */

        public void AlterarServico(ModeloServico modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
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
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE ServicoMaodeObra SET " +
                "MaodeObraId = @MaodeObraId," +
                "WHERE ServicoId = @ServicoId;";
            cmd.Parameters.AddWithValue("@ServicoId", modelo.CServicoId);
            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.CMaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void AlterarServicoPeca(ModeloServico modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
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


        /* DELETE */

        public void ExcluirServico(int ServicoId)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM Servico WHERE ServicoId = @ServicoId;";
            cmd.Parameters.AddWithValue("@ServicoId", ServicoId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirServicoMaodeObra(int MaodeObraId)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM ServicoMaodeObra WHERE MaodeObraId = @MaodeObraId;";
            cmd.Parameters.AddWithValue("@MaodeObraId", MaodeObraId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void ExcluirServicoPeca(int PecaId)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM ServicoPeca WHERE PecaId = @PecaId;";
            cmd.Parameters.AddWithValue("@PecaId", PecaId);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }


        /* LOCALIZAR  PARA BOTÃO PESQUISAR */
        public DataTable LocalizarServico(int ServicoId)
        {
            Convert.ToString(ServicoId);
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Servico WHERE ServicoId = " + ServicoId, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarServicoMaodeObra(int ServicoId)
        {
            Convert.ToString(ServicoId);
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("" +
                "SELECT " +
                "MaodeObra.MaodeObraId, " +
                "MaodeObra.MaodeObra, " +
                "MaodeObra.Valor " +
                "FROM ServicoMaodeObra " +
                "INNER JOIN MaodeObra ON MaodeObra.MaodeObraId = ServicoMaodeObra.MaodeObraId " +
                "WHERE ServicoMaodeObra.ServicoId = " + ServicoId, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarServicoPeca(int ServicoIdId)
        {
            Convert.ToString(ServicoIdId);
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("" +
                "SELECT " +
                "Pecas.PecaId, " +
                "Pecas.Peca, " +
                "(Pecas.Valor + Pecas.ValorFrete) AS ValorTotal " +
                "FROM ServicoPeca " +
                "INNER JOIN Pecas ON Pecas.PecaId = ServicoPeca.PecaId " +
                "WHERE ServicoPeca.ServicoId = " + ServicoIdId, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarCliente(String Valor)
        {
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("" +
                "SELECT " +
                "ClienteId, " +
                "Cliente, " +
                "DocumentoCliente, " +
                "Sexo, " +
                "Email " +
                "FROM Cliente " +
                "WHERE Cliente.Cliente LIKE '%" + Valor + "%' OR Cliente.Apelido LIKE '%" + Valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }


        /* LOCALIZAR CRAZY - PARA TRAZER NO GRIDVIEW */
        public DataTable LocalizarMaodeObra(int valor)
        {
            Convert.ToString(valor);
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT MaodeObra.MaodeObraId, MaodeObra.MaodeObra, MaodeObra.Valor FROM MaodeObra WHERE MaodeObra.MaodeObraId = " + valor, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPeca(int valor)
        {
            Convert.ToString(valor);
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT Pecas.PecaId, Pecas.Peca, (Pecas.Valor + Pecas.ValorFrete) AS ValorTotal FROM Pecas WHERE Pecas.PecaId = " + valor, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloMaoDeObra CarregaModeloOrcamentoMaodeObra(int maodeobraid)
        {
            ModeloMaoDeObra modelo = new ModeloMaoDeObra();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM MaodeObra WHERE MaodeObraId = @MaodeObraId";
            cmd.Parameters.AddWithValue("@MaodeObraId", maodeobraid);
            conexao.Conectar();
            SQLiteDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CMaodeObraId = Convert.ToInt32(registro["MaodeObraId"]);
                modelo.CMaodeObra = Convert.ToString(registro["MaodeObra"]);
                modelo.CTipo = Convert.ToString(registro["Tipo"]);
                modelo.CValor = Convert.ToDecimal(registro["Valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
