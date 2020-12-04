using SGM.ApplicationServices.Application.Interface;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGM.WindowsForms
{
    public partial class FrmConsultaMaoDeObra : Form
    {
        public int codigo = 0;
        private readonly IMaodeObraApplication _maoDeObraApplication;

        public FrmConsultaMaoDeObra(IMaodeObraApplication maodeObraApplication)
        {
            _maoDeObraApplication = maodeObraApplication;
            InitializeComponent();
        }

        private void BtnConsultaMaoDeObra_Click(object sender, EventArgs e)
        {
            if (txtConsultaMaoDeObra.Text != "" || txtConsultaMaoDeObra.Text != null)
            {
                var listaMaodeObra = _maoDeObraApplication.GetMaodeObraByDescricao(txtConsultaMaoDeObra.Text);

                CarregaGridView(listaMaodeObra);
            }
        }

        private void frmConsultaMaoDeObra_Load(object sender, EventArgs e)
        {
            IList<MaodeObra> maoDeObra = new List<MaodeObra>();

            if (codigo > 0)
            {
                maoDeObra.Add(_maoDeObraApplication.GetMaodeObraById(codigo));
            }

            CarregaGridView(maoDeObra);
        }

        private void dgvConsultaMaoDeObra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvConsultaMaoDeObra.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void CarregaGridView(IList<MaodeObra> maodeObra)
        {
            dgvConsultaMaoDeObra.DataSource = maodeObra;
            dgvConsultaMaoDeObra.Columns[0].HeaderText = "Código";
            dgvConsultaMaoDeObra.Columns[0].Width = 50;
            dgvConsultaMaoDeObra.Columns[1].HeaderText = "Mão-de-Obra/Serviço";
            dgvConsultaMaoDeObra.Columns[1].Width = 230;
            dgvConsultaMaoDeObra.Columns[2].HeaderText = "Tipo";
            dgvConsultaMaoDeObra.Columns[2].Width = 120;
            dgvConsultaMaoDeObra.Columns[3].HeaderText = "Valor";
            dgvConsultaMaoDeObra.Columns[3].Width = 70;
            dgvConsultaMaoDeObra.Columns[4].HeaderText = "Vigência Inicial";
            dgvConsultaMaoDeObra.Columns[4].Width = 70;
            dgvConsultaMaoDeObra.Columns[5].HeaderText = "Vigência Final";
            dgvConsultaMaoDeObra.Columns[5].Width = 70;
            dgvConsultaMaoDeObra.Columns[6].HeaderText = "Ativo";
            dgvConsultaMaoDeObra.Columns[6].Width = 45;
            dgvConsultaMaoDeObra.Columns[7].HeaderText = "Data Cadastro";
            dgvConsultaMaoDeObra.Columns[7].Width = 70;
        }
    }
}
