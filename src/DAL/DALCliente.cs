using Modelo;
using System;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class DALCliente
    {
        private DALConexao conexao;
        SQLiteConnection _sQLiteConnection;
        SQLiteCommand _cmd;
        string sql;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "INSERT INTO Cliente " +
                "(" +
                "Cliente," +
                "Apelido," +
                "DocumentoCliente," +
                "Sexo," +
                "EstadoCivil," +
                "DataNascimento," +
                "Email," +
                "TelefoneFixo," +
                "TelefoneCelular," +
                "TelefoneOutros," +
                "LogradouroCEP," +
                "LogradouroNome," +
                "LogradouroNumero," +
                "LogradouroComplemento," +
                "LogradouroMunicipio," +
                "LogradouroBairro," +
                "LogradouroUF" +
                ") VALUES (" +
                "@Cliente," +
                "@Apelido," +
                "@DocumentoCliente," +
                "@Sexo," +
                "@EstadoCivil," +
                "@DataNascimento," +
                "@Email," +
                "@TelefoneFixo," +
                "@TelefoneCelular," +
                "@TelefoneOutros," +
                "@LogradouroCEP," +
                "@LogradouroNome," +
                "@LogradouroNumero," +
                "@LogradouroComplemento," +
                "@LogradouroMunicipio," +
                "@LogradouroBairro," +
                "@LogradouroUF" +
                "); " +
                "SELECT seq FROM sqlite_sequence WHERE name = 'Cliente';"
            };
            cmd.Parameters.AddWithValue("@Cliente", modelo.CCliente);
            cmd.Parameters.AddWithValue("@Apelido", modelo.CApelido);
            cmd.Parameters.AddWithValue("@DocumentoCliente", modelo.CDocumentoCliente);
            cmd.Parameters.AddWithValue("@Sexo", modelo.CSexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", modelo.CEstadoCivil);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.CDataNascimento);
            cmd.Parameters.AddWithValue("@Email", modelo.CEmail);
            cmd.Parameters.AddWithValue("@TelefoneFixo", modelo.CTelefoneFixo);
            cmd.Parameters.AddWithValue("@TelefoneCelular", modelo.CTelefoneCelular);
            cmd.Parameters.AddWithValue("@TelefoneOutros", modelo.CTelefoneOutros);
            cmd.Parameters.AddWithValue("@LogradouroCEP", modelo.CLogradouroCEP);
            cmd.Parameters.AddWithValue("@LogradouroNome", modelo.CLogradouroNome);
            cmd.Parameters.AddWithValue("@LogradouroNumero", modelo.CLogradouroNumero);
            cmd.Parameters.AddWithValue("@LogradouroComplemento", modelo.CLogradouroComplemento);
            cmd.Parameters.AddWithValue("@LogradouroMunicipio", modelo.CLogradouroMunicipio);
            cmd.Parameters.AddWithValue("@LogradouroBairro", modelo.CLogradouroBairro);
            cmd.Parameters.AddWithValue("@LogradouroUF", modelo.CLogradouroUF);
            conexao.Conectar();
            modelo.CClienteId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCliente modelo)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Cliente SET " +
                "Cliente = @Cliente," +
                "Apelido = @Apelido," +
                "DocumentoCliente = @DocumentoCliente," +
                "Sexo = @Sexo," +
                "EstadoCivil = @EstadoCivil," +
                "DataNascimento = @DataNascimento," +
                "Email = @Email," +
                "TelefoneFixo = @TelefoneFixo," +
                "TelefoneCelular = @TelefoneCelular," +
                "TelefoneOutros = @TelefoneOutros," +
                "LogradouroCEP = @LogradouroCEP," +
                "LogradouroNome = @LogradouroNome," +
                "LogradouroNumero = @LogradouroNumero," +
                "LogradouroComplemento = @LogradouroComplemento," +
                "LogradouroMunicipio = @LogradouroMunicipio," +
                "LogradouroBairro = @LogradouroBairro," +
                "LogradouroUF = @LogradouroUF " +
                "WHERE ClienteId = @ClienteId;";
            cmd.Parameters.AddWithValue("@ClienteId", modelo.CClienteId);
            cmd.Parameters.AddWithValue("@Cliente", modelo.CCliente);
            cmd.Parameters.AddWithValue("@Apelido", modelo.CApelido);
            cmd.Parameters.AddWithValue("@DocumentoCliente", modelo.CDocumentoCliente);
            cmd.Parameters.AddWithValue("@Sexo", modelo.CSexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", modelo.CEstadoCivil);
            cmd.Parameters.AddWithValue("@DataNascimento", modelo.CDataNascimento);
            cmd.Parameters.AddWithValue("@Email", modelo.CEmail);
            cmd.Parameters.AddWithValue("@TelefoneFixo", modelo.CTelefoneFixo);
            cmd.Parameters.AddWithValue("@TelefoneCelular", modelo.CTelefoneCelular);
            cmd.Parameters.AddWithValue("@TelefoneOutros", modelo.CTelefoneOutros);
            cmd.Parameters.AddWithValue("@LogradouroCEP", modelo.CLogradouroCEP);
            cmd.Parameters.AddWithValue("@LogradouroNome", modelo.CLogradouroNome);
            cmd.Parameters.AddWithValue("@LogradouroNumero", modelo.CLogradouroNumero);
            cmd.Parameters.AddWithValue("@LogradouroComplemento", modelo.CLogradouroComplemento);
            cmd.Parameters.AddWithValue("@LogradouroMunicipio", modelo.CLogradouroMunicipio);
            cmd.Parameters.AddWithValue("@LogradouroBairro", modelo.CLogradouroBairro);
            cmd.Parameters.AddWithValue("@LogradouroUF", modelo.CLogradouroUF);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int clienteid)
        {
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "DELETE FROM Cliente WHERE ClienteId = @ClienteId;"
            };
            cmd.Parameters.AddWithValue("@ClienteId", clienteid);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Cliente WHERE Cliente LIKE '%" + valor + "%' OR Apelido LIKE '%" + valor + "%' OR DocumentoCliente = '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int clienteid)
        {
            ModeloCliente modelo = new ModeloCliente();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM Cliente WHERE ClienteId = @ClienteId";
            cmd.Parameters.AddWithValue("@ClienteId", clienteid);
            conexao.Conectar();
            SQLiteDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.CCliente = Convert.ToString(registro["Cliente"]);
                modelo.CApelido = Convert.ToString(registro["Apelido"]);
                modelo.CDocumentoCliente = Convert.ToString(registro["DocumentoCliente"]);
                modelo.CSexo = Convert.ToString(registro["Sexo"]);
                modelo.CEstadoCivil = Convert.ToString(registro["EstadoCivil"]);
                modelo.CDataNascimento = Convert.ToDateTime(registro["DataNascimento"]);
                modelo.CEmail = Convert.ToString(registro["Email"]);
                modelo.CTelefoneFixo = Convert.ToString(registro["TelefoneFixo"]);
                modelo.CTelefoneCelular = Convert.ToString(registro["TelefoneCelular"]);
                modelo.CTelefoneOutros = Convert.ToString(registro["TelefoneOutros"]);
                modelo.CLogradouroCEP = Convert.ToString(registro["LogradouroCEP"]);
                modelo.CLogradouroNome = Convert.ToString(registro["LogradouroNome"]);
                modelo.CLogradouroNumero = Convert.ToString(registro["LogradouroNumero"]);
                modelo.CLogradouroComplemento = Convert.ToString(registro["LogradouroComplemento"]);
                modelo.CLogradouroMunicipio = Convert.ToString(registro["LogradouroMunicipio"]);
                modelo.CLogradouroBairro = Convert.ToString(registro["LogradouroBairro"]);
                modelo.CLogradouroUF = Convert.ToString(registro["LogradouroUF"]);

            }

            conexao.Desconectar();
            return modelo;
        }

        /* Abaixo é apenas para verificar se existe o CPF do cliente e informar ao usuário, opcional para os demais cadastros. */
        public int VerificaCPFCliente(String cpf)
        {
            int retorno = 0; // 0 não existe
            SQLiteCommand cmd = new SQLiteCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Cliente WHERE DocumentoCliente = @documentoCliente"
            };
            cmd.Parameters.AddWithValue("@documentoCliente", cpf);
            conexao.Conectar();
            SQLiteDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();

                retorno = Convert.ToInt32(registro["ClienteId"]);
            }
            conexao.Desconectar();
            return retorno;
        }

        public DataTable LocalizarClienteById(int clienteId)
        {
            DataTable tabela = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Cliente WHERE ClienteId = " + Convert.ToString(clienteId), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
