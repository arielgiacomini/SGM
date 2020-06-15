using DAL;
using Modelo;
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

        /* INSERE O REGISTRO NO BANCO DE DADOS */
        public void IncluirServico(ModeloServico modelo)
        {
            modelo.CStatus = modelo.CStatus.ToUpper();
            DALServico DALobj = new DALServico(conexao);
            DALobj.IncluirServico(modelo);
        }

        public void IncluirServicoMaodeObra(ModeloServico modelo)
        {
            DALServico DALobj = new DALServico(conexao);
            DALobj.IncluirServicoMaodeObra(modelo);
        }

        public void IncluirServicoPeca(ModeloServico modelo)
        {
            DALServico DALobj = new DALServico(conexao);
            DALobj.IncluirServicoPeca(modelo);
        }


        /* ATUALIZA OS REGISTROS NO BANCO DE DADOS */
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


        /* PREENCHE OS DADOS NA GRIDVIEW DA TELA DE GERAÇÃO DE ORÇAMENTO */
        public DataTable LocalizarOrcamentoMaodeObra(int ServicoId)
        {
            DALServico DALobj = new DALServico(conexao);
            return DALobj.LocalizarServicoMaodeObra(ServicoId);
        }

        public DataTable LocalizarOrcamentoPeca(int ServicoId)
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
    }
}
