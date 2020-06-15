using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroMaoDeObra : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroMaoDeObra()
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

        public String Status = "";
        public bool vf = true;

        private void frmCadastroMaoDeObra_Load(object sender, EventArgs e)
        {
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
            cboAtivo.Text = Convert.ToString("Ativo");
            cboAtivo.Enabled = false;
            //txtValor.Text = Convert.ToDecimal("0").ToString("C");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
            cboAtivo.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    // objeto para gravar os dados no banco de dados
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMaoDeObra bll = new BLLMaoDeObra(cx);
                    bll.Excluir(Convert.ToInt32(txtMaoDeObraId.Text));
                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

                // leitura dos dados
                ModeloMaoDeObra modelo = new ModeloMaoDeObra();
                modelo.CMaodeObra = txtMaoDeObra.Text;
                modelo.CTipo = cboTipo.Text;
                modelo.CValor = Convert.ToDecimal(txtValor.Text.Replace("R$ ", ""));
                modelo.CVigenciaInicial = Convert.ToDateTime(txtVigenciaInicial.Text);
                modelo.CVigenciaFinal = Convert.ToDateTime(txtVigenciaFinal.Text);
                modelo.CAtivo = Convert.ToBoolean(vf);

                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMaoDeObra bll = new BLLMaoDeObra(cx);

                if (this.operacao == "inserir")
                {
                    // Cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Mão-de-Obra/Serviço: " + modelo.CMaodeObra.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // Alterar uma categoria
                    modelo.CMaodeObraId = Convert.ToInt32(txtMaoDeObraId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso! Mão-de-Obra/Serviço: " + modelo.CMaodeObra.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.LimpaTela();
                this.alteraBotoes(1);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.alteraBotoes(1);
            this.LimpaTela();
            txtVigenciaInicial.Text = Convert.ToString(DateTime.Today);
            txtVigenciaFinal.Text = Convert.ToString(DateTime.Today.AddDays(365));
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaMaoDeObra m = new frmConsultaMaoDeObra();
            m.ShowDialog();
            if (m.codigo != 0)
            {
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLMaoDeObra bll = new BLLMaoDeObra(cx);
                ModeloMaoDeObra modelo = bll.CarregaModeloMaoDeObra(m.codigo);
                txtMaoDeObraId.Text = Convert.ToString(modelo.CMaodeObraId);
                txtMaoDeObra.Text = Convert.ToString(modelo.CMaodeObra);
                cboTipo.Text = Convert.ToString(modelo.CTipo);
                txtValor.Text = Convert.ToString(modelo.CValor);
                txtVigenciaInicial.Text = Convert.ToString(modelo.CVigenciaInicial);
                txtVigenciaFinal.Text = Convert.ToString(modelo.CVigenciaFinal);
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            m.Dispose(); //destrói o formulário de consulta, para não ocupar memória.

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                Decimal VM = Convert.ToDecimal(txtValor.Text.Replace("R$ ", ""));
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
