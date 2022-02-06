using SGM.Domain.Intern.Enum;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.Domain.Intern.Entities
{
    public class ResponseBase
    {
        public int Id { get; set; }
        public TipoResponseEnum TipoResponse { get; set; }
        public Dictionary<TipoMensagemEnum, string> Mensagem { get; set; }
        public MessageBoxButtons MessageBoxButtons { get; set; }
        public MessageBoxIcon MessageBoxIcon { get; set; }
    }
}
