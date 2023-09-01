using SGM.Domain.Entities.External;
using SGM.Domain.Intern.Interfaces.Application.External;
using SGM.Domain.Intern.Interfaces.Command.External;

namespace SGM.Infrastructure.Application.External
{
    public class WhatsAppApplication : IWhatsAppApplication
    {
        private readonly IWhatsAppCommand _whatsAppCommand;

        public WhatsAppApplication(IWhatsAppCommand whatsAppCommand)
        {
            _whatsAppCommand = whatsAppCommand;
        }

        public WhatsAppMessage SendWhatsAppMessageTest(WhatsAppMessage message)
        {
            return _whatsAppCommand.EnviarMensagemWhatsApp(message);
        }
    }
}