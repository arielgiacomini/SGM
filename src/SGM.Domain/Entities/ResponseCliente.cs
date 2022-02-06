namespace SGM.Domain.Intern.Entities
{
    public class ResponseCliente : ResponseBase
    {
        public int QuantidadeVeiculoCliente { get; set; }
        public bool DeveAbrirFormularioCadastroVeiculoDoCliente { get; set; }
        public bool DeveAbrirFormularioConsultaVeiculoDoCliente { get; set; }
        public int ClienteId { get; set; }
        public int ClienteVeiculoId { get; set; }
        public bool InativacaoClienteWithError { get; set; }
    }
}