using SGM.Domain.Intern.Enum;

namespace SGM.Domain.Intern.Entities
{
    public class CallbackBase
    {
        public int Id { get; set; }
        public TipoCallbackEnum TipoCallback { get; set; }
        public string Mensagem { get; set; }
    }
}
