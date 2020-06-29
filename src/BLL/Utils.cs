namespace BLL
{
    public class Utils
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
