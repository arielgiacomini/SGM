using SGM.Domain.Entities;

namespace SGM.Domain.Intern.Interfaces.Query
{
    public interface IClienteQuery
    {
        Cliente GetClienteById(int clienteId);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
        Cliente GetClienteByLikePlacaOrNomeOrApelido(string valor);
        Cliente GetClienteByPlaca(string placaVeiculo);
    }
}
