using System.Runtime.InteropServices;

namespace MP2032
{
    public class MP2032
    {
        /* Função para enviar comandos para a impressora */
        [DllImport("MP2032")]
        public static extern int ComandoTX(string comando, int tComando);

        /* Função utilizada para abrir a porta de comunicação */
        [DllImport("MP2032")]
        public static extern int IniciaPorta(string porta);

        /* Função utilizada fechar a porta de comunicação */
        [DllImport("MP2032")]
        public static extern int FechaPorta();

        /* Função utilizada para configurar modelo da impressora */
        [DllImport("MP2032")]
        public static extern int ConfiguraModeloImpressora(int iModelo);

        /* Função para acionamento da guilhotina de papel */
        [DllImport("MP2032")]
        public static extern int AcionaGuilhotina(int guilhotina);

        /* Função para impressão de texto formatado */
        [DllImport("MP2032")]
        public static extern int FormataTX(string texto, int tipoLetra, int italico, int sublinhado, int expandido, int enfatizado);
    }
}
