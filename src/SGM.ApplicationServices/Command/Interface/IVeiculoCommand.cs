using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Command.Interface
{
    public interface IVeiculoCommand
    {
        int SalvarVeiculo(Veiculo veiculo);
        void AtualizarVeiculo(Veiculo veiculo);
        void InativarVeiculo(int veiculoId);
    }
}