using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteCommand _clienteCommand;
        private readonly IClienteQuery _clienteQuery;
        public ClienteApplication(IClienteCommand clienteCommand, IClienteQuery clienteQuery)
        {
            _clienteCommand = clienteCommand;
            _clienteQuery = clienteQuery;
        }

        public Cliente GetClienteById(int clienteId)
        {
            var cliente = _clienteQuery.GetClienteById(clienteId);

            return cliente;
        }
    }
}
