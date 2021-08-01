using System;
using System.ComponentModel;
using System.Linq;

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

    public static class StatusServico
    {
        public static string TranslateStatusServico(int statusServico)
        {
            string DescricaoEnum = "";

            var tranformEnumInList = Enum.GetValues(typeof(EnumStatusServico)).Cast<EnumStatusServico>();

            foreach (var item in tranformEnumInList)
            {
                if (((int)item) == statusServico)
                {
                    DescricaoEnum = EnumBase.ObterDescricao(item);
                }
            }

            return DescricaoEnum;
        }
    }
}