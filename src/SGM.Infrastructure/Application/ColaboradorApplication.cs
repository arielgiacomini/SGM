using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Intern.Interfaces.Query;

namespace SGM.Infrastructure.Application
{
    public class ColaboradorApplication : IColaboradorApplication
    {
        private readonly IColaboradorQuery _colaboradorQuery;

        public ColaboradorApplication(IColaboradorQuery colaboradorQuery)
        {
            _colaboradorQuery = colaboradorQuery;
        }

        public bool AutenticacaoLogin(string usuario, string senha)
        {
            bool autenticado = false;

            var colaborador = _colaboradorQuery.GetColaboradorByColaboradorLogin(usuario);

            if (colaborador != null || colaborador.ColaboradorId != 0)
            {
                if (colaborador.Senha == senha)
                {
                    autenticado = true;
                }
            }

            return autenticado;
        }
    }
}