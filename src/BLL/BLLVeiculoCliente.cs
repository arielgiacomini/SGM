using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLVeiculoCliente
    {
        private DALConexao conexao;

        public BLLVeiculoCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVeiculoCliente modelo)
        {
            if (modelo.CPlacaVeiculo.Trim().Length == 0 || modelo.CCorVeiculo.Trim().Length == 0)
            {
                throw new Exception("A Placa e a Cor do veículo são obrigatórios!");
            }
            if (modelo.CVeiculoId <= 0 && modelo.CClienteId <= 0)
            {
                throw new Exception("O cliente e seu veículo são campos obrigatórios!");
            }

            modelo.CPlacaVeiculo = modelo.CPlacaVeiculo.ToUpper();
            modelo.CCorVeiculo = modelo.CCorVeiculo.ToUpper();

            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloVeiculoCliente modelo)
        {
            if (modelo.CPlacaVeiculo.Trim().Length == 0 || modelo.CCorVeiculo.Trim().Length == 0)
            {
                throw new Exception("A Placa e a Cor do veículo são obrigatórios!");
            }
            if (modelo.CVeiculoId <= 0 && modelo.CClienteId <= 0)
            {
                throw new Exception("O cliente e seu veículo são campos obrigatórios!");
            }
            if (modelo.CClienteVeiculoId <= 0)
            {
                throw new Exception("Você precisa selecionar o registro que deseja alterar!");
            }

            modelo.CPlacaVeiculo = modelo.CPlacaVeiculo.ToUpper();
            modelo.CCorVeiculo = modelo.CCorVeiculo.ToUpper();

            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int ClienteVeiculoId)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            DALobj.Excluir(ClienteVeiculoId);
        }

        public DataTable Localizar(String valor)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloVeiculoCliente CarregaModeloVeiculoCliente(int ClienteVeiculoId)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.CarregaModeloVeiculo(ClienteVeiculoId);
        }

        public ModeloVeiculoCliente CarregaModeloVeiculoClienteByPlaca(string placaVeiculo)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.CarregaModeloVeiculoClienteByPlaca(placaVeiculo);
        }

        public ModeloVeiculoCliente BuscarVeiculosCliente(int clienteId)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.BuscarVeiculosCliente(clienteId);
        }

        public DataTable LocalizarTodosVeiculosCliente(int clienteId)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.LocalizarTodosVeiculosCliente(clienteId);
        }
    }
}
