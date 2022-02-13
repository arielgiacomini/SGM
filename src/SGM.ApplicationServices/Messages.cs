namespace SGM.ApplicationServices
{
    public static class Messages
    {
        const string CadastroInseridoComSucesso = "Cadastro inserido com sucesso!";
        const string CadastroInseridoSemSucesso = "Cadastro NÃO EFETUADO!";
        const string AtualizacaoComSucesso = "Atualização de cliente com sucesso!";
        const string AtualizacaoSemSucesso = "Atualização de cliente NÃO EFETUADO!";

        const string NaoFoiPossivelValidarVeiculo = "Não foi possível verificar/validar veiculo(s) do cliente. ";

        const string ClienteSemVeiculo = "Deseja incluir o veículo dele agora? " +
                        "\n Clicando em (Sim), será aberto uma lista de clientes você escolhe o " +
                        "cliente que você acabou de cadastrar \n " +
                        "e clicando duas vezes você automáticamente poderá cadastrar o veículo dele.";

        const string ClienteComApenasUmVeiculo = "Este Cliente possui 1 veículo no cadastro, " +
                            "abriremos a tela de veiculo deste cliente.";

        const string ClienteComMaisDeUmVeiculo = "Este cliente possui + de 1 veículo cadastrado no sistema, " +
                            "será aberto a lista de veículos.";

        const string ExclusaoComSucesso = "Registro Excluído com Sucesso!";
        const string ExclusaoSemSucesso = "A exclusão NÃO FOI EFETUADA!";

        const string PesquisaSemSucesso = "Erro ao tentar pesquisar";

        const string PesquisaComSucesso = "";

        const string CPFExistente = "Esse CPF já existe em nossa base de dados. Deseja alterar o registro?";

        const string CEPInexistente = "CEP não encontrado na base dos Correios. Está correto?";

        const string CEPEncontrado = "CEP Localizado. Digite o número...";

        public static string Mensagem(MensagemEnum tipoMessagem)
        {
            var mensagem = "";
            switch (tipoMessagem)
            {
                case MensagemEnum.CadastroInseridoComSucesso:
                    mensagem = CadastroInseridoComSucesso;
                    break;
                case MensagemEnum.CadastroInseridoSemSucesso:
                    mensagem = CadastroInseridoSemSucesso;
                    break;
                case MensagemEnum.AtualizacaoComSucesso:
                    mensagem = AtualizacaoComSucesso;
                    break;
                case MensagemEnum.AtualizacaoSemSucesso:
                    mensagem = AtualizacaoSemSucesso;
                    break;
                case MensagemEnum.NaoFoiPossivelValidarVeiculo:
                    mensagem = NaoFoiPossivelValidarVeiculo;
                    break;
                case MensagemEnum.ClienteSemVeiculo:
                    mensagem = ClienteSemVeiculo;
                    break;
                case MensagemEnum.ClienteComApenasUmVeiculo:
                    mensagem = ClienteComApenasUmVeiculo;
                    break;
                case MensagemEnum.ClienteComMaisDeUmVeiculo:
                    mensagem = ClienteComMaisDeUmVeiculo;
                    break;
                case MensagemEnum.ExclusaoComSucesso:
                    mensagem = ExclusaoComSucesso;
                    break;
                case MensagemEnum.ExclusaoSemSucesso:
                    mensagem = ExclusaoSemSucesso;
                    break;
                case MensagemEnum.PesquisaSemSucesso:
                    mensagem = PesquisaSemSucesso;
                    break;
                case MensagemEnum.PesquisaComSucesso:
                    mensagem = PesquisaComSucesso;
                    break;
                case MensagemEnum.CPFExistente:
                    mensagem = CPFExistente;
                    break;
                case MensagemEnum.CEPEncontrado:
                    mensagem = CEPEncontrado;
                    break;
                case MensagemEnum.CEPInexistente:
                    mensagem = CEPInexistente;
                    break;
            }
            return mensagem;
        }

        public enum MensagemEnum
        {
            CadastroInseridoComSucesso = 1,
            CadastroInseridoSemSucesso = 2,
            AtualizacaoComSucesso = 3,
            AtualizacaoSemSucesso = 4,
            NaoFoiPossivelValidarVeiculo = 5,
            ClienteSemVeiculo = 6,
            ClienteComApenasUmVeiculo = 7,
            ClienteComMaisDeUmVeiculo = 8,
            ExclusaoComSucesso = 9,
            ExclusaoSemSucesso = 10,
            PesquisaComSucesso = 11,
            PesquisaSemSucesso = 12,
            CPFExistente = 13,
            CEPEncontrado = 14,
            CEPInexistente = 15
        }
    }
}