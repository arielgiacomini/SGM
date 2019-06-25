using System;
using System.Data.SQLite;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SQLiteConnection _conexao;

        public DALConexao(String dadosConexao)
        {
            this._conexao = new SQLiteConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SQLiteConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }

    }
}
