using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IVeiculoQuery
    {
        Veiculo GetVeiculoByVeiculoId(int veiculoId);
        VeiculoMarca GetMarcaByMarcaId(int marcaId);
    }
}