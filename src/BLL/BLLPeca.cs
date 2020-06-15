using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLPeca
    {
        private DALConexao conexao;

        public BLLPeca(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPeca modelo)
        {
            if (modelo.CPeca.Trim().Length == 0)
            {
                throw new Exception("O nome da peça é obrigatório.");
            }

            if (modelo.CValor == 0)
            {
                throw new Exception("O valor da peça é obrigatório.");
            }

            modelo.CPeca = modelo.CPeca.ToUpper();
            modelo.CFornecedor = modelo.CFornecedor.ToUpper();

            DALPeca DALobj = new DALPeca(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloPeca modelo)
        {
            if (modelo.CPecaId <= 0)
            {
                throw new Exception("O código da Peça é obrigatório!");
            }
            if (modelo.CPeca.Trim().Length == 0)
            {
                throw new Exception("O nome da Peça é obrigatório.");
            }

            modelo.CPeca = modelo.CPeca.ToUpper();
            modelo.CFornecedor = modelo.CFornecedor.ToUpper();

            DALPeca DALobj = new DALPeca(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int pecaid)
        {
            DALPeca DALobj = new DALPeca(conexao);
            DALobj.Excluir(pecaid);
        }

        public DataTable Localizar(String valor)
        {
            DALPeca DALobj = new DALPeca(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloPeca CarregaModeloPeca(int pecaid)
        {
            DALPeca DALobj = new DALPeca(conexao);
            return DALobj.CarregaModeloPeca(pecaid);
        }
    }
}
