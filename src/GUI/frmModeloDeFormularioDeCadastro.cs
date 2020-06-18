using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmModeloDeFormularioDeCadastro : Form
    {

        public String operacao;


        public FrmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            // op = Operações que serão feitas com os botões
            //  1 = Prepara os botões para inserir e localizar
            //  2 = Prepara os para inserir/alterar um registro
            //  3 = preparar a tela para excluir ou alterar
            //  4 = apenas para operação de inclusão de registro direto de outra tela

            pnCadastro.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnCadastro.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 4)
            {
                pnCadastro.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnLocalizar.Enabled = true;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
            }

            if (op == 5)
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

        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, e.Shift, true, true, true);
            }
        }
    }
}
