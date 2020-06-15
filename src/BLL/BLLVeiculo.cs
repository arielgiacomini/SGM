using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLVeiculo
    {
        private DALConexao conexao;

        public BLLVeiculo(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVeiculo modelo)
        {
            if (modelo.CMarca.Trim().Length == 0 || modelo.CModelo.Trim().Length == 0)
            {
                throw new Exception("O nome da Marca/Modelo é obrigatório");
            }

            modelo.CMarca = modelo.CMarca.ToUpper();
            modelo.CModelo = modelo.CModelo.ToUpper();

            DALVeiculo DALobj = new DALVeiculo(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloVeiculo modelo)
        {
            if (modelo.CVeiculoId <= 0)
            {
                throw new Exception("O código do Veiculo é obrigatório!");
            }
            if (modelo.CMarca.Trim().Length == 0 || modelo.CModelo.Trim().Length == 0)
            {
                throw new Exception("O nome da Marca/Modelo é obrigatório");
            }

            modelo.CMarca = modelo.CMarca.ToUpper();
            modelo.CModelo = modelo.CModelo.ToUpper();

            DALVeiculo DALobj = new DALVeiculo(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int veiculoid)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            DALobj.Excluir(veiculoid);
        }

        public DataTable Localizar(String valor)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloVeiculo CarregaModeloVeiculo(int veiculoid)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.CarregaModeloVeiculo(veiculoid);
        }
    }
}
