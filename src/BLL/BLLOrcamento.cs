using DAL;
using Modelo;
using System;
using System.Data;

namespace BLL
{
    public class BLLOrcamento
    {
        private DALConexao conexao;

        public BLLOrcamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        /* INSERE O REGISTRO NO BANCO DE DADOS */
        public void IncluirOrcamento(ModeloOrcamento modelo)
        {
            modelo.CStatus = modelo.CStatus.ToUpper();
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.IncluirOrcamento(modelo);
        }

        public void IncluirOrcamentoMaodeObra(ModeloOrcamento modelo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.IncluirOrcamentoMaodeObra(modelo);
        }

        public void IncluirOrcamentoPeca(ModeloOrcamento modelo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.IncluirOrcamentoPeca(modelo);
        }

        /* UPDATE NO REGISTRO DO BANCO DE DADOS */
        public void AlterarOrcamento(ModeloOrcamento modelo)
        {
            if (modelo.COrcamentoId <= 0)
            {
                throw new Exception("Você precisa primeiro, determinar um cliente.");
            }
            if (modelo.CValorTotal == 0)
            {
                throw new Exception("Para criar um orçamento é preciso existir um valor.");
            }
            if (modelo.CDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do Orçamento é obrigatório.");
            }

            modelo.CDescricao = modelo.CDescricao.ToUpper();
            modelo.CStatus = modelo.CStatus.ToUpper();

            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.AlterarOrcamento(modelo);
        }

        public DataTable LocalizarCliente(String valor)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarCliente(valor);
        }

        public DataTable LocalizarMaodeObra(int valor)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarMaodeObra(valor);
        }

        public DataTable LocalizarPeca(int valor)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarPeca(valor);
        }


        /* PREENCHE OS DADOS NA GRIDVIEW DA TELA DE GERAÇÃO DE ORÇAMENTO */
        public DataTable LocalizarOrcamentoMaodeObra(int OrcamentoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarOrcamentoMaodeObra(OrcamentoId);
        }

        public DataTable LocalizarOrcamentoPeca(int OrcamentoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarOrcamentoPeca(OrcamentoId);
        }

        public DataTable LocalizarOrcamento(int OrcamentoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.LocalizarOrcamento(OrcamentoId);
        }

        public DataTable BuscaHistoricoOrcamentoClientePorPlacaVeiculo(string placaVeiculo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.BuscaHistoricoOrcamentoClientePorPlacaVeiculo(placaVeiculo);
        }

        public ModeloOrcamento CarregaModeloOrcamento(int OrcamentoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.CarregaModeloOrcamento(OrcamentoId);
        }


    }
}
