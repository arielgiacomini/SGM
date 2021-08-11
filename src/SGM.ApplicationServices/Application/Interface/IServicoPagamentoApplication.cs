using SGM.Domain.Entities;

namespace SGM.ApplicationServices.Application.Interface
{
    public interface IServicoPagamentoApplication
    {
        string[] GetFormaPagamento();
        string[] GetParcelasDisponiveisByFormaPagamento(int? formaPagamentoId, bool temImputValor, string valorTotalPorExtenso, string valorParceladoPorExtenso);
        ServicoPagamento GetServicoPagamentoByServicoId(int servicoId);
    }
}