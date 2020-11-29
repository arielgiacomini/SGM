using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmCadastroMaoDeObra : FrmModeloDeFormularioDeCadastro
    {
        private readonly IMaodeObraApplication _maoDeObraApplication;
        public string Status = "";
        public bool vf = true;

        public FrmCadastroMaoDeObra(IMaodeObraApplication maodeObraApplication)
        {
            _maoDeObraApplication = maodeObraApplication;
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtMaoDeObraId.Clear();
            txtMaoDeObra.Clear();
            txtValor.Clear();
            txtVigenciaInicial.Clear();
            txtVigenciaFinal.Clear();
        }

        private void FrmCadastroMaoDeObra_Load(object sender, EventArgs e)
        {
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
            cboAtivo.Text = Convert.ToString("Ativo");
            cboAtivo.Enabled = false;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
            cboAtivo.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    _maoDeObraApplication.InativarMaodeObra(Convert.ToInt32(txtMaoDeObraId.Text));

                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LimpaTela();
                    this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelExcluirAndAlterar);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Status = (Convert.ToString(cboAtivo.Text));

                if (Status == "Ativo")
                {
                    vf = true;
                }
                else
                {
                    vf = false;
                }

                MaodeObra maoDeObra = new MaodeObra
                {
                    Descricao = txtMaoDeObra.Text,
                    Tipo = cboTipo.Text,
                    Valor = Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")),
                    VigenciaInicial = Convert.ToDateTime(txtVigenciaInicial.Text),
                    VigenciaFinal = Convert.ToDateTime(txtVigenciaFinal.Text),
                    Ativo = Convert.ToBoolean(vf)
                };

                if (this.operacao == "inserir")
                {
                    _maoDeObraApplication.SalvarMaodeObra(maoDeObra);
                    MessageBox.Show("Cadastro inserido com sucesso! Mão-de-Obra/Serviço: " + maoDeObra.Descricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    maoDeObra.MaodeObraId = Convert.ToInt32(txtMaoDeObraId.Text);
                    _maoDeObraApplication.AtualizarMaodeObra(maoDeObra);
                    MessageBox.Show("Cadastro alterado com sucesso! Mão-de-Obra/Serviço: " + maoDeObra.Descricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
                this.operacao = "inserir";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
            this.LimpaTela();
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaMaoDeObra formConsultaMaodeObra = new FrmConsultaMaoDeObra();
            formConsultaMaodeObra.ShowDialog();

            if (formConsultaMaodeObra.codigo != 0)
            {
                var maoDeObra = _maoDeObraApplication.GetMaodeObraById(formConsultaMaodeObra.codigo);

                txtMaoDeObraId.Text = Convert.ToString(maoDeObra.MaodeObraId);
                txtMaoDeObra.Text = Convert.ToString(maoDeObra.Descricao);
                cboTipo.Text = Convert.ToString(maoDeObra.Tipo);
                txtValor.Text = Convert.ToString(maoDeObra.Valor);
                txtVigenciaInicial.Text = Convert.ToString(maoDeObra.VigenciaInicial);
                txtVigenciaFinal.Text = Convert.ToString(maoDeObra.VigenciaFinal);
                cboAtivo.Text = ApresentarStatus(maoDeObra);

                DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndAlterar);
            }
            else
            {
                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.DisponivelInserirAndLocalizar);
            }

            formConsultaMaodeObra.Dispose();
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal VM = Convert.ToDecimal(txtValor.Text.Replace("R$ ", ""));
                txtValor.Text = Convert.ToString(VM.ToString("C"));
            }
            catch (Exception validaVM)
            {
                MessageBox.Show("Por favor, digite um número. \n " + validaVM.Message, "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private string ApresentarStatus(MaodeObra maodeObra)
        {
            string devolucao = "Escolher";

            if (maodeObra.Ativo)
            {
                devolucao = "Ativo";
            }
            else if (!maodeObra.Ativo)
            {
                devolucao = "Inativo";
            }

            return devolucao;
        }
    }
}
