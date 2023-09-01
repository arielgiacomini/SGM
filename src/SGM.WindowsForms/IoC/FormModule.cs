using Ninject.Modules;
using SGM.ApplicationServices.Business;
using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Application.External;
using SGM.Domain.Intern.Interfaces.Business;
using SGM.Domain.Intern.Interfaces.Command;
using SGM.Domain.Intern.Interfaces.Command.External;
using SGM.Domain.Intern.Interfaces.Configuration;
using SGM.Domain.Intern.Interfaces.Query;
using SGM.Domain.Intern.Interfaces.Query.External;
using SGM.Infrastructure.Application;
using SGM.Infrastructure.Application.External;
using SGM.Infrastructure.Command;
using SGM.Infrastructure.Command.External;
using SGM.Infrastructure.Query;
using SGM.Infrastructure.Query.External;
using SGM.WindowsForms.Configuration;

namespace SGM.WindowsForms.IoC
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClienteQuery>().To<ClienteQuery>();
            Bind<IClienteCommand>().To<ClienteCommand>();

            Bind<IClienteVeiculoQuery>().To<ClienteVeiculoQuery>();
            Bind<IClienteVeiculoCommand>().To<ClienteVeiculoCommand>();

            Bind<IMaodeObraQuery>().To<MaodeObraQuery>();
            Bind<IMaodeObraCommand>().To<MaodeObraCommand>();

            Bind<IPecaQuery>().To<PecaQuery>();
            Bind<IPecaCommand>().To<PecaCommand>();

            Bind<IVeiculoCommand>().To<VeiculoCommand>();
            Bind<IVeiculoQuery>().To<VeiculoQuery>();

            Bind<IOrcamentoCommand>().To<OrcamentoCommand>();
            Bind<IOrcamentoQuery>().To<OrcamentoQuery>();

            Bind<IServicoCommand>().To<ServicoCommand>();
            Bind<IServicoQuery>().To<ServicoQuery>();

            Bind<IServicoPagamentoCommand>().To<ServicoPagamentoCommand>();
            Bind<IServicoPagamentoQuery>().To<ServicoPagamentoQuery>();

            Bind<ICorreiosQuery>().To<CorreiosQuery>();

            Bind<IWhatsAppCommand>().To<WhatsAppCommand>();

            Bind<IColaboradorQuery>().To<ColaboradorQuery>();

            Bind<IFormaPagamentoQuery>().To<FormaPagamentoQuery>();

            Bind<IClienteApplication>().To<ClienteApplication>();
            Bind<IClienteVeiculoApplication>().To<ClienteVeiculoApplication>();
            Bind<IMaodeObraApplication>().To<MaodeObraApplication>();
            Bind<IPecaApplication>().To<PecaApplication>();
            Bind<IVeiculoApplication>().To<VeiculoApplication>();
            Bind<IOrcamentoApplication>().To<OrcamentoApplication>();
            Bind<IServicoApplication>().To<ServicoApplication>();
            Bind<ICorreriosApplication>().To<CorreiosApplication>();
            Bind<IColaboradorApplication>().To<ColaboradorApplication>();
            Bind<IServicoPagamentoApplication>().To<ServicoPagamentoApplication>();
            Bind<IWhatsAppApplication>().To<WhatsAppApplication>();

            Bind<IClienteBusiness>().To<ClienteBusiness>();
            Bind<ICorreiosBusiness>().To<CorreiosBusiness>();

            Bind<ISGMConfiguration>().To<SGMConfiguration>();
        }

        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}