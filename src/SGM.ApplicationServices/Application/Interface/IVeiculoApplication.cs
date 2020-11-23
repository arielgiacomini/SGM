using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IVeiculoApplication
    {
        void SalvarVeiculo(Veiculo veiculo);
        void AtualizarVeiculo(Veiculo veiculo);
        void InativarVeiculo(int veiculoId);
        Veiculo GetVeiculoByVeiculoId(int veiculoId);
        VeiculoMarca GetMarcaByMarcaId(int marcaId);
    }
}