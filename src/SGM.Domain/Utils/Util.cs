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
    }
}
