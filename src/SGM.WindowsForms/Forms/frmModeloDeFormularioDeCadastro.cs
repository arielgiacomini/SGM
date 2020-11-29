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
            pnCadastro.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (operacaoEscolhida == EnumControleTelas.InserirLocalizar)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (operacaoEscolhida == EnumControleTelas.SalvarCancelarExcluir)
            {
                pnCadastro.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            if (operacaoEscolhida == EnumControleTelas.AlterarExcluirCancelar)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (operacaoEscolhida == EnumControleTelas.Localizar)
            {
                pnCadastro.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnLocalizar.Enabled = true;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
            }

            if (operacaoEscolhida == EnumControleTelas.CancelarSalvar)
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
            this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
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
