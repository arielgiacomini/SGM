using BLL;
using DAL;
using Modelo;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmGerarServico : GUI.FrmModeloDeFormularioDeCadastro
    {
        public frmGerarServico()
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
        public String CellCliente = "";
        public String VerificaOrcamento = "";
        public decimal txtVA = 0;
        public decimal txtVD = 0;
        public decimal txtVP = 0;
        public decimal txtVM = 0;
        public decimal txtVT = 0;

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
            BLLServico bll = new BLLServico(cx);
            dgvCliente.DataSource = bll.LocalizarCliente(txtConsultaCliente.Text);
            dgvCliente.Columns[0].HeaderText = "Código";
            dgvCliente.Columns[0].Width = 50;
            dgvCliente.Columns[1].HeaderText = "Cliente";
            dgvCliente.Columns[1].Width = 296;
            dgvCliente.Columns[2].HeaderText = "CPF";
            dgvCliente.Columns[2].Width = 90;
            dgvCliente.Columns[3].HeaderText = "Sexo";
            dgvCliente.Columns[3].Width = 80;
            dgvCliente.Columns[4].HeaderText = "E-mail";
            dgvCliente.Columns[4].Width = 182;
        }

        private void frmGerarServico_Load(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                FrmConsultaMaoDeObra r = new FrmConsultaMaoDeObra();
                r.ShowDialog();

                if (r.codigo != 0)
                {
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLServico bll = new BLLServico(cx);
                    dgvOcultoGuardaInformacao.DataSource = bll.LocalizarMaodeObra(r.codigo);
                    dgvMaodeObra.DataSource = bll.LocalizarServicoMaodeObra(Convert.ToInt32(txtServicoId.Text));
                    dgvMaodeObra.Columns[0].HeaderText = "Código";
                    dgvMaodeObra.Columns[0].Width = 50;
                    dgvMaodeObra.Columns[1].HeaderText = "Mão de Obra";
                    dgvMaodeObra.Columns[1].Width = 330;
                    dgvMaodeObra.Columns[2].HeaderText = "Valor";
                    dgvMaodeObra.Columns[2].Width = 70;
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
            frmConsultaPeca p = new frmConsultaPeca();
            p.ShowDialog();

            if (p.codigo != 0)
            {
                DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                BLLServico bll = new BLLServico(cx);
                dgvOcultoInformacaoPecas.DataSource = bll.LocalizarPeca(p.codigo);
                dgvPeca.DataSource = bll.LocalizarServicoPeca(Convert.ToInt32(txtServicoId.Text));
                dgvPeca.Columns[0].HeaderText = "Código";
                dgvPeca.Columns[0].Width = 50;
                dgvPeca.Columns[1].HeaderText = "Peça";
                dgvPeca.Columns[1].Width = 330;
                dgvPeca.Columns[2].HeaderText = "Valor Integral";
                dgvPeca.Columns[2].Width = 70;
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

        /* GriewView OCULTO DA MÃO DE OBRA - PARA GUARDAR INFORMAÇÃO MOMENTANEA ATÉ INSERIR NA TABELA */
        private void dgvOcultoGuardaInformacao_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvOcultoGuardaInformacao.Rows[e.RowIndex].Cells[0].Value) != 0)
                {
                    ModeloServico modelo = new ModeloServico();
                    modelo.CServicoId = Convert.ToInt32(txtServicoId.Text);
                    modelo.CMaodeObraId = Convert.ToInt32(dgvOcultoGuardaInformacao.Rows[e.RowIndex].Cells["MaodeObraId"].Value);
                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLServico bll = new BLLServico(cx);
                    bll.IncluirServicoMaodeObra(modelo);
                }
            }
        }

        private void DgvMaodeObra_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvMaodeObra.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        /* GriewView OCULTO DE PEÇAS - PARA GUARDAR INFORMAÇÃO MOMENTANEA ATÉ INSERIR NA TABELA */
        private void DgvOcultoInformacaoPecas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvOcultoInformacaoPecas.Rows[e.RowIndex].Cells[0].Value) != 0)
                {
                    ModeloServico modelo = new ModeloServico
                    {
                        CServicoId = Convert.ToInt32(txtServicoId.Text),
                        CPecaId = Convert.ToInt32(dgvOcultoInformacaoPecas.Rows[e.RowIndex].Cells["PecaId"].Value)
                    };

                    DALConexao cx = new DALConexao(ConnectionStringConfiguration.ConnectionString);
                    BLLServico bll = new BLLServico(cx);
                    bll.IncluirServicoPeca(modelo);
                }
            }
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
                dgvOcultoGuardaInformacao.DataSource = null;
                dgvOcultoInformacaoPecas.DataSource = null;

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
    }
}
