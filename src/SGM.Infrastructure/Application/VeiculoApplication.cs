using SGM.Domain.Entities;
using SGM.Infrastructure.Application.Interface;
using SGM.Infrastructure.Command.Interface;
using SGM.Infrastructure.Queries.Interface;
using System.Collections.Generic;

namespace SGM.Infrastructure.Application
{
    public class VeiculoApplication : IVeiculoApplication
    {
        private readonly IVeiculoCommand _veiculoCommand;
        private readonly IVeiculoQuery _veiculoQuery;

        public VeiculoApplication(IVeiculoCommand veiculoCommand, IVeiculoQuery veiculoQuery)
        {
            _veiculoCommand = veiculoCommand;
            _veiculoQuery = veiculoQuery;
        }

        public int SalvarVeiculo(Veiculo veiculo)
        {
            return _veiculoCommand.SalvarVeiculo(veiculo);
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            _veiculoCommand.AtualizarVeiculo(veiculo);
        }

        public void InativarVeiculo(int veiculoId)
        {
            _veiculoCommand.InativarVeiculo(veiculoId);
        }

        public Veiculo GetVeiculoByVeiculoId(int veiculoId)
        {
            return _veiculoQuery.GetVeiculoByVeiculoId(veiculoId);
        }

        public IList<Veiculo> GetVeiculoByDescricaoModelo(string descricaoModelo)
        {
            return _veiculoQuery.GetVeiculoByDescricaoModelo(descricaoModelo);
        }

        public VeiculoMarca GetMarcaByMarcaId(int marcaId)
        {
            return _veiculoQuery.GetMarcaByMarcaId(marcaId);
        }

        public IList<VeiculoMarca> GetMarcasByAll()
        {
            return _veiculoQuery.GetMarcasByAll();
        }

        public IList<Veiculo> GetVeiculosByMarcaId(int marcaId)
        {
            return _veiculoQuery.GetVeiculosByMarcaId(marcaId);
        }
    }
}