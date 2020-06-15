using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroPeca : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroPeca()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtPecaId.Clear();
            txtPeca.Clear();
            txtFornecedor.Clear();
            txtValorPeca.Clear();
            txtValorFrete.Clear();
        }

        private void frmCadastroPeca_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            //txtValorPeca.Text = Convert.ToDecimal("0").ToString("C");
            //txtValorFrete.Text = Convert.ToDecimal("0").ToString("C");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
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
                    BLLPeca bll = new BLLPeca(cx);
                    bll.Excluir(Convert.ToInt32(txtPecaId.Text));
                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.alteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // leitura dos dados
                ModeloPeca modelo = new ModeloPeca();
                modelo.CPeca = txtPeca.Text;
                modelo.CFornecedor = txtFornecedor.Text;
                modelo.CValor = Convert.ToDecimal(txtValorPeca.Text.Replace("R$ ", ""));
                modelo.CValorFrete = Convert.ToDecimal(txtValorFrete.Text.Replace("R$ ", ""));

                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPeca bll = new BLLPeca(cx);

                if (this.operacao == "inserir")
                {
                    // Cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Peça/Produto: " + modelo.CPeca.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // Alterar uma categoria
                    modelo.CPecaId = Convert.ToInt32(txtPecaId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso! Peça/Produto: " + modelo.CPeca.ToString());
                }

                this.LimpaTela();
                this.alteraBotoes(1);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaPeca l = new frmConsultaPeca();
            l.ShowDialog();
            if (l.codigo != 0)
            {
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPeca bll = new BLLPeca(cx);
                ModeloPeca modelo = bll.CarregaModeloPeca(l.codigo);
                txtPecaId.Text = Convert.ToString(modelo.CPecaId);
                txtPeca.Text = Convert.ToString(modelo.CPeca);
                txtFornecedor.Text = Convert.ToString(modelo.CFornecedor);
                txtValorPeca.Text = Convert.ToString(modelo.CValor);
                txtValorFrete.Text = Convert.ToString(modelo.CValorFrete);
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            l.Dispose(); //destrói o formulário de consulta, para não ocupar memória.

        }

        private void txtValorPeca_Leave(object sender, EventArgs e)
        {
            try
            {
                Decimal VP = Convert.ToDecimal(txtValorPeca.Text.Replace("R$ ", "0"));
                txtValorPeca.Text = Convert.ToString(VP.ToString("C"));
            }
            catch (Exception validaVP)
            {

                MessageBox.Show("Por favor, digite um número. \n " + validaVP.Message, "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorPeca.Clear();
                txtValorPeca.Focus();
            }

        }

        private void txtValorFrete_Leave(object sender, EventArgs e)
        {
            try
            {
                Decimal VF = Convert.ToDecimal(txtValorFrete.Text.Replace("R$ ", ""));
                txtValorFrete.Text = Convert.ToString(VF.ToString("C"));
            }
            catch (Exception validaVF)
            {

                MessageBox.Show("Por favor, digite um número. \n " + validaVF.Message, "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorFrete.Clear();
                txtValorFrete.Focus();
            }
        }
    }
}
