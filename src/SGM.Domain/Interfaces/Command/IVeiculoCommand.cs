using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IVeiculoCommand
    {
        int SalvarVeiculo(Veiculo veiculo);
        void AtualizarVeiculo(Veiculo veiculo);
        void InativarVeiculo(int veiculoId);
    }
}