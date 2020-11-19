using BLL;
using DAL;
using Modelo;
using Modelo.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmGerarOrcamento : SGM.WindowsForms.FrmModeloDeFormularioDeCadastro
    {
        public FrmGerarOrcamento()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtClienteId.Clear();
            txtConsultaCliente.Clear();
            txtClienteSelecionado.Clear();
            txtDescricao.Clear();
            txtOrcamentoId.Clear();
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
            BLLOrcamento bll = new BLLOrcamento(cx);
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

        private void FrmGerarOrcamento_Load(object sender, EventArgs e)
        {
            if (clienteId != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLOrcamento bll = new BLLOrcamento(cx);
                BLLCliente modeloCliente = new BLLCliente(cx);

                var dadosCliente = modeloCliente.CarregaModeloCliente(clienteId);

                if (placaVeiculo != "" && veiculoId != 0)
                {
                    dgvCliente.DataSource = bll.LocalizarCliente(placaVeiculo);
                    dgvCliente.Columns[0].HeaderText = "Código";
                    dgvCliente.Columns[0].Width = 50;
                    dgvCliente.Columns[1].HeaderText = "Cliente";
                    dgvCliente.Columns[1].Width = 296;
                    dgvCliente.Columns[2].HeaderText = "Placa Veículo";
                    dgvCliente.Columns[2].Width = 120;
                    dgvCliente.Columns[3].HeaderText = "Marca/Modelo";
                    dgvCliente.Columns[3].Width = 232;
                }

                this.operacao = "inserir";
                this.AlteraBotoes(2);

                txtConsultaCliente.Enabled = false;
                btnConsultaCliente.Enabled = false;
                dgvCliente.Enabled = false;

                txtValorAdicional.Enabled = true;
                txtPercentualDesconto.Enabled = true;

                txtClienteId.Text = dadosCliente.CClienteId.ToString();
                txtClienteSelecionado.Text = dadosCliente.CNomeCliente.ToString();
                txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
                txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
                txtDescricao.Text = "PESQUISANDO";

                ModeloOrcamento modelo = new ModeloOrcamento
                {
                    CClienteId = Convert.ToInt32(txtClienteId.Text),
                    CStatus = "ORÇAMENTO INICIADO"
                };

                bll.IncluirOrcamento(modelo);
                txtOrcamentoId.Text = Convert.ToString(modelo.COrcamentoId);
            }
        }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // vai guardar a informação escolhida com duplo clique.
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
            this.AlteraBotoes(2);

            txtValorAdicional.Enabled = true;
            txtPercentualDesconto.Enabled = true;
            txtClienteId.Text = Convert.ToString(1);
            txtClienteSelecionado.Text = Convert.ToString("SEM CLIENTE");
            txtValorDesconto.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotal.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalMaodeObra.Text = Convert.ToDecimal("0").ToString("C");
            txtValorTotalPecas.Text = Convert.ToDecimal("0").ToString("C");
            txtDescricao.Text = "PESQUISANDO";

            ModeloOrcamento modelo = new ModeloOrcamento
            {
                CClienteId = Convert.ToInt32(txtClienteId.Text),
                CStatus = "ORÇAMENTO INICIADO"
            };

            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLOrcamento bll = new BLLOrcamento(cx);
            bll.IncluirOrcamento(modelo);
            txtOrcamentoId.Text = Convert.ToString(modelo.COrcamentoId);
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
                    BLLOrcamento bll = new BLLOrcamento(cx);

                    OrcamentoMaodeObra orcamentoMaodeObra = new OrcamentoMaodeObra()
                    {
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        MaodeObraId = consultaMaodeObra.codigo
                    };

                    bll.IncluirOrcamentoMaodeObra(orcamentoMaodeObra);

                    dgvMaodeObra.DataSource = bll.LocalizarOrcamentoMaodeObra(Convert.ToInt32(txtOrcamentoId.Text));
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
                BLLOrcamento bll = new BLLOrcamento(cx);

                OrcamentoPeca orcamentoPeca = new OrcamentoPeca()
                {
                    OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                    PecaId = consultaPeca.codigo
                };

                bll.IncluirOrcamentoPeca(orcamentoPeca);

                dgvPeca.DataSource = bll.LocalizarOrcamentoPeca(Convert.ToInt32(txtOrcamentoId.Text));

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
                ModeloOrcamento modelo = new ModeloOrcamento
                {
                    COrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                    CClienteId = Convert.ToInt32(txtClienteId.Text),
                    CValorAdicional = txtValorAdicional.Text == "" ? 0 : Convert.ToDecimal(txtValorAdicional.Text.Replace("R$ ", "")),
                    CPercentualDesconto = txtValorAdicional.Text == "" ? 0 : (Convert.ToDecimal(txtPercentualDesconto.Text.Replace("%", "")) / 100),
                    CValorDesconto = Convert.ToDecimal(txtValorDesconto.Text.Replace("R$ ", "")),
                    CValorTotal = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")),
                    CDescricao = txtDescricao.Text,
                    CStatus = "ORÇAMENTO GERADO"
                };

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLOrcamento bll = new BLLOrcamento(cx);

                bll.AlterarOrcamento(modelo);
                MessageBox.Show("Cadastro alterado com sucesso! Número do Orçamento: " + modelo.COrcamentoId.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvCliente.DataSource = null;
                dgvMaodeObra.DataSource = null;
                dgvPeca.DataSource = null;
                this.LimpaTela();
                this.AlteraBotoes(1);
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
            decimal PDesc = Convert.ToDecimal(txtPercentualDesconto.Text.Replace("%", ""));
            decimal VTota = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
            decimal VDesc = Convert.ToDecimal(txtValorDesconto.Text.Replace("R$ ", ""));
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
            this.AlteraBotoes(1);
            this.LimpaTela();
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaHistoricoOrcamentoClienteVeiculo consultaHistoricoOrcamento = new frmConsultaHistoricoOrcamentoClienteVeiculo();
            consultaHistoricoOrcamento.ShowDialog();
            if (consultaHistoricoOrcamento.codigo != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLOrcamento bll = new BLLOrcamento(cx);

                ModeloOrcamento modelo = bll.CarregaModeloOrcamento(consultaHistoricoOrcamento.codigo);

                txtOrcamentoId.Text = Convert.ToString(modelo.COrcamentoId);
                txtClienteId.Text = Convert.ToString(modelo.CClienteId);
                txtDescricao.Text = Convert.ToString(modelo.CDescricao);
                txtValorAdicional.Text = Convert.ToString(modelo.CValorAdicional);
                txtPercentualDesconto.Text = Convert.ToString(modelo.CPercentualDesconto);
                txtValorDesconto.Text = Convert.ToString(modelo.CValorDesconto);
                txtValorTotal.Text = Convert.ToString(modelo.CValorTotal);
                AlteraBotoes(3);
            }

            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }

            consultaHistoricoOrcamento.Dispose();
        }

        private void DgvMaodeObra_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maoDeObraId = Convert.ToInt32(dgvMaodeObra.Rows[e.RowIndex].Cells[0].Value);

                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLOrcamento bll = new BLLOrcamento(cx);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    OrcamentoMaodeObra orcamentoMaodeObra = new OrcamentoMaodeObra()
                    {
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        MaodeObraId = maoDeObraId
                    };


                    bll.ExcluirOrcamentoMaodeObra(orcamentoMaodeObra);

                    dgvMaodeObra.DataSource = bll.LocalizarOrcamentoMaodeObra(Convert.ToInt32(txtOrcamentoId.Text));
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
                BLLOrcamento bll = new BLLOrcamento(cx);

                DialogResult res = MessageBox.Show("Deseja realmente EXCLUIR este item?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res.ToString() == "Yes")
                {
                    OrcamentoPeca orcamentoPeca = new OrcamentoPeca()
                    {
                        OrcamentoId = Convert.ToInt32(txtOrcamentoId.Text),
                        PecaId = pecaId
                    };

                    bll.ExcluirOrcamentoPeca(orcamentoPeca);

                    dgvPeca.DataSource = bll.LocalizarOrcamentoPeca(Convert.ToInt32(txtOrcamentoId.Text));

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