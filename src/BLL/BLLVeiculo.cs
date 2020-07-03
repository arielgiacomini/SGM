using DAL;
using Modelo;
using Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BLLVeiculo
    {
        private readonly DALConexao conexao;

        public BLLVeiculo(DALConexao cx)
        {
            this.conexao = cx;
        }

        public int Incluir(Veiculo modelo)
        {
            if (modelo.MarcaId == 0 || modelo.Modelo.Trim().Length == 0)
            {
                throw new Exception("O nome da Marca/Modelo é obrigatório");
            }

            modelo.Modelo = modelo.Modelo.ToUpper();

            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.Incluir(modelo);
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

        public DataTable Localizar(string valor)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloVeiculo CarregaModeloVeiculo(int veiculoid)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.CarregaModeloVeiculo(veiculoid);
        }

        public List<VeiculoMarca> BuscarMarcasVeiculo()
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.BuscarMarcaVeiculo();
        }

        public List<Veiculo> BuscarVeiculoByMarcaId(int marcaId)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.BuscarVeiculoByMarcaId(marcaId);
        }

        public Veiculo BuscarVeiculoByVeiculoId(int veiculoId)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.BuscarVeiculoByVeiculoId(veiculoId);
        }

        public VeiculoMarca BuscarMarcaVeiculoByMarcaId(int marcaId)
        {
            DALVeiculo DALobj = new DALVeiculo(conexao);
            return DALobj.BuscarMarcaVeiculoByMarcaId(marcaId);
        }
    }
}
