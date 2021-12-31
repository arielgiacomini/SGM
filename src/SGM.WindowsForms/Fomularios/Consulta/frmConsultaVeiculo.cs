using SGM.Domain.Intern.Interfaces.Application;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SGM.WindowsForms
{
    public partial class FrmConsultaVeiculo : Form
    {
        private readonly IVeiculoApplication _veiculoApplication;
        public int codigo = 0;

        public FrmConsultaVeiculo(IVeiculoApplication veiculoApplication)
        {
            _veiculoApplication = veiculoApplication;
            InitializeComponent();
        }

        private void BtnModeloMarcaConsulta_Click(object sender, EventArgs e)
        {
            if (txtModeloMarcaConsulta.Text != "" || txtModeloMarcaConsulta.Text != null)
            {
                var listaVeiculos = _veiculoApplication.GetVeiculoByDescricaoModelo(txtModeloMarcaConsulta.Text);

                CarregaGridView(listaVeiculos);
            }
        }

        private void FrmConsultaVeiculo_Load(object sender, EventArgs e)
        {
            IList<Veiculo> veiculo = new List<Veiculo>();

            if (codigo > 0)
            {
                veiculo.Add(_veiculoApplication.GetVeiculoByVeiculoId(codigo));
            }

            CarregaGridView(veiculo);

        }

        private void dgvModeloMarcaConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvModeloMarcaConsulta.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void CarregaGridView(IList<Veiculo> veiculo)
        {
            dgvModeloMarcaConsulta.DataSource = veiculo;
            dgvModeloMarcaConsulta.Columns[0].HeaderText = "Código";
            dgvModeloMarcaConsulta.Columns[0].Width = 50;
            dgvModeloMarcaConsulta.Columns[1].HeaderText = "Marca Veículo";
            dgvModeloMarcaConsulta.Columns[1].Width = 245;
            dgvModeloMarcaConsulta.Columns[2].HeaderText = "Modelo Veículo";
            dgvModeloMarcaConsulta.Columns[2].Width = 260;
            dgvModeloMarcaConsulta.Columns[3].HeaderText = "Status";
            dgvModeloMarcaConsulta.Columns[3].Width = 65;
            dgvModeloMarcaConsulta.Columns[4].HeaderText = "Data Cadastro";
            dgvModeloMarcaConsulta.Columns[4].Width = 78;
        }
    }
}
