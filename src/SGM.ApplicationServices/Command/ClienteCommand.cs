using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Infrastructure;

namespace SGM.ApplicationServices.Command
{
    public class ClienteCommand : IClienteCommand
    {
        private readonly ISGMConfiguration _sGMConfiguration;

        public ClienteCommand(ISGMConfiguration sGMConfiguration)
        {
            _sGMConfiguration = sGMConfiguration;
        }
    }
}