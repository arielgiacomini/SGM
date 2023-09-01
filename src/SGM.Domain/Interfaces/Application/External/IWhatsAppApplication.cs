using SGM.Domain.Entities.External;

namespace SGM.Domain.Intern.Interfaces.Application.External
{
    public interface IWhatsAppApplication
    {
        WhatsAppMessage SendWhatsAppMessageTest(WhatsAppMessage message);
    }
}