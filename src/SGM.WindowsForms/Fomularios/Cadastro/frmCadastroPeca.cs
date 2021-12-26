using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using SGM.WindowsForms.IoC;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmCadastroPeca : FrmModeloDeFormularioDeCadastro
    {
        private readonly IPecaApplication _pecaApplication;

        public FrmCadastroPeca(IPecaApplication pecaApplication)
        {
            _pecaApplication = pecaApplication;
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
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d.ToString() == "Yes")
                {
                    _pecaApplication.InativarPeca(Convert.ToInt32(txtPecaId.Text));

                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LimpaTela();
                    this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Peca peca = new Peca
                {
                    Descricao = txtPeca.Text,
                    Fornecedor = txtFornecedor.Text,
                    Valor = Convert.ToDecimal(txtValorPeca.Text.Replace("R$ ", "")),
                    ValorFrete = Convert.ToDecimal(txtValorFrete.Text.Replace("R$ ", "")),
                    Ativo = true,
                    DataCadastro = DateTime.Now
                };

                if (this.operacao == "inserir")
                {
                    _pecaApplication.SalvarPeca(peca);
                    MessageBox.Show("Cadastro inserido com sucesso! Peça/Produto: " + peca.Descricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    peca.PecaId = Convert.ToInt32(txtPecaId.Text);
                    _pecaApplication.AtualizarPeca(peca);

                    MessageBox.Show("Cadastro alterado com sucesso! Peça/Produto: " + peca.Descricao.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {

            FrmConsultaPeca formConsultaPeca = FormResolve.Resolve<FrmConsultaPeca>();
            formConsultaPeca.ShowDialog();
            if (formConsultaPeca.codigo != 0)
            {
                var peca = _pecaApplication.GetPecaByPecaId(formConsultaPeca.codigo);

                txtPecaId.Text = Convert.ToString(peca.PecaId);
                txtPeca.Text = Convert.ToString(peca.Descricao);
                txtFornecedor.Text = Convert.ToString(peca.Fornecedor);
                txtValorPeca.Text = TransformaTextoEmMoeda(Convert.ToString(peca.Valor));
                txtValorFrete.Text = TransformaTextoEmMoeda(Convert.ToString(peca.ValorFrete));

                DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
            }
            else
            {
                this.LimpaTela();
                this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
            }

            formConsultaPeca.Dispose();
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

        private string TransformaTextoEmMoeda(string textoValor)
        {
            string valorFinal = "0";
            try
            {
                decimal VF = Convert.ToDecimal(textoValor.Replace("R$ ", ""));
                return valorFinal = Convert.ToString(VF.ToString("C"));
            }
            catch (Exception validaVF)
            {
                MessageBox.Show("Por favor, digite um número. \n " + validaVF.Message, "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return valorFinal;
            }
        }
    }
}