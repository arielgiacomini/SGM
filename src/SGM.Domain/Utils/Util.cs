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
    }
}
