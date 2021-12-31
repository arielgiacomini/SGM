using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Command
{
    public interface IClienteVeiculoCommand
    {
        int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void InativarClienteVeiculo(int clienteVeiculoId);
    }
}