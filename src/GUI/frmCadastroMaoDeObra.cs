using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCadastroMaoDeObra : GUI.FrmModeloDeFormularioDeCadastro
    {
        public FrmCadastroMaoDeObra()
        {
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

        public string Status = "";
        public bool vf = true;

        private void FrmCadastroMaoDeObra_Load(object sender, EventArgs e)
        {
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
            cboAtivo.Text = Convert.ToString("Ativo");
            cboAtivo.Enabled = false;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
            cboAtivo.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLMaoDeObra bll = new BLLMaoDeObra(cx);
                    bll.Excluir(Convert.ToInt32(txtMaoDeObraId.Text));
                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.AlteraBotoes(3);
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

                ModeloMaoDeObra modelo = new ModeloMaoDeObra
                {
                    CDescricao = txtMaoDeObra.Text,
                    CTipo = cboTipo.Text,
                    CValor = Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")),
                    CVigenciaInicial = Convert.ToDateTime(txtVigenciaInicial.Text),
                    CVigenciaFinal = Convert.ToDateTime(txtVigenciaFinal.Text),
                    CAtivo = Convert.ToBoolean(vf)
                };

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLMaoDeObra bll = new BLLMaoDeObra(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Mão-de-Obra/Serviço: " + modelo.CDescricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    modelo.CMaodeObraId = Convert.ToInt32(txtMaoDeObraId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso! Mão-de-Obra/Serviço: " + modelo.CDescricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.LimpaTela();
                this.AlteraBotoes(2);
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
            this.AlteraBotoes(1);
            this.LimpaTela();
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaMaoDeObra m = new FrmConsultaMaoDeObra();
            m.ShowDialog();
            if (m.codigo != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLMaoDeObra bll = new BLLMaoDeObra(cx);

                ModeloMaoDeObra modelo = bll.CarregaModeloMaoDeObra(m.codigo);

                txtMaoDeObraId.Text = Convert.ToString(modelo.CMaodeObraId);
                txtMaoDeObra.Text = Convert.ToString(modelo.CDescricao);
                cboTipo.Text = Convert.ToString(modelo.CTipo);
                txtValor.Text = Convert.ToString(modelo.CValor);
                txtVigenciaInicial.Text = Convert.ToString(modelo.CVigenciaInicial);
                txtVigenciaFinal.Text = Convert.ToString(modelo.CVigenciaFinal);

                AlteraBotoes(2);
            }
            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            m.Dispose();
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
    }
}
