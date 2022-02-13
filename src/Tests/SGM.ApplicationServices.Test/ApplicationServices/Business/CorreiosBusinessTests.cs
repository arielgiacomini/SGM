using Moq;
using SGM.ApplicationServices.Business;
using SGM.Domain.Entities.External;
using SGM.Domain.Intern.Interfaces.Application.External;
using SGM.Domain.Intern.Interfaces.Query.External;
using Xunit;


namespace SGM.Tests.ApplicationServices.Business
{
    public class CorreiosBusinessTests
    {
        Mock<ICorreriosApplication> _correriosApplicationMock;
        Mock<ICorreiosQuery> _correiosQueryMock;

        public CorreiosBusinessTests()
        {
            _correriosApplicationMock = new Mock<ICorreriosApplication>();
            _correiosQueryMock = new Mock<ICorreiosQuery>();
        }

        [Fact]
        public void FeatureSearchByCEPSucess()
        {
            var cep = "03971010";

            CorreiosEndereco correiosMock = new CorreiosEndereco
            {
                CEP = "03971010",
                Localidade = "São Paulo",
                Logradouro = "Rua Pascoal Dias",
                UF = "SP",
                Complemento = ""
            };

            _correiosQueryMock.Setup(query => query
                .GetEnderecoByCEP(string.Empty))
                .Returns(correiosMock);

            _correriosApplicationMock
                .Setup(application => application
                .GetEnderecoByCEP(string.Empty))
                .Returns(correiosMock);

            CorreiosBusiness feature = new CorreiosBusiness(_correriosApplicationMock.Object);

            var response = feature.SearchByCEP(cep);

            Assert.True(response.ReturnCompleted);
        }
    }
}