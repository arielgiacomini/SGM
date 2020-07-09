using Ninject.Modules;
using SGM.ApplicationServices.Application;
using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Command;
using SGM.ApplicationServices.Command.Interface;
using SGM.ApplicationServices.Infrastructure;
using SGM.ApplicationServices.Queries;
using SGM.ApplicationServices.Queries.Interface;
using SGM.WindowsForms.Configuration;

namespace SGM.WindowsForms.IoC
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClienteQuery>().To<ClienteQuery>();
            Bind<IClienteCommand>().To<ClienteCommand>();
            Bind<IClienteApplication>().To<ClienteApplication>();
            Bind<ISGMConfiguration>().To<SGMConfiguration>();
        }

        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}
