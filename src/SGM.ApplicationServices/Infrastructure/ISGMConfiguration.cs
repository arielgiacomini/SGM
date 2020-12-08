namespace SGM.ApplicationServices.Infrastructure
{
    public interface ISGMConfiguration
    {
        string SGMWebApiUrl { get; }
        string QuantidadeUltimosOrcamentos { get; }
        string QuantidadeUltimosServicos { get; }
    }
}