using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IVeiculoApplication
    {
        int SalvarVeiculo(Veiculo veiculo);
        void AtualizarVeiculo(Veiculo veiculo);
        void InativarVeiculo(int veiculoId);
        Veiculo GetVeiculoByVeiculoId(int veiculoId);
        VeiculoMarca GetMarcaByMarcaId(int marcaId);
        IList<VeiculoMarca> GetMarcasByAll();
        IList<Veiculo> GetVeiculosByMarcaId(int marcaId);
        IList<Veiculo> GetVeiculoByDescricaoModelo(string descricaoModelo);
    }
}