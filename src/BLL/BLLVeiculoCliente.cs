using DAL;
using Modelo;
using Modelo.Entities;
using System;
using System.Data;

namespace BLL
{
    public class BLLVeiculoCliente
    {
        private readonly DALConexao conexao;

        public BLLVeiculoCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public int Incluir(ClienteVeiculo modelo)
        {
            if (modelo.PlacaVeiculo.Trim().Length == 0 || modelo.CorVeiculo.Trim().Length == 0)
            {
                throw new Exception("A Placa e a Cor do veículo são obrigatórios!");
            }
            if (modelo.VeiculoId <= 0 && modelo.ClienteId <= 0)
            {
                throw new Exception("O cliente e seu veículo são campos obrigatórios!");
            }

            modelo.PlacaVeiculo = modelo.PlacaVeiculo.ToUpper();
            modelo.CorVeiculo = modelo.CorVeiculo.ToUpper();

            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.Incluir(modelo);
        }

        public void Alterar(ClienteVeiculo modelo)
        {
            if (modelo.PlacaVeiculo.Trim().Length == 0 || modelo.CorVeiculo.Trim().Length == 0)
            {
                throw new Exception("A Placa e a Cor do veículo são obrigatórios!");
            }
            if (modelo.VeiculoId <= 0 && modelo.ClienteId <= 0)
            {
                throw new Exception("O cliente e seu veículo são campos obrigatórios!");
            }
            if (modelo.ClienteVeiculoId <= 0)
            {
                throw new Exception("Você precisa selecionar o registro que deseja alterar!");
            }

            modelo.PlacaVeiculo = modelo.PlacaVeiculo.ToUpper();
            modelo.CorVeiculo = modelo.CorVeiculo.ToUpper();

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

        public ClienteVeiculo CarregaModeloVeiculoCliente(int ClienteVeiculoId)
        {
            DALVeiculoCliente DALobj = new DALVeiculoCliente(conexao);
            return DALobj.CarregaModeloVeiculo(ClienteVeiculoId);
        }

        public ClienteVeiculo CarregaModeloVeiculoClienteByPlaca(string placaVeiculo)
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
