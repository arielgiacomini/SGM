using BLL;
using DAL;
using Modelo;
using Modelo.Entities;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroVeiculo : GUI.FrmModeloDeFormularioDeCadastro
    {
        public frmCadastroVeiculo()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtVeiculoid.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
        }

        private void frmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo modelo = new Veiculo
                {
                    CodigoFipe = 0,
                    MarcaId = 0,
                    Modelo = txtModelo.Text,
                    VeiculoAtivo = true,
                    DataCadastro = DateTime.Now
                };
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculo bll = new BLLVeiculo(cx);

                if (this.operacao == "inserir")
                {
                    // Cadastrar uma categoria
                    int veiculoId = bll.Incluir(modelo);
                    MessageBox.Show("Cadastro inserido com sucesso! Código: " + veiculoId.ToString());
                }
                //else
                //{
                //    // Alterar uma categoria
                //    modelo.CVeiculoId = Convert.ToInt32(txtVeiculoid.Text);
                //    bll.Alterar(modelo);
                //    MessageBox.Show("Cadastro alterado com sucesso!");
                //}
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
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
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLVeiculo bll = new BLLVeiculo(cx);
                    bll.Excluir(Convert.ToInt32(txtVeiculoid.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    MessageBox.Show("Registro Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVeiculo c = new frmConsultaVeiculo();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                // objeto para gravar os dados no banco de dados
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculo bll = new BLLVeiculo(cx);
                ModeloVeiculo modelo = bll.CarregaModeloVeiculo(c.codigo);
                txtVeiculoid.Text = modelo.CVeiculoId.ToString();
                txtMarca.Text = modelo.CMarca;
                txtModelo.Text = modelo.CModelo;
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
