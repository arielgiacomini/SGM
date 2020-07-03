using BLL;
using DAL;
using Modelo;
using Modelo.Entities;
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
            txtCorVeiculo.Clear();
            txtKmVeiculo.Clear();
            txtPlacaVeiculo.Clear();
            txtClienteId.Clear();
            txtCliente.Clear();
            txtTelefoneCliente.Clear();
            txtAnoModeloVeiculo.Clear();
            cboVeiculo.SelectedIndex = -1;
            cboMarcaVeiculo.SelectedIndex = -1;
        }

        private void FrmCadastroClienteVeiculo_Load(object sender, EventArgs e)
        {
            this.txtClienteId.Enabled = false;
            this.txtCliente.Enabled = false;
            this.txtTelefoneCliente.Enabled = false;
            this.txtAnoModeloVeiculo.Enabled = false;

            this.LimpaTela();
            this.alteraBotoes(1);

            DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculo veiculo = new BLLVeiculo(conexao);
            BLLCliente cliente = new BLLCliente(conexao);
            BLLVeiculoCliente clienteVeiculos = new BLLVeiculoCliente(conexao);

            if (cboMarcaVeiculo.DataSource == null)
            {
                cboMarcaVeiculo.DataSource = veiculo.BuscarMarcasVeiculo();
                cboMarcaVeiculo.DisplayMember = "Marca";
                cboMarcaVeiculo.ValueMember = "MarcaId";
            }

            ClienteVeiculo dadosVeiculoCliente = new ClienteVeiculo();
            ModeloCliente dadosCliente = new ModeloCliente();
            Veiculo dadosVeiculo = new Veiculo();
            VeiculoMarca dadosMarcaVeiculo = new VeiculoMarca();


            if (placaVeiculo != null && placaVeiculo != "")
            {
                dadosVeiculoCliente = clienteVeiculos.CarregaModeloVeiculoClienteByPlaca(placaVeiculo);
                dadosCliente = cliente.CarregaModeloCliente(dadosVeiculoCliente.ClienteId);
                dadosVeiculo = veiculo.BuscarVeiculoByVeiculoId(dadosVeiculoCliente.VeiculoId);
                dadosMarcaVeiculo = veiculo.BuscarMarcaVeiculoByMarcaId(dadosVeiculo.MarcaId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.alteraBotoes(3);
                this.operacao = "alterar";
            }

            if (clienteVeiculoId != 0)
            {
                dadosVeiculoCliente = clienteVeiculos.CarregaModeloVeiculoCliente(clienteVeiculoId);
                dadosCliente = cliente.CarregaModeloCliente(dadosVeiculoCliente.ClienteId);
                dadosVeiculo = veiculo.BuscarVeiculoByVeiculoId(dadosVeiculoCliente.VeiculoId);
                dadosMarcaVeiculo = veiculo.BuscarMarcaVeiculoByMarcaId(dadosVeiculo.MarcaId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.alteraBotoes(3);
                this.operacao = "alterar";
            }

            if (clienteId != 0)
            {
                dadosCliente = cliente.CarregaModeloCliente(clienteId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.alteraBotoes(2);
                this.operacao = "inserir";
            }
            else
            {
                this.alteraBotoes(1);
                this.operacao = "inserir";
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloVeiculo.Enabled = false;

            if (cboMarcaVeiculo.DataSource == null)
            {
                DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculo veiculo = new BLLVeiculo(conexao);
                cboMarcaVeiculo.DataSource = veiculo.BuscarMarcasVeiculo();
                cboMarcaVeiculo.DisplayMember = "Marca";
                cboMarcaVeiculo.ValueMember = "MarcaId";
            }

            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloVeiculo.Enabled = false;
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloVeiculo.Enabled = false;

            this.alteraBotoes(3);
            this.operacao = "alterar";
            txtCliente.Enabled = false;
            txtClienteId.Enabled = false;
            txtTelefoneCliente.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int veiculoId = 0;

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculoCliente bll = new BLLVeiculoCliente(cx);
                BLLVeiculo veiculo = new BLLVeiculo(cx);

                if (Convert.ToInt32(cboVeiculo.SelectedValue) == 0)
                {
                    Veiculo novoVeiculo = new Veiculo()
                    {
                        CodigoFipe = 0,
                        MarcaId = Convert.ToInt32(cboMarcaVeiculo.SelectedValue),
                        Modelo = cboVeiculo.Text,
                        VeiculoAtivo = true,
                        DataCadastro = DateTime.Now
                    };
                    try
                    {
                        veiculoId = veiculo.Incluir(novoVeiculo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HOUVE ALGUM ERRO AO CADASTRAR O VEICULO: " + Convert.ToString(ex), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                ClienteVeiculo modelo = new ClienteVeiculo
                {
                    ClienteId = Convert.ToInt32(txtClienteId.Text),
                    VeiculoId = veiculoId == 0 ? Convert.ToInt32(cboVeiculo.SelectedValue) : veiculoId,
                    CorVeiculo = txtCorVeiculo.Text,
                    PlacaVeiculo = txtPlacaVeiculo.Text,
                    KmRodados = txtKmVeiculo.Text.Length == 0 ? 0 : Convert.ToInt32(txtKmVeiculo.Text),
                    AnoVeiculo = Convert.ToInt32(txtAnoModeloVeiculo.Text)
                };

                if (this.operacao == "inserir")
                {
                    try
                    {
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro inserido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AbrirPerguntaQualItemDesejaEfetuarParaCliente(Convert.ToInt32(txtClienteId.Text), Convert.ToInt32(cboVeiculo.SelectedValue), Convert.ToString(txtPlacaVeiculo.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HOUVE ALGUM ERRO AO CADASTRAR: " + Convert.ToString(ex), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        modelo.ClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AbrirPerguntaQualItemDesejaEfetuarParaCliente(Convert.ToInt32(txtClienteId.Text), Convert.ToInt32(cboVeiculo.SelectedValue), Convert.ToString(txtPlacaVeiculo.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HOUVE ALGUM ERRO AO ALTERAR: " + Convert.ToString(ex), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
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

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            FrmConsultaClienteVeiculo c = new FrmConsultaClienteVeiculo();
            c.ShowDialog();
            if (c.codigo != 0)
            {
                this.txtClienteId.Enabled = false;
                this.txtCliente.Enabled = false;
                this.txtTelefoneCliente.Enabled = false;

                DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLVeiculo veiculo = new BLLVeiculo(conexao);
                BLLCliente cliente = new BLLCliente(conexao);
                BLLVeiculoCliente clienteVeiculos = new BLLVeiculoCliente(conexao);

                if (cboMarcaVeiculo.DataSource == null)
                {
                    cboMarcaVeiculo.DataSource = veiculo.BuscarMarcasVeiculo();
                    cboMarcaVeiculo.DisplayMember = "Marca";
                    cboMarcaVeiculo.ValueMember = "MarcaId";
                }

                if (placaVeiculo != null && placaVeiculo != "")
                {
                    ClienteVeiculo dadosVeiculoCliente = clienteVeiculos.CarregaModeloVeiculoClienteByPlaca(placaVeiculo);
                    ModeloCliente dadosCliente = cliente.CarregaModeloCliente(dadosVeiculoCliente.ClienteId);
                    Veiculo dadosVeiculo = veiculo.BuscarVeiculoByVeiculoId(dadosVeiculoCliente.VeiculoId);
                    VeiculoMarca dadosMarcaVeiculo = veiculo.BuscarMarcaVeiculoByMarcaId(dadosVeiculo.MarcaId);

                    PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                    this.alteraBotoes(2);
                    this.operacao = "alterar";
                }
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }

            c.Dispose();
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

        private void ComboBoxMarcaVeiculoAlteracaoValor(object sender, EventArgs e)
        {
            VeiculoMarca marcaVeiculo = (VeiculoMarca)cboMarcaVeiculo.SelectedItem;
            if (marcaVeiculo != null && marcaVeiculo.Marca != "Escolher Item")
            {
                this.txtAnoModeloVeiculo.Enabled = true;
            }
            else
            {
                txtAnoModeloVeiculo.Clear();
                cboVeiculo.SelectedIndex = -1;
            }
        }

        private void TextBoxAnoModeloSaidaCampo(object sender, EventArgs e)
        {
            var anoModeloFabricacao = txtAnoModeloVeiculo.Text;

            VeiculoMarca marcaVeiculo = (VeiculoMarca)cboMarcaVeiculo.SelectedItem;
            DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculo veiculo = new BLLVeiculo(conexao);

            int marcaId = Convert.ToInt32(marcaVeiculo.MarcaId);

            if (!Utils.VerificaSeEhNumero(anoModeloFabricacao))
            {
                MessageBox.Show("O Ano Modelo/Fabricação deve ser um número: ex.: 2020 ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoModeloVeiculo.Clear();
            }

            else
            {
                cboVeiculo.DataSource = veiculo.BuscarVeiculoByMarcaId(marcaId);
                cboVeiculo.DisplayMember = "Modelo";
                cboVeiculo.ValueMember = "VeiculoId";
            }
        }

        public void PreencheInformacoesNaTela(ModeloCliente cliente, ClienteVeiculo veiculoCliente, Veiculo veiculo, VeiculoMarca veiculoMarca)
        {
            if (cliente != null && cliente.CClienteId != 0)
            {
                txtClienteId.Text = cliente.CClienteId.ToString();
                txtCliente.Text = cliente.CNomeCliente.ToString();
                txtTelefoneCliente.Text = cliente.CTelefoneCelular.ToString();
            }

            if (veiculoCliente != null && veiculoCliente.ClienteVeiculoId != 0)
            {
                txtClienteVeiculoId.Text = veiculoCliente.ClienteVeiculoId.ToString();
                txtPlacaVeiculo.Text = veiculoCliente.PlacaVeiculo.ToString();
                txtKmVeiculo.Text = veiculoCliente.KmRodados.ToString();
                txtCorVeiculo.Text = veiculoCliente.CorVeiculo.ToString();
                txtAnoModeloVeiculo.Text = veiculoCliente.AnoVeiculo.ToString();
            }

            if (veiculo != null && veiculo.VeiculoId != 0)
            {
                cboMarcaVeiculo.SelectedValue = veiculoMarca.MarcaId;

                if (cboMarcaVeiculo.SelectedIndex > 0)
                {
                    DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLVeiculo veaquinho = new BLLVeiculo(conexao);
                    cboVeiculo.DataSource = veaquinho.BuscarVeiculoByMarcaId(veiculoMarca.MarcaId);
                    cboVeiculo.DisplayMember = "Modelo";
                    cboVeiculo.ValueMember = "VeiculoId";
                    cboVeiculo.SelectedValue = veiculoCliente.VeiculoId;
                }
            }

            if (veiculoMarca != null && veiculoMarca.MarcaId != 0)
            {
                cboMarcaVeiculo.DisplayMember = veiculoMarca.Marca.ToString();
            }
        }

        private void AbrirPerguntaQualItemDesejaEfetuarParaCliente(int clienteId, int veiculoId, string placaVeiculo)
        {
            FrmPerguntaQualItemAbrir questionItemAbrir = new FrmPerguntaQualItemAbrir
            {
                clienteId = clienteId,
                veiculoId = veiculoId,
                placaVeiculo = placaVeiculo
            };

            questionItemAbrir.ShowDialog();
        }

        private void cboVeiculo_Leave(object sender, EventArgs e)
        {
            txtKmVeiculo.Focus();
        }
    }
}