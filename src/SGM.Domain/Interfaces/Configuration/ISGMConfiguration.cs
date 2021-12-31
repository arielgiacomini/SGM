namespace SGM.Domain.Intern.Interfaces.Configuration
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