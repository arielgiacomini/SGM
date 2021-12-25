using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using SGM.Domain.Enumeration;
using SGM.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGM.WindowsForms.Fomularios.Cadastro
{
    public partial class FrmGerarServicoPagamento : FrmModeloDeFormularioDeCadastro
    {
        private readonly IServicoPagamentoApplication _servicoPagamentoApplication;

        public FrmGerarServicoPagamento(IServicoPagamentoApplication servicoPagamentoApplication)
        {
            _servicoPagamentoApplication = servicoPagamentoApplication;
            InitializeComponent();
        }

        public int servicoId = 2;
        public int clienteId = 0;
        public int clienteVeiculoId = 0;
        public int servicoPagamentoId = 0;
        public ServicoPagamento servicoPagamento;

        private void FrmGerarServicoPagamento_Load(object sender, System.EventArgs e)
        {
            if (servicoId != 0)
            {
                servicoPagamento = _servicoPagamentoApplication.GetServicoPagamentoByServicoId(servicoId);

                if (servicoPagamento.ValorTotalPago > 0)
                {
                    grbFormaPagamento1.Enabled = false;
                    grbFormaPagamento2.Enabled = false;

                    txtValorOriginal.Text = Convert.ToDecimal(servicoPagamento.ValorTotalOriginal).ToString("C");

                    txtValorPagamento1.Text = Convert.ToDecimal(servicoPagamento.ValorTotalPago).ToString("C");

                    PreencherComboBoxFormaPagamento(servicoPagamento.FormaPagamento, false);

                    PreencherComboBoxParcelas(servicoPagamento);

                    this.operacao = "alterar";
                    this.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
                }
                else
                {
                    grbFormaPagamento1.Enabled = true;
                    grbFormaPagamento2.Enabled = true;

                    txtValorOriginal.Text = Convert.ToDecimal(servicoPagamento.ValorTotalOriginal).ToString("C");

                    txtValorPagamento1.Text = Convert.ToDecimal(servicoPagamento.ValorTotalPago).ToString("C");

                    PreencherComboBoxFormaPagamento(servicoPagamento.FormaPagamento, true);

                    PreencherComboBoxParcelas(servicoPagamento);

                    this.operacao = "inserir";
                    this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
                }
            }
        }

        private void BtnInserir_Click(object sender, System.EventArgs e)
        {
            this.operacao = "inserir";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
        }

        private void BtnAlterar_Click(object sender, System.EventArgs e)
        {
            this.operacao = "alterar";
            this.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
        }

        private void BtnExcluir_Click(object sender, System.EventArgs e)
        {
            this.operacao = "alterar";
            this.DisponibilizarBotoesTela(EnumControleTelas.AlterarExcluirCancelar);
        }

        private void BtnLocalizar_Click(object sender, System.EventArgs e)
        {
            this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
        }

        private void BtnSalvar_Click(object sender, System.EventArgs e)
        {
            this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            this.operacao = "cancelar";
            this.DisponibilizarBotoesTela(EnumControleTelas.InserirLocalizar);
        }

        private void CkbDuasFormasPagamento_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ckbDuasFormasPagamento.Checked)
            {
                grbFormaPagamento2.Visible = true;
            }
            else
            {
                grbFormaPagamento2.Visible = false;
            }
        }

        private void PreencherComboBoxFormaPagamento(FormaPagamento formaPagamento, bool preencherTodasAsFormas)
        {
            if (!preencherTodasAsFormas)
            {
                IList<FormaPagamento> listaFormaPagamento = new List<FormaPagamento>
            {
                formaPagamento
            };

                if (cboFormaPagamento1.DataSource == null)
                {
                    cboFormaPagamento1.DataSource = listaFormaPagamento;
                    cboFormaPagamento1.DisplayMember = "Descricao";
                    cboFormaPagamento1.ValueMember = "FormaPagamentoId";
                }
            }
            else
            {
                if (cboFormaPagamento1.DataSource == null)
                {
                    cboFormaPagamento1.DataSource = _servicoPagamentoApplication.GetFormaPagamentoByAll();
                    cboFormaPagamento1.DisplayMember = "Descricao";
                    cboFormaPagamento1.ValueMember = "FormaPagamentoId";
                }
            }
        }

        private void PreencherComboBoxParcelas(ServicoPagamento servicoPagamento)
        {
            var servicoPagamentoFormat = ReformulaTextoParcelas(true, servicoPagamento, servicoPagamento.ValorTotalOriginal);

            cboQuantidadeParcelas1.DataSource = servicoPagamentoFormat.FormaPagamento.ParcelaDisponivel;
            cboQuantidadeParcelas1.DisplayMember = "TextoParcela";
            cboQuantidadeParcelas1.ValueMember = "FormaPagamentoParcelaId";

        }

        private ServicoPagamento ReformulaTextoParcelas(bool carregaGridCompleta, ServicoPagamento servicoPagamento, decimal valorTotalOriginal)
        {
            foreach (var parcela in servicoPagamento.FormaPagamento.ParcelaDisponivel)
            {
                var valorTotalParcelado = Math.Round(valorTotalOriginal / parcela.NumeroParcela, 2);

                if (carregaGridCompleta)
                {
                    parcela.TextoParcela = ($"R$ {valorTotalOriginal} em {parcela.NumeroParcela} parcelas de R$ {valorTotalParcelado} reais (sem juros)");
                }
                else
                {
                    parcela.TextoParcela = ($"em {parcela.NumeroParcela} vezes (sem juros)");
                }
            }

            return servicoPagamento;
        }

        private void CboFormaPagamento1_SelectedValueChanged(object sender, EventArgs e)
        {
            FormaPagamento formaPagamento = (FormaPagamento)cboFormaPagamento1.SelectedItem;

            servicoPagamento.FormaPagamentoId = formaPagamento.FormaPagamentoId;
            servicoPagamento.FormaPagamento = formaPagamento;

            PreencherComboBoxParcelas(servicoPagamento);

        }

        private void TxtValorPagamento1_Leave(object sender, EventArgs e)
        {
            var valorPagamento = Util.TranslateStringEmDecimal(txtValorPagamento1.Text).ToString("C");

            txtValorPagamento1.Text = valorPagamento;
        }

        private void TxtValorPagamento1_Enter(object sender, EventArgs e)
        {
            txtValorPagamento1.Text = "";
        }

        private void CboQuantidadeParcelas1_SelectedValueChanged(object sender, EventArgs e)
        {
            List<FormaPagamentoParcela> objeto = (List<FormaPagamentoParcela>)cboQuantidadeParcelas1.DataSource;

            var parcela = servicoPagamento.FormaPagamento.ParcelaDisponivel.Where(x => x.NumeroParcela == 12).FirstOrDefault().NumeroParcela;
            var valor = servicoPagamento.ValorTotalOriginal;

            var valorCorrecao = Math.Round((valor / parcela), 2);

            txtValorPagamento1.Text = valorCorrecao.ToString("C");
        }
    }
}