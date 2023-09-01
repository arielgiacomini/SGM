using SGM.Domain.Entities.External;

namespace SGM.Domain.Intern.Interfaces.Command.External
{
    public interface IWhatsAppCommand
    {
        WhatsAppMessage EnviarMensagemWhatsApp(WhatsAppMessage whatsAppMessage);
    }
}