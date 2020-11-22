using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IMaodeObraQuery
    {
        MaodeObra GetMaodeObraById(int maoDeObraId);
    }
}