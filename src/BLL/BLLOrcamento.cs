using DAL;
using Modelo;
using Modelo.Entities;
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

        public void IncluirOrcamento(ModeloOrcamento modelo)
        {
            modelo.CStatus = modelo.CStatus.ToUpper();
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.IncluirOrcamento(modelo);
        }

        public void IncluirOrcamentoMaodeObra(OrcamentoMaodeObra modelo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.IncluirOrcamentoMaodeObra(modelo);
        }

        public void IncluirOrcamentoPeca(OrcamentoPeca modelo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.IncluirOrcamentoPeca(modelo);
        }

        public void ExcluirOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.ExcluirOrcamentoMaodeObra(orcamentoMaodeObra);
        }

        public void ExcluirOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.ExcluirOrcamentoPeca(orcamentoPeca);
        }

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

        public DataTable BuscarHistoricoOrcamentoClienteByClienteId(int clienteId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.BuscarHistoricoOrcamentoClienteByClienteId(clienteId);
        }

        public ModeloOrcamento BuscarDetalheOrcamentoGerado(int servicoId)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.BuscarDetalheOrcamentoGerado(servicoId);
        }
    }
}
