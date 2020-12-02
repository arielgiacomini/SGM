using System.ComponentModel;

namespace SGM.Domain.Enumeration
{
    public enum EnumStatusServico
    {
        [Description("Iniciado - Pendente de Término")]
        IniciadoPendente = 1,
        [Description("Expirado")]
        Expirado = 2,
        [Description("Desistido pelo Cliente")]
        Desistido = 3,
        [Description("Concluido - Gerado mas ainda não houve serviço")]
        ConcluidoSemGerarServico = 5,
        [Description("Gerou Ordem de Serviço")]
        GerouServico = 6
    }
}