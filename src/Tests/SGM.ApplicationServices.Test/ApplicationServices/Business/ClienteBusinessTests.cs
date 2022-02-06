using Moq;
using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Application.External;
using Xunit;

namespace SGM.Tests.ApplicationServices.Business
{
    public class ClienteBusinessTests
    {
        Mock<IClienteApplication> _clienteApplicationMock;
        Mock<IClienteVeiculoApplication> _clienteVeiculoApplicationMock;
        Mock<ICorreriosApplication> _correriosApplicationMock;

        public ClienteBusinessTests()
        {
            _clienteApplicationMock = new Mock<IClienteApplication>();
            _clienteVeiculoApplicationMock = new Mock<IClienteVeiculoApplication>();
            _correriosApplicationMock = new Mock<ICorreriosApplication>();
        }

        [Fact]
        public void FeatureSalvarClienteSucess()
        {

        }
    }
}