using Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCliente
    {
        private readonly DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente WHERE NomeCliente LIKE '%" + valor + "%' OR Apelido LIKE '%" + valor + "%' OR DocumentoCliente = '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int clienteid)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "SELECT * FROM Cliente WHERE ClienteId = @ClienteId"
            };

            cmd.Parameters.AddWithValue("@ClienteId", clienteid);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.CClienteId = Convert.ToInt32(registro["ClienteId"]);
                modelo.CNomeCliente = Convert.ToString(registro["NomeCliente"]);
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
                modelo.CDataCadastro = Convert.ToDateTime(registro["DataCadastro"]).AddHours(-3);
            }

            conexao.Desconectar();
            return modelo;
        }

        public DataTable LocalizarClienteById(int clienteId)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente WHERE ClienteId = " + Convert.ToString(clienteId), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
