using BLL;
using DAL;
using Modelo;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmCadastroClienteVeiculo : FrmModeloDeFormularioDeCadastro
    {
        public int clienteId = 0;
        public string placaVeiculo = "";
        public int clienteVeiculoId = 0;

        public FrmCadastroClienteVeiculo()
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
            txtClienteId.Clear();
            txtCliente.Clear();
            txtTelefoneCliente.Clear();
            cboVeiculo.SelectedIndex = -1;
        }

        private void FrmCadastroClienteVeiculo_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculo bll = new BLLVeiculo(cx);
            BLLCliente bllC = new BLLCliente(cx);
            BLLVeiculoCliente veiculoClienteBLL = new BLLVeiculoCliente(cx);

            ModeloVeiculoCliente modelo = veiculoClienteBLL.CarregaModeloVeiculoClienteByPlaca(placaVeiculo);

            if (modelo.CClienteVeiculoId.Equals(0))
            {
                modelo = veiculoClienteBLL.CarregaModeloVeiculoCliente(clienteVeiculoId);
            }

            cboVeiculo.DataSource = bll.Localizar("");
            cboVeiculo.DisplayMember = "Marca";
            cboVeiculo.DisplayMember = "Modelo";
            cboVeiculo.ValueMember = "VeiculoId";


            if (clienteId == 0)
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            else
            {
                ModeloCliente modeloCliente = bllC.CarregaModeloCliente(clienteId);

                txtClienteId.Text = modeloCliente.CClienteId.ToString();
                txtCliente.Text = modeloCliente.CNomeCliente.ToString();
                txtTelefoneCliente.Text = modeloCliente.CTelefoneCelular.ToString();

                this.txtClienteId.Enabled = false;
                this.txtCliente.Enabled = false;
                this.txtTelefoneCliente.Enabled = false;

                if (!modelo.CClienteVeiculoId.Equals(0))
                {
                    txtClienteVeiculoId.Text = modelo.CClienteVeiculoId.ToString();
                    txtPlacaVeiculo.Text = modelo.CPlacaVeiculo.ToString();
                    txtAnoVeiculo.Text = modelo.CAnoVeiculo.ToString();
                    txtKmVeiculo.Text = modelo.CKmRodados.ToString();
                    txtCorVeiculo.Text = modelo.CCorVeiculo.ToString();
                    cboVeiculo.SelectedValue = modelo.CVeiculoId.ToString();

                    this.alteraBotoes(3);
                    this.operacao = "alterar";
                }
                else
                {
                    this.alteraBotoes(5);
                    this.operacao = "inserir";
                }
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "alterar";
            txtCliente.Enabled = false;
            txtClienteId.Enabled = false;
            txtTelefoneCliente.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloVeiculoCliente modelo = new ModeloVeiculoCliente
                {
                    CClienteId = Convert.ToInt32(txtClienteId.Text),
                    CVeiculoId = Convert.ToInt32(cboVeiculo.SelectedValue),
                    CAnoVeiculo = Convert.ToInt32(txtAnoVeiculo.Text),
                    CCorVeiculo = txtCorVeiculo.Text,
                    CPlacaVeiculo = txtPlacaVeiculo.Text,
                    CKmRodados = Convert.ToInt32(txtKmVeiculo.Text)
                };

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Código: " + modelo.CVeiculoId.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    modelo.CClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FrmPerguntaQualItemAbrir questionItemAbrir = new FrmPerguntaQualItemAbrir
                {
                    clienteId = Convert.ToInt32(txtClienteId.Text),
                    veiculoId = Convert.ToInt32(cboVeiculo.SelectedValue),
                    placaVeiculo = Convert.ToString(txtPlacaVeiculo.Text)
                };

                questionItemAbrir.ShowDialog();
                questionItemAbrir.Dispose();
                questionItemAbrir.Close();

                this.LimpaTela();
                Dispose();
                this.alteraBotoes(1);
                Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d.ToString() == "Yes")
                {
                    // objeto para gravar os dados no banco de dados
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
                    bll.Excluir(Convert.ToInt32(txtClienteVeiculoId.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);

                    MessageBox.Show("Registro Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Dispose();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.alteraBotoes(3);
            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaClienteVeiculo c = new FrmConsultaClienteVeiculo();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                this.txtClienteId.Enabled = false;
                this.txtCliente.Enabled = false;
                this.txtTelefoneCliente.Enabled = false;

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
                BLLCliente bllC = new BLLCliente(cx);
                ModeloVeiculoCliente modelo = bll.CarregaModeloVeiculoCliente(c.codigo);
                ModeloCliente modeloCliente = bllC.CarregaModeloCliente(c.clienteId);

                txtClienteVeiculoId.Text = modelo.CClienteVeiculoId.ToString();
                txtPlacaVeiculo.Text = modelo.CPlacaVeiculo.ToString();
                txtAnoVeiculo.Text = modelo.CAnoVeiculo.ToString();
                txtKmVeiculo.Text = modelo.CKmRodados.ToString();
                txtCorVeiculo.Text = modelo.CCorVeiculo.ToString();
                cboVeiculo.SelectedValue = modelo.CVeiculoId.ToString();
                txtClienteId.Text = modeloCliente.CClienteId.ToString();
                txtCliente.Text = modeloCliente.CNomeCliente.ToString();
                txtTelefoneCliente.Text = modeloCliente.CTelefoneCelular.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }

            c.Dispose();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarHistoricoCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaHistoricoServicoClienteVeiculo consultaHistorico = new FrmConsultaHistoricoServicoClienteVeiculo
            {
                clienteId = Convert.ToInt32(txtClienteId.Text)
            };

            consultaHistorico.ShowDialog();
            consultaHistorico.Dispose();
            consultaHistorico.Close();
        }

        private void pnCadastro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
