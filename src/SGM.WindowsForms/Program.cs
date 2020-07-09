using SGM.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormResolve.Wire(FormModule.Create());
            Application.Run(FormResolve.Resolve<FrmPrincipal>());
        }
    }
}
