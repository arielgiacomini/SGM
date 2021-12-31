namespace SGM.Domain.Intern.Interfaces.Application
{
    public interface IColaboradorApplication
    {
        bool AutenticacaoLogin(string usuario, string senha);
    }
}