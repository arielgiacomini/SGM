using System;

namespace SGM.Domain.Utils
{
    public class Util
    {
        public static bool VerificaSeEhNumero(string valor)
        {
            int i = 0;

            bool result = int.TryParse(valor, out i);

            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DateTime ConvertHorarioOfServerToWorldReal(DateTime dataHora, int horas)
        {
            return dataHora.AddHours(horas);
        }

        public static decimal TranslateStringEmDecimal(string valor, bool ehPercentual = false)
        {
            decimal devolutiva = 0;

            bool ehNumero = Util.VerificaSeEhNumero(valor);

            if (valor.Contains("R$"))
            {
                devolutiva = Convert.ToDecimal(valor.Replace("R$ ", ""));
            }
            else if (valor.Contains("%"))
            {
                devolutiva = (Convert.ToDecimal(valor.Replace("%", "")) / 100);
            }
            else if (ehNumero && !ehPercentual)
            {
                devolutiva = Convert.ToDecimal(valor);
            }
            else if (ehNumero && ehPercentual)
            {
                devolutiva = Convert.ToDecimal(valor);
                devolutiva /= 100;
            }

            return devolutiva;
        }

        public static string TranslateValorEmStringDinheiro(string valor)
        {
            string devolutiva;

            if (valor == "")
            {
                devolutiva = 0.ToString("C");
            }
            else if (valor == "R$ 0,00")
            {
                devolutiva = valor;
            }
            else if ((!valor.Contains("R$") || !valor.Contains(",")) && Util.VerificaSeEhNumero(valor))
            {
                devolutiva = Convert.ToDecimal(valor).ToString("C");
            }
            else
            {
                devolutiva = valor;
            }

            return devolutiva;
        }
    }
}
