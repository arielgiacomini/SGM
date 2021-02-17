using SGM.WindowsForms.Fomularios.Login;
using SGM.WindowsForms.IoC;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormResolve.Wire(FormModule.Create());

            if (Convert.ToBoolean(ConfigurationManager.AppSettings["usuario.necessita.logar"]))
            {
                Application.Run(FormResolve.Resolve<FrmLogin>());
            }
            else
            {
                Application.Run(FormResolve.Resolve<FrmPrincipal>());
            }
        }
    }
}