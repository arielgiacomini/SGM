namespace SGM.Infrastructure.Configuration
{
    public interface ISGMConfiguration
    {
        string SGMWebApiUrl { get; }
        string QuantidadeUltimosOrcamentos { get; }
        string QuantidadeUltimosServicos { get; }
        string ViaCepApiUrl { get; }
        string WhatsAppApiUrl { get; }
    }
}