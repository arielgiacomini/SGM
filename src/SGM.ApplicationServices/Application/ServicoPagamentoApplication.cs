using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Queries.Interface;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using SGM.Domain.Utils;
using System.Linq;

namespace SGM.ApplicationServices.Application
{
    public class ServicoPagamentoApplication : IServicoPagamentoApplication
    {
        private readonly IServicoPagamentoQuery _servicoPagamentoQuery;

        public ServicoPagamentoApplication(IServicoPagamentoQuery servicoPagamentoQuery)
        {
            _servicoPagamentoQuery = servicoPagamentoQuery;
        }

        public ServicoPagamento GetServicoPagamentoByServicoId(int servicoId)
        {
            return _servicoPagamentoQuery.GetServicoPagamentoByServicoId(servicoId);
        }

        public string[] GetFormaPagamento()
        {
            var dados = FormaPagamentoEnumeration.GetDescriptionFormasPagamento();

            string[] formasPagamentos;
            formasPagamentos = new string[6];

            var index = 0;

            foreach (var item in dados)
            {
                if (item != null)
                {
                    formasPagamentos[index] = item;

                    index++;
                }
            }

            return formasPagamentos;
        }

        public string[] GetParcelasDisponiveisByFormaPagamento(int? formaPagamentoId, bool temImputValor, string valorTotalPorExtenso, string valorParceladoPorExtenso)
        {
            var dados = FormaPagamentoEnumeration.GetFormaPagamentoQuantidadeMaximaParcela();

            string[] parcelas;
            parcelas = new string[0];

            var index = 0;

            if (formaPagamentoId > 0)
            {
                foreach (var item in dados)
                {
                    if (formaPagamentoId == item.Key)
                    {
                        parcelas = new string[item.Value.Count()];

                        foreach (var parcela in item.Value)
                        {
                            var valorTotal = Util.TranslateStringEmDecimal(valorTotalPorExtenso);

                            valorParceladoPorExtenso = (valorTotal / parcela.NumeroParcela).ToString();

                            parcelas[index] = ReformulaTextoParcelas(temImputValor, parcela.NumeroParcela, valorTotalPorExtenso, valorParceladoPorExtenso);

                            index++;
                        }
                    }
                }
            }

            return parcelas;
        }

        private string ReformulaTextoParcelas(bool temImputDeValor, int numeroParcela, string valorTotalPorExtenso, string valorParceladoPorExtenso)
        {
            var texto = "";

            if (temImputDeValor)
            {
                texto = ($"{valorTotalPorExtenso} em {numeroParcela} parcelas de {valorParceladoPorExtenso} reais");
            }
            else
            {
                texto = ($"em {numeroParcela} vezes (sem juros)");
            }

            return texto;
        }
    }
}