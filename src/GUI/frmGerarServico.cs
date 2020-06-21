using BLL;
using DAL;
using Modelo;
using Modelo.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmGerarServico : FrmModeloDeFormularioDeCadastro
    {
        public FrmGerarServico()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtClienteId.Clear();
            txtConsultaCliente.Clear();
            txtClienteSelecionado.Clear();
            txtDescricao.Clear();
            txtServicoId.Clear();
            txtPercentualDesconto.Clear();
            txtValorAdicional.Clear();
            txtValorDesconto.Clear();
            txtValorTotal.Clear();
            txtValorTotalMaodeObra.Clear();
            txtValorTotalPecas.Clear();

            for (int i = 0; i < dgvCliente.RowCount; i++)
            {
                dgvCliente.Rows[i].DataGridView.Columns.Clear();
            }

            for (int i = 0; i < dgvMaodeObra.RowCount; i++)
            {
                dgvMaodeObra.Rows[i].DataGridView.Columns.Clear();
            }

            for (int i = 0; i < dgvPeca.RowCount; i++)
            {
                dgvPeca.Rows[i].DataGridView.Columns.Clear();
            }

            lblQtdRegistrosMaoDeObra.Text = "Quantidade de Registros: ";
            lblQtdRegistrosPecas.Text = "Quantidade de Registros: ";
        }

        public int codigo = 0;
        public int clienteId = 0;
        public int veiculoId = 0;
        public string placaVeiculo = "";
        public string CellCliente = "";
        public string VerificaOrcamento = "";
        public decimal txtVA = 0;
        public decimal txtVD = 0;
        public decimal txtVP = 0;
        public decimal txtVM = 0;
        public decimal txtVT = 0;

        private void BtnConsultaCliente_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLServico bll = new BLLServico(cx);
            dgvCliente.DataSource = bll.LocalizarCliente(txtConsultaCliente.Text);
            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 50;
            dgvCliente.Columns[1].HeaderText = "Cliente";
            dgvCliente.Columns[1].Width = 296;
            dgvCliente.Columns[2].HeaderText = "Placa Veículo";
            dgvCliente.Columns[2].Width = 120;
            dgvCliente.Columns[3].HeaderText = "Marca/Modelo";
            dgvCliente.Columns[3].Width = 232;
        }

        private void FrmGerarServico_Load(object sender, EventArgs e)
        {
            if (clienteId != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);
                BLLCliente modeloCliente = new BLLCliente(cx);

                var dadosCliente = modeloCliente.CarregaModeloCliente(clienteId);

                this.operacao = "inserir";
                this.alteraBotoes(2);

                if (placaVeiculo != "" && veiculoId != 0)
                {
                    dgvCliente.DataSource = bll.LocalizarCliente(txtConsultaCliente.Text);
                    dgvCliente.Columns[0].HeaderText = "Código";
                    dgvCliente.Columns[0].Width = 50;
                    dgvCliente.Columns[1].HeaderText = "Cliente";
                    dgvCliente.Columns[1].Width = 296;
                    dgvCliente.Columns[2].HeaderText = "Placa Veículo";
                    dgvCliente.Columns[2].Width = 120;
                    dgvCliente.Columns[3].HeaderText = "Marca/Modelo";
                    dgvCliente.Columns[3].Width = 232;
                }

                txtConsultaCliente.Enabled = false;
                btnConsultaCliente.Enabled = false;
                dgvCliente.Enabled = false;

                txtValorAdicional.Enabled = true;
                txtPercentualDesconto.Enabled = true;

                txtClienteId.Text = dadosCliente.CClienteId.ToString();
                txtClienteSelecionado.Text = dadosCliente.CNomeCliente.ToString();
                txtValorAdicional.Text = Convert.ToDecimal("0").ToString("C");
                txtPercentualDesconto.Text = Convert.ToDecimal("0").ToString("P");
                txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
                txtDescricao.Text = "PESQUISANDO";

                ModeloServico modelo = new ModeloServico
                {
                    CClienteId = Convert.ToInt32(txtClienteId.Text),
                    CStatus = "SERVIÇO INICIADO"
                };


                bll.IncluirServico(modelo);
                txtServicoId.Text = Convert.ToString(modelo.CServicoId);
            }
        }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells[0].Value);
                this.CellCliente = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells[1].Value);
                txtClienteSelecionado.Text = Convert.ToString(CellCliente);
                txtClienteId.Text = Convert.ToString(codigo);
                dgvCliente.CurrentRow.Selected = false;
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtValorAdicional.Enabled = true;
            txtPercentualDesconto.Enabled = true;
            txtClienteId.Text = Convert.ToString(1);
            txtClienteSelecionado.Text = Convert.ToString("SEM CLIENTE");
            txtValorAdicional.Text = Convert.ToDecimal("0").ToString("C");
            txtPercentualDesconto.Text = Convert.ToDecimal("0").ToString("P");
            txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
            txtDescricao.Text = "";

            ModeloServico modelo = new ModeloServico
            {
                CClienteId = Convert.ToInt32(txtClienteId.Text),
                CStatus = "SERVIÇO INICIADO"
            };

            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLServico bll = new BLLServico(cx);
            bll.IncluirServico(modelo);
            txtServicoId.Text = Convert.ToString(modelo.CServicoId);
        }

        private void BtnAdicionarMaodeObra_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text == "")
            {
                MessageBox.Show("Você precisa primeiro incluir um cliente acima!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FrmConsultaMaoDeObra consultaMaodeObra = new FrmConsultaMaoDeObra();
                consultaMaodeObra.ShowDialog();

                if (consultaMaodeObra.codigo != 0)
                {
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLServico bll = new BLLServico(cx);

                    ServicoMaodeObra servicoMaodeObra = new ServicoMaodeObra()
                    {
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        MaodeObraId = consultaMaodeObra.codigo
                    };

                    bll.IncluirServicoMaodeObra(servicoMaodeObra);

                    dgvMaodeObra.DataSource = bll.LocalizarServicoMaodeObra(Convert.ToInt32(txtServicoId.Text));
                    dgvMaodeObra.Columns[0].HeaderText = "Código";
                    dgvMaodeObra.Columns[0].Width = 50;
                    dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                    dgvMaodeObra.Columns[1].Width = 330;
                    dgvMaodeObra.Columns[2].HeaderText = "Valor";
                    dgvMaodeObra.Columns[2].Width = 70;
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            lblQtdRegistrosMaoDeObra.Text = "Quantidade de Registros: " + this.dgvMaodeObra.Rows.Count.ToString();

            txtVM = Convert.ToDecimal(dgvMaodeObra.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Valor"].Value)));
            txtValorTotalMaodeObra.Text = (txtVM.ToString("C"));

            if (txtValorTotalPecas.Text.Replace("R$ 0,00", "") != "")
            {
                txtVP = Convert.ToDecimal(txtValorTotalPecas.Text.Replace("R$ ", ""));
            }

            if (txtValorAdicional.Text.Replace("R$ 0,00", "") != "")
            {
                txtVA = Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", ""));
            }

            txtVT = 0;
            txtVT = (txtVM + txtVP + txtVA);

            txtValorTotal.Text = (txtVT.ToString("C"));
        }

        private void BtnAdicionarPeca_Click(object sender, EventArgs e)
        {
            frmConsultaPeca consultaPeca = new frmConsultaPeca();
            consultaPeca.ShowDialog();

            if (consultaPeca.codigo != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);

                ServicoPeca servicoPeca = new ServicoPeca()
                {
                    ServicoId = Convert.ToInt32(txtServicoId.Text),
                    PecaId = consultaPeca.codigo
                };

                bll.IncluirServicoPeca(servicoPeca);

                dgvPeca.DataSource = bll.LocalizarServicoPeca(Convert.ToInt32(txtServicoId.Text));
                dgvPeca.Columns[0].HeaderText = "Código";
                dgvPeca.Columns[0].Width = 50;
                dgvPeca.Columns[1].HeaderText = "Peça";
                dgvPeca.Columns[1].Width = 330;
                dgvPeca.Columns[2].HeaderText = "Valor Integral";
                dgvPeca.Columns[2].Width = 70;
                dgvPeca.Columns[2].DefaultCellStyle.Format = "C2";
                dgvPeca.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            lblQtdRegistrosPecas.Text = "Quantidade de Registros: " + this.dgvPeca.Rows.Count.ToString();
            txtVP = Convert.ToDecimal(dgvPeca.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["ValorTotal"].Value)));
            txtValorTotalPecas.Text = Convert.ToString(txtVP.ToString("C"));


            if (txtValorTotalMaodeObra.Text.Replace("R$ 0,00", "") != "")
            {
                txtVM = Convert.ToDecimal(txtValorTotalMaodeObra.Text.Replace("R$ ", ""));
            }

            if (txtValorAdicional.Text.Replace("R$ 0,00", "") != "")
            {
                txtVA = Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", ""));
            }

            txtVT = 0;
            txtVT = (txtVM + txtVP + txtVA);

            txtValorTotal.Text = (txtVT.ToString("C"));
        }

        private void DgvMaodeObra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvMaodeObra.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void DgvPeca_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvPeca.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloServico modelo = new ModeloServico();
                modelo.CServicoId = Convert.ToInt32(txtServicoId.Text);
                modelo.CClienteId = Convert.ToInt32(txtClienteId.Text);
                modelo.CValorAdicional = Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", ""));
                modelo.CPercentualDesconto = (Convert.ToDecimal(txtPercentualDesconto.Text.Replace("%", "")) / 100);
                modelo.CValorDesconto = Convert.ToDecimal(txtValorDesconto.Text.Replace("R$ ", ""));
                modelo.CValorTotal = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                modelo.CDescricao = txtDescricao.Text;
                modelo.CStatus = "SERVIÇO GERADO";

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);

                bll.AlterarServico(modelo);
                MessageBox.Show("Cadastro alterado com sucesso! Número da Ordem de Serviço: " + modelo.CServicoId.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvCliente.DataSource = null;
                dgvMaodeObra.DataSource = null;
                dgvPeca.DataSource = null;

                this.LimpaTela();
                this.alteraBotoes(1);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void TxtValorAdicional_Leave(object sender, EventArgs e)
        {
            if (txtValorTotalMaodeObra.Text.Replace("R$ 0,00", "") != "")
            {
                txtVM = Convert.ToDecimal(txtValorTotalMaodeObra.Text.Replace("R$ ", ""));
            }

            if (txtValorTotalPecas.Text.Replace("R$ 0,00", "") != "")
            {
                txtVP = Convert.ToDecimal(txtValorTotalPecas.Text.Replace("R$ ", ""));
            }

            if (txtValorAdicional.Text.Replace("R$ 0,00", "") != "")
            {
                txtVA = Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", ""));
            }

            txtValorAdicional.Text = (txtVA.ToString("C"));

            txtVT = 0;
            txtVT = (txtVM + txtVP + txtVA);

            txtValorTotal.Text = (txtVT.ToString("C"));


            DialogResult res = MessageBox.Show("Deseja realmente incluir esse adicional de: " + txtValorAdicional.Text, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res.ToString() == "Yes")
            {
                txtValorAdicional.Enabled = false;
            }
        }

        private void TxtPercentualDesconto_Leave(object sender, EventArgs e)
        {
            Decimal PDesc = Convert.ToDecimal(txtPercentualDesconto.Text.Replace("%", ""));
            Decimal VTota = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
            Decimal VDesc = Convert.ToDecimal(txtValorDesconto.Text.Replace("R$ ", ""));
            txtValorDesconto.Text = Convert.ToString(Convert.ToDecimal(((VTota / 100) * PDesc)).ToString("C"));
            VDesc = Convert.ToDecimal((VTota / 100) * PDesc);
            txtValorTotal.Text = Convert.ToString((VTota - VDesc).ToString("C"));
            txtPercentualDesconto.Text = Convert.ToString(Convert.ToDecimal(PDesc / 100).ToString("P"));

            if (PDesc != 0)
            {
                txtPercentualDesconto.Enabled = false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.operacao = "cancelar";
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            Close();
            FrmConsultaHistoricoServicoClienteVeiculo consultaHistoricoServico = new FrmConsultaHistoricoServicoClienteVeiculo();
            consultaHistoricoServico.ShowDialog();
            if (consultaHistoricoServico.codigo != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);

                ModeloServico modelo = bll.BuscarDetalheServicoGerado(consultaHistoricoServico.codigo);

                txtServicoId.Text = Convert.ToString(modelo.CServicoId);
                txtClienteId.Text = Convert.ToString(modelo.CClienteId);
                txtDescricao.Text = Convert.ToString(modelo.CDescricao);
                txtValorAdicional.Text = Convert.ToString(modelo.CValorAdicional);
                txtPercentualDesconto.Text = Convert.ToString(modelo.CPercentualDesconto);
                txtValorDesconto.Text = Convert.ToString(modelo.CValorDesconto);
                txtValorTotal.Text = Convert.ToString(modelo.CValorTotal);
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }

            consultaHistoricoServico.Dispose();
        }

        private void DgvMaodeObra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maoDeObraId = Convert.ToInt32(dgvMaodeObra.Rows[e.RowIndex].Cells[0].Value);

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {

                    ServicoMaodeObra servicoMaodeObra = new ServicoMaodeObra()
                    {
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        MaodeObraId = maoDeObraId
                    };

                    bll.ExcluirServicoMaodeObra(servicoMaodeObra);

                    dgvMaodeObra.DataSource = bll.LocalizarServicoMaodeObra(Convert.ToInt32(txtServicoId.Text));
                    dgvMaodeObra.Columns[0].HeaderText = "Código";
                    dgvMaodeObra.Columns[0].Width = 50;
                    dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                    dgvMaodeObra.Columns[1].Width = 330;
                    dgvMaodeObra.Columns[2].HeaderText = "Valor";
                    dgvMaodeObra.Columns[2].Width = 70;
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvMaodeObra.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void DgvPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int pecaId = Convert.ToInt32(dgvPeca.Rows[e.RowIndex].Cells[0].Value);

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    ServicoPeca servicoPeca = new ServicoPeca()
                    {
                        ServicoId = Convert.ToInt32(txtServicoId.Text),
                        PecaId = pecaId
                    };

                    bll.ExcluirServicoPeca(servicoPeca);

                    dgvPeca.DataSource = bll.LocalizarServicoPeca(Convert.ToInt32(txtServicoId.Text));
                    dgvPeca.Columns[0].HeaderText = "Código";
                    dgvPeca.Columns[0].Width = 50;
                    dgvPeca.Columns[1].HeaderText = "Peça";
                    dgvPeca.Columns[1].Width = 330;
                    dgvPeca.Columns[2].HeaderText = "Valor Integral";
                    dgvPeca.Columns[2].Width = 70;
                    dgvPeca.Columns[2].DefaultCellStyle.Format = "C2";
                    dgvPeca.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }
    }
}
