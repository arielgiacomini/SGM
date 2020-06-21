using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALMaoDeObra
    {
        private readonly DALConexao conexao;

        public DALMaoDeObra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloMaoDeObra modelo)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO MaodeObra " +
                "(" +
                "MaodeObra.Descricao," +
                "Tipo," +
                "Valor," +
                "VigenciaInicial," +
                "VigenciaFinal, " +
                "Ativo " +
                ") VALUES (" +
                "@Descricao," +
                "@Tipo," +
                "@Valor," +
                "@VigenciaInicial," +
                "@VigenciaFinal, " +
                "@Ativo " +
                "); "
            };

            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
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
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "UPDATE MaodeObra SET " +
                "Descricao = @Descricao," +
                "Tipo = @Tipo," +
                "Valor = @Valor," +
                "VigenciaInicial = @VigenciaInicial," +
                "VigenciaFinal = @VigenciaFinal," +
                "Ativo = @Ativo " +
                "WHERE MaodeObraId = @MaodeObraId;"
            };

            cmd.Parameters.AddWithValue("@MaodeObraId", modelo.CMaodeObraId);
            cmd.Parameters.AddWithValue("@Descricao", modelo.CDescricao);
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
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM MaodeObra WHERE MaodeObraId = @MaodeObraId;"
            };

            cmd.Parameters.AddWithValue("@MaodeObraId", maodeobraid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MaodeObra WHERE MaodeObra.Descricao LIKE '%" + valor + "%' OR Tipo LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }

        public ModeloMaoDeObra CarregaModeloMaoDeObra(int maodeobraid)
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
                modelo.CDescricao = Convert.ToString(registro["Descricao"]);
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