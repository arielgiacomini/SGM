using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Enumeration;
using System;

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

        private void FrmGerarServicoPagamento_Load(object sender, System.EventArgs e)
        {
            if (servicoId != 0)
            {
                var servicoPagamento = _servicoPagamentoApplication.GetServicoPagamentoByServicoId(servicoId);

                txtValorPagamento1.Text = Convert.ToDecimal(servicoPagamento.ValorTotalPago).ToString("C");

                PreencherComboBoxFormaPagamento(servicoPagamento.FormaPagamentoId);

                PreencherComboBoxParcelas(servicoPagamento.FormaPagamentoId, servicoPagamento.ValorTotalOriginal > 0, servicoPagamento.ValorTotalOriginal.ToString(), "");
            }

            this.operacao = "inserir";
            this.DisponibilizarBotoesTela(EnumControleTelas.SalvarCancelarExcluir);
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

        private void PreencherComboBoxFormaPagamento(int? formaPagamentoId)
        {
            var formas = _servicoPagamentoApplication.GetFormaPagamento();

            cboFormaPagamento1.Items.AddRange(formas);

            if (formaPagamentoId.HasValue)
            {
                cboFormaPagamento1.SelectedIndex = formaPagamentoId.Value - 1;
            }
        }

        private void PreencherComboBoxParcelas(int? formaPagamentoId, bool imputValor, string valorTotalPorExtenso, string valorParceladoPorExtenso)
        {
            var parcelas = _servicoPagamentoApplication.GetParcelasDisponiveisByFormaPagamento(0, imputValor, valorTotalPorExtenso, valorParceladoPorExtenso);

            cboQuantidadeParcelas1.Items.AddRange(parcelas);

            if (formaPagamentoId.HasValue)
            {
                cboQuantidadeParcelas1.SelectedIndex = formaPagamentoId.Value - 1;
            }
        }
    }
}