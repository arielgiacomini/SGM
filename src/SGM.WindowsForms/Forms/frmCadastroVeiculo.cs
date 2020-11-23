using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using System;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class frmCadastroVeiculo : FrmModeloDeFormularioDeCadastro
    {
        private readonly IVeiculoApplication _veiculoApplication;

        public frmCadastroVeiculo(IVeiculoApplication veiculoApplication)
        {
            _veiculoApplication = veiculoApplication;
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtVeiculoid.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
        }

        private void FrmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.AlteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = new Veiculo
                {
                    CodigoFipe = 0,
                    MarcaId = 0,
                    Modelo = txtModelo.Text,
                    VeiculoAtivo = true,
                    DataCadastro = DateTime.Now
                };

                if (this.operacao == "inserir")
                {
                    _veiculoApplication.SalvarVeiculo(veiculo);
                    MessageBox.Show("Cadastro inserido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    veiculo.VeiculoId = Convert.ToInt32(txtVeiculoid.Text);
                    _veiculoApplication.AtualizarVeiculo(veiculo);

                    MessageBox.Show("Cadastro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    _veiculoApplication.InativarVeiculo(Convert.ToInt32(txtVeiculoid.Text));

                    this.LimpaTela();
                    this.AlteraBotoes(1);

                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AlteraBotoes(3);
            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculo c = new frmConsultaVeiculo();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                var veiculo = _veiculoApplication.GetVeiculoByVeiculoId(c.codigo);
                var marca = _veiculoApplication.GetMarcaByMarcaId(veiculo.MarcaId);

                txtVeiculoid.Text = veiculo.VeiculoId.ToString();
                txtMarca.Text = marca.Marca;
                txtModelo.Text = veiculo.Modelo;

                AlteraBotoes(2);
            }
            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            c.Dispose();
        }
    }
}