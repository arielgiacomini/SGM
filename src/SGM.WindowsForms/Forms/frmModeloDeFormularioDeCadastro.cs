using SGM.Domain.Enumeration;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmModeloDeFormularioDeCadastro : Form
    {

        public string operacao;


        public FrmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }

        public void DisponibilizarBotoesTela(EnumControleTelas operacaoEscolhida)
        {
            //  1 = Prepara os botões para inserir e localizar
            //  2 = Prepara os para inserir/alterar um registro
            //  3 = preparar a tela para excluir ou alterar
            //  4 = apenas para operação de inclusão de registro direto de outra tela
            //  5 = Disponível Alterar e Cancelar

            pnCadastro.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (operacaoEscolhida == EnumControleTelas.DisponivelInserirAndLocalizar)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (operacaoEscolhida == EnumControleTelas.DisponivelInserirAndAlterar)
            {
                pnCadastro.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            if (operacaoEscolhida == EnumControleTelas.DisponivelExcluirAndAlterar)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (operacaoEscolhida == EnumControleTelas.DisponivelInserirDeOutraTela)
            {
                pnCadastro.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnLocalizar.Enabled = true;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
            }

            if (operacaoEscolhida == EnumControleTelas.DisponivelInserirAndCancelar)
            {
                pnCadastro.Enabled = true;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnLocalizar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
            }
        }

        private void FrmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
        }

        private void FrmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, e.Shift, true, true, true);
            }
        }
    }
}
