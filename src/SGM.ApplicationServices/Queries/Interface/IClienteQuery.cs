using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Queries.Interface
{
    public interface IClienteQuery
    {
        Cliente GetClienteById(int clienteId);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
    }
}
