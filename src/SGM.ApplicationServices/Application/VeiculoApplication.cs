using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application
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

        public void SalvarVeiculo(Veiculo veiculo)
        {
            _veiculoCommand.SalvarVeiculo(veiculo);
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

        public VeiculoMarca GetMarcaByMarcaId(int marcaId)
        {
            return _veiculoQuery.GetMarcaByMarcaId(marcaId);
        }
    }
}