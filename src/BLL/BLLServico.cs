using DAL;
using Modelo;
using Modelo.Entities;
using System;
using System.Data;

namespace BLL
{
    public class BLLServico
    {
        private DALConexao conexao;

        public BLLServico(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void IncluirServico(ModeloServico modelo)
        {
            modelo.CStatus = modelo.CStatus.ToUpper();
            DALServico DALobj = new DALServico(conexao);
            DALobj.IncluirServico(modelo);
        }

        public void IncluirServicoMaodeObra(ServicoMaodeObra modelo)
        {
            DALServico DALobj = new DALServico(conexao);
            DALobj.IncluirServicoMaodeObra(modelo);
        }

        public void IncluirServicoPeca(ServicoPeca modelo)
        {
            DALServico DALobj = new DALServico(conexao);
            DALobj.IncluirServicoPeca(modelo);
        }

        public void AlterarServico(ModeloServico modelo)
        {
            if (modelo.CServicoId <= 0)
            {
                throw new Exception("Você precisa primeiro, clicar no botão Inserir.");
            }
            if (modelo.CValorTotal == 0)
            {
                throw new Exception("Para criar um Servico é preciso existir um valor.");
            }
            if (modelo.CDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do Serviço é obrigatório.");
            }

            modelo.CDescricao = modelo.CDescricao.ToUpper();
            modelo.CStatus = modelo.CStatus.ToUpper();

            DALServico DALobj = new DALServico(conexao);
            DALobj.AlterarServico(modelo);
        }

        public void ExcluirServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            DALServico DALobj = new DALServico(conexao);
            DALobj.ExcluirServicoMaodeObra(servicoMaodeObra);
        }

        public void ExcluirServicoPeca(ServicoPeca servicoPeca)
        {
            DALServico DALobj = new DALServico(conexao);
            DALobj.ExcluirServicoPeca(servicoPeca);
        }

        public DataTable LocalizarCliente(String valor)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarCliente(valor);
        }

        public DataTable LocalizarMaodeObra(int valor)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarMaodeObra(valor);
        }

        public DataTable LocalizarPeca(int valor)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarPeca(valor);
        }

        public DataTable LocalizarServicoMaodeObra(int ServicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarServicoMaodeObra(ServicoId);
        }

        public DataTable LocalizarServicoPeca(int ServicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarServicoPeca(ServicoId);
        }

        public DataTable LocalizarServico(int ServicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarServico(ServicoId);
        }

        public DataTable BuscarHistoricoServicoClienteByClienteId(int clienteId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.BuscarHistoricoServicoClienteByClienteId(clienteId);
        }

        public DataTable BuscaHistoricoServicoClientePorPlacaVeiculo(string valor)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.BuscaHistoricoServicoClientePorPlacaVeiculo(valor);
        }

        public ModeloServico BuscarDetalheServicoGerado(int servicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.BuscarDetalheServicoGerado(servicoId);
        }
    }
}
