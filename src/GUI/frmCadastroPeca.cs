using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCadastroPeca : GUI.FrmModeloDeFormularioDeCadastro
    {
        public FrmCadastroPeca()
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

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLPeca bll = new BLLPeca(cx);
                    bll.Excluir(Convert.ToInt32(txtPecaId.Text));
                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AlteraBotoes(3);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloPeca modelo = new ModeloPeca();
                modelo.CDescricao = txtPeca.Text;
                modelo.CFornecedor = txtFornecedor.Text;
                modelo.CValor = Convert.ToDecimal(txtValorPeca.Text.Replace("R$ ", ""));
                modelo.CValorFrete = Convert.ToDecimal(txtValorFrete.Text.Replace("R$ ", ""));

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLPeca bll = new BLLPeca(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Peça/Produto: " + modelo.CDescricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    modelo.CPecaId = Convert.ToInt32(txtPecaId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso! Peça/Produto: " + modelo.CDescricao.ToString());
                }

                this.LimpaTela();
                this.AlteraBotoes(2);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.AlteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaPeca l = new frmConsultaPeca();
            l.ShowDialog();
            if (l.codigo != 0)
            {
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLPeca bll = new BLLPeca(cx);
                ModeloPeca modelo = bll.CarregaModeloPeca(l.codigo);
                txtPecaId.Text = Convert.ToString(modelo.CPecaId);
                txtPeca.Text = Convert.ToString(modelo.CDescricao);
                txtFornecedor.Text = Convert.ToString(modelo.CFornecedor);
                txtValorPeca.Text = Convert.ToString(modelo.CValor);
                txtValorFrete.Text = Convert.ToString(modelo.CValorFrete);
                AlteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            l.Dispose(); //destrói o formulário de consulta, para não ocupar memória.

        }

        private void TxtValorPeca_Leave(object sender, EventArgs e)
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

        private void TxtValorFrete_Leave(object sender, EventArgs e)
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