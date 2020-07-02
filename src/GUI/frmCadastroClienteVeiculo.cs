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
            txtAnoModeloInicial.Clear();
            txtAnoModeloFinal.Clear();
            cboVeiculo.SelectedIndex = -1;
            cboMarcaVeiculo.SelectedIndex = -1;
        }

        private void FrmCadastroClienteVeiculo_Load(object sender, EventArgs e)
        {
            this.txtClienteId.Enabled = false;
            this.txtCliente.Enabled = false;
            this.txtTelefoneCliente.Enabled = false;
            this.txtAnoModeloInicial.Enabled = false;
            this.txtAnoModeloFinal.Enabled = false;

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

            ModeloVeiculoCliente dadosVeiculoCliente = new ModeloVeiculoCliente();
            ModeloCliente dadosCliente = new ModeloCliente();
            Veiculo dadosVeiculo = new Veiculo();
            VeiculoMarca dadosMarcaVeiculo = new VeiculoMarca();


            if (placaVeiculo != null && placaVeiculo != "")
            {
                dadosVeiculoCliente = clienteVeiculos.CarregaModeloVeiculoClienteByPlaca(placaVeiculo);
                dadosCliente = cliente.CarregaModeloCliente(dadosVeiculoCliente.CClienteId);
                dadosVeiculo = veiculo.BuscarVeiculoByVeiculoId(dadosVeiculoCliente.CVeiculoId);
                dadosMarcaVeiculo = veiculo.BuscarMarcaVeiculoByMarcaId(dadosVeiculo.MarcaId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.alteraBotoes(2);
                this.operacao = "alterar";
            }

            if (clienteVeiculoId != 0)
            {
                dadosVeiculoCliente = clienteVeiculos.CarregaModeloVeiculoCliente(clienteVeiculoId);
                dadosCliente = cliente.CarregaModeloCliente(dadosVeiculoCliente.CClienteId);
                dadosVeiculo = veiculo.BuscarVeiculoByVeiculoId(dadosVeiculoCliente.CVeiculoId);
                dadosMarcaVeiculo = veiculo.BuscarMarcaVeiculoByMarcaId(dadosVeiculo.MarcaId);

                PreencheInformacoesNaTela(dadosCliente, dadosVeiculoCliente, dadosVeiculo, dadosMarcaVeiculo);

                this.alteraBotoes(2);
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
            this.txtAnoModeloInicial.Enabled = false;
            this.txtAnoModeloFinal.Enabled = false;

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
            this.txtAnoModeloInicial.Enabled = false;
            this.txtAnoModeloFinal.Enabled = false;
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.txtAnoModeloInicial.Enabled = false;
            this.txtAnoModeloFinal.Enabled = false;

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
                        AnoModeloInicial = Convert.ToInt64(txtAnoModeloInicial.Text),
                        AnoModeloFinal = Convert.ToInt64(txtAnoModeloFinal.Text),
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

                ModeloVeiculoCliente modelo = new ModeloVeiculoCliente
                {
                    CClienteId = Convert.ToInt32(txtClienteId.Text),
                    CVeiculoId = veiculoId == 0 ? Convert.ToInt32(cboVeiculo.SelectedValue) : veiculoId,
                    CCorVeiculo = txtCorVeiculo.Text,
                    CPlacaVeiculo = txtPlacaVeiculo.Text,
                    CKmRodados = txtKmVeiculo.Text.Length == 0 ? 0 : Convert.ToInt32(txtKmVeiculo.Text)
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
                        modelo.CClienteVeiculoId = Convert.ToInt32(txtClienteVeiculoId.Text);
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
                this.txtAnoModeloInicial.Enabled = true;
            }
            else
            {
                txtAnoModeloInicial.Clear();
                txtAnoModeloFinal.Clear();
                cboVeiculo.SelectedIndex = -1;
            }
        }

        private void TextBoxAnoFabricacaoSaidaCampo(object sender, EventArgs e)
        {
            if (Utils.VerificaSeEhNumero(txtAnoModeloInicial.Text))
            {
                this.txtAnoModeloFinal.Enabled = true;
                txtAnoModeloFinal.Focus();
            }
        }

        private void TextBoxAnoModeloSaidaCampo(object sender, EventArgs e)
        {
            var anoModelo = txtAnoModeloInicial.Text;
            var anoModeloFabricacao = txtAnoModeloFinal.Text;

            VeiculoMarca marcaVeiculo = (VeiculoMarca)cboMarcaVeiculo.SelectedItem;
            DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLVeiculo veiculo = new BLLVeiculo(conexao);

            int marcaId = Convert.ToInt32(marcaVeiculo.MarcaId);

            if (!Utils.VerificaSeEhNumero(anoModelo) || !Utils.VerificaSeEhNumero(anoModeloFabricacao))
            {
                MessageBox.Show("O Ano Modelo/Fabricação deve ser um número: ex.: 2020 ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoModeloInicial.Clear();
                txtAnoModeloFinal.Clear();
                txtAnoModeloInicial.Focus();
            }
            else
            {
                cboVeiculo.DataSource = veiculo.BuscarVeiculoByMarcaAnoModeloAnoFabricacao(marcaId, Convert.ToInt32(anoModelo), Convert.ToInt32(anoModeloFabricacao));
                cboVeiculo.DisplayMember = "Modelo";
                cboVeiculo.ValueMember = "VeiculoId";
            }
        }

        public void PreencheInformacoesNaTela(ModeloCliente cliente, ModeloVeiculoCliente veiculoCliente, Veiculo veiculo, VeiculoMarca veiculoMarca)
        {
            if (cliente != null && cliente.CClienteId != 0)
            {
                txtClienteId.Text = cliente.CClienteId.ToString();
                txtCliente.Text = cliente.CNomeCliente.ToString();
                txtTelefoneCliente.Text = cliente.CTelefoneCelular.ToString();
            }

            if (veiculoCliente != null && veiculoCliente.CClienteVeiculoId != 0)
            {
                txtClienteVeiculoId.Text = veiculoCliente.CClienteVeiculoId.ToString();
                txtPlacaVeiculo.Text = veiculoCliente.CPlacaVeiculo.ToString();
                txtKmVeiculo.Text = veiculoCliente.CKmRodados.ToString();
                txtCorVeiculo.Text = veiculoCliente.CCorVeiculo.ToString();
            }

            if (veiculo != null && veiculo.VeiculoId != 0)
            {
                txtAnoModeloInicial.Text = veiculo.AnoModeloInicial.ToString();
                txtAnoModeloFinal.Text = veiculo.AnoModeloFinal.ToString();
                cboMarcaVeiculo.SelectedValue = veiculoMarca.MarcaId;

                if (cboMarcaVeiculo.SelectedIndex > 0)
                {
                    DALConexao conexao = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLVeiculo veaquinho = new BLLVeiculo(conexao);
                    cboVeiculo.DataSource = veaquinho.BuscarVeiculoByMarcaId(veiculoMarca.MarcaId);
                    cboVeiculo.DisplayMember = "Modelo";
                    cboVeiculo.ValueMember = "VeiculoId";
                    cboVeiculo.SelectedValue = veiculoCliente.CVeiculoId;
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
    }
}