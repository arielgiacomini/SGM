using Modelo;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class DALMaoDeObra
    {
        private DALConexao conexao;

        public DALMaoDeObra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloMaoDeObra modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO MaodeObra " +
                "(" +
                "MaodeObra," +
                "Tipo," +
                "Valor," +
                "VigenciaInicial," +
                "VigenciaFinal, " +
                "Ativo " +
                ") VALUES (" +
                "@MaodeObra," +
                "@Tipo," +
                "@Valor," +
                "@VigenciaInicial," +
                "@VigenciaFinal, " +
                "@Ativo " +
                "); " +
                "SELECT seq FROM sqlite_sequence WHERE name = 'MaodeObra';";
            cmd.Parameters.AddWithValue("@MaodeObra", modelo.CMaodeObra);
            cmd.Parameters.AddWithValue("@Tipo", modelo.CTipo);
            cmd.Parameters.AddWithValue("@Valor", modelo.CValor);
            cmd.Parameters.AddWithValue("@VigenciaInicial", modelo.CVigenciaInicial);
            cmd.Parameters.AddWithValue("@VigenciaFinal", modelo.CVigenciaFinal);
            cmd.Parameters.AddWithValue("@Ativo", modelo.CAtivo);
            conexao.Conectar();
            modelo.CMaodeObraId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloMaoDeObra modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE MaodeObra SET " +
                "MaodeObra = @MaodeObra," +
                "Tipo = @Tipo," +
                "Valor = @Valor," +
                "VigenciaInicial = @VigenciaInicial," +
                "VigenciaFinal = @VigenciaFinal," +
                "Ativo = @Ativo " +
                "WHERE MaodeObraId = @MaodeObraId;";
            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.CMaodeObraId);
            cmd.Parameters.AddWithValue("@MaodeObra", modelo.CMaodeObra);
            cmd.Parameters.AddWithValue("@Tipo", modelo.CTipo);
            cmd.Parameters.AddWithValue("@Valor", modelo.CValor);
            cmd.Parameters.AddWithValue("@VigenciaInicial", modelo.CVigenciaInicial);
            cmd.Parameters.AddWithValue("@VigenciaFinal", modelo.CVigenciaFinal);
            cmd.Parameters.AddWithValue("@Ativo", modelo.CAtivo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int maodeobraid)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM MaodeObra WHERE MaodeObraId = @MaodeObraId;";
            cmd.Parameters.AddWithValue("@MaodeObraId", maodeobraid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM MaodeObra WHERE MaodeObra LIKE '%" + valor + "%' OR Tipo LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloMaoDeObra CarregaModeloMaoDeObra(int maodeobraid)
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
                modelo.CVigenciaInicial = Convert.ToDateTime(registro["VigenciaInicial"]);
                modelo.CVigenciaFinal = Convert.ToDateTime(registro["VigenciaFinal"]);
                modelo.CAtivo = Convert.ToBoolean(registro["Ativo"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}