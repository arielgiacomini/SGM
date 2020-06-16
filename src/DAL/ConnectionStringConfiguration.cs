using System.Configuration;

namespace DAL
{
    public class ConnectionStringConfiguration
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["sistema.gerenciamento.mecanica.db"].ToString();
            }
        }
    }
}