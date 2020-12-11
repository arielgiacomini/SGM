using SGM.ApplicationServices.Application.Interface;
using SGM.ApplicationServices.Queries.Interface;

namespace SGM.ApplicationServices.Application
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