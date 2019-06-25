using BBL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroClienteVeiculo : GUI.frmModeloDeFormularioDeCadastro
    {

        public frmCadastroClienteVeiculo()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtClienteVeiculoId.Clear();
            txtAnoVeiculo.Clear();
            txtCorVeiculo.Clear();
            txtKmVeiculo.Clear();
            txtPlacaVeiculo.Clear();
        }

        public String InformacaoCliente = "";

        private void frmCadastroClienteVeiculo_Load(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVeiculo bll = new BLLVeiculo(cx);
            BLLCliente bllC = new BLLCliente(cx);

            cboVeiculo.DataSource = bll.Localizar("");
            cboVeiculo.DisplayMember = "Modelo";
            cboVeiculo.ValueMember = "VeiculoId";


            if (InformacaoCliente == "")
            {
                cboCliente.DataSource = bllC.Localizar("");
                cboCliente.DisplayMember = "Cliente";
                cboCliente.ValueMember = "ClienteId";

                this.alteraBotoes(1);
            }
            else
            {
                cboCliente.DataSource = bllC.Localizar(Convert.ToString(InformacaoCliente));
                cboCliente.DisplayMember = "Cliente";
                cboCliente.ValueMember = "ClienteId";

                this.alteraBotoes(5);
                this.operacao = "inserir";
                this.cboCliente.Enabled = false;

            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "alterar";
            cboCliente.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                // leitura dos dados
                ModeloVeiculoCliente modelo = new ModeloVeiculoCliente();
                modelo.CClienteId = Convert.ToInt32(cboCliente.SelectedValue); // Quando implementar cliente atribuir como a linha abaixo.
                modelo.CVeiculoId = Convert.ToInt32(cboVeiculo.SelectedValue);
                modelo.CAnoVeiculo = Convert.ToInt32(txtAnoVeiculo.Text);
                modelo.CCorVeiculo = txtCorVeiculo.Text;
                modelo.CPlacaVeiculo = txtPlacaVeiculo.Text;
                modelo.CKmRodados = Convert.ToInt32(txtKmVeiculo.Text); // ERRO NA HORA DE LER FLOAT

                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);

                if (this.operacao == "inserir")
                {
                    // Cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Código: " + modelo.CVeiculoId.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // Alterar uma categoria
                    modelo.CClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
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
                    BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
                    bll.Excluir(Convert.ToInt32(txtClienteVeiculoId.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);

                    MessageBox.Show("Registro Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.alteraBotoes(3);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaClienteVeiculo c = new frmConsultaClienteVeiculo();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
                ModeloVeiculoCliente modelo = bll.CarregaModeloVeiculoCliente(c.codigo);
                txtClienteVeiculoId.Text = modelo.CClienteVeiculoId.ToString();
                txtPlacaVeiculo.Text = modelo.CPlacaVeiculo.ToString();
                txtAnoVeiculo.Text = modelo.CAnoVeiculo.ToString();
                txtKmVeiculo.Text = modelo.CKmRodados.ToString();
                txtCorVeiculo.Text = modelo.CCorVeiculo.ToString();
                cboCliente.SelectedValue = modelo.CClienteId.ToString();
                cboVeiculo.SelectedValue = modelo.CVeiculoId.ToString();
                alteraBotoes(3);

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            c.Dispose(); //destrói o formulário de consulta, para não ocupar memória.

        }
    }
}
