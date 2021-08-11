using SGM.ApplicationServices.Application.Interface;
using SGM.WindowsForms.Fomularios.Modelo;
using SGM.WindowsForms.IoC;
using System.Windows.Forms;

namespace SGM.WindowsForms.Fomularios.Login
{
    public partial class FrmLogin : Form
    {
        private readonly IColaboradorApplication _colaboradorApplication;

        public FrmLogin(IColaboradorApplication colaboradorApplication)
        {
            _colaboradorApplication = colaboradorApplication;
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, System.EventArgs e)
        {
            Entrar();
        }

        private void Entrar()
        {
            FrmLoading loading = new FrmLoading();
            loading.Show();

            var usuario = txtUsuario.Text;
            var senha = txtSenha.Text;

            var usuarioAutenticado = _colaboradorApplication.AutenticacaoLogin(usuario, senha);

            if (usuarioAutenticado)
            {
                loading.Dispose();
                this.Hide();

                FrmPrincipal formPrincipal = FormResolve.Resolve<FrmPrincipal>();
                formPrincipal.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido", "Erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }
    }
}