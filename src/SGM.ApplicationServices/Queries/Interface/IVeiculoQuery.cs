using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IVeiculoQuery
    {
        Veiculo GetVeiculoByVeiculoId(int veiculoId);
        VeiculoMarca GetMarcaByMarcaId(int marcaId);
        IList<VeiculoMarca> GetMarcasByAll();
        IList<Veiculo> GetVeiculosByMarcaId(int marcaId);
        IList<Veiculo> GetVeiculoByDescricaoModelo(string descricaoModelo);
    }
}