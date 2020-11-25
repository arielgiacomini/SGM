using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Command.Interface
{
    public interface IClienteVeiculoCommand
    {
        int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void InativarClienteVeiculo(int clienteVeiculoId);
    }
}